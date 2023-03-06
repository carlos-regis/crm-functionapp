using SharedLibraries_Plugins.EntityModel;
using System;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.DeliveryNoteItem
{
    public class DeliveryNoteItemRepos : IDeliveryNoteItemRepos
    {
        private CrmContext crmContext;

        public DeliveryNoteItemRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createDeliveryNoteItem(rbtt_delivernoteitem delvierNoteItem)
        {
            crmContext.AddObject(delvierNoteItem);
            crmContext.SaveChanges();
        }

        public rbtt_delivernoteitem retrieveDeliveryNoteItemById(Guid deliveryNoteItemId)
        {
            rbtt_delivernoteitem deliverNoteItem = (from d in crmContext.rbtt_delivernoteitemSet
                                                    where d.Id == deliveryNoteItemId
                                                    select new rbtt_delivernoteitem
                                                    {
                                                        Id = d.Id,
                                                        rbtt_name = d.rbtt_name
                                                    }).FirstOrDefault();
            return deliverNoteItem;
        }

        public void updateDeliveryNoteItem(rbtt_delivernoteitem delvierNoteItem)
        {
            if (!crmContext.IsAttached(delvierNoteItem))
            {
                crmContext.Attach(delvierNoteItem);
            }
            crmContext.UpdateObject(delvierNoteItem);
            crmContext.SaveChanges();
        }
    }
}
