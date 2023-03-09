using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;
using Ttms.Crm.FunctionApp.Common;
using Ttms.Crm.FunctionApp.Domain.Services;
using Ttms.Crm.FunctionApp.Triggers;
using Ttms.Crm.FunctionApp.UnitTests.Common;
using Ttms.Crm.FunctionApp.UnitTests.Helpers;

namespace Ttms.Crm.FunctionApp.IntegrationTests.Triggers
{
    public class AccountPostOperationHttpTriggerTests : FakeContextTestsBase
    {
        private readonly CrmService fakeCrmService;

        public AccountPostOperationHttpTriggerTests()
        {
            this.fakeCrmService = new(_service, new NullLogger<CrmService>());
        }

        private AccountPostOperationHttpTrigger CreateAccountPostOperationHttpTrigger()
        {
            return new AccountPostOperationHttpTrigger(
                this.fakeCrmService);
        }

        [Theory]
        [InlineData("{\"MessageName\": \"Delete\"}")]
        [InlineData("{\"MessageName\": \"Retrieve\"}")]
        public void Run_InvalidContextMessageNameNeitherCreateNorUpdate_FailureResult(string jsonBody)
        {
            // Arrange
            var accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();
            HttpRequest request = Utils.CreateMockHttpRequest(jsonBody);

            // Act
            var sut = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            // Assert
            Assert.NotNull(sut);

            Assert.Equal((int)HttpStatusCode.BadRequest, sut.StatusCode);

            var result = sut.Value as OperationResult;
            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.Equal("Invalid context received.", result.FailureMessage);
            Assert.Null(result.Exception);
        }

        [Fact]
        public void Run_InvalidKeyValue_FailureResult()
        {
            // Arrange
            var accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();
            HttpRequest request = Utils.CreateMockHttpRequest("{\"InvalidKey\": \"Invalid Value\"}");

            // Act
            var sut = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            // Assert
            Assert.NotNull(sut);

            Assert.Equal((int)HttpStatusCode.BadRequest, sut.StatusCode);

            var result = sut.Value as OperationResult;
            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.Equal("Invalid context received.", result.FailureMessage);
            Assert.Null(result.Exception);
        }


        [Theory]
        [InlineData("{invalid}")]
        [InlineData("{'name': ''}")]
        [InlineData("")]
        public void Run_InvalidRequestBody_ExceptionResult(string jsonBody)
        {
            // Arrange
            var accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();
            HttpRequest request = Utils.CreateMockHttpRequest(jsonBody);

            // Act
            var sut = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            // Assert
            Assert.NotNull(sut);

            Assert.Equal((int)HttpStatusCode.BadRequest, sut.StatusCode);

            var result = sut.Value as OperationResult;
            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.Null(result.FailureMessage);
            Assert.NotNull(result.Exception);
        }

        [Fact]
        public void Run_NullHttpRequest_ExceptionResult()
        {
            // Arrange
            var accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();
            HttpRequest request = null!;

            // Act
            var sut = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            // Assert
            Assert.NotNull(sut);

            Assert.Equal((int)HttpStatusCode.BadRequest, sut.StatusCode);

            var result = sut.Value as OperationResult;
            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.Null(result.FailureMessage);
            Assert.NotNull(result.Exception);
        }
    }
}
