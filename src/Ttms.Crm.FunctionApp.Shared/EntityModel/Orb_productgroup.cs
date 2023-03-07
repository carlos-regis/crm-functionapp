namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_productgroupState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Product Group
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("orb_productgroup")]
    public partial class Orb_productgroup : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string btt_CountryId = "btt_countryid";
            public const string btt_ProductGroupId = "btt_productgroupid";
            public const string btt_productmaingroupid = "btt_productmaingroupid";
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
            public const string Orb_Code = "orb_code";
            public const string orb_maincompetitorid = "orb_maincompetitorid";
            public const string Orb_name = "orb_name";
            public const string Orb_productgroupId = "orb_productgroupid";
            public const string Id = "orb_productgroupid";
            public const string orb_targetgroupid = "orb_targetgroupid";
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
            public const string btt_orb_country_orb_productgroup = "btt_orb_country_orb_productgroup";
            public const string lk_orb_productgroup_createdby = "lk_orb_productgroup_createdby";
            public const string lk_orb_productgroup_createdonbehalfby = "lk_orb_productgroup_createdonbehalfby";
            public const string lk_orb_productgroup_modifiedby = "lk_orb_productgroup_modifiedby";
            public const string lk_orb_productgroup_modifiedonbehalfby = "lk_orb_productgroup_modifiedonbehalfby";
            public const string orb_contact_orb_productgroup = "orb_contact_orb_productgroup";
            public const string user_orb_productgroup = "user_orb_productgroup";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_productgroup() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "orb_productgroup";

        public const string EntitySchemaName = "Orb_productgroup";

        public const string PrimaryIdAttribute = "orb_productgroupid";

        public const string PrimaryNameAttribute = "orb_name";

        public const string EntityLogicalCollectionName = "orb_productgroups";

        public const string EntitySetName = "orb_productgroups";

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
        /// Unique identifier for Country associated with Product Group.
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
        /// Unique identifier for Opportunity Product Group associated with Product Group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productgroupid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_ProductGroupId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_productgroupid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_ProductGroupId");
                this.SetAttributeValue("btt_productgroupid", value);
                this.OnPropertyChanged("btt_ProductGroupId");
            }
        }

        /// <summary>
        /// Unique identifier of Product main group related to Product group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productmaingroupid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_productmaingroupid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_productmaingroupid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_productmaingroupid");
                this.SetAttributeValue("btt_productmaingroupid", value);
                this.OnPropertyChanged("btt_productmaingroupid");
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
        /// Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_code")]
        public string Orb_Code
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_code");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_Code");
                this.SetAttributeValue("orb_code", value);
                this.OnPropertyChanged("Orb_Code");
            }
        }

        /// <summary>
        /// lookup to the main competitor
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
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_productgroupid")]
        public System.Nullable<System.Guid> Orb_productgroupId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("orb_productgroupid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_productgroupId");
                this.SetAttributeValue("orb_productgroupid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("Orb_productgroupId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_productgroupid")]
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
                this.Orb_productgroupId = value;
            }
        }

        /// <summary>
        /// Unique identifier for Contact associated with Product Group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_targetgroupid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_targetgroupid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_targetgroupid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_targetgroupid");
                this.SetAttributeValue("orb_targetgroupid", value);
                this.OnPropertyChanged("orb_targetgroupid");
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
        /// Status of the Product Group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupState), optionSet.Value)));
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
        /// Reason for the status of the Product Group
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
        /// Reason for the status of the Product Group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Orb_productgroup_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_productgroup_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N btt_orb_productgroup_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_productgroup_opportunity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> btt_orb_productgroup_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_orb_productgroup_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_productgroup_opportunity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_orb_productgroup_opportunity", null, value);
                this.OnPropertyChanged("btt_orb_productgroup_opportunity");
            }
        }

        /// <summary>
        /// 1:N btt_orb_productgroup_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_productgroup_orb_machine")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> btt_orb_productgroup_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("btt_orb_productgroup_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_productgroup_orb_machine");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("btt_orb_productgroup_orb_machine", null, value);
                this.OnPropertyChanged("btt_orb_productgroup_orb_machine");
            }
        }

        /// <summary>
        /// 1:N btt_productgroup_opportunity_ProductGroup2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_productgroup_opportunity_ProductGroup2")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> btt_productgroup_opportunity_ProductGroup2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_productgroup_opportunity_ProductGroup2", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_productgroup_opportunity_ProductGroup2");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_productgroup_opportunity_ProductGroup2", null, value);
                this.OnPropertyChanged("btt_productgroup_opportunity_ProductGroup2");
            }
        }

        /// <summary>
        /// 1:N btt_productgroup_opportunity_ProductGroup3
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_productgroup_opportunity_ProductGroup3")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> btt_productgroup_opportunity_ProductGroup3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_productgroup_opportunity_ProductGroup3", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_productgroup_opportunity_ProductGroup3");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_productgroup_opportunity_ProductGroup3", null, value);
                this.OnPropertyChanged("btt_productgroup_opportunity_ProductGroup3");
            }
        }

        /// <summary>
        /// 1:N orb_orb_productgroup_orb_productgroupclassifi
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_productgroup_orb_productgroupclassifi")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> orb_orb_productgroup_orb_productgroupclassifi
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("orb_orb_productgroup_orb_productgroupclassifi", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_productgroup_orb_productgroupclassifi");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("orb_orb_productgroup_orb_productgroupclassifi", null, value);
                this.OnPropertyChanged("orb_orb_productgroup_orb_productgroupclassifi");
            }
        }

        /// <summary>
        /// 1:N orb_orb_productgroup_product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_productgroup_product")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> orb_orb_productgroup_product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("orb_orb_productgroup_product", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_productgroup_product");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("orb_orb_productgroup_product", null, value);
                this.OnPropertyChanged("orb_orb_productgroup_product");
            }
        }

        /// <summary>
        /// 1:N ttpoico_orb_productgroup_quote_PG1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ttpoico_orb_productgroup_quote_PG1")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> ttpoico_orb_productgroup_quote_PG1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("ttpoico_orb_productgroup_quote_PG1", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_orb_productgroup_quote_PG1");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("ttpoico_orb_productgroup_quote_PG1", null, value);
                this.OnPropertyChanged("ttpoico_orb_productgroup_quote_PG1");
            }
        }

        /// <summary>
        /// 1:N ttpoico_orb_productgroup_quote_PG2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ttpoico_orb_productgroup_quote_PG2")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> ttpoico_orb_productgroup_quote_PG2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("ttpoico_orb_productgroup_quote_PG2", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_orb_productgroup_quote_PG2");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("ttpoico_orb_productgroup_quote_PG2", null, value);
                this.OnPropertyChanged("ttpoico_orb_productgroup_quote_PG2");
            }
        }

        /// <summary>
        /// 1:N ttpoico_orb_productgroup_quote_PG3
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ttpoico_orb_productgroup_quote_PG3")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> ttpoico_orb_productgroup_quote_PG3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("ttpoico_orb_productgroup_quote_PG3", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_orb_productgroup_quote_PG3");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("ttpoico_orb_productgroup_quote_PG3", null, value);
                this.OnPropertyChanged("ttpoico_orb_productgroup_quote_PG3");
            }
        }

        /// <summary>
        /// N:1 btt_orb_country_orb_productgroup
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_countryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_country_orb_productgroup")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country btt_orb_country_orb_productgroup
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_orb_productgroup", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_country_orb_productgroup");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_orb_productgroup", null, value);
                this.OnPropertyChanged("btt_orb_country_orb_productgroup");
            }
        }

        /// <summary>
        /// N:1 lk_orb_productgroup_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroup_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_createdby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_productgroup_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroup_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_productgroup_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroup_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_productgroup_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_productgroup_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_productgroup_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 orb_contact_orb_productgroup
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_targetgroupid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_contact_orb_productgroup")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact orb_contact_orb_productgroup
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("orb_contact_orb_productgroup", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_contact_orb_productgroup");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("orb_contact_orb_productgroup", null, value);
                this.OnPropertyChanged("orb_contact_orb_productgroup");
            }
        }

        /// <summary>
        /// N:1 user_orb_productgroup
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orb_productgroup")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_orb_productgroup
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_orb_productgroup", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_orb_productgroup");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_orb_productgroup", null, value);
                this.OnPropertyChanged("user_orb_productgroup");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_productgroup(object anonymousType) :
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
                        Attributes["orb_productgroupid"] = base.Id;
                        break;
                    case "orb_productgroupid":
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