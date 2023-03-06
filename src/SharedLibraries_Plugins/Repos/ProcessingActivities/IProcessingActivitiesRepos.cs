using SharedLibraries_Plugins.EntityModel;
using System;

namespace SharedLibraries_Plugins.Repos.ProcessingActivities
{
    public interface IProcessingActivitiesRepos
    {
        rbtt_processingactivity retrievedProcessingActivityById(Guid id);
        void createProcessingActivity(rbtt_processingactivity processingActivity);

    }
}
