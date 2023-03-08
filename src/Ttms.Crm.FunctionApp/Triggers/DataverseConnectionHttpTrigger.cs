using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Helpers;
using Ttms.Crm.FunctionApp.Services.Contracts;

namespace Ttms.Crm.FunctionApp.Triggers
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
                log.LogInformation("Microsoft Dynamics CRM version {Version}.", _crmService.GetVersion());
                log.LogInformation("Logged on user is {FullName}.", _crmService.GetUserFullName());

                string jsonContext = await req.ReadAsStringAsync();
                log.LogInformation("{jsonContext}", jsonContext);

                FunctionProcess.ProcessContext(log, CrmUtils.GetContext(jsonContext), _crmService);

                return new OkObjectResult("Success");
            }
            catch (Exception ex)
            {
                log.LogError("{Function}: Could not connect to the organization service - {Exception}.", nameof(DataverseConnectionHttpTrigger), ex.ToString());
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
