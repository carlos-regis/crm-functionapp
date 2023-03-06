using SharedLibraries_Plugins.EntityModel;
using System;

namespace SharedLibraries_Plugins.Repos.ClassificationBases
{
    public interface IClassificationBaseRepos
    {
        Orb_classificationbase retrieveClassificationBaseById(Guid classificationBaseId);
    }
}
