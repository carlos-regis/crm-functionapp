using FakeXrmEasy.Abstractions;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Middleware;
using FakeXrmEasy.Middleware.Crud;
using Microsoft.PowerPlatform.Dataverse.Client;

namespace Ttms.Crm.FunctionApp.UnitTests.Common
{
    public abstract class FakeContextTestsBase
    {
        protected readonly IXrmFakedContext _context;
        protected readonly IOrganizationServiceAsync2 _service;

        protected FakeContextTestsBase()
        {
            _context = MiddlewareBuilder
                            .New()
                            .AddCrud()
                            .UseCrud()
                            .SetLicense(FakeXrmEasyLicense.NonCommercial)
                            .Build();

            _service = _context.GetAsyncOrganizationService2();
        }
    }
}
