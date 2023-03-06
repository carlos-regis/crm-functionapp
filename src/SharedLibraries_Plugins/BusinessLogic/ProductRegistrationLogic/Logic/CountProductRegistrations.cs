using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.ProductRegistrations;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic
{
    public class CountProductRegistrations
    {
        #region Variables
        private ITracingService tracingService;
        private Entity entity;
        private Entity preImage;
        private ProductRegistrationRepos productRegistrationRepos;
        private AccountRepos accountRepos;
        #endregion

        #region Constructor
        public CountProductRegistrations(ITracingService _tracingService, Entity _entity, Entity _preImage, ProductRegistrationRepos _productRegistrationRepos, AccountRepos _accountRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.productRegistrationRepos = _productRegistrationRepos;
            this.accountRepos = _accountRepos;
        }
        #endregion

        #region Logic
        public void CountProductRegistrations_Logic()
        {
            if (entity.Attributes.Contains(Orb_machine.Fields.rbtt_AccountId) &&
                entity.GetAttributeValue<EntityReference>(Orb_machine.Fields.rbtt_AccountId).Id != null)
            {
                if (preImage != null && preImage.Attributes.Contains(Orb_machine.Fields.rbtt_AccountId))
                {
                    var retrievedPreImageAccount = accountRepos.retrieveAccountById_ProductRegistration(preImage.GetAttributeValue<EntityReference>(Orb_machine.Fields.rbtt_AccountId).Id);

                    CountProductRegistrationsForUpdatedAccount(retrievedPreImageAccount);
                }

                var accountId = entity.GetAttributeValue<EntityReference>(Orb_machine.Fields.rbtt_AccountId).Id;

                var retrievedAccount = accountRepos.retrieveAccountById_ProductRegistration(accountId);

                CountProductRegistrationsForUpdatedAccount(retrievedAccount);
            }
        }
        #endregion

        #region Private Methods
        private int CountRegistrationsByYear(Entity entity, int ytd)
        {
            var retrievedProductRegistrations = productRegistrationRepos.retrieveMultipleProductRegistraionsByAccountIdAndYTD(entity.Id, ytd);

            return retrievedProductRegistrations.Count;
        }

        private void CountProductRegistrationsForUpdatedAccount(Entity retrievedAccount)
        {
            int currentRegistrationYTD = retrievedAccount.Attributes.Contains(Account.Fields.rbtt_NoofRegistrationsYTD) ?
                                         retrievedAccount.GetAttributeValue<int>(Account.Fields.rbtt_NoofRegistrationsYTD) :
                                         0;

            int currentRegistrationYTD1 = retrievedAccount.Attributes.Contains(Account.Fields.rbtt_NoofRegistrationsY1) ?
                                         retrievedAccount.GetAttributeValue<int>(Account.Fields.rbtt_NoofRegistrationsY1) :
                                         0;

            int currentRegistrationYTD2 = retrievedAccount.Attributes.Contains(Account.Fields.rbtt_NoofRegistrationsY2) ?
                                         retrievedAccount.GetAttributeValue<int>(Account.Fields.rbtt_NoofRegistrationsY2) :
                                         0;

            int newRegistrationYTD = CountRegistrationsByYear(retrievedAccount, 0);
            int newRegistrationYTD1 = CountRegistrationsByYear(retrievedAccount, 1);
            int newRegistrationYTD2 = CountRegistrationsByYear(retrievedAccount, 2);

            if (!currentRegistrationYTD.Equals(newRegistrationYTD))
                retrievedAccount.Attributes[Account.Fields.rbtt_NoofRegistrationsYTD] = newRegistrationYTD;

            if (!currentRegistrationYTD1.Equals(newRegistrationYTD1))
                retrievedAccount.Attributes[Account.Fields.rbtt_NoofRegistrationsY1] = newRegistrationYTD1;

            if (!currentRegistrationYTD2.Equals(newRegistrationYTD2))
                retrievedAccount.Attributes[Account.Fields.rbtt_NoofRegistrationsY2] = newRegistrationYTD2;

            accountRepos.updateAccount((Account)retrievedAccount);
        }
        #endregion
    }
}
