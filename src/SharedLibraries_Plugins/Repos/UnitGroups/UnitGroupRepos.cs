using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.UnitGroups
{
    public class UnitGroupRepos : IUnitGroupRepos
    {
        private CrmContext crmContext;
        public UnitGroupRepos(CrmContext _crmContext) { this.crmContext = _crmContext; }

        public List<UoMSchedule> retrieveMultipleUnitGroups()
        {
            List<UoMSchedule> unitGroupList = (from u in crmContext.UoMScheduleSet
                                               select new UoMSchedule
                                               {
                                                   Id = u.Id,
                                                   Name = u.Name
                                               }).ToList();
            return unitGroupList;
        }

        public UoMSchedule retrieveUnitGroupById(Guid id)
        {
            UoMSchedule unitGroup = (from u in crmContext.UoMScheduleSet
                                     where u.Id == id
                                     select new UoMSchedule
                                     {
                                         Id = u.Id,
                                         Name = u.Name
                                     }).FirstOrDefault();
            return unitGroup;
        }

        public UoMSchedule retrieveUnitGroupByName(string name)
        {
            UoMSchedule unitGroup = (from u in crmContext.UoMScheduleSet
                                     where u.Name == name
                                     select new UoMSchedule
                                     {
                                         Id = u.Id,
                                         Name = u.Name
                                     }).FirstOrDefault();
            return unitGroup;
        }

    }
}
