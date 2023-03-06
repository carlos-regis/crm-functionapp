using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.ConsentLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.ApplicationId;
using SharedLibraries_Plugins.Repos.ConfigurationParameters;
using SharedLibraries_Plugins.Repos.Consents;
using SharedLibraries_Plugins.Repos.ConsentsText;
using SharedLibraries_Plugins.Repos.Contacts;
using SharedLibraries_Plugins.Repos.ProcessingActivities;

namespace SharedLibraries_Plugins.BusinessLogic.ConsentLogic.Events
{
    public class PostOperationConsentLogicSync
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly Entity postImage;
        private readonly CrmContext crmContext;

        #endregion Variables

        #region Constructor
        public PostOperationConsentLogicSync(ITracingService _tracingService, Entity _entity, Entity _preImage, Entity _postImage, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.postImage = _postImage;
            this.crmContext = _crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                ConsentRepos consentRepos = new ConsentRepos(crmContext);
                ContactRepos contactRepos = new ContactRepos(crmContext);
                ConfigurationParameterRepos configParamRepos = new ConfigurationParameterRepos(crmContext);
                ProcessingActivityRepos processingActivityRepos = new ProcessingActivityRepos(crmContext);
                ApplicationIdRepos applicationIdRepos = new ApplicationIdRepos(crmContext);
                ConsentsTextRepos consentsTextRepos = new ConsentsTextRepos(crmContext);

                if (postImage != null && (postImage.Attributes.Contains(rbtt_consent.Fields.rbtt_ExternalID) &&
                    (postImage.Attributes[rbtt_consent.Fields.rbtt_ExternalID].ToString() != null ||
                    postImage.Attributes[rbtt_consent.Fields.rbtt_ExternalID].ToString() != string.Empty)))
                {
                    HttpRequestAndConsentUpdate hrcu = new HttpRequestAndConsentUpdate(tracingService, postImage, contactRepos,
                                                                                    configParamRepos, processingActivityRepos, applicationIdRepos,
                                                                                    consentsTextRepos, consentRepos);

                    hrcu.RequestAndConsentUpdate_Logic("update");
                }
                else if (preImage != null && (preImage.Attributes.Contains(rbtt_consent.Fields.rbtt_ExternalID) &&
                    (preImage.Attributes[rbtt_consent.Fields.rbtt_ExternalID].ToString() != null ||
                    preImage.Attributes[rbtt_consent.Fields.rbtt_ExternalID].ToString() != string.Empty)))
                {
                    HttpRequestAndConsentUpdate hrcu = new HttpRequestAndConsentUpdate(tracingService, preImage, contactRepos,
                                                                                    configParamRepos, processingActivityRepos, applicationIdRepos,
                                                                                    consentsTextRepos, consentRepos);

                    hrcu.RequestAndConsentUpdate_Logic("delete");
                }

                if ((postImage != null && postImage.Contains(rbtt_consent.Fields.rbtt_Contact2)) ||
                    (preImage != null && preImage.Contains(rbtt_consent.Fields.rbtt_Contact2)))
                {
                    SyncContactChannels scc = new SyncContactChannels(tracingService, entity, preImage, postImage, contactRepos, consentRepos);
                    scc.SyncContactChannels_Logic();
                }

                tracingService.Trace("PostOperationConsentLogicSync.ValidateAndExecute --> Successfully");
            }
            catch (InvalidPluginExecutionException ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
        }
        #endregion Execute
    }
}
