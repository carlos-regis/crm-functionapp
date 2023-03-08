using Microsoft.Xrm.Sdk;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Ttms.Crm.FunctionApp.Helpers
{
    public static class CrmUtils
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
    }
}
