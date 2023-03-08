﻿using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Threading.Tasks;

namespace Ttms.Crm.FunctionApp.Services.Contracts
{
    public interface ICrmService
    {
        Task<Guid> CreateAsync(Entity entity);
        Task<Entity> RetrieveAsync(string entityName, Guid id, ColumnSet columnSet);
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(string entityName, Guid id);
        Task<OrganizationResponse> ExecuteAsync(OrganizationRequest request);
        string GetUserFullName();
        string GetVersion();
    }
}
