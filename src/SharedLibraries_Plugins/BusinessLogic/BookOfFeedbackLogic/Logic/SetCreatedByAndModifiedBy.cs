using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Users;

namespace SharedLibraries_Plugins.BusinessLogic.BookOfFeedbackLogic.Logic
{
    public class SetCreatedByAndModifiedBy
    {
        #region Variables

        private ITracingService tracingService;
        private Entity entity;
        private UserRepos userRepos;

        #endregion Variables

        #region Constructor
        public SetCreatedByAndModifiedBy(ITracingService _tracingService, Entity _entity, UserRepos _userRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.userRepos = _userRepos;
        }
        #endregion

        #region Logic
        public rbtt_bookoffeedback SetCreatedByAndModifiedBy_Logic()
        {
            tracingService.Trace("SetCreatedByAndModifiedBy_Logic --> Started");

            var user = userRepos.retrieveUserByDomainName(@"DE\TTD1WE");

            entity.Attributes[rbtt_bookoffeedback.Fields.CreatedBy] = new EntityReference(SystemUser.EntityLogicalName, user.Id);
            entity.Attributes[rbtt_bookoffeedback.Fields.ModifiedBy] = new EntityReference(SystemUser.EntityLogicalName, user.Id);

            return (rbtt_bookoffeedback)entity;
        }

        #endregion
    }
}
