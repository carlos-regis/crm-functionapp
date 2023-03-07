namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum TaskState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Completed = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Canceled = 2,
    }

    /// <summary>
    /// Generic activity representing work needed to be done.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("task")]
    public partial class Task : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string ActivityAdditionalParams = "activityadditionalparams";
            public const string ActivityId = "activityid";
            public const string Id = "activityid";
            public const string ActivityTypeCode = "activitytypecode";
            public const string ActualDurationMinutes = "actualdurationminutes";
            public const string ActualEnd = "actualend";
            public const string ActualStart = "actualstart";
            public const string Btt_Cost = "btt_cost";
            public const string btt_cost_Base = "btt_cost_base";
            public const string Btt_dateandtime = "btt_dateandtime";
            public const string Btt_mileage = "btt_mileage";
            public const string Btt_Taskcategory = "btt_taskcategory";
            public const string Category = "category";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CrmTaskAssignedUniqueId = "crmtaskassigneduniqueid";
            public const string Description = "description";
            public const string ExchangeRate = "exchangerate";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IsBilled = "isbilled";
            public const string IsRegularActivity = "isregularactivity";
            public const string IsWorkflowCreated = "isworkflowcreated";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string OnHoldTime = "onholdtime";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string PercentComplete = "percentcomplete";
            public const string PriorityCode = "prioritycode";
            public const string ProcessId = "processid";
            public const string rbtt_RhythmUpdatedBy = "rbtt_rhythmupdatedby";
            public const string RegardingObjectId = "regardingobjectid";
            public const string ScheduledDurationMinutes = "scheduleddurationminutes";
            public const string ScheduledEnd = "scheduledend";
            public const string ScheduledStart = "scheduledstart";
            public const string ServiceId = "serviceid";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string SortDate = "sortdate";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string Subcategory = "subcategory";
            public const string Subject = "subject";
            public const string SubscriptionId = "subscriptionid";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string Account_Tasks = "Account_Tasks";
            public const string Contact_Tasks = "Contact_Tasks";
            public const string lk_task_createdby = "lk_task_createdby";
            public const string lk_task_createdonbehalfby = "lk_task_createdonbehalfby";
            public const string lk_task_modifiedby = "lk_task_modifiedby";
            public const string lk_task_modifiedonbehalfby = "lk_task_modifiedonbehalfby";
            public const string Opportunity_Tasks = "Opportunity_Tasks";
            public const string orb_machine_Tasks = "orb_machine_Tasks";
            public const string Quote_Tasks = "Quote_Tasks";
            public const string rbtt_apimonitor_Tasks = "rbtt_apimonitor_Tasks";
            public const string rbtt_appliance_Tasks = "rbtt_appliance_Tasks";
            public const string rbtt_applicationid_Tasks = "rbtt_applicationid_Tasks";
            public const string rbtt_configurations_Tasks = "rbtt_configurations_Tasks";
            public const string rbtt_consent_Tasks = "rbtt_consent_Tasks";
            public const string rbtt_consenttext_Tasks = "rbtt_consenttext_Tasks";
            public const string rbtt_customermasterdataexchange_Tasks = "rbtt_customermasterdataexchange_Tasks";
            public const string rbtt_delivernote_Tasks = "rbtt_delivernote_Tasks";
            public const string rbtt_processingactivity_Tasks = "rbtt_processingactivity_Tasks";
            public const string rbtt_productionplants_Tasks = "rbtt_productionplants_Tasks";
            public const string rbtt_systemuser_task_RhythmUpdatedBy = "rbtt_systemuser_task_RhythmUpdatedBy";
            public const string user_task = "user_task";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Task() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "task";

        public const string EntitySchemaName = "Task";

        public const string PrimaryIdAttribute = "activityid";

        public const string PrimaryNameAttribute = "subject";

        public const string EntityLogicalCollectionName = "tasks";

        public const string EntitySetName = "tasks";

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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityadditionalparams")]
        public string ActivityAdditionalParams
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("activityadditionalparams");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActivityAdditionalParams");
                this.SetAttributeValue("activityadditionalparams", value);
                this.OnPropertyChanged("ActivityAdditionalParams");
            }
        }

        /// <summary>
        /// Unique identifier of the task.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public System.Nullable<System.Guid> ActivityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("activityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActivityId");
                this.SetAttributeValue("activityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ActivityId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
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
                this.ActivityId = value;
            }
        }

        /// <summary>
        /// Type of activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
        public string ActivityTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("activitytypecode");
            }
        }

        /// <summary>
        /// Type the number of minutes spent on the task. The duration is used in reporting.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
        public System.Nullable<int> ActualDurationMinutes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActualDurationMinutes");
                this.SetAttributeValue("actualdurationminutes", value);
                this.OnPropertyChanged("ActualDurationMinutes");
            }
        }

        /// <summary>
        /// Enter the actual end date and time of the task. By default, it displays when the activity was completed or canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
        public System.Nullable<System.DateTime> ActualEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActualEnd");
                this.SetAttributeValue("actualend", value);
                this.OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        /// Enter the actual start date and time for the task. By default, it displays when the task was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
        public System.Nullable<System.DateTime> ActualStart
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActualStart");
                this.SetAttributeValue("actualstart", value);
                this.OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        /// Cost
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_cost")]
        public Microsoft.Xrm.Sdk.Money Btt_Cost
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_cost");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Cost");
                this.SetAttributeValue("btt_cost", value);
                this.OnPropertyChanged("Btt_Cost");
            }
        }

        /// <summary>
        /// Value of the Cost in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_cost_base")]
        public Microsoft.Xrm.Sdk.Money btt_cost_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_cost_base");
            }
        }

        /// <summary>
        /// Date and time periods.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dateandtime")]
        public System.Nullable<System.DateTime> Btt_dateandtime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_dateandtime");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_dateandtime");
                this.SetAttributeValue("btt_dateandtime", value);
                this.OnPropertyChanged("Btt_dateandtime");
            }
        }

        /// <summary>
        /// Mileage involved.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_mileage")]
        public System.Nullable<int> Btt_mileage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_mileage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_mileage");
                this.SetAttributeValue("btt_mileage", value);
                this.OnPropertyChanged("Btt_mileage");
            }
        }

        /// <summary>
        /// Task category
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_taskcategory")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Taskcategory
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_taskcategory");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Taskcategory");
                this.SetAttributeValue("btt_taskcategory", value);
                this.OnPropertyChanged("Btt_Taskcategory");
            }
        }

        /// <summary>
        /// Task category
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_taskcategory")]
        public virtual Task_Btt_Taskcategory? Btt_TaskcategoryEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Task_Btt_Taskcategory?)(EntityOptionSetEnum.GetEnum(this, "btt_taskcategory")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Taskcategory");
                this.SetAttributeValue("btt_taskcategory", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Taskcategory");
            }
        }

        /// <summary>
        /// Type a category to identify the task type, such as lead gathering or customer follow up, to tie the task to a business group or function.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
        public string Category
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("category");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Category");
                this.SetAttributeValue("category", value);
                this.OnPropertyChanged("Category");
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
        /// Assigned Task Unique Id
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crmtaskassigneduniqueid")]
        public System.Nullable<System.Guid> CrmTaskAssignedUniqueId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("crmtaskassigneduniqueid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CrmTaskAssignedUniqueId");
                this.SetAttributeValue("crmtaskassigneduniqueid", value);
                this.OnPropertyChanged("CrmTaskAssignedUniqueId");
            }
        }

        /// <summary>
        /// Type additional information to describe the task.
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
        /// Information which specifies whether the task was billed as part of resolving a case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
        public System.Nullable<bool> IsBilled
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isbilled");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsBilled");
                this.SetAttributeValue("isbilled", value);
                this.OnPropertyChanged("IsBilled");
            }
        }

        /// <summary>
        /// Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
        public System.Nullable<bool> IsRegularActivity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity");
            }
        }

        /// <summary>
        /// Information which specifies if the task was created from a workflow rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
        public System.Nullable<bool> IsWorkflowCreated
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsWorkflowCreated");
                this.SetAttributeValue("isworkflowcreated", value);
                this.OnPropertyChanged("IsWorkflowCreated");
            }
        }

        /// <summary>
        /// Contains the date and time stamp of the last on hold time.
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
        /// Shows how long, in minutes, that the record was on hold.
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
        /// Shows the record owner's business unit.
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
        /// Unique identifier of the team that owns the task.
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
        /// Unique identifier of the user that owns the task.
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
        /// Type the percentage complete value for the task to track tasks to completion.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("percentcomplete")]
        public System.Nullable<int> PercentComplete
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("percentcomplete");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PercentComplete");
                this.SetAttributeValue("percentcomplete", value);
                this.OnPropertyChanged("PercentComplete");
            }
        }

        /// <summary>
        /// Select the priority so that preferred customers or critical issues are handled quickly.
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
        /// Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public virtual Task_PriorityCode? PriorityCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Task_PriorityCode?)(EntityOptionSetEnum.GetEnum(this, "prioritycode")));
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
        /// This filed is to control who was requesting to update the Rhythm frequency for the Regarding Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_rhythmupdatedby")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_RhythmUpdatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_rhythmupdatedby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RhythmUpdatedBy");
                this.SetAttributeValue("rbtt_rhythmupdatedby", value);
                this.OnPropertyChanged("rbtt_RhythmUpdatedBy");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the task is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("RegardingObjectId");
                this.SetAttributeValue("regardingobjectid", value);
                this.OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        /// Scheduled duration of the task, specified in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes");
            }
        }

        /// <summary>
        /// Enter the expected due date and time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduledEnd");
                this.SetAttributeValue("scheduledend", value);
                this.OnPropertyChanged("ScheduledEnd");
            }
        }

        /// <summary>
        /// Enter the expected due date and time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduledStart");
                this.SetAttributeValue("scheduledstart", value);
                this.OnPropertyChanged("ScheduledStart");
            }
        }

        /// <summary>
        /// service_tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        public Microsoft.Xrm.Sdk.EntityReference ServiceId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ServiceId");
                this.SetAttributeValue("serviceid", value);
                this.OnPropertyChanged("ServiceId");
            }
        }

        /// <summary>
        /// Choose the service level agreement (SLA) that you want to apply to the Task record.
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
        /// Last SLA that was applied to this Task. This field is for internal use only.
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
        /// Shows the date and time by which the activities are sorted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sortdate")]
        public System.Nullable<System.DateTime> SortDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("sortdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SortDate");
                this.SetAttributeValue("sortdate", value);
                this.OnPropertyChanged("SortDate");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
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
        /// Shows whether the task is open, completed, or canceled. Completed and canceled tasks are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.TaskState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.TaskState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.TaskState), optionSet.Value)));
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
        /// Select the task's status.
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
        /// Select the task's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Task_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Task_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// Type a subcategory to identify the task type and relate the activity to a specific product, sales region, business group, or other function.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subcategory")]
        public string Subcategory
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("subcategory");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Subcategory");
                this.SetAttributeValue("subcategory", value);
                this.OnPropertyChanged("Subcategory");
            }
        }

        /// <summary>
        /// Type a short description about the objective or primary topic of the task.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("subject");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
        public System.Nullable<System.Guid> SubscriptionId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SubscriptionId");
                this.SetAttributeValue("subscriptionid", value);
                this.OnPropertyChanged("SubscriptionId");
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
        /// Version number of the task.
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
        /// 1:N task_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> task_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("task_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("task_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("task_activity_parties", null, value);
                this.OnPropertyChanged("task_activity_parties");
            }
        }

        /// <summary>
        /// N:1 Account_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account Account_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Tasks", null, value);
                this.OnPropertyChanged("Account_Tasks");
            }
        }

        /// <summary>
        /// N:1 Contact_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact Contact_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("Contact_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Contact_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("Contact_Tasks", null, value);
                this.OnPropertyChanged("Contact_Tasks");
            }
        }

        /// <summary>
        /// N:1 lk_task_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_task_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_createdby", null, value);
                this.OnPropertyChanged("lk_task_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_task_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_task_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_task_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_task_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_modifiedby", null, value);
                this.OnPropertyChanged("lk_task_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_task_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_task_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_task_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity Opportunity_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("Opportunity_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Opportunity_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("Opportunity_Tasks", null, value);
                this.OnPropertyChanged("Opportunity_Tasks");
            }
        }

        /// <summary>
        /// N:1 orb_machine_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_machine_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine orb_machine_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_machine_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_machine_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_machine_Tasks", null, value);
                this.OnPropertyChanged("orb_machine_Tasks");
            }
        }

        /// <summary>
        /// N:1 Quote_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Quote Quote_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("Quote_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Quote_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("Quote_Tasks", null, value);
                this.OnPropertyChanged("Quote_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_apimonitor_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_apimonitor_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor rbtt_apimonitor_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("rbtt_apimonitor_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_apimonitor_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("rbtt_apimonitor_Tasks", null, value);
                this.OnPropertyChanged("rbtt_apimonitor_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_appliance_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_appliance_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance rbtt_appliance_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_appliance_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_appliance_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_appliance_Tasks", null, value);
                this.OnPropertyChanged("rbtt_appliance_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_applicationid_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_applicationid_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid rbtt_applicationid_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_applicationid_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_applicationid_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_applicationid_Tasks", null, value);
                this.OnPropertyChanged("rbtt_applicationid_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_configurations_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_configurations_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations rbtt_configurations_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("rbtt_configurations_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_configurations_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("rbtt_configurations_Tasks", null, value);
                this.OnPropertyChanged("rbtt_configurations_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_consent_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consent_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent rbtt_consent_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_consent_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consent_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_consent_Tasks", null, value);
                this.OnPropertyChanged("rbtt_consent_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_consenttext_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consenttext_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext rbtt_consenttext_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_consenttext_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consenttext_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_consenttext_Tasks", null, value);
                this.OnPropertyChanged("rbtt_consenttext_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_customermasterdataexchange_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_customermasterdataexchange_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange rbtt_customermasterdataexchange_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_customermasterdataexchange_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_customermasterdataexchange_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_customermasterdataexchange_Tasks", null, value);
                this.OnPropertyChanged("rbtt_customermasterdataexchange_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_delivernote_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_delivernote_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote rbtt_delivernote_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_delivernote_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_delivernote_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_delivernote_Tasks", null, value);
                this.OnPropertyChanged("rbtt_delivernote_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_processingactivity_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_processingactivity_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity rbtt_processingactivity_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_processingactivity_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_processingactivity_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_processingactivity_Tasks", null, value);
                this.OnPropertyChanged("rbtt_processingactivity_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_productionplants_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_productionplants_Tasks")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants rbtt_productionplants_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_productionplants_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_productionplants_Tasks");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_productionplants_Tasks", null, value);
                this.OnPropertyChanged("rbtt_productionplants_Tasks");
            }
        }

        /// <summary>
        /// N:1 rbtt_systemuser_task_RhythmUpdatedBy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_rhythmupdatedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_systemuser_task_RhythmUpdatedBy")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser rbtt_systemuser_task_RhythmUpdatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("rbtt_systemuser_task_RhythmUpdatedBy", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_systemuser_task_RhythmUpdatedBy");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("rbtt_systemuser_task_RhythmUpdatedBy", null, value);
                this.OnPropertyChanged("rbtt_systemuser_task_RhythmUpdatedBy");
            }
        }

        /// <summary>
        /// N:1 user_task
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_task")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_task
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_task", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_task");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_task", null, value);
                this.OnPropertyChanged("user_task");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Task(object anonymousType) :
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
                        Attributes["activityid"] = base.Id;
                        break;
                    case "activityid":
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