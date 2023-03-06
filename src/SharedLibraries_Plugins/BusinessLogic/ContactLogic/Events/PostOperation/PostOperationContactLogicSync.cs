using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.ContactLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Consents;
using SharedLibraries_Plugins.Repos.Contacts;
using SharedLibraries_Plugins.Repos.Countries;
using SharedLibraries_Plugins.Repos.Users;

namespace SharedLibraries_Plugins.BusinessLogic.ContactLogic.Events.PostOperation
{
    public class PostOperationContactLogicSync
    {
        #region Variables
        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity postImage;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;
        private IOrganizationService service;
        #endregion

        #region Constructor
        public PostOperationContactLogicSync(ITracingService _tracingService, Entity _entity, Entity _postImage,
                                         Entity _preImage, CrmContext _crmContext, IOrganizationService _service)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.postImage = _postImage;
            this.preImage = _preImage;
            this.crmContext = _crmContext;
            this.service = _service;
        }
        #endregion

        #region Execute
        public void ValidateAndExecute()
        {
            try
            {
                if ((entity.Attributes.Contains(Contact.Fields.EMailAddress1) && entity.GetAttributeValue<string>(Contact.Fields.EMailAddress1) != string.Empty) &&
                    postImage.Attributes.Contains(Contact.Fields.rbtt_CountryId))
                {
                    CountryRepos countryRepos = new CountryRepos(crmContext);
                    ContactRepos contactRepos = new ContactRepos(crmContext);
                    ConsentRepos consentRepos = new ConsentRepos(crmContext);
                    UserRepos userRepos = new UserRepos(crmContext);

                    RequestCustomerConsent rcc = new RequestCustomerConsent(tracingService, preImage, postImage, countryRepos,
                                                                            contactRepos, consentRepos, userRepos, service);
                    rcc.RequestCustomerConsent_Logic();

                    tracingService.Trace("PostOperationContactLogicSync.ValidateAndExecute --> Successfully");
                }
            }
            catch (InvalidPluginExecutionException ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
        }
        #endregion
    }
}
