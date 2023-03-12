using Microsoft.Xrm.Sdk;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.Tests.Shared.UnitTests;
using Task = System.Threading.Tasks.Task;

namespace Ttms.Crm.Facade.UnitTests
{
    public class CrmServiceUnitTests : FakeContextTestsBase
    {
        [Fact]
        public async Task CreateAsync_CreateAccount_RetrieveSameAccount()
        {
            // Arrange
            Orb_country country = new()
            {
                Id = Guid.NewGuid(),
                Orb_name = "Portugal",
                rbtt_phoneprefix = "351"
            };

            Account newAccount = new()
            {
                Name = "CR LLC",
                Telephone1 = "968384411",
                Address1_Country = "Portugal",
                orb_countryid = new EntityReference
                {
                    Id = country.Id,
                    Name = country.Orb_name,
                    LogicalName = country.LogicalName
                }
            };

            fakeContext.Initialize(new List<Entity> { country });

            // Act
            Guid accountId = await fakeService.CreateAsync(newAccount);

            var accounts = fakeContext.CreateQuery<Account>().ToList();

            // Assert
            Assert.Single(accounts);

            Assert.True(accounts[0].Contains(Account.Fields.Name));
            Assert.True(accounts[0].Contains(Account.Fields.Telephone1));
            Assert.True(accounts[0].Contains(Account.Fields.orb_countryid));

            Assert.Equal(accountId, accounts[0][Account.Fields.Id]);
            Assert.Equal(newAccount[Account.Fields.Name], accounts[0][Account.Fields.Name]);
            Assert.Equal(newAccount[Account.Fields.Telephone1], accounts[0][Account.Fields.Telephone1]);
            Assert.Equal(newAccount[Account.Fields.orb_countryid], accounts[0][Account.Fields.orb_countryid]);
        }
    }
}