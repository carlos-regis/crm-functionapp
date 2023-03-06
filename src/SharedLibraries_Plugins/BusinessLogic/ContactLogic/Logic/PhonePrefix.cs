using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Countries;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.ContactLogic.Logic
{
    public class PhonePrefix
    {
        #region Variables
        private ITracingService tracingService;
        private Entity entity;
        private Entity preImage;
        private Entity contactToUpdate;
        private CountryRepos countryRepos;
        #endregion

        #region Constructor
        public PhonePrefix(ITracingService _tracingService, Entity _entity, Entity _preImage, Entity _contactToUpdate,
                                        CountryRepos _countryRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.contactToUpdate = _contactToUpdate;
            this.countryRepos = _countryRepos;
        }
        #endregion

        #region Logic
        public Contact PhonePrefix_Logic()
        {
            Guid countryId = entity.GetAttributeValue<EntityReference>(Contact.Fields.rbtt_CountryId) != null ?
                            entity.GetAttributeValue<EntityReference>(Contact.Fields.rbtt_CountryId).Id : preImage.GetAttributeValue<EntityReference>(Contact.Fields.rbtt_CountryId).Id;

            Orb_country retrievedCountry = countryRepos.retrieveCountryPhonePrefix(countryId);

            if (retrievedCountry != null)
            {
                if (entity.Attributes.Contains(Contact.Fields.Telephone1))
                {
                    tracingService.Trace("Getting the Telephone1");
                    string Telephone1 = entity.GetAttributeValue<string>(Contact.Fields.Telephone1) != null ? entity.GetAttributeValue<string>(Contact.Fields.Telephone1) : preImage.GetAttributeValue<string>(Contact.Fields.Telephone1);
                    if (!Telephone1.StartsWith("+" + retrievedCountry.rbtt_phoneprefix))
                    {
                        if (Telephone1.StartsWith("0")) Telephone1 = Telephone1.Substring(1);
                        contactToUpdate.Attributes[Contact.Fields.Telephone1] = $"+{retrievedCountry.rbtt_phoneprefix}{Telephone1}";
                    }
                }

                if (entity.Attributes.Contains(Contact.Fields.MobilePhone))
                {
                    tracingService.Trace("Getting the MobilePhone");
                    string MobilePhone = entity.GetAttributeValue<string>(Contact.Fields.MobilePhone) != null ? entity.GetAttributeValue<string>(Contact.Fields.MobilePhone) : preImage.GetAttributeValue<string>(Contact.Fields.MobilePhone);
                    if (!MobilePhone.StartsWith("+" + retrievedCountry.rbtt_phoneprefix))
                    {
                        if (MobilePhone.StartsWith("0")) MobilePhone = MobilePhone.Substring(1);
                        contactToUpdate.Attributes[Contact.Fields.MobilePhone] = $"+{retrievedCountry.rbtt_phoneprefix}{MobilePhone}";
                    }
                }

                if (entity.Attributes.Contains(Contact.Fields.Fax))
                {
                    tracingService.Trace("Getting the Fax");
                    string Fax = entity.GetAttributeValue<string>(Contact.Fields.Fax) != null ? entity.GetAttributeValue<string>(Contact.Fields.Fax) : preImage.GetAttributeValue<string>(Contact.Fields.Fax);
                    if (!Fax.StartsWith("+" + retrievedCountry.rbtt_phoneprefix))
                    {
                        if (Fax.StartsWith("0")) Fax = Fax.Substring(1);
                        contactToUpdate.Attributes[Contact.Fields.Fax] = $"+{retrievedCountry.rbtt_phoneprefix}{Fax}";
                    }
                }
            }
            else
            {
                tracingService.Trace("- PostOperationUserLogic.PhonePrefix.Logic_onCreate() - No PhonePrefix found for this country");
            }

            return (Contact)contactToUpdate;
        }
        #endregion Logic
    }
}
