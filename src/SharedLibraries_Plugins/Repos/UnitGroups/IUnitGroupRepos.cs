using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.UnitGroups
{
    public interface IUnitGroupRepos
    {
        List<UoMSchedule> retrieveMultipleUnitGroups();
        UoMSchedule retrieveUnitGroupByName(string name);
        UoMSchedule retrieveUnitGroupById(Guid id);
    }
}
