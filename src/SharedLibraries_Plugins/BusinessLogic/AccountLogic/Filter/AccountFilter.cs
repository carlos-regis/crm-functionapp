using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Filter
{
    public class AccountFilter : IAccountFilter
    {
        public bool ValidateCMD(Entity entity, Entity preImage)
        {
            if ((entity.Attributes.Contains(Account.Fields.orb_classificationbaseid) && entity.GetAttributeValue<EntityReference>(Account.Fields.orb_classificationbaseid) != null) ||
                ((entity.Attributes.Contains(Account.Fields.Btt_Totalpotential) && entity.GetAttributeValue<Money>(Account.Fields.Btt_Totalpotential) != null) &&
                (entity.Attributes.Contains(Account.Fields.Btt_TT_Turnover) && entity.GetAttributeValue<Money>(Account.Fields.Btt_TT_Turnover) != null) &&
                (preImage != null && preImage.Attributes.Contains(Account.Fields.orb_classificationbaseid) && preImage.GetAttributeValue<EntityReference>(Account.Fields.orb_classificationbaseid) != null)))
            {
                return true;
            }

            return false;
        }

        public bool ValidateABCStatus(Entity entity, Entity postImage)
        {
            if (entity.Attributes.Contains(Account.Fields.rbtt_CustomerMasterData) && entity.GetAttributeValue<bool>(Account.Fields.rbtt_CustomerMasterData) &&
                postImage != null)
            {
                return true;
            }

            return false;
        }

        public bool ValidateAutoNrGenerator(Entity entity)
        {
            if (!entity.Attributes.Contains(Account.Fields.btt_CRMAccountNumber))
            {
                return true;
            }

            return false;
        }

        public bool ValidateCountVisitPlans(Entity entity)
        {
            if (entity.Attributes.Contains(Account.Fields.orb_classificationbaseid) && 
                entity.GetAttributeValue<EntityReference>(Account.Fields.orb_classificationbaseid) != null)
            {
                return true;
            }

            return false;
        }

        public bool ValidatePhonePrefix(Entity entity)
        {
            if (entity.Attributes.Contains(Account.Fields.Telephone1)){
                if ((!entity.GetAttributeValue<string>(Account.Fields.Telephone1).Equals(string.Empty) &&
                !entity.GetAttributeValue<string>(Account.Fields.Telephone1).StartsWith("+")) ||
                entity.Attributes.Contains(Account.Fields.orb_countryid))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
