using Microsoft.Extensions.Logging;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Security;
using Ttms.Crm.FunctionApp.V4.Common.Exceptions;
using Ttms.Crm.FunctionApp.V4.Contracts;
using Ttms.Crm.FunctionApp.V4.Helpers;

namespace Ttms.Crm.FunctionApp.V4.Services
{
    public class CrmConnection : ICrmConnection
    {
        private readonly string _connectionString;
        private readonly ILogger _logger;
        private ServiceClient _service;

        public CrmConnection(ILogger logger, string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Connect to the D365 Organization _service using the Dataverse client
        /// </summary>
        /// <returns>Organization _service connection</returns>
        public ServiceClient Connect()
        {
            if (_service != null)
            {
                return _service;
            }

            _service = GetService();
            return _service;
        }

        #region Private Methods

        private ServiceClient GetService()
        {
            _logger.LogInformation("Connecting to dataverse");

            ServiceClient serviceClient = null;

            try
            {
                serviceClient = new ServiceClient(GetServiceConfiguration(_connectionString));
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
        private string GetServiceConfiguration(string connectionString)
        {
            try
            {
                string crmConnectionString = Utils.GetEnvironmentVariables(connectionString);
                if (IsValidConnectionString(crmConnectionString))
                {
                    return crmConnectionString;
                }
                else
                {
                    throw new ArgumentException(string.Format("{0}: Invalid connection string '{1}' provided.", nameof(GetServiceConfiguration), crmConnectionString));
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
