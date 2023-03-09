using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Xrm.Sdk;
using Ttms.Crm.FunctionApp.Domain.Helpers;

namespace Ttms.Crm.FunctionApp.UnitTests.Domain.Helpers
{
    public class CrmUtilsTests
    {

        [Theory]
        [InlineData("{\"MessageName\": \"Create\", \"Depth\": 1, \"Stage\": 20}")]
        [InlineData("{\"MessageName\": \"Update\", \"Depth\": 2, \"Stage\": 50}")]
        [InlineData("{\"MessageName\": \"Create\", \"Depth\": 3}")]
        [InlineData("{\"MessageName\": \"Update\", \"Depth\": 5}")]
        [InlineData("{\"MessageName\": \"Delete\"}")]
        [InlineData("{\"MessageName\": \"Retrieve\"}")]
        [InlineData("{\"InvalidKey\": \"InvalidValue\"}")]
        public void ValidateContext_InvalidContext_False(string jsonContext)
        {
            // Arrange

            // Act
            bool sut = CrmUtils.ValidateContext(CrmUtils.GetContext(jsonContext), NullLogger.Instance);

            // Assert
            Assert.False(sut);
        }

        [Fact]
        public void GetContext_ValidJson_CorrectRemoteExecutionContext()
        {
            // Arrange
            string jsonContext = "{\"Depth\": 2, \"MessageName\": \"Update\"}";

            // Act
            RemoteExecutionContext sut = CrmUtils.GetContext(jsonContext);

            // Act
            Assert.IsType<RemoteExecutionContext>(sut);
            Assert.Equal("Update", sut.MessageName.ToString());
            Assert.Equal(2, sut.Depth);
        }

        [Theory]
        [InlineData("{invalid}")]
        [InlineData("{'name': ''}")]
        [InlineData("")]
        public void GetContext_InvalidJson_ThrowsArgumentException(string jsonContext)
        {
            // Arrange

            // Act & Assert
            Assert.Throws<ArgumentException>(() => CrmUtils.GetContext(jsonContext));
        }
    }
}
