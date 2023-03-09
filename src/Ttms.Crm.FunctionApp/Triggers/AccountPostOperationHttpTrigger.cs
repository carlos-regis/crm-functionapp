using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Net;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Common;
using Ttms.Crm.FunctionApp.Domain.Helpers;
using Ttms.Crm.FunctionApp.Domain.Services.Contracts;
using Ttms.Crm.FunctionApp.Shared;
using Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Events.PostOperation;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public class AccountPostOperationHttpTrigger
    {
        private readonly ICrmService _crmService;

        public AccountPostOperationHttpTrigger(ICrmService crmService)
        {
            _crmService = crmService ?? throw new ArgumentNullException(nameof(crmService));
        }

        [FunctionName(nameof(AccountPostOperationHttpTrigger))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            RemoteExecutionContext _context;
            log.LogInformation("The {Function} function processed a request.", nameof(AccountPostOperationHttpTrigger));

            try
            {
                string requestBody = await req.ReadAsStringAsync();
                log.LogInformation("{requestBody }", requestBody);

                _context = CrmUtils.GetRemoteExecutionContextFromJson(requestBody);
                log.LogInformation("{Context}", _context);


                if (!CrmUtils.ValidateContext(_context,
                                              Account.EntityLogicalName,
                                              log,
                                              out Entity entity,
                                              out Entity preImage,
                                              out Entity postImage))
                {
                    PerformPostOperationAccountLogic(_context.Mode, log, entity, preImage, postImage);

                    return new JsonResult(OperationResult.FailureResult("Invalid context received."))
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }

                return new JsonResult(OperationResult.SuccessResult())
                {
                    StatusCode = (int)HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: Bad request - {Exception}.", nameof(AccountPostOperationHttpTrigger), ex.ToString());
                return new JsonResult(OperationResult.ExceptionResult(ex))
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
        }

        internal void PerformPostOperationAccountLogic(int contextMode,
                                                       ILogger log,
                                                       Entity entity,
                                                       Entity preImage,
                                                       Entity postImage)
        {
            CrmContext crmContext = (CrmContext)(new OrganizationServiceContext(_crmService.GetOrganizationService()));

            try
            {
                log.LogInformation("AccountPostOperation --> Started");

                if (contextMode == (int)SdkMessageProcessingStepMode.Asynchronous)
                {
                    log.LogInformation("PostOperationAccountLogicAsync --> Started");

                    PostOperationAccountLogicAsync postOpAccountLogicAsync = new(log, entity, preImage, crmContext);
                    postOpAccountLogicAsync.ValidateAndExecute();

                    log.LogInformation("PostOperationAccountLogicAsync --> Ended");
                }
                else
                {
                    log.LogInformation("PostOperationAccountLogicSync --> Started");

                    PostOperationAccountLogicSync postOpAccountLogicSync = new(log, entity, preImage, postImage, crmContext);
                    postOpAccountLogicSync.ValidateAndExecute();

                    log.LogInformation("PostOperationAccountLogicSync --> Ended");
                }
                log.LogInformation("AccountPostOperation --> Ended");
            }
            catch (InvalidPluginExecutionException ex)
            {
                log.LogError(ex.Message);
                throw new InvalidPluginExecutionException(ex.Message);
            }
        }
    }
}
