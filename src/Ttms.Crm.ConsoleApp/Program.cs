using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Configuration;
using System.Diagnostics;

namespace Ttms.Crm.ConsoleApp
{
    public static class Program
    {
        static void Main(string[] _)
        {
            IOrganizationService crmService = CrmConnection();

            Entity account = new Entity("account");
            account["name"] = "My New Account";

            Console.WriteLine("Creating new account");
            crmService.Create(account);

            Console.ReadKey();
        }

        private static IOrganizationService CrmConnection()
        {
            IOrganizationService crmService = null;

            try
            {
                Console.WriteLine("Setting up Dynamics 365 connection");

                CrmServiceClient crmConnection = new CrmServiceClient(ConfigurationManager.ConnectionStrings["crmConnectionString"].ConnectionString);

                crmService = crmConnection.OrganizationWebProxyClient != null ?
                                    (IOrganizationService)crmConnection.OrganizationWebProxyClient :
                                    (IOrganizationService)crmConnection.OrganizationServiceProxy;

                Console.WriteLine("Validating Connection");

                if (crmService != null)
                {
                    Guid userid = ((WhoAmIResponse)crmService.Execute(new WhoAmIRequest())).UserId;

                    if (userid != Guid.Empty)
                    {
                        Console.WriteLine($"Information: {userid} connected successfully!");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: Failed to Established Connection!");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: Exception caught - {ex.Message}");
            }

            return crmService;
        }
    }
}
