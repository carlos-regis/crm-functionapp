using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.BookOfFeedbackLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.BookOfFeedback;
using SharedLibraries_Plugins.Repos.Users;

namespace SharedLibraries_Plugins.BusinessLogic.BookOfFeedbackLogic.Events.PreOperation
{
    public class PreOperationBookOfFeedbackLogic
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly CrmContext crmContext;

        #endregion Variables

        #region Constructor
        public PreOperationBookOfFeedbackLogic(ITracingService _tracingService, Entity _entity, CrmContext _crmContext)
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
                BookOfFeedbackRepos bofRepos = new BookOfFeedbackRepos(crmContext);

                if (entity.Attributes.Contains(rbtt_bookoffeedback.Fields.rbtt_Anonimous) &&
                    entity.GetAttributeValue<bool>(rbtt_bookoffeedback.Fields.rbtt_Anonimous))
                {
                    UserRepos userRepos = new UserRepos(crmContext);

                    SetCreatedByAndModifiedBy scamb = new SetCreatedByAndModifiedBy(tracingService, entity, userRepos);
                    scamb.SetCreatedByAndModifiedBy_Logic();

                    bofRepos.updateBoF((rbtt_bookoffeedback)entity);
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
