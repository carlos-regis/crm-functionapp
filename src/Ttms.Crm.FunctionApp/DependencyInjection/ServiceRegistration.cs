using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using Ttms.Crm.FunctionApp.Configurations;
using Ttms.Crm.FunctionApp.DependencyInjection;
using Ttms.Crm.FunctionApp.Services;
using Ttms.Crm.FunctionApp.Services.Contracts;

[assembly: FunctionsStartup(typeof(ServiceRegistration))]
namespace Ttms.Crm.FunctionApp.DependencyInjection
{
    public class ServiceRegistration : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var services = builder.Services;

            services.AddScoped<ICrmService, CrmService>();

            services.Configure(GetCrmConfiguration());
        }
        private static Action<CrmConfiguration> GetCrmConfiguration()
        {
            return conf =>
            {
                conf.ConnectionString = Environment.GetEnvironmentVariable("CrmConnectionString");
            };
        }
    }
}
