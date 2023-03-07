using Ttms.Crm.FunctionApp.UnitTests.Common;

namespace Ttms.Crm.FunctionApp.UnitTests.Accounts
{
    public class AccountPostOperationTests : FakeContextTestsBase
    {
        #region PhonePrefix

        [Fact]
        public void Check_if_account_phoneNumber_has_the_right_prefix_on_creation()
        {
            // Arrange
            //_context.Initialize(new List<Entity>()
            //{
            //    _account, _contact
            //});

            // Act
            //var sut = new UpdateAccountCommand(_service)
            //{
            //    AccountId = _account.Id,
            //    Name = "Jose"
            //};
            //sut.Execute();

            //Retrieve state of the In-Memory database after execution
            //var accountUpdated = _context.CreateQuery<Account>().FirstOrDefault();

            // Assert
            //Assert.Equal("Jose", accountUpdated?.Name);
        }

        #endregion PhonePrefix
    }
}
