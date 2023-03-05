using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.ServiceModel;

namespace Ttms.Crm.FunctionApp.Account
{
    internal static class Account
    {
        internal static void PostAccountUpdate(ILogger _logger, RemoteExecutionContext context, CrmServiceClient service)
        {
            _logger.LogInformation(string.Format("Calling {0}...", nameof(PostAccountUpdate)));

            try
            {
                Entity entity = (Entity)context.InputParameters["Target"];
                if (entity.Attributes.Contains("address1_country") && entity.GetAttributeValue<string>("address1_country") != null)
                {
                    Entity account = new Entity("account")
                    {
                        Id = entity.Id
                    };

                    account["name"] = entity.GetAttributeValue<string>("address1_country");

                    service.Update(account);
                    _logger.LogInformation(string.Format("{0} completed.", nameof(PostAccountUpdate)));
                }
                else
                {
                    _logger.LogWarning("No 'address1_country' in the current context");
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                _logger.LogError(string.Format("{0}: {1}.", nameof(PostAccountUpdate), ex.ToString()));
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Format("{0}: {1}.", nameof(PostAccountUpdate), ex.ToString()));
                throw;
            }
        }
    }
}

