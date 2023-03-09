using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Filter;
using Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Logic;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.Shared.Repos.Accounts;
using Ttms.Crm.FunctionApp.Shared.Repos.BoschSites;
using Ttms.Crm.FunctionApp.Shared.Repos.ClassificationBases;
using Ttms.Crm.FunctionApp.Shared.Repos.ConfigurationParameters;
using Ttms.Crm.FunctionApp.Shared.Repos.Countries;
using Ttms.Crm.FunctionApp.Shared.Repos.CustomerMasterDataExchange;

namespace Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Events.PostOperation
{
    public class PostOperationAccountLogicSync
    {
        #region Variables

        private readonly ILogger logger;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly Entity postImage;
        private readonly CrmContext crmContext;
        private readonly AccountFilter af = new AccountFilter();

        #endregion

        #region Constructor

        public PostOperationAccountLogicSync(ILogger _logger, Entity _entity, Entity _preImage, Entity _postImage, CrmContext _crmContext)
        {
            this.logger = _logger;
            this.entity = _entity;
            this.preImage = _preImage;
            this.postImage = _postImage;
            this.crmContext = _crmContext;
        }

        #endregion

        #region Execute
        public void ValidateAndExecute()
        {
            try
            {
                logger.LogInformation("PostOperationAccountLogicSync.ValidateAndExecute() --> Started");

                AccountRepos accountRepos = new AccountRepos(crmContext);

                Account accountToUpdate = new Account();
                accountToUpdate.Id = entity.Id;

                if (af.ValidateCMD(entity, preImage))
                {
                    ClassificationBaseRepos classificationBaseRepos = new ClassificationBaseRepos(crmContext);

                    CalculateABCStatus calculateABCStatus = new CalculateABCStatus(logger, entity, accountToUpdate, preImage, classificationBaseRepos);
                    accountToUpdate = calculateABCStatus.CalculateABCStatus_Logic();

                    accountRepos.updateAccount(accountToUpdate);
                }

                if (af.ValidateABCStatus(entity, postImage))
                {
                    if ((postImage.Attributes.Contains(Account.Fields.rbtt_ERPCustomerNumber) || postImage.Attributes.Contains(Account.Fields.rbtt_ERPShiptoNumber)) &&
                       postImage.Attributes.Contains(Account.Fields.rbtt_Brand) && postImage.Attributes.Contains(Account.Fields.rbtt_SalesOrganization))
                    {
                        CountryRepos countryRepos = new CountryRepos(crmContext);
                        ConfigurationParameterRepos configurationParameterRepos = new ConfigurationParameterRepos(crmContext);
                        BoschSiteRepos boschSiteRepos = new BoschSiteRepos(crmContext);
                        CustomerMasterDataExchangeRepos customerMasterDataExchageRepos = new CustomerMasterDataExchangeRepos(crmContext);

                        CMDInterface cmdi = new CMDInterface(logger, entity, accountToUpdate, postImage, countryRepos, configurationParameterRepos, boschSiteRepos, customerMasterDataExchageRepos);
                        accountToUpdate = cmdi.CMDInterface_Logic();

                        accountRepos.updateAccount(accountToUpdate);
                    }
                    else
                    {
                        var missingField = !postImage.Attributes.Contains(Account.Fields.rbtt_ERPCustomerNumber) ?
                                                "ERP Customer Number missing." : !postImage.Attributes.Contains(Account.Fields.rbtt_ERPShiptoNumber) ?
                                                        "ERP Ship to Number missing." : !postImage.Attributes.Contains(Account.Fields.rbtt_Brand) ?
                                                                "Distribution Channel missing." : !postImage.Attributes.Contains(Account.Fields.orb_countryid) ?
                                                                        "Sales Organization missing." : $"Contact the system administrator with the following message: AccountId - {entity.Id}, Error in PostOperationAccountLogicSync.ValidateAndExecute().";

                        logger.LogInformation($"Please re-check the record and correct the needed fields to link the account: Message = {missingField}");
                        throw new InvalidPluginExecutionException(missingField);
                    }
                }

                logger.LogInformation("PostOperationAccountLogicSync.ValidateAndExecute() --> Ended");
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
        #endregion
    }
}
