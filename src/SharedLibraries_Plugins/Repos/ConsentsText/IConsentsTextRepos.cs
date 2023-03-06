using SharedLibraries_Plugins.EntityModel;
using System;

namespace SharedLibraries_Plugins.Repos.ConsentsText
{
    public interface IConsentsTextRepos
    {
        void createConsentText(rbtt_consenttext consentText);
        rbtt_consenttext retrieveConsentTextById(Guid consentTextId);
    }
}
