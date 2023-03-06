using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.CommonLogic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.AutoNumber;
using SharedLibraries_Plugins.Repos.Contacts;

namespace SharedLibraries_Plugins.BusinessLogic.ContactLogic.Events.PreOperation
{
    public class PreOperationContactLogicSync
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly CrmContext crmContext;

        #endregion Variables

        #region Constructor
        public PreOperationContactLogicSync(ITracingService _tracingService, Entity _entity, CrmContext _crmContext)
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
                ContactRepos contactRepos = new ContactRepos(crmContext);

                if (!entity.Attributes.Contains(Contact.Fields.btt_CRMContactNumber))
                {
                    AutoNumberRepos autoNumberRepos = new AutoNumberRepos(crmContext);

                    AutoNrGenerator ang = new AutoNrGenerator(tracingService, entity, autoNumberRepos);
                    ang.AutoNrGenerator_Logic();
                }
            }
            catch (InvalidPluginExecutionException Ex)
            {
                throw new InvalidPluginExecutionException("\n\nInvalidPluginExecutionException\n-----------------------------------------------\n" +
                                    "\nErro Message:\n" + Ex.Message.ToString() +
                                    "\nErrorCode:\n" + Ex.ErrorCode.ToString() +
                                    "\nData:\n" + Ex.Data.ToString() +
                                    "\nHResult:\n" + Ex.HResult.ToString() +
                                    "\nInnerException:\n" + Ex.InnerException.ToString() +
                                    "\nSource:\n" + Ex.Source.ToString() +
                                    "\nStatus:\n" + Ex.Status.ToString() +
                                    "\nStatus:\n" + Ex.Status.ToString() +
                                    "\nHelpLink:\n" + Ex.HelpLink.ToString() +
                                    "\n\n-----------------------------------------------\n\n");
            }
        }

        #endregion Execute
    }
}
