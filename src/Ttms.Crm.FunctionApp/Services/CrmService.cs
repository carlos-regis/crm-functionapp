using Microsoft.Crm.Sdk.Messages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Threading.Tasks;
using Ttms.Crm.FunctionApp.Common.Exceptions;
using Ttms.Crm.FunctionApp.Configurations;
using Ttms.Crm.FunctionApp.Helpers;
using Ttms.Crm.FunctionApp.Services.Contracts;

namespace Ttms.Crm.FunctionApp.Services
{
    public class CrmService : ICrmService
    {
        private readonly IOrganizationServiceAsync2 _crmService;
        private readonly ILogger<ICrmService> _logger;

        public CrmService(IOptions<CrmConfiguration> configuration,
                          ILogger<ICrmService> logger)
        {
            if (_crmService != null)
            {
                return;
            }
            _crmService = GetService(configuration.Value.ConnectionString);

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Guid> CreateAsync(Entity entity)
        {
            _logger.LogInformation("Creating Entity with Id: '{Id}'", entity.Id);
            return await _crmService.CreateAsync(entity);
        }

        public async Task<Entity> RetrieveAsync(string entityName, Guid id, ColumnSet columnSet)
        {
            _logger.LogInformation("Retrieving Entity {Entity} with Id: '{Id}'", entityName, id);
            return await _crmService.RetrieveAsync(entityName, id, columnSet);
        }

        public async Task UpdateAsync(Entity entity)
        {
            _logger.LogInformation("Updating Entity with Id: '{Id}'", entity.Id);
            await _crmService.UpdateAsync(entity);
        }

        public async Task DeleteAsync(string entityName, Guid id)
        {
            _logger.LogInformation("Deleting Entity {Entity} with Id: '{Id}'", entityName, id);
            await _crmService.DeleteAsync(entityName, id);
        }

        Task<OrganizationResponse> ICrmService.ExecuteAsync(OrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>Obtain information about the logged on user from the web service.</summary>
        /// <param name="service">The service to use to get the user's full name.</param>
        /// <returns>Logged on user's full name</returns>
        public string GetUserFullName()
        {
            Guid userid = ((WhoAmIResponse)_crmService.Execute(new WhoAmIRequest())).UserId;
            Entity systemUser = _crmService.Retrieve("systemuser", userid, new ColumnSet("fullname"));

            return systemUser.GetAttributeValue<string>("fullname");
        }

        /// <summary> Retrieve the version of Microsoft Dynamics CRM. </summary>
        /// <param name="service">The service to use to get the version.</param>
        /// <returns>Dynamics 365 version</returns>
        public string GetVersion()
        {
            return ((RetrieveVersionResponse)_crmService.Execute(new RetrieveVersionRequest())).Version;
        }

        #region Private Methods

        /// <summary>
        /// Connect to the D365 Organization _service using the Dataverse client
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns>Organization service </returns>
        private IOrganizationServiceAsync2 GetService(string connectionString)
        {
            _logger.LogInformation("Connecting to dataverse");

            ServiceClient serviceClient = null;

            try
            {
                // TODO: Reorganize flow control using Operation Result pattern without exceptions
                serviceClient = new ServiceClient(CheckServiceConfiguration(connectionString));
                if (serviceClient.IsReady)
                {
                    return serviceClient;
                }
                else
                {
                    if (serviceClient.LastError.Contains(Constants.ERROR_UNABLE_TO_LOGIN))
                    {
                        _logger.LogError("{Function}: {Error}", nameof(GetService), serviceClient.LastError);
                        throw new InvalidOperationException(serviceClient.LastError);
                    }
                    else
                    {
                        _logger.LogError("{Function}: {Exception}", nameof(GetService), serviceClient.LastException.ToString());
                        throw serviceClient.LastException;
                    }
                }
            }
            catch (Exception ex) when (ex is TimeoutException || ex is SecurityTokenValidationException ||
                                       ex is MessageSecurityException || ex is SecurityNegotiationException ||
                                       ex is SecurityAccessDeniedException || ex is FaultException<OrganizationServiceFault>)
            {
                _logger.LogError("{Function}: {Exception}.", nameof(GetService), ex.ToString());
                CrmExceptions.HandleException(ex);
            }
            catch (Exception ex)
            {
                _logger.LogError("{Function}: {Exception}.", nameof(GetService), ex.ToString());
                CrmExceptions.HandleException(ex);
            }

            return serviceClient;
        }

        /// <summary>
        /// Gets a named connection string from App.config
        /// </summary>
        /// <param name="connectionString">The name of the connection string to return</param>
        /// <returns>The named connection string</returns>
        private string CheckServiceConfiguration(string connectionString)
        {
            try
            {
                if (IsValidConnectionString(connectionString))
                {
                    return connectionString;
                }
                else
                {
                    throw new ArgumentException(string.Format("{0}: Invalid connection string '{1}' provided.", nameof(CheckServiceConfiguration), connectionString));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// Validates if a connection string is valid for Dynamics 365.
        /// </summary>
        /// <param name="connectionString">The name of the connection string to validate</param>
        /// <returns>True for a valid string, otherwise False.</returns>
        private static bool IsValidConnectionString(string connectionString)
        {
            // At a minimum, a connection string must contain one of these arguments.
            return connectionString.Contains("Url=") ||
                   connectionString.Contains("Server=") ||
                   connectionString.Contains("ServiceUri=");
        }
        #endregion Private Methods
    }
}
