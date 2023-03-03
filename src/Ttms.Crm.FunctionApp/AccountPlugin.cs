using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Helper;

namespace Ttms.Crm.FunctionApp
{
    public static class AccountPlugin
    {
        [FunctionName("AccountPlugin")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequestMessage req, TraceWriter log)
        {
            log.Info("D365 webhook was triggered!");

            CrmServiceClient crmServiceClient;

            try
            {
                crmServiceClient = Common.ConnectionCrmServiceClient(log);
                if (crmServiceClient is null)
                {
                    throw new InvalidOperationException("Failed to Established Connection!");
                }
            }
            catch (Exception ex)
            {
                log.Error($"Exception: {ex.Message}");
                return req.CreateResponse(HttpStatusCode.BadGateway);
            }

            string jsonContent = await req.Content.ReadAsStringAsync();
            log.Info(jsonContent);

            //RemoteExecutionContext remoteExecutionContext = Common.GetD365Context(log, jsonContent);
            //FunctionProcess.ProcessContext(log, remoteExecutionContext, crmServiceClient);

            Entity account = new Entity("account");
            account["name"] = $"Azure function account #{new Random().Next(1, 100)}";

            log.Info("Creating new account");
            crmServiceClient.Create(account);
            log.Info("Account successfully created");

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
