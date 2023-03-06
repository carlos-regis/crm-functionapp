using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;
using System.ServiceModel;

namespace Ttms.Crm.FunctionApp.V4.Helpers
{
    internal static class FunctionProcess
    {
        internal static void ProcessContext(ILogger _logger, RemoteExecutionContext context, ServiceClient service)
        {
            _logger.LogInformation(string.Format("Calling {0}...", nameof(ProcessContext)));

            try
            {
                _logger.LogInformation(string.Format("Received: {0}", context.MessageName));

                Entity entity = (Entity)context.InputParameters["Target"];
                var entityName = entity.LogicalName;

                switch (entityName.ToLower())
                {
                    case "account":
                        Account.Account.PostAccountUpdate(_logger, context, service);
                        break;

                    default:
                        break;
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                _logger.LogError(string.Format("{0}: {1}.", nameof(ProcessContext), ex.ToString()));
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(string.Format("{0}: {1}.", nameof(ProcessContext), ex.ToString()));
                throw;
            }
        }
    }
}
