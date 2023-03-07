using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.UnitTests.Common;
using Ttms.Crm.FunctionApp.V4.Accounts;

namespace Ttms.Crm.FunctionApp.UnitTests.Accounts
{
    public class UpdateAccountCommandTests : FakeContextTestsBase
    {
        private Account? _account;
        private readonly Guid _accountId = Guid.NewGuid();

        private void CreateTestContext()
        {
            _account = new()
            {
                Id = Guid.NewGuid(),
                Name = "Dynamics Value SL"
            };
        }

        [Fact]
        public void Execute_UpdateAccountName_GetSameUpdatedAccountName()
        {
            // Arrange
            CreateTestContext();
            _context.Initialize(_account);

            // Act
            var sut = new UpdateAccountCommand(_service)
            {
                AccountId = _accountId,
                Name = "Jose"
            };
            sut.Execute();

            //Retrieve state of the In-Memory database after execution
            var accountUpdated = _context.CreateQuery<Account>().FirstOrDefault();

            // Assert
            Assert.Equal("Jose", accountUpdated?.Name);
        }
    }
}
