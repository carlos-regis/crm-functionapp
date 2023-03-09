using Microsoft.AspNetCore.Http;
using Moq;
using System.Text;

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
    }
}
