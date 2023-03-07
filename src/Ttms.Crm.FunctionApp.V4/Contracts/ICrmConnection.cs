using Microsoft.PowerPlatform.Dataverse.Client;

namespace Ttms.Crm.FunctionApp.V4.Contracts
{
    public interface ICrmConnection
    {
        ServiceClient Connect();
    }
}
