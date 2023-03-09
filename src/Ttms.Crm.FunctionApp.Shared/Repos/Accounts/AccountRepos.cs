using System;
using System.Collections.Generic;
using System.Linq;
using Ttms.Crm.FunctionApp.Shared.EntityModel;

namespace Ttms.Crm.FunctionApp.Shared.Repos.Accounts
{
    public class AccountRepos : IAccountRepos
    {
        private readonly CrmContext crmContext;

        public AccountRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createAccount(Account account)
        {
            crmContext.AddObject(account);
            crmContext.SaveChanges();
        }

        public Account retrieveAccountByEmail(string emailAddress)
        {
            Account account = (from a in crmContext.AccountSet
                               where a.EMailAddress1 == emailAddress
                               select new Account
                               {
                                   Id = a.Id,
                                   rbtt_ERPCustomerNumber = a.rbtt_ERPCustomerNumber,
                                   Name = a.Name,
                                   EMailAddress1 = a.EMailAddress1,
                                   Address1_PostalCode = a.Address1_PostalCode,
                                   Orb_vatnumber = a.Orb_vatnumber,
                                   OwnerId = a.OwnerId,
                                   ModifiedOn = a.ModifiedOn,
                                   StatusCode = a.StatusCode
                               }).FirstOrDefault();
            return account;
        }

        public Account retrieveAccountByERP(string erpNumber)
        {
            Account account = (from a in crmContext.AccountSet
                               where a.rbtt_ERPCustomerNumber == erpNumber
                               select new Account
                               {
                                   Id = a.Id,
                                   rbtt_ERPCustomerNumber = a.rbtt_ERPCustomerNumber,
                                   Name = a.Name,
                                   EMailAddress1 = a.EMailAddress1,
                                   Address1_PostalCode = a.Address1_PostalCode,
                                   Orb_vatnumber = a.Orb_vatnumber,
                                   OwnerId = a.OwnerId,
                                   ModifiedOn = a.ModifiedOn,
                                   StatusCode = a.StatusCode
                               }).FirstOrDefault();
            return account;
        }

        public Account retrieveAccountById(Guid accountId)
        {
            Account account = (from a in crmContext.AccountSet
                               where a.Id == accountId
                               select new Account
                               {
                                   Id = a.Id,
                                   rbtt_ERPCustomerNumber = a.rbtt_ERPCustomerNumber,
                                   Name = a.Name,
                                   EMailAddress1 = a.EMailAddress1,
                                   Address1_PostalCode = a.Address1_PostalCode,
                                   Orb_vatnumber = a.Orb_vatnumber,
                                   OwnerId = a.OwnerId,
                                   ModifiedOn = a.ModifiedOn,
                                   StatusCode = a.StatusCode,
                                   StateCode = a.StateCode,
                                   Orb_nextappointment = a.Orb_nextappointment,
                                   rbtt_GratuitiesTotalY1 = a.rbtt_GratuitiesTotalY1,
                                   rbtt_GratuitiesTotalYTD = a.rbtt_GratuitiesTotalYTD,
                                   rbtt_NoofRegistrationsY1 = a.rbtt_NoofRegistrationsY1,
                                   rbtt_NoofRegistrationsY2 = a.rbtt_NoofRegistrationsY2,
                                   rbtt_NoofRegistrationsYTD = a.rbtt_NoofRegistrationsYTD,
                                   btt_visitscompletedprimaryresp = a.btt_visitscompletedprimaryresp,
                                   btt_visitscompletedindustryresp = a.btt_visitscompletedindustryresp,
                                   Orb_visitcountplanned = a.Orb_visitcountplanned,
                                   Orb_visitcountactual = a.Orb_visitcountactual,
                                   btt_industryresponsibleid = a.btt_industryresponsibleid
                               }).FirstOrDefault();
            return account;
        }

        public Account retrieveAccountById_Appointment(Guid accountId)
        {
            Account account = (from a in crmContext.AccountSet
                               where a.Id == accountId
                               select new Account
                               {
                                   Id = a.Id,
                                   rbtt_AppointmentOverdue = a.rbtt_AppointmentOverdue,
                                   Orb_nextappointment = a.Orb_nextappointment
                               }).FirstOrDefault();
            return account;
        }

        public Account retrieveAccountById_Gratuities(Guid accountId)
        {
            Account account = (from a in crmContext.AccountSet
                               where a.Id == accountId
                               select new Account
                               {
                                   Id = a.Id,
                                   rbtt_GratuitiesTotalYTD = a.rbtt_GratuitiesTotalYTD,
                                   rbtt_GratuitiesTotalY1 = a.rbtt_GratuitiesTotalY1
                               }).FirstOrDefault();
            return account;
        }

        public Account retrieveAccountById_ProductRegistration(Guid accountId)
        {
            Account account = (from a in crmContext.AccountSet
                               where a.Id == accountId
                               select new Account
                               {
                                   Id = a.Id,
                                   rbtt_NoofRegistrationsYTD = a.rbtt_NoofRegistrationsYTD,
                                   rbtt_NoofRegistrationsY1 = a.rbtt_NoofRegistrationsY1,
                                   rbtt_NoofRegistrationsY2 = a.rbtt_NoofRegistrationsY2,
                               }).FirstOrDefault();
            return account;
        }

        public List<Account> retrieveMultipleAccounts()
        {
            List<Account> accountList = (from a in crmContext.AccountSet
                                         select new Account
                                         {
                                             Id = a.Id,
                                             Name = a.Name,
                                             EMailAddress1 = a.EMailAddress1,
                                             Address1_PostalCode = a.Address1_PostalCode,
                                             rbtt_ERPCustomerNumber = a.rbtt_ERPCustomerNumber,
                                             Orb_vatnumber = a.Orb_vatnumber,
                                             OwnerId = a.OwnerId,
                                             ModifiedOn = a.ModifiedOn,
                                             StatusCode = a.StatusCode
                                         }).ToList();
            return accountList;
        }

        public void updateAccount(Account account)
        {
            if (!crmContext.IsAttached(account))
            {
                crmContext.Attach(account);
            }
            crmContext.UpdateObject(account);
            crmContext.SaveChanges();
        }
    }
}