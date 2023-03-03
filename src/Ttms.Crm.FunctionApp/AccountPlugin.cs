using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Ttms.Crm.FunctionApp
{
    public static class AccountPlugin
    {
        [FunctionName("AccountPlugin")]
        public static async Task<HttpResponseMessage> RunAsync([HttpTrigger(AuthorizationLevel.Function, "POST", Route = null)] HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string jsonContent = await req.Content.ReadAsStringAsync();
            log.Info($"{jsonContent}");

            try
            {
                IOrganizationService crmService = CrmConnection(log);

                Entity account = new Entity("account");
                account["name"] = $"Azure function account #{new Random().Next(1, 100)}";

                log.Info("Creating new account");
                crmService.Create(account);
                log.Info("Account successfully created");
            }
            catch (Exception ex)
            {
                log.Error($"Exception: {ex.Message}");
            }

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
        }

        private static IOrganizationService CrmConnection(TraceWriter log)
        {
            IOrganizationService crmService = null;

            try
            {
                log.Info("Setting up Dynamics 365 connection");

                ClientCredentials clientCredentials = new ClientCredentials();
                clientCredentials.UserName.UserName = Environment.GetEnvironmentVariable("CredentialUserName");
                clientCredentials.UserName.Password = Environment.GetEnvironmentVariable("CredentialPassword");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                OrganizationServiceProxy organizationServiceProxy = new OrganizationServiceProxy(new Uri(Environment.GetEnvironmentVariable("crmOrgService")), null, clientCredentials, null)
                {
                    Timeout = new TimeSpan(0, 10, 0)
                };

                crmService = (IOrganizationService)organizationServiceProxy;

                log.Info("Validating Connection");

                if (crmService is object)
                {
                    Guid userid = ((WhoAmIResponse)crmService.Execute(new WhoAmIRequest())).UserId;

                    if (!userid.Equals(Guid.Empty))
                    {
                        log.Info($"User '{userid}' connected successfully established!");
                    }
                }
                else
                {
                    log.Error("Failed to Established Connection!");
                }

            }
            catch (Exception ex)
            {
                log.Error($"Exception: {ex.Message}");
            }

            return crmService;
        }
    }
}
