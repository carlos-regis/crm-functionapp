using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.AccountLogic.Filter;
using SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.Countries;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Events.PostOperation
{
    public class PostOperationAccountLogicAsync
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;
        private readonly AccountFilter af = new AccountFilter();

        #endregion Variables

        #region Constructor

        public PostOperationAccountLogicAsync(ITracingService _tracingService, Entity _entity,
                                              Entity _preImage, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.crmContext = _crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                if (af.ValidatePhonePrefix(entity))
                {
                    Account accountToUpdate = new Account();
                    accountToUpdate.Id = entity.Id;

                    CountryRepos countryRepos = new CountryRepos(crmContext);
                    AccountRepos accountRepos = new AccountRepos(crmContext);

                    PhonePrefix pp = new PhonePrefix(tracingService, entity, preImage, accountToUpdate, countryRepos);
                    accountToUpdate = pp.PhonePrefix_Logic();

                    accountRepos.updateAccount(accountToUpdate);
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