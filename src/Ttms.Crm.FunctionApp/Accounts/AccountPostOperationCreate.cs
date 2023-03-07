using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;
using System.ServiceModel;

namespace Ttms.Crm.FunctionApp.Accounts
{
    internal static class AccountPostOperationCreate
    {
        internal static void PostAccountUpdate(ILogger log, RemoteExecutionContext context, ServiceClient service)
        {
            log.LogInformation(string.Format("Calling {0}...", nameof(PostAccountUpdate)));

            try
            {
                Entity entity = (Entity)context.InputParameters["Target"];
                if (entity.Attributes.Contains("address1_country") && entity.GetAttributeValue<string>("address1_country") != null)
                {
                    Entity account = new("account")
                    {
                        Id = entity.Id
                    };

                    account["name"] = entity.GetAttributeValue<string>("address1_country");

                    service.Update(account);
                    log.LogInformation(string.Format("{0} completed.", nameof(PostAccountUpdate)));
                }
                else
                {
                    log.LogWarning("No 'address1_country' in the current context");
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                log.LogError(string.Format("{0}: {1}.", nameof(PostAccountUpdate), ex.ToString()));
                throw;
            }
            catch (Exception ex)
            {
                log.LogError(string.Format("{0}: {1}.", nameof(PostAccountUpdate), ex.ToString()));
                throw;
            }
        }
    }
}
