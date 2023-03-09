using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Ttms.Crm.FunctionApp.Shared;

namespace Ttms.Crm.FunctionApp.Domain.Helpers
{
    public static class CrmUtils
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        public static bool ValidateContext(RemoteExecutionContext context, ILogger log)
        {
            if (context.MessageName != "Create" || context.MessageName != "Update")
            {
                log.LogInformation("Context Message: {Message}", context.MessageName);
                return false;
            }
            log.LogInformation("Context Message: {Message}", context.MessageName);

            if (context.Depth > 2)
            {
                log.LogInformation("Depth: {Depth}", context.Depth);
                return false;
            }
            log.LogInformation("Depth: {Depth}", context.Depth);

            if ((Stage)context.Stage != Stage.PostOperation)
            {
                log.LogInformation("Context Stage: {Stage}", context.Stage);
                return false;
            }
            log.LogInformation("Context Stage: {Stage}", context.Stage);

            return true;
        }

        /// <summary>
        /// Convert JSON into a remote execution context
        /// </summary>
        /// <param name="jsonContext">JSON String</param>
        /// <returns>Xrm sdk RemoteExecutionContext</returns>
        public static RemoteExecutionContext GetContext(string jsonContext)
        {
            RemoteExecutionContext context = null;
            try
            {
                using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(jsonContext)))
                {
                    DataContractJsonSerializer jsonSerializer = new(typeof(RemoteExecutionContext));
                    context = (RemoteExecutionContext)jsonSerializer.ReadObject(memoryStream);
                }

                return context;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
