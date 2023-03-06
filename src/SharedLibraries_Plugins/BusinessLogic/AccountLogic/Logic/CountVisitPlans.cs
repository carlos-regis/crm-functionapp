using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.VisitPlanning;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic
{
    public class CountVisitPlans
    {
        private ITracingService tracingService;
        private Entity entity;
        private VisitPlanningRepos visitPlanningRepos;

        public CountVisitPlans(ITracingService _tracingService, Entity _entity,
                               VisitPlanningRepos visitPlanningRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.visitPlanningRepos = visitPlanningRepos;
        }

        public void CountVisitPlans_Logic()
        {
            Orb_visitplanningbase retrievedVisitPlanning = visitPlanningRepos.retrieveVisitPlanningByClassificationBaseIdAndByName(entity.GetAttributeValue<EntityReference>(Account.Fields.orb_classificationbaseid).Id, "Z9");

            if (retrievedVisitPlanning != null)
                entity.Attributes[Account.Fields.Orb_visitcountplanned] = retrievedVisitPlanning.GetAttributeValue<double>(Orb_visitplanningbase.Fields.Orb_VisitPlanned).ToString();
        }
    }
}
