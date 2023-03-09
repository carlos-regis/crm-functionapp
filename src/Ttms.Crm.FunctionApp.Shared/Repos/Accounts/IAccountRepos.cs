using System;
using System.Collections.Generic;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.Shared.Repos.Accounts
{
    public interface IAccountRepos
    {
        Account retrieveAccountById(Guid accountId);
        Account retrieveAccountById_Appointment(Guid accountId);
        Account retrieveAccountById_Gratuities(Guid accountId);
        Account retrieveAccountById_ProductRegistration(Guid accountId);
        Account retrieveAccountByERP(string erpNumber);
        Account retrieveAccountByEmail(string emailAddress);
        List<Account> retrieveMultipleAccounts();
        void createAccount(Account account);
        void updateAccount(Account account);
    }
}
