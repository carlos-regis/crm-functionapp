using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Xrm.Sdk;
using Ttms.Crm.FunctionApp.Domain.Models;
using Ttms.Crm.FunctionApp.Domain.Services;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.Triggers.Demo;
using Ttms.Crm.FunctionApp.UnitTests.Common;
using Task = System.Threading.Tasks.Task;

namespace Ttms.Crm.FunctionApp.UnitTests.Triggers.Demo
{
    public class CreateContactHttpTriggerTests : FakeContextTestsBase
    {
        private readonly CrmService fakeCrmService;

        public CreateContactHttpTriggerTests()
        {
            fakeCrmService = new(fakeService, new NullLogger<CrmService>());
        }

        private CreateContactHttpTrigger CreateCreateContactHttpTrigger()
        {
            return new CreateContactHttpTrigger(fakeCrmService);
        }

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

            var createContactHttpTrigger = CreateCreateContactHttpTrigger();

            //// Act
            var sut = await createContactHttpTrigger.CreateContactAsync(contact);
            var contacts = fakeContext.CreateQuery<Contact>().ToList();

            // Assert
            Assert.IsType<CrmResponse>(sut);
            Assert.Single(contacts);
            Assert.True(contacts[0].Contains("firstname"));
            Assert.True(contacts[0].Contains("lastname"));
            Assert.True(contacts[0].Contains("emailaddress1"));
            Assert.Equal(contact["firstname"], contacts[0]["firstname"]);
            Assert.Equal(contact["lastname"], contacts[0]["lastname"]);
            Assert.Equal(contact["emailaddress1"], contacts[0]["emailaddress1"]);
        }
    }
}
