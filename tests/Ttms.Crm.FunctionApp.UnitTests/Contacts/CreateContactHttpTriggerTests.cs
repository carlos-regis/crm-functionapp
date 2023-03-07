using Ttms.Crm.FunctionApp.Triggers;
using Ttms.Crm.FunctionApp.UnitTests.Common;

namespace Ttms.Crm.FunctionApp.UnitTests.Contacts
{
    public class CreateContactHttpTriggerTests : FakeContextTestsBase
    {
        [Fact]
        public async Task CreateContactAsync_CreateContact_GetSameContact()
        {
            // Arrange
            string firstName = "Zeca";
            string lastName = "Diabo";
            string email = "zeca.diabo@gmail.com";

            // Act
            var sut = await CreateContactHttpTrigger.CreateContactAsync(_service, firstName, lastName, email);
            var contacts = _context.CreateQuery("contact").ToList();

            // Assert
            Assert.True(sut.Succeeded);
            Assert.Single(contacts);
            Assert.Equal(firstName, contacts[0]["firstname"]);
            Assert.Equal(lastName, contacts[0]["lastname"]);
            Assert.Equal(email, contacts[0]["emailaddress1"]);
        }
    }
}
