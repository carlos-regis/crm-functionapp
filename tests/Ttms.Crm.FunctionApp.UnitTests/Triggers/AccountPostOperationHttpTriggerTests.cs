using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Ttms.Crm.FunctionApp.Common;
using Ttms.Crm.FunctionApp.Domain.Services;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
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
            this.fakeCrmService = new(fakeService, new NullLogger<CrmService>());
        }

        private AccountPostOperationHttpTrigger CreateAccountPostOperationHttpTrigger()
        {
            return new AccountPostOperationHttpTrigger(
                this.fakeCrmService);
        }

        #region PhonePrefix

        [Fact]
        public void Run_CountryUpdate_AccountPhoneNumberHasCorrectPrefix()
        {
            // Arrange
            Orb_country targetCountry = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Afghanistan",
                rbtt_phoneprefix = "93"
            };

            Orb_country preTargetCountry = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Portugal",
                rbtt_phoneprefix = "351"
            };

            Account targetEntity = new()
            {
                Id = Guid.NewGuid(),
                orb_countryid = new()
                {
                    Id = targetCountry.Id,
                    Name = targetCountry.Orb_name,
                    LogicalName = targetCountry.LogicalName
                }
            };

            fakeContext.Initialize(new List<Entity> { targetCountry, preTargetCountry, targetEntity });

            Account preImage = new()
            {
                Id = targetEntity.Id,
                Telephone1 = "968384411"
            };

            ParameterCollection inputParameters = new()
            {
                { "Target", targetEntity }
            };

            EntityImageCollection preEntityImages = new()
            {
                { "PreImage", preImage }
            };

            FakeRemoteExecutionContext context = new()
            {
                MessageName = "Update",
                Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
                UserId = Guid.NewGuid(),
                PrimaryEntityId = targetEntity.Id,
                PrimaryEntityName = targetEntity.LogicalName,
                InputParameters = inputParameters,
                PreEntityImages = preEntityImages,
                Mode = (int)SdkMessageProcessingStep_Mode.Asynchronous,
                Depth = 1
            };

            DataContractJsonSerializerSettings settings = new()
            {
                EmitTypeInformation = EmitTypeInformation.AsNeeded,
                KnownTypes = new List<Type>()
                {
                    typeof(RemoteExecutionContext),
                    typeof(Entity),
                    typeof(EntityReference),
                    typeof(Account)
                }
            };

            string requestBody;
            using (var memoryStream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new(typeof(FakeRemoteExecutionContext), settings);
                serializer.WriteObject(memoryStream, context);
                memoryStream.Position = 0;
                requestBody = (new StreamReader(memoryStream)).ReadToEnd();
            }

            //JsonSerializerSettings jsonSerializerSettings = new()
            //{
            //    Formatting = Formatting.Indented,
            //    NullValueHandling = NullValueHandling.Ignore,
            //    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            //    ContractResolver = new LowerCaseDictionaryKeysContractResolver(),
            //    TypeNameHandling = TypeNameHandling.Auto
            //};

            //string requestBody = JsonConvert.SerializeObject(context, jsonSerializerSettings);

            HttpRequest request = Utils.CreateMockHttpRequest(requestBody);
            var accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;
            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Telephone1));

            // Assert
            Assert.Equal("+93968384411", result.GetAttributeValue<string>(Account.Fields.Telephone1));
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
