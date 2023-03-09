using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;
using Ttms.Crm.FunctionApp.Common;
using Ttms.Crm.FunctionApp.Domain.Services;
using Ttms.Crm.FunctionApp.Triggers;
using Ttms.Crm.FunctionApp.UnitTests.Common;
using Ttms.Crm.FunctionApp.UnitTests.Helpers;

namespace Ttms.Crm.FunctionApp.UnitTests.Triggers
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

        #region PhonePrefix

        [Fact]
        public void Check_if_account_phoneNumber_has_the_right_prefix_on_creation()
        {
            // Arrange


            // Act


            // Assert

        }

        #endregion PhonePrefix

        [Fact]
        public void Run_JsonFileAccountUpdate_SuccessResult()
        {
            // Arrange
            var accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();
            HttpRequest request = Utils.CreateMockHttpRequest(Utils.LoadData(Constants.AccountUpdateJsonFile));

            // Act
            var sut = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            // Assert
            Assert.NotNull(sut);

            Assert.Equal((int)HttpStatusCode.OK, sut.StatusCode);

            var result = sut.Value as OperationResult;
            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.Null(result.FailureMessage);
            Assert.Null(result.Exception);
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
