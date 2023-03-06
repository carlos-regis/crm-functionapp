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
    public class PostOperationSetStateConsentLogicSync
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly CrmContext crmContext;

        #endregion Variables

        #region Constructor
        public PostOperationSetStateConsentLogicSync(ITracingService _tracingService, Entity _entity, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
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

                HttpRequestAndConsentUpdate hrcu = new HttpRequestAndConsentUpdate(tracingService, entity, contactRepos,
                                                                                configParamRepos, processingActivityRepos, applicationIdRepos,
                                                                                consentsTextRepos, consentRepos);

                hrcu.RequestAndConsentUpdate_Logic("create");
            }
            catch (InvalidPluginExecutionException ex)
            {
                switch (ex.ErrorCode)
                {
                    case 10001:
                        tracingService.Trace("\n\nInvalidPluginExecutionException\n-----------------------------------------------\n" +
                                            "\nStatus:\n" + ex.Status.ToString() +
                                            "\nErrorCode:\n" + ex.ErrorCode.ToString() +
                                            "\nErro Message:\n" + ex.Message.ToString() +
                                            "\nData:\n" + ex.Data.ToString() +
                                            "\nHResult:\n" + ex.HResult.ToString() +
                                            "\nInnerException:\n" + ex.InnerException.ToString() +
                                            "\nSource:\n" + ex.Source.ToString() +
                                            "\nHelpLink:\n" + ex.HelpLink.ToString() +
                                            "\n\n-----------------------------------------------\n\n");
                        break;

                    default:
                        throw new InvalidPluginExecutionException(ex.Status, ex.ErrorCode, ex.Message, ex.HttpStatus);

                }
                /*throw new InvalidPluginExecutionException("\n\nInvalidPluginExecutionException\n-----------------------------------------------\n" +
                                    "\nStatus:\n" + Ex.Status.ToString() +
                                    "\nErrorCode:\n" + Ex.ErrorCode.ToString() +
                                    "\nErro Message:\n" + Ex.Message.ToString() +
                                    "\nData:\n" + Ex.Data.ToString() +
                                    "\nHResult:\n" + Ex.HResult.ToString() +
                                    "\nInnerException:\n" + Ex.InnerException.ToString() +
                                    "\nSource:\n" + Ex.Source.ToString() +
                                    "\nHelpLink:\n" + Ex.HelpLink.ToString() +
                                    "\n\n-----------------------------------------------\n\n");
                */
            }
        }

        #endregion Execute
    }
}
