using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Linq;

namespace SharedLibraries_Plugins
{
    public class Options
    {
        public static int GlobalOptions(IOrganizationService _orgService, String GlobalName, String Attribute)
        {
            var retrieveAllOptionSetsRequest = new RetrieveAllOptionSetsRequest();
            RetrieveAllOptionSetsResponse retrieveAllOptionSetsResponse = (RetrieveAllOptionSetsResponse)_orgService.Execute(retrieveAllOptionSetsRequest);
            if (retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0)
            {
                foreach (OptionSetMetadataBase optionSetMetadataBase in retrieveAllOptionSetsResponse.OptionSetMetadata)
                {
                    if (optionSetMetadataBase.OptionSetType != null)
                    {
                        if (optionSetMetadataBase.OptionSetType == OptionSetType.Picklist)
                        {
                            OptionSetMetadata optionSetMetadata = (OptionSetMetadata)optionSetMetadataBase;
                            if (optionSetMetadata.Name == GlobalName)
                            {
                                int optionvalue = 0;

                                foreach (OptionMetadata option in optionSetMetadata.Options)
                                {
                                    string o1 = option.Label.ToString();
                                    if (Attribute == "e.l.m Leblanc")
                                        Attribute = "ELM";
                                    if (option.Label.UserLocalizedLabel.Label.ToString() == Attribute)
                                        optionvalue = (int)option.Value;
                                }

                                if (optionvalue == 0)
                                    optionvalue = GlobalOptions(_orgService, "btt_brands", "Unknown");

                                return optionvalue;
                            }
                        }
                    }
                }
            }
            return 0;
        }

        public static string RetrieveOptionSetText(IOrganizationService service, string entityName, String attributeName, int optionValue)
        {
            if (optionValue == 0 || entityName == null || attributeName == null)
                return null;

            var attributeRequest = new RetrieveAttributeRequest
            {
                EntityLogicalName = entityName,
                LogicalName = attributeName,
                RetrieveAsIfPublished = true
            };

            var attributeResponse = (RetrieveAttributeResponse)service.Execute(attributeRequest);
            var attributeMetadata = (EnumAttributeMetadata)attributeResponse.AttributeMetadata;

            var optionList = (from o in attributeMetadata.OptionSet.Options select new { Value = o.Value, Text = o.Label.UserLocalizedLabel.Label }).ToList();

            //var activeValue = optionList.Where(o => o.Text == "Active").Select(o => o.Value).FirstOrDefault();
            var activeValue = optionList.Where(o => o.Value == optionValue).Select(o => o.Text).FirstOrDefault();

            return activeValue.ToString();
        }
    }
}