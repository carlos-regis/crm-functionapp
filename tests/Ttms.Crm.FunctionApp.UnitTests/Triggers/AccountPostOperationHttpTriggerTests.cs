using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Net;
using Ttms.Crm.FunctionApp.Common;
using Ttms.Crm.FunctionApp.Domain.Services;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.Triggers;
using Ttms.Crm.FunctionApp.UnitTests.Common;
using Ttms.Crm.FunctionApp.UnitTests.Helpers;
using Ttms.Crm.Tests.Shared.UnitTests;

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
        public void Run_AccountCreate_PhoneNumberHasCorrectPrefix()
        {
            // Arrange
            Orb_country country = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Portugal",
                rbtt_phoneprefix = "351"
            };

            Account targetEntity = new()
            {
                Id = Guid.NewGuid(),
                Telephone1 = "968384411",
                orb_countryid = new()
                {
                    Id = country.Id,
                    Name = country.Orb_name,
                    LogicalName = country.LogicalName
                }
            };

            fakeContext.Initialize(new List<Entity> { targetEntity, country });

            ParameterCollection inputParameters = new()
            {
                { "Target", targetEntity }
            };

            FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
            {
                MessageName = "Create",
                Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
                UserId = Guid.NewGuid(),
                PrimaryEntityId = targetEntity.Id,
                PrimaryEntityName = targetEntity.LogicalName,
                InputParameters = inputParameters,
                Mode = (int)SdkMessageProcessingStep_Mode.Asynchronous,
                Depth = 1
            };

            HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
            AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;
            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Telephone1));

            // Assert
            Assert.Equal($"+{country.rbtt_phoneprefix}{targetEntity.Telephone1}",
                         result.GetAttributeValue<string>(Account.Fields.Telephone1));
        }

        [Fact]
        public void Run_CountryUpdate_PhoneNumberHasCorrectPrefix()
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
                Telephone1 = "968384411",
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

            FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
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

            HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
            AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;
            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Telephone1));

            // Assert
            Assert.Equal($"+{targetCountry.rbtt_phoneprefix}{targetEntity.Telephone1}",
                         result.GetAttributeValue<string>(Account.Fields.Telephone1));
        }

        [Fact]
        public void Run_PhoneNumberUpdate_PhoneNumberHasCorrectPrefix()
        {
            // Arrange
            Orb_country country = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Portugal",
                rbtt_phoneprefix = "351"
            };

            Account targetEntity = new()
            {
                Id = Guid.NewGuid(),
                Telephone1 = "968384411",
            };

            Account preImage = new()
            {
                Id = targetEntity.Id,
                orb_countryid = new()
                {
                    Id = country.Id,
                    Name = country.Orb_name,
                    LogicalName = country.LogicalName
                }
            };

            fakeContext.Initialize(new List<Entity> { country, targetEntity });

            EntityImageCollection preEntityImages = new()
            {
                { "PreImage", preImage }
            };

            ParameterCollection inputParameters = new()
            {
                { "Target", targetEntity }
            };

            FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
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

            HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
            AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;
            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Telephone1));

            // Assert
            Assert.Equal($"+{country.rbtt_phoneprefix}{targetEntity.Telephone1}",
                         result.GetAttributeValue<string>(Account.Fields.Telephone1));
        }

        #endregion PhonePrefix

        #region ABCStatus

        [Fact]
        public void Run_ClassificationBaseUpdate_AccountAbcStatusWithTotalPotentialAndTurnoverHasCorrectValue()
        {
            // Arrange
            Orb_classificationbase classificationBase = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Installers - PT",
                Btt_Valueperappliance = new Money((decimal)1.25),
                Orb_potentialA = 61000.00,
                Orb_potentialb = 59000.00,
                Orb_useofpotential1 = 0.66,
                Orb_useofpotential2 = 0.33,
                Orb_useofpotential3 = 0.00
            };

            Account targetEntity = new()
            {
                Id = Guid.NewGuid(),
                orb_classificationbaseid = new EntityReference
                {
                    Id = classificationBase.Id,
                    Name = classificationBase.Orb_name,
                    LogicalName = classificationBase.LogicalName
                }
            };

            Account preImage = new()
            {
                Id = targetEntity.Id,
                Btt_Totalpotential = new Money((decimal)500000.00),
                Btt_TT_Turnover = new Money((decimal)500000.00)
            };

            fakeContext.Initialize(new List<Entity> { targetEntity, classificationBase });

            EntityImageCollection preEntityImages = new()
            {
                { "PreImage" , preImage }
            };

            ParameterCollection inputParameters = new()
            {
                { "Target", targetEntity }
            };

            FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
            {
                MessageName = "Update",
                Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
                UserId = Guid.NewGuid(),
                PrimaryEntityId = targetEntity.Id,
                PrimaryEntityName = targetEntity.LogicalName,
                InputParameters = inputParameters,
                PreEntityImages = preEntityImages,
                Mode = (int)SdkMessageProcessingStep_Mode.Synchronous,
                Depth = 1
            };

            HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
            AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;
            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Orb_classification));

            // Assert
            Assert.Equal("A1", result.GetAttributeValue<string>(Account.Fields.Orb_classification));
        }


        [Fact]
        public void Run_ClassificationBaseUpdate_AccountAbcStatusWithoutTotalPotentialAndTurnoverHasCorrectValue()
        {
            Orb_classificationbase classificationBase = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Installers - PT",
                Btt_Valueperappliance = new Money((decimal)1.25),
                Orb_potentialA = 61000.00,
                Orb_potentialb = 59000.00,
                Orb_useofpotential1 = 0.66,
                Orb_useofpotential2 = 0.33,
                Orb_useofpotential3 = 0.00
            };

            Account targetEntity = new()
            {
                Id = Guid.NewGuid(),
                orb_classificationbaseid = new()
                {
                    Id = classificationBase.Id,
                    Name = classificationBase.Orb_name,
                    LogicalName = classificationBase.LogicalName
                }
            };

            Account preImage = new()
            {
                Id = targetEntity.Id,
                Btt_Totalpotential = null,
                Btt_TT_Turnover = null
            };

            fakeContext.Initialize(new List<Entity> { targetEntity, classificationBase });

            EntityImageCollection preEntityImages = new()
            {
                { "PreImage" , preImage }
            };

            ParameterCollection inputParameters = new()
            {
                { "Target", targetEntity }
            };

            FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
            {
                MessageName = "Update",
                Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
                UserId = Guid.NewGuid(),
                PrimaryEntityId = targetEntity.Id,
                PrimaryEntityName = targetEntity.LogicalName,
                InputParameters = inputParameters,
                PreEntityImages = preEntityImages,
                Mode = (int)SdkMessageProcessingStep_Mode.Synchronous,
                Depth = 1
            };

            HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
            AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Orb_classification));

            // Assert
            Assert.Equal("Z9", result.GetAttributeValue<string>(Account.Fields.Orb_classification));
        }

        [Fact]
        public void Run_TotalPotentialAndTurnoverUpdate_AccountAbcStatusWithClassificationBaseHasCorrectValue()
        {
            Orb_classificationbase classificationBase = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Installers - PT",
                Btt_Valueperappliance = new Money((decimal)1.25),
                Orb_potentialA = 61000.00,
                Orb_potentialb = 59000.00,
                Orb_useofpotential1 = 0.66,
                Orb_useofpotential2 = 0.33,
                Orb_useofpotential3 = 0.00
            };

            Account targetEntity = new()
            {
                Id = Guid.NewGuid(),
                Btt_Totalpotential = new Money((decimal)500000.00),
                Btt_TT_Turnover = new Money((decimal)500000.00)
            };

            Account preImage = new()
            {
                Id = targetEntity.Id,
                orb_classificationbaseid = new()
                {
                    Id = classificationBase.Id,
                    Name = classificationBase.Orb_name,
                    LogicalName = classificationBase.LogicalName
                }
            };

            fakeContext.Initialize(new List<Entity> { targetEntity, classificationBase });

            EntityImageCollection preEntityImages = new()
            {
                { "PreImage" , preImage }
            };

            ParameterCollection inputParameters = new()
            {
                { "Target", targetEntity }
            };

            FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
            {
                MessageName = "Update",
                Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
                UserId = Guid.NewGuid(),
                PrimaryEntityId = targetEntity.Id,
                PrimaryEntityName = targetEntity.LogicalName,
                InputParameters = inputParameters,
                PreEntityImages = preEntityImages,
                Mode = (int)SdkMessageProcessingStep_Mode.Synchronous,
                Depth = 1
            };

            HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
            AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Orb_classification));

            // Assert
            Assert.Equal("A1", result.GetAttributeValue<string>(Account.Fields.Orb_classification));
        }

        [Fact]
        public void Run_AccountCreate_AccountAbcStatusWithClassificationBaseAndTotalPotentialAndTurnoverHasCorrectValue()
        {
            Orb_classificationbase classificationBase = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Test técnico",
                Btt_Valueperappliance = new Money((decimal)1.00),
                Orb_potentialA = 70000.00,
                Orb_potentialb = 10000.00,
                Orb_useofpotential1 = 0.67,
                Orb_useofpotential2 = 0.33,
                Orb_useofpotential3 = 0.00
            };

            Account targetEntity = new()
            {
                Id = Guid.NewGuid(),
                Btt_Totalpotential = new Money((decimal)520000.00),
                Btt_TT_Turnover = new Money((decimal)0.00),
                orb_classificationbaseid = new EntityReference
                {
                    Id = classificationBase.Id,
                    Name = classificationBase.Orb_name,
                    LogicalName = classificationBase.LogicalName
                }
            };

            Account preImage = new()
            {
                Id = targetEntity.Id,
                Btt_Totalpotential = new Money((decimal)520000.00),
                Btt_TT_Turnover = new Money((decimal)0.00),
                orb_classificationbaseid = new()
                {
                    Id = classificationBase.Id,
                    Name = classificationBase.Orb_name,
                    LogicalName = classificationBase.LogicalName
                }
            };

            fakeContext.Initialize(new List<Entity> { targetEntity, classificationBase });

            EntityImageCollection preEntityImages = new()
            {
                { "PreImage" , preImage }
            };

            ParameterCollection inputParameters = new()
            {
                { "Target", targetEntity }
            };

            FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
            {
                MessageName = "Update",
                Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
                UserId = Guid.NewGuid(),
                PrimaryEntityId = targetEntity.Id,
                PrimaryEntityName = targetEntity.LogicalName,
                InputParameters = inputParameters,
                PreEntityImages = preEntityImages,
                Mode = (int)SdkMessageProcessingStep_Mode.Synchronous,
                Depth = 1
            };

            HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
            AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

            // Act
            _ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

            var result = fakeService.Retrieve(Account.EntityLogicalName,
                                              targetEntity.Id,
                                              new ColumnSet(Account.Fields.Orb_classification));

            // Assert
            Assert.Equal("D1", result.GetAttributeValue<string>(Account.Fields.Orb_classification));

        }

        #endregion ABCStatus

        #region CMD

        //[Fact]
        //public void Run_AccountUpdate_AccountHasSapValues()
        //{
        //   Orb_country country = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        Orb_name = "Sweden",
        //        rbtt_ISO3166_Alpha_2 = "SE"
        //    };

        //    rbtt_productionplants salesorganization = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "RBSE",
        //        rbtt_Country = new EntityReference
        //        {
        //            Id = country.Id,
        //            Name = country.Orb_name,
        //            LogicalName = country.LogicalName
        //        }
        //    };

        //    Account targetEntity = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_CustomerMasterData = true,
        //        orb_countryid = new ()
        //        {
        //            Id = country.Id,
        //            Name = country.Orb_name,
        //            LogicalName = country.LogicalName
        //        },
        //        rbtt_Brand = new OptionSetValue {
        //            Value = (int)btt_Brands.Bosch
        //        }
        //    };

        //    Account postImage = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "testJohn_Name1",
        //        Btt_accountname = "testJohn_Name2",
        //        rbtt_ERPCustomerNumber = "0103034613",
        //        rbtt_Brand = new OptionSetValue
        //        {
        //            Value = (int)btt_Brands.Bosch
        //        },
        //        rbtt_SalesOrganization = new ()
        //        {
        //            Id = salesorganization.Id,
        //            Name = salesorganization.rbtt_name,
        //            LogicalName = salesorganization.LogicalName
        //        }
        //    };

        //    rbtt_customermasterdataexchange cmde = new rbtt_customermasterdataexchange
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_Account = new ()
        //        {
        //            Id = postImage.Id,
        //            LogicalName = Account.EntityLogicalName,
        //            Name = postImage.Name
        //        },
        //        rbtt_MDCStatus = new OptionSetValue { Value = (int)rbtt_customermasterdataexchange_rbtt_MDCStatus.Requested }
        //    };

        //    rbtt_configurations configToken = new rbtt_configurations
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - Token",
        //        rbtt_Value = "Basic NTdmYzFiODYtNTliZC00YmRlLWFkODYtZjljMmIxODIzYzIyOmNjNGUwMzZiLTQ1ZWEtNDcxMi1hNmJmLTk1ODQxMWQ5YjhmOA=="
        //    };

        //    rbtt_configurations configKeyId = new rbtt_configurations
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - keyId",
        //        rbtt_Value = "57fc1b86-59bd-4bde-ad86-f9c2b1823c22"
        //    };

        //    rbtt_configurations configRegisterCustomer = new rbtt_configurations
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - RegisterCustomer",
        //        rbtt_Value = "https://ews-esz-emea.api.bosch.com/eai/d/TTGB/ManageCustomer/RegisterCustomer?Brand={Brand}&Country={Country}&CustomerNumber={CustomerNumber}&SystemID=CRM"
        //    };

        //    rbtt_configurations configGetInformation = new rbtt_configurations
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - GetCustomerInformation",
        //        rbtt_Value = "https://ews-esz-emea.api.bosch.com/eai/d/TTGB/ManageCustomer/GetCustomerInformation?Brand={Brand}&Country={Country}&CustomerNumber={CustomerNumber}&SystemID=CRM"
        //    };

        //    fakeContext.Initialize(new List<Entity> { targetEntity, country, configToken, configKeyId, configRegisterCustomer, configGetInformation, salesorganization, cmde });

        //    EntityImageCollection postEntityImages = new ()
        //    {
        //        { "PostImage" , postImage }
        //    };

        //    ParameterCollection inputParameters = new ()
        //    {
        //        { "Target", targetEntity }
        //    };

        //FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
        //{
        //    MessageName = "Update",
        //    Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
        //    UserId = Guid.NewGuid(),
        //    PrimaryEntityId = targetEntity.Id,
        //    PrimaryEntityName = targetEntity.LogicalName,
        //    InputParameters = inputParameters,
        //    PostEntityImages = postEntityImages,
        //    Mode = (int)SdkMessageProcessingStep_Mode.Synchronous,
        //    Depth = 1
        //};

        //HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
        //AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

        //// Act
        //_ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

        //var result = fakeService.Retrieve(Account.EntityLogicalName,
        //                                  targetEntity.Id,
        //                                  new ColumnSet(Account.Fields.Name));

        //// Assert
        //Assert.Equal("Lars Sunes rör & meck AB", result.GetAttributeValue<string>(Account.Fields.Name));
        //}

        //[TestMethod]
        //public void Run_AccountCreate_AccountHasSapValues()
        //{
        //    Orb_country country = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        Orb_name = "Germany",
        //        rbtt_ISO3166_Alpha_2 = "DE"
        //    };

        //    rbtt_productionplants salesorganization = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "RBSE",
        //        rbtt_Country = new ()
        //        {
        //            Id = country.Id,
        //            Name = country.Orb_name,
        //            LogicalName = country.LogicalName
        //        }
        //    };

        //    Account targetEntity = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_CustomerMasterData = true,
        //        rbtt_SalesOrganization = new ()
        //        {
        //            Id = salesorganization.Id,
        //            Name = salesorganization.rbtt_name,
        //            LogicalName = salesorganization.LogicalName
        //        }
        //    };

        //    Account postImage = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "testJohn_Name1",
        //        Btt_accountname = "testJohn_Name2",
        //        rbtt_ERPCustomerNumber = "39000627",
        //        rbtt_Brand = new OptionSetValue
        //        {
        //            Value = (int)btt_Brands.Bosch
        //        },
        //        rbtt_SalesOrganization = new ()
        //        {
        //            Id = salesorganization.Id,
        //            Name = salesorganization.rbtt_name,
        //            LogicalName = salesorganization.LogicalName
        //        }
        //    };

        //    rbtt_configurations configToken = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - Token",
        //        rbtt_Value = "Basic NTdmYzFiODYtNTliZC00YmRlLWFkODYtZjljMmIxODIzYzIyOmNjNGUwMzZiLTQ1ZWEtNDcxMi1hNmJmLTk1ODQxMWQ5YjhmOA=="
        //    };

        //    rbtt_configurations configKeyId = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - keyId",
        //        rbtt_Value = "57fc1b86-59bd-4bde-ad86-f9c2b1823c22"
        //    };

        //    rbtt_configurations configRegisterCustomer = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - RegisterCustomer",
        //        rbtt_Value = "https://ews-esz-emea.api.bosch.com/eai/d/TTGB/ManageCustomer/RegisterCustomer?Brand={Brand}&Country={Country}&CustomerNumber={CustomerNumber}&SystemID=CRM"
        //    };

        //    rbtt_configurations configGetInformation = new ()
        //    {
        //        Id = Guid.NewGuid(),
        //        rbtt_name = "Customer Master Data Exchange - GetCustomerInformation",
        //        rbtt_Value = "https://ews-esz-emea.api.bosch.com/eai/d/TTGB/ManageCustomer/GetCustomerInformation?Brand={Brand}&Country={Country}&CustomerNumber={CustomerNumber}&SystemID=CRM"
        //    };

        //    fakeContext.Initialize(new List<Entity> { targetEntity, country, configToken, configKeyId, configRegisterCustomer, configGetInformation, salesorganization });

        //    EntityImageCollection postEntityImages = new ()
        //    {
        //        { "PostImage" , postImage }
        //    };

        //    ParameterCollection inputParameters = new ()
        //    {
        //        { "Target", targetEntity }
        //    };

        //FakeRemoteExecutionContext fakeRemoteExecutionContext = new()
        //{
        //    MessageName = "Create",
        //    Stage = (int)SdkMessageProcessingStep_Stage.Postoperation,
        //    UserId = Guid.NewGuid(),
        //    PrimaryEntityId = targetEntity.Id,
        //    PrimaryEntityName = targetEntity.LogicalName,
        //    InputParameters = inputParameters,
        //    PostEntityImages = postEntityImages,
        //    Mode = (int)SdkMessageProcessingStep_Mode.Synchronous,
        //    Depth = 1
        //};

        //HttpRequest request = Utils.CreateMockHttpRequest(Utils.GetJsonFromRemoteExecutionContext(fakeRemoteExecutionContext));
        //AccountPostOperationHttpTrigger accountPostOperationHttpTrigger = this.CreateAccountPostOperationHttpTrigger();

        //// Act
        //_ = accountPostOperationHttpTrigger.Run(request, NullLogger.Instance).Result as JsonResult;

        //var result = fakeService.Retrieve(Account.EntityLogicalName,
        //                                  targetEntity.Id,
        //                                  new ColumnSet(Account.Fields.Name, Account.Fields.Btt_accountname));

        //// Assert
        //    Assert.Equal("Lars Sunes rör & meck AB", result.GetAttributeValue<string>(Account.Fields.Name));
        //    Assert.AreEqual("YESSS Elektrofachgroßhandlung GmbH", result.GetAttributeValue<string>(Account.Fields.Name));
        //    Assert.AreEqual("Filiale Kitzingen", result.GetAttributeValue<string>(Account.Fields.Btt_accountname));
        //}

        #endregion CMD

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
