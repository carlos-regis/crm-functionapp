namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum AppointmentState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Completed = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Canceled = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scheduled = 3,
    }

    /// <summary>
    /// Appointments on physical meetings at a customer.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("appointment")]
    public partial class Appointment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
            public const string AttachmentCount = "attachmentcount";
            public const string AttachmentErrors = "attachmenterrors";
            public const string Btt_accountinformation = "btt_accountinformation";
            public const string btt_accountname = "btt_accountname";
            public const string btt_accountnumber = "btt_accountnumber";
            public const string btt_accountrole = "btt_accountrole";
            public const string Btt_boschloyaltyprogram = "btt_boschloyaltyprogram";
            public const string Btt_mileage = "btt_mileage";
            public const string BTT_reasonControlling = "btt_reasoncontrolling";
            public const string BTT_reasonCustomerOrder = "btt_reasoncustomerorder";
            public const string Btt_reasonfair = "btt_reasonfair";
            public const string Btt_ReasonIncomingCall = "btt_reasonincomingcall";
            public const string Btt_reasoninspection = "btt_reasoninspection";
            public const string BTT_reasonOther = "btt_reasonother";
            public const string Btt_ReasonOutgoingCall = "btt_reasonoutgoingcall";
            public const string BTT_reasonPricing = "btt_reasonpricing";
            public const string BTT_reasonProductPres = "btt_reasonproductpres";
            public const string BTT_reasonProducttechnical = "btt_reasonproducttechnical";
            public const string Btt_reasonprojectreview = "btt_reasonprojectreview";
            public const string BTT_reasonPromotion = "btt_reasonpromotion";
            public const string BTT_reasonRegularVisit = "btt_reasonregularvisit";
            public const string BTT_reasonStrategic = "btt_reasonstrategic";
            public const string BTT_reasonTechnicalDifficulties = "btt_reasontechnicaldifficulties";
            public const string btt_visitobjective1 = "btt_visitobjective1";
            public const string btt_visitobjective2 = "btt_visitobjective2";
            public const string btt_visitobjective3 = "btt_visitobjective3";
            public const string Category = "category";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string Description = "description";
            public const string ExchangeRate = "exchangerate";
            public const string GlobalObjectId = "globalobjectid";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string InstanceTypeCode = "instancetypecode";
            public const string IsAllDayEvent = "isalldayevent";
            public const string IsBilled = "isbilled";
            public const string IsDraft = "isdraft";
            public const string IsMapiPrivate = "ismapiprivate";
            public const string IsRegularActivity = "isregularactivity";
            public const string IsUnsafe = "isunsafe";
            public const string IsWorkflowCreated = "isworkflowcreated";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string Location = "location";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedFieldsMask = "modifiedfieldsmask";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string OnHoldTime = "onholdtime";
            public const string OptionalAttendees = "optionalattendees";
            public const string Orb_isscheduled = "orb_isscheduled";
            public const string Organizer = "organizer";
            public const string OriginalStartDate = "originalstartdate";
            public const string OutlookOwnerApptId = "outlookownerapptid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string PriorityCode = "prioritycode";
            public const string ProcessId = "processid";
            public const string RegardingObjectId = "regardingobjectid";
            public const string RequiredAttendees = "requiredattendees";
            public const string ScheduledDurationMinutes = "scheduleddurationminutes";
            public const string ScheduledEnd = "scheduledend";
            public const string ScheduledStart = "scheduledstart";
            public const string SeriesId = "seriesid";
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
            public const string Account_Appointments = "Account_Appointments";
            public const string Contact_Appointments = "Contact_Appointments";
            public const string lk_appointment_createdby = "lk_appointment_createdby";
            public const string lk_appointment_createdonbehalfby = "lk_appointment_createdonbehalfby";
            public const string lk_appointment_modifiedby = "lk_appointment_modifiedby";
            public const string lk_appointment_modifiedonbehalfby = "lk_appointment_modifiedonbehalfby";
            public const string Opportunity_Appointments = "Opportunity_Appointments";
            public const string orb_machine_Appointments = "orb_machine_Appointments";
            public const string Quote_Appointments = "Quote_Appointments";
            public const string rbtt_apimonitor_Appointments = "rbtt_apimonitor_Appointments";
            public const string rbtt_appliance_Appointments = "rbtt_appliance_Appointments";
            public const string rbtt_applicationid_Appointments = "rbtt_applicationid_Appointments";
            public const string rbtt_configurations_Appointments = "rbtt_configurations_Appointments";
            public const string rbtt_consent_Appointments = "rbtt_consent_Appointments";
            public const string rbtt_consenttext_Appointments = "rbtt_consenttext_Appointments";
            public const string rbtt_customermasterdataexchange_Appointments = "rbtt_customermasterdataexchange_Appointments";
            public const string rbtt_delivernote_Appointments = "rbtt_delivernote_Appointments";
            public const string rbtt_processingactivity_Appointments = "rbtt_processingactivity_Appointments";
            public const string rbtt_productionplants_Appointments = "rbtt_productionplants_Appointments";
            public const string user_appointment = "user_appointment";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Appointment() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "appointment";

        public const string EntitySchemaName = "Appointment";

        public const string PrimaryIdAttribute = "activityid";

        public const string PrimaryNameAttribute = "subject";

        public const string EntityLogicalCollectionName = "appointments";

        public const string EntitySetName = "appointments";

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
        /// Unique identifier of the appointment.
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
        /// Shows the value selected in the Duration field on the appointment at the time that the appointment is closed as completed. The duration is used to report the time spent on the activity.
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
        /// Enter the actual end date and time of the appointment. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual duration of the appointment.
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
        /// Enter the actual start date and time for the appointment. By default, it displays the date and time when the activity was created, but can be edited to capture the actual duration of the appointment.
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
        /// Shows the number of attachments on the appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentcount")]
        public System.Nullable<int> AttachmentCount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("attachmentcount");
            }
        }

        /// <summary>
        /// Select the error code to identify issues with the outlook item recipients or attachments, such as blocked attachments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmenterrors")]
        public Microsoft.Xrm.Sdk.OptionSetValue AttachmentErrors
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("attachmenterrors");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AttachmentErrors");
                this.SetAttributeValue("attachmenterrors", value);
                this.OnPropertyChanged("AttachmentErrors");
            }
        }

        /// <summary>
        /// Select the error code to identify issues with the outlook item recipients or attachments, such as blocked attachments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmenterrors")]
        public virtual Appointment_AttachmentErrors? AttachmentErrorsEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Appointment_AttachmentErrors?)(EntityOptionSetEnum.GetEnum(this, "attachmenterrors")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AttachmentErrors");
                this.SetAttributeValue("attachmenterrors", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("AttachmentErrors");
            }
        }

        /// <summary>
        /// Account Information
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_accountinformation")]
        public System.Nullable<bool> Btt_accountinformation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_accountinformation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_accountinformation");
                this.SetAttributeValue("btt_accountinformation", value);
                this.OnPropertyChanged("Btt_accountinformation");
            }
        }

        /// <summary>
        /// Account Name
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_accountname")]
        public string btt_accountname
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_accountname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_accountname");
                this.SetAttributeValue("btt_accountname", value);
                this.OnPropertyChanged("btt_accountname");
            }
        }

        /// <summary>
        /// Account Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_accountnumber")]
        public string btt_accountnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_accountnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_accountnumber");
                this.SetAttributeValue("btt_accountnumber", value);
                this.OnPropertyChanged("btt_accountnumber");
            }
        }

        /// <summary>
        /// Role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_accountrole")]
        public string btt_accountrole
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_accountrole");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_accountrole");
                this.SetAttributeValue("btt_accountrole", value);
                this.OnPropertyChanged("btt_accountrole");
            }
        }

        /// <summary>
        /// Bosch Loyalty Program
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_boschloyaltyprogram")]
        public System.Nullable<bool> Btt_boschloyaltyprogram
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_boschloyaltyprogram");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_boschloyaltyprogram");
                this.SetAttributeValue("btt_boschloyaltyprogram", value);
                this.OnPropertyChanged("Btt_boschloyaltyprogram");
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
        /// Reason for visit: Controlling/Bookkeeping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasoncontrolling")]
        public System.Nullable<bool> BTT_reasonControlling
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasoncontrolling");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonControlling");
                this.SetAttributeValue("btt_reasoncontrolling", value);
                this.OnPropertyChanged("BTT_reasonControlling");
            }
        }

        /// <summary>
        /// Reason for visit: Customer Order
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasoncustomerorder")]
        public System.Nullable<bool> BTT_reasonCustomerOrder
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasoncustomerorder");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonCustomerOrder");
                this.SetAttributeValue("btt_reasoncustomerorder", value);
                this.OnPropertyChanged("BTT_reasonCustomerOrder");
            }
        }

        /// <summary>
        /// Fair or Exhibition
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonfair")]
        public System.Nullable<bool> Btt_reasonfair
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonfair");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_reasonfair");
                this.SetAttributeValue("btt_reasonfair", value);
                this.OnPropertyChanged("Btt_reasonfair");
            }
        }

        /// <summary>
        /// Incoming Call
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonincomingcall")]
        public System.Nullable<bool> Btt_ReasonIncomingCall
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonincomingcall");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ReasonIncomingCall");
                this.SetAttributeValue("btt_reasonincomingcall", value);
                this.OnPropertyChanged("Btt_ReasonIncomingCall");
            }
        }

        /// <summary>
        /// Inspection of old unit for replacement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasoninspection")]
        public System.Nullable<bool> Btt_reasoninspection
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasoninspection");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_reasoninspection");
                this.SetAttributeValue("btt_reasoninspection", value);
                this.OnPropertyChanged("Btt_reasoninspection");
            }
        }

        /// <summary>
        /// Reason for visit: Other
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonother")]
        public System.Nullable<bool> BTT_reasonOther
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonother");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonOther");
                this.SetAttributeValue("btt_reasonother", value);
                this.OnPropertyChanged("BTT_reasonOther");
            }
        }

        /// <summary>
        /// Outgoing Call
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonoutgoingcall")]
        public System.Nullable<bool> Btt_ReasonOutgoingCall
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonoutgoingcall");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ReasonOutgoingCall");
                this.SetAttributeValue("btt_reasonoutgoingcall", value);
                this.OnPropertyChanged("Btt_ReasonOutgoingCall");
            }
        }

        /// <summary>
        /// Reason for visit: Pricing and Offers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonpricing")]
        public System.Nullable<bool> BTT_reasonPricing
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonpricing");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonPricing");
                this.SetAttributeValue("btt_reasonpricing", value);
                this.OnPropertyChanged("BTT_reasonPricing");
            }
        }

        /// <summary>
        /// Reason for visit: New Product Presentation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonproductpres")]
        public System.Nullable<bool> BTT_reasonProductPres
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonproductpres");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonProductPres");
                this.SetAttributeValue("btt_reasonproductpres", value);
                this.OnPropertyChanged("BTT_reasonProductPres");
            }
        }

        /// <summary>
        /// Reason for visit: Product (technical)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonproducttechnical")]
        public System.Nullable<bool> BTT_reasonProducttechnical
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonproducttechnical");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonProducttechnical");
                this.SetAttributeValue("btt_reasonproducttechnical", value);
                this.OnPropertyChanged("BTT_reasonProducttechnical");
            }
        }

        /// <summary>
        /// Opportunity Review
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonprojectreview")]
        public System.Nullable<bool> Btt_reasonprojectreview
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonprojectreview");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_reasonprojectreview");
                this.SetAttributeValue("btt_reasonprojectreview", value);
                this.OnPropertyChanged("Btt_reasonprojectreview");
            }
        }

        /// <summary>
        /// Reason for visit: Promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonpromotion")]
        public System.Nullable<bool> BTT_reasonPromotion
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonpromotion");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonPromotion");
                this.SetAttributeValue("btt_reasonpromotion", value);
                this.OnPropertyChanged("BTT_reasonPromotion");
            }
        }

        /// <summary>
        /// Reason for visit: Regular Visit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonregularvisit")]
        public System.Nullable<bool> BTT_reasonRegularVisit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonregularvisit");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonRegularVisit");
                this.SetAttributeValue("btt_reasonregularvisit", value);
                this.OnPropertyChanged("BTT_reasonRegularVisit");
            }
        }

        /// <summary>
        /// Reason for visit: Strategic and Commercial
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasonstrategic")]
        public System.Nullable<bool> BTT_reasonStrategic
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasonstrategic");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonStrategic");
                this.SetAttributeValue("btt_reasonstrategic", value);
                this.OnPropertyChanged("BTT_reasonStrategic");
            }
        }

        /// <summary>
        /// Reason for visit: Technical Difficulties (After Sales)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reasontechnicaldifficulties")]
        public System.Nullable<bool> BTT_reasonTechnicalDifficulties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_reasontechnicaldifficulties");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_reasonTechnicalDifficulties");
                this.SetAttributeValue("btt_reasontechnicaldifficulties", value);
                this.OnPropertyChanged("BTT_reasonTechnicalDifficulties");
            }
        }

        /// <summary>
        /// 1st Objective
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitobjective1")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_visitobjective1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_visitobjective1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitobjective1");
                this.SetAttributeValue("btt_visitobjective1", value);
                this.OnPropertyChanged("btt_visitobjective1");
            }
        }

        /// <summary>
        /// 1st Objective
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitobjective1")]
        public virtual Appointment_btt_visitobjective1? btt_visitobjective1Enum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Appointment_btt_visitobjective1?)(EntityOptionSetEnum.GetEnum(this, "btt_visitobjective1")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitobjective1");
                this.SetAttributeValue("btt_visitobjective1", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_visitobjective1");
            }
        }

        /// <summary>
        /// 2nd Objective
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitobjective2")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_visitobjective2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_visitobjective2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitobjective2");
                this.SetAttributeValue("btt_visitobjective2", value);
                this.OnPropertyChanged("btt_visitobjective2");
            }
        }

        /// <summary>
        /// 2nd Objective
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitobjective2")]
        public virtual Appointment_btt_visitobjective2? btt_visitobjective2Enum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Appointment_btt_visitobjective2?)(EntityOptionSetEnum.GetEnum(this, "btt_visitobjective2")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitobjective2");
                this.SetAttributeValue("btt_visitobjective2", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_visitobjective2");
            }
        }

        /// <summary>
        /// 3rd Objective
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitobjective3")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_visitobjective3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_visitobjective3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitobjective3");
                this.SetAttributeValue("btt_visitobjective3", value);
                this.OnPropertyChanged("btt_visitobjective3");
            }
        }

        /// <summary>
        /// 3rd Objective
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitobjective3")]
        public virtual Appointment_btt_visitobjective3? btt_visitobjective3Enum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Appointment_btt_visitobjective3?)(EntityOptionSetEnum.GetEnum(this, "btt_visitobjective3")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitobjective3");
                this.SetAttributeValue("btt_visitobjective3", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_visitobjective3");
            }
        }

        /// <summary>
        /// Type a category to identify the appointment type, such as sales demo, prospect call, or service call, to tie the appointment to a business group or function.
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
        /// Type additional information to describe the purpose of the appointment.
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
        /// Shows the ID of the appointment in Microsoft Office Outlook. The ID is used to synchronize the appointment between Microsoft Dynamics 365 and the correct Exchange account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("globalobjectid")]
        public string GlobalObjectId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("globalobjectid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("GlobalObjectId");
                this.SetAttributeValue("globalobjectid", value);
                this.OnPropertyChanged("GlobalObjectId");
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
        /// Type of instance of a recurring series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InstanceTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instancetypecode");
            }
        }

        /// <summary>
        /// Type of instance of a recurring series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
        public virtual Appointment_InstanceTypeCode? InstanceTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Appointment_InstanceTypeCode?)(EntityOptionSetEnum.GetEnum(this, "instancetypecode")));
            }
        }

        /// <summary>
        /// Select whether the appointment is an all-day event to make sure that the required resources are scheduled for the full day.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isalldayevent")]
        public System.Nullable<bool> IsAllDayEvent
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isalldayevent");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsAllDayEvent");
                this.SetAttributeValue("isalldayevent", value);
                this.OnPropertyChanged("IsAllDayEvent");
            }
        }

        /// <summary>
        /// Information regarding whether the appointment was billed as part of resolving a case.
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
        /// Information regarding whether the appointment is a draft.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdraft")]
        public System.Nullable<bool> IsDraft
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isdraft");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsDraft");
                this.SetAttributeValue("isdraft", value);
                this.OnPropertyChanged("IsDraft");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismapiprivate")]
        public System.Nullable<bool> IsMapiPrivate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ismapiprivate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsMapiPrivate");
                this.SetAttributeValue("ismapiprivate", value);
                this.OnPropertyChanged("IsMapiPrivate");
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isunsafe")]
        public System.Nullable<int> IsUnsafe
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("isunsafe");
            }
        }

        /// <summary>
        /// Information regarding whether the appointment was created from a workflow rule.
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
        /// Type the location where the appointment will take place, such as a conference room or customer office.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
        public string Location
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("location");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Location");
                this.SetAttributeValue("location", value);
                this.OnPropertyChanged("Location");
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedfieldsmask")]
        public string ModifiedFieldsMask
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("modifiedfieldsmask");
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
        /// Shows who created the record on behalf of another user.
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
        /// Enter the account, contact, lead, user, or other equipment resources that are not needed at the appointment, but can optionally attend.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("optionalattendees")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> OptionalAttendees
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("optionalattendees");
                if (((collection != null)
                            && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Select<Microsoft.Xrm.Sdk.Entity, Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>(collection.Entities, e => e.ToEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>());
                }
                else
                {
                    return null;
                }
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OptionalAttendees");
                if ((value == null))
                {
                    this.SetAttributeValue("optionalattendees", value);
                }
                else
                {
                    this.SetAttributeValue("optionalattendees", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("OptionalAttendees");
            }
        }

        /// <summary>
        /// Is scheduled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_isscheduled")]
        public System.Nullable<bool> Orb_isscheduled
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_isscheduled");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_isscheduled");
                this.SetAttributeValue("orb_isscheduled", value);
                this.OnPropertyChanged("Orb_isscheduled");
            }
        }

        /// <summary>
        /// Enter the user who is in charge of coordinating or leading the appointment to make sure the appointment is displayed in the user's My Activities view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizer")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> Organizer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("organizer");
                if (((collection != null)
                            && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Select<Microsoft.Xrm.Sdk.Entity, Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>(collection.Entities, e => e.ToEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>());
                }
                else
                {
                    return null;
                }
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Organizer");
                if ((value == null))
                {
                    this.SetAttributeValue("organizer", value);
                }
                else
                {
                    this.SetAttributeValue("organizer", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Organizer");
            }
        }

        /// <summary>
        /// The original start date of the appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originalstartdate")]
        public System.Nullable<System.DateTime> OriginalStartDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("originalstartdate");
            }
        }

        /// <summary>
        /// Unique identifier of the Microsoft Office Outlook appointment owner that correlates to the PR_OWNER_APPT_ID MAPI property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outlookownerapptid")]
        public System.Nullable<int> OutlookOwnerApptId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("outlookownerapptid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OutlookOwnerApptId");
                this.SetAttributeValue("outlookownerapptid", value);
                this.OnPropertyChanged("OutlookOwnerApptId");
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
        /// Shows the business unit that the record owner belongs to.
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
        /// Unique identifier of the team that owns the appointment.
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
        /// Unique identifier of the user that owns the appointment.
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
        public virtual Appointment_PriorityCode? PriorityCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Appointment_PriorityCode?)(EntityOptionSetEnum.GetEnum(this, "prioritycode")));
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
        /// Unique identifier of the object with which the appointment is associated.
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
        /// Enter the account, contact, lead, user, or other equipment resources that are required to attend the appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredattendees")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> RequiredAttendees
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("requiredattendees");
                if (((collection != null)
                            && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Select<Microsoft.Xrm.Sdk.Entity, Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>(collection.Entities, e => e.ToEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>());
                }
                else
                {
                    return null;
                }
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("RequiredAttendees");
                if ((value == null))
                {
                    this.SetAttributeValue("requiredattendees", value);
                }
                else
                {
                    this.SetAttributeValue("requiredattendees", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("RequiredAttendees");
            }
        }

        /// <summary>
        /// Shows the expected duration of the appointment, in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduledDurationMinutes");
                this.SetAttributeValue("scheduleddurationminutes", value);
                this.OnPropertyChanged("ScheduledDurationMinutes");
            }
        }

        /// <summary>
        /// Enter the expected due date and time for the activity to be completed to provide details about the timing of the appointment.
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
        /// Enter the expected start date and time for the activity to provide details about the timing of the appointment.
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
        /// Shows the ID of the recurring series of an instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("seriesid")]
        public System.Nullable<System.Guid> SeriesId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("seriesid");
            }
        }

        /// <summary>
        /// service_appointments
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
        /// Choose the service level agreement (SLA) that you want to apply to the appointment record.
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
        /// Last SLA that was applied to this appointment. This field is for internal use only.
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
        /// Shows whether the appointment is open, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.AppointmentState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.AppointmentState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.AppointmentState), optionSet.Value)));
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
        /// Select the appointment's status.
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
        /// Select the appointment's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Appointment_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Appointment_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// Type a subcategory to identify the appointment type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the appointment.
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
        /// Version number of the appointment.
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
        /// 1:N appointment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> appointment_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("appointment_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("appointment_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("appointment_activity_parties", null, value);
                this.OnPropertyChanged("appointment_activity_parties");
            }
        }

        /// <summary>
        /// N:1 Account_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account Account_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Appointments", null, value);
                this.OnPropertyChanged("Account_Appointments");
            }
        }

        /// <summary>
        /// N:1 Contact_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact Contact_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("Contact_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Contact_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("Contact_Appointments", null, value);
                this.OnPropertyChanged("Contact_Appointments");
            }
        }

        /// <summary>
        /// N:1 lk_appointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_appointment_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_createdby", null, value);
                this.OnPropertyChanged("lk_appointment_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_appointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_appointment_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_appointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_appointment_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_modifiedby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_appointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_appointment_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_appointment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity Opportunity_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("Opportunity_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Opportunity_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("Opportunity_Appointments", null, value);
                this.OnPropertyChanged("Opportunity_Appointments");
            }
        }

        /// <summary>
        /// N:1 orb_machine_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_machine_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine orb_machine_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_machine_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_machine_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_machine_Appointments", null, value);
                this.OnPropertyChanged("orb_machine_Appointments");
            }
        }

        /// <summary>
        /// N:1 Quote_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Quote Quote_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("Quote_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Quote_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("Quote_Appointments", null, value);
                this.OnPropertyChanged("Quote_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_apimonitor_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_apimonitor_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor rbtt_apimonitor_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("rbtt_apimonitor_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_apimonitor_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("rbtt_apimonitor_Appointments", null, value);
                this.OnPropertyChanged("rbtt_apimonitor_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_appliance_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_appliance_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance rbtt_appliance_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_appliance_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_appliance_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_appliance_Appointments", null, value);
                this.OnPropertyChanged("rbtt_appliance_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_applicationid_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_applicationid_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid rbtt_applicationid_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_applicationid_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_applicationid_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_applicationid_Appointments", null, value);
                this.OnPropertyChanged("rbtt_applicationid_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_configurations_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_configurations_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations rbtt_configurations_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("rbtt_configurations_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_configurations_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("rbtt_configurations_Appointments", null, value);
                this.OnPropertyChanged("rbtt_configurations_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_consent_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consent_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent rbtt_consent_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_consent_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consent_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_consent_Appointments", null, value);
                this.OnPropertyChanged("rbtt_consent_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_consenttext_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consenttext_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext rbtt_consenttext_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_consenttext_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consenttext_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_consenttext_Appointments", null, value);
                this.OnPropertyChanged("rbtt_consenttext_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_customermasterdataexchange_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_customermasterdataexchange_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange rbtt_customermasterdataexchange_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_customermasterdataexchange_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_customermasterdataexchange_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_customermasterdataexchange_Appointments", null, value);
                this.OnPropertyChanged("rbtt_customermasterdataexchange_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_delivernote_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_delivernote_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote rbtt_delivernote_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_delivernote_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_delivernote_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_delivernote_Appointments", null, value);
                this.OnPropertyChanged("rbtt_delivernote_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_processingactivity_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_processingactivity_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity rbtt_processingactivity_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_processingactivity_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_processingactivity_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_processingactivity_Appointments", null, value);
                this.OnPropertyChanged("rbtt_processingactivity_Appointments");
            }
        }

        /// <summary>
        /// N:1 rbtt_productionplants_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_productionplants_Appointments")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants rbtt_productionplants_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_productionplants_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_productionplants_Appointments");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_productionplants_Appointments", null, value);
                this.OnPropertyChanged("rbtt_productionplants_Appointments");
            }
        }

        /// <summary>
        /// N:1 user_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_appointment")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_appointment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_appointment", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_appointment");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_appointment", null, value);
                this.OnPropertyChanged("user_appointment");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Appointment(object anonymousType) :
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