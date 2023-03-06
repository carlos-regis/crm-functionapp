using SharedLibraries_Plugins.EntityModel;
using System;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.VisitPlanning
{
    public class VisitPlanningRepos : IVisitPlanningRepos
    {
        private CrmContext crmContext;

        public VisitPlanningRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createAccount(Account account)
        {
            crmContext.AddObject(account);
            crmContext.SaveChanges();
        }

        public Orb_visitplanningbase retrieveVisitPlanningByClassificationBaseIdAndByName(Guid classificationBaseId, string name)
        {
            Orb_visitplanningbase visitPlanningList = (from vp in crmContext.Orb_visitplanningbaseSet
                                                       where vp.orb_classificationbaseid.Id == classificationBaseId
                                                       where vp.Orb_name == name
                                                       where vp.StateCode.Value == (int)Orb_classificationbaseState.Active
                                                       select new Orb_visitplanningbase
                                                       {
                                                           Id = vp.Id,
                                                           Orb_VisitPlanned = vp.Orb_VisitPlanned
                                                       }).FirstOrDefault();
            return visitPlanningList;
        }
    }
}