using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Gratuities
{
    public class GratuitiesRepos : IGratuitiesRepos
    {
        private CrmContext crmContext;

        public GratuitiesRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public List<Btt_gratuity> retrieveMultipleGratuitiesByAccountIdAndYTD(Guid accountId, int YTD)
        {
            int currentYear = 0;

            if (YTD == 0)
                currentYear = DateTime.UtcNow.Date.AddYears(YTD).Year;
            else
                currentYear = DateTime.UtcNow.Date.AddYears(-YTD).Year;

            List<Btt_gratuity> gratuitiesList = (from e in crmContext.CreateQuery(Btt_gratuity.EntityLogicalName).ToList()
                                                 .Where(ne => ne.Contains(Btt_gratuity.Fields.CreatedOn) && ne.GetAttributeValue<DateTime>(Btt_gratuity.Fields.CreatedOn).Date.Year == currentYear &&
                                                              ne.Contains(Btt_gratuity.Fields.btt_accountid) && ne.GetAttributeValue<EntityReference>(Btt_gratuity.Fields.btt_accountid).Id == accountId &&
                                                              ne.Contains(Btt_gratuity.Fields.Btt_value))
                                                 select new Btt_gratuity
                                                 {
                                                     Id = e.Id,
                                                     Btt_value = e.GetAttributeValue<Money>(Btt_gratuity.Fields.Btt_value),
                                                     CreatedOn = e.GetAttributeValue<DateTime>(Btt_gratuity.Fields.CreatedOn)
                                                 }
                                                ).ToList();
            return gratuitiesList;
        }
    }
}
