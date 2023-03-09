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
                string jsonContext = await req.ReadAsStringAsync();
                log.LogInformation("{jsonContext}", jsonContext);

                _context = CrmUtils.GetContext(jsonContext);
                log.LogInformation("{Context}", _context);

                if (!CrmUtils.ValidateContext(_context, log))
                {
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
    }
}
