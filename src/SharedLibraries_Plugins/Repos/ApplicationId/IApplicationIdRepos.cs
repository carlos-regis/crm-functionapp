using SharedLibraries_Plugins.EntityModel;
using System;

namespace SharedLibraries_Plugins.Repos.ApplicationId
{
    public interface IApplicationIdRepos
    {
        void createApplicationId(rbtt_applicationid applicationId);
        rbtt_applicationid retrievedApplicationIdById(Guid applicationId);
    }
}
