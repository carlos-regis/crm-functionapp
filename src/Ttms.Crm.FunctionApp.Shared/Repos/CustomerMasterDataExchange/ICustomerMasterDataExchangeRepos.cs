using Ttms.Crm.FunctionApp.Shared.EntityModel;
using System;

namespace Ttms.Crm.FunctionApp.Shared.Repos.CustomerMasterDataExchange
{
    public interface ICustomerMasterDataExchangeRepos
    {
        void createCustomerMasterDataExchange(rbtt_customermasterdataexchange CMDE);
        void updateCMDE(rbtt_customermasterdataexchange cmde);
        rbtt_customermasterdataexchange GetCMDEByAccountId(Guid accountId);
    }
}
