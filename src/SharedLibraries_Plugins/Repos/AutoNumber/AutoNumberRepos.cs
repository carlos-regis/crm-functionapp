using SharedLibraries_Plugins.EntityModel;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.AutoNumber
{
    public class AutoNumberRepos : IAutoNumberRepos
    {
        private CrmContext crmContext;
        public AutoNumberRepos(CrmContext _crmContext) { this.crmContext = _crmContext; }

        public alegri_autonumbercounter retrieveAutoNumberByEntityLogicalName(string entityLogicalName)
        {
            alegri_autonumbercounter autoNumberCounter = (from a in crmContext.alegri_autonumbercounterSet
                                                          where a.alegri_name == entityLogicalName
                                                          orderby a.alegri_Counterposition descending
                                                          select new alegri_autonumbercounter
                                                          {
                                                              Id = a.Id,
                                                              alegri_Counterposition = a.alegri_Counterposition,
                                                              alegri_DigitLength = a.alegri_DigitLength,
                                                              alegri_FieldLogicalName = a.alegri_FieldLogicalName,
                                                              alegri_Prefix = a.alegri_Prefix,
                                                              alegri_Suffix = a.alegri_Suffix
                                                          }).FirstOrDefault();

            return autoNumberCounter;
        }

        public void updateAutoNumberCounter(alegri_autonumbercounter autoNumberCounter)
        {
            if (!crmContext.IsAttached(autoNumberCounter))
            {
                crmContext.Attach(autoNumberCounter);
            }
            crmContext.UpdateObject(autoNumberCounter);
            crmContext.SaveChanges();
        }
    }
}
