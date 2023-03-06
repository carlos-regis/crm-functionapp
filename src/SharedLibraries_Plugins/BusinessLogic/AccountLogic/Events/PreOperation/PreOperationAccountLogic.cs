using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.AccountLogic.Filter;
using SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic;
using SharedLibraries_Plugins.BusinessLogic.CommonLogic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.AutoNumber;
using SharedLibraries_Plugins.Repos.ClassificationBases;
using SharedLibraries_Plugins.Repos.VisitPlanning;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Events.PreOperation
{
    public class PreOperationAccountLogic
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly AutoNumberRepos autoNumberRepos;
        private readonly CrmContext crmContext;
        private readonly AccountFilter af = new AccountFilter();

        #endregion Variables

        #region Constructor

        public PreOperationAccountLogic(ITracingService _tracingService, Entity _entity, AutoNumberRepos _autoNumberRepos, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.autoNumberRepos = _autoNumberRepos;
            this.crmContext = _crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                AccountRepos accountRepos = new AccountRepos(crmContext);

                if (af.ValidateAutoNrGenerator(entity))
                {
                    AutoNrGenerator ang = new AutoNrGenerator(tracingService, entity, autoNumberRepos);
                    ang.AutoNrGenerator_Logic();
                }
                if (af.ValidateCountVisitPlans(entity))
                {
                    ClassificationBaseRepos classificationBaseRepos = new ClassificationBaseRepos(crmContext);
                    
                    ClassificationBaseInitialization initialization = new ClassificationBaseInitialization(tracingService, entity, classificationBaseRepos);
                    initialization.AccountInitialization();

                    VisitPlanningRepos visitPlanningRepos = new VisitPlanningRepos(crmContext);
                    CountVisitPlans cvp = new CountVisitPlans(tracingService, entity, visitPlanningRepos);
                    cvp.CountVisitPlans_Logic();
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
