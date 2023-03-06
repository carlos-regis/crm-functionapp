using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Appliances
{
    public class ApplianceRepos : IApplianceRepos
    {
        private CrmContext crmContext;

        public ApplianceRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createAppliance(rbtt_appliance appliance)
        {
            crmContext.AddObject(appliance);
            crmContext.SaveChanges();
        }

        public rbtt_appliance retrieveApplianceById(Guid id)
        {
            rbtt_appliance appliance = (from a in crmContext.rbtt_applianceSet
                                        where a.Id == id
                                        select new rbtt_appliance
                                        {
                                            Id = a.Id,
                                            rbtt_serialnumber = a.rbtt_serialnumber,
                                            rbtt_Brand = a.rbtt_Brand,
                                            rbtt_Product = a.rbtt_Product,
                                            rbtt_ProductionPlant = a.rbtt_ProductionPlant,
                                            rbtt_ManufacturingDate = a.rbtt_ManufacturingDate,
                                            rbtt_ProductionCounter = a.rbtt_ProductionCounter,
                                            rbtt_RawSerialNumber = a.rbtt_RawSerialNumber,
                                            rbtt_FakeSNSAP = a.rbtt_FakeSNSAP,
                                            rbtt_PTTEquipmentID = a.rbtt_PTTEquipmentID,
                                            ModifiedOn = a.ModifiedOn
                                        }).FirstOrDefault();
            return appliance;
        }

        public rbtt_appliance retrieveApplianceBySerialNumber(string id)
        {
            rbtt_appliance appliance = (from a in crmContext.rbtt_applianceSet
                                        where a.rbtt_serialnumber == id
                                        select new rbtt_appliance
                                        {
                                            Id = a.Id,
                                            rbtt_serialnumber = a.rbtt_serialnumber,
                                            rbtt_Brand = a.rbtt_Brand,
                                            rbtt_Product = a.rbtt_Product,
                                            rbtt_ProductionPlant = a.rbtt_ProductionPlant,
                                            rbtt_ManufacturingDate = a.rbtt_ManufacturingDate,
                                            rbtt_ProductionCounter = a.rbtt_ProductionCounter,
                                            rbtt_RawSerialNumber = a.rbtt_RawSerialNumber,
                                            rbtt_FakeSNSAP = a.rbtt_FakeSNSAP,
                                            rbtt_PTTEquipmentID = a.rbtt_PTTEquipmentID,
                                            ModifiedOn = a.ModifiedOn
                                        }).FirstOrDefault();
            return appliance;
        }

        public List<rbtt_appliance> retrieveMultipleAppliances()
        {
            List<rbtt_appliance> applianceList = (from a in crmContext.rbtt_applianceSet
                                                  select new rbtt_appliance
                                                  {
                                                      Id = a.Id,
                                                      rbtt_serialnumber = a.rbtt_serialnumber,
                                                      rbtt_Brand = a.rbtt_Brand,
                                                      rbtt_Product = a.rbtt_Product,
                                                      rbtt_ProductionPlant = a.rbtt_ProductionPlant,
                                                      rbtt_ManufacturingDate = a.rbtt_ManufacturingDate,
                                                      rbtt_ProductionCounter = a.rbtt_ProductionCounter,
                                                      rbtt_RawSerialNumber = a.rbtt_RawSerialNumber,
                                                      rbtt_FakeSNSAP = a.rbtt_FakeSNSAP,
                                                      rbtt_PTTEquipmentID = a.rbtt_PTTEquipmentID,
                                                      ModifiedOn = a.ModifiedOn
                                                  }).ToList();
            return applianceList;
        }

        public void updateAppliance(rbtt_appliance appliance)
        {
            if (!crmContext.IsAttached(appliance))
            {
                crmContext.Attach(appliance);
            }
            crmContext.UpdateObject(appliance);
            crmContext.SaveChanges();
        }
    }
}