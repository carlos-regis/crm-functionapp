using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Filter;
using Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Logic;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.Shared.Repos.Accounts;
using Ttms.Crm.FunctionApp.Shared.Repos.Countries;

namespace Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Events.PostOperation
{
    public class PostOperationAccountLogicAsync
    {
        #region Variables

        private readonly ILogger _logger;
        private readonly Entity _entity;
        private readonly Entity _preImage;
        private readonly CrmContext _crmContext;
        private readonly AccountFilter _af = new AccountFilter();

        #endregion Variables

        #region Constructor

        public PostOperationAccountLogicAsync(ILogger logger, Entity entity,
                                              Entity preImage, CrmContext crmContext)
        {
            _logger = logger;
            _entity = entity;
            _preImage = preImage;
            _crmContext = crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                if (_af.ValidatePhonePrefix(_entity))
                {
                    Account accountToUpdate = new Account();
                    accountToUpdate.Id = _entity.Id;

                    CountryRepos countryRepos = new CountryRepos(_crmContext);
                    AccountRepos accountRepos = new AccountRepos(_crmContext);

                    PhonePrefix pp = new PhonePrefix(_logger, _entity, _preImage, accountToUpdate, countryRepos);
                    accountToUpdate = pp.PhonePrefix_Logic();

                    accountRepos.updateAccount(accountToUpdate);
                }
            }
            catch (InvalidPluginExecutionException Ex)
            {
                throw new InvalidPluginExecutionException("\n\nInvalidPluginExecutionException\n-----------------------------------------------\n" +
                                    "\nError Message:\n" + Ex.Message.ToString() +
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