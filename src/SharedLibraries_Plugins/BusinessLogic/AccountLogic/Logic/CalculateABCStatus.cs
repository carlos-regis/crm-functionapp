using Microsoft.Xrm.Sdk;
using SharedLibraries_Plugins.EntityModel;
using SharedLibraries_Plugins.Repos.ClassificationBases;
using System;

namespace SharedLibraries_Plugins.BusinessLogic.AccountLogic.Logic
{
    public class CalculateABCStatus
    {
        #region Variables

        private ITracingService tracingService;
        private Entity entity;
        private Entity entityToUpdate;
        private Entity preImage;
        private ClassificationBaseRepos classificationBaseRepos;

        #endregion Variables

        #region Constructor
        public CalculateABCStatus(ITracingService _tracingService, Entity _entity, Entity _entityToUpdate, Entity _preImage, ClassificationBaseRepos _classificationBaseRepos)
        {
            this.tracingService = _tracingService;
            this.entity = _entity;
            this.entityToUpdate = _entityToUpdate;
            this.preImage = _preImage;
            this.classificationBaseRepos = _classificationBaseRepos;
        }
        #endregion

        #region Logic

        public Account CalculateABCStatus_Logic()
        {
            tracingService.Trace("CalculateABCStatus_Logic --> Started");

            Guid classificationBaseId = entity.GetAttributeValue<EntityReference>(Account.Fields.orb_classificationbaseid) != null ?
                                            entity.GetAttributeValue<EntityReference>(Account.Fields.orb_classificationbaseid).Id :
                                            preImage.GetAttributeValue<EntityReference>(Account.Fields.orb_classificationbaseid).Id;

            Orb_classificationbase retrievedClassificationBase = classificationBaseRepos.retrieveClassificationBaseById(classificationBaseId);

            if (retrievedClassificationBase != null)
            {
                ClassifyABCStatus(retrievedClassificationBase);
            }

            tracingService.Trace("CalculateABCStatus_Logic --> Ended");

            return (Account)entityToUpdate;
        }

        #endregion

        #region Private Methods

        private void ClassifyABCStatus(Orb_classificationbase retrievedClassificationBase)
        {
            tracingService.Trace("ClassifyABCStatus --> Started");

            double totalPotential = entity.Attributes.Contains(Account.Fields.Btt_Totalpotential) ?
                                        (double)entity.GetAttributeValue<Money>(Account.Fields.Btt_Totalpotential).Value :
                                        preImage != null ?
                                            preImage.GetAttributeValue<Money>(Account.Fields.Btt_Totalpotential) != null ?
                                                (double)preImage.GetAttributeValue<Money>(Account.Fields.Btt_Totalpotential).Value :
                                                0.0 :
                                        0.0;

            double turnover = entity.Attributes.Contains(Account.Fields.Btt_TT_Turnover) ?
                                        (double)entity.GetAttributeValue<Money>(Account.Fields.Btt_TT_Turnover).Value :
                                        preImage != null ?
                                            preImage.GetAttributeValue<Money>(Account.Fields.Btt_TT_Turnover) != null ?
                                                (double)preImage.GetAttributeValue<Money>(Account.Fields.Btt_TT_Turnover).Value :
                                                0.0 :
                                        0.0;

            var borderX3X2 = retrievedClassificationBase.GetAttributeValue<double>(Orb_classificationbase.Fields.Orb_potentialb);
            var borderX2X1 = retrievedClassificationBase.GetAttributeValue<double>(Orb_classificationbase.Fields.Orb_potentialA);
            var borderCD = retrievedClassificationBase.GetAttributeValue<double>(Orb_classificationbase.Fields.rbtt_useofpotential3);
            var borderBC = retrievedClassificationBase.GetAttributeValue<double>(Orb_classificationbase.Fields.Orb_useofpotential2);
            var borderAB = retrievedClassificationBase.GetAttributeValue<double>(Orb_classificationbase.Fields.Orb_useofpotential1);

            double ttShare = turnover / totalPotential;
            string prefix = "Z";
            string suffix = "9";

            if (totalPotential != 0)
            {
                if (totalPotential <= borderX3X2)
                {
                    suffix = "3";
                }
                else if (totalPotential > borderX3X2 && totalPotential <= borderX2X1)
                {
                    suffix = "2";
                }
                else if (totalPotential > borderX2X1)
                {
                    suffix = "1";
                }

                if (ttShare <= borderCD)
                {
                    prefix = "D";
                }
                else if (ttShare > borderCD && ttShare <= borderBC)
                {
                    prefix = "C";
                }
                else if (ttShare > borderBC && ttShare <= borderAB)
                {
                    prefix = "B";
                }
                else if (ttShare > borderAB)
                {
                    prefix = "A";
                }
            }
            else
            {
                if (turnover > 0)
                {
                    prefix = "Z";
                    suffix = "Z";
                }

                ttShare = 0.0;
            }

            entityToUpdate.Attributes[Account.Fields.Orb_classification] = string.Concat(prefix, suffix);
            entityToUpdate.Attributes[Account.Fields.Btt_TTShare] = ttShare;

            tracingService.Trace("ClassifyABCStatus --> Ended");
        }

        #endregion
    }
}