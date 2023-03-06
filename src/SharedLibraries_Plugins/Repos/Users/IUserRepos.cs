using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Users
{
    public interface IUserRepos
    {
        SystemUser retrieveEnableUserById(Guid userId);
        SystemUser retrieveUserById(Guid userId);
        SystemUser retrieveUserNameById(Guid userId);
        SystemUser retrieveUserByEmail(string emailAddress);
        SystemUser retrieveUserByDomainName(string domainName);
        List<SystemUser> retrieveMultipleUsers();
    }
}
