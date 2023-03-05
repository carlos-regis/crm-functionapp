using Microsoft.Azure.WebJobs.Host;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.ServiceModel;

namespace Ttms.Crm.FunctionApp.Helper
{
    internal static class FunctionProcess
    {
        internal static void ProcessContext(TraceWriter log, RemoteExecutionContext context, CrmServiceClient crmServiceClient)
        {
            log.Info(string.Format("Calling {0}...", nameof(ProcessContext)));

            try
            {
                log.Info(string.Format("Received: {0}", context.MessageName));

                Entity entity = (Entity)context.InputParameters["Target"];
                var entityName = entity.LogicalName;

                switch (entityName.ToLower())
                {
                    case "account":
                        Account.Account.PostAccountUpdate(log, context, crmServiceClient);
                        break;

                    case "f1_workorder":
                        break;

                    default:
                        break;
                }
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                log.Error(string.Format("{0}: {1}.", nameof(ProcessContext), ex.ToString()));
                throw;
            }
            catch (Exception ex)
            {
                log.Error(string.Format("{0}: {1}.", nameof(ProcessContext), ex.ToString()));
                throw;
            }
        }
    }
}

