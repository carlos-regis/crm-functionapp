using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Threading.Tasks;

namespace Ttms.Crm.FunctionApp.Domain.Services.Contracts
{
    public interface ICrmService
    {
        IOrganizationServiceAsync2 GetOrganizationService();
        Task<Guid> CreateAsync(Entity entity);
        Task<Entity> RetrieveAsync(string entityName, Guid id, ColumnSet columnSet);
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(string entityName, Guid id);
        //Task<OrganizationResponse> ExecuteAsync(OrganizationRequest request);
        Task<string> GetUserFullNameAsync();
        Task<string> GetVersionAsync();
        Task<Guid> GetUserIdAsync();
    }
}
