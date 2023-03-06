using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Gratuities
{
    public interface IGratuitiesRepos
    {
        List<Btt_gratuity> retrieveMultipleGratuitiesByAccountIdAndYTD(Guid accountId, int YTD);
    }
}
