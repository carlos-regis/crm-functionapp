using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Helpers;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public class AccountCreateOrUpdateHttpTrigger
    {
        [FunctionName(nameof(AccountCreateOrUpdateHttpTrigger))]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req, ILogger _logger)
        {
            // get the context from D365
            string jsonContext = await req.ReadAsStringAsync();
            _logger.LogInformation("{jsonContext}", jsonContext);

            RemoteExecutionContext dataverseContext = Common.GetContext(_logger, jsonContext);
            _logger.LogInformation("Received: {MessageName}.", dataverseContext.MessageName);

            Entity updatedAccount = (Entity)dataverseContext.InputParameters["Target"];
            _logger.LogInformation("{LogicalName}: {Id}.", updatedAccount.LogicalName, updatedAccount.Id);

            return new OkObjectResult(string.Format("Account id: {0}", updatedAccount.Id));
        }
    }
}
