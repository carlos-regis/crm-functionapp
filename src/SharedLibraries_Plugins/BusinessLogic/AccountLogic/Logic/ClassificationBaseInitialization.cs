using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.ClassificationBases;
using SharedLibraries_Plugins.Repos.VisitPlanning;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic
{
    public class ClassificationBaseInitialization
    {
        private ITracingService tracingService;
        private Entity entity;
        private ClassificationBaseRepos classificationBaseRepos;

        public ClassificationBaseInitialization(ITracingService _tracingService, Entity _entity,
                               ClassificationBaseRepos classificationBaseRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.classificationBaseRepos = classificationBaseRepos;
        }

        public void AccountInitialization()
        {
            if (entity.Attributes.Contains("orb_classificationbaseid"))
            {
                Orb_classificationbase cb = classificationBaseRepos.retrieveClassificationBaseById(((EntityReference)entity.Attributes["orb_classificationbaseid"]).Id);
                if(cb != null)
                {
                    entity.Attributes["orb_potentiala"] = cb.Attributes.Contains("orb_potentiala") ? cb.Attributes["orb_potentiala"] : 0;
                    entity.Attributes["orb_potentialb"] = cb.Attributes.Contains("orb_potentialb") ? cb.Attributes["orb_potentialb"] : 0;
                    entity.Attributes["orb_useofpotential1"] = cb.Attributes.Contains("orb_useofpotential1") ? cb.Attributes["orb_useofpotential1"] : 0;
                    entity.Attributes["orb_useofpotential2"] = cb.Attributes.Contains("orb_useofpotential2") ? cb.Attributes["orb_useofpotential2"] : 0;
                    entity.Attributes["orb_bordercd"] = cb.Attributes.Contains("orb_useofpotential3") ? (double)cb.Attributes["orb_useofpotential3"] : 0;
                }
            }
        }
    }
}
