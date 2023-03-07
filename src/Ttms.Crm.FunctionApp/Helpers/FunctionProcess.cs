using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;
using System.ServiceModel;
using Ttms.Crm.FunctionApp.Accounts;

namespace Ttms.Crm.FunctionApp.Helpers
{
    internal static class FunctionProcess
    {
        internal static void ProcessContext(ILogger log, RemoteExecutionContext context, ServiceClient service)
        {
            log.LogInformation(string.Format("Calling {0}...", nameof(ProcessContext)));

            try
            {
                log.LogInformation(string.Format("Received: {0}", context.MessageName));

                Entity entity = (Entity)context.InputParameters["Target"];
                var entityName = entity.LogicalName;

                switch (entityName.ToLower())
                {
                    case "account":
                        AccountPostOperationCreate.PostAccountUpdate(log, context, service);
                        break;

                    default:
                        break;
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                log.LogError(string.Format("{0}: {1}.", nameof(ProcessContext), ex.ToString()));
                throw;
            }
            catch (Exception ex)
            {
                log.LogError(string.Format("{0}: {1}.", nameof(ProcessContext), ex.ToString()));
                throw;
            }
        }
    }
}
