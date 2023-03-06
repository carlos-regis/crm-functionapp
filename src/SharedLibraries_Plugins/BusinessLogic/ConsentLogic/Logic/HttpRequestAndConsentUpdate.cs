using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Helpers;
using SharedLibraries_Plugins.Models;
using SharedLibraries_Plugins.Repos.ApplicationId;
using SharedLibraries_Plugins.Repos.ConfigurationParameters;
using SharedLibraries_Plugins.Repos.Consents;
using SharedLibraries_Plugins.Repos.ConsentsText;
using SharedLibraries_Plugins.Repos.Contacts;
using SharedLibraries_Plugins.Repos.ProcessingActivities;
using System;
using System.Web.Script.Serialization;

namespace SharedLibraries_Plugins.BusinessLogic.ConsentLogic.Logic
{
    public class HttpRequestAndConsentUpdate
    {
        #region Variables
        private ITracingService tracingService;
        private Entity entity;
        private Entity consentToUpdate;
        private ContactRepos contactRepos;
        private ConfigurationParameterRepos configParamsRepos;
        private ProcessingActivityRepos procActivityRepos;
        private ApplicationIdRepos applicationIdRepos;
        private ConsentsTextRepos consentsTextRepos;
        private ConsentRepos consentRepos;
        #endregion

        #region Constructor
        public HttpRequestAndConsentUpdate(ITracingService _tracingService, Entity _entity,
                                           ContactRepos _contactRepos, ConfigurationParameterRepos _configParamsRepos,
                                           ProcessingActivityRepos _procActivityRepos, ApplicationIdRepos _applicationIdRepos,
                                           ConsentsTextRepos _consentsTextRepos, ConsentRepos _consentRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.contactRepos = _contactRepos;
            this.configParamsRepos = _configParamsRepos;
            this.procActivityRepos = _procActivityRepos;
            this.applicationIdRepos = _applicationIdRepos;
            this.consentsTextRepos = _consentsTextRepos;
            this.consentRepos = _consentRepos;
        }
        #endregion

        #region Logic

        public void RequestAndConsentUpdate_Logic(string messageName)
        {
            tracingService.Trace("HttpRequestAndConsentUpdate.RequestAndConsentUpdate_Logic --> Started");

            #region Contact Validation
            var contactId = entity.Attributes.Contains(rbtt_consent.Fields.rbtt_Contact2) ?
                                entity.GetAttributeValue<EntityReference>(rbtt_consent.Fields.rbtt_Contact2).Id :
                                Guid.Empty;
            var retrievedContact = contactRepos.retrieveContactById(contactId);
            if (retrievedContact == null)
                tracingService.Trace("The Contact is not in the system. Please contact the administrator.");
                //throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "The Contact is not in the system. Please contact the administrator.");

            //var json = new JavaScriptSerializer().Serialize(retrievedContact);

            if (retrievedContact.Attributes.Contains(Contact.Fields.rbtt_GDPRBlock))
                if (retrievedContact.GetAttributeValue<bool>(Contact.Fields.rbtt_GDPRBlock))
                    tracingService.Trace("The Contact you selected already has the GDPR blocked.");
                    //throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "The Contact you selected already has the GDPR blocked.");

            if (!retrievedContact.Attributes.Contains(Contact.Fields.EMailAddress1))
                tracingService.Trace("The Contact you selected has no email address assigned.");
                //throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "The Contact you selected has no email address assigned.");

            #endregion

            #region Processing Activity Validation
            var processingActivityId = entity.Attributes.Contains(rbtt_consent.Fields.rbtt_ProcessingActivity) ?
                                        entity.GetAttributeValue<EntityReference>(rbtt_consent.Fields.rbtt_ProcessingActivity).Id :
                                        Guid.Empty;
            var retrievedProcessingActivity = procActivityRepos.retrievedProcessingActivityById(processingActivityId);
            if (retrievedProcessingActivity == null)
                tracingService.Trace("The Processing Activity is not in the system. Please contact the administrator.");
                //throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "The Processing Activity is not in the system. Please contact the administrator.");
                
            if (!retrievedProcessingActivity.Attributes.Contains(rbtt_processingactivity.Fields.rbtt_Activityname))
                tracingService.Trace("External ID is missing in the selected Processing Activity.");
                //throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "External ID is missing in the selected Processing Activity.");
            #endregion

            #region Consent Text Validation
            var contextTextId = entity.Attributes.Contains(rbtt_consent.Fields.rbtt_ConsentTexts) ?
                                        entity.GetAttributeValue<EntityReference>(rbtt_consent.Fields.rbtt_ConsentTexts).Id :
                                        Guid.Empty;
            var retrievedConsentText = consentsTextRepos.retrieveConsentTextById(contextTextId);
            if (retrievedConsentText == null)
                throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "The Consent Text is not in the system. Please contact the administrator.");

            if (retrievedConsentText.Attributes.Contains(rbtt_consenttext.Fields.rbtt_ExternalID))
            {
                if (retrievedConsentText.GetAttributeValue<string>(rbtt_consenttext.Fields.rbtt_ExternalID) == string.Empty)
                    tracingService.Trace("ExternalId is missing in the selected Consent Text.");
                //throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "ExternalId is missing in the selected Consent Text.");
            }
            else
                tracingService.Trace("ExternalId is missing in the selected Consent Text.");
                //throw new InvalidPluginExecutionException(OperationStatus.Canceled, 10001, "ExternalId is missing in the selected Consent Text.");

            #endregion

            #region SetConsentObject
            tracingService.Trace("Registering the Consent in the Consent Tool --> Started");
            ConsentObject consentObject = new ConsentObject();

            SetConsentObject(consentObject, retrievedContact, retrievedProcessingActivity, retrievedConsentText, messageName);

            tracingService.Trace($"-- CONSENT OBJECT -- \n jsonBody: {consentObject.jsonBody} \n frameURL: {consentObject.frameURL} \n proxy: {consentObject.proxy}");
            
            #endregion
           
            var result = RequestAPI.POST_Request(consentObject.frameURL, consentObject.bearer_token, consentObject.proxy, consentObject.jsonBody);
            tracingService.Trace($"-- REQUEST RESPONSE -- \n {result}");

            if (result != null)
            {
                try
                {
                    rbtt_consent consentToUpdate = new rbtt_consent();
                    consentToUpdate.Id = entity.Id;

                    if (messageName == "create")
                    {
                        ConsentsCreateResponseObject consentResponseObject = new ConsentsCreateResponseObject();
                        consentResponseObject = new JavaScriptSerializer().Deserialize<ConsentsCreateResponseObject>(result);

                        consentToUpdate[rbtt_consent.Fields.rbtt_ExternalID] = consentResponseObject.id;
                        consentToUpdate[rbtt_consent.Fields.rbtt_GDPRLockConsents] = true;
                        consentToUpdate[rbtt_consent.Fields.rbtt_GDPRTrackingDate] = DateTime.UtcNow;
                    }
                    else if (messageName == "update")
                    {
                        ConsentsUpdateResponseObject consentResponseObject = new ConsentsUpdateResponseObject();
                        consentResponseObject = new JavaScriptSerializer().Deserialize<ConsentsUpdateResponseObject>(result);

                        consentToUpdate[rbtt_consent.Fields.rbtt_GDPRTrackingDate] = DateTime.UtcNow;
                    }
                    else return;

                    consentRepos.updateConsent(consentToUpdate);
                }
                catch (InvalidPluginExecutionException ex)
                {
                    throw new InvalidPluginExecutionException(ex.Status, ex.ErrorCode, ex.Message, ex.HttpStatus);
                }
            }
            tracingService.Trace("HttpRequestAndConsentUpdate.RequestAndConsentUpdate_Logic --> Ending");

            tracingService.Trace("Registering the Consent in the Consent Tool --> Ended");
        }

        #endregion

        #region Private Methods

        private void SetConsentObject(ConsentObject consentObject, Contact retrievedContact, rbtt_processingactivity retrievedProcessingActivity, rbtt_consenttext retrievedConsentText, string messageName)
        {
            tracingService.Trace("HttpRequestAndConsentUpdate.SetConsentObject --> STARTING");

            var retrievedConfigs = configParamsRepos.retrieveMultipleConfigForConsents_Create();

            if (retrievedConfigs.Count > 0)
            {
                string frameURL = string.Empty;

                foreach (rbtt_configurations config in retrievedConfigs)
                {
                    if (config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_name) == "GDPR Access Token URL")
                        consentObject.access_token_url = config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value);

                    else if (config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_name) == "GDPR Consent Activity Services - Post Create")
                    {
                        string applicationidValues;

                        if (((OptionSetValue)entity.Attributes[rbtt_consent.Fields.rbtt_StorageTyp]).Value != (int)rbtt_consent_rbtt_StorageTyp.Localpaperfilesystem)
                        {
                            var applicationId = entity.GetAttributeValue<EntityReference>(rbtt_consent.Fields.rbtt_SourceApplication2).Id;

                            var retrievedApplicationId = applicationIdRepos.retrievedApplicationIdById(applicationId);

                            applicationidValues = retrievedApplicationId.Attributes.Contains(rbtt_applicationid.Fields.rbtt_ApplicationIDValues) ?
                                                    retrievedApplicationId.GetAttributeValue<string>(rbtt_applicationid.Fields.rbtt_ApplicationIDValues) :
                                                    config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_AdditionalValue);

                        }
                        else applicationidValues = config.Attributes[rbtt_configurations.Fields.rbtt_AdditionalValue].ToString();

                        consentObject.sourceApplicationId = applicationidValues;

                        string activityId = retrievedProcessingActivity.GetAttributeValue<string>(rbtt_processingactivity.Fields.rbtt_Activityname);

                        frameURL = config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value).Replace("{activityId}", activityId).Replace("{applicationid}", applicationidValues);
                    }

                    else if (config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_name) == "GDPR Base URL")
                        consentObject.authorize_url = config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value);

                    else if (config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_name) == "GDPR Client ID")
                        consentObject.client_id = config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value);

                    else if (config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_name) == "GDPR Client Secret")
                        consentObject.client_secret = config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value);

                    else if (config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_name) == "GDPR Proxy Settings - JOB")
                    {
                        consentObject.proxy_url = config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_Value);
                        consentObject.proxy_port = int.Parse(config.GetAttributeValue<string>(rbtt_configurations.Fields.rbtt_AdditionalValue));
                    }
                }

                consentObject.subjectIdentifier = retrievedContact.GetAttributeValue<string>(Contact.Fields.EMailAddress1);
                consentObject.consentTextRevision = Convert.ToInt16(retrievedConsentText.GetAttributeValue<string>(rbtt_consenttext.Fields.rbtt_ExternalID));
                consentObject.documentedOn = entity.Attributes.Contains(rbtt_consent.Fields.rbtt_Acceptedon) ?
                                                entity.GetAttributeValue<DateTime>(rbtt_consent.Fields.rbtt_Acceptedon).ToString("yyyy-MM-ddTHH:mm:ssZ") :
                                                string.Empty;

                consentObject.lastUsed = entity.Attributes.Contains(rbtt_consent.Fields.rbtt_LastActivity) ?
                                            entity.GetAttributeValue<DateTime>(rbtt_consent.Fields.rbtt_LastActivity).ToString("yyyy-MM-ddTHH:mm:ssZ") :
                                            string.Empty;

                consentObject.storageType = entity.GetAttributeValue<OptionSetValue>(rbtt_consent.Fields.rbtt_StorageTyp).Value == (int)rbtt_consent_rbtt_StorageTyp.Insourcesystem ?
                                                1 :
                                                entity.GetAttributeValue<OptionSetValue>(rbtt_consent.Fields.rbtt_StorageTyp).Value == (int)rbtt_consent_rbtt_StorageTyp.Localpaperfilesystem ?
                                                    2 :
                                                    3;

                consentObject.storageLocation = entity.Attributes.Contains(rbtt_consent.Fields.rbtt_StorageLocation) ?
                                                    entity.GetAttributeValue<string>(rbtt_consent.Fields.rbtt_StorageLocation) :
                                                    string.Empty;

                //consentObject.proxy = $"{consentObject.proxy_url}:{consentObject.proxy_port}";
                consentObject.bearer_token = RequestAPI.TOKEN_Request(consentObject.client_id, consentObject.client_secret, consentObject.access_token_url);

                if (messageName == "create")
                {
                    consentObject.frameURL = frameURL + "consent/";
                    consentObject.jsonBody = new JavaScriptSerializer().Serialize(new
                    {
                        subjectIdentifier = consentObject.subjectIdentifier,
                        sourceApplicationId = consentObject.sourceApplicationId,
                        consentTextRevision = consentObject.consentTextRevision
                    });
                }
                else if (messageName == "update")
                {
                    consentObject.frameURL = frameURL + "refresh?subject=" + consentObject.subjectIdentifier;
                    consentObject.jsonBody = new JavaScriptSerializer().Serialize(new
                    { });
                }
                else
                {
                    consentObject.frameURL = frameURL + "withdraw/";
                    consentObject.jsonBody = new JavaScriptSerializer().Serialize(new
                    {
                        subjectIdentifier = consentObject.subjectIdentifier,
                        sourceApplicationId = consentObject.sourceApplicationId
                    });
                }

                tracingService.Trace("HttpRequestAndConsentUpdate.SetConsentObject --> ENDING");
            }
            else throw new InvalidPluginExecutionException("Configuration Parameters not Found. Please contact the administrator");
        }

        #endregion
    }
}