using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.ProductRegistrations;

namespace SharedLibraries_Plugins.BusinessLogic.ProductRegistrationLogic.Events.PostOperation
{
    public class PostOperationProductRegistrationLogicSync
    {
        #region Variables
        private readonly ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;
        #endregion

        #region Constructor
        public PostOperationProductRegistrationLogicSync(ITracingService _tracingService, Entity _entity, Entity _preImage, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.crmContext = _crmContext;
        }
        #endregion

        public void ValidateAndExecute()
        {
            try
            {
                if (entity.Contains(Orb_machine.Fields.rbtt_AccountId) && preImage.Contains(Orb_machine.Fields.rbtt_AccountId))
                {
                    tracingService.Trace("CountProductRegistrations_Logic --> Starting");

                    ProductRegistrationRepos productRegistrationRepos = new ProductRegistrationRepos(crmContext);
                    AccountRepos accountRepos = new AccountRepos(crmContext);

                    CountProductRegistrations cop = new CountProductRegistrations(tracingService, entity, preImage, productRegistrationRepos, accountRepos);
                    cop.CountProductRegistrations_Logic();

                    tracingService.Trace("CountProductRegistrations_Logic --> Ending");
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
    }
}
