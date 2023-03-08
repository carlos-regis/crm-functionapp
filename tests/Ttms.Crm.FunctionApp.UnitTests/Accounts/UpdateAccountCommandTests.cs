using Ttms.Crm.FunctionApp.Accounts;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.UnitTests.Common;

namespace Ttms.Crm.FunctionApp.UnitTests.Accounts
{
    public class UpdateAccountCommandTests : FakeContextTestsBase
    {
        private readonly Account? _account;
        private readonly Guid _accountId = Guid.NewGuid();

        public UpdateAccountCommandTests()
        {
            _account = new()
            {
                Id = _accountId,
                Name = "Dynamics Value SL"
            };
        }

        [Fact]
        public void Execute_UpdateAccountName_GetSameUpdatedAccountName()
        {
            // Arrange
            _context.Initialize(_account);

            // Act
            var sut = new UpdateAccountCommand(_service)
            {
                AccountId = _accountId,
                Name = "CR LLC - Zeca"
            };
            sut.Execute();

            //Retrieve state of the In-Memory database after execution
            var accountUpdated = _context.CreateQuery<Account>().FirstOrDefault();

            // Assert
            Assert.Equal(sut.Name, accountUpdated?.Name);
        }
    }
}
