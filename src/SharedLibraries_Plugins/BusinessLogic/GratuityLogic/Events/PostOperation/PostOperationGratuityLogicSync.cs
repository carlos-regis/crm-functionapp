using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.GratuityLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.Gratuities;

namespace SharedLibraries_Plugins.BusinessLogic.GratuityLogic.Events.PostOperation
{
    public class PostOperationGratuityLogicSync
    {
        #region Variables
        private readonly ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;
        #endregion

        #region Constructor
        public PostOperationGratuityLogicSync(ITracingService _tracingService, Entity _entity, Entity _preImage, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.crmContext = _crmContext;
        }
        #endregion

        public void ValidateAndExecute()
        {
            try
            {
                if (entity.Contains(Btt_gratuity.Fields.btt_accountid) || entity.Contains(Btt_gratuity.Fields.Btt_value) &&
                    preImage.Contains(Btt_gratuity.Fields.btt_accountid))
                {
                    tracingService.Trace("CalculateGratuities_Logic --> Starting");

                    GratuitiesRepos gratuitiesRepos = new GratuitiesRepos(crmContext);
                    AccountRepos accountRepos = new AccountRepos(crmContext);

                    CalculateGratuities cg = new CalculateGratuities(tracingService, entity, preImage, accountRepos, gratuitiesRepos);
                    cg.CalculateGratuities_Logic();

                    tracingService.Trace("CalculateGratuities_Logic --> Ending");
                }
            }
            catch (InvalidPluginExecutionException Ex)
            {
                throw new InvalidPluginExecutionException("\n\nInvalidPluginExecutionException\n-----------------------------------------------\n" +
                                    "\nErro Message:\n" + Ex.Message.ToString() +
                                    "\nErrorCode:\n" + Ex.ErrorCode.ToString() +
                                    "\nData:\n" + Ex.Data.ToString() +
                                    "\nHResult:\n" + Ex.HResult.ToString() +
                                    "\nInnerException:\n" + Ex.InnerException.ToString() +
                                    "\nSource:\n" + Ex.Source.ToString() +
                                    "\nStatus:\n" + Ex.Status.ToString() +
                                    "\nStatus:\n" + Ex.Status.ToString() +
                                    "\nHelpLink:\n" + Ex.HelpLink.ToString() +
                                    "\n\n-----------------------------------------------\n\n");

            }
        }
    }
}
