using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Security;
using Ttms.Crm.FunctionApp.Helpers;

namespace Ttms.Crm.FunctionApp.Helper
{
    public class CrmConnection
    {
        private readonly ILogger _logger;

        public CrmConnection(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Connect to the D365 Organization service using XRM tooling connector
        /// </summary>
        /// <param name="connectionString">The name of the connection string to return</param>
        /// <returns>Organization service connection</returns>
        public CrmServiceClient Connect(string connectionString)
        {
            CrmServiceClient service = null;
            try
            {
                _logger.LogInformation("Setting up connection");

                // Connect to the CRM web service using a connection string.
                service = new CrmServiceClient(GetServiceConfiguration(connectionString));
                if (service.IsReady)
                {
                    return service;
                }
                else
                {
                    if (service.LastCrmError.Contains(Constants.ERROR_UNABLE_TO_LOGIN))
                    {
                        _logger.LogError(string.Format("{0}: {1}", nameof(Connect), service.LastCrmError));
                        throw new InvalidOperationException(service.LastCrmError);
                    }
                    else
                    {
                        _logger.LogError(string.Format("{0}: {1}", nameof(Connect), service.LastCrmException.ToString()));
                        throw service.LastCrmException;
                    }
                }
            }
            catch (Exception ex) when (ex is TimeoutException || ex is SecurityTokenValidationException ||
                                       ex is ExpiredSecurityTokenException || ex is MessageSecurityException ||
                                       ex is SecurityNegotiationException || ex is SecurityAccessDeniedException ||
                                       ex is FaultException<OrganizationServiceFault>)
            {
                HandleException(ex);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }

            return service;
        }

        #region Private Methods

        /// <summary>
        /// A function to manage exceptions thrown by the app
        /// </summary>
        /// <param name="exception">The exception thrown</param>
        private void HandleException(Exception ex)
        {
            _logger.LogError(string.Format("{0}: {1}.", nameof(Connect), ex.ToString()));

            if (ex.InnerException != null)
            {
                HandleException(ex.InnerException);
            }
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
                string crmConnectionString = Common.GetEnvironmentVariables(connectionString);
                if (IsValidConnectionString(crmConnectionString))
                {
                    return crmConnectionString;
                }
                else
                {
                    throw new ArgumentException(string.Format("{0}: Invalid connection string '{1}'.", nameof(GetServiceConfiguration), crmConnectionString));
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
            return connectionString.Contains("URL=") ||
                   connectionString.Contains("Server=") ||
                   connectionString.Contains("ServiceUri=");
        }

        #endregion Private Methods
    }
}

