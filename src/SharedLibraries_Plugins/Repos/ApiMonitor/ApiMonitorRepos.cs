using SharedLibraries_Plugins.EntityModel;

namespace SharedLibraries_Plugins.Repos.ApiMonitor
{
    public class ApiMonitorRepos : IApiMonitorRepos
    {
        private CrmContext crmContext;

        public ApiMonitorRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createApiMonitor(rbtt_apimonitor apiMonitor)
        {
            crmContext.AddObject(apiMonitor);
            crmContext.SaveChanges();
        }
    }
}