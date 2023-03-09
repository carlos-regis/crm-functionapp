using System;
using System.Collections.Generic;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.Shared.Repos.Countries
{
    public interface ICountryRepos
    {
        Orb_country retrieveCountryById(Guid countryId);
        Orb_country retrieveCountryByIso(string iso);
        Orb_country retrieveCountryPhonePrefix(Guid countryId);
        List<Orb_country> retrieveMultipleCountries();
    }
}
