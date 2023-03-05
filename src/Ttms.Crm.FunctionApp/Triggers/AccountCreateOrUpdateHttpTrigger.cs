using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System;
using System.Net;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Helper;

namespace Ttms.Crm.FunctionApp.Triggers
{
    public class AccountCreateOrUpdateHttpTrigger
    {
        private readonly ILogger _logger;

        public AccountCreateOrUpdateHttpTrigger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<PocHttpTrigger>() ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        [Function(nameof(AccountCreateOrUpdateHttpTrigger))]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req)
        {
            // get the context from D365
            string jsonContext = await req.ReadAsStringAsync();
            _logger.LogInformation(jsonContext);

            RemoteExecutionContext dataverseContext = Common.GetContext(_logger, jsonContext);
            _logger.LogInformation(string.Format("Received: {0}.", dataverseContext.MessageName));

            Entity updatedAccount = (Entity)dataverseContext.InputParameters["Target"];
            _logger.LogInformation(string.Format("{0}: {1}.", updatedAccount.LogicalName, updatedAccount.Id));

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}

