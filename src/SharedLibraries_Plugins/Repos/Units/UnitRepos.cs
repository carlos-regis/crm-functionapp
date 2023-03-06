using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Units
{
    public class UnitRepos : IUnitRepos
    {
        private CrmContext crmContext;

        public UnitRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public List<UoM> retrieveMultipleUnits()
        {
            List<UoM> unitList = (from u in crmContext.UoMSet
                                  select new UoM
                                  {
                                      Id = u.Id,
                                      Name = u.Name,
                                      Quantity = u.Quantity
                                  }).ToList();
            return unitList;
        }

        public UoM retrieveUnitById(Guid id)
        {
            UoM unit = (from u in crmContext.UoMSet
                        where u.Id == id
                        select new UoM
                        {
                            Id = u.Id,
                            Name = u.Name,
                            Quantity = u.Quantity
                        }).FirstOrDefault();
            return unit;
        }

        public UoM retrieveUnitByName(string name)
        {
            UoM unit = (from u in crmContext.UoMSet
                        where u.Name == name
                        select new UoM
                        {
                            Id = u.Id,
                            Name = u.Name,
                            Quantity = u.Quantity
                        }).FirstOrDefault();
            return unit;
        }
    }
}