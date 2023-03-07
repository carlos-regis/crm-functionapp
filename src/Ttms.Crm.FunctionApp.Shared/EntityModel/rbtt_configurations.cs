namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_configurationsState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Configurations
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("rbtt_configurations")]
    public partial class rbtt_configurations : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string OrganizationId = "organizationid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string rbtt_AdditionalValue = "rbtt_additionalvalue";
            public const string rbtt_configurationsId = "rbtt_configurationsid";
            public const string Id = "rbtt_configurationsid";
            public const string rbtt_LastJobRun = "rbtt_lastjobrun";
            public const string rbtt_name = "rbtt_name";
            public const string rbtt_Value = "rbtt_value";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_rbtt_configurations_createdby = "lk_rbtt_configurations_createdby";
            public const string lk_rbtt_configurations_createdonbehalfby = "lk_rbtt_configurations_createdonbehalfby";
            public const string lk_rbtt_configurations_modifiedby = "lk_rbtt_configurations_modifiedby";
            public const string lk_rbtt_configurations_modifiedonbehalfby = "lk_rbtt_configurations_modifiedonbehalfby";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_configurations() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "rbtt_configurations";

        public const string EntitySchemaName = "rbtt_configurations";

        public const string PrimaryIdAttribute = "rbtt_configurationsid";

        public const string PrimaryNameAttribute = "rbtt_name";

        public const string EntityLogicalCollectionName = "rbtt_configurationses";

        public const string EntitySetName = "rbtt_configurationses";

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
        /// Additional Value
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_additionalvalue")]
        public string rbtt_AdditionalValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_additionalvalue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_AdditionalValue");
                this.SetAttributeValue("rbtt_additionalvalue", value);
                this.OnPropertyChanged("rbtt_AdditionalValue");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_configurationsid")]
        public System.Nullable<System.Guid> rbtt_configurationsId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("rbtt_configurationsid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_configurationsId");
                this.SetAttributeValue("rbtt_configurationsid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("rbtt_configurationsId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_configurationsid")]
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
                this.rbtt_configurationsId = value;
            }
        }

        /// <summary>
        /// Last Job Run
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_lastjobrun")]
        public System.Nullable<System.DateTime> rbtt_LastJobRun
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_lastjobrun");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LastJobRun");
                this.SetAttributeValue("rbtt_lastjobrun", value);
                this.OnPropertyChanged("rbtt_LastJobRun");
            }
        }

        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name")]
        public string rbtt_name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_name");
                this.SetAttributeValue("rbtt_name", value);
                this.OnPropertyChanged("rbtt_name");
            }
        }

        /// <summary>
        /// Value
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_value")]
        public string rbtt_Value
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_value");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Value");
                this.SetAttributeValue("rbtt_value", value);
                this.OnPropertyChanged("rbtt_Value");
            }
        }

        /// <summary>
        /// Status of the Configurations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurationsState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurationsState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurationsState), optionSet.Value)));
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
        /// Reason for the status of the Configurations
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
        /// Reason for the status of the Configurations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual rbtt_configurations_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_configurations_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N rbtt_configurations_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_configurations_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> rbtt_configurations_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_configurations_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_configurations_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_configurations_Appointments", null, value);
                this.OnPropertyChanged("rbtt_configurations_Appointments");
            }
        }

        /// <summary>
        /// 1:N rbtt_configurations_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_configurations_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> rbtt_configurations_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_configurations_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_configurations_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_configurations_Emails", null, value);
                this.OnPropertyChanged("rbtt_configurations_Emails");
            }
        }

        /// <summary>
        /// 1:N rbtt_configurations_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_configurations_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> rbtt_configurations_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_configurations_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_configurations_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_configurations_Tasks", null, value);
                this.OnPropertyChanged("rbtt_configurations_Tasks");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_configurations_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_configurations_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_configurations_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_configurations_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_configurations_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_configurations_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_configurations_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_configurations_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_configurations_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_configurations(object anonymousType) :
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
                        Attributes["rbtt_configurationsid"] = base.Id;
                        break;
                    case "rbtt_configurationsid":
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