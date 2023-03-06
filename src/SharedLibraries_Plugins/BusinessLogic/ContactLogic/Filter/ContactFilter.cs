using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;

namespace SharedLibraries_Plugins.BusinessLogic.ContactLogic.Filter
{
    public class ContactFilter : IContactFilter
    {
        public bool ValidatePhonePrefix(Entity entity)
        {
            bool toBeReturned = false;
            if (entity.Attributes.Contains(Contact.Fields.Telephone1))
                if (!entity.GetAttributeValue<string>(Contact.Fields.Telephone1).Equals(string.Empty) && !entity.GetAttributeValue<string>(Contact.Fields.Telephone1).StartsWith("+")) 
                    toBeReturned = true;
            
            if (entity.Attributes.Contains(Contact.Fields.MobilePhone))
                if (!entity.GetAttributeValue<string>(Contact.Fields.MobilePhone).Equals(string.Empty) && !entity.GetAttributeValue<string>(Contact.Fields.MobilePhone).StartsWith("+")) 
                    toBeReturned = true;
            
            if (entity.Attributes.Contains(Contact.Fields.Fax))
                if(!entity.GetAttributeValue<string>(Contact.Fields.Fax).Equals(string.Empty) && !entity.GetAttributeValue<string>(Contact.Fields.Fax).StartsWith("+")) 
                    toBeReturned = true;

            return toBeReturned;
        }
    }
}
