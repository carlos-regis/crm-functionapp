using System;
using System.Collections.Generic;
using System.Linq;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.Shared.Repos.Countries
{
    public class CountryRepos : ICountryRepos
    {
        private readonly CrmContext crmContext;

        public CountryRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public Orb_country retrieveCountryById(Guid countryId)
        {
            Orb_country country = (from c in crmContext.Orb_countrySet
                                   where c.Id == countryId
                                   select new Orb_country
                                   {
                                       Id = c.Id,
                                       Orb_name = c.Orb_name,
                                       rbtt_ISO3166_Alpha_2 = c.rbtt_ISO3166_Alpha_2,
                                       rbtt_EmailTemplateGUID = c.rbtt_EmailTemplateGUID,
                                       rbtt_GDPRMailbox = c.rbtt_GDPRMailbox
                                   }).FirstOrDefault();
            return country;
        }

        public Orb_country retrieveCountryByIso(string iso)
        {
            Orb_country country = (from c in crmContext.Orb_countrySet
                                   where c.rbtt_ISO3166_Alpha_2 == iso
                                   select new Orb_country
                                   {
                                       Id = c.Id,
                                       Orb_name = c.Orb_name,
                                       rbtt_ISO3166_Alpha_2 = c.rbtt_ISO3166_Alpha_2
                                   }).FirstOrDefault();
            return country;
        }

        public Orb_country retrieveCountryPhonePrefix(Guid countryId)
        {
            Orb_country country = (from c in crmContext.Orb_countrySet
                                   where c.Id == countryId
                                   select new Orb_country
                                   {
                                       Id = c.Id,
                                       Orb_name = c.Orb_name,
                                       rbtt_phoneprefix = c.rbtt_phoneprefix
                                   }).FirstOrDefault();
            return country;
        }

        public List<Orb_country> retrieveMultipleCountries()
        {
            List<Orb_country> countryList = (from c in crmContext.Orb_countrySet
                                             select new Orb_country
                                             {
                                                 Id = c.Id,
                                                 Orb_name = c.Orb_name,
                                                 rbtt_ISO3166_Alpha_2 = c.rbtt_ISO3166_Alpha_2
                                             }).ToList();
            return countryList;
        }
    }
}