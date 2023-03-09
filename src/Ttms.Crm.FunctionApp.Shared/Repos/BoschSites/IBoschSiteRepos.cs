using Ttms.Crm.FunctionApp.Shared.EntityModel;
using System;
using System.Collections.Generic;

namespace Ttms.Crm.FunctionApp.Shared.Repos.BoschSites
{
    public interface IBoschSiteRepos
    {
        List<rbtt_productionplants> retrieveMultipleBoschSites();
        rbtt_productionplants retrieveBoschSiteByPlantId(string id);
        rbtt_productionplants retrieveBoschSiteById(Guid id);
        rbtt_productionplants retrieveBoschSiteByPlantSAP(string planSAP);
        void createBoschSite(rbtt_productionplants boschSite);
    }
}
