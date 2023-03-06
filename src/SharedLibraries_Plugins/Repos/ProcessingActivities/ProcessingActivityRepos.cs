using SharedLibraries_Plugins.EntityModel;
using System;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.ProcessingActivities
{
    public class ProcessingActivityRepos : IProcessingActivitiesRepos
    {
        private CrmContext crmContext;

        public ProcessingActivityRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createProcessingActivity(rbtt_processingactivity processingActivity)
        {
            crmContext.AddObject(processingActivity);
            crmContext.SaveChanges();
        }

        public rbtt_processingactivity retrievedProcessingActivityById(Guid id)
        {
            rbtt_processingactivity processingActivity = (from pa in crmContext.rbtt_processingactivitySet
                                                          where pa.Id == id
                                                          select new rbtt_processingactivity
                                                          {
                                                              Id = pa.Id,
                                                              rbtt_Activityname = pa.rbtt_Activityname
                                                          }).FirstOrDefault();
            return processingActivity;
        }
    }
}
