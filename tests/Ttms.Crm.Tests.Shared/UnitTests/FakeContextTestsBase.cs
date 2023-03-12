using FakeXrmEasy.Abstractions;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Middleware;
using FakeXrmEasy.Middleware.Crud;
using Microsoft.PowerPlatform.Dataverse.Client;

namespace Ttms.Crm.Tests.Shared.UnitTests
{
    public abstract class FakeContextTestsBase
    {
        protected readonly IXrmFakedContext fakeContext;
        protected readonly IOrganizationServiceAsync2 fakeService;

        protected FakeContextTestsBase()
        {
            fakeContext = MiddlewareBuilder
                            .New()
                            .AddCrud()
                            .UseCrud()
                            .SetLicense(FakeXrmEasyLicense.NonCommercial)
                            .Build();

            fakeService = fakeContext.GetAsyncOrganizationService2();
        }
    }
}
