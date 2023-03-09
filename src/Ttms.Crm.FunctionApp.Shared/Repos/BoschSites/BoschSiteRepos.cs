using Ttms.Crm.FunctionApp.Shared.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ttms.Crm.FunctionApp.Shared.Repos.BoschSites
{
    public class BoschSiteRepos : IBoschSiteRepos
    {
        private CrmContext crmContext;

        public BoschSiteRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createBoschSite(rbtt_productionplants boschSite)
        {
            crmContext.AddObject(boschSite);
            crmContext.SaveChanges();
        }

        public rbtt_productionplants retrieveBoschSiteByPlantId(string id)
        {
            rbtt_productionplants boschSite = (from b in crmContext.rbtt_productionplantsSet
                                               where b.rbtt_PlantSAP == id
                                               select new rbtt_productionplants
                                               {
                                                   Id = b.Id,
                                                   rbtt_PlantSAP = b.rbtt_PlantSAP,
                                                   rbtt_name = b.rbtt_name,
                                                   rbtt_ShortForm = b.rbtt_ShortForm,
                                                   rbtt_Locationcode = b.rbtt_Locationcode,
                                                   rbtt_Country = b.rbtt_Country,
                                                   rbtt_BWN = b.rbtt_BWN,
                                                   rbtt_Companycode = b.rbtt_Companycode,
                                                   rbtt_ProductionPlant = b.rbtt_ProductionPlant,
                                                   rbtt_SalesOrganization = b.rbtt_SalesOrganization,
                                                   rbtt_Warehouse = b.rbtt_Warehouse,
                                                   ModifiedOn = b.ModifiedOn
                                               }).FirstOrDefault();
            return boschSite;
        }

        public rbtt_productionplants retrieveBoschSiteById(Guid id)
        {
            rbtt_productionplants boschSite = (from b in crmContext.rbtt_productionplantsSet
                                               where b.Id == id
                                               select new rbtt_productionplants
                                               {
                                                   Id = b.Id,
                                                   rbtt_PlantSAP = b.rbtt_PlantSAP,
                                                   rbtt_name = b.rbtt_name,
                                                   rbtt_ShortForm = b.rbtt_ShortForm,
                                                   rbtt_Locationcode = b.rbtt_Locationcode,
                                                   rbtt_Country = b.rbtt_Country,
                                                   rbtt_BWN = b.rbtt_BWN,
                                                   rbtt_Companycode = b.rbtt_Companycode,
                                                   rbtt_ProductionPlant = b.rbtt_ProductionPlant,
                                                   rbtt_SalesOrganization = b.rbtt_SalesOrganization,
                                                   rbtt_Warehouse = b.rbtt_Warehouse,
                                                   ModifiedOn = b.ModifiedOn
                                               }).FirstOrDefault();
            return boschSite;
        }

        public List<rbtt_productionplants> retrieveMultipleBoschSites()
        {
            List<rbtt_productionplants> boschSiteList = (from b in crmContext.rbtt_productionplantsSet
                                                         select new rbtt_productionplants
                                                         {
                                                             Id = b.Id,
                                                             rbtt_PlantSAP = b.rbtt_PlantSAP,
                                                             rbtt_name = b.rbtt_name,
                                                             rbtt_ShortForm = b.rbtt_ShortForm,
                                                             rbtt_Locationcode = b.rbtt_Locationcode,
                                                             rbtt_Country = b.rbtt_Country,
                                                             rbtt_BWN = b.rbtt_BWN,
                                                             rbtt_Companycode = b.rbtt_Companycode,
                                                             rbtt_ProductionPlant = b.rbtt_ProductionPlant,
                                                             rbtt_SalesOrganization = b.rbtt_SalesOrganization,
                                                             rbtt_Warehouse = b.rbtt_Warehouse,
                                                             ModifiedOn = b.ModifiedOn
                                                         }).ToList();
            return boschSiteList;
        }

        public rbtt_productionplants retrieveBoschSiteByPlantSAP(string planSAP)
        {
            rbtt_productionplants boschSite = (from b in crmContext.rbtt_productionplantsSet
                                               where b.rbtt_PlantSAP == planSAP
                                               select new rbtt_productionplants
                                               {
                                                   Id = b.Id,
                                                   rbtt_PlantSAP = b.rbtt_PlantSAP
                                               }).FirstOrDefault();
            return boschSite;
        }
    }
}