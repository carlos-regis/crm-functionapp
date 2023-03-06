using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.ApplianceLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.ProductRegistrations;

namespace SharedLibraries_Plugins.BusinessLogic.ApplianceLogic.Events.PostOperation
{
    public class PostOperationApplianceLogicSync
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity postImage;
        private readonly CrmContext crmContext;

        #endregion Variables

        #region Constructor
        public PostOperationApplianceLogicSync(ITracingService _tracingService, Entity _entity, Entity _postImage, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.postImage = _postImage;
            this.crmContext = _crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                if (entity.Attributes.Contains(rbtt_appliance.Fields.rbtt_serialnumber) &&
                   (postImage != null && postImage.Attributes.Contains(rbtt_appliance.Fields.rbtt_serialnumber)))
                {
                    ProductRegistrationRepos productRegistrationRepos = new ProductRegistrationRepos(crmContext);

                    SetProductRegistrationState sprs = new SetProductRegistrationState(tracingService, postImage, productRegistrationRepos);
                    sprs.SetProductRegistrationState_Logic();
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

        #endregion Execute
    }
}
