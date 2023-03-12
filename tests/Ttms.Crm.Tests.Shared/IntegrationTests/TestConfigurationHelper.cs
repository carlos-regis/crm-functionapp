using Microsoft.Extensions.Configuration;

namespace Ttms.Crm.Tests.Shared.IntegrationTests
{
    public static class TestConfigurationHelper
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
