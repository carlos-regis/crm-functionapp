using Microsoft.Xrm.Sdk;
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
            var contact = new Entity("contact")
            {
                ["firstname"] = "Zeca",
                ["lastname"] = "Unit Test",
                ["emailaddress1"] = "zeca.unittest@gmail.com"
            };

            // Act
            var sut = await CreateContactHttpTrigger.CreateContactAsync(contact);
            var contacts = _context.CreateQuery("contact").ToList();

            // Assert
            Assert.True(sut.Success);
            Assert.Single(contacts);
            Assert.Equal(contact["firstname"], contacts?[0]["firstname"]);
            Assert.Equal(contact["lastname"], contacts?[0]["lastname"]);
            Assert.Equal(contact["emailaddress1"], contacts?[0]["emailaddress1"]);
        }
    }
}
