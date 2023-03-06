using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.ConfigurationParameters
{
    public class ConfigurationParameterRepos : IConfigurationParameterRepos
    {
        private CrmContext crmContext;

        public ConfigurationParameterRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createConfig(rbtt_configurations config)
        {
            crmContext.AddObject(config);
            crmContext.SaveChanges();
        }

        public rbtt_configurations retrieveConfigByName(string name)
        {
            rbtt_configurations config = (from c in crmContext.rbtt_configurationsSet
                                          where c.rbtt_name == name
                                          select new rbtt_configurations
                                          {
                                              rbtt_name = c.rbtt_name,
                                              rbtt_Value = c.rbtt_Value,
                                              rbtt_AdditionalValue = c.rbtt_AdditionalValue
                                          }).FirstOrDefault();
            return config;
        }

        public List<rbtt_configurations> retrieveMultipleConfigByStartsWithName(string name)
        {
            List<rbtt_configurations> configList = (from c in crmContext.rbtt_configurationsSet
                                                    where c.rbtt_name.StartsWith(name)
                                                    select new rbtt_configurations
                                                    {
                                                        rbtt_name = c.rbtt_name,
                                                        rbtt_Value = c.rbtt_Value,
                                                        rbtt_AdditionalValue = c.rbtt_AdditionalValue
                                                    }).ToList();
            return configList;
        }

        public List<rbtt_configurations> retrieveMultipleConfigForConsents_Create()
        {
            List<rbtt_configurations> configList = (from c in crmContext.rbtt_configurationsSet
                                                    where c.rbtt_name == "GDPR Consent Activity Services - Post Create" ||
                                                    c.rbtt_name == "GDPR Client ID" || c.rbtt_name == "GDPR Client Secret" ||
                                                    c.rbtt_name == "GDPR Access Token URL" || c.rbtt_name == "GDPR Base URL" ||
                                                    c.rbtt_name == "GDPR MVC URL" || c.rbtt_name == "GDPR Proxy Settings - JOB"
                                                    select new rbtt_configurations
                                                    {
                                                        rbtt_name = c.rbtt_name,
                                                        rbtt_Value = c.rbtt_Value,
                                                        rbtt_AdditionalValue = c.rbtt_AdditionalValue
                                                    }).ToList();
            return configList;
        }

        public rbtt_configurations retrieveConfigByValue(string value)
        {
            throw new NotImplementedException();
        }

        public rbtt_configurations retrievedConfigById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<rbtt_configurations> retrieveMultipleConfigs()
        {
            throw new NotImplementedException();
        }
    }
}
