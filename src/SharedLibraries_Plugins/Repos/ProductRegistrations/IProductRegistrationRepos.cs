using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.ProductRegistrations
{
    public interface IProductRegistrationRepos
    {
        List<Orb_machine> retrieveMultipleProductRegistrationByApplianceId(Guid applianceId);
        Orb_machine retrieveProductRegistrationById(Guid id);
        Orb_machine retrieveProductRegstrationByExternalId(string id);
        List<Orb_machine> retrieveMultipleProductRegistrations();
        List<Orb_machine> retrieveMultipleProductRegistraionsByAccountIdAndYTD(Guid accountId, int YTD);
        void createProductRegistration(Orb_machine productRegistration);
        void updateProductRegistration(Orb_machine productRegistration);
    }
}
