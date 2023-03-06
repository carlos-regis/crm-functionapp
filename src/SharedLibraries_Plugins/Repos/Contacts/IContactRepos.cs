using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Contacts
{
    public interface IContactRepos
    {
        Contact retrieveContactById(Guid contactId);
        Contact retrieveContactByEmail(string emailAddress);
        List<Contact> retrieveMultipleContacts();
        List<Contact> retrieveMultipleContactsByEmail(string emailAddress);
        void createContact(Contact contact);
        void updateContact(Entity contact);
    }
}
