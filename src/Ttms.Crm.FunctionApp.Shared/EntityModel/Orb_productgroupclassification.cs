namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_productgroupclassificationState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Entity for detail account classification on product group level
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("orb_productgroupclassification")]
    public partial class Orb_productgroupclassification : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string Btt_2ndCompetitorShare = "btt_2ndcompetitorshare";
            public const string Btt_3rdCompetitorSharein = "btt_3rdcompetitorsharein";
            public const string Btt_BuderusShare = "btt_buderusshare";
            public const string Btt_BuyBuderus = "btt_buybuderus";
            public const string Btt_Buyelmleblanc = "btt_buyelmleblanc";
            public const string Btt_BuyGeminox = "btt_buygeminox";
            public const string Btt_Calculationbasedon = "btt_calculationbasedon";
            public const string Btt_elmleblancShare = "btt_elmleblancshare";
            public const string Btt_GeminoxShare = "btt_geminoxshare";
            public const string btt_secondcompetitorid = "btt_secondcompetitorid";
            public const string Btt_target = "btt_target";
            public const string btt_target_Base = "btt_target_base";
            public const string Btt_targetnumberofappliances = "btt_targetnumberofappliances";
            public const string Btt_Totalnumberappl = "btt_totalnumberappl";
            public const string Btt_Totalpotential = "btt_totalpotential";
            public const string btt_totalpotential_Base = "btt_totalpotential_base";
            public const string Btt_TT_numberappl = "btt_tt_numberappl";
            public const string Btt_TT_Turnover = "btt_tt_turnover";
            public const string btt_tt_turnover_Base = "btt_tt_turnover_base";
            public const string Btt_ValueperProductGroup = "btt_valueperproductgroup";
            public const string btt_valueperproductgroup_Base = "btt_valueperproductgroup_base";
            public const string Btt_Workswith = "btt_workswith";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string ExchangeRate = "exchangerate";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string orb_accountid = "orb_accountid";
            public const string Orb_classification = "orb_classification";
            public const string orb_classificationbaseid = "orb_classificationbaseid";
            public const string Orb_competitorpotential = "orb_competitorpotential";
            public const string orb_maincompetitorid = "orb_maincompetitorid";
            public const string Orb_name = "orb_name";
            public const string Orb_potential = "orb_potential";
            public const string Orb_productgroupclassificationId = "orb_productgroupclassificationid";
            public const string Id = "orb_productgroupclassificationid";
            public const string orb_productgroupid = "orb_productgroupid";
            public const string Orb_reorgflag = "orb_reorgflag";
            public const string Orb_Turnover = "orb_turnover";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_orb_productgroupclassification_createdby = "lk_orb_productgroupclassification_createdby";
            public const string lk_orb_productgroupclassification_createdonbehalfby = "lk_orb_productgroupclassification_createdonbehalfby";
            public const string lk_orb_productgroupclassification_modifiedby = "lk_orb_productgroupclassification_modifiedby";
            public const string lk_orb_productgroupclassification_modifiedonbehalfby = "lk_orb_productgroupclassification_modifiedonbehalfby";
            public const string orb_account_orb_productgroupclassification = "orb_account_orb_productgroupclassification";
            public const string orb_orb_classificationbase_orb_productgroupcl = "orb_orb_classificationbase_orb_productgroupcl";
            public const string orb_orb_productgroup_orb_productgroupclassifi = "orb_orb_productgroup_orb_productgroupclassifi";
            public const string user_orb_productgroupclassification = "user_orb_productgroupclassification";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_productgroupclassification() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "orb_productgroupclassification";

        public const string EntitySchemaName = "Orb_productgroupclassification";

        public const string PrimaryIdAttribute = "orb_productgroupclassificationid";

        public const string PrimaryNameAttribute = "orb_name";

        public const string EntityLogicalCollectionName = "orb_productgroupclassifications";

        public const string EntitySetName = "orb_productgroupclassifications";

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
        /// 2nd Competitor Share in %
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_2ndcompetitorshare")]
        public System.Nullable<double> Btt_2ndCompetitorShare
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_2ndcompetitorshare");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_2ndCompetitorShare");
                this.SetAttributeValue("btt_2ndcompetitorshare", value);
                this.OnPropertyChanged("Btt_2ndCompetitorShare");
            }
        }

        /// <summary>
        /// 3rd Competitor Share in %
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_3rdcompetitorsharein")]
        public System.Nullable<double> Btt_3rdCompetitorSharein
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_3rdcompetitorsharein");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_3rdCompetitorSharein");
                this.SetAttributeValue("btt_3rdcompetitorsharein", value);
                this.OnPropertyChanged("Btt_3rdCompetitorSharein");
            }
        }

        /// <summary>
        /// Buderus No. of appliances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_buderusshare")]
        public System.Nullable<int> Btt_BuderusShare
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_buderusshare");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_BuderusShare");
                this.SetAttributeValue("btt_buderusshare", value);
                this.OnPropertyChanged("Btt_BuderusShare");
            }
        }

        /// <summary>
        /// Buy Buderus
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_buybuderus")]
        public System.Nullable<bool> Btt_BuyBuderus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_buybuderus");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_BuyBuderus");
                this.SetAttributeValue("btt_buybuderus", value);
                this.OnPropertyChanged("Btt_BuyBuderus");
            }
        }

        /// <summary>
        /// Buy elm leblanc
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_buyelmleblanc")]
        public System.Nullable<bool> Btt_Buyelmleblanc
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_buyelmleblanc");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Buyelmleblanc");
                this.SetAttributeValue("btt_buyelmleblanc", value);
                this.OnPropertyChanged("Btt_Buyelmleblanc");
            }
        }

        /// <summary>
        /// Buy Geminox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_buygeminox")]
        public System.Nullable<bool> Btt_BuyGeminox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_buygeminox");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_BuyGeminox");
                this.SetAttributeValue("btt_buygeminox", value);
                this.OnPropertyChanged("Btt_BuyGeminox");
            }
        }

        /// <summary>
        /// Indicates whether the ABC calculation is based on amount of money OR on the number of appliances.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_calculationbasedon")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Calculationbasedon
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_calculationbasedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Calculationbasedon");
                this.SetAttributeValue("btt_calculationbasedon", value);
                this.OnPropertyChanged("Btt_Calculationbasedon");
            }
        }

        /// <summary>
        /// Indicates whether the ABC calculation is based on amount of money OR on the number of appliances.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_calculationbasedon")]
        public virtual Orb_productgroupclassification_Btt_Calculationbasedon? Btt_CalculationbasedonEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_productgroupclassification_Btt_Calculationbasedon?)(EntityOptionSetEnum.GetEnum(this, "btt_calculationbasedon")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Calculationbasedon");
                this.SetAttributeValue("btt_calculationbasedon", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Calculationbasedon");
            }
        }

        /// <summary>
        /// elm leblanc No. of appliances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_elmleblancshare")]
        public System.Nullable<int> Btt_elmleblancShare
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_elmleblancshare");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_elmleblancShare");
                this.SetAttributeValue("btt_elmleblancshare", value);
                this.OnPropertyChanged("Btt_elmleblancShare");
            }
        }

        /// <summary>
        /// Geminox No. of appliances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_geminoxshare")]
        public System.Nullable<int> Btt_GeminoxShare
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_geminoxshare");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_GeminoxShare");
                this.SetAttributeValue("btt_geminoxshare", value);
                this.OnPropertyChanged("Btt_GeminoxShare");
            }
        }

        /// <summary>
        /// Unique identifier for Competitor associated with Product Group Classification.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_secondcompetitorid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_secondcompetitorid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_secondcompetitorid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_secondcompetitorid");
                this.SetAttributeValue("btt_secondcompetitorid", value);
                this.OnPropertyChanged("btt_secondcompetitorid");
            }
        }

        /// <summary>
        /// Target
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_target")]
        public Microsoft.Xrm.Sdk.Money Btt_target
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_target");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_target");
                this.SetAttributeValue("btt_target", value);
                this.OnPropertyChanged("Btt_target");
            }
        }

        /// <summary>
        /// Value of the Target in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_target_base")]
        public Microsoft.Xrm.Sdk.Money btt_target_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_target_base");
            }
        }

        /// <summary>
        /// Target number of appliances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_targetnumberofappliances")]
        public System.Nullable<double> Btt_targetnumberofappliances
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_targetnumberofappliances");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_targetnumberofappliances");
                this.SetAttributeValue("btt_targetnumberofappliances", value);
                this.OnPropertyChanged("Btt_targetnumberofappliances");
            }
        }

        /// <summary>
        /// Total number of appliances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalnumberappl")]
        public System.Nullable<double> Btt_Totalnumberappl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_totalnumberappl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Totalnumberappl");
                this.SetAttributeValue("btt_totalnumberappl", value);
                this.OnPropertyChanged("Btt_Totalnumberappl");
            }
        }

        /// <summary>
        /// Total potential Y-1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential")]
        public Microsoft.Xrm.Sdk.Money Btt_Totalpotential
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Totalpotential");
                this.SetAttributeValue("btt_totalpotential", value);
                this.OnPropertyChanged("Btt_Totalpotential");
            }
        }

        /// <summary>
        /// Value of the Total potential in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential_base")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotential_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential_base");
            }
        }

        /// <summary>
        /// TT number of appliances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_numberappl")]
        public System.Nullable<double> Btt_TT_numberappl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_tt_numberappl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TT_numberappl");
                this.SetAttributeValue("btt_tt_numberappl", value);
                this.OnPropertyChanged("Btt_TT_numberappl");
            }
        }

        /// <summary>
        /// TT Turnover Y-1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover")]
        public Microsoft.Xrm.Sdk.Money Btt_TT_Turnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TT_Turnover");
                this.SetAttributeValue("btt_tt_turnover", value);
                this.OnPropertyChanged("Btt_TT_Turnover");
            }
        }

        /// <summary>
        /// Value of the TT Turnover in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover_base")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnover_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover_base");
            }
        }

        /// <summary>
        /// Value per Product Group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_valueperproductgroup")]
        public Microsoft.Xrm.Sdk.Money Btt_ValueperProductGroup
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_valueperproductgroup");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ValueperProductGroup");
                this.SetAttributeValue("btt_valueperproductgroup", value);
                this.OnPropertyChanged("Btt_ValueperProductGroup");
            }
        }

        /// <summary>
        /// Value of the Value per Product Group in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_valueperproductgroup_base")]
        public Microsoft.Xrm.Sdk.Money btt_valueperproductgroup_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_valueperproductgroup_base");
            }
        }

        /// <summary>
        /// Describes how strong the customer works with the particular product group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_workswith")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Workswith
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_workswith");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Workswith");
                this.SetAttributeValue("btt_workswith", value);
                this.OnPropertyChanged("Btt_Workswith");
            }
        }

        /// <summary>
        /// Describes how strong the customer works with the particular product group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_workswith")]
        public virtual Orb_productgroupclassification_Btt_Workswith? Btt_WorkswithEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_productgroupclassification_Btt_Workswith?)(EntityOptionSetEnum.GetEnum(this, "btt_workswith")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Workswith");
                this.SetAttributeValue("btt_workswith", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Workswith");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the record.
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
        /// Date and time when the record was created.
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
        /// Unique identifier of the delegate user who created the record.
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
        /// Exchange rate for the currency associated with the entity with respect to the base currency.
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
        /// Sequence number of the import that created this record.
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
        /// Unique identifier of the user who modified the record.
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
        /// Date and time when the record was modified.
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
        /// Unique identifier of the delegate user who modified the record.
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
        /// Unique identifier for Account associated with Product Group Classification.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_accountid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_accountid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_accountid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_accountid");
                this.SetAttributeValue("orb_accountid", value);
                this.OnPropertyChanged("orb_accountid");
            }
        }

        /// <summary>
        /// ABC Status
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classification")]
        public string Orb_classification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_classification");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_classification");
                this.SetAttributeValue("orb_classification", value);
                this.OnPropertyChanged("Orb_classification");
            }
        }

        /// <summary>
        /// Unique identifier for ClassificationBase associated with Product Group Classification.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classificationbaseid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_classificationbaseid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_classificationbaseid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_classificationbaseid");
                this.SetAttributeValue("orb_classificationbaseid", value);
                this.OnPropertyChanged("orb_classificationbaseid");
            }
        }

        /// <summary>
        /// Main Competitor Share in %
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_competitorpotential")]
        public System.Nullable<double> Orb_competitorpotential
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_competitorpotential");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_competitorpotential");
                this.SetAttributeValue("orb_competitorpotential", value);
                this.OnPropertyChanged("Orb_competitorpotential");
            }
        }

        /// <summary>
        /// Look up to the competitor base.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_maincompetitorid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_maincompetitorid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_maincompetitorid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_maincompetitorid");
                this.SetAttributeValue("orb_maincompetitorid", value);
                this.OnPropertyChanged("orb_maincompetitorid");
            }
        }

        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_name")]
        public string Orb_name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_name");
                this.SetAttributeValue("orb_name", value);
                this.OnPropertyChanged("Orb_name");
            }
        }

        /// <summary>
        /// Total number of appliances per year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potential")]
        public System.Nullable<double> Orb_potential
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potential");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potential");
                this.SetAttributeValue("orb_potential", value);
                this.OnPropertyChanged("Orb_potential");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_productgroupclassificationid")]
        public System.Nullable<System.Guid> Orb_productgroupclassificationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("orb_productgroupclassificationid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_productgroupclassificationId");
                this.SetAttributeValue("orb_productgroupclassificationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("Orb_productgroupclassificationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_productgroupclassificationid")]
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
                this.Orb_productgroupclassificationId = value;
            }
        }

        /// <summary>
        /// Unique identifier for Product Group associated with Product Group Classification.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_productgroupid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_productgroupid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_productgroupid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_productgroupid");
                this.SetAttributeValue("orb_productgroupid", value);
                this.OnPropertyChanged("orb_productgroupid");
            }
        }

        /// <summary>
        /// Reorg Flag
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_reorgflag")]
        public System.Nullable<bool> Orb_reorgflag
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_reorgflag");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_reorgflag");
                this.SetAttributeValue("orb_reorgflag", value);
                this.OnPropertyChanged("Orb_reorgflag");
            }
        }

        /// <summary>
        /// TT number of appliances per year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover")]
        public System.Nullable<double> Orb_Turnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_Turnover");
                this.SetAttributeValue("orb_turnover", value);
                this.OnPropertyChanged("Orb_Turnover");
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
        /// Owner Id
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
        /// Unique identifier for the business unit that owns the record
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
        /// Unique identifier for the team that owns the record.
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
        /// Unique identifier for the user that owns the record.
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
        /// Status of the Product Group Classification
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassificationState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassificationState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassificationState), optionSet.Value)));
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
        /// Reason for the status of the Product Group Classification
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
        /// Reason for the status of the Product Group Classification
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Orb_productgroupclassification_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_productgroupclassification_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// Unique identifier of the currency associated with the entity.
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
        /// Version Number
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
        /// N:1 lk_orb_productgroupclassification_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroupclassification_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_createdby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_productgroupclassification_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroupclassification_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_productgroupclassification_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroupclassification_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_productgroupclassification_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroupclassification_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroupclassification_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 orb_account_orb_productgroupclassification
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_accountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_account_orb_productgroupclassification")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account orb_account_orb_productgroupclassification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_account_orb_productgroupclassification", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_account_orb_productgroupclassification");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_account_orb_productgroupclassification", null, value);
                this.OnPropertyChanged("orb_account_orb_productgroupclassification");
            }
        }

        /// <summary>
        /// N:1 orb_orb_classificationbase_orb_productgroupcl
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classificationbaseid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_classificationbase_orb_productgroupcl")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase orb_orb_classificationbase_orb_productgroupcl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("orb_orb_classificationbase_orb_productgroupcl", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_classificationbase_orb_productgroupcl");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("orb_orb_classificationbase_orb_productgroupcl", null, value);
                this.OnPropertyChanged("orb_orb_classificationbase_orb_productgroupcl");
            }
        }

        /// <summary>
        /// N:1 orb_orb_productgroup_orb_productgroupclassifi
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_productgroupid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_productgroup_orb_productgroupclassifi")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup orb_orb_productgroup_orb_productgroupclassifi
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("orb_orb_productgroup_orb_productgroupclassifi", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_productgroup_orb_productgroupclassifi");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("orb_orb_productgroup_orb_productgroupclassifi", null, value);
                this.OnPropertyChanged("orb_orb_productgroup_orb_productgroupclassifi");
            }
        }

        /// <summary>
        /// N:1 user_orb_productgroupclassification
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orb_productgroupclassification")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_orb_productgroupclassification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_orb_productgroupclassification", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_orb_productgroupclassification");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_orb_productgroupclassification", null, value);
                this.OnPropertyChanged("user_orb_productgroupclassification");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_productgroupclassification(object anonymousType) :
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
                        Attributes["orb_productgroupclassificationid"] = base.Id;
                        break;
                    case "orb_productgroupclassificationid":
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