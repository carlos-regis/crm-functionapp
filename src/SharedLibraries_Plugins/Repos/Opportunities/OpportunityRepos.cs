using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Opportunities
{
    public class OpportunityRepos : IOpportunityRepos
    {
        private CrmContext crmContext;

        public OpportunityRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createOpportunity(Opportunity opportunity)
        {
            crmContext.AddObject(opportunity);
            crmContext.SaveChanges();
        }

        public List<Opportunity> retrieveMultipleOpportunities()
        {
            List<Opportunity> opportunityList = (from a in crmContext.OpportunitySet
                                                 select new Opportunity
                                                 {
                                                     Id = a.Id
                                                 }).ToList();
            return opportunityList;
        }

        public Opportunity retrieveOpportunityById(Guid opportunityId)
        {
            Opportunity opportunity = (from opp in crmContext.OpportunitySet
                                       where opp.Id == opportunityId
                                       select new Opportunity
                                       {
                                           Id = opp.Id
                                       }).FirstOrDefault();
            return opportunity;
        }

        public void updateOpportunity(Opportunity opportunity)
        {
            if (!crmContext.IsAttached(opportunity))
            {
                crmContext.Attach(opportunity);
            }
            crmContext.UpdateObject(opportunity);
            crmContext.SaveChanges();
        }
    }
}
