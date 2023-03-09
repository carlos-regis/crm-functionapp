using System;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.Shared.Repos.ClassificationBases
{
    public interface IClassificationBaseRepos
    {
        Orb_classificationbase retrieveClassificationBaseById(Guid classificationBaseId);
    }
}
