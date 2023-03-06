using SharedLibraries_Plugins.EntityModel;
using System;

namespace SharedLibraries_Plugins.Repos.VisitPlanning
{
    public interface IVisitPlanningRepos
    {
        Orb_visitplanningbase retrieveVisitPlanningByClassificationBaseIdAndByName(Guid classificationBaseId, string name);
    }
}
