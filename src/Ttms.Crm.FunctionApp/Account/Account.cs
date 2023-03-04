using Microsoft.Azure.WebJobs.Host;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.ServiceModel;

namespace Ttms.Crm.FunctionApp.Account
{
    internal static class Account
    {
        internal static void PostAccountUpdate(TraceWriter log, RemoteExecutionContext context, CrmServiceClient crmServiceClient)
        {
            log.Info("Calling PostAccountUpdate...");

            try
            {
                Entity entity = (Entity)context.InputParameters["Target"];

                if (entity.Attributes.Contains("address1_country") && entity.Attributes["address1_country"] != null)
                {
                    Entity account = new Entity("account")
                    {
                        Id = entity.Id
                    };

                    account["name"] = entity.GetAttributeValue<string>("address1_country");

                    crmServiceClient.Update(account);
                    log.Info("PostAccountUpdate completed!");
                }
                else
                {
                    log.Error("No 'address1_country' in the current context");
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                log.Error(string.Format("PostAccountUpdate: {0}", ex.ToString()));
            }
            catch (Exception ex)
            {
                log.Error(string.Format("PostAccountUpdate: {0}", ex.ToString()));
            }
        }
    }
}

