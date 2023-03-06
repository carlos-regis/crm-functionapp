using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Users
{
    public class UserRepos : IUserRepos
    {
        private CrmContext crmContext;

        public UserRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public SystemUser retrieveEnableUserById(Guid userId)
        {
            SystemUser user = (from u in crmContext.SystemUserSet
                               where u.Id == userId
                               where u.IsDisabled == false
                               select new SystemUser
                               {
                                   Id = u.Id,
                                   FirstName = u.FirstName,
                                   LastName = u.LastName,
                                   InternalEMailAddress = u.InternalEMailAddress,
                                   DomainName = u.DomainName,
                                   MobilePhone = u.MobilePhone,
                                   Address1_Telephone1 = u.Address1_Telephone1,
                                   ModifiedOn = u.ModifiedOn
                               }).FirstOrDefault();
            return user;
        }

        public List<SystemUser> retrieveMultipleUsers()
        {
            List<SystemUser> userList = (from u in crmContext.SystemUserSet
                                         select new SystemUser
                                         {
                                             Id = u.Id,
                                             FirstName = u.FirstName,
                                             LastName = u.LastName,
                                             InternalEMailAddress = u.InternalEMailAddress,
                                             DomainName = u.DomainName,
                                             MobilePhone = u.MobilePhone,
                                             Address1_Telephone1 = u.Address1_Telephone1,
                                             ModifiedOn = u.ModifiedOn
                                         }).ToList();
            return userList;
        }

        public SystemUser retrieveUserByDomainName(string domainName)
        {
            SystemUser user = (from u in crmContext.SystemUserSet
                               where u.DomainName == domainName
                               select new SystemUser
                               {
                                   Id = u.Id,
                                   FirstName = u.FirstName,
                                   LastName = u.LastName
                               }).FirstOrDefault();
            return user;
        }

        public SystemUser retrieveUserByEmail(string emailAddress)
        {
            SystemUser user = (from u in crmContext.SystemUserSet
                               where u.InternalEMailAddress == emailAddress
                               select new SystemUser
                               {
                                   Id = u.Id,
                                   FirstName = u.FirstName,
                                   LastName = u.LastName,
                                   InternalEMailAddress = u.InternalEMailAddress,
                                   DomainName = u.DomainName,
                                   MobilePhone = u.MobilePhone,
                                   Address1_Telephone1 = u.Address1_Telephone1,
                                   ModifiedOn = u.ModifiedOn
                               }).FirstOrDefault();
            return user;
        }

        public SystemUser retrieveUserById(Guid userId)
        {
            SystemUser user = (from u in crmContext.SystemUserSet
                               where u.Id == userId
                               select new SystemUser
                               {
                                   Id = u.Id,
                                   FirstName = u.FirstName,
                                   LastName = u.LastName,
                                   InternalEMailAddress = u.InternalEMailAddress,
                                   DomainName = u.DomainName,
                                   MobilePhone = u.MobilePhone,
                                   Address1_Telephone1 = u.Address1_Telephone1,
                                   ModifiedOn = u.ModifiedOn
                               }).FirstOrDefault();
            return user;
        }

        public SystemUser retrieveUserNameById(Guid userId)
        {
            SystemUser user = (from u in crmContext.SystemUserSet
                               where u.Id == userId
                               select new SystemUser
                               {
                                   Id = u.Id,
                                   FirstName = u.FirstName,
                                   LastName = u.LastName
                               }).FirstOrDefault();
            return user;
        }
    }
}