using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.Repos.AutoNumber;

namespace SharedLibraries_Plugins.BusinessLogic.CommonLogic
{
    public class AutoNrGenerator
    {
        #region Variables

        private ITracingService tracingService;
        private Entity entity;
        private AutoNumberRepos autoNumberRepos;

        #endregion Variables

        #region Constructor

        public AutoNrGenerator(ITracingService _tracingService, Entity _entity, AutoNumberRepos _autoNumberRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.autoNumberRepos = _autoNumberRepos;
        }

        #endregion

        #region Logic

        public void AutoNrGenerator_Logic()
        {
            tracingService.Trace("Starting AutoNrGenerator_Logic.");

            var retrievedAutoNumberCounter = autoNumberRepos.retrieveAutoNumberByEntityLogicalName(entity.LogicalName);

            if (retrievedAutoNumberCounter != null)
            {
                retrievedAutoNumberCounter.alegri_Counterposition = retrievedAutoNumberCounter.alegri_Counterposition.Value + 1;

                autoNumberRepos.updateAutoNumberCounter(retrievedAutoNumberCounter);

                var prefix = retrievedAutoNumberCounter.alegri_Prefix;
                var counterPosition = retrievedAutoNumberCounter.alegri_Counterposition.Value.ToString("D" + retrievedAutoNumberCounter.alegri_DigitLength);
                var suffix = retrievedAutoNumberCounter.alegri_Suffix != null ? retrievedAutoNumberCounter.alegri_Suffix : "";
                var fieldName = retrievedAutoNumberCounter.alegri_FieldLogicalName;

                entity.Attributes[fieldName] = prefix + counterPosition + suffix;
            }

            tracingService.Trace("Ending AutoNrGenerator_Logic.");
        }

        #endregion
    }
}
