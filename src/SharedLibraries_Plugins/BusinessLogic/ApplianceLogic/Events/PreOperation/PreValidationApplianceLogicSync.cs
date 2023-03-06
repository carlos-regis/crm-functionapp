using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.ApplianceLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Appliances;
using SharedLibraries_Plugins.Repos.BoschSites;
using SharedLibraries_Plugins.Repos.Products;
using SharedLibraries_Plugins.Repos.Users;

namespace SharedLibraries_Plugins.BusinessLogic.ApplianceLogic.Events.PreOperation
{
    public class PreValidationApplianceLogicSync
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;
        private readonly string contextUserId;

        #endregion Variables

        #region Constructor

        public PreValidationApplianceLogicSync(ITracingService _tracingService, Entity _entity, Entity _preImage, string _contextUserId, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.contextUserId = _contextUserId;
            this.crmContext = _crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                ApplianceRepos applianceRepos = new ApplianceRepos(crmContext);

                rbtt_appliance applianceToUpdate = new rbtt_appliance();
                applianceToUpdate.Id = entity.Id;

                if ((entity.Attributes.Contains(rbtt_appliance.Fields.rbtt_serialnumber) &&
                    entity.Attributes.Contains(rbtt_appliance.Fields.rbtt_ManufacturingDate)) ||
                    (preImage != null &&
                    preImage.Attributes.Contains(rbtt_appliance.Fields.rbtt_ManufacturingDate) ||
                    preImage.Attributes.Contains(rbtt_appliance.Fields.rbtt_serialnumber)))
                {
                    UserRepos userRepos = new UserRepos(crmContext);
                    BoschSiteRepos boschSiteRepos = new BoschSiteRepos(crmContext);
                    ProductRepos productRepos = new ProductRepos(crmContext);

                    SerialNumberValidation snv = new SerialNumberValidation(tracingService, entity, applianceToUpdate, preImage, contextUserId, userRepos, boschSiteRepos, productRepos);
                    applianceToUpdate = snv.SerialNumberValidation_Logic();
                }
                else
                {
                    applianceToUpdate.Attributes[rbtt_appliance.Fields.StatusCode] = new OptionSetValue((int)rbtt_appliance_StatusCode.SPAM);
                }

                applianceRepos.updateAppliance(applianceToUpdate);
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

        #endregion Execute
    }
}
