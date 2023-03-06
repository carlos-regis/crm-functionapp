using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.DeliveryNoteItemLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.DeliveryNoteItem;

namespace SharedLibraries_Plugins.BusinessLogic.DeliveryNoteItemLogic.Events.PreOperation
{
    public class PreOperationDeliveryNoteItemLogic
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;

        #endregion Variables

        #region Constructor

        public PreOperationDeliveryNoteItemLogic(ITracingService _tracingService, Entity _entity, Entity _preImage, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.crmContext = _crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                if ((entity.Attributes.Contains(rbtt_delivernoteitem.Fields.rbtt_DeliverNoteId) || preImage != null && preImage.Attributes.Contains(rbtt_delivernoteitem.Fields.rbtt_DeliverNoteId)) &&
                   entity.Attributes.Contains(rbtt_delivernoteitem.Fields.rbtt_Position))
                {
                    DeliveryNoteItemRepos deliveryNoteItemRepos = new DeliveryNoteItemRepos(crmContext);

                    rbtt_delivernoteitem deliveryNoteItemToUpdate = new rbtt_delivernoteitem();
                    deliveryNoteItemToUpdate.Id = entity.Id;

                    SetDeliveryNoteItemName sdnin = new SetDeliveryNoteItemName(tracingService, entity, deliveryNoteItemToUpdate, preImage);
                    sdnin.SetDeliveryNoteItemName_Logic();

                    deliveryNoteItemRepos.updateDeliveryNoteItem(deliveryNoteItemToUpdate);
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
