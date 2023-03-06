using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Appliances
{
    public interface IApplianceRepos
    {
        rbtt_appliance retrieveApplianceBySerialNumber(string id);
        rbtt_appliance retrieveApplianceById(Guid id);
        List<rbtt_appliance> retrieveMultipleAppliances();
        void createAppliance(rbtt_appliance appliance);
        void updateAppliance(rbtt_appliance appliance);
    }
}
