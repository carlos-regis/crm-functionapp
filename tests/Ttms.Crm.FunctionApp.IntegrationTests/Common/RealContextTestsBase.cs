using FakeXrmEasy;
using FakeXrmEasy.Abstractions;
using Microsoft.PowerPlatform.Dataverse.Client;
using Ttms.Crm.FunctionApp.IntegrationTests.Helpers;

namespace Ttms.Crm.FunctionApp.IntegrationTests.Common
{
    public abstract class RealContextTestsBase
    {
        protected readonly IXrmRealContext _context;
        protected readonly IOrganizationServiceAsync2 _service;

        protected RealContextTestsBase()
        {
            _context = new XrmRealContext(TestConfigHelper.GetIConfigurationRoot()["CrmConnectionString"]);
            _service = _context.GetAsyncOrganizationService2();
        }
    }
}
