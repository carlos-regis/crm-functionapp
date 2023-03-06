using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Units
{
    public interface IUnitRepos
    {
        List<UoM> retrieveMultipleUnits();
        UoM retrieveUnitByName(string name);
        UoM retrieveUnitById(Guid id);
    }
}
