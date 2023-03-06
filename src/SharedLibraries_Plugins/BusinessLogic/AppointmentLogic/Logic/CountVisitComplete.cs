using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.Appointments;
using SharedLibraries_Plugins.Repos.Contacts;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.AppointmentLogic.Logic
{
    public class CountVisitComplete
    {
        #region Variables

        private ITracingService tracingService;
        private Entity entity;
        private Entity preImage;
        private string direction;
        private CrmContext crmContext;

        #endregion Variables

        #region Constructor
        public CountVisitComplete(ITracingService _tracingService, Entity _entity, Entity _preImage, string _direction, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.direction = _direction;
            this.crmContext = _crmContext;
        }
        #endregion

        #region Logic

        public void CountVisitComplete_Logic()
        {
            tracingService.Trace("CountVisitComplete_Logic --> Started");

            EntityReference regardingObject = entity.Attributes.Contains(Appointment.Fields.RegardingObjectId) ?
                                                entity.GetAttributeValue<EntityReference>(Appointment.Fields.RegardingObjectId) :
                                                (EntityReference)preImage.Attributes[Appointment.Fields.RegardingObjectId];

            if (regardingObject.LogicalName.Equals(Account.EntityLogicalName))
            {
                CountAccountVisitComplete(regardingObject.Id);
            }
            else if (regardingObject.LogicalName.Equals(Contact.EntityLogicalName))
            {
                CountContactVisitComplete(regardingObject.Id);
            }

            tracingService.Trace("CountVisitComplete_Logic --> Ended");
        }

        #endregion

        #region Private Methods

        private void CountAccountVisitComplete(Guid accountId)
        {
            AccountRepos accountRepos = new AccountRepos(crmContext);
            Account retrievedAccount = accountRepos.retrieveAccountById(accountId);

            int counter = 0;
            int VCPR = 0;
            int VCIR = 0;
            DateTime Last_Complete = DateTime.Parse("01/01/1753");
            DateTime Next_Propose = DateTime.Parse("01/01/1753");

            if (retrievedAccount.Attributes.Contains(Account.Fields.Orb_visitcountactual))
            {
                if (direction.Equals(">"))
                    counter = (int)retrievedAccount.Attributes[Account.Fields.Orb_visitcountactual] + 1;
                else
                    counter = (int)retrievedAccount.Attributes[Account.Fields.Orb_visitcountactual] - 1;
            }
            else
            {
                if (direction.Equals(">")) ++counter;
                if (direction.Equals("<")) --counter;
            }

            if (retrievedAccount.Attributes.Contains(Account.Fields.OwnerId))
            {
                if (((EntityReference)retrievedAccount.Attributes[Account.Fields.OwnerId]).Id.Equals(((EntityReference)preImage.Attributes[Appointment.Fields.OwnerId]).Id))
                {
                    if (retrievedAccount.Attributes.Contains(Account.Fields.btt_visitscompletedprimaryresp))
                    {
                        if (direction.Equals(">"))
                            VCPR = (int)retrievedAccount.Attributes[Account.Fields.btt_visitscompletedprimaryresp] + 1;
                        if (direction.Equals("<"))
                            VCPR = (int)retrievedAccount.Attributes[Account.Fields.btt_visitscompletedprimaryresp] - 1;
                    }
                    else
                    {
                        if (direction.Equals(">"))
                            ++VCPR;
                        if (direction.Equals("<"))
                            --VCPR;
                    }
                }
            }
            if (retrievedAccount.Attributes.Contains(Account.Fields.btt_industryresponsibleid))
            {
                if (((EntityReference)retrievedAccount.Attributes[Account.Fields.btt_industryresponsibleid]).Id.Equals(((EntityReference)preImage.Attributes[Appointment.Fields.OwnerId]).Id))
                {
                    if (retrievedAccount.Attributes.Contains(Account.Fields.btt_visitscompletedindustryresp))
                    {
                        if (direction.Equals(">"))
                            VCIR = (int)retrievedAccount.Attributes[Account.Fields.btt_visitscompletedindustryresp] + 1;
                        if (direction.Equals("<"))
                            VCIR = (int)retrievedAccount.Attributes[Account.Fields.btt_visitscompletedindustryresp] - 1;
                    }
                    else
                    {
                        if (direction.Equals(">"))
                            ++VCIR;
                        if (direction.Equals("<"))
                            --VCIR;
                    }
                }
            }

            Last_Complete = LastCompletedAppointment(retrievedAccount.Id);

            if (retrievedAccount.Attributes.Contains(Account.Fields.Orb_visitcountplanned))
            {
                if ((int)retrievedAccount.Attributes[Account.Fields.Orb_visitcountplanned] > 0) Next_Propose = Last_Complete.AddDays(365 / (int)retrievedAccount.Attributes[Account.Fields.Orb_visitcountplanned]);
            }

            if (counter >= 0) retrievedAccount.Attributes[Account.Fields.Orb_visitcountactual] = counter;

            if (VCPR >= 0) retrievedAccount.Attributes[Account.Fields.btt_visitscompletedprimaryresp] = VCPR;

            if (VCIR >= 0) retrievedAccount.Attributes[Account.Fields.btt_visitscompletedindustryresp] = VCIR;

            if (retrievedAccount.Attributes.Contains(Account.Fields.Orb_lastscheduledappointment))
            {
                if (!DateTime.Compare((DateTime)retrievedAccount.Attributes[Account.Fields.Orb_lastscheduledappointment], Last_Complete).Equals(0))
                    retrievedAccount.Attributes[Account.Fields.Orb_lastscheduledappointment] = Last_Complete;
                else
                    if (DateTime.Compare(Last_Complete, DateTime.Parse("01/01/1753")).Equals(0))
                    retrievedAccount.Attributes[Account.Fields.Orb_lastscheduledappointment] = null;
            }
            else
            {
                if (DateTime.Compare(Last_Complete, DateTime.Parse("01/01/1753")).Equals(0))
                    retrievedAccount.Attributes[Account.Fields.Orb_lastscheduledappointment] = null;
                else
                    retrievedAccount.Attributes[Account.Fields.Orb_lastscheduledappointment] = Last_Complete;
            }

            if (retrievedAccount.Attributes.Contains(Account.Fields.Orb_nextappointment))
            {
                if (!DateTime.Compare((DateTime)retrievedAccount.Attributes[Account.Fields.Orb_nextappointment], Next_Propose).Equals(0))
                {
                    if (DateTime.Compare(Next_Propose, DateTime.Parse("01/01/1753")).Equals(0))
                        retrievedAccount.Attributes[Account.Fields.Orb_nextappointment] = null;
                    else
                        retrievedAccount.Attributes[Account.Fields.Orb_nextappointment] = Next_Propose;
                }
                else
                {
                    if (DateTime.Compare(Next_Propose, DateTime.Parse("01/01/1753")).Equals(0))
                        retrievedAccount.Attributes[Account.Fields.Orb_nextappointment] = null;
                }
            }
            else
            {
                if (DateTime.Compare(Next_Propose, DateTime.Parse("01/01/1753")).Equals(0))
                    retrievedAccount.Attributes[Account.Fields.Orb_nextappointment] = null;
                else
                    retrievedAccount.Attributes[Account.Fields.Orb_nextappointment] = Next_Propose;
            }

            accountRepos.updateAccount(retrievedAccount);
        }

        private void CountContactVisitComplete(Guid contactId)
        {
            ContactRepos contactRepos = new ContactRepos(crmContext);

            var retrievedContact = contactRepos.retrieveContactById(contactId);

            if (retrievedContact != null &&
               retrievedContact.Contains(Contact.Fields.ParentCustomerId))
            {
                CountAccountVisitComplete(retrievedContact.ParentCustomerId.Id);
            }
        }

        private DateTime LastCompletedAppointment(Guid accountId)
        {
            AppointmentRepos appointmentRepos = new AppointmentRepos(crmContext);

            DateTime when = DateTime.Parse("01/01/1753");

            var retrievedAppointment = appointmentRepos.retrieveAppointmentByRegardingObject(accountId);

            if (retrievedAppointment != null && retrievedAppointment.Contains(Appointment.Fields.ScheduledEnd))
                when = retrievedAppointment.GetAttributeValue<DateTime>(Appointment.Fields.ScheduledEnd);

            return when;
        }

        #endregion
    }
}
