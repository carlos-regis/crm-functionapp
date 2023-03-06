using SharedLibraries_Plugins.EntityModel;
using System;

namespace SharedLibraries_Plugins.Repos.DeliveryNoteItem
{
    public interface IDeliveryNoteItemRepos
    {
        rbtt_delivernoteitem retrieveDeliveryNoteItemById(Guid deliveryNoteItemId);
        void createDeliveryNoteItem(rbtt_delivernoteitem delvierNoteItem);
        void updateDeliveryNoteItem(rbtt_delivernoteitem delvierNoteItem);
    }
}
