using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Countries;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic
{
    public class PhonePrefix
    {
        #region Variables

        private ITracingService tracingService;
        private Entity entity;
        private Entity preImage;
        private Entity accountToUpdate;
        private CountryRepos countryRepos;

        #endregion Variables

        #region Constructor

        public PhonePrefix(ITracingService _tracingService, Entity _entity, Entity _preImage, Entity _accountToUpdate,
                                        CountryRepos _countryRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.accountToUpdate = _accountToUpdate;
            this.countryRepos = _countryRepos;
        }

        #endregion Constructor

        #region Logic
        public Account PhonePrefix_Logic()
        {
            Guid countryId = entity.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid) != null ?
                            entity.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid).Id : preImage.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid).Id;

            Orb_country retrievedCountry = countryRepos.retrieveCountryPhonePrefix(countryId);

            if (retrievedCountry != null)
            {
                string phoneValue = entity.GetAttributeValue<string>(Account.Fields.Telephone1) != null ? 
                    entity.GetAttributeValue<string>(Account.Fields.Telephone1) : preImage.GetAttributeValue<string>(Account.Fields.Telephone1);
                if (phoneValue.StartsWith("0")) phoneValue = phoneValue.Substring(1);
                accountToUpdate.Attributes[Account.Fields.Telephone1] = $"+{retrievedCountry.rbtt_phoneprefix}{phoneValue}";
            }
            else
            {
                tracingService.Trace("- PostOperationUserLogic.PhonePrefix.Logic_onCreate() - No PhonePrefix found for this country");
            }

            return (Account)accountToUpdate;
        }
        #endregion
    }
}