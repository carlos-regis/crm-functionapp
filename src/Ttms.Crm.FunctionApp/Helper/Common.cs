using Microsoft.Azure.WebJobs.Host;
using Microsoft.Xrm.Sdk;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Ttms.Crm.FunctionApp.Helper
{
    internal static class Common
    {
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
