using Microsoft.Azure.WebJobs.Host;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.ServiceModel;

namespace Ttms.Crm.FunctionApp.Account
{
    internal static class Account
    {
        internal static void PostAccountUpdate(TraceWriter log, RemoteExecutionContext context, CrmServiceClient service)
        {
            log.Info(string.Format("Calling {0}...", nameof(PostAccountUpdate)));

            try
            {
                Entity entity = (Entity)context.InputParameters["Target"];

                if (entity.Attributes.Contains("address1_country") && entity.Attributes["address1_country"] != null)
                {
                    Entity account = new Entity("account")
                    {
                        Id = entity.Id
                    };

                    log.Info(string.Format("{0}: entity name '{1}'.", nameof(PostAccountUpdate), entity.GetAttributeValue<string>("name")));
                    account["name"] = string.Format("{0} from {1}",
                                                    entity.GetAttributeValue<string>("name"),
                                                    entity.GetAttributeValue<string>("address1_country"));

                    service.Update(account);
                    log.Info(string.Format("{0} completed.", nameof(PostAccountUpdate)));
                }
                else
                {
                    log.Warning("No 'address1_country' in the current context");
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                log.Error(string.Format("{0}: {1}.", nameof(PostAccountUpdate), ex.ToString()));
                throw;
            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0}: {1}.", nameof(PostAccountUpdate), ex.ToString()));
                throw;
            }
        }
    }
}

