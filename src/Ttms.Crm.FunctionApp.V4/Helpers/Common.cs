using Microsoft.Crm.Sdk.Messages;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Ttms.Crm.FunctionApp.V4.Helpers
{
    public static class Common
    {
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
                throw new ArgumentOutOfRangeException(ex.Message);
            }
        }

        /// <summary>Get variable stored for local and remote in application settings.</summary>
        /// <param name="envVarName"></param>
        /// <returns>The value associated with the environment variable</returns>
        public static string GetEnvironmentVariables(string envVarName)
        {
            return Environment.GetEnvironmentVariable(envVarName, EnvironmentVariableTarget.Process);
        }

        /// <summary>Obtain information about the logged on user from the web service.</summary>
        /// <param name="service">The service to use to get the user's full name.</param>
        /// <returns>Logged on user's full name</returns>
        public static string GetUserFullName(ServiceClient service)
        {
            Guid userid = ((WhoAmIResponse)service.Execute(new WhoAmIRequest())).UserId;
            Entity systemUser = service.Retrieve("systemuser", userid, new ColumnSet("fullname"));

            return systemUser.GetAttributeValue<string>("fullname");
        }

        /// <summary> Retrieve the version of Microsoft Dynamics CRM. </summary>
        /// <param name="service">The service to use to get the version.</param>
        /// <returns>Dynamics 365 version</returns>
        public static string GetVersion(ServiceClient service)
        {
            return ((RetrieveVersionResponse)service.Execute(new RetrieveVersionRequest())).Version;
        }
    }
}
