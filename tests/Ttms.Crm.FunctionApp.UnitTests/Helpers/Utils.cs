using Microsoft.AspNetCore.Http;
using Microsoft.Xrm.Sdk;
using Moq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.UnitTests.Common;

namespace Ttms.Crm.FunctionApp.UnitTests.Helpers
{
    public static class Utils
    {
        public static HttpRequest CreateMockHttpRequest(string jsonBody)
        {
            MemoryStream msBody = new(Encoding.UTF8.GetBytes(jsonBody));
            var mockRequest = new Mock<HttpRequest>();

            mockRequest.Setup(x => x.Body).Returns(msBody);
            mockRequest.Setup(x => x.ContentType).Returns("application/json");

            return mockRequest.Object;
        }

        public static string LoadData(string fileName)
        {
            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (directory == null)
            {
                return string.Empty;
            }

            return File.ReadAllText(Path.Combine(directory, fileName));
        }

        /// <summary>
        /// Converts a remote execution context to JSON
        /// </summary>
        /// <param name="fakeContext">RemoteExecutionContext context object</param>
        /// <returns>JSON string</returns>
        public static string GetJsonFromRemoteExecutionContext(FakeRemoteExecutionContext fakeContext)
        {
            byte[] jsonRequestBody;

            try
            {
                DataContractJsonSerializerSettings settings = new()
                {
                    EmitTypeInformation = EmitTypeInformation.AsNeeded,
                    KnownTypes = new List<Type>()
                {
                    typeof(RemoteExecutionContext),
                    typeof(Entity),
                    typeof(EntityReference),
                    typeof(Account),
                    typeof(Orb_country)
                }
                };

                using (var memoryStream = new MemoryStream())
                {
                    DataContractJsonSerializer serializer = new(typeof(FakeRemoteExecutionContext), settings);
                    serializer.WriteObject(memoryStream, fakeContext);
                    jsonRequestBody = memoryStream.ToArray();
                }

                return Encoding.UTF8.GetString(jsonRequestBody, 0, jsonRequestBody.Length);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
