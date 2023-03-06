using Microsoft.Xrm.Sdk;

namespace SharedLibraries_Plugins.BusinessLogic.ContactLogic.Filter
{
    public interface IContactFilter
    {
        bool ValidatePhonePrefix(Entity entity);
    }
}
