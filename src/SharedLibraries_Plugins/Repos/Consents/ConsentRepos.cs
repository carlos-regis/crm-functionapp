using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Consents
{
    public class ConsentRepos : IConsentRepos
    {
        private CrmContext crmContext;

        public ConsentRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createConsent(rbtt_consent consent)
        {
            crmContext.AddObject(consent);
            crmContext.SaveChanges();
        }

        public void updateConsent(rbtt_consent consent)
        {
            if (!crmContext.IsAttached(consent))
                crmContext.Attach(consent);

            crmContext.UpdateObject(consent);
            crmContext.SaveChanges();
        }

        public List<rbtt_consent> retrieveMultipleConsentByContactId(Guid contactId)
        {
            List<rbtt_consent> consent = (from c in crmContext.rbtt_consentSet
                                          where c.rbtt_Contact2.Id == contactId
                                          select new rbtt_consent
                                          {
                                              Id = c.Id,
                                              rbtt_ConsentName = c.rbtt_ConsentName,
                                              rbtt_Email = c.rbtt_Email,
                                              rbtt_Phone = c.rbtt_Phone,
                                              rbtt_Mobilephone = c.rbtt_Mobilephone,
                                              rbtt_Fax = c.rbtt_Fax,
                                              rbtt_Letter = c.rbtt_Letter
                                          }).ToList();
            return consent;
        }

        public rbtt_consent retrieveConsentById(Guid consentId)
        {
            rbtt_consent consent = (from c in crmContext.rbtt_consentSet
                                    where c.Id == consentId
                                    select new rbtt_consent
                                    {
                                        Id = c.Id,
                                        rbtt_ConsentName = c.rbtt_ConsentName
                                    }).FirstOrDefault();
            return consent;
        }

        public List<rbtt_consent> retrieveMultipleConsents()
        {
            List<rbtt_consent> consentList = (from c in crmContext.rbtt_consentSet
                                              select new rbtt_consent
                                              {
                                                  Id = c.Id,
                                                  rbtt_ConsentName = c.rbtt_ConsentName
                                              }).ToList();
            return consentList;
        }
    }
}
