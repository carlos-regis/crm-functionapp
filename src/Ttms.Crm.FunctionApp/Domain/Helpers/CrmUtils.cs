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
        /// Context validation
        /// </summary>
        /// <param name="context"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        public static bool ValidateContext(RemoteExecutionContext context,
                                           string entityLogicalName,
                                           ILogger log,
                                           out Entity entity,
                                           out Entity preImage,
                                           out Entity postImage)
        {
            entity = null;
            preImage = null;
            postImage = null;

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                entity = (Entity)context.InputParameters["Target"];
                if (entity.LogicalName != entityLogicalName)
                {
                    log.LogWarning("Entity is : {Entity}", entity.LogicalName);
                    return false;
                }
                log.LogInformation("Entity is : {Entity}", entity.LogicalName);

                if (!(context.MessageName == "Create" || context.MessageName == "Update"))
                {
                    log.LogWarning("Context Message: {Message}", context.MessageName);
                    return false;
                }
                log.LogInformation("Context Message: {Message}", context.MessageName);

                if (context.Depth > 2)
                {
                    log.LogWarning("Depth: {Depth}", context.Depth);
                    return false;
                }
                log.LogInformation("Depth: {Depth}", context.Depth);

                if ((Stage)context.Stage != Stage.PostOperation)
                {
                    log.LogWarning("Context Stage: {Stage}", context.Stage);
                    return false;
                }
                log.LogInformation("Context Stage: {Stage}", context.Stage);

                if (context.PreEntityImages != null && context.PreEntityImages.Contains("PreImage"))
                {
                    preImage = context.PreEntityImages["PreImage"];
                    log.LogInformation("PreImage id is: {Id}", preImage.Id);
                }

                if (context.PostEntityImages != null && context.PostEntityImages.Contains("PostImage"))
                {
                    postImage = context.PostEntityImages["PostImage"];
                    log.LogInformation("PostImage id is: {Id}", postImage.Id);
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// Convert JSON into a remote execution context
        /// </summary>
        /// <param name="jsonContext">JSON String</param>
        /// <returns>Xrm sdk RemoteExecutionContext</returns>
        public static RemoteExecutionContext GetRemoteExecutionContextFromJson(string jsonContext)
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
