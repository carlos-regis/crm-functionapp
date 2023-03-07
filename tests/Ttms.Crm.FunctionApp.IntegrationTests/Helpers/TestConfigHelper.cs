using Microsoft.Extensions.Configuration;

namespace Ttms.Crm.FunctionApp.IntegrationTests.Helpers
{
    public static class TestConfigHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
