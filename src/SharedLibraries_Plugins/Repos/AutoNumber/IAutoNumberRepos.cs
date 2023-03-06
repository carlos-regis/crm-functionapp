using SharedLibraries_Plugins.EntityModel;

namespace SharedLibraries_Plugins.Repos.AutoNumber
{
    public interface IAutoNumberRepos
    {
        alegri_autonumbercounter retrieveAutoNumberByEntityLogicalName(string entityLogicalName);
        void updateAutoNumberCounter(alegri_autonumbercounter autoNumberCounter);
    }
}
