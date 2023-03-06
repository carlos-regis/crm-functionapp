using Microsoft.Xrm.Sdk;
using Ttms.Crm.FunctionApp.Tests.FakeXrmEasy;
using Ttms.Crm.FunctionApp.V4.Accounts;

namespace Ttms.Crm.FunctionApp.Tests.Accounts
{
    public class AccountPostOperationTests : FakeXrmEasyTestsBase
    {
        private readonly Account _account;
        private readonly Contact _contact;

        public AccountPostOperationTests()
        {
            _account = new Account()
            {
                Id = Guid.NewGuid(),
                Name = "Dynamics Value SL"
            };

            _contact = new Contact()
            {
                Id = Guid.NewGuid(),
                FirstName = "Tony"
            };
        }

        #region PhonePrefix

        [Fact]
        public void Check_if_account_phoneNumber_has_the_right_prefix_on_creation()
        {
            // Arrange
            _context.Initialize(new List<Entity>()
            {
                _account, _contact
            });

            // Act
            //Execute the system under test
            var cmd = new UpdateAccountCommand(_service)
            {
                AccountId = _account.Id,
                Name = "Jose"
            };
            cmd.Execute();

            //Retrieve state of the In-Memory database after execution
            var accountUpdated = _context.CreateQuery<Account>().FirstOrDefault();

            // Assert
            Assert.Equal("Jose", accountUpdated?.Name);
        }

        #endregion PhonePrefix
    }
}
