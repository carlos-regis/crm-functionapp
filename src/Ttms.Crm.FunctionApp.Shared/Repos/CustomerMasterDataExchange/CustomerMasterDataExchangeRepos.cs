using Ttms.Crm.FunctionApp.Shared.EntityModel;
using System;
using System.Linq;

namespace Ttms.Crm.FunctionApp.Shared.Repos.CustomerMasterDataExchange
{
    public class CustomerMasterDataExchangeRepos : ICustomerMasterDataExchangeRepos
    {
        private CrmContext crmContext;

        public CustomerMasterDataExchangeRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }
        public void createCustomerMasterDataExchange(rbtt_customermasterdataexchange CMDE)
        {
            crmContext.AddObject(CMDE);
            crmContext.SaveChanges();
        }
        public void updateCMDE(rbtt_customermasterdataexchange cmde)
        {
            if (!crmContext.IsAttached(cmde))
            {
                crmContext.Attach(cmde);
            }
            crmContext.UpdateObject(cmde);
            crmContext.SaveChanges();
        }
        public rbtt_customermasterdataexchange GetCMDEByAccountId(Guid accountId)
        {
            rbtt_customermasterdataexchange CMDE = (from c in crmContext.rbtt_customermasterdataexchangeSet
                                                    where c.rbtt_Account.Id == accountId
                                                    && c.rbtt_MDCStatus.Value == 173140001
                                                    select new rbtt_customermasterdataexchange
                                                    {
                                                        Id = c.Id,
                                                        rbtt_MDCStatus = c.rbtt_MDCStatus,
                                                        StateCode = c.StateCode
                                                    }).FirstOrDefault();
            return CMDE;
        }
    }
}
