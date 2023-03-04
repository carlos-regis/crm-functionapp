using Microsoft.Azure.WebJobs.Host;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Security;

namespace Ttms.Crm.FunctionApp.Helper
{
    public class CrmConnection
    {

        private readonly TraceWriter _logger;

        public CrmConnection(TraceWriter logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Connect to the D365 Organization service using XRM tooling connector
        /// </summary>
        /// <param name="log"></param>
        /// <returns>Organization service connection</returns>
        public CrmServiceClient Run()
        {
            CrmServiceClient crmServiceClient = null;
            try
            {
                _logger.Info("Setting up Dynamics 365 connection");

                // Connect to the CRM web service using a connection string.
                crmServiceClient = new CrmServiceClient(GetServiceConfiguration());

                // Cast the proxy client to the IOrganizationService interface.
                IOrganizationService orgService = crmServiceClient.OrganizationWebProxyClient != null ?
                    (IOrganizationService)crmServiceClient.OrganizationWebProxyClient :
                    (IOrganizationService)crmServiceClient.OrganizationServiceProxy;

                // Obtain information about the logged on user from the web service.
                Guid userId = ((WhoAmIResponse)orgService.Execute(new WhoAmIRequest())).UserId;

                // Lookup user
                Entity systemUser = orgService.Retrieve("systemuser", userId, new ColumnSet("fullname"));
                _logger.Info(string.Format("Logged on user is {0}.", systemUser.GetAttributeValue<string>("fullname")));

                // Retrieve the version of Microsoft Dynamics CRM.
                RetrieveVersionResponse versionResponse =
                    (RetrieveVersionResponse)orgService.Execute(new RetrieveVersionRequest());
                _logger.Info(string.Format("Microsoft Dynamics CRM version {0}.", versionResponse.Version));

                if (crmServiceClient is object && crmServiceClient.IsReady)
                {
                    _logger.Info("Validating connection");
                    if (crmServiceClient.ConnectedOrgId != null)
                    {
                        _logger.Info(string.Format("Organization Id: {0}", crmServiceClient.ConnectedOrgId));
                    }
                    else
                    {
                        throw new InvalidOperationException("Failed to Established CrmConnection!");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Failed to Established CrmConnection!");
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

            return crmServiceClient;
        }

        #region Private Methods

        /// Handle a thrown exception.
        /// </summary>
        /// <param name="ex">An exception.</param>
        private void HandleException(Exception exception)
        {
            _logger.Error(string.Format("CrmConnection: {0}", exception.Message));

            if (exception.InnerException != null)
            {
                HandleException(exception.InnerException);
            }
        }

        /// <summary>
        /// Set the connection string for the service
        /// </summary>
        /// <param name="_logger"></param>
        /// <returns></returns>
        private String GetServiceConfiguration()
        {
            string crmConnectionString = Common.GetEnvironmentVariables(_logger, "crmConnectionString");
            if (IsValidConnectionString(crmConnectionString))
            {
                return crmConnectionString;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Verifies if a connection string is valid for Microsoft Dynamics CRM.
        /// </summary>
        /// <returns>True for a valid string, otherwise False.</returns>
        private static Boolean IsValidConnectionString(String connectionString)
        {
            // At a minimum, a connection string must contain one of these arguments.
            if (connectionString.Contains("URL=") ||
                connectionString.Contains("Server=") ||
                connectionString.Contains("ServiceUri="))
                return true;

            return false;
        }

        #endregion Private Methods
    }
}

