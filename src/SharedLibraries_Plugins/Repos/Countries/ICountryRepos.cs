using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Countries
{
    public interface ICountryRepos
    {
        Orb_country retrieveCountryById(Guid countryId);
        Orb_country retrieveCountryByIso(string iso);
        Orb_country retrieveCountryPhonePrefix(Guid countryId);
        List<Orb_country> retrieveMultipleCountries();
    }
}
