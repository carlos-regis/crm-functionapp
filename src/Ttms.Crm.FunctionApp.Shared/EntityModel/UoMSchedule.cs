namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum UoMScheduleState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Grouping of units.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uomschedule")]
    public partial class UoMSchedule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string BaseUoMName = "baseuomname";
            public const string CreatedBy = "createdby";
            public const string CreatedByExternalParty = "createdbyexternalparty";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string Description = "description";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByExternalParty = "modifiedbyexternalparty";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UoMScheduleId = "uomscheduleid";
            public const string Id = "uomscheduleid";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_uomschedule_createdonbehalfby = "lk_uomschedule_createdonbehalfby";
            public const string lk_uomschedule_modifiedonbehalfby = "lk_uomschedule_modifiedonbehalfby";
            public const string lk_uomschedulebase_createdby = "lk_uomschedulebase_createdby";
            public const string lk_uomschedulebase_modifiedby = "lk_uomschedulebase_modifiedby";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public UoMSchedule() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "uomschedule";

        public const string EntitySchemaName = "UoMSchedule";

        public const string PrimaryIdAttribute = "uomscheduleid";

        public const string PrimaryNameAttribute = "name";

        public const string EntityLogicalCollectionName = "uomschedules";

        public const string EntitySetName = "uomschedules";

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
        /// Name of the base unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuomname")]
        public string BaseUoMName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("baseuomname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BaseUoMName");
                this.SetAttributeValue("baseuomname", value);
                this.OnPropertyChanged("BaseUoMName");
            }
        }

        /// <summary>
        /// lk_uomschedulebase_createdby
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
        /// Shows the external party who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
            }
        }

        /// <summary>
        /// Date and time when the unit group was created.
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
        /// lk_uomschedulebase_createdonbehalfby
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
        /// Description of the unit group.
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
        /// lk_uomschedulebase_modifiedby
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
        /// Shows the external party who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
            }
        }

        /// <summary>
        /// Date and time when the unit group was last modified.
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
        /// lk_uomschedulebase_modifiedonbehalfby
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
        /// Name of the unit group.
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
        /// organization_uof_schedules
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
        /// Status of the Unit Group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMScheduleState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.UoMScheduleState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.UoMScheduleState), optionSet.Value)));
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
        /// Reason for the status of the Unit Group.
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
        /// Reason for the status of the Unit Group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual UoMSchedule_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((UoMSchedule_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// Unique identifier for the unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        public System.Nullable<System.Guid> UoMScheduleId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("uomscheduleid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UoMScheduleId");
                this.SetAttributeValue("uomscheduleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UoMScheduleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
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
                this.UoMScheduleId = value;
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
        /// Version number of the unit group.
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
        /// 1:N unit_of_measure_schedule_conversions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_conversions")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM> unit_of_measure_schedule_conversions
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measure_schedule_conversions", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("unit_of_measure_schedule_conversions");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measure_schedule_conversions", null, value);
                this.OnPropertyChanged("unit_of_measure_schedule_conversions");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_schedule_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_schedule_products")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> unit_of_measurement_schedule_products
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("unit_of_measurement_schedule_products", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("unit_of_measurement_schedule_products");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("unit_of_measurement_schedule_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_schedule_products");
            }
        }

        /// <summary>
        /// N:1 lk_uomschedule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uomschedule_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedule_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedule_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_uomschedule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uomschedule_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedule_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedule_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_uomschedulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uomschedulebase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedulebase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedulebase_createdby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_uomschedulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uomschedulebase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedulebase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uomschedulebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_modifiedby");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public UoMSchedule(object anonymousType) :
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
                        Attributes["uomscheduleid"] = base.Id;
                        break;
                    case "uomscheduleid":
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