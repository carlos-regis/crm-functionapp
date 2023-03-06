using SharedLibraries_Plugins.EntityModel;
using System;

namespace SharedLibraries_Plugins.Repos.CustomerMasterDataExchange
{
    public interface ICustomerMasterDataExchangeRepos
    {
        void createCustomerMasterDataExchange(rbtt_customermasterdataexchange CMDE);
        void updateCMDE(rbtt_customermasterdataexchange cmde);
        rbtt_customermasterdataexchange GetCMDEByAccountId(Guid accountId);
    }
}
