using Microsoft.PowerPlatform.Dataverse.Client;

namespace Ttms.Crm.FunctionApp.Contracts
{
    public interface ICrmConnection
    {
        ServiceClient Connect();
    }
}
