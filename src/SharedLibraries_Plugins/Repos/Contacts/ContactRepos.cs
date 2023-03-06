using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Contacts
{
    public class ContactRepos : IContactRepos
    {
        private CrmContext crmContext;

        public ContactRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createContact(Contact contact)
        {
            crmContext.AddObject(contact);
            crmContext.SaveChanges();
        }

        public Contact retrieveContactByEmail(string emailAddress)
        {
            Contact contact = (from c in crmContext.ContactSet
                               where c.EMailAddress1 == emailAddress
                               select new Contact
                               {
                                   Id = c.Id,
                                   FirstName = c.FirstName,
                                   LastName = c.LastName,
                                   EMailAddress1 = c.EMailAddress1,
                                   Address1_PostalCode = c.Address1_PostalCode,
                                   rbtt_CIAMID = c.rbtt_CIAMID,
                                   OwnerId = c.OwnerId,
                                   ModifiedOn = c.ModifiedOn
                               }).FirstOrDefault();
            return contact;
        }

        public Contact retrieveContactById(Guid contactId)
        {
            Contact contact = (from c in crmContext.ContactSet
                               where c.Id == contactId
                               select new Contact
                               {
                                   Id = c.Id,
                                   FirstName = c.FirstName,
                                   LastName = c.LastName,
                                   EMailAddress1 = c.EMailAddress1,
                                   Address1_PostalCode = c.Address1_PostalCode,
                                   rbtt_CIAMID = c.rbtt_CIAMID,
                                   OwnerId = c.OwnerId,
                                   ParentCustomerId = c.ParentCustomerId,
                                   ModifiedOn = c.ModifiedOn,
                                   rbtt_GDPRBlock = c.rbtt_GDPRBlock,
                                   DoNotEMail = c.DoNotEMail,
                                   FollowEmail = c.FollowEmail,
                                   DoNotBulkEMail = c.DoNotBulkEMail,
                                   DoNotPhone = c.DoNotPhone,
                                   DoNotFax = c.DoNotFax,
                                   DoNotPostalMail = c.DoNotPostalMail
                               }).FirstOrDefault();
            return contact;
        }

        public List<Contact> retrieveMultipleContacts()
        {
            List<Contact> contactList = (from c in crmContext.ContactSet
                                         select new Contact
                                         {
                                             Id = c.Id,
                                             FirstName = c.FirstName,
                                             LastName = c.LastName,
                                             EMailAddress1 = c.EMailAddress1,
                                             Address1_PostalCode = c.Address1_PostalCode,
                                             rbtt_CIAMID = c.rbtt_CIAMID,
                                             OwnerId = c.OwnerId,
                                             ModifiedOn = c.ModifiedOn
                                         }).ToList();
            return contactList;
        }

        public List<Contact> retrieveMultipleContactsByEmail(string emailAddress)
        {
            List<Contact> contactList = (from c in crmContext.ContactSet
                                         where c.EMailAddress1 == emailAddress
                                         select new Contact
                                         {
                                             Id = c.Id
                                         }).ToList();
            return contactList;
        }

        public void updateContact(Entity contact)
        {
            if (!crmContext.IsAttached(contact))
            {
                crmContext.Attach(contact);
            }
            crmContext.UpdateObject(contact);
            crmContext.SaveChanges();
        }
    }
}