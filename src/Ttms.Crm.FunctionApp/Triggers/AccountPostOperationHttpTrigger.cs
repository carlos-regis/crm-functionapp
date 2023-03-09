using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System;
using System.Net;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Common;
using Ttms.Crm.FunctionApp.Domain.Helpers;
using Ttms.Crm.FunctionApp.Domain.Services.Contracts;
using Ttms.Crm.FunctionApp.Shared;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public class AccountPostOperationHttpTrigger
    {
        private readonly ICrmService _crmService;
        private RemoteExecutionContext _context;

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
                                              out Entity postImage))
                {
                    PerformBusinessLogic(_context.Mode, entity, postImage);

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
                                                       Entity entity,
                                                       Entity postImage)
        {
            try
            {
                if (contextMode == (int)SdkMessageProcessingStepMode.Asynchronous)
                {
                    //
                }
                else
                {
                    //
                }
            }
            catch (Exception ex)
            {
                //
            }
        }
    }
}
