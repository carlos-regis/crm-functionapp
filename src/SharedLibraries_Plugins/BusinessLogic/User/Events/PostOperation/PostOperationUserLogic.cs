using Microsoft.Xrm.Sdk;
using System;
using TTMSCRM.Plugins.CommonFunctions.ActiveDirectory;
using TTMSCRM.Plugins.EntityModel;

namespace SharedLibraries_Plugins.BusinessLogic.User.Events.PostOperation
{
    public class PostOperationUserLogic
    {
        #region Variables
        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmInterop crmInterop;
        private readonly CrmContext crmContext;
        #endregion

        #region Constructor
        public PostOperationUserLogic(ITracingService _tracingService, Entity _entity, Entity _preImage, CrmInterop _crmInterop, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.crmInterop = _crmInterop;
            this.crmContext = _crmContext;
        }
        #endregion

        #region Execute
        public void ValidateAndExecute()
        {
            if(entity.Attributes.Contains(SystemUser.Fields.IsDisabled) && !(Boolean)entity.Attributes[SystemUser.Fields.IsDisabled] &&
               (preImage.Attributes.Contains(SystemUser.Fields.DomainName) || entity.Attributes.Contains(SystemUser.Fields.DomainName)))
            {
                crmInterop.SyncCrmWithADUser(entity, preImage);
            }
            else
            {
                tracingService.Trace("- PostOperationUserLogic - Failed in the ValidateAndExecute method.");
                return;
            }
        }
        #endregion
    }
}
