using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.ProductRegistrations;

namespace SharedLibraries_Plugins.BusinessLogic.ApplianceLogic.Logic
{
    public class SetProductRegistrationState
    {
        #region Variables

        private ITracingService tracingService;
        private Entity postImage;
        private ProductRegistrationRepos productRegistrationRepos;

        #endregion Variables

        #region Constructor
        public SetProductRegistrationState(ITracingService _tracingService, Entity _postImage, ProductRegistrationRepos _productRegistrationRepos)
        {
            this.tracingService = _tracingService;
            this.postImage = _postImage;
            this.productRegistrationRepos = _productRegistrationRepos;
        }
        #endregion

        #region Logic

        public void SetProductRegistrationState_Logic()
        {
            tracingService.Trace("SetProductRegistrationState_Logic --> Started");

            var retrievedProductRegistrationList = productRegistrationRepos.retrieveMultipleProductRegistrationByApplianceId(postImage.Id);

            if (retrievedProductRegistrationList.Count > 0)
            {
                foreach (var pr in retrievedProductRegistrationList)
                {
                    pr.StateCode = (Orb_machineState?)postImage.GetAttributeValue<OptionSetValue>(rbtt_appliance.Fields.StateCode).Value;
                    pr.StatusCode = postImage.GetAttributeValue<OptionSetValue>(rbtt_appliance.Fields.StatusCode);

                    productRegistrationRepos.updateProductRegistration(pr);
                }
            }

            tracingService.Trace("SetProductRegistrationState_Logic --> Ended");
        }

        #endregion
    }
}
