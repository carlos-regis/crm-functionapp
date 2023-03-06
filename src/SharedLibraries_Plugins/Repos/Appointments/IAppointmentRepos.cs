using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Appointments
{
    public interface IAppointmentRepos
    {
        Appointment retrieveAppointmentByRegardingObject(Guid regardingObjectId);
        Appointment retrieveAppointmentById(Guid id);
        List<Appointment> retrieveMultipleAppointments();
        void creatAppointment(Appointment appliance);
        void updateAppointment(Appointment appliance);
    }
}
