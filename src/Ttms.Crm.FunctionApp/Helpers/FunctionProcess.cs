using Microsoft.Extensions.Logging;
using System;
using System.ServiceModel;

namespace Ttms.Crm.FunctionApp.Helpers
{
    internal static class FunctionProcess
    {
        internal static void ProcessContext(ILogger _logger, RemoteExecutionContext context, CrmServiceClient crmServiceClient)
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
                        Account.Account.PostAccountUpdate(_logger, context, crmServiceClient);
                        break;

                    case "f1_workorder":
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

