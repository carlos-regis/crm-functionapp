using FakeXrmEasy.Abstractions;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Middleware;
using FakeXrmEasy.Middleware.Crud;
using Microsoft.PowerPlatform.Dataverse.Client;

namespace Ttms.Crm.FunctionApp.Tests.FakeXrmEasy
{
    public class FakeXrmEasyTestsBase
    {
        protected readonly IXrmFakedContext _context;
        protected readonly IOrganizationServiceAsync2 _service;

        public FakeXrmEasyTestsBase()
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
