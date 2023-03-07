namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum OpportunityState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Won = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Lost = 2,
    }

    /// <summary>
    /// Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunity")]
    public partial class Opportunity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string AccountId = "accountid";
            public const string ActualCloseDate = "actualclosedate";
            public const string ActualValue = "actualvalue";
            public const string ActualValue_Base = "actualvalue_base";
            public const string BTT_Actualdate1stoffersent = "btt_actualdate1stoffersent";
            public const string BTT_ActualDateCertification = "btt_actualdatecertification";
            public const string BTT_ActualDateInstallation = "btt_actualdateinstallation";
            public const string BTT_ActualDateOrder = "btt_actualdateorder";
            public const string BTT_ActualNegotiationsEnd = "btt_actualnegotiationsend";
            public const string BTT_ActualPreparationEnd = "btt_actualpreparationend";
            public const string BTT_ActualRealisationEnd = "btt_actualrealisationend";
            public const string Btt_ActualTenderBiddingClose = "btt_actualtenderbiddingclose";
            public const string Btt_BSH = "btt_bsh";
            public const string Btt_buyingstartdate = "btt_buyingstartdate";
            public const string Btt_city = "btt_city";
            public const string Btt_Contractwith = "btt_contractwith";
            public const string Btt_country = "btt_country";
            public const string btt_countryregion = "btt_countryregion";
            public const string Btt_crossselling = "btt_crossselling";
            public const string Btt_Crosssellingnotes = "btt_crosssellingnotes";
            public const string Btt_deliverybatch1 = "btt_deliverybatch1";
            public const string Btt_Deliverybatch1Turnover = "btt_deliverybatch1turnover";
            public const string btt_deliverybatch1turnover_Base = "btt_deliverybatch1turnover_base";
            public const string Btt_Deliverybatch2 = "btt_deliverybatch2";
            public const string Btt_Deliverybatch2Turnover = "btt_deliverybatch2turnover";
            public const string btt_deliverybatch2turnover_Base = "btt_deliverybatch2turnover_base";
            public const string Btt_Deliverybatch3 = "btt_deliverybatch3";
            public const string Btt_Deliverybatch3Turnover = "btt_deliverybatch3turnover";
            public const string btt_deliverybatch3turnover_Base = "btt_deliverybatch3turnover_base";
            public const string Btt_involvedplannerId = "btt_involvedplannerid";
            public const string Btt_NextStep = "btt_nextstep";
            public const string btt_offercode = "btt_offercode";
            public const string Btt_onschedule = "btt_onschedule";
            public const string btt_OpportunityProductGroupId = "btt_opportunityproductgroupid";
            public const string Btt_Other = "btt_other";
            public const string btt_parentopportunityid = "btt_parentopportunityid";
            public const string BTT_Planneddate1stoffersent = "btt_planneddate1stoffersent";
            public const string BTT_PlannedDateCertification = "btt_planneddatecertification";
            public const string BTT_PlannedDateInstallation = "btt_planneddateinstallation";
            public const string BTT_PlannedDateOrder = "btt_planneddateorder";
            public const string Btt_PlannedDelivery = "btt_planneddelivery";
            public const string BTT_PlannedNegotiationsEnd = "btt_plannednegotiationsend";
            public const string BTT_PlannedPreparationEnd = "btt_plannedpreparationend";
            public const string BTT_PlannedRealisationEnd = "btt_plannedrealisationend";
            public const string Btt_Plannedtender = "btt_plannedtender";
            public const string btt_plannercontactid = "btt_plannercontactid";
            public const string Btt_PlannersCommission = "btt_plannerscommission";
            public const string btt_plannerscommission_Base = "btt_plannerscommission_base";
            public const string Btt_Plannersshare = "btt_plannersshare";
            public const string Btt_postalcode = "btt_postalcode";
            public const string Btt_Productdescription = "btt_productdescription";
            public const string btt_ProductGroup2 = "btt_productgroup2";
            public const string btt_ProductGroup3 = "btt_productgroup3";
            public const string Btt_Productionlocation = "btt_productionlocation";
            public const string Btt_productnr = "btt_productnr";
            public const string Btt_projectclassification = "btt_projectclassification";
            public const string Btt_projectnumber = "btt_projectnumber";
            public const string Btt_projectstartdate = "btt_projectstartdate";
            public const string Btt_projecttype1 = "btt_projecttype1";
            public const string Btt_projecttype2 = "btt_projecttype2";
            public const string Btt_ProvinceId = "btt_provinceid";
            public const string Btt_PT = "btt_pt";
            public const string Btt_region = "btt_region";
            public const string Btt_SalesModel = "btt_salesmodel";
            public const string btt_salesstages = "btt_salesstages";
            public const string Btt_specialdiscounts = "btt_specialdiscounts";
            public const string Btt_ST = "btt_st";
            public const string Btt_street = "btt_street";
            public const string Btt_Tonnage = "btt_tonnage";
            public const string Btt_trigger_price = "btt_trigger_price";
            public const string Btt_trigger_product = "btt_trigger_product";
            public const string Btt_trigger_relationship = "btt_trigger_relationship";
            public const string Btt_trigger_service = "btt_trigger_service";
            public const string BTT_trigger_TechnicalSupport = "btt_trigger_technicalsupport";
            public const string Btt_TypeofproductId = "btt_typeofproductid";
            public const string btt_xsell1 = "btt_xsell1";
            public const string btt_xsell2 = "btt_xsell2";
            public const string btt_xsell3 = "btt_xsell3";
            public const string btt_xsell4 = "btt_xsell4";
            public const string BudgetAmount = "budgetamount";
            public const string BudgetAmount_Base = "budgetamount_base";
            public const string BudgetStatus = "budgetstatus";
            public const string CampaignId = "campaignid";
            public const string CaptureProposalFeedback = "captureproposalfeedback";
            public const string CloseProbability = "closeprobability";
            public const string CompleteFinalProposal = "completefinalproposal";
            public const string CompleteInternalReview = "completeinternalreview";
            public const string ConfirmInterest = "confirminterest";
            public const string ContactId = "contactid";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CurrentSituation = "currentsituation";
            public const string CustomerId = "customerid";
            public const string CustomerNeed = "customerneed";
            public const string CustomerPainPoints = "customerpainpoints";
            public const string DecisionMaker = "decisionmaker";
            public const string Description = "description";
            public const string DevelopProposal = "developproposal";
            public const string DiscountAmount = "discountamount";
            public const string DiscountAmount_Base = "discountamount_base";
            public const string DiscountPercentage = "discountpercentage";
            public const string EmailAddress = "emailaddress";
            public const string EstimatedCloseDate = "estimatedclosedate";
            public const string EstimatedValue = "estimatedvalue";
            public const string EstimatedValue_Base = "estimatedvalue_base";
            public const string EvaluateFit = "evaluatefit";
            public const string ExchangeRate = "exchangerate";
            public const string FileDebrief = "filedebrief";
            public const string FinalDecisionDate = "finaldecisiondate";
            public const string FreightAmount = "freightamount";
            public const string FreightAmount_Base = "freightamount_base";
            public const string IdentifyCompetitors = "identifycompetitors";
            public const string IdentifyCustomerContacts = "identifycustomercontacts";
            public const string IdentifyPursuitTeam = "identifypursuitteam";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string InitialCommunication = "initialcommunication";
            public const string IsRevenueSystemCalculated = "isrevenuesystemcalculated";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Name = "name";
            public const string Need = "need";
            public const string new_commercial = "new_commercial";
            public const string new_industrial = "new_industrial";
            public const string new_residential = "new_residential";
            public const string OnHoldTime = "onholdtime";
            public const string OpportunityId = "opportunityid";
            public const string Id = "opportunityid";
            public const string OpportunityRatingCode = "opportunityratingcode";
            public const string OriginatingLeadId = "originatingleadid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string ParentAccountId = "parentaccountid";
            public const string ParentContactId = "parentcontactid";
            public const string ParticipatesInWorkflow = "participatesinworkflow";
            public const string PresentFinalProposal = "presentfinalproposal";
            public const string PresentProposal = "presentproposal";
            public const string PriceLevelId = "pricelevelid";
            public const string PricingErrorCode = "pricingerrorcode";
            public const string PriorityCode = "prioritycode";
            public const string ProcessId = "processid";
            public const string ProposedSolution = "proposedsolution";
            public const string PurchaseProcess = "purchaseprocess";
            public const string PurchaseTimeframe = "purchasetimeframe";
            public const string PursuitDecision = "pursuitdecision";
            public const string QualificationComments = "qualificationcomments";
            public const string QuoteComments = "quotecomments";
            public const string rbtt_ALid = "rbtt_alid";
            public const string rbtt_Application = "rbtt_application";
            public const string rbtt_BranchOffice = "rbtt_branchoffice";
            public const string rbtt_BusinessSegment = "rbtt_businesssegment";
            public const string rbtt_ConfigurationCountryId = "rbtt_configurationcountryid";
            public const string rbtt_EstimatedValueCurrentFX = "rbtt_estimatedvaluecurrentfx";
            public const string rbtt_ExternalReference = "rbtt_externalreference";
            public const string rbtt_GA = "rbtt_ga";
            public const string rbtt_HouseNumber = "rbtt_housenumber";
            public const string rbtt_IndustryReference = "rbtt_industryreference";
            public const string rbtt_IsLPKProject = "rbtt_islpkproject";
            public const string rbtt_KD = "rbtt_kd";
            public const string rbtt_Line2 = "rbtt_line2";
            public const string rbtt_Line3 = "rbtt_line3";
            public const string rbtt_LpkOrganization = "rbtt_lpkorganization";
            public const string rbtt_LPKProjektID = "rbtt_lpkprojektid";
            public const string rbtt_Mandator = "rbtt_mandator";
            public const string rbtt_OpportunityCountry = "rbtt_opportunitycountry";
            public const string rbtt_OrderingCustomer = "rbtt_orderingcustomer";
            public const string rbtt_PlantLocationId = "rbtt_plantlocationid";
            public const string rbtt_ProductGroup1Qty = "rbtt_productgroup1qty";
            public const string rbtt_ProductGroup2Qty = "rbtt_productgroup2qty";
            public const string rbtt_ProductGroup3Qty = "rbtt_productgroup3qty";
            public const string rbtt_ProjectName = "rbtt_projectname";
            public const string rbtt_ProjectPhase = "rbtt_projectphase";
            public const string rbtt_ProjectType = "rbtt_projecttype";
            public const string rbtt_ProjectTypeId = "rbtt_projecttypeid";
            public const string rbtt_ProjectTypesValue = "rbtt_projecttypesvalue";
            public const string rbtt_Province = "rbtt_province";
            public const string rbtt_QuotetoOpportunityId = "rbtt_quotetoopportunityid";
            public const string rbtt_ReferenceSystemId = "rbtt_referencesystemid";
            public const string rbtt_REid = "rbtt_reid";
            public const string rbtt_ResidentialBuildingType = "rbtt_residentialbuildingtype";
            public const string rbtt_RGid = "rbtt_rgid";
            public const string rbtt_SalesChannel = "rbtt_saleschannel";
            public const string rbtt_SalesOrganization = "rbtt_salesorganization";
            public const string rbtt_SalesOrganizationsValue = "rbtt_salesorganizationsvalue";
            public const string rbtt_SAPDocumentID = "rbtt_sapdocumentid";
            public const string rbtt_SARegion = "rbtt_saregion";
            public const string rbtt_ScoringChance = "rbtt_scoringchance";
            public const string rbtt_SerialNumber = "rbtt_serialnumber";
            public const string rbtt_Sparte = "rbtt_sparte";
            public const string rbtt_SpecifiedbyEAP = "rbtt_specifiedbyeap";
            public const string rbtt_TechnicalSupport = "rbtt_technicalsupport";
            public const string rbtt_TTinspecification = "rbtt_ttinspecification";
            public const string rbtt_VE = "rbtt_ve";
            public const string rbtt_Verkufergruppe = "rbtt_verkufergruppe";
            public const string rbtt_Vertriebsweg = "rbtt_vertriebsweg";
            public const string rbtt_VKORG = "rbtt_vkorg";
            public const string rbtt_WEid = "rbtt_weid";
            public const string rbtt_WeightedTurnover = "rbtt_weightedturnover";
            public const string rbtt_weightedturnover_Base = "rbtt_weightedturnover_base";
            public const string ResolveFeedback = "resolvefeedback";
            public const string SalesStage = "salesstage";
            public const string SalesStageCode = "salesstagecode";
            public const string ScheduleFollowup_Prospect = "schedulefollowup_prospect";
            public const string ScheduleFollowup_Qualify = "schedulefollowup_qualify";
            public const string ScheduleProposalMeeting = "scheduleproposalmeeting";
            public const string SendThankYouNote = "sendthankyounote";
            public const string SkipPriceCalculation = "skippricecalculation";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string StepId = "stepid";
            public const string StepName = "stepname";
            public const string TeamsFollowed = "teamsfollowed";
            public const string TimeLine = "timeline";
            public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TotalAmount = "totalamount";
            public const string TotalAmount_Base = "totalamount_base";
            public const string TotalAmountLessFreight = "totalamountlessfreight";
            public const string TotalAmountLessFreight_Base = "totalamountlessfreight_base";
            public const string TotalDiscountAmount = "totaldiscountamount";
            public const string TotalDiscountAmount_Base = "totaldiscountamount_base";
            public const string TotalLineItemAmount = "totallineitemamount";
            public const string TotalLineItemAmount_Base = "totallineitemamount_base";
            public const string TotalLineItemDiscountAmount = "totallineitemdiscountamount";
            public const string TotalLineItemDiscountAmount_Base = "totallineitemdiscountamount_base";
            public const string TotalTax = "totaltax";
            public const string TotalTax_Base = "totaltax_base";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string btt_accountplanner_opportunity = "btt_accountplanner_opportunity";
            public const string btt_contactplanner_opportunity = "btt_contactplanner_opportunity";
            public const string Referencingbtt_opportunity_opportunity = "btt_opportunity_opportunity";
            public const string btt_orb_country_opportunity_countryregion = "btt_orb_country_opportunity_countryregion";
            public const string btt_orb_productgroup_opportunity = "btt_orb_productgroup_opportunity";
            public const string btt_productgroup_opportunity_ProductGroup2 = "btt_productgroup_opportunity_ProductGroup2";
            public const string btt_productgroup_opportunity_ProductGroup3 = "btt_productgroup_opportunity_ProductGroup3";
            public const string lk_opportunity_createdonbehalfby = "lk_opportunity_createdonbehalfby";
            public const string lk_opportunity_modifiedonbehalfby = "lk_opportunity_modifiedonbehalfby";
            public const string lk_opportunitybase_createdby = "lk_opportunitybase_createdby";
            public const string lk_opportunitybase_modifiedby = "lk_opportunitybase_modifiedby";
            public const string opportunity_customer_accounts = "opportunity_customer_accounts";
            public const string opportunity_customer_contacts = "opportunity_customer_contacts";
            public const string opportunity_owning_user = "opportunity_owning_user";
            public const string opportunity_parent_account = "opportunity_parent_account";
            public const string opportunity_parent_contact = "opportunity_parent_contact";
            public const string rbtt_account_opportunity_SalesOrganization = "rbtt_account_opportunity_SalesOrganization";
            public const string rbtt_orb_country_opportunity_ALid = "rbtt_orb_country_opportunity_ALid";
            public const string rbtt_orb_country_opportunity_ConfigurationCountryId = "rbtt_orb_country_opportunity_ConfigurationCountryId";
            public const string rbtt_orb_country_opportunity_OpportunityCountry = "rbtt_orb_country_opportunity_OpportunityCountry";
            public const string rbtt_orb_machine_opportunity_PlantLocationId = "rbtt_orb_machine_opportunity_PlantLocationId";
            public const string rbtt_quote_opportunity = "rbtt_quote_opportunity";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Opportunity() :
                base(EntityLogicalName)
        {
        }

        public const string AlternateKeys = "btt_projectnumber";

        public const string EntityLogicalName = "opportunity";

        public const string EntitySchemaName = "Opportunity";

        public const string PrimaryIdAttribute = "opportunityid";

        public const string PrimaryNameAttribute = "name";

        public const string EntityLogicalCollectionName = "opportunities";

        public const string EntitySetName = "opportunities";

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Unique identifier of the account with which the opportunity is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
            }
        }

        /// <summary>
        /// Date when the opportunity was closed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualclosedate")]
        public System.Nullable<System.DateTime> ActualCloseDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualclosedate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActualCloseDate");
                this.SetAttributeValue("actualclosedate", value);
                this.OnPropertyChanged("ActualCloseDate");
            }
        }

        /// <summary>
        /// Actual revenue for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue")]
        public Microsoft.Xrm.Sdk.Money ActualValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActualValue");
                this.SetAttributeValue("actualvalue", value);
                this.OnPropertyChanged("ActualValue");
            }
        }

        /// <summary>
        /// Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue_base")]
        public Microsoft.Xrm.Sdk.Money ActualValue_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue_base");
            }
        }

        /// <summary>
        /// This is the due date until which we need to support the installer so he participate in the tender.
        ///Usually it includes hydraulic schemes and electrical schemes as well.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualdate1stoffersent")]
        public System.Nullable<System.DateTime> BTT_Actualdate1stoffersent
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualdate1stoffersent");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_Actualdate1stoffersent");
                this.SetAttributeValue("btt_actualdate1stoffersent", value);
                this.OnPropertyChanged("BTT_Actualdate1stoffersent");
            }
        }

        /// <summary>
        /// Actual Date Certification
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualdatecertification")]
        public System.Nullable<System.DateTime> BTT_ActualDateCertification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualdatecertification");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_ActualDateCertification");
                this.SetAttributeValue("btt_actualdatecertification", value);
                this.OnPropertyChanged("BTT_ActualDateCertification");
            }
        }

        /// <summary>
        /// Actual Date Installation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualdateinstallation")]
        public System.Nullable<System.DateTime> BTT_ActualDateInstallation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualdateinstallation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_ActualDateInstallation");
                this.SetAttributeValue("btt_actualdateinstallation", value);
                this.OnPropertyChanged("BTT_ActualDateInstallation");
            }
        }

        /// <summary>
        /// Completion of construction
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualdateorder")]
        public System.Nullable<System.DateTime> BTT_ActualDateOrder
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualdateorder");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_ActualDateOrder");
                this.SetAttributeValue("btt_actualdateorder", value);
                this.OnPropertyChanged("BTT_ActualDateOrder");
            }
        }

        /// <summary>
        /// Actual Negotiations End
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualnegotiationsend")]
        public System.Nullable<System.DateTime> BTT_ActualNegotiationsEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualnegotiationsend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_ActualNegotiationsEnd");
                this.SetAttributeValue("btt_actualnegotiationsend", value);
                this.OnPropertyChanged("BTT_ActualNegotiationsEnd");
            }
        }

        /// <summary>
        /// This is the due date until which we need to support the planner so he can create a tender.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualpreparationend")]
        public System.Nullable<System.DateTime> BTT_ActualPreparationEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualpreparationend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_ActualPreparationEnd");
                this.SetAttributeValue("btt_actualpreparationend", value);
                this.OnPropertyChanged("BTT_ActualPreparationEnd");
            }
        }

        /// <summary>
        /// Actual Realisation End
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualrealisationend")]
        public System.Nullable<System.DateTime> BTT_ActualRealisationEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualrealisationend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_ActualRealisationEnd");
                this.SetAttributeValue("btt_actualrealisationend", value);
                this.OnPropertyChanged("BTT_ActualRealisationEnd");
            }
        }

        /// <summary>
        /// Setting this field will create a task reminder after 14 days
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_actualtenderbiddingclose")]
        public System.Nullable<System.DateTime> Btt_ActualTenderBiddingClose
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_actualtenderbiddingclose");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ActualTenderBiddingClose");
                this.SetAttributeValue("btt_actualtenderbiddingclose", value);
                this.OnPropertyChanged("Btt_ActualTenderBiddingClose");
            }
        }

        /// <summary>
        /// BSH
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_bsh")]
        public System.Nullable<bool> Btt_BSH
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_bsh");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_BSH");
                this.SetAttributeValue("btt_bsh", value);
                this.OnPropertyChanged("Btt_BSH");
            }
        }

        /// <summary>
        /// Will start buying on.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_buyingstartdate")]
        public System.Nullable<System.DateTime> Btt_buyingstartdate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_buyingstartdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_buyingstartdate");
                this.SetAttributeValue("btt_buyingstartdate", value);
                this.OnPropertyChanged("Btt_buyingstartdate");
            }
        }

        /// <summary>
        /// City
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_city")]
        public string Btt_city
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_city");
                this.SetAttributeValue("btt_city", value);
                this.OnPropertyChanged("Btt_city");
            }
        }

        /// <summary>
        /// Contract with
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_contractwith")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Contractwith
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_contractwith");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Contractwith");
                this.SetAttributeValue("btt_contractwith", value);
                this.OnPropertyChanged("Btt_Contractwith");
            }
        }

        /// <summary>
        /// Contract with
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_contractwith")]
        public virtual Opportunity_Btt_Contractwith? Btt_ContractwithEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_Btt_Contractwith?)(EntityOptionSetEnum.GetEnum(this, "btt_contractwith")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Contractwith");
                this.SetAttributeValue("btt_contractwith", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Contractwith");
            }
        }

        /// <summary>
        /// Country or Region.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_country")]
        public string Btt_country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_country");
                this.SetAttributeValue("btt_country", value);
                this.OnPropertyChanged("Btt_country");
            }
        }

        /// <summary>
        /// Country / Region
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_countryregion")]
        public Microsoft.Xrm.Sdk.EntityReference btt_countryregion
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_countryregion");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_countryregion");
                this.SetAttributeValue("btt_countryregion", value);
                this.OnPropertyChanged("btt_countryregion");
            }
        }

        /// <summary>
        /// Cross Sales potential?
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_crossselling")]
        public System.Nullable<bool> Btt_crossselling
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_crossselling");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_crossselling");
                this.SetAttributeValue("btt_crossselling", value);
                this.OnPropertyChanged("Btt_crossselling");
            }
        }

        /// <summary>
        /// Cross selling notes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_crosssellingnotes")]
        public string Btt_Crosssellingnotes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_crosssellingnotes");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Crosssellingnotes");
                this.SetAttributeValue("btt_crosssellingnotes", value);
                this.OnPropertyChanged("Btt_Crosssellingnotes");
            }
        }

        /// <summary>
        /// This is the date when TT delivers the product to the installer (2-step). Or the installer actually buys the product from the wholesaler (3-step).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch1")]
        public System.Nullable<System.DateTime> Btt_deliverybatch1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_deliverybatch1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_deliverybatch1");
                this.SetAttributeValue("btt_deliverybatch1", value);
                this.OnPropertyChanged("Btt_deliverybatch1");
            }
        }

        /// <summary>
        /// Delivery batch 1 Turnover
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch1turnover")]
        public Microsoft.Xrm.Sdk.Money Btt_Deliverybatch1Turnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_deliverybatch1turnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Deliverybatch1Turnover");
                this.SetAttributeValue("btt_deliverybatch1turnover", value);
                this.OnPropertyChanged("Btt_Deliverybatch1Turnover");
            }
        }

        /// <summary>
        /// Value of the Delivery batch 1 Turnover in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch1turnover_base")]
        public Microsoft.Xrm.Sdk.Money btt_deliverybatch1turnover_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_deliverybatch1turnover_base");
            }
        }

        /// <summary>
        /// Delivery batch 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch2")]
        public System.Nullable<System.DateTime> Btt_Deliverybatch2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_deliverybatch2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Deliverybatch2");
                this.SetAttributeValue("btt_deliverybatch2", value);
                this.OnPropertyChanged("Btt_Deliverybatch2");
            }
        }

        /// <summary>
        /// Delivery batch 2 Turnover
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch2turnover")]
        public Microsoft.Xrm.Sdk.Money Btt_Deliverybatch2Turnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_deliverybatch2turnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Deliverybatch2Turnover");
                this.SetAttributeValue("btt_deliverybatch2turnover", value);
                this.OnPropertyChanged("Btt_Deliverybatch2Turnover");
            }
        }

        /// <summary>
        /// Value of the Delivery batch 2 Turnover in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch2turnover_base")]
        public Microsoft.Xrm.Sdk.Money btt_deliverybatch2turnover_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_deliverybatch2turnover_base");
            }
        }

        /// <summary>
        /// Delivery batch 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch3")]
        public System.Nullable<System.DateTime> Btt_Deliverybatch3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_deliverybatch3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Deliverybatch3");
                this.SetAttributeValue("btt_deliverybatch3", value);
                this.OnPropertyChanged("Btt_Deliverybatch3");
            }
        }

        /// <summary>
        /// Delivery batch 3 Turnover
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch3turnover")]
        public Microsoft.Xrm.Sdk.Money Btt_Deliverybatch3Turnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_deliverybatch3turnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Deliverybatch3Turnover");
                this.SetAttributeValue("btt_deliverybatch3turnover", value);
                this.OnPropertyChanged("Btt_Deliverybatch3Turnover");
            }
        }

        /// <summary>
        /// Value of the Delivery batch 3 Turnover in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_deliverybatch3turnover_base")]
        public Microsoft.Xrm.Sdk.Money btt_deliverybatch3turnover_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_deliverybatch3turnover_base");
            }
        }

        /// <summary>
        /// Unique identifier for Account associated with Project.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_involvedplannerid")]
        public Microsoft.Xrm.Sdk.EntityReference Btt_involvedplannerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_involvedplannerid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_involvedplannerId");
                this.SetAttributeValue("btt_involvedplannerid", value);
                this.OnPropertyChanged("Btt_involvedplannerId");
            }
        }

        /// <summary>
        /// Setting this field will create a task reminder on the same date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_nextstep")]
        public System.Nullable<System.DateTime> Btt_NextStep
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_nextstep");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_NextStep");
                this.SetAttributeValue("btt_nextstep", value);
                this.OnPropertyChanged("Btt_NextStep");
            }
        }

        /// <summary>
        /// Offer Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_offercode")]
        public string btt_offercode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_offercode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_offercode");
                this.SetAttributeValue("btt_offercode", value);
                this.OnPropertyChanged("btt_offercode");
            }
        }

        /// <summary>
        /// Whether the project on schedule or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_onschedule")]
        public System.Nullable<bool> Btt_onschedule
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_onschedule");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_onschedule");
                this.SetAttributeValue("btt_onschedule", value);
                this.OnPropertyChanged("Btt_onschedule");
            }
        }

        /// <summary>
        /// Unique identifier for Opportunity Product Group associated with Opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_opportunityproductgroupid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_OpportunityProductGroupId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_opportunityproductgroupid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_OpportunityProductGroupId");
                this.SetAttributeValue("btt_opportunityproductgroupid", value);
                this.OnPropertyChanged("btt_OpportunityProductGroupId");
            }
        }

        /// <summary>
        /// Other
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_other")]
        public System.Nullable<bool> Btt_Other
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_other");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Other");
                this.SetAttributeValue("btt_other", value);
                this.OnPropertyChanged("Btt_Other");
            }
        }

        /// <summary>
        /// Unique identifier for opportunity associated with parent opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_parentopportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_parentopportunityid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_parentopportunityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_parentopportunityid");
                this.SetAttributeValue("btt_parentopportunityid", value);
                this.OnPropertyChanged("btt_parentopportunityid");
            }
        }

        /// <summary>
        /// Planned date 1st offer sent
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_planneddate1stoffersent")]
        public System.Nullable<System.DateTime> BTT_Planneddate1stoffersent
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_planneddate1stoffersent");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_Planneddate1stoffersent");
                this.SetAttributeValue("btt_planneddate1stoffersent", value);
                this.OnPropertyChanged("BTT_Planneddate1stoffersent");
            }
        }

        /// <summary>
        /// Planned Date Certification
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_planneddatecertification")]
        public System.Nullable<System.DateTime> BTT_PlannedDateCertification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_planneddatecertification");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_PlannedDateCertification");
                this.SetAttributeValue("btt_planneddatecertification", value);
                this.OnPropertyChanged("BTT_PlannedDateCertification");
            }
        }

        /// <summary>
        /// Planned Date Installation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_planneddateinstallation")]
        public System.Nullable<System.DateTime> BTT_PlannedDateInstallation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_planneddateinstallation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_PlannedDateInstallation");
                this.SetAttributeValue("btt_planneddateinstallation", value);
                this.OnPropertyChanged("BTT_PlannedDateInstallation");
            }
        }

        /// <summary>
        /// Setting this field will create a task 2 days before
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_planneddateorder")]
        public System.Nullable<System.DateTime> BTT_PlannedDateOrder
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_planneddateorder");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_PlannedDateOrder");
                this.SetAttributeValue("btt_planneddateorder", value);
                this.OnPropertyChanged("BTT_PlannedDateOrder");
            }
        }

        /// <summary>
        /// Setting this field will create a task reminder 2 days before and 7 days after
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_planneddelivery")]
        public System.Nullable<System.DateTime> Btt_PlannedDelivery
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_planneddelivery");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PlannedDelivery");
                this.SetAttributeValue("btt_planneddelivery", value);
                this.OnPropertyChanged("Btt_PlannedDelivery");
            }
        }

        /// <summary>
        /// Planned Negotiations End
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannednegotiationsend")]
        public System.Nullable<System.DateTime> BTT_PlannedNegotiationsEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_plannednegotiationsend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_PlannedNegotiationsEnd");
                this.SetAttributeValue("btt_plannednegotiationsend", value);
                this.OnPropertyChanged("BTT_PlannedNegotiationsEnd");
            }
        }

        /// <summary>
        /// Planned Preparation End
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannedpreparationend")]
        public System.Nullable<System.DateTime> BTT_PlannedPreparationEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_plannedpreparationend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_PlannedPreparationEnd");
                this.SetAttributeValue("btt_plannedpreparationend", value);
                this.OnPropertyChanged("BTT_PlannedPreparationEnd");
            }
        }

        /// <summary>
        /// Planned Realisation End
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannedrealisationend")]
        public System.Nullable<System.DateTime> BTT_PlannedRealisationEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_plannedrealisationend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_PlannedRealisationEnd");
                this.SetAttributeValue("btt_plannedrealisationend", value);
                this.OnPropertyChanged("BTT_PlannedRealisationEnd");
            }
        }

        /// <summary>
        /// Setting this field will create a task 2 days before
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannedtender")]
        public System.Nullable<System.DateTime> Btt_Plannedtender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_plannedtender");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Plannedtender");
                this.SetAttributeValue("btt_plannedtender", value);
                this.OnPropertyChanged("Btt_Plannedtender");
            }
        }

        /// <summary>
        /// Unique identifier for Contact associated with Opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannercontactid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_plannercontactid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_plannercontactid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_plannercontactid");
                this.SetAttributeValue("btt_plannercontactid", value);
                this.OnPropertyChanged("btt_plannercontactid");
            }
        }

        /// <summary>
        /// Planner's Commission
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannerscommission")]
        public Microsoft.Xrm.Sdk.Money Btt_PlannersCommission
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_plannerscommission");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PlannersCommission");
                this.SetAttributeValue("btt_plannerscommission", value);
                this.OnPropertyChanged("Btt_PlannersCommission");
            }
        }

        /// <summary>
        /// Value of the Planner's Commission in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannerscommission_base")]
        public Microsoft.Xrm.Sdk.Money btt_plannerscommission_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_plannerscommission_base");
            }
        }

        /// <summary>
        /// Planner's share of the whole opportunity amount (decimal, not percentage).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannersshare")]
        public System.Nullable<decimal> Btt_Plannersshare
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("btt_plannersshare");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Plannersshare");
                this.SetAttributeValue("btt_plannersshare", value);
                this.OnPropertyChanged("Btt_Plannersshare");
            }
        }

        /// <summary>
        /// Postal code.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_postalcode")]
        public string Btt_postalcode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_postalcode");
                this.SetAttributeValue("btt_postalcode", value);
                this.OnPropertyChanged("Btt_postalcode");
            }
        }

        /// <summary>
        /// Product description
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productdescription")]
        public string Btt_Productdescription
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_productdescription");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Productdescription");
                this.SetAttributeValue("btt_productdescription", value);
                this.OnPropertyChanged("Btt_Productdescription");
            }
        }

        /// <summary>
        /// Product Group 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productgroup2")]
        public Microsoft.Xrm.Sdk.EntityReference btt_ProductGroup2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_productgroup2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_ProductGroup2");
                this.SetAttributeValue("btt_productgroup2", value);
                this.OnPropertyChanged("btt_ProductGroup2");
            }
        }

        /// <summary>
        /// Product Group 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productgroup3")]
        public Microsoft.Xrm.Sdk.EntityReference btt_ProductGroup3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_productgroup3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_ProductGroup3");
                this.SetAttributeValue("btt_productgroup3", value);
                this.OnPropertyChanged("btt_ProductGroup3");
            }
        }

        /// <summary>
        /// Production location
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productionlocation")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Productionlocation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_productionlocation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Productionlocation");
                this.SetAttributeValue("btt_productionlocation", value);
                this.OnPropertyChanged("Btt_Productionlocation");
            }
        }

        /// <summary>
        /// Production location
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productionlocation")]
        public virtual Opportunity_Btt_Productionlocation? Btt_ProductionlocationEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_Btt_Productionlocation?)(EntityOptionSetEnum.GetEnum(this, "btt_productionlocation")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Productionlocation");
                this.SetAttributeValue("btt_productionlocation", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Productionlocation");
            }
        }

        /// <summary>
        /// NR.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productnr")]
        public System.Nullable<int> Btt_productnr
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_productnr");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_productnr");
                this.SetAttributeValue("btt_productnr", value);
                this.OnPropertyChanged("Btt_productnr");
            }
        }

        /// <summary>
        /// Opportunity ABC classification.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_projectclassification")]
        public string Btt_projectclassification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_projectclassification");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_projectclassification");
                this.SetAttributeValue("btt_projectclassification", value);
                this.OnPropertyChanged("Btt_projectclassification");
            }
        }

        /// <summary>
        /// Project code.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_projectnumber")]
        public string Btt_projectnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_projectnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_projectnumber");
                this.SetAttributeValue("btt_projectnumber", value);
                this.OnPropertyChanged("Btt_projectnumber");
            }
        }

        /// <summary>
        /// Opportunity start date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_projectstartdate")]
        public System.Nullable<System.DateTime> Btt_projectstartdate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_projectstartdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_projectstartdate");
                this.SetAttributeValue("btt_projectstartdate", value);
                this.OnPropertyChanged("Btt_projectstartdate");
            }
        }

        /// <summary>
        /// Opportunity type 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_projecttype1")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_projecttype1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_projecttype1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_projecttype1");
                this.SetAttributeValue("btt_projecttype1", value);
                this.OnPropertyChanged("Btt_projecttype1");
            }
        }

        /// <summary>
        /// Opportunity type 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_projecttype1")]
        public virtual Opportunity_Btt_projecttype1? Btt_projecttype1Enum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_Btt_projecttype1?)(EntityOptionSetEnum.GetEnum(this, "btt_projecttype1")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_projecttype1");
                this.SetAttributeValue("btt_projecttype1", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_projecttype1");
            }
        }

        /// <summary>
        /// Opportunity type 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_projecttype2")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_projecttype2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_projecttype2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_projecttype2");
                this.SetAttributeValue("btt_projecttype2", value);
                this.OnPropertyChanged("Btt_projecttype2");
            }
        }

        /// <summary>
        /// Opportunity type 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_projecttype2")]
        public virtual Opportunity_Btt_projecttype2? Btt_projecttype2Enum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_Btt_projecttype2?)(EntityOptionSetEnum.GetEnum(this, "btt_projecttype2")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_projecttype2");
                this.SetAttributeValue("btt_projecttype2", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_projecttype2");
            }
        }

        /// <summary>
        /// Unique identifier for Province associated with Opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_provinceid")]
        public Microsoft.Xrm.Sdk.EntityReference Btt_ProvinceId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_provinceid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ProvinceId");
                this.SetAttributeValue("btt_provinceid", value);
                this.OnPropertyChanged("Btt_ProvinceId");
            }
        }

        /// <summary>
        /// PT
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_pt")]
        public System.Nullable<bool> Btt_PT
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_pt");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PT");
                this.SetAttributeValue("btt_pt", value);
                this.OnPropertyChanged("Btt_PT");
            }
        }

        /// <summary>
        /// Region
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_region")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_region
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_region");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_region");
                this.SetAttributeValue("btt_region", value);
                this.OnPropertyChanged("Btt_region");
            }
        }

        /// <summary>
        /// Region
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_region")]
        public virtual Opportunity_Btt_region? Btt_regionEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_Btt_region?)(EntityOptionSetEnum.GetEnum(this, "btt_region")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_region");
                this.SetAttributeValue("btt_region", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_region");
            }
        }

        /// <summary>
        /// Sales Model
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_salesmodel")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_SalesModel
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_salesmodel");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_SalesModel");
                this.SetAttributeValue("btt_salesmodel", value);
                this.OnPropertyChanged("Btt_SalesModel");
            }
        }

        /// <summary>
        /// Sales Model
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_salesmodel")]
        public virtual Opportunity_Btt_SalesModel? Btt_SalesModelEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_Btt_SalesModel?)(EntityOptionSetEnum.GetEnum(this, "btt_salesmodel")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_SalesModel");
                this.SetAttributeValue("btt_salesmodel", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_SalesModel");
            }
        }

        /// <summary>
        /// sales stages
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_salesstages")]
        public Microsoft.Xrm.Sdk.EntityReference btt_salesstages
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_salesstages");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_salesstages");
                this.SetAttributeValue("btt_salesstages", value);
                this.OnPropertyChanged("btt_salesstages");
            }
        }

        /// <summary>
        /// Different discounts are possible for projects
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_specialdiscounts")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_specialdiscounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_specialdiscounts");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_specialdiscounts");
                this.SetAttributeValue("btt_specialdiscounts", value);
                this.OnPropertyChanged("Btt_specialdiscounts");
            }
        }

        /// <summary>
        /// Different discounts are possible for projects
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_specialdiscounts")]
        public virtual Opportunity_Btt_specialdiscounts? Btt_specialdiscountsEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_Btt_specialdiscounts?)(EntityOptionSetEnum.GetEnum(this, "btt_specialdiscounts")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_specialdiscounts");
                this.SetAttributeValue("btt_specialdiscounts", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_specialdiscounts");
            }
        }

        /// <summary>
        /// ST
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_st")]
        public System.Nullable<bool> Btt_ST
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_st");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ST");
                this.SetAttributeValue("btt_st", value);
                this.OnPropertyChanged("Btt_ST");
            }
        }

        /// <summary>
        /// Street
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_street")]
        public string Btt_street
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_street");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_street");
                this.SetAttributeValue("btt_street", value);
                this.OnPropertyChanged("Btt_street");
            }
        }

        /// <summary>
        /// Tonnage
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tonnage")]
        public System.Nullable<int> Btt_Tonnage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_tonnage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Tonnage");
                this.SetAttributeValue("btt_tonnage", value);
                this.OnPropertyChanged("Btt_Tonnage");
            }
        }

        /// <summary>
        /// Can be triggerd with price.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_price")]
        public System.Nullable<bool> Btt_trigger_price
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_price");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_price");
                this.SetAttributeValue("btt_trigger_price", value);
                this.OnPropertyChanged("Btt_trigger_price");
            }
        }

        /// <summary>
        /// Can be triggerd with  product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_product")]
        public System.Nullable<bool> Btt_trigger_product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_product");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_product");
                this.SetAttributeValue("btt_trigger_product", value);
                this.OnPropertyChanged("Btt_trigger_product");
            }
        }

        /// <summary>
        /// Can be triggerd with relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_relationship")]
        public System.Nullable<bool> Btt_trigger_relationship
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_relationship");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_relationship");
                this.SetAttributeValue("btt_trigger_relationship", value);
                this.OnPropertyChanged("Btt_trigger_relationship");
            }
        }

        /// <summary>
        /// Can be triggerd with service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_service")]
        public System.Nullable<bool> Btt_trigger_service
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_service");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_service");
                this.SetAttributeValue("btt_trigger_service", value);
                this.OnPropertyChanged("Btt_trigger_service");
            }
        }

        /// <summary>
        /// Can be triggered with technical support.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_technicalsupport")]
        public System.Nullable<bool> BTT_trigger_TechnicalSupport
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_technicalsupport");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_trigger_TechnicalSupport");
                this.SetAttributeValue("btt_trigger_technicalsupport", value);
                this.OnPropertyChanged("BTT_trigger_TechnicalSupport");
            }
        }

        /// <summary>
        /// Unique identifier for Product Group associated with Opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_typeofproductid")]
        public Microsoft.Xrm.Sdk.EntityReference Btt_TypeofproductId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_typeofproductid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TypeofproductId");
                this.SetAttributeValue("btt_typeofproductid", value);
                this.OnPropertyChanged("Btt_TypeofproductId");
            }
        }

        /// <summary>
        /// AA
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_xsell1")]
        public System.Nullable<bool> btt_xsell1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_xsell1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_xsell1");
                this.SetAttributeValue("btt_xsell1", value);
                this.OnPropertyChanged("btt_xsell1");
            }
        }

        /// <summary>
        /// Rexroth
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_xsell2")]
        public System.Nullable<bool> btt_xsell2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_xsell2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_xsell2");
                this.SetAttributeValue("btt_xsell2", value);
                this.OnPropertyChanged("btt_xsell2");
            }
        }

        /// <summary>
        /// BEPS
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_xsell3")]
        public System.Nullable<bool> btt_xsell3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_xsell3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_xsell3");
                this.SetAttributeValue("btt_xsell3", value);
                this.OnPropertyChanged("btt_xsell3");
            }
        }

        /// <summary>
        /// Packaging
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_xsell4")]
        public System.Nullable<bool> btt_xsell4
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_xsell4");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_xsell4");
                this.SetAttributeValue("btt_xsell4", value);
                this.OnPropertyChanged("btt_xsell4");
            }
        }

        /// <summary>
        /// Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BudgetAmount");
                this.SetAttributeValue("budgetamount", value);
                this.OnPropertyChanged("BudgetAmount");
            }
        }

        /// <summary>
        /// Shows the budget amount converted to the system's base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount_base")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount_base");
            }
        }

        /// <summary>
        /// Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue BudgetStatus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("budgetstatus");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BudgetStatus");
                this.SetAttributeValue("budgetstatus", value);
                this.OnPropertyChanged("BudgetStatus");
            }
        }

        /// <summary>
        /// Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
        public virtual BudgetStatus? BudgetStatusEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((BudgetStatus?)(EntityOptionSetEnum.GetEnum(this, "budgetstatus")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BudgetStatus");
                this.SetAttributeValue("budgetstatus", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BudgetStatus");
            }
        }

        /// <summary>
        /// Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                this.OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        /// Choose whether the proposal feedback has been captured for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("captureproposalfeedback")]
        public System.Nullable<bool> CaptureProposalFeedback
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("captureproposalfeedback");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CaptureProposalFeedback");
                this.SetAttributeValue("captureproposalfeedback", value);
                this.OnPropertyChanged("CaptureProposalFeedback");
            }
        }

        /// <summary>
        /// Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closeprobability")]
        public System.Nullable<int> CloseProbability
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("closeprobability");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CloseProbability");
                this.SetAttributeValue("closeprobability", value);
                this.OnPropertyChanged("CloseProbability");
            }
        }

        /// <summary>
        /// Select whether a final proposal has been completed for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completefinalproposal")]
        public System.Nullable<bool> CompleteFinalProposal
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("completefinalproposal");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CompleteFinalProposal");
                this.SetAttributeValue("completefinalproposal", value);
                this.OnPropertyChanged("CompleteFinalProposal");
            }
        }

        /// <summary>
        /// Select whether an internal review has been completed for this opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completeinternalreview")]
        public System.Nullable<bool> CompleteInternalReview
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("completeinternalreview");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CompleteInternalReview");
                this.SetAttributeValue("completeinternalreview", value);
                this.OnPropertyChanged("CompleteInternalReview");
            }
        }

        /// <summary>
        /// Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("confirminterest")]
        public System.Nullable<bool> ConfirmInterest
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("confirminterest");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ConfirmInterest");
                this.SetAttributeValue("confirminterest", value);
                this.OnPropertyChanged("ConfirmInterest");
            }
        }

        /// <summary>
        /// Unique identifier of the contact associated with the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid");
            }
        }

        /// <summary>
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedBy");
                this.SetAttributeValue("createdby", value);
                this.OnPropertyChanged("CreatedBy");
            }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedOn");
                this.SetAttributeValue("createdon", value);
                this.OnPropertyChanged("CreatedOn");
            }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedOnBehalfBy");
                this.SetAttributeValue("createdonbehalfby", value);
                this.OnPropertyChanged("CreatedOnBehalfBy");
            }
        }

        /// <summary>
        /// Type notes about the company or organization associated with the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentsituation")]
        public string CurrentSituation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("currentsituation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CurrentSituation");
                this.SetAttributeValue("currentsituation", value);
                this.OnPropertyChanged("CurrentSituation");
            }
        }

        /// <summary>
        /// Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerneed")]
        public string CustomerNeed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("customerneed");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerNeed");
                this.SetAttributeValue("customerneed", value);
                this.OnPropertyChanged("CustomerNeed");
            }
        }

        /// <summary>
        /// Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerpainpoints")]
        public string CustomerPainPoints
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("customerpainpoints");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerPainPoints");
                this.SetAttributeValue("customerpainpoints", value);
                this.OnPropertyChanged("CustomerPainPoints");
            }
        }

        /// <summary>
        /// Select whether your notes include information about who makes the purchase decisions at the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decisionmaker")]
        public System.Nullable<bool> DecisionMaker
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("decisionmaker");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DecisionMaker");
                this.SetAttributeValue("decisionmaker", value);
                this.OnPropertyChanged("DecisionMaker");
            }
        }

        /// <summary>
        /// Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("description");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Select whether a proposal has been developed for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("developproposal")]
        public System.Nullable<bool> DevelopProposal
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("developproposal");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DevelopProposal");
                this.SetAttributeValue("developproposal", value);
                this.OnPropertyChanged("DevelopProposal");
            }
        }

        /// <summary>
        /// Type the discount amount for the opportunity if the customer is eligible for special savings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DiscountAmount");
                this.SetAttributeValue("discountamount", value);
                this.OnPropertyChanged("DiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Opportunity Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount_base")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount_base");
            }
        }

        /// <summary>
        /// Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountpercentage")]
        public System.Nullable<decimal> DiscountPercentage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("discountpercentage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DiscountPercentage");
                this.SetAttributeValue("discountpercentage", value);
                this.OnPropertyChanged("DiscountPercentage");
            }
        }

        /// <summary>
        /// The primary email address for the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EmailAddress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("emailaddress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailAddress");
                this.SetAttributeValue("emailaddress", value);
                this.OnPropertyChanged("EmailAddress");
            }
        }

        /// <summary>
        /// Enter the expected closing date of the opportunity to help make accurate revenue forecasts. Date when the customer decides who wins the tender.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedclosedate")]
        public System.Nullable<System.DateTime> EstimatedCloseDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("estimatedclosedate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EstimatedCloseDate");
                this.SetAttributeValue("estimatedclosedate", value);
                this.OnPropertyChanged("EstimatedCloseDate");
            }
        }

        /// <summary>
        /// Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue")]
        public Microsoft.Xrm.Sdk.Money EstimatedValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EstimatedValue");
                this.SetAttributeValue("estimatedvalue", value);
                this.OnPropertyChanged("EstimatedValue");
            }
        }

        /// <summary>
        /// Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue_base")]
        public Microsoft.Xrm.Sdk.Money EstimatedValue_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue_base");
            }
        }

        /// <summary>
        /// Select whether the fit between the lead's requirements and your offerings was evaluated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("evaluatefit")]
        public System.Nullable<bool> EvaluateFit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("evaluatefit");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EvaluateFit");
                this.SetAttributeValue("evaluatefit", value);
                this.OnPropertyChanged("EvaluateFit");
            }
        }

        /// <summary>
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }

        /// <summary>
        /// Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filedebrief")]
        public System.Nullable<bool> FileDebrief
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("filedebrief");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FileDebrief");
                this.SetAttributeValue("filedebrief", value);
                this.OnPropertyChanged("FileDebrief");
            }
        }

        /// <summary>
        /// Enter the date and time when the final decision of the opportunity was made.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("finaldecisiondate")]
        public System.Nullable<System.DateTime> FinalDecisionDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("finaldecisiondate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FinalDecisionDate");
                this.SetAttributeValue("finaldecisiondate", value);
                this.OnPropertyChanged("FinalDecisionDate");
            }
        }

        /// <summary>
        /// Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount")]
        public Microsoft.Xrm.Sdk.Money FreightAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FreightAmount");
                this.SetAttributeValue("freightamount", value);
                this.OnPropertyChanged("FreightAmount");
            }
        }

        /// <summary>
        /// Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount_base")]
        public Microsoft.Xrm.Sdk.Money FreightAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount_base");
            }
        }

        /// <summary>
        /// Select whether information about competitors is included.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycompetitors")]
        public System.Nullable<bool> IdentifyCompetitors
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("identifycompetitors");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IdentifyCompetitors");
                this.SetAttributeValue("identifycompetitors", value);
                this.OnPropertyChanged("IdentifyCompetitors");
            }
        }

        /// <summary>
        /// Select whether the customer contacts for this opportunity have been identified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycustomercontacts")]
        public System.Nullable<bool> IdentifyCustomerContacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("identifycustomercontacts");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IdentifyCustomerContacts");
                this.SetAttributeValue("identifycustomercontacts", value);
                this.OnPropertyChanged("IdentifyCustomerContacts");
            }
        }

        /// <summary>
        /// Choose whether you have recorded who will pursue the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifypursuitteam")]
        public System.Nullable<bool> IdentifyPursuitTeam
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("identifypursuitteam");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IdentifyPursuitTeam");
                this.SetAttributeValue("identifypursuitteam", value);
                this.OnPropertyChanged("IdentifyPursuitTeam");
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Choose whether someone from the sales team contacted this lead earlier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
        public Microsoft.Xrm.Sdk.OptionSetValue InitialCommunication
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialcommunication");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("InitialCommunication");
                this.SetAttributeValue("initialcommunication", value);
                this.OnPropertyChanged("InitialCommunication");
            }
        }

        /// <summary>
        /// Choose whether someone from the sales team contacted this lead earlier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
        public virtual InitialCommunication? InitialCommunicationEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((InitialCommunication?)(EntityOptionSetEnum.GetEnum(this, "initialcommunication")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("InitialCommunication");
                this.SetAttributeValue("initialcommunication", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("InitialCommunication");
            }
        }

        /// <summary>
        /// Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrevenuesystemcalculated")]
        public System.Nullable<bool> IsRevenueSystemCalculated
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isrevenuesystemcalculated");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsRevenueSystemCalculated");
                this.SetAttributeValue("isrevenuesystemcalculated", value);
                this.OnPropertyChanged("IsRevenueSystemCalculated");
            }
        }

        /// <summary>
        /// Contains the date time stamp of the last on hold time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
        public System.Nullable<System.DateTime> LastOnHoldTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastOnHoldTime");
                this.SetAttributeValue("lastonholdtime", value);
                this.OnPropertyChanged("LastOnHoldTime");
            }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedBy");
                this.SetAttributeValue("modifiedby", value);
                this.OnPropertyChanged("ModifiedBy");
            }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedOn");
                this.SetAttributeValue("modifiedon", value);
                this.OnPropertyChanged("ModifiedOn");
            }
        }

        /// <summary>
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedOnBehalfBy");
                this.SetAttributeValue("modifiedonbehalfby", value);
                this.OnPropertyChanged("ModifiedOnBehalfBy");
            }
        }

        /// <summary>
        /// Type a subject or descriptive name, such as the expected order or company name, for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Choose how high the level of need is for the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
        public Microsoft.Xrm.Sdk.OptionSetValue Need
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("need");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Need");
                this.SetAttributeValue("need", value);
                this.OnPropertyChanged("Need");
            }
        }

        /// <summary>
        /// Choose how high the level of need is for the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
        public virtual Need? NeedEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Need?)(EntityOptionSetEnum.GetEnum(this, "need")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Need");
                this.SetAttributeValue("need", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Need");
            }
        }

        /// <summary>
        /// Commercial
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_commercial")]
        public System.Nullable<bool> new_commercial
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_commercial");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("new_commercial");
                this.SetAttributeValue("new_commercial", value);
                this.OnPropertyChanged("new_commercial");
            }
        }

        /// <summary>
        /// Industrial
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_industrial")]
        public System.Nullable<bool> new_industrial
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_industrial");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("new_industrial");
                this.SetAttributeValue("new_industrial", value);
                this.OnPropertyChanged("new_industrial");
            }
        }

        /// <summary>
        /// Residential
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_residential")]
        public System.Nullable<bool> new_residential
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_residential");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("new_residential");
                this.SetAttributeValue("new_residential", value);
                this.OnPropertyChanged("new_residential");
            }
        }

        /// <summary>
        /// Shows the duration in minutes for which the opportunity was on hold.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
        public System.Nullable<int> OnHoldTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("onholdtime");
            }
        }

        /// <summary>
        /// Unique identifier of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public System.Nullable<System.Guid> OpportunityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OpportunityId");
                this.SetAttributeValue("opportunityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("OpportunityId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public override System.Guid Id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return base.Id;
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OpportunityId = value;
            }
        }

        /// <summary>
        /// Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityratingcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue OpportunityRatingCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("opportunityratingcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OpportunityRatingCode");
                this.SetAttributeValue("opportunityratingcode", value);
                this.OnPropertyChanged("OpportunityRatingCode");
            }
        }

        /// <summary>
        /// Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityratingcode")]
        public virtual Opportunity_OpportunityRatingCode? OpportunityRatingCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_OpportunityRatingCode?)(EntityOptionSetEnum.GetEnum(this, "opportunityratingcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OpportunityRatingCode");
                this.SetAttributeValue("opportunityratingcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("OpportunityRatingCode");
            }
        }

        /// <summary>
        /// Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OriginatingLeadId");
                this.SetAttributeValue("originatingleadid", value);
                this.OnPropertyChanged("OriginatingLeadId");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// business_unit_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningBusinessUnit");
                this.SetAttributeValue("owningbusinessunit", value);
                this.OnPropertyChanged("OwningBusinessUnit");
            }
        }

        /// <summary>
        /// team_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningTeam");
                this.SetAttributeValue("owningteam", value);
                this.OnPropertyChanged("OwningTeam");
            }
        }

        /// <summary>
        /// opportunity_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningUser");
                this.SetAttributeValue("owninguser", value);
                this.OnPropertyChanged("OwningUser");
            }
        }

        /// <summary>
        /// Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentAccountId");
                this.SetAttributeValue("parentaccountid", value);
                this.OnPropertyChanged("ParentAccountId");
            }
        }

        /// <summary>
        /// Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentContactId");
                this.SetAttributeValue("parentcontactid", value);
                this.OnPropertyChanged("ParentContactId");
            }
        }

        /// <summary>
        /// Information about whether the opportunity participates in workflow rules.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParticipatesInWorkflow");
                this.SetAttributeValue("participatesinworkflow", value);
                this.OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        /// Select whether the final proposal has been presented to the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentfinalproposal")]
        public System.Nullable<bool> PresentFinalProposal
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("presentfinalproposal");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PresentFinalProposal");
                this.SetAttributeValue("presentfinalproposal", value);
                this.OnPropertyChanged("PresentFinalProposal");
            }
        }

        /// <summary>
        /// Select whether a proposal for the opportunity has been presented to the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentproposal")]
        public System.Nullable<bool> PresentProposal
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("presentproposal");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PresentProposal");
                this.SetAttributeValue("presentproposal", value);
                this.OnPropertyChanged("PresentProposal");
            }
        }

        /// <summary>
        /// Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PriceLevelId");
                this.SetAttributeValue("pricelevelid", value);
                this.OnPropertyChanged("PriceLevelId");
            }
        }

        /// <summary>
        /// Pricing error for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PricingErrorCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingerrorcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PricingErrorCode");
                this.SetAttributeValue("pricingerrorcode", value);
                this.OnPropertyChanged("PricingErrorCode");
            }
        }

        /// <summary>
        /// Pricing error for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
        public virtual Qooi_PricingErrorCode? PricingErrorCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Qooi_PricingErrorCode?)(EntityOptionSetEnum.GetEnum(this, "pricingerrorcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PricingErrorCode");
                this.SetAttributeValue("pricingerrorcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PricingErrorCode");
            }
        }

        /// <summary>
        /// (importance) Priority of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value);
                this.OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        /// (importance) Priority of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public virtual Opportunity_PriorityCode? PriorityCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_PriorityCode?)(EntityOptionSetEnum.GetEnum(this, "prioritycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Type notes about the proposed solution for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("proposedsolution")]
        public string ProposedSolution
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("proposedsolution");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProposedSolution");
                this.SetAttributeValue("proposedsolution", value);
                this.OnPropertyChanged("ProposedSolution");
            }
        }

        /// <summary>
        /// Choose whether an individual or a committee will be involved in the purchase process for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseProcess
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchaseprocess");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PurchaseProcess");
                this.SetAttributeValue("purchaseprocess", value);
                this.OnPropertyChanged("PurchaseProcess");
            }
        }

        /// <summary>
        /// Choose whether an individual or a committee will be involved in the purchase process for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
        public virtual PurchaseProcess? PurchaseProcessEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((PurchaseProcess?)(EntityOptionSetEnum.GetEnum(this, "purchaseprocess")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PurchaseProcess");
                this.SetAttributeValue("purchaseprocess", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PurchaseProcess");
            }
        }

        /// <summary>
        /// Choose how long the lead will likely take to make the purchase.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseTimeframe
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchasetimeframe");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PurchaseTimeframe");
                this.SetAttributeValue("purchasetimeframe", value);
                this.OnPropertyChanged("PurchaseTimeframe");
            }
        }

        /// <summary>
        /// Choose how long the lead will likely take to make the purchase.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
        public virtual PurchaseTimeFrame? PurchaseTimeframeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((PurchaseTimeFrame?)(EntityOptionSetEnum.GetEnum(this, "purchasetimeframe")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PurchaseTimeframe");
                this.SetAttributeValue("purchasetimeframe", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PurchaseTimeframe");
            }
        }

        /// <summary>
        /// Select whether the decision about pursuing the opportunity has been made.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pursuitdecision")]
        public System.Nullable<bool> PursuitDecision
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("pursuitdecision");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PursuitDecision");
                this.SetAttributeValue("pursuitdecision", value);
                this.OnPropertyChanged("PursuitDecision");
            }
        }

        /// <summary>
        /// Type comments about the qualification or scoring of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualificationcomments")]
        public string QualificationComments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("qualificationcomments");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QualificationComments");
                this.SetAttributeValue("qualificationcomments", value);
                this.OnPropertyChanged("QualificationComments");
            }
        }

        /// <summary>
        /// Type comments about the quotes associated with the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotecomments")]
        public string QuoteComments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("quotecomments");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QuoteComments");
                this.SetAttributeValue("quotecomments", value);
                this.OnPropertyChanged("QuoteComments");
            }
        }

        /// <summary>
        /// AL- Destination Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_alid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ALid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_alid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ALid");
                this.SetAttributeValue("rbtt_alid", value);
                this.OnPropertyChanged("rbtt_ALid");
            }
        }

        /// <summary>
        /// Application
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_application")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_Application
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_application");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Application");
                this.SetAttributeValue("rbtt_application", value);
                this.OnPropertyChanged("rbtt_Application");
            }
        }

        /// <summary>
        /// Application
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_application")]
        public virtual Opportunity_rbtt_Application? rbtt_ApplicationEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_rbtt_Application?)(EntityOptionSetEnum.GetEnum(this, "rbtt_application")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Application");
                this.SetAttributeValue("rbtt_application", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_Application");
            }
        }

        /// <summary>
        /// Branch Office
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_branchoffice")]
        public string rbtt_BranchOffice
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_branchoffice");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_BranchOffice");
                this.SetAttributeValue("rbtt_branchoffice", value);
                this.OnPropertyChanged("rbtt_BranchOffice");
            }
        }

        /// <summary>
        /// Business Segment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_businesssegment")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_BusinessSegment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_businesssegment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_BusinessSegment");
                this.SetAttributeValue("rbtt_businesssegment", value);
                this.OnPropertyChanged("rbtt_BusinessSegment");
            }
        }

        /// <summary>
        /// Business Segment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_businesssegment")]
        public virtual Opportunity_rbtt_BusinessSegment? rbtt_BusinessSegmentEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_rbtt_BusinessSegment?)(EntityOptionSetEnum.GetEnum(this, "rbtt_businesssegment")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_BusinessSegment");
                this.SetAttributeValue("rbtt_businesssegment", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_BusinessSegment");
            }
        }

        /// <summary>
        /// Configuration Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_configurationcountryid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ConfigurationCountryId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_configurationcountryid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ConfigurationCountryId");
                this.SetAttributeValue("rbtt_configurationcountryid", value);
                this.OnPropertyChanged("rbtt_ConfigurationCountryId");
            }
        }

        /// <summary>
        /// Estimated Value (Current FX)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_estimatedvaluecurrentfx")]
        public System.Nullable<decimal> rbtt_EstimatedValueCurrentFX
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("rbtt_estimatedvaluecurrentfx");
            }
        }

        /// <summary>
        /// External Customer Reference
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_externalreference")]
        public string rbtt_ExternalReference
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_externalreference");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ExternalReference");
                this.SetAttributeValue("rbtt_externalreference", value);
                this.OnPropertyChanged("rbtt_ExternalReference");
            }
        }

        /// <summary>
        /// Sales Office
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_ga")]
        public string rbtt_GA
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_ga");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GA");
                this.SetAttributeValue("rbtt_ga", value);
                this.OnPropertyChanged("rbtt_GA");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_housenumber")]
        public string rbtt_HouseNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_housenumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_HouseNumber");
                this.SetAttributeValue("rbtt_housenumber", value);
                this.OnPropertyChanged("rbtt_HouseNumber");
            }
        }

        /// <summary>
        /// Industry Reference
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_industryreference")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_IndustryReference
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_industryreference");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_IndustryReference");
                this.SetAttributeValue("rbtt_industryreference", value);
                this.OnPropertyChanged("rbtt_IndustryReference");
            }
        }

        /// <summary>
        /// Industry Reference
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_industryreference")]
        public virtual rbtt_IndustryReference? rbtt_IndustryReferenceEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_IndustryReference?)(EntityOptionSetEnum.GetEnum(this, "rbtt_industryreference")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_IndustryReference");
                this.SetAttributeValue("rbtt_industryreference", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_IndustryReference");
            }
        }

        /// <summary>
        /// Is LPK Project
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_islpkproject")]
        public System.Nullable<bool> rbtt_IsLPKProject
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_islpkproject");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_IsLPKProject");
                this.SetAttributeValue("rbtt_islpkproject", value);
                this.OnPropertyChanged("rbtt_IsLPKProject");
            }
        }

        /// <summary>
        /// Service Engineer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_kd")]
        public string rbtt_KD
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_kd");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_KD");
                this.SetAttributeValue("rbtt_kd", value);
                this.OnPropertyChanged("rbtt_KD");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_line2")]
        public string rbtt_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_line2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Line2");
                this.SetAttributeValue("rbtt_line2", value);
                this.OnPropertyChanged("rbtt_Line2");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_line3")]
        public string rbtt_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_line3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Line3");
                this.SetAttributeValue("rbtt_line3", value);
                this.OnPropertyChanged("rbtt_Line3");
            }
        }

        /// <summary>
        /// Lpk Organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_lpkorganization")]
        public string rbtt_LpkOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_lpkorganization");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LpkOrganization");
                this.SetAttributeValue("rbtt_lpkorganization", value);
                this.OnPropertyChanged("rbtt_LpkOrganization");
            }
        }

        /// <summary>
        /// LPK-Projekt ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_lpkprojektid")]
        public string rbtt_LPKProjektID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_lpkprojektid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LPKProjektID");
                this.SetAttributeValue("rbtt_lpkprojektid", value);
                this.OnPropertyChanged("rbtt_LPKProjektID");
            }
        }

        /// <summary>
        /// Mandator
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_mandator")]
        public string rbtt_Mandator
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_mandator");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Mandator");
                this.SetAttributeValue("rbtt_mandator", value);
                this.OnPropertyChanged("rbtt_Mandator");
            }
        }

        /// <summary>
        /// Opportunity Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_opportunitycountry")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_OpportunityCountry
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_opportunitycountry");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_OpportunityCountry");
                this.SetAttributeValue("rbtt_opportunitycountry", value);
                this.OnPropertyChanged("rbtt_OpportunityCountry");
            }
        }

        /// <summary>
        /// Ordering Customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_orderingcustomer")]
        public string rbtt_OrderingCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_orderingcustomer");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_OrderingCustomer");
                this.SetAttributeValue("rbtt_orderingcustomer", value);
                this.OnPropertyChanged("rbtt_OrderingCustomer");
            }
        }

        /// <summary>
        /// Plant
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_plantlocationid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_PlantLocationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_plantlocationid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PlantLocationId");
                this.SetAttributeValue("rbtt_plantlocationid", value);
                this.OnPropertyChanged("rbtt_PlantLocationId");
            }
        }

        /// <summary>
        /// Total quantities of items for the Product Group 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_productgroup1qty")]
        public System.Nullable<int> rbtt_ProductGroup1Qty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_productgroup1qty");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProductGroup1Qty");
                this.SetAttributeValue("rbtt_productgroup1qty", value);
                this.OnPropertyChanged("rbtt_ProductGroup1Qty");
            }
        }

        /// <summary>
        /// Total quantities of items for the Product Group 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_productgroup2qty")]
        public System.Nullable<int> rbtt_ProductGroup2Qty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_productgroup2qty");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProductGroup2Qty");
                this.SetAttributeValue("rbtt_productgroup2qty", value);
                this.OnPropertyChanged("rbtt_ProductGroup2Qty");
            }
        }

        /// <summary>
        /// Total quantities of items for the Product Group 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_productgroup3qty")]
        public System.Nullable<int> rbtt_ProductGroup3Qty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_productgroup3qty");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProductGroup3Qty");
                this.SetAttributeValue("rbtt_productgroup3qty", value);
                this.OnPropertyChanged("rbtt_ProductGroup3Qty");
            }
        }

        /// <summary>
        /// ProjectName
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projectname")]
        public string rbtt_ProjectName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_projectname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectName");
                this.SetAttributeValue("rbtt_projectname", value);
                this.OnPropertyChanged("rbtt_ProjectName");
            }
        }

        /// <summary>
        /// Project Phase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projectphase")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_ProjectPhase
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_projectphase");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectPhase");
                this.SetAttributeValue("rbtt_projectphase", value);
                this.OnPropertyChanged("rbtt_ProjectPhase");
            }
        }

        /// <summary>
        /// Project Phase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projectphase")]
        public virtual rbtt_ProjectPhases? rbtt_ProjectPhaseEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_ProjectPhases?)(EntityOptionSetEnum.GetEnum(this, "rbtt_projectphase")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectPhase");
                this.SetAttributeValue("rbtt_projectphase", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_ProjectPhase");
            }
        }

        /// <summary>
        /// Project Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projecttype")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_ProjectType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_projecttype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectType");
                this.SetAttributeValue("rbtt_projecttype", value);
                this.OnPropertyChanged("rbtt_ProjectType");
            }
        }

        /// <summary>
        /// Project Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projecttype")]
        public virtual rbtt_ProjectType1? rbtt_ProjectTypeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_ProjectType1?)(EntityOptionSetEnum.GetEnum(this, "rbtt_projecttype")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectType");
                this.SetAttributeValue("rbtt_projecttype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_ProjectType");
            }
        }

        /// <summary>
        /// Project Type Id
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projecttypeid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ProjectTypeId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_projecttypeid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectTypeId");
                this.SetAttributeValue("rbtt_projecttypeid", value);
                this.OnPropertyChanged("rbtt_ProjectTypeId");
            }
        }

        /// <summary>
        /// LPK Project Types Value
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projecttypesvalue")]
        public string rbtt_ProjectTypesValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_projecttypesvalue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectTypesValue");
                this.SetAttributeValue("rbtt_projecttypesvalue", value);
                this.OnPropertyChanged("rbtt_ProjectTypesValue");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_province")]
        public string rbtt_Province
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_province");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Province");
                this.SetAttributeValue("rbtt_province", value);
                this.OnPropertyChanged("rbtt_Province");
            }
        }

        /// <summary>
        /// Unique identifier for Quote associated with Opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_quotetoopportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_QuotetoOpportunityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_quotetoopportunityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_QuotetoOpportunityId");
                this.SetAttributeValue("rbtt_quotetoopportunityid", value);
                this.OnPropertyChanged("rbtt_QuotetoOpportunityId");
            }
        }

        /// <summary>
        /// referenceSystemId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_referencesystemid")]
        public string rbtt_ReferenceSystemId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_referencesystemid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ReferenceSystemId");
                this.SetAttributeValue("rbtt_referencesystemid", value);
                this.OnPropertyChanged("rbtt_ReferenceSystemId");
            }
        }

        /// <summary>
        /// Invoice Recipient
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_reid")]
        public string rbtt_REid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_reid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_REid");
                this.SetAttributeValue("rbtt_reid", value);
                this.OnPropertyChanged("rbtt_REid");
            }
        }

        /// <summary>
        /// Residential Building Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_residentialbuildingtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_ResidentialBuildingType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_residentialbuildingtype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ResidentialBuildingType");
                this.SetAttributeValue("rbtt_residentialbuildingtype", value);
                this.OnPropertyChanged("rbtt_ResidentialBuildingType");
            }
        }

        /// <summary>
        /// Residential Building Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_residentialbuildingtype")]
        public virtual Opportunity_rbtt_ResidentialBuildingType? rbtt_ResidentialBuildingTypeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_rbtt_ResidentialBuildingType?)(EntityOptionSetEnum.GetEnum(this, "rbtt_residentialbuildingtype")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ResidentialBuildingType");
                this.SetAttributeValue("rbtt_residentialbuildingtype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_ResidentialBuildingType");
            }
        }

        /// <summary>
        /// Payer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_rgid")]
        public string rbtt_RGid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_rgid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RGid");
                this.SetAttributeValue("rbtt_rgid", value);
                this.OnPropertyChanged("rbtt_RGid");
            }
        }

        /// <summary>
        /// Sales Channel
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_saleschannel")]
        public string rbtt_SalesChannel
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_saleschannel");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SalesChannel");
                this.SetAttributeValue("rbtt_saleschannel", value);
                this.OnPropertyChanged("rbtt_SalesChannel");
            }
        }

        /// <summary>
        /// Sales Organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_salesorganization")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_SalesOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_salesorganization");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SalesOrganization");
                this.SetAttributeValue("rbtt_salesorganization", value);
                this.OnPropertyChanged("rbtt_SalesOrganization");
            }
        }

        /// <summary>
        /// Sales Organizations Value
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_salesorganizationsvalue")]
        public string rbtt_SalesOrganizationsValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_salesorganizationsvalue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SalesOrganizationsValue");
                this.SetAttributeValue("rbtt_salesorganizationsvalue", value);
                this.OnPropertyChanged("rbtt_SalesOrganizationsValue");
            }
        }

        /// <summary>
        /// SAP Document ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_sapdocumentid")]
        public string rbtt_SAPDocumentID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_sapdocumentid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SAPDocumentID");
                this.SetAttributeValue("rbtt_sapdocumentid", value);
                this.OnPropertyChanged("rbtt_SAPDocumentID");
            }
        }

        /// <summary>
        /// SA Region
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_saregion")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_SARegion
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_saregion");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SARegion");
                this.SetAttributeValue("rbtt_saregion", value);
                this.OnPropertyChanged("rbtt_SARegion");
            }
        }

        /// <summary>
        /// SA Region
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_saregion")]
        public virtual rbtt_SARegion? rbtt_SARegionEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_SARegion?)(EntityOptionSetEnum.GetEnum(this, "rbtt_saregion")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SARegion");
                this.SetAttributeValue("rbtt_saregion", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_SARegion");
            }
        }

        /// <summary>
        /// Scoring Chance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_scoringchance")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_ScoringChance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_scoringchance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ScoringChance");
                this.SetAttributeValue("rbtt_scoringchance", value);
                this.OnPropertyChanged("rbtt_ScoringChance");
            }
        }

        /// <summary>
        /// Scoring Chance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_scoringchance")]
        public virtual Opportunity_rbtt_ScoringChance? rbtt_ScoringChanceEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_rbtt_ScoringChance?)(EntityOptionSetEnum.GetEnum(this, "rbtt_scoringchance")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ScoringChance");
                this.SetAttributeValue("rbtt_scoringchance", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_ScoringChance");
            }
        }

        /// <summary>
        /// Serial Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_serialnumber")]
        public string rbtt_SerialNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_serialnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SerialNumber");
                this.SetAttributeValue("rbtt_serialnumber", value);
                this.OnPropertyChanged("rbtt_SerialNumber");
            }
        }

        /// <summary>
        /// Sparte
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_sparte")]
        public string rbtt_Sparte
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_sparte");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Sparte");
                this.SetAttributeValue("rbtt_sparte", value);
                this.OnPropertyChanged("rbtt_Sparte");
            }
        }

        /// <summary>
        /// Specified by EAP
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_specifiedbyeap")]
        public System.Nullable<bool> rbtt_SpecifiedbyEAP
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_specifiedbyeap");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SpecifiedbyEAP");
                this.SetAttributeValue("rbtt_specifiedbyeap", value);
                this.OnPropertyChanged("rbtt_SpecifiedbyEAP");
            }
        }

        /// <summary>
        /// Indicate when is need it the support of the technical department.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_technicalsupport")]
        public System.Nullable<bool> rbtt_TechnicalSupport
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_technicalsupport");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_TechnicalSupport");
                this.SetAttributeValue("rbtt_technicalsupport", value);
                this.OnPropertyChanged("rbtt_TechnicalSupport");
            }
        }

        /// <summary>
        /// TT in specification is needed because it is a target to be in as many specifications as possible and this can only be measured with this field. If TT is already in the specification the chance of gett
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_ttinspecification")]
        public System.Nullable<bool> rbtt_TTinspecification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_ttinspecification");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_TTinspecification");
                this.SetAttributeValue("rbtt_ttinspecification", value);
                this.OnPropertyChanged("rbtt_TTinspecification");
            }
        }

        /// <summary>
        /// Sales Employee
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_ve")]
        public string rbtt_VE
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_ve");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_VE");
                this.SetAttributeValue("rbtt_ve", value);
                this.OnPropertyChanged("rbtt_VE");
            }
        }

        /// <summary>
        /// Verkäufergruppe
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_verkufergruppe")]
        public string rbtt_Verkufergruppe
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_verkufergruppe");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Verkufergruppe");
                this.SetAttributeValue("rbtt_verkufergruppe", value);
                this.OnPropertyChanged("rbtt_Verkufergruppe");
            }
        }

        /// <summary>
        /// Vertriebsweg
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_vertriebsweg")]
        public string rbtt_Vertriebsweg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_vertriebsweg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Vertriebsweg");
                this.SetAttributeValue("rbtt_vertriebsweg", value);
                this.OnPropertyChanged("rbtt_Vertriebsweg");
            }
        }

        /// <summary>
        /// Sales Organisation VKORG
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_vkorg")]
        public string rbtt_VKORG
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_vkorg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_VKORG");
                this.SetAttributeValue("rbtt_vkorg", value);
                this.OnPropertyChanged("rbtt_VKORG");
            }
        }

        /// <summary>
        /// Material Recipient
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_weid")]
        public string rbtt_WEid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_weid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_WEid");
                this.SetAttributeValue("rbtt_weid", value);
                this.OnPropertyChanged("rbtt_WEid");
            }
        }

        /// <summary>
        /// Weighted Turnover
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_weightedturnover")]
        public Microsoft.Xrm.Sdk.Money rbtt_WeightedTurnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rbtt_weightedturnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_WeightedTurnover");
                this.SetAttributeValue("rbtt_weightedturnover", value);
                this.OnPropertyChanged("rbtt_WeightedTurnover");
            }
        }

        /// <summary>
        /// Value of the Weighted Turnover in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_weightedturnover_base")]
        public Microsoft.Xrm.Sdk.Money rbtt_weightedturnover_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rbtt_weightedturnover_base");
            }
        }

        /// <summary>
        /// Choose whether the proposal feedback has been captured and resolved for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvefeedback")]
        public System.Nullable<bool> ResolveFeedback
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("resolvefeedback");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ResolveFeedback");
                this.SetAttributeValue("resolvefeedback", value);
                this.OnPropertyChanged("ResolveFeedback");
            }
        }

        /// <summary>
        /// Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SalesStage");
                this.SetAttributeValue("salesstage", value);
                this.OnPropertyChanged("SalesStage");
            }
        }

        /// <summary>
        /// Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
        public virtual Opportunity_SalesStage? SalesStageEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_SalesStage?)(EntityOptionSetEnum.GetEnum(this, "salesstage")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SalesStage");
                this.SetAttributeValue("salesstage", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("SalesStage");
            }
        }

        /// <summary>
        /// Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStageCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstagecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SalesStageCode");
                this.SetAttributeValue("salesstagecode", value);
                this.OnPropertyChanged("SalesStageCode");
            }
        }

        /// <summary>
        /// Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
        public virtual Opportunity_SalesStageCode? SalesStageCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_SalesStageCode?)(EntityOptionSetEnum.GetEnum(this, "salesstagecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SalesStageCode");
                this.SetAttributeValue("salesstagecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("SalesStageCode");
            }
        }

        /// <summary>
        /// Enter the date and time of the prospecting follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_prospect")]
        public System.Nullable<System.DateTime> ScheduleFollowup_Prospect
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_prospect");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduleFollowup_Prospect");
                this.SetAttributeValue("schedulefollowup_prospect", value);
                this.OnPropertyChanged("ScheduleFollowup_Prospect");
            }
        }

        /// <summary>
        /// Enter the date and time of the qualifying follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_qualify")]
        public System.Nullable<System.DateTime> ScheduleFollowup_Qualify
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_qualify");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduleFollowup_Qualify");
                this.SetAttributeValue("schedulefollowup_qualify", value);
                this.OnPropertyChanged("ScheduleFollowup_Qualify");
            }
        }

        /// <summary>
        /// Enter the date and time of the proposal meeting for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleproposalmeeting")]
        public System.Nullable<System.DateTime> ScheduleProposalMeeting
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduleproposalmeeting");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduleProposalMeeting");
                this.SetAttributeValue("scheduleproposalmeeting", value);
                this.OnPropertyChanged("ScheduleProposalMeeting");
            }
        }

        /// <summary>
        /// Select whether a thank you note has been sent to the account for considering the proposal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendthankyounote")]
        public System.Nullable<bool> SendThankYouNote
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("sendthankyounote");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SendThankYouNote");
                this.SetAttributeValue("sendthankyounote", value);
                this.OnPropertyChanged("SendThankYouNote");
            }
        }

        /// <summary>
        /// Skip Price Calculation (For Internal Use)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skippricecalculation")]
        public Microsoft.Xrm.Sdk.OptionSetValue SkipPriceCalculation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("skippricecalculation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SkipPriceCalculation");
                this.SetAttributeValue("skippricecalculation", value);
                this.OnPropertyChanged("SkipPriceCalculation");
            }
        }

        /// <summary>
        /// Skip Price Calculation (For Internal Use)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skippricecalculation")]
        public virtual qooi_skippricecalculation? SkipPriceCalculationEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((qooi_skippricecalculation?)(EntityOptionSetEnum.GetEnum(this, "skippricecalculation")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SkipPriceCalculation");
                this.SetAttributeValue("skippricecalculation", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("SkipPriceCalculation");
            }
        }

        /// <summary>
        /// Choose the service level agreement (SLA) that you want to apply to the opportunity record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SLAId");
                this.SetAttributeValue("slaid", value);
                this.OnPropertyChanged("SLAId");
            }
        }

        /// <summary>
        /// sla_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid");
            }
        }

        /// <summary>
        /// processstage_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.OpportunityState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.OpportunityState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.OpportunityState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StateCode");
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
                }
                this.OnPropertyChanged("StateCode");
            }
        }

        /// <summary>
        /// Select the opportunity's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Select the opportunity's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Opportunity_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Shows the ID of the workflow step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
        public System.Nullable<System.Guid> StepId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("stepid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StepId");
                this.SetAttributeValue("stepid", value);
                this.OnPropertyChanged("StepId");
            }
        }

        /// <summary>
        /// Shows the current phase in the sales pipeline for the opportunity. This is updated by a workflow.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepname")]
        public string StepName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("stepname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StepName");
                this.SetAttributeValue("stepname", value);
                this.OnPropertyChanged("StepName");
            }
        }

        /// <summary>
        /// Number of users or conversations followed the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
        public System.Nullable<int> TeamsFollowed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TeamsFollowed");
                this.SetAttributeValue("teamsfollowed", value);
                this.OnPropertyChanged("TeamsFollowed");
            }
        }

        /// <summary>
        /// Select when the opportunity is likely to be closed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeline")]
        public Microsoft.Xrm.Sdk.OptionSetValue TimeLine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("timeline");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TimeLine");
                this.SetAttributeValue("timeline", value);
                this.OnPropertyChanged("TimeLine");
            }
        }

        /// <summary>
        /// Select when the opportunity is likely to be closed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeline")]
        public virtual Opportunity_TimeLine? TimeLineEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Opportunity_TimeLine?)(EntityOptionSetEnum.GetEnum(this, "timeline")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TimeLine");
                this.SetAttributeValue("timeline", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("TimeLine");
            }
        }

        /// <summary>
        /// Total time spent for emails (read and write) and meetings by me in relation to the opportunity record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
        public string TimeSpentByMeOnEmailAndMeetings
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount")]
        public Microsoft.Xrm.Sdk.Money TotalAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalAmount");
                this.SetAttributeValue("totalamount", value);
                this.OnPropertyChanged("TotalAmount");
            }
        }

        /// <summary>
        /// Shows the Total Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount_base");
            }
        }

        /// <summary>
        /// Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalAmountLessFreight");
                this.SetAttributeValue("totalamountlessfreight", value);
                this.OnPropertyChanged("TotalAmountLessFreight");
            }
        }

        /// <summary>
        /// Shows the Total Pre-Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight_base");
            }
        }

        /// <summary>
        /// Shows the total discount amount, based on the discount price and rate entered on the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalDiscountAmount");
                this.SetAttributeValue("totaldiscountamount", value);
                this.OnPropertyChanged("TotalDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Total Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount_base");
            }
        }

        /// <summary>
        /// Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalLineItemAmount");
                this.SetAttributeValue("totallineitemamount", value);
                this.OnPropertyChanged("TotalLineItemAmount");
            }
        }

        /// <summary>
        /// Shows the Total Detail Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount_base");
            }
        }

        /// <summary>
        /// Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalLineItemDiscountAmount");
                this.SetAttributeValue("totallineitemdiscountamount", value);
                this.OnPropertyChanged("TotalLineItemDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Total Line Item Discount Amount field to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount_base");
            }
        }

        /// <summary>
        /// Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax")]
        public Microsoft.Xrm.Sdk.Money TotalTax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalTax");
                this.SetAttributeValue("totaltax", value);
                this.OnPropertyChanged("TotalTax");
            }
        }

        /// <summary>
        /// Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax_base")]
        public Microsoft.Xrm.Sdk.Money TotalTax_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax_base");
            }
        }

        /// <summary>
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("traversedpath");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// 1:N btt_opportunity_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_opportunity_opportunity", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> Referencedbtt_opportunity_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_opportunity_opportunity", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedbtt_opportunity_opportunity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_opportunity_opportunity", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedbtt_opportunity_opportunity");
            }
        }

        /// <summary>
        /// 1:N opportunity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> opportunity_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("opportunity_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("opportunity_activity_parties", null, value);
                this.OnPropertyChanged("opportunity_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> Opportunity_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Opportunity_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Opportunity_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Opportunity_Appointments", null, value);
                this.OnPropertyChanged("Opportunity_Appointments");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Opportunity_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Opportunity_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Opportunity_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Opportunity_Emails", null, value);
                this.OnPropertyChanged("Opportunity_Emails");
            }
        }

        /// <summary>
        /// 1:N opportunity_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_quotes")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> opportunity_quotes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("opportunity_quotes", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_quotes");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("opportunity_quotes", null, value);
                this.OnPropertyChanged("opportunity_quotes");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> Opportunity_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Opportunity_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Opportunity_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Opportunity_Tasks", null, value);
                this.OnPropertyChanged("Opportunity_Tasks");
            }
        }

        /// <summary>
        /// N:N btt_opportunity_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_opportunity_systemuser")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser> btt_opportunity_systemuser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_opportunity_systemuser", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_opportunity_systemuser");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_opportunity_systemuser", null, value);
                this.OnPropertyChanged("btt_opportunity_systemuser");
            }
        }

        /// <summary>
        /// N:1 btt_accountplanner_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_involvedplannerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_accountplanner_opportunity")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account btt_accountplanner_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_accountplanner_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_accountplanner_opportunity");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_accountplanner_opportunity", null, value);
                this.OnPropertyChanged("btt_accountplanner_opportunity");
            }
        }

        /// <summary>
        /// N:1 btt_contactplanner_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_plannercontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_contactplanner_opportunity")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact btt_contactplanner_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_contactplanner_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_contactplanner_opportunity");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_contactplanner_opportunity", null, value);
                this.OnPropertyChanged("btt_contactplanner_opportunity");
            }
        }

        /// <summary>
        /// N:1 btt_opportunity_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_parentopportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_opportunity_opportunity", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity Referencingbtt_opportunity_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_opportunity_opportunity", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingbtt_opportunity_opportunity");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_opportunity_opportunity", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingbtt_opportunity_opportunity");
            }
        }

        /// <summary>
        /// N:1 btt_orb_country_opportunity_countryregion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_countryregion")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_country_opportunity_countryregion")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country btt_orb_country_opportunity_countryregion
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_opportunity_countryregion", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_country_opportunity_countryregion");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_opportunity_countryregion", null, value);
                this.OnPropertyChanged("btt_orb_country_opportunity_countryregion");
            }
        }

        /// <summary>
        /// N:1 btt_orb_productgroup_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_typeofproductid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_productgroup_opportunity")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup btt_orb_productgroup_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_orb_productgroup_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_productgroup_opportunity");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_orb_productgroup_opportunity", null, value);
                this.OnPropertyChanged("btt_orb_productgroup_opportunity");
            }
        }

        /// <summary>
        /// N:1 btt_productgroup_opportunity_ProductGroup2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productgroup2")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_productgroup_opportunity_ProductGroup2")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup btt_productgroup_opportunity_ProductGroup2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_productgroup_opportunity_ProductGroup2", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_productgroup_opportunity_ProductGroup2");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_productgroup_opportunity_ProductGroup2", null, value);
                this.OnPropertyChanged("btt_productgroup_opportunity_ProductGroup2");
            }
        }

        /// <summary>
        /// N:1 btt_productgroup_opportunity_ProductGroup3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productgroup3")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_productgroup_opportunity_ProductGroup3")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup btt_productgroup_opportunity_ProductGroup3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_productgroup_opportunity_ProductGroup3", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_productgroup_opportunity_ProductGroup3");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_productgroup_opportunity_ProductGroup3", null, value);
                this.OnPropertyChanged("btt_productgroup_opportunity_ProductGroup3");
            }
        }

        /// <summary>
        /// N:1 lk_opportunity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_opportunity_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunity_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunity_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_opportunity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_opportunity_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunity_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunity_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_opportunitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_opportunitybase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunitybase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunitybase_createdby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_opportunitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_opportunitybase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunitybase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_opportunitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 opportunity_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_accounts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account opportunity_customer_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("opportunity_customer_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_customer_accounts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("opportunity_customer_accounts", null, value);
                this.OnPropertyChanged("opportunity_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 opportunity_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_contacts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact opportunity_customer_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("opportunity_customer_contacts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_customer_contacts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("opportunity_customer_contacts", null, value);
                this.OnPropertyChanged("opportunity_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 opportunity_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser opportunity_owning_user
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("opportunity_owning_user", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_owning_user");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("opportunity_owning_user", null, value);
                this.OnPropertyChanged("opportunity_owning_user");
            }
        }

        /// <summary>
        /// N:1 opportunity_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_account")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account opportunity_parent_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("opportunity_parent_account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_parent_account");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("opportunity_parent_account", null, value);
                this.OnPropertyChanged("opportunity_parent_account");
            }
        }

        /// <summary>
        /// N:1 opportunity_parent_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_contact")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact opportunity_parent_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("opportunity_parent_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_parent_contact");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("opportunity_parent_contact", null, value);
                this.OnPropertyChanged("opportunity_parent_contact");
            }
        }

        /// <summary>
        /// N:1 rbtt_account_opportunity_SalesOrganization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_salesorganization")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_opportunity_SalesOrganization")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account rbtt_account_opportunity_SalesOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_opportunity_SalesOrganization", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_opportunity_SalesOrganization");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_opportunity_SalesOrganization", null, value);
                this.OnPropertyChanged("rbtt_account_opportunity_SalesOrganization");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_opportunity_ALid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_alid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_opportunity_ALid")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_opportunity_ALid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_opportunity_ALid", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_opportunity_ALid");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_opportunity_ALid", null, value);
                this.OnPropertyChanged("rbtt_orb_country_opportunity_ALid");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_opportunity_ConfigurationCountryId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_configurationcountryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_opportunity_ConfigurationCountryId")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_opportunity_ConfigurationCountryId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_opportunity_ConfigurationCountryId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_opportunity_ConfigurationCountryId");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_opportunity_ConfigurationCountryId", null, value);
                this.OnPropertyChanged("rbtt_orb_country_opportunity_ConfigurationCountryId");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_opportunity_OpportunityCountry
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_opportunitycountry")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_opportunity_OpportunityCountry")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_opportunity_OpportunityCountry
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_opportunity_OpportunityCountry", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_opportunity_OpportunityCountry");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_opportunity_OpportunityCountry", null, value);
                this.OnPropertyChanged("rbtt_orb_country_opportunity_OpportunityCountry");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_machine_opportunity_PlantLocationId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_plantlocationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_machine_opportunity_PlantLocationId")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine rbtt_orb_machine_opportunity_PlantLocationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_orb_machine_opportunity_PlantLocationId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_machine_opportunity_PlantLocationId");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_orb_machine_opportunity_PlantLocationId", null, value);
                this.OnPropertyChanged("rbtt_orb_machine_opportunity_PlantLocationId");
            }
        }

        /// <summary>
        /// N:1 rbtt_quote_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_quotetoopportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_quote_opportunity")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Quote rbtt_quote_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("rbtt_quote_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_quote_opportunity");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("rbtt_quote_opportunity", null, value);
                this.OnPropertyChanged("rbtt_quote_opportunity");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Opportunity(object anonymousType) :
                this()
        {
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();

                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int)value);
                    name = name.Remove(name.Length - "enum".Length);
                }

                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["opportunityid"] = base.Id;
                        break;
                    case "opportunityid":
                        var id = (System.Nullable<System.Guid>)value;
                        if (id == null) { continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
        }
    }
}