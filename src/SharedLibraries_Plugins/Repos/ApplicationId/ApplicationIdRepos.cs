using SharedLibraries_Plugins.EntityModel;
using System;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.ApplicationId
{
    public class ApplicationIdRepos : IApplicationIdRepos
    {
        private CrmContext crmContext;

        public ApplicationIdRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createApplicationId(rbtt_applicationid applicationId)
        {
            crmContext.AddObject(applicationId);
            crmContext.SaveChanges();
        }

        public rbtt_applicationid retrievedApplicationIdById(Guid id)
        {
            rbtt_applicationid applicationId = (from ai in crmContext.rbtt_applicationidSet
                                                where ai.Id == id
                                                select new rbtt_applicationid
                                                {
                                                    Id = ai.Id,
                                                    rbtt_ApplicationIDValues = ai.rbtt_ApplicationIDValues
                                                }).FirstOrDefault();
            return applicationId;
        }
    }
}
