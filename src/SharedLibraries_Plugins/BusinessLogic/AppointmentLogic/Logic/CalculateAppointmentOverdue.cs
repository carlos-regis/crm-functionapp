using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.AppointmentLogic.Logic
{
    public class CalculateAppointmentOverdue
    {
        private readonly ITracingService tracingService;
        private Entity entity;
        private Entity preImage;
        private AccountRepos accountRepos;

        public CalculateAppointmentOverdue(ITracingService _tracingService, Entity _entity, Entity _preImage, AccountRepos _accountRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.accountRepos = _accountRepos;
        }
        public void CalculateAppointmentOverdue_Logic()
        {
            var accountId = entity.Contains(Appointment.Fields.RegardingObjectId) ?
                            entity.GetAttributeValue<EntityReference>(Appointment.Fields.RegardingObjectId).Id :
                            preImage.GetAttributeValue<EntityReference>(Appointment.Fields.RegardingObjectId).Id;

            var retrievedAccount = accountRepos.retrieveAccountById_Appointment(accountId);

            if (retrievedAccount != null)
            {
                OptionSetValue currentOverdue = retrievedAccount.GetAttributeValue<OptionSetValue>(Account.Fields.rbtt_AppointmentOverdue) != null ?
                                                retrievedAccount.GetAttributeValue<OptionSetValue>(Account.Fields.rbtt_AppointmentOverdue) :
                                                new OptionSetValue(0);

                OptionSetValue newOverdue = new OptionSetValue(0);

                DateTime nextAppointment = retrievedAccount.Attributes.Contains(Account.Fields.Orb_nextappointment) ?
                                           retrievedAccount.GetAttributeValue<DateTime>(Account.Fields.Orb_nextappointment) :
                                           retrievedAccount.GetAttributeValue<DateTime>(Account.Fields.CreatedOn);

                DateTime today = DateTime.Today;
                DateTime olderthan30 = today.AddDays(-30);

                int compareTodayResult = DateTime.Compare(nextAppointment, today);
                int compareOlderResult = DateTime.Compare(nextAppointment, olderthan30);

                if (compareTodayResult >= 0)
                {
                    newOverdue.Value = (int)Account_rbtt_AppointmentOverdue.No;
                }
                else
                {
                    if (compareOlderResult >= 0)
                        newOverdue.Value = (int)Account_rbtt_AppointmentOverdue._30days_173140001;
                    if (compareOlderResult < 0)
                        newOverdue.Value = (int)Account_rbtt_AppointmentOverdue._30days_173140002;
                }

                if (!newOverdue.Equals(currentOverdue))
                {
                    retrievedAccount.Attributes[Account.Fields.rbtt_AppointmentOverdue] = newOverdue;
                }

                accountRepos.updateAccount(retrievedAccount);
            }
        }
    }
}
