namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_classificationbaseState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Classification Base
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("orb_classificationbase")]
    public partial class Orb_classificationbase : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string Btt_appl_per_employee = "btt_appl_per_employee";
            public const string Btt_Calculationbasedon = "btt_calculationbasedon";
            public const string btt_CountryId = "btt_countryid";
            public const string Btt_Valueperappliance = "btt_valueperappliance";
            public const string btt_valueperappliance_Base = "btt_valueperappliance_base";
            public const string Btt_ValueperProductGroup = "btt_valueperproductgroup";
            public const string btt_valueperproductgroup_Base = "btt_valueperproductgroup_base";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string ExchangeRate = "exchangerate";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Orb_classificationbaseId = "orb_classificationbaseid";
            public const string Id = "orb_classificationbaseid";
            public const string Orb_Classificationtype = "orb_classificationtype";
            public const string Orb_estimatedturnover = "orb_estimatedturnover";
            public const string Orb_name = "orb_name";
            public const string Orb_potentialA = "orb_potentiala";
            public const string Orb_potentialAto = "orb_potentialato";
            public const string Orb_potentialb = "orb_potentialb";
            public const string Orb_potentialbto = "orb_potentialbto";
            public const string Orb_potentialc = "orb_potentialc";
            public const string Orb_potentialcto = "orb_potentialcto";
            public const string Orb_turnover1 = "orb_turnover1";
            public const string Orb_turnover1to = "orb_turnover1to";
            public const string Orb_turnover2 = "orb_turnover2";
            public const string Orb_turnover2to = "orb_turnover2to";
            public const string Orb_turnover3 = "orb_turnover3";
            public const string Orb_turnover3to = "orb_turnover3to";
            public const string Orb_turnover4 = "orb_turnover4";
            public const string Orb_turnover4to = "orb_turnover4to";
            public const string Orb_useofpotential1 = "orb_useofpotential1";
            public const string Orb_useofpotential2 = "orb_useofpotential2";
            public const string Orb_useofpotential3 = "orb_useofpotential3";
            public const string Orb_useofpotential4 = "orb_useofpotential4";
            public const string OrganizationId = "organizationid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string rbtt_useofpotential3 = "rbtt_useofpotential3";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string btt_orb_country_orb_classificationbase = "btt_orb_country_orb_classificationbase";
            public const string lk_orb_classificationbase_createdby = "lk_orb_classificationbase_createdby";
            public const string lk_orb_classificationbase_createdonbehalfby = "lk_orb_classificationbase_createdonbehalfby";
            public const string lk_orb_classificationbase_modifiedby = "lk_orb_classificationbase_modifiedby";
            public const string lk_orb_classificationbase_modifiedonbehalfby = "lk_orb_classificationbase_modifiedonbehalfby";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_classificationbase() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "orb_classificationbase";

        public const string EntitySchemaName = "Orb_classificationbase";

        public const string PrimaryIdAttribute = "orb_classificationbaseid";

        public const string PrimaryNameAttribute = "orb_name";

        public const string EntityLogicalCollectionName = "orb_classificationbases";

        public const string EntitySetName = "orb_classificationbases";

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
        /// Estimated No. of appliances per employee
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_appl_per_employee")]
        public System.Nullable<double> Btt_appl_per_employee
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_appl_per_employee");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_appl_per_employee");
                this.SetAttributeValue("btt_appl_per_employee", value);
                this.OnPropertyChanged("Btt_appl_per_employee");
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
        public virtual Orb_classificationbase_Btt_Calculationbasedon? Btt_CalculationbasedonEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_classificationbase_Btt_Calculationbasedon?)(EntityOptionSetEnum.GetEnum(this, "btt_calculationbasedon")));
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
        /// Unique identifier for Country associated with Classification Base.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_countryid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_CountryId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_countryid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CountryId");
                this.SetAttributeValue("btt_countryid", value);
                this.OnPropertyChanged("btt_CountryId");
            }
        }

        /// <summary>
        /// Estimated Value per appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_valueperappliance")]
        public Microsoft.Xrm.Sdk.Money Btt_Valueperappliance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_valueperappliance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Valueperappliance");
                this.SetAttributeValue("btt_valueperappliance", value);
                this.OnPropertyChanged("Btt_Valueperappliance");
            }
        }

        /// <summary>
        /// Value of the Estimated Value per appliance in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_valueperappliance_base")]
        public Microsoft.Xrm.Sdk.Money btt_valueperappliance_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_valueperappliance_base");
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
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classificationbaseid")]
        public System.Nullable<System.Guid> Orb_classificationbaseId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("orb_classificationbaseid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_classificationbaseId");
                this.SetAttributeValue("orb_classificationbaseid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("Orb_classificationbaseId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classificationbaseid")]
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
                this.Orb_classificationbaseId = value;
            }
        }

        /// <summary>
        /// Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classificationtype")]
        public System.Nullable<bool> Orb_Classificationtype
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_classificationtype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_Classificationtype");
                this.SetAttributeValue("orb_classificationtype", value);
                this.OnPropertyChanged("Orb_Classificationtype");
            }
        }

        /// <summary>
        /// Estimated Turnover
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_estimatedturnover")]
        public System.Nullable<double> Orb_estimatedturnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_estimatedturnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_estimatedturnover");
                this.SetAttributeValue("orb_estimatedturnover", value);
                this.OnPropertyChanged("Orb_estimatedturnover");
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
        /// Border: x2 - x1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentiala")]
        public System.Nullable<double> Orb_potentialA
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentiala");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentialA");
                this.SetAttributeValue("orb_potentiala", value);
                this.OnPropertyChanged("Orb_potentialA");
            }
        }

        /// <summary>
        /// Potential A to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentialato")]
        public System.Nullable<double> Orb_potentialAto
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentialato");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentialAto");
                this.SetAttributeValue("orb_potentialato", value);
                this.OnPropertyChanged("Orb_potentialAto");
            }
        }

        /// <summary>
        /// Border: x3 - x2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentialb")]
        public System.Nullable<double> Orb_potentialb
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentialb");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentialb");
                this.SetAttributeValue("orb_potentialb", value);
                this.OnPropertyChanged("Orb_potentialb");
            }
        }

        /// <summary>
        /// Potential B to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentialbto")]
        public System.Nullable<double> Orb_potentialbto
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentialbto");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentialbto");
                this.SetAttributeValue("orb_potentialbto", value);
                this.OnPropertyChanged("Orb_potentialbto");
            }
        }

        /// <summary>
        /// Potential C
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentialc")]
        public System.Nullable<double> Orb_potentialc
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentialc");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentialc");
                this.SetAttributeValue("orb_potentialc", value);
                this.OnPropertyChanged("Orb_potentialc");
            }
        }

        /// <summary>
        /// Potential C to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentialcto")]
        public System.Nullable<double> Orb_potentialcto
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentialcto");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentialcto");
                this.SetAttributeValue("orb_potentialcto", value);
                this.OnPropertyChanged("Orb_potentialcto");
            }
        }

        /// <summary>
        /// Turnover 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover1")]
        public System.Nullable<double> Orb_turnover1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover1");
                this.SetAttributeValue("orb_turnover1", value);
                this.OnPropertyChanged("Orb_turnover1");
            }
        }

        /// <summary>
        /// Turnover 1 to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover1to")]
        public System.Nullable<double> Orb_turnover1to
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover1to");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover1to");
                this.SetAttributeValue("orb_turnover1to", value);
                this.OnPropertyChanged("Orb_turnover1to");
            }
        }

        /// <summary>
        /// Turnover 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover2")]
        public System.Nullable<double> Orb_turnover2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover2");
                this.SetAttributeValue("orb_turnover2", value);
                this.OnPropertyChanged("Orb_turnover2");
            }
        }

        /// <summary>
        /// Turnover 2 to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover2to")]
        public System.Nullable<double> Orb_turnover2to
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover2to");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover2to");
                this.SetAttributeValue("orb_turnover2to", value);
                this.OnPropertyChanged("Orb_turnover2to");
            }
        }

        /// <summary>
        /// Turnover 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover3")]
        public System.Nullable<double> Orb_turnover3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover3");
                this.SetAttributeValue("orb_turnover3", value);
                this.OnPropertyChanged("Orb_turnover3");
            }
        }

        /// <summary>
        /// Turnover 3 to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover3to")]
        public System.Nullable<double> Orb_turnover3to
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover3to");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover3to");
                this.SetAttributeValue("orb_turnover3to", value);
                this.OnPropertyChanged("Orb_turnover3to");
            }
        }

        /// <summary>
        /// Turnover 4
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover4")]
        public System.Nullable<double> Orb_turnover4
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover4");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover4");
                this.SetAttributeValue("orb_turnover4", value);
                this.OnPropertyChanged("Orb_turnover4");
            }
        }

        /// <summary>
        /// Turnover 4 to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_turnover4to")]
        public System.Nullable<double> Orb_turnover4to
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_turnover4to");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_turnover4to");
                this.SetAttributeValue("orb_turnover4to", value);
                this.OnPropertyChanged("Orb_turnover4to");
            }
        }

        /// <summary>
        /// Border: A - B
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_useofpotential1")]
        public System.Nullable<double> Orb_useofpotential1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_useofpotential1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_useofpotential1");
                this.SetAttributeValue("orb_useofpotential1", value);
                this.OnPropertyChanged("Orb_useofpotential1");
            }
        }

        /// <summary>
        /// Border:  B - C
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_useofpotential2")]
        public System.Nullable<double> Orb_useofpotential2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_useofpotential2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_useofpotential2");
                this.SetAttributeValue("orb_useofpotential2", value);
                this.OnPropertyChanged("Orb_useofpotential2");
            }
        }

        /// <summary>
        /// Use Of Potential 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_useofpotential3")]
        public System.Nullable<double> Orb_useofpotential3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_useofpotential3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_useofpotential3");
                this.SetAttributeValue("orb_useofpotential3", value);
                this.OnPropertyChanged("Orb_useofpotential3");
            }
        }

        /// <summary>
        /// Use Of Potential 4
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_useofpotential4")]
        public System.Nullable<double> Orb_useofpotential4
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_useofpotential4");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_useofpotential4");
                this.SetAttributeValue("orb_useofpotential4", value);
                this.OnPropertyChanged("Orb_useofpotential4");
            }
        }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
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
        /// Border: C - D
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_useofpotential3")]
        public System.Nullable<double> rbtt_useofpotential3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("rbtt_useofpotential3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_useofpotential3");
                this.SetAttributeValue("rbtt_useofpotential3", value);
                this.OnPropertyChanged("rbtt_useofpotential3");
            }
        }

        /// <summary>
        /// Status of the ClassificationBase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbaseState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbaseState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbaseState), optionSet.Value)));
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
        /// Reason for the status of the ClassificationBase
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
        /// Reason for the status of the ClassificationBase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Orb_classificationbase_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_classificationbase_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N orb_classificationbase_visitplanningbase
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_classificationbase_visitplanningbase")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase> orb_classificationbase_visitplanningbase
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("orb_classificationbase_visitplanningbase", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_classificationbase_visitplanningbase");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("orb_classificationbase_visitplanningbase", null, value);
                this.OnPropertyChanged("orb_classificationbase_visitplanningbase");
            }
        }

        /// <summary>
        /// 1:N orb_orb_classificationbase_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_classificationbase_account")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> orb_orb_classificationbase_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_orb_classificationbase_account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_classificationbase_account");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_orb_classificationbase_account", null, value);
                this.OnPropertyChanged("orb_orb_classificationbase_account");
            }
        }

        /// <summary>
        /// 1:N orb_orb_classificationbase_orb_productgroupcl
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_classificationbase_orb_productgroupcl")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> orb_orb_classificationbase_orb_productgroupcl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("orb_orb_classificationbase_orb_productgroupcl", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_classificationbase_orb_productgroupcl");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("orb_orb_classificationbase_orb_productgroupcl", null, value);
                this.OnPropertyChanged("orb_orb_classificationbase_orb_productgroupcl");
            }
        }

        /// <summary>
        /// N:1 btt_orb_country_orb_classificationbase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_countryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_country_orb_classificationbase")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country btt_orb_country_orb_classificationbase
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_orb_classificationbase", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_country_orb_classificationbase");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_orb_classificationbase", null, value);
                this.OnPropertyChanged("btt_orb_country_orb_classificationbase");
            }
        }

        /// <summary>
        /// N:1 lk_orb_classificationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_classificationbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_createdby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_classificationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_classificationbase_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_classificationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_classificationbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_classificationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_classificationbase_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_classificationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_classificationbase(object anonymousType) :
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
                        Attributes["orb_classificationbaseid"] = base.Id;
                        break;
                    case "orb_classificationbaseid":
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