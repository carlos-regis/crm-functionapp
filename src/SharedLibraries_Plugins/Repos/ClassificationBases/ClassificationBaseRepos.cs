using SharedLibraries_Plugins.EntityModel;
using System;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.ClassificationBases
{
    public class ClassificationBaseRepos : IClassificationBaseRepos
    {
        private CrmContext crmContext;

        public ClassificationBaseRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public Orb_classificationbase retrieveClassificationBaseById(Guid classificationBaseId)
        {
            Orb_classificationbase classificationBase = (from cb in crmContext.Orb_classificationbaseSet
                                                         where cb.Id == classificationBaseId
                                                         select new Orb_classificationbase
                                                         {
                                                             Id = cb.Id,
                                                             Orb_name = cb.Orb_name,
                                                             Btt_Valueperappliance = cb.Btt_Valueperappliance,
                                                             Orb_potentialA = cb.Orb_potentialA,
                                                             Orb_potentialb = cb.Orb_potentialb,
                                                             Orb_useofpotential1 = cb.Orb_useofpotential1,
                                                             Orb_useofpotential2 = cb.Orb_useofpotential2,
                                                             Orb_useofpotential3 = cb.rbtt_useofpotential3
                                                         }).FirstOrDefault();

            return classificationBase;
        }
    }
}
