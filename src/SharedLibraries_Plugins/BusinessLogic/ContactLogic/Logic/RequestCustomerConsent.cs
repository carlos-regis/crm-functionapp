using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Models;
using SharedLibraries_Plugins.Repos.Consents;
using SharedLibraries_Plugins.Repos.Contacts;
using SharedLibraries_Plugins.Repos.Countries;
using SharedLibraries_Plugins.Repos.Users;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.ContactLogic.Logic
{
    public class RequestCustomerConsent
    {
        #region Variables
        private ITracingService tracingService;
        private Entity preImage;
        private Entity postImage;
        private CountryRepos countryRepos;
        private ContactRepos contactRepos;
        private ConsentRepos consentRepos;
        private UserRepos userRepos;
        private IOrganizationService service;
        #endregion

        #region Constructor
        public RequestCustomerConsent(ITracingService _tracingService, Entity _preImage, Entity _postImage,
                                      CountryRepos _countryRepos, ContactRepos _contactRepos, ConsentRepos _consentRepos, UserRepos _userRepos,
                                      IOrganizationService _service)
        {
            this.tracingService = _tracingService;
            this.preImage = _preImage;
            this.postImage = _postImage;
            this.countryRepos = _countryRepos;
            this.contactRepos = _contactRepos;
            this.consentRepos = _consentRepos;
            this.userRepos = _userRepos;
            this.service = _service;
        }
        #endregion

        #region Logic

        public void RequestCustomerConsent_Logic()
        {
            var emailAddress = postImage.GetAttributeValue<string>(Contact.Fields.EMailAddress1);
            var countryId = postImage.GetAttributeValue<EntityReference>(Contact.Fields.rbtt_CountryId).Id;

            var retrievedContacts = contactRepos.retrieveMultipleContactsByEmail(emailAddress);
            var hasConsents = false;

            if (retrievedContacts.Count > 0)
            {
                foreach (var contact in retrievedContacts)
                {
                    var retrievedConsents = consentRepos.retrieveMultipleConsentByContactId(contact.Id);

                    if (retrievedConsents.Count > 0) { hasConsents = true; };
                }
            }

            if (hasConsents) return;

            var retrievedCountry = countryRepos.retrieveCountryById(countryId);

            if (retrievedCountry != null)
            {
                if (!retrievedCountry.Attributes.Contains(Orb_country.Fields.rbtt_GDPRMailbox)) return;
                if (!retrievedCountry.Attributes.Contains(Orb_country.Fields.rbtt_EmailTemplateGUID)) return;

                var userId = retrievedCountry.GetAttributeValue<EntityReference>(Orb_country.Fields.rbtt_GDPRMailbox).Id;

                var retrievedUser = userRepos.retrieveUserById(userId);

                if (retrievedUser != null)
                {
                    EmailModels emailSetup = new EmailModels();
                    PartyId partyfrom = new PartyId();
                    partyfrom.Id = retrievedUser.Id;
                    partyfrom.entity = SystemUser.EntityLogicalName;
                    emailSetup.from = partyfrom;

                    PartyId partyto = new PartyId();
                    partyto.Id = postImage.Id;
                    partyto.entity = Contact.EntityLogicalName;
                    emailSetup.to = partyto;

                    emailSetup.regardingobjectid = new EntityReference(postImage.LogicalName, postImage.Id);

                    emailSetup.directioncode = true;
                    emailSetup.owner = retrievedUser.Id;
                    emailSetup.TemplateGuid = Guid.Parse(retrievedCountry.Attributes[Orb_country.Fields.rbtt_EmailTemplateGUID].ToString());

                    SendEmailUsingTemplate(service, emailSetup);
                }
            }
        }

        #endregion

        #region Private Methods
        private static void SendEmailUsingTemplate(IOrganizationService service, EmailModels emailValues)
        {
            Entity fromActivityParty = new Entity(ActivityParty.EntityLogicalName);
            Entity toActivityParty = new Entity(ActivityParty.EntityLogicalName);
            Entity CCActivityParty = new Entity(ActivityParty.EntityLogicalName);
            Entity BCCActivityParty = new Entity(ActivityParty.EntityLogicalName);

            fromActivityParty.Attributes[ActivityParty.Fields.PartyId] = new EntityReference(emailValues.from.entity, emailValues.from.Id);
            toActivityParty.Attributes[ActivityParty.Fields.PartyId] = new EntityReference(emailValues.to.entity, emailValues.to.Id);
            if (emailValues.CC != null)
                if (emailValues.CC.entity != null)
                    if (emailValues.CC.Id != Guid.Empty)
                        CCActivityParty.Attributes[ActivityParty.Fields.PartyId] = new EntityReference(emailValues.CC.entity, emailValues.CC.Id);
            if (emailValues.BCC != null)
                if (emailValues.BCC.entity != null)
                    if (emailValues.BCC.Id != Guid.Empty)
                        BCCActivityParty.Attributes[ActivityParty.Fields.PartyId] = new EntityReference(emailValues.BCC.entity, emailValues.BCC.Id);

            Entity email = new Entity(Email.EntityLogicalName);
            email.Attributes[Email.Fields.From] = new Entity[] { fromActivityParty };
            email.Attributes[Email.Fields.To] = new Entity[] { toActivityParty };
            if (emailValues.CC != null)
                if (emailValues.CC.entity != null)
                    if (emailValues.CC.Id != Guid.Empty)
                        email.Attributes[Email.Fields.Cc] = new Entity[] { CCActivityParty };
            if (emailValues.BCC != null)
                if (emailValues.BCC.entity != null)
                    if (emailValues.BCC.Id != Guid.Empty)
                        email.Attributes[Email.Fields.Bcc] = new Entity[] { BCCActivityParty };
            email.Attributes[Email.Fields.OwnerId] = new EntityReference(SystemUser.EntityLogicalName, emailValues.owner);
            email.Attributes[Email.Fields.DirectionCode] = emailValues.directioncode;
            email.Attributes[Email.Fields.RegardingObjectId] = emailValues.regardingobjectid;

            if (emailValues.TemplateGuid.Equals(null) || emailValues.TemplateGuid.Equals(Guid.Empty))
            {
                if (emailValues.TemplateName.Equals(string.Empty))
                {
                    email.Attributes[Email.Fields.Subject] = emailValues.subject;
                    email.Attributes[Email.Fields.Description] = emailValues.description;
                }
                else
                {
                    email.Attributes[Email.Fields.Subject] = "[TTMSCRM] Issues with the Interface: ".Replace(": ", ": " + emailValues.subject);
                    string description = "<html>" +
                                                        "<head>" +
                                                            "<title>TT MS CRM Notification system</title>" +
                                                        "</head>" +
                                                        "<body style='background-color: #ffffff; color: #333333; padding: 10px;'>" +
                                                            "<p id='description'>" +
                                                                "Dear TTMSCRM team, " +
                                                                "<br/><br/>" +
                                                                "This email was sent to you as a warning of issues happening in one of the implemented Interfaces." +
                                                                "<br/>" +
                                                                "Please take the needed meassures to fix this issue." +
                                                                "<br/>" +
                                                            "</p>" +
                                                            "<div id='message' style='background-color: beige; color: brown; border: #333333 solid; padding: 5px;'>" +
                                                                "<p id='interface'><strong>Interface</strong>: interface_name</p>" +
                                                                "<p id='origin'><strong>Origin</strong>: interface_origin</p>" +
                                                                "<p id='url'><strong>URL to consume</strong>: interface_url</p>" +
                                                                "<p id='when'><strong>When</strong>: interface_date</p>" +
                                                                "<p id='error'><strong>Error</strong>: interface_error</p>" +
                                                            "</div>" +
                                                            "<p id='bye'>" +
                                                                "Thank you." +
                                                                "<br/>" +
                                                                "Your MS CRM System user." +
                                                                "<br/><br/>" +
                                                                "<a title='MSCRM@TT' href='https://connect.bosch.com/communities/service/html/communitystart?communityUuid=7db9080a-c14f-4f22-93d1-e8deab3370ed' target='_blank'><img title='MSCRM@TT' src='https://connect.bosch.com/communities/service/html/image?communityUuid=7db9080a-c14f-4f22-93d1-e8deab3370ed'></a>" +
                                                            "</p>" +
                                                        "</body>" +
                                                    "</html>";
                    email.Attributes[Email.Fields.Description] = description.Replace("interface_name", emailValues.subject).Replace("interface_url", emailValues.message.URL).Replace("interface_origin", emailValues.message.origin).Replace("interface_date", emailValues.message.when.ToString()).Replace("interface_error", emailValues.message.error);
                }

                Guid emailId = service.Create(email);

                SendEmailRequest sendEmailRequest = new SendEmailRequest
                {
                    EmailId = emailId,
                    TrackingToken = "",
                    IssueSend = true
                };

                SendEmailResponse sendEmailresp = (SendEmailResponse)service.Execute(sendEmailRequest);
            }
            else
            {
                email.Attributes[Email.Fields.Subject] = emailValues.subject;
                email.Attributes[Email.Fields.Description] = emailValues.description;
                var emailUsingTemplateReq = new SendEmailFromTemplateRequest
                {
                    Target = email,
                    TemplateId = emailValues.TemplateGuid,
                    RegardingId = emailValues.regardingobjectid.Id,
                    RegardingType = emailValues.regardingobjectid.LogicalName
                };

                var emailUsingTemplateResp = (SendEmailFromTemplateResponse)service.Execute(emailUsingTemplateReq);
                if (emailUsingTemplateResp.Id.Equals(Guid.Empty))
                    throw new Exception("Error: the email cannot be sent");
            }
        }
        #endregion
    }
}
