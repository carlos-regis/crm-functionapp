using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.Gratuities;

namespace SharedLibraries_Plugins.BusinessLogic.GratuityLogic.Logic
{
    public class CalculateGratuities
    {
        #region Variables
        private ITracingService tracingService;
        private Entity entity;
        private Entity preImage;
        private AccountRepos accountRepos;
        private GratuitiesRepos gratuitiesRepos;
        #endregion

        public CalculateGratuities(ITracingService _tracingService, Entity _entity, Entity _preImage, AccountRepos _accountRepos, GratuitiesRepos _gratuitiesRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.accountRepos = _accountRepos;
            this.gratuitiesRepos = _gratuitiesRepos;
        }
        public void CalculateGratuities_Logic()
        {
            if (entity.Attributes.Contains(Btt_gratuity.Fields.btt_accountid) &&
               (preImage != null && preImage.Attributes.Contains(Btt_gratuity.Fields.btt_accountid) && preImage.GetAttributeValue<EntityReference>(Btt_gratuity.Fields.btt_accountid) != null) &&
               entity.GetAttributeValue<EntityReference>(Btt_gratuity.Fields.btt_accountid).Id != preImage.GetAttributeValue<EntityReference>(Btt_gratuity.Fields.btt_accountid).Id)
            {
                var retrievedPreImageAccount = accountRepos.retrieveAccountById_Gratuities(preImage.GetAttributeValue<EntityReference>(Btt_gratuity.Fields.btt_accountid).Id);

                CalculateTotalGratuitiesForUpdatedAccount(retrievedPreImageAccount);
            }

            var accountId = entity.Contains(Btt_gratuity.Fields.btt_accountid) ?
                            entity.GetAttributeValue<EntityReference>(Btt_gratuity.Fields.btt_accountid).Id :
                            preImage.GetAttributeValue<EntityReference>(Btt_gratuity.Fields.btt_accountid).Id;

            var retrievedAccount = accountRepos.retrieveAccountById_Gratuities(accountId);

            CalculateTotalGratuitiesForUpdatedAccount(retrievedAccount);
        }

        private decimal CalculateTotalGratuities(Entity entity, int ytd)
        {
            var retrievedGratuities = gratuitiesRepos.retrieveMultipleGratuitiesByAccountIdAndYTD(entity.Id, ytd);
            decimal totalGratuities = 0;

            if (retrievedGratuities.Count > 0)
            {
                foreach (var gratuity in retrievedGratuities)
                {
                    totalGratuities += gratuity.Attributes.Contains(Btt_gratuity.Fields.Btt_value) ?
                                       gratuity.GetAttributeValue<Money>(Btt_gratuity.Fields.Btt_value).Value :
                                       0;
                }
            }

            return totalGratuities;
        }

        private void CalculateTotalGratuitiesForUpdatedAccount(Entity retrievedAccount)
        {
            decimal currentGratuitiesYTD = retrievedAccount.Attributes.Contains(Account.Fields.rbtt_GratuitiesTotalYTD) ?
                                                retrievedAccount.GetAttributeValue<Money>(Account.Fields.rbtt_GratuitiesTotalYTD).Value :
                                                0;

            decimal currentGratuitiesYTD1 = retrievedAccount.Attributes.Contains(Account.Fields.rbtt_GratuitiesTotalY1) ?
                                            retrievedAccount.GetAttributeValue<Money>(Account.Fields.rbtt_GratuitiesTotalY1).Value :
                                            0;

            var newGratuitiesYTD = CalculateTotalGratuities(retrievedAccount, 0);

            var newGratuitiesYTD1 = CalculateTotalGratuities(retrievedAccount, 1);

            if (!currentGratuitiesYTD.Equals(newGratuitiesYTD))
                retrievedAccount.Attributes[Account.Fields.rbtt_GratuitiesTotalYTD] = new Money(newGratuitiesYTD);

            if (!currentGratuitiesYTD1.Equals(newGratuitiesYTD1))
                retrievedAccount.Attributes[Account.Fields.rbtt_GratuitiesTotalY1] = new Money(newGratuitiesYTD1);

            accountRepos.updateAccount((Account)retrievedAccount);
        }
    }
}
