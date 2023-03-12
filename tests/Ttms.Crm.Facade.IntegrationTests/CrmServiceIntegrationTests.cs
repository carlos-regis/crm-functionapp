using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Ttms.Crm.Tests.Shared.EntityModel;
using Ttms.Crm.Tests.Shared.IntegrationTests;
using Task = System.Threading.Tasks.Task;

namespace Ttms.Crm.Facade.IntegrationTests
{
    public class CrmServiceIntegrationTests : RealContextTestsBase
    {
        [Fact]
        public async Task CreateAsync_CreateAccount_RetrieveAccountWithCountry()
        {
            Entity country = new(Orb_country.Fields.EntityLogicalName)
            {
                [Orb_country.Fields.Orb_name] = "Portugal",
                [Orb_country.Fields.rbtt_phoneprefix] = "351"
            };

            Guid countryId = await service.CreateAsync(country);

            Entity account = new(Account.Fields.EntityLogicalName)
            {
                [Account.Fields.Name] = "CR LLC",
                [Account.Fields.Telephone1] = "968384411",
                [Account.Fields.Address1_Country] = "Portugal",
                [Account.Fields.orb_countryid] = new EntityReference
                {
                    Id = countryId,
                    Name = (string)country[Orb_country.Fields.Orb_name],
                    LogicalName = Orb_country.Fields.EntityLogicalName
                }
            };

            // Act
            Guid accountId = await service.CreateAsync(account);

            ColumnSet cols = new(Account.Fields.Name,
                                 Account.Fields.Telephone1,
                                 Account.Fields.Address1_Country,
                                 Account.Fields.orb_countryid);
            Entity retrievedAccount = await service.RetrieveAsync(Account.Fields.EntityLogicalName, accountId, cols);

            // Assert
            Assert.True(retrievedAccount.Contains(Account.Fields.Name));
            Assert.True(retrievedAccount.Contains(Account.Fields.Address1_Country));
            Assert.True(retrievedAccount.Contains(Account.Fields.Telephone1));
            Assert.True(retrievedAccount.Contains(Account.Fields.orb_countryid));

            Assert.Equal(accountId, retrievedAccount[Account.Fields.Id]);
            Assert.Equal(account[Account.Fields.Name], retrievedAccount[Account.Fields.Name]);
            Assert.Equal(account[Account.Fields.Address1_Country], retrievedAccount[Account.Fields.Address1_Country]);
            Assert.Equal(account[Account.Fields.Telephone1], retrievedAccount[Account.Fields.Telephone1]);

            //Assert.Equal(countryId, retrievedAccount.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid).Id);
            //Assert.Equal(country[Orb_country.Fields.Orb_name], retrievedAccount.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid).Name);
            //Assert.Equal(country[Orb_country.Fields.EntityLogicalName], retrievedAccount.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid).LogicalName);

        }

        [Fact]
        public async Task CreateAsync_CreateAccount_RetrieveSameAccount()
        {
            Entity account = new(Account.Fields.EntityLogicalName)
            {
                [Account.Fields.Name] = "CR LLC",
                [Account.Fields.Telephone1] = "968384411",
                [Account.Fields.Address1_Country] = "Portugal",
            };

            // Act
            Guid accountId = await service.CreateAsync(account);

            ColumnSet cols = new(Account.Fields.Name, Account.Fields.Telephone1, Account.Fields.Address1_Country);
            Entity retrievedAccount = await service.RetrieveAsync(Account.Fields.EntityLogicalName, accountId, cols);

            // Assert
            Assert.True(retrievedAccount.Contains(Account.Fields.Name));
            Assert.True(retrievedAccount.Contains(Account.Fields.Address1_Country));
            Assert.True(retrievedAccount.Contains(Account.Fields.Telephone1));

            Assert.Equal(accountId, retrievedAccount[Account.Fields.Id]);
            Assert.Equal(account[Account.Fields.Name], retrievedAccount[Account.Fields.Name]);
            Assert.Equal(account[Account.Fields.Address1_Country], retrievedAccount[Account.Fields.Address1_Country]);
            Assert.Equal(account[Account.Fields.Telephone1], retrievedAccount[Account.Fields.Telephone1]);

            service.Delete(Account.Fields.EntityLogicalName, accountId);
        }

        [Fact]
        public async Task CreateAsync_CreateOrbCountry_RetrieveSameOrbCountry()
        {
            // Arrange
            Entity country = new(Orb_country.Fields.EntityLogicalName)
            {
                [Orb_country.Fields.Orb_name] = "Portugal",
                [Orb_country.Fields.rbtt_phoneprefix] = "+351"
            };

            // Act
            Guid countryId = await service.CreateAsync(country);

            ColumnSet cols = new(Orb_country.Fields.Orb_name, Orb_country.Fields.rbtt_phoneprefix);
            Entity retrieveCountry = await service.RetrieveAsync(Orb_country.Fields.EntityLogicalName, countryId, cols);

            // Assert
            Assert.True(retrieveCountry.Contains(Orb_country.Fields.Orb_name));
            Assert.True(retrieveCountry.Contains(Orb_country.Fields.rbtt_phoneprefix));
            Assert.Equal(countryId, retrieveCountry[Orb_country.Fields.Id]);
            Assert.Equal(country[Orb_country.Fields.Orb_name], retrieveCountry[Orb_country.Fields.Orb_name]);
            Assert.Equal(country[Orb_country.Fields.rbtt_phoneprefix], retrieveCountry[Orb_country.Fields.rbtt_phoneprefix]);

            service.Delete(Orb_country.Fields.EntityLogicalName, countryId);
        }
    }
}