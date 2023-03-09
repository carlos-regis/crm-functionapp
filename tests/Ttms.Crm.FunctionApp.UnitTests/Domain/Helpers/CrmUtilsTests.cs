using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Xrm.Sdk;
using Ttms.Crm.FunctionApp.Domain.Helpers;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.UnitTests.Helpers;

namespace Ttms.Crm.FunctionApp.UnitTests.Domain.Helpers
{
    public class CrmUtilsTests
    {
        #region ValidateContextTests

        [Fact]
        public void ValidateContext_JsonFileAccountUpdate_TrueNotNullEntityNullPostImage()
        {
            // Arrange
            string jsonContext = Utils.LoadData(Constants.AccountUpdateJsonFile);

            // Act
            bool sut = CrmUtils.ValidateContext(CrmUtils.GetRemoteExecutionContextFromJson(jsonContext),
                                                Account.EntityLogicalName,
                                                NullLogger.Instance,
                                                out Entity entity,
                                                out Entity preImage,
                                                out Entity postImage);

            // Assert
            Assert.True(sut);
            Assert.NotNull(entity);
            Assert.Null(preImage);
            Assert.Null(postImage);
        }

        [Fact]
        public void ValidateContext_NullInputParametersTarget_FalseNullEntityNullPostImage()
        {
            // Arrange

            // Act
            bool sut = CrmUtils.ValidateContext(new RemoteExecutionContext(),
                                                Account.EntityLogicalName,
                                                NullLogger.Instance,
                                                out Entity entity,
                                                out Entity preImage,
                                                out Entity postImage);

            // Assert
            Assert.False(sut);
            Assert.Null(entity);
            Assert.Null(preImage);
            Assert.Null(postImage);
        }

        #endregion ValidateContextTests

        #region GetContextTests

        [Fact]
        public void GetContext_ValidJson_CorrectRemoteExecutionContext()
        {
            // Arrange
            string jsonContext = "{\"Depth\": 2, \"MessageName\": \"Update\"}";

            // Act
            RemoteExecutionContext sut = CrmUtils.GetRemoteExecutionContextFromJson(jsonContext);

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
            Assert.Throws<ArgumentException>(() => CrmUtils.GetRemoteExecutionContextFromJson(jsonContext));
        }

        #endregion GetContextTests
    }
}
