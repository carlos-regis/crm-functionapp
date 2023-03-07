﻿using Microsoft.Xrm.Sdk.Query;
using Ttms.Crm.FunctionApp.IntegrationTests.Common;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.V4.Accounts;

namespace Ttms.Crm.FunctionApp.IntegrationTests.Accounts
{
    public class UpdateAccountCommandTests : RealContextTestsBase
    {
        [Fact]
        public void Execute_UpdateAccountName_GetUpdatedAccountName()
        {
            // Arrange
            Account _account = new()
            {
                Id = new Guid("4717b527-e7bb-ed11-83fe-000d3ab7a2f2")
            };

            // Act
            var sut = new UpdateAccountCommand(_service)
            {
                AccountId = _account.Id,
                Name = "CR LLC"
            };
            sut.Execute();

            Account accountUpdated = (Account)_service.Retrieve("account", _account.Id, new ColumnSet("name"));

            // Assert
            Assert.Equal(sut.Name, accountUpdated.Name);
        }
    }
}