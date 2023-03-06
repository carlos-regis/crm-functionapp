using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.BusinessLogic.ContactLogic.Filter;
using SharedLibraries_Plugins.BusinessLogic.ContactLogic.Logic;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.Accounts;
using SharedLibraries_Plugins.Repos.Contacts;
using SharedLibraries_Plugins.Repos.Countries;

namespace SharedLibraries_Plugins.BusinessLogic.ContactLogic.Events.PostOperation
{
    public class PostOperationContactLogicAsync
    {
        #region Variables
        private ITracingService tracingService;
        private readonly Entity entity;
        private readonly Entity preImage;
        private readonly CrmContext crmContext;
        private readonly ContactFilter cf = new ContactFilter();
        #endregion

        #region Constructor
        public PostOperationContactLogicAsync(ITracingService _tracingService, Entity _entity, 
                                                Entity _preImage, CrmContext _crmContext)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.preImage = _preImage;
            this.crmContext = _crmContext;
        }
        #endregion

        #region Execute
        public void ValidateAndExecute()
        {
            try
            {
                if (cf.ValidatePhonePrefix(entity))
                {
                    Contact contactToUpdate = new Contact();
                    contactToUpdate.Id = entity.Id;

                    CountryRepos countryRepos = new CountryRepos(crmContext);
                    ContactRepos contactRepos = new ContactRepos(crmContext);

                    PhonePrefix pp = new PhonePrefix(tracingService, entity, preImage, contactToUpdate, countryRepos);
                    contactToUpdate = pp.PhonePrefix_Logic();
                    contactRepos.updateContact(contactToUpdate);
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
        #endregion
    }
}
