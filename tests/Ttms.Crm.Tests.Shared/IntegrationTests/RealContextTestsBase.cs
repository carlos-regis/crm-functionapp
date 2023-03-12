using FakeXrmEasy;
using FakeXrmEasy.Abstractions;
using Microsoft.PowerPlatform.Dataverse.Client;

namespace Ttms.Crm.Tests.Shared.IntegrationTests
{
    public abstract class RealContextTestsBase
    {
        protected readonly IXrmRealContext context;
        protected readonly IOrganizationServiceAsync2 service;

        protected RealContextTestsBase()
        {
            context = new XrmRealContext(TestConfigurationHelper.GetIConfigurationRoot()["CrmConnectionString"]);
            service = context.GetAsyncOrganizationService2();
        }
    }
}
