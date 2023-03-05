using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Configuration;

namespace Ttms.Crm.ConsoleApp
{
    public static class Program
    {
        static void Main(string[] _)
        {

            CrmServiceClient service = null;
            try
            {
                service = Connect();

                Entity account = new Entity("account");
                account["name"] = "My New Account";

                Console.WriteLine("Creating new account...");
                service.Create(account);
                Console.WriteLine("New account successfully created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: {0}.", ex.ToString()));
                throw;
            }
            finally
            {
                service?.Dispose();

                Console.WriteLine("\nPress <Enter> to exit.");
                Console.ReadLine();
            }
        }

        private static CrmServiceClient Connect()
        {
            CrmServiceClient service;
            try
            {
                Console.WriteLine("Setting up Dynamics 365 connection");

                service = new CrmServiceClient(ConfigurationManager.ConnectionStrings["crmConnectionString"].ConnectionString);

                Console.WriteLine("Validating Connection");

                if (service.IsReady)
                {
                    Guid userid = ((WhoAmIResponse)service.Execute(new WhoAmIRequest())).UserId;

                    if (userid != Guid.Empty)
                    {
                        Console.WriteLine(string.Format("User '{0}' connected successfully!", userid));
                        return service;
                    }
                }
                else
                {
                    Console.WriteLine(string.Format("{0}", service.LastCrmError));
                    throw service.LastCrmException;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("{0}", ex.ToString()));
                throw;
            }

            return service;
        }
    }
}

