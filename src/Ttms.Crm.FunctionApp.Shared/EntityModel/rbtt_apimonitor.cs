namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_apimonitorState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Entity to collect all the activities performed by the API
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("rbtt_apimonitor")]
    public partial class rbtt_apimonitor : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string rbtt_Action = "rbtt_action";
            public const string rbtt_apimonitorId = "rbtt_apimonitorid";
            public const string Id = "rbtt_apimonitorid";
            public const string rbtt_Callfrom = "rbtt_callfrom";
            public const string rbtt_JsonRequest = "rbtt_jsonrequest";
            public const string rbtt_JsonResponse = "rbtt_jsonresponse";
            public const string rbtt_Method = "rbtt_method";
            public const string rbtt_thirdparty = "rbtt_thirdparty";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_rbtt_apimonitor_createdby = "lk_rbtt_apimonitor_createdby";
            public const string lk_rbtt_apimonitor_createdonbehalfby = "lk_rbtt_apimonitor_createdonbehalfby";
            public const string lk_rbtt_apimonitor_modifiedby = "lk_rbtt_apimonitor_modifiedby";
            public const string lk_rbtt_apimonitor_modifiedonbehalfby = "lk_rbtt_apimonitor_modifiedonbehalfby";
            public const string user_rbtt_apimonitor = "user_rbtt_apimonitor";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_apimonitor() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "rbtt_apimonitor";

        public const string EntitySchemaName = "rbtt_apimonitor";

        public const string PrimaryIdAttribute = "rbtt_apimonitorid";

        public const string PrimaryNameAttribute = "rbtt_thirdparty";

        public const string EntityLogicalCollectionName = "rbtt_apimonitors";

        public const string EntitySetName = "rbtt_apimonitors";

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
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_action")]
        public string rbtt_Action
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_action");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Action");
                this.SetAttributeValue("rbtt_action", value);
                this.OnPropertyChanged("rbtt_Action");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_apimonitorid")]
        public System.Nullable<System.Guid> rbtt_apimonitorId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("rbtt_apimonitorid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_apimonitorId");
                this.SetAttributeValue("rbtt_apimonitorid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("rbtt_apimonitorId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_apimonitorid")]
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
                this.rbtt_apimonitorId = value;
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_callfrom")]
        public string rbtt_Callfrom
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_callfrom");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Callfrom");
                this.SetAttributeValue("rbtt_callfrom", value);
                this.OnPropertyChanged("rbtt_Callfrom");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_jsonrequest")]
        public string rbtt_JsonRequest
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_jsonrequest");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_JsonRequest");
                this.SetAttributeValue("rbtt_jsonrequest", value);
                this.OnPropertyChanged("rbtt_JsonRequest");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_jsonresponse")]
        public string rbtt_JsonResponse
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_jsonresponse");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_JsonResponse");
                this.SetAttributeValue("rbtt_jsonresponse", value);
                this.OnPropertyChanged("rbtt_JsonResponse");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_method")]
        public string rbtt_Method
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_method");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Method");
                this.SetAttributeValue("rbtt_method", value);
                this.OnPropertyChanged("rbtt_Method");
            }
        }

        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_thirdparty")]
        public string rbtt_thirdparty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_thirdparty");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_thirdparty");
                this.SetAttributeValue("rbtt_thirdparty", value);
                this.OnPropertyChanged("rbtt_thirdparty");
            }
        }

        /// <summary>
        /// Status of the API Monitor
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitorState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitorState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitorState), optionSet.Value)));
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
        /// Reason for the status of the API Monitor
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
        /// Reason for the status of the API Monitor
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual rbtt_apimonitor_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_apimonitor_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N rbtt_apimonitor_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_apimonitor_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> rbtt_apimonitor_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_apimonitor_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_apimonitor_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_apimonitor_Appointments", null, value);
                this.OnPropertyChanged("rbtt_apimonitor_Appointments");
            }
        }

        /// <summary>
        /// 1:N rbtt_apimonitor_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_apimonitor_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> rbtt_apimonitor_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_apimonitor_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_apimonitor_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_apimonitor_Emails", null, value);
                this.OnPropertyChanged("rbtt_apimonitor_Emails");
            }
        }

        /// <summary>
        /// 1:N rbtt_apimonitor_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_apimonitor_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> rbtt_apimonitor_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_apimonitor_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_apimonitor_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_apimonitor_Tasks", null, value);
                this.OnPropertyChanged("rbtt_apimonitor_Tasks");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_apimonitor_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_apimonitor_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_apimonitor_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_apimonitor_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_apimonitor_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_apimonitor_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_apimonitor_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_apimonitor_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_apimonitor_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 user_rbtt_apimonitor
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_rbtt_apimonitor")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_rbtt_apimonitor
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_rbtt_apimonitor", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_rbtt_apimonitor");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_rbtt_apimonitor", null, value);
                this.OnPropertyChanged("user_rbtt_apimonitor");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_apimonitor(object anonymousType) :
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
                        Attributes["rbtt_apimonitorid"] = base.Id;
                        break;
                    case "rbtt_apimonitorid":
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