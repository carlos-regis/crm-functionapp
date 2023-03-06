using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;

namespace SharedLibraries_Plugins.BusinessLogic.DeliveryNoteItemLogic.Logic
{
    public class SetDeliveryNoteItemName
    {
        #region Variables

        private ITracingService tracingService;
        private Entity entity;
        private Entity entityToUpdate;
        private Entity preImage;

        #endregion Variables

        #region Constructor
        public SetDeliveryNoteItemName(ITracingService _tracingService, Entity _entity, Entity _entityToUpdate, Entity _preImage)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.entityToUpdate = _entityToUpdate;
            this.preImage = _preImage;
        }
        #endregion

        public rbtt_delivernoteitem SetDeliveryNoteItemName_Logic()
        {
            var deliveryNoteId = entity.Contains(rbtt_delivernoteitem.Fields.rbtt_DeliverNoteId) ? entity.GetAttributeValue<EntityReference>(rbtt_delivernoteitem.Fields.rbtt_DeliverNoteId).Id.ToString() : preImage.GetAttributeValue<EntityReference>(rbtt_delivernoteitem.Fields.rbtt_DeliverNoteId).Id.ToString();
            entityToUpdate.Attributes[rbtt_delivernoteitem.Fields.rbtt_name] = deliveryNoteId + "." + entity.Attributes[rbtt_delivernoteitem.Fields.rbtt_Position].ToString();

            return (rbtt_delivernoteitem)entityToUpdate;
        }
    }
}
