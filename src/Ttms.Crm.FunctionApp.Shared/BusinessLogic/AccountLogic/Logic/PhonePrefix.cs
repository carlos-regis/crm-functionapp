using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk;
using System;
using Ttms.Crm.FunctionApp.Shared.EntityModel;
using Ttms.Crm.FunctionApp.Shared.Repos.Countries;

namespace Ttms.Crm.FunctionApp.Shared.BusinessLogic.AccountLogic.Logic
{
    public class PhonePrefix
    {
        #region Variables

        private readonly ILogger logger;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly Entity accountToUpdate;
        private readonly CountryRepos countryRepos;

        #endregion Variables

        #region Constructor

        public PhonePrefix(ILogger _logger, Entity _entity, Entity _preImage, Entity _accountToUpdate,
                                        CountryRepos _countryRepos)
        {
            this.logger = _logger;
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
                             entity.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid).Id :
                             preImage.GetAttributeValue<EntityReference>(Account.Fields.orb_countryid).Id;

            Orb_country retrievedCountry = countryRepos.retrieveCountryPhonePrefix(countryId);

            if (retrievedCountry != null)
            {
                string phoneValue = entity.GetAttributeValue<string>(Account.Fields.Telephone1) != null ?
                                    entity.GetAttributeValue<string>(Account.Fields.Telephone1) :
                                    preImage.GetAttributeValue<string>(Account.Fields.Telephone1);
                if (phoneValue.StartsWith("0"))
                {
                    phoneValue = phoneValue.Substring(1);
                }
                accountToUpdate.Attributes[Account.Fields.Telephone1] = $"+{retrievedCountry.rbtt_phoneprefix}{phoneValue}";
            }
            else
            {
                logger.LogWarning("- PostOperationUserLogic.PhonePrefix.Logic_onCreate() - No PhonePrefix found for this country");
            }

            return (Account)accountToUpdate;
        }
        #endregion
    }
}