using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Opportunities
{
    public interface IOpportunityRepos
    {
        Opportunity retrieveOpportunityById(Guid opportunityId);
        List<Opportunity> retrieveMultipleOpportunities();
        void createOpportunity(Opportunity opportunity);
        void updateOpportunity(Opportunity opportunity);
    }
}
