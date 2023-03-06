using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Consents;
using SharedLibraries_Plugins.Repos.Contacts;

namespace SharedLibraries_Plugins.BusinessLogic.ConsentLogic.Logic
{
    public class SyncContactChannels
    {
        #region Variables
        private ITracingService tracingService;
        private Entity entity;
        private Entity postImage;
        private Entity preImage;
        private ConsentRepos consentRepos;
        private ContactRepos contactRepos;
        #endregion

        #region Constructor
        public SyncContactChannels(ITracingService _tracingService, Entity _entity, Entity _preImage, Entity _postImage,
                                   ContactRepos _contactRepos, ConsentRepos _consentRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.postImage = _postImage;
            this.contactRepos = _contactRepos;
            this.consentRepos = _consentRepos;
        }
        #endregion

        #region Logic
        public void SyncContactChannels_Logic()
        {
            var contactId = postImage != null ? postImage.GetAttributeValue<EntityReference>(rbtt_consent.Fields.rbtt_Contact2).Id
                                                :
                                                preImage.GetAttributeValue<EntityReference>(rbtt_consent.Fields.rbtt_Contact2).Id;

            var retrievedContact = contactRepos.retrieveContactById(contactId);

            if (retrievedContact != null)
            {
                var retrievedConsents = consentRepos.retrieveMultipleConsentByContactId(contactId);

                bool rbtt_email_Allow_NotAllow = false;
                bool rbtt_mobilephone_Allow_NotAllow = false;
                bool rbtt_phone_Allow_NotAllow = false;
                bool rbtt_fax_Allow_NotAllow = false;
                bool rbtt_letter_Allow_NotAllow = false;

                if (retrievedConsents.Count > 0)
                {
                    foreach (var consent in retrievedConsents)
                    {
                        #region rbtt_email
                        if (consent.Attributes.Contains(rbtt_consent.Fields.rbtt_Email))
                            if (!rbtt_email_Allow_NotAllow)
                                rbtt_email_Allow_NotAllow = (bool)consent.Attributes[rbtt_consent.Fields.rbtt_Email];
                        #endregion rbtt_email

                        #region phone
                        if (consent.Attributes.Contains(rbtt_consent.Fields.rbtt_Phone))
                            if (!rbtt_phone_Allow_NotAllow)
                                rbtt_phone_Allow_NotAllow = (bool)consent.Attributes[rbtt_consent.Fields.rbtt_Phone];
                        #endregion phone

                        #region rbtt_mobilephone
                        if (consent.Attributes.Contains(rbtt_consent.Fields.rbtt_Mobilephone))
                            if (!rbtt_mobilephone_Allow_NotAllow)
                                rbtt_mobilephone_Allow_NotAllow = (bool)consent.Attributes[rbtt_consent.Fields.rbtt_Mobilephone];
                        #endregion rbtt_mobilephone

                        #region rbtt_fax
                        if (consent.Attributes.Contains(rbtt_consent.Fields.rbtt_Fax))
                            if (!rbtt_fax_Allow_NotAllow)
                                rbtt_fax_Allow_NotAllow = (bool)consent.Attributes[rbtt_consent.Fields.rbtt_Fax];
                        #endregion rbtt_fax

                        #region rbtt_letter
                        if (consent.Attributes.Contains(rbtt_consent.Fields.rbtt_Letter))
                            if (!rbtt_letter_Allow_NotAllow)
                                rbtt_letter_Allow_NotAllow = (bool)consent.Attributes[rbtt_consent.Fields.rbtt_Letter];
                        #endregion rbtt_letter
                    }

                    #region DoNotEmail
                    if (retrievedContact.Attributes.Contains(Contact.Fields.DoNotEMail))
                    {
                        if (rbtt_email_Allow_NotAllow.Equals(true) && retrievedContact.Attributes[Contact.Fields.DoNotEMail].Equals(true))
                            retrievedContact.Attributes[Contact.Fields.DoNotEMail] = false;

                        if (rbtt_email_Allow_NotAllow.Equals(false) && retrievedContact.Attributes[Contact.Fields.DoNotEMail].Equals(false))
                            retrievedContact.Attributes[Contact.Fields.DoNotEMail] = true;
                    }
                    else
                    {
                        retrievedContact.Attributes[Contact.Fields.DoNotEMail] = rbtt_email_Allow_NotAllow;
                    }
                    #endregion

                    #region FollowEmail
                    if (retrievedContact.Attributes.Contains(Contact.Fields.FollowEmail))
                    {
                        if (!rbtt_email_Allow_NotAllow.Equals((bool)retrievedContact.Attributes[Contact.Fields.FollowEmail]))
                            retrievedContact.Attributes[Contact.Fields.FollowEmail] = rbtt_email_Allow_NotAllow;
                    }
                    else
                    {
                        retrievedContact.Attributes[Contact.Fields.FollowEmail] = rbtt_email_Allow_NotAllow;
                    }
                    #endregion

                    #region DoNotBulkEmail
                    if (retrievedContact.Attributes.Contains(Contact.Fields.DoNotBulkEMail))
                    {
                        if (rbtt_email_Allow_NotAllow.Equals(true) && retrievedContact.Attributes[Contact.Fields.DoNotBulkEMail].Equals(true))
                            retrievedContact.Attributes[Contact.Fields.DoNotBulkEMail] = false;

                        if (rbtt_email_Allow_NotAllow.Equals(false) && retrievedContact.Attributes[Contact.Fields.DoNotBulkEMail].Equals(false))
                            retrievedContact.Attributes[Contact.Fields.DoNotBulkEMail] = true;
                    }
                    else
                    {
                        retrievedContact.Attributes[Contact.Fields.DoNotBulkEMail] = rbtt_email_Allow_NotAllow;
                    }
                    #endregion

                    #region DoNotPhone
                    if (retrievedContact.Attributes.Contains(Contact.Fields.DoNotPhone))
                    {
                        if ((rbtt_phone_Allow_NotAllow.Equals(true) || rbtt_mobilephone_Allow_NotAllow.Equals(true)) && retrievedContact.Attributes[Contact.Fields.DoNotPhone].Equals(true))
                            retrievedContact.Attributes[Contact.Fields.DoNotPhone] = false;

                        if ((rbtt_phone_Allow_NotAllow.Equals(false) || rbtt_mobilephone_Allow_NotAllow.Equals(false)) && retrievedContact.Attributes[Contact.Fields.DoNotPhone].Equals(false))
                            retrievedContact.Attributes[Contact.Fields.DoNotPhone] = true;
                    }
                    else
                    {
                        if (rbtt_phone_Allow_NotAllow.Equals(rbtt_mobilephone_Allow_NotAllow))
                            retrievedContact.Attributes[Contact.Fields.DoNotPhone] = rbtt_phone_Allow_NotAllow;

                        if (rbtt_phone_Allow_NotAllow.Equals(true) && rbtt_mobilephone_Allow_NotAllow.Equals(false))
                            retrievedContact.Attributes[Contact.Fields.DoNotPhone] = rbtt_phone_Allow_NotAllow;

                        if (rbtt_phone_Allow_NotAllow.Equals(false) && rbtt_mobilephone_Allow_NotAllow.Equals(true))
                            retrievedContact.Attributes[Contact.Fields.DoNotPhone] = rbtt_mobilephone_Allow_NotAllow;
                    }
                    #endregion

                    #region DoNotFax

                    if (retrievedContact.Attributes.Contains(Contact.Fields.DoNotFax))
                    {
                        if (rbtt_fax_Allow_NotAllow.Equals(true) && retrievedContact.Attributes[Contact.Fields.DoNotFax].Equals(true))
                            retrievedContact.Attributes[Contact.Fields.DoNotFax] = false;

                        if (rbtt_fax_Allow_NotAllow.Equals(false) && retrievedContact.Attributes[Contact.Fields.DoNotFax].Equals(false))
                            retrievedContact.Attributes[Contact.Fields.DoNotFax] = true;
                    }
                    else
                    {
                        retrievedContact.Attributes[Contact.Fields.DoNotFax] = rbtt_fax_Allow_NotAllow;
                    }

                    #endregion

                    #region DoNotPostalMail

                    if (retrievedContact.Attributes.Contains(Contact.Fields.DoNotPostalMail))
                    {
                        if (rbtt_letter_Allow_NotAllow.Equals(true) && retrievedContact.Attributes[Contact.Fields.DoNotPostalMail].Equals(true))
                            retrievedContact.Attributes[Contact.Fields.DoNotPostalMail] = false;

                        if (rbtt_letter_Allow_NotAllow.Equals(false) && retrievedContact.Attributes[Contact.Fields.DoNotPostalMail].Equals(false))
                            retrievedContact.Attributes[Contact.Fields.DoNotPostalMail] = true;
                    }
                    else
                    {
                        retrievedContact.Attributes[Contact.Fields.DoNotPostalMail] = rbtt_letter_Allow_NotAllow;
                    }

                    #endregion
                }
                else
                {
                    retrievedContact.Attributes[Contact.Fields.DoNotBulkEMail] = true;
                    retrievedContact.Attributes[Contact.Fields.DoNotEMail] = true;
                    retrievedContact.Attributes[Contact.Fields.DoNotFax] = true;
                    retrievedContact.Attributes[Contact.Fields.DoNotPostalMail] = true;
                    retrievedContact.Attributes[Contact.Fields.DoNotPhone] = true;
                    retrievedContact.Attributes[Contact.Fields.FollowEmail] = false;
                }

                contactRepos.updateContact(retrievedContact);
            }
        }
        #endregion
    }
}
