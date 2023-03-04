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
            log.Info("Webhook triggered!");

            CrmServiceClient crmServiceClient;

            try
            {
                CrmConnection crmConnection = new CrmConnection(log);
                crmServiceClient = crmConnection.Run();
            }
            catch (Exception ex)
            {
                log.Error(string.Format("AccountPlugin - service connection: {0}", ex.Message));
                return req.CreateResponse(HttpStatusCode.BadGateway);
            }

            string jsonContent = await req.Content.ReadAsStringAsync();
            log.Info(string.Format("Webhook context: {0}", jsonContent));

            try
            {
                RemoteExecutionContext remoteExecutionContext = Common.GetD365Context(log, jsonContent);
                FunctionProcess.ProcessContext(log, remoteExecutionContext, crmServiceClient);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("AccountPlugin - context processing: {0}", ex.Message));
                return req.CreateResponse(HttpStatusCode.BadRequest);
            }
            finally
            {
                // Always dispose the service object to close the service connection and free resources.
                crmServiceClient?.Dispose();
            }

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
