using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Appointments
{
    public class AppointmentRepos : IAppointmentRepos
    {
        private CrmContext crmContext;

        public AppointmentRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void creatAppointment(Appointment appliance)
        {
            crmContext.AddObject(appliance);
            crmContext.SaveChanges();
        }

        public Appointment retrieveAppointmentById(Guid id)
        {
            Appointment appointment = (from a in crmContext.AppointmentSet
                                       where a.Id == id
                                       select new Appointment
                                       {
                                           Id = a.Id,
                                           ScheduledEnd = a.ScheduledEnd,
                                           ScheduledStart = a.ScheduledStart,
                                           ScheduledDurationMinutes = a.ScheduledDurationMinutes
                                       }).FirstOrDefault();
            return appointment;
        }

        public Appointment retrieveAppointmentByRegardingObject(Guid regardingObjectId)
        {
            Appointment appointment = (from a in crmContext.AppointmentSet
                                       where a.RegardingObjectId.Id == regardingObjectId
                                       where a.StateCode == AppointmentState.Completed
                                       orderby a.ScheduledEnd descending
                                       select new Appointment
                                       {
                                           Id = a.Id,
                                           ScheduledEnd = a.ScheduledEnd
                                       }).FirstOrDefault();
            return appointment;
        }

        public List<Appointment> retrieveMultipleAppointments()
        {
            List<Appointment> appointmentList = (from a in crmContext.AppointmentSet
                                                 select new Appointment
                                                 {
                                                     Id = a.Id,
                                                     ScheduledEnd = a.ScheduledEnd,
                                                     ScheduledStart = a.ScheduledStart,
                                                     ScheduledDurationMinutes = a.ScheduledDurationMinutes
                                                 }).ToList();
            return appointmentList;
        }

        public void updateAppointment(Appointment appliance)
        {
            if (!crmContext.IsAttached(appliance))
            {
                crmContext.Attach(appliance);
            }
            crmContext.UpdateObject(appliance);
            crmContext.SaveChanges();
        }
    }
}
