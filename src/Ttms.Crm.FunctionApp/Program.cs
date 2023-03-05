using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;

namespace Ttms.Crm.FunctionApp
{
    internal class Program
    {
        static void Main(string[] _)
        {
            FunctionsDebugger.Enable();

            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .Build();

            host.Run();
        }
    }
}
