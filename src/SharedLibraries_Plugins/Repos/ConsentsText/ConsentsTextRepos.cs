using SharedLibraries_Plugins.EntityModel;
using System;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.ConsentsText
{
    public class ConsentsTextRepos : IConsentsTextRepos
    {
        private CrmContext crmContext;
        public ConsentsTextRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }
        public void createConsentText(rbtt_consenttext consentText)
        {
            crmContext.AddObject(consentText);
            crmContext.SaveChanges();
        }

        public rbtt_consenttext retrieveConsentTextById(Guid consentTextId)
        {
            rbtt_consenttext consentText = (from ct in crmContext.rbtt_consenttextSet
                                            where ct.Id == consentTextId
                                            select new rbtt_consenttext
                                            {
                                                Id = ct.Id,
                                                rbtt_ExternalID = ct.rbtt_ExternalID
                                            }).FirstOrDefault();
            return consentText;
        }
    }
}
