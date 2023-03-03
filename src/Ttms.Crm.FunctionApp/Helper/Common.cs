using Microsoft.Azure.WebJobs.Host;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Description;
using System.Text;

namespace Ttms.Crm.FunctionApp.Helper
{
    internal static class Common
    {
        /// <summary>
        /// Connect to the D365 organization service using CrmServiceClient
        /// </summary>
        /// <param name="log"></param>
        /// <returns>Organization service connection</returns>
        internal static CrmServiceClient ConnectionCrmServiceClient(TraceWriter log)
        {
            CrmServiceClient crmServiceClient = null;

            try
            {
                log.Info("Setting up Dynamics 365 connection");

                crmServiceClient = new CrmServiceClient(GetEnvironmentVariables(log, "crmConnectionString"));

                log.Info("Validating Connection");

                if (crmServiceClient?.ConnectedOrgId != null)
                {
                    log.Info($"Organization Id: {crmServiceClient.ConnectedOrgId}");
                }
                else
                {
                    log.Error("Failed to Established Connection!");
                    return null;
                }
            }
            catch (Exception ex)
            {
                log.Error($"Exception: {ex.Message}");
            }

            return crmServiceClient;
        }

        /// <summary>
        /// Connect to the D365 organization service using organization service proxy
        /// </summary>
        /// <param name="log"></param>
        /// <returns>Organization service connection</returns>
        internal static IOrganizationService ConnectionCrmOrgServiceProxy(TraceWriter log)
        {
            IOrganizationService crmService = null;

            try
            {
                log.Info("Setting up Dynamics 365 connection");

                ClientCredentials clientCredentials = new ClientCredentials();
                clientCredentials.UserName.UserName = GetEnvironmentVariables(log, "CredentialUserName");
                clientCredentials.UserName.Password = GetEnvironmentVariables(log, "CredentialPassword");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                OrganizationServiceProxy organizationServiceProxy = new OrganizationServiceProxy(new Uri(GetEnvironmentVariables(log, "crmOrgService")), null, clientCredentials, null)
                {
                    Timeout = new TimeSpan(0, 10, 0)
                };

                crmService = (IOrganizationService)organizationServiceProxy;

                log.Info("Validating Connection");

                if (crmService is object)
                {
                    Guid userid = ((WhoAmIResponse)crmService.Execute(new WhoAmIRequest())).UserId;

                    if (!userid.Equals(Guid.Empty))
                    {
                        log.Info($"User '{userid}' connected successfully established!");
                    }
                }
                else
                {
                    log.Error("Failed to Established Connection!");
                }

            }
            catch (Exception ex)
            {
                log.Error($"Exception: {ex.Message}");
            }

            return crmService;
        }

        /// <summary>
        /// Convert JSON to plugin (webhook) execution context
        /// </summary>
        /// <param name="log"></param>
        /// <param name="jsonContent"></param>
        /// <returns>Execution Context</returns>
        internal static RemoteExecutionContext GetD365Context(TraceWriter log, string jsonContent)
        {
            log.Info("Calling GetD365Context");

            RemoteExecutionContext remoteExecutionContext = null;

            using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonContent)))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RemoteExecutionContext));
                remoteExecutionContext = (RemoteExecutionContext)jsonSerializer.ReadObject(memoryStream);
            }

            log.Info("Return context");

            return remoteExecutionContext;
        }

        /// <summary>
        /// Get variable stored for local and remote in application settings
        /// </summary>
        /// <param name="log"></param>
        /// <param name="envVarName"></param>
        /// <returns></returns>
        internal static string GetEnvironmentVariables(TraceWriter log, string envVarName)
        {
            log.Info($"Calling GetEnvironmentVariables: {envVarName}");

            return Environment.GetEnvironmentVariable($"{envVarName}", EnvironmentVariableTarget.Process);
        }
    }
}
