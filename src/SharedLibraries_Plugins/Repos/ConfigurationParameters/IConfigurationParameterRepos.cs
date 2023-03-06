using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.ConfigurationParameters
{
    public interface IConfigurationParameterRepos
    {
        List<rbtt_configurations> retrieveMultipleConfigs();
        List<rbtt_configurations> retrieveMultipleConfigByStartsWithName(string name);
        List<rbtt_configurations> retrieveMultipleConfigForConsents_Create();
        rbtt_configurations retrieveConfigByName(string name);
        rbtt_configurations retrieveConfigByValue(string value);
        rbtt_configurations retrievedConfigById(Guid id);
        void createConfig(rbtt_configurations config);
    }
}
