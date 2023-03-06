using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.AppointmentLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.AppointmentLogic.Events.PostOperation
{
    public class PostOperationAppointmentLogicSync
    {
        #region Variables

        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;
        private readonly string direction;

        #endregion Variables

        #region Constructor
        public PostOperationAppointmentLogicSync(ITracingService _tracingService, Entity _entity, Entity _preImage, string _direction, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.direction = _direction;
            this.crmContext = _crmContext;
        }

        #endregion Constructor

        #region Execute

        public void ValidateAndExecute()
        {
            try
            {
                if ((preImage != null &&
                   (entity.Contains(Appointment.Fields.RegardingObjectId) || preImage.Attributes.Contains(Appointment.Fields.RegardingObjectId)) &&
                    preImage.Attributes.Contains(Appointment.Fields.ScheduledEnd)))
                {
                    var currentYear = DateTime.UtcNow.Year;
                    var scheduledEndYear = preImage.GetAttributeValue<DateTime>(Appointment.Fields.ScheduledEnd).Year;

                    if(currentYear == scheduledEndYear)
                    {
                        CountVisitComplete cvc = new CountVisitComplete(tracingService, entity, preImage, direction, crmContext);
                        cvc.CountVisitComplete_Logic();
                    }

                    AccountRepos accountRepos = new AccountRepos(crmContext);

                    CalculateAppointmentOverdue cao = new CalculateAppointmentOverdue(tracingService, entity, preImage, accountRepos);
                    cao.CalculateAppointmentOverdue_Logic();
                }
            }
            catch (InvalidPluginExecutionException Ex)
            {
                throw new InvalidPluginExecutionException("\n\nInvalidPluginExecutionException\n-----------------------------------------------\n" +
                                    "\nErro Message:\n" + Ex.Message.ToString() +
                                    "\nErrorCode:\n" + Ex.ErrorCode.ToString() +
                                    "\nData:\n" + Ex.Data.ToString() +
                                    "\nHResult:\n" + Ex.HResult.ToString() +
                                    "\nInnerException:\n" + Ex.InnerException.ToString() +
                                    "\nSource:\n" + Ex.Source.ToString() +
                                    "\nStatus:\n" + Ex.Status.ToString() +
                                    "\nStatus:\n" + Ex.Status.ToString() +
                                    "\nHelpLink:\n" + Ex.HelpLink.ToString() +
                                    "\n\n-----------------------------------------------\n\n");
            }
        }

        #endregion Execute
    }
}
