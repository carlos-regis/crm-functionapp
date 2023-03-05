using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
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
            CrmServiceClient service = null;
            try
            {
                CrmConnection crmConnection = new CrmConnection(log);
                service = crmConnection.Connect("crmConnectionString");

                log.Info(string.Format("Microsoft Dynamics CRM version {0}.", Common.GetVersion(service)));
                log.Info(string.Format("Organization Id: {0}.", service.ConnectedOrgId));
                log.Info(string.Format("Logged on user is {0}.", Common.GetUserFullName(service)));

            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0} - service connection: {1}.", nameof(AccountPlugin), ex.ToString()));
                service?.Dispose();

                return req.CreateResponse(HttpStatusCode.NotFound);
            }

            try
            {
                string jsonContent = await req.Content.ReadAsStringAsync();
                log.Info(string.Format("Webhook context: {0}", jsonContent));

                FunctionProcess.ProcessContext(log, Common.GetContext(log, jsonContent), service);
                return req.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0} - context processing: {1}.", nameof(AccountPlugin), ex.ToString()));
                return req.CreateResponse(HttpStatusCode.BadRequest);
            }
            finally
            {
                service?.Dispose();
            }
        }
    }
}

