using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Common;
using Ttms.Crm.FunctionApp.Domain.Models;
using Ttms.Crm.FunctionApp.Domain.Services.Contracts;

namespace Ttms.Crm.FunctionApp.Triggers.Demo
{
    public class DataverseConnectionHttpTrigger
    {
        private readonly ICrmService _crmService;

        public DataverseConnectionHttpTrigger(ICrmService crmService)
        {
            _crmService = crmService ?? throw new ArgumentNullException(nameof(crmService));
        }

        [FunctionName(nameof(DataverseConnectionHttpTrigger))]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            log.LogInformation("The {Function} function processed a request.", nameof(DataverseConnectionHttpTrigger));

            try
            {
                string crmVersion = await _crmService.GetVersionAsync();
                string userFullName = await _crmService.GetUserFullNameAsync();

                log.LogInformation("Microsoft Dynamics CRM version {Version}.", crmVersion);
                log.LogInformation("Logged on user is {FullName}.", userFullName);

                return new JsonResult(new CrmSystemResponse()
                {
                    Version = crmVersion,
                    UserFullName = userFullName
                })
                {
                    StatusCode = (int)HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: Could not connect to the organization service - {Exception}.", nameof(DataverseConnectionHttpTrigger), ex.ToString());
                return new JsonResult(OperationResult.ExceptionResult(ex))
                {
                    StatusCode = (int)HttpStatusCode.Unauthorized
                };
            }
        }
    }
}
