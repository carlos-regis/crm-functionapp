using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Consents
{
    public interface IConsentRepos
    {
        rbtt_consent retrieveConsentById(Guid consentId);
        List<rbtt_consent> retrieveMultipleConsentByContactId(Guid contactId);
        List<rbtt_consent> retrieveMultipleConsents();
        void createConsent(rbtt_consent consent);
        void updateConsent(rbtt_consent consent);
    }
}
