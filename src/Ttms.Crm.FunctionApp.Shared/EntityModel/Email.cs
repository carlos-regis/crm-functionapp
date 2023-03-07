namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum EmailState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Completed = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Canceled = 2,
    }

    /// <summary>
    /// Activity that is delivered using email protocols.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("email")]
    public partial class Email : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
            public const string AttachmentOpenCount = "attachmentopencount";
            public const string BaseConversationIndexHash = "baseconversationindexhash";
            public const string Bcc = "bcc";
            public const string Btt_Cost = "btt_cost";
            public const string btt_cost_Base = "btt_cost_base";
            public const string Btt_dateandtime = "btt_dateandtime";
            public const string Btt_mileage = "btt_mileage";
            public const string Category = "category";
            public const string Cc = "cc";
            public const string Compressed = "compressed";
            public const string ConversationIndex = "conversationindex";
            public const string ConversationTrackingId = "conversationtrackingid";
            public const string CorrelatedActivityId = "correlatedactivityid";
            public const string CorrelationMethod = "correlationmethod";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string DelayedEmailSendTime = "delayedemailsendtime";
            public const string DeliveryAttempts = "deliveryattempts";
            public const string DeliveryPriorityCode = "deliveryprioritycode";
            public const string DeliveryReceiptRequested = "deliveryreceiptrequested";
            public const string Description = "description";
            public const string DirectionCode = "directioncode";
            public const string EmailReminderExpiryTime = "emailreminderexpirytime";
            public const string EmailReminderStatus = "emailreminderstatus";
            public const string EmailReminderText = "emailremindertext";
            public const string EmailReminderType = "emailremindertype";
            public const string EmailSender = "emailsender";
            public const string EmailTrackingId = "emailtrackingid";
            public const string ExchangeRate = "exchangerate";
            public const string FollowEmailUserPreference = "followemailuserpreference";
            public const string From = "from";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string InReplyTo = "inreplyto";
            public const string IsBilled = "isbilled";
            public const string IsEmailFollowed = "isemailfollowed";
            public const string IsEmailReminderSet = "isemailreminderset";
            public const string IsRegularActivity = "isregularactivity";
            public const string IsUnsafe = "isunsafe";
            public const string IsWorkflowCreated = "isworkflowcreated";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string LastOpenedTime = "lastopenedtime";
            public const string LinksClickedCount = "linksclickedcount";
            public const string MessageId = "messageid";
            public const string MessageIdDupCheck = "messageiddupcheck";
            public const string MimeType = "mimetype";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Notifications = "notifications";
            public const string OnHoldTime = "onholdtime";
            public const string OpenCount = "opencount";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string ParentActivityId = "parentactivityid";
            public const string PostponeEmailProcessingUntil = "postponeemailprocessinguntil";
            public const string PriorityCode = "prioritycode";
            public const string ProcessId = "processid";
            public const string ReadReceiptRequested = "readreceiptrequested";
            public const string RegardingObjectId = "regardingobjectid";
            public const string ReminderActionCardId = "reminderactioncardid";
            public const string ReplyCount = "replycount";
            public const string ReservedForInternalUse = "reservedforinternaluse";
            public const string ScheduledDurationMinutes = "scheduleddurationminutes";
            public const string ScheduledEnd = "scheduledend";
            public const string ScheduledStart = "scheduledstart";
            public const string Sender = "sender";
            public const string SenderMailboxId = "sendermailboxid";
            public const string SendersAccount = "sendersaccount";
            public const string SentOn = "senton";
            public const string ServiceId = "serviceid";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string SortDate = "sortdate";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string Subcategory = "subcategory";
            public const string Subject = "subject";
            public const string SubmittedBy = "submittedby";
            public const string TemplateId = "templateid";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string To = "to";
            public const string ToRecipients = "torecipients";
            public const string TrackingToken = "trackingtoken";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string Account_Email_EmailSender = "Account_Email_EmailSender";
            public const string Account_Email_SendersAccount = "Account_Email_SendersAccount";
            public const string Account_Emails = "Account_Emails";
            public const string Contact_Email_EmailSender = "Contact_Email_EmailSender";
            public const string Contact_Emails = "Contact_Emails";
            public const string Referencingemail_email_CorrelatedActivityId = "email_email_CorrelatedActivityId";
            public const string Referencingemail_email_parentactivityid = "email_email_parentactivityid";
            public const string lk_email_createdby = "lk_email_createdby";
            public const string lk_email_createdonbehalfby = "lk_email_createdonbehalfby";
            public const string lk_email_modifiedby = "lk_email_modifiedby";
            public const string lk_email_modifiedonbehalfby = "lk_email_modifiedonbehalfby";
            public const string Opportunity_Emails = "Opportunity_Emails";
            public const string orb_machine_Emails = "orb_machine_Emails";
            public const string Quote_Emails = "Quote_Emails";
            public const string rbtt_apimonitor_Emails = "rbtt_apimonitor_Emails";
            public const string rbtt_appliance_Emails = "rbtt_appliance_Emails";
            public const string rbtt_applicationid_Emails = "rbtt_applicationid_Emails";
            public const string rbtt_configurations_Emails = "rbtt_configurations_Emails";
            public const string rbtt_consent_Emails = "rbtt_consent_Emails";
            public const string rbtt_consenttext_Emails = "rbtt_consenttext_Emails";
            public const string rbtt_customermasterdataexchange_Emails = "rbtt_customermasterdataexchange_Emails";
            public const string rbtt_delivernote_Emails = "rbtt_delivernote_Emails";
            public const string rbtt_processingactivity_Emails = "rbtt_processingactivity_Emails";
            public const string rbtt_productionplants_Emails = "rbtt_productionplants_Emails";
            public const string SystemUser_Email_EmailSender = "SystemUser_Email_EmailSender";
            public const string user_email = "user_email";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Email() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "email";

        public const string EntitySchemaName = "Email";

        public const string PrimaryIdAttribute = "activityid";

        public const string PrimaryNameAttribute = "subject";

        public const string EntityLogicalCollectionName = "emails";

        public const string EntitySetName = "emails";

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
        /// Unique identifier of the email activity.
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
        /// Shows the type of activity.
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
        /// Type the number of minutes spent creating and sending the email. The duration is used in reporting.
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
        /// Enter the actual end date and time of the email. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the email.
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
        /// Enter the actual start date and time for the email. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the email.
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
        /// Shows the umber of attachments of the email message.
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
        /// Shows the number of times an email attachment has been viewed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentopencount")]
        public System.Nullable<int> AttachmentOpenCount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("attachmentopencount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AttachmentOpenCount");
                this.SetAttributeValue("attachmentopencount", value);
                this.OnPropertyChanged("AttachmentOpenCount");
            }
        }

        /// <summary>
        /// Hash of base of conversation index.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseconversationindexhash")]
        public System.Nullable<int> BaseConversationIndexHash
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("baseconversationindexhash");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BaseConversationIndexHash");
                this.SetAttributeValue("baseconversationindexhash", value);
                this.OnPropertyChanged("BaseConversationIndexHash");
            }
        }

        /// <summary>
        /// Enter the recipients that are included on the email distribution, but are not displayed to other recipients.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bcc")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> Bcc
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("bcc");
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
                this.OnPropertyChanging("Bcc");
                if ((value == null))
                {
                    this.SetAttributeValue("bcc", value);
                }
                else
                {
                    this.SetAttributeValue("bcc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Bcc");
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
        /// Type a category to identify the email type, such as lead outreach, customer follow-up, or service alert, to tie the email to a business group or function.
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
        /// Enter the recipients that should be copied on the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cc")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> Cc
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("cc");
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
                this.OnPropertyChanging("Cc");
                if ((value == null))
                {
                    this.SetAttributeValue("cc", value);
                }
                else
                {
                    this.SetAttributeValue("cc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Cc");
            }
        }

        /// <summary>
        /// Indicates if the body is compressed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("compressed")]
        public System.Nullable<bool> Compressed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("compressed");
            }
        }

        /// <summary>
        /// Identifier for all the email responses for this conversation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("conversationindex")]
        public string ConversationIndex
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("conversationindex");
            }
        }

        /// <summary>
        /// Conversation Tracking Id.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("conversationtrackingid")]
        public System.Nullable<System.Guid> ConversationTrackingId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("conversationtrackingid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ConversationTrackingId");
                this.SetAttributeValue("conversationtrackingid", value);
                this.OnPropertyChanged("ConversationTrackingId");
            }
        }

        /// <summary>
        /// Correlated Activity Id
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlatedactivityid")]
        public Microsoft.Xrm.Sdk.EntityReference CorrelatedActivityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("correlatedactivityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CorrelatedActivityId");
                this.SetAttributeValue("correlatedactivityid", value);
                this.OnPropertyChanged("CorrelatedActivityId");
            }
        }

        /// <summary>
        /// Shows how an email is matched to an existing email in Microsoft Dynamics 365. For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationmethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue CorrelationMethod
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("correlationmethod");
            }
        }

        /// <summary>
        /// Shows how an email is matched to an existing email in Microsoft Dynamics 365. For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationmethod")]
        public virtual Email_CorrelationMethod? CorrelationMethodEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Email_CorrelationMethod?)(EntityOptionSetEnum.GetEnum(this, "correlationmethod")));
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
        /// Enter the expected date and time when email will be sent.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("delayedemailsendtime")]
        public System.Nullable<System.DateTime> DelayedEmailSendTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("delayedemailsendtime");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DelayedEmailSendTime");
                this.SetAttributeValue("delayedemailsendtime", value);
                this.OnPropertyChanged("DelayedEmailSendTime");
            }
        }

        /// <summary>
        /// Shows the count of the number of attempts made to send the email. The count is used as an indicator of email routing issues.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryattempts")]
        public System.Nullable<int> DeliveryAttempts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("deliveryattempts");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DeliveryAttempts");
                this.SetAttributeValue("deliveryattempts", value);
                this.OnPropertyChanged("DeliveryAttempts");
            }
        }

        /// <summary>
        /// Select the priority of delivery of the email to the email server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryprioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue DeliveryPriorityCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("deliveryprioritycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DeliveryPriorityCode");
                this.SetAttributeValue("deliveryprioritycode", value);
                this.OnPropertyChanged("DeliveryPriorityCode");
            }
        }

        /// <summary>
        /// Select the priority of delivery of the email to the email server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryprioritycode")]
        public virtual activitypointer_DeliveryPriorityCode? DeliveryPriorityCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((activitypointer_DeliveryPriorityCode?)(EntityOptionSetEnum.GetEnum(this, "deliveryprioritycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DeliveryPriorityCode");
                this.SetAttributeValue("deliveryprioritycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("DeliveryPriorityCode");
            }
        }

        /// <summary>
        /// Select whether the sender should receive confirmation that the email was delivered.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryreceiptrequested")]
        public System.Nullable<bool> DeliveryReceiptRequested
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("deliveryreceiptrequested");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DeliveryReceiptRequested");
                this.SetAttributeValue("deliveryreceiptrequested", value);
                this.OnPropertyChanged("DeliveryReceiptRequested");
            }
        }

        /// <summary>
        /// Type the greeting and message text of the email.
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
        /// Select the direction of the email as incoming or outbound.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("directioncode")]
        public System.Nullable<bool> DirectionCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("directioncode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DirectionCode");
                this.SetAttributeValue("directioncode", value);
                this.OnPropertyChanged("DirectionCode");
            }
        }

        /// <summary>
        /// Shows the date and time when an email reminder expires.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailreminderexpirytime")]
        public System.Nullable<System.DateTime> EmailReminderExpiryTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("emailreminderexpirytime");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailReminderExpiryTime");
                this.SetAttributeValue("emailreminderexpirytime", value);
                this.OnPropertyChanged("EmailReminderExpiryTime");
            }
        }

        /// <summary>
        /// Shows the status of the email reminder.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailreminderstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue EmailReminderStatus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailreminderstatus");
            }
        }

        /// <summary>
        /// Shows the status of the email reminder.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailreminderstatus")]
        public virtual Email_EmailReminderStatus? EmailReminderStatusEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Email_EmailReminderStatus?)(EntityOptionSetEnum.GetEnum(this, "emailreminderstatus")));
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailremindertext")]
        public string EmailReminderText
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("emailremindertext");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailReminderText");
                this.SetAttributeValue("emailremindertext", value);
                this.OnPropertyChanged("EmailReminderText");
            }
        }

        /// <summary>
        /// Shows the type of the email reminder.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailremindertype")]
        public Microsoft.Xrm.Sdk.OptionSetValue EmailReminderType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailremindertype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailReminderType");
                this.SetAttributeValue("emailremindertype", value);
                this.OnPropertyChanged("EmailReminderType");
            }
        }

        /// <summary>
        /// Shows the type of the email reminder.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailremindertype")]
        public virtual Email_EmailReminderType? EmailReminderTypeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Email_EmailReminderType?)(EntityOptionSetEnum.GetEnum(this, "emailremindertype")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailReminderType");
                this.SetAttributeValue("emailremindertype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("EmailReminderType");
            }
        }

        /// <summary>
        /// Equipment_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        public Microsoft.Xrm.Sdk.EntityReference EmailSender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("emailsender");
            }
        }

        /// <summary>
        /// Email Tracking Id.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailtrackingid")]
        public System.Nullable<System.Guid> EmailTrackingId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("emailtrackingid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailTrackingId");
                this.SetAttributeValue("emailtrackingid", value);
                this.OnPropertyChanged("EmailTrackingId");
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
        /// Select whether the email allows following recipient activities sent from Microsoft Dynamics 365.This is user preference state which can be overridden by system evaluated state.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemailuserpreference")]
        public System.Nullable<bool> FollowEmailUserPreference
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("followemailuserpreference");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FollowEmailUserPreference");
                this.SetAttributeValue("followemailuserpreference", value);
                this.OnPropertyChanged("FollowEmailUserPreference");
            }
        }

        /// <summary>
        /// Enter the sender of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("from")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> From
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("from");
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
                this.OnPropertyChanging("From");
                if ((value == null))
                {
                    this.SetAttributeValue("from", value);
                }
                else
                {
                    this.SetAttributeValue("from", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("From");
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
        /// Type the ID of the email message that this email activity is a response to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inreplyto")]
        public string InReplyTo
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("inreplyto");
            }
        }

        /// <summary>
        /// Information regarding whether the email activity was billed as part of resolving a case.
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
        /// For internal use only. Shows whether this email is followed. This is evaluated state which overrides user selection of follow email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailfollowed")]
        public System.Nullable<bool> IsEmailFollowed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isemailfollowed");
            }
        }

        /// <summary>
        /// For internal use only. Shows whether this email Reminder is Set.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailreminderset")]
        public System.Nullable<bool> IsEmailReminderSet
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isemailreminderset");
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
        /// Indication if the email was created by a workflow rule.
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
        /// Shows the latest date and time when email was opened.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastopenedtime")]
        public System.Nullable<System.DateTime> LastOpenedTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastopenedtime");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastOpenedTime");
                this.SetAttributeValue("lastopenedtime", value);
                this.OnPropertyChanged("LastOpenedTime");
            }
        }

        /// <summary>
        /// Shows the number of times a link in an email has been clicked.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linksclickedcount")]
        public System.Nullable<int> LinksClickedCount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("linksclickedcount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LinksClickedCount");
                this.SetAttributeValue("linksclickedcount", value);
                this.OnPropertyChanged("LinksClickedCount");
            }
        }

        /// <summary>
        /// Unique identifier of the email message. Used only for email that is received.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageid")]
        public string MessageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("messageid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MessageId");
                this.SetAttributeValue("messageid", value);
                this.OnPropertyChanged("MessageId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageiddupcheck")]
        [System.ObsoleteAttribute()]
        public System.Nullable<System.Guid> MessageIdDupCheck
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("messageiddupcheck");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MessageIdDupCheck");
                this.SetAttributeValue("messageiddupcheck", value);
                this.OnPropertyChanged("MessageIdDupCheck");
            }
        }

        /// <summary>
        /// MIME type of the email message data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("mimetype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MimeType");
                this.SetAttributeValue("mimetype", value);
                this.OnPropertyChanged("MimeType");
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
        /// Select the notification code to identify issues with the email recipients or attachments, such as blocked attachments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notifications")]
        public Microsoft.Xrm.Sdk.OptionSetValue Notifications
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("notifications");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Notifications");
                this.SetAttributeValue("notifications", value);
                this.OnPropertyChanged("Notifications");
            }
        }

        /// <summary>
        /// Select the notification code to identify issues with the email recipients or attachments, such as blocked attachments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notifications")]
        public virtual Email_Notifications? NotificationsEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Email_Notifications?)(EntityOptionSetEnum.GetEnum(this, "notifications")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Notifications");
                this.SetAttributeValue("notifications", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Notifications");
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
        /// Shows the number of times an email has been opened.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opencount")]
        public System.Nullable<int> OpenCount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("opencount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OpenCount");
                this.SetAttributeValue("opencount", value);
                this.OnPropertyChanged("OpenCount");
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
        /// Unique identifier of the business unit that owns the email activity.
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
        /// Unique identifier of the team who owns the email activity.
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
        /// Unique identifier of the user who owns the email activity.
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
        /// Select the activity that the email is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentactivityid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentActivityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentactivityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentActivityId");
                this.SetAttributeValue("parentactivityid", value);
                this.OnPropertyChanged("ParentActivityId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponeemailprocessinguntil")]
        public System.Nullable<System.DateTime> PostponeEmailProcessingUntil
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponeemailprocessinguntil");
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
        public virtual Email_PriorityCode? PriorityCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Email_PriorityCode?)(EntityOptionSetEnum.GetEnum(this, "prioritycode")));
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
        /// Indicates that a read receipt is requested.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("readreceiptrequested")]
        public System.Nullable<bool> ReadReceiptRequested
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("readreceiptrequested");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ReadReceiptRequested");
                this.SetAttributeValue("readreceiptrequested", value);
                this.OnPropertyChanged("ReadReceiptRequested");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the e-mail is associated.
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
        /// Reminder Action Card Id.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reminderactioncardid")]
        public System.Nullable<System.Guid> ReminderActionCardId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("reminderactioncardid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ReminderActionCardId");
                this.SetAttributeValue("reminderactioncardid", value);
                this.OnPropertyChanged("ReminderActionCardId");
            }
        }

        /// <summary>
        /// Shows the number of replies received for an email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("replycount")]
        public System.Nullable<int> ReplyCount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("replycount");
            }
        }

        /// <summary>
        /// For internal use only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reservedforinternaluse")]
        public string ReservedForInternalUse
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("reservedforinternaluse");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ReservedForInternalUse");
                this.SetAttributeValue("reservedforinternaluse", value);
                this.OnPropertyChanged("ReservedForInternalUse");
            }
        }

        /// <summary>
        /// Scheduled duration of the email activity, specified in minutes.
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
        /// Enter the expected due date and time for the activity to be completed to provide details about when the email will be sent.
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
        /// Enter the expected start date and time for the activity to provide details about the tentative time when the email activity must be initiated.
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
        /// Sender of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sender")]
        public string Sender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("sender");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Sender");
                this.SetAttributeValue("sender", value);
                this.OnPropertyChanged("Sender");
            }
        }

        /// <summary>
        /// Select the mailbox associated with the sender of the email message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendermailboxid")]
        public Microsoft.Xrm.Sdk.EntityReference SenderMailboxId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sendermailboxid");
            }
        }

        /// <summary>
        /// Shows the parent account of the sender of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendersaccount")]
        public Microsoft.Xrm.Sdk.EntityReference SendersAccount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sendersaccount");
            }
        }

        /// <summary>
        /// Shows the date and time that the email was sent.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("senton")]
        public System.Nullable<System.DateTime> SentOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("senton");
            }
        }

        /// <summary>
        /// service_emails
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
        /// Choose the service level agreement (SLA) that you want to apply to the email record.
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
        /// Last SLA that was applied to this email. This field is for internal use only.
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
        /// Shows whether the email is open, completed, or canceled. Completed and canceled email is read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.EmailState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.EmailState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.EmailState), optionSet.Value)));
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
        /// Select the email's status.
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
        /// Select the email's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Email_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Email_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// Type a subcategory to identify the email type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the email.
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
        /// Shows the Microsoft Office Outlook account for the user who submitted the email to Microsoft Dynamics 365.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("submittedby")]
        public string SubmittedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("submittedby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SubmittedBy");
                this.SetAttributeValue("submittedby", value);
                this.OnPropertyChanged("SubmittedBy");
            }
        }

        /// <summary>
        /// For internal use only. ID for template used in email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("templateid")]
        public Microsoft.Xrm.Sdk.EntityReference TemplateId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("templateid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TemplateId");
                this.SetAttributeValue("templateid", value);
                this.OnPropertyChanged("TemplateId");
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
        /// Enter the account, contact, lead, queue, or user recipients for the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("to")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> To
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("to");
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
                this.OnPropertyChanging("To");
                if ((value == null))
                {
                    this.SetAttributeValue("to", value);
                }
                else
                {
                    this.SetAttributeValue("to", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("To");
            }
        }

        /// <summary>
        /// Shows the email addresses corresponding to the recipients.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("torecipients")]
        public string ToRecipients
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("torecipients");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ToRecipients");
                this.SetAttributeValue("torecipients", value);
                this.OnPropertyChanged("ToRecipients");
            }
        }

        /// <summary>
        /// Shows the tracking token assigned to the email to make sure responses are automatically tracked in Microsoft Dynamics 365.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtoken")]
        public string TrackingToken
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("trackingtoken");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TrackingToken");
                this.SetAttributeValue("trackingtoken", value);
                this.OnPropertyChanged("TrackingToken");
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
        /// Version number of the email message.
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
        /// 1:N email_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> email_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("email_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("email_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("email_activity_parties", null, value);
                this.OnPropertyChanged("email_activity_parties");
            }
        }

        /// <summary>
        /// 1:N email_email_CorrelatedActivityId
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_email_CorrelatedActivityId", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Referencedemail_email_CorrelatedActivityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_CorrelatedActivityId", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedemail_email_CorrelatedActivityId");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_CorrelatedActivityId", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedemail_email_CorrelatedActivityId");
            }
        }

        /// <summary>
        /// 1:N email_email_parentactivityid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Referencedemail_email_parentactivityid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedemail_email_parentactivityid");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedemail_email_parentactivityid");
            }
        }

        /// <summary>
        /// N:1 Account_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Email_EmailSender")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account Account_Email_EmailSender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Email_EmailSender", null);
            }
        }

        /// <summary>
        /// N:1 Account_Email_SendersAccount
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendersaccount")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Email_SendersAccount")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account Account_Email_SendersAccount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Email_SendersAccount", null);
            }
        }

        /// <summary>
        /// N:1 Account_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account Account_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("Account_Emails", null, value);
                this.OnPropertyChanged("Account_Emails");
            }
        }

        /// <summary>
        /// N:1 Contact_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Email_EmailSender")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact Contact_Email_EmailSender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("Contact_Email_EmailSender", null);
            }
        }

        /// <summary>
        /// N:1 Contact_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact Contact_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("Contact_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Contact_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("Contact_Emails", null, value);
                this.OnPropertyChanged("Contact_Emails");
            }
        }

        /// <summary>
        /// N:1 email_email_CorrelatedActivityId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlatedactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_email_CorrelatedActivityId", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Email Referencingemail_email_CorrelatedActivityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_CorrelatedActivityId", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingemail_email_CorrelatedActivityId");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_CorrelatedActivityId", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingemail_email_CorrelatedActivityId");
            }
        }

        /// <summary>
        /// N:1 email_email_parentactivityid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Email Referencingemail_email_parentactivityid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingemail_email_parentactivityid");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingemail_email_parentactivityid");
            }
        }

        /// <summary>
        /// N:1 lk_email_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_email_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_createdby", null, value);
                this.OnPropertyChanged("lk_email_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_email_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_email_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_email_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_email_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_modifiedby", null, value);
                this.OnPropertyChanged("lk_email_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_email_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_email_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_email_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity Opportunity_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("Opportunity_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Opportunity_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("Opportunity_Emails", null, value);
                this.OnPropertyChanged("Opportunity_Emails");
            }
        }

        /// <summary>
        /// N:1 orb_machine_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_machine_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine orb_machine_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_machine_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_machine_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_machine_Emails", null, value);
                this.OnPropertyChanged("orb_machine_Emails");
            }
        }

        /// <summary>
        /// N:1 Quote_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Quote Quote_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("Quote_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Quote_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("Quote_Emails", null, value);
                this.OnPropertyChanged("Quote_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_apimonitor_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_apimonitor_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor rbtt_apimonitor_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("rbtt_apimonitor_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_apimonitor_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("rbtt_apimonitor_Emails", null, value);
                this.OnPropertyChanged("rbtt_apimonitor_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_appliance_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_appliance_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance rbtt_appliance_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_appliance_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_appliance_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_appliance_Emails", null, value);
                this.OnPropertyChanged("rbtt_appliance_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_applicationid_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_applicationid_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid rbtt_applicationid_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_applicationid_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_applicationid_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_applicationid_Emails", null, value);
                this.OnPropertyChanged("rbtt_applicationid_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_configurations_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_configurations_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations rbtt_configurations_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("rbtt_configurations_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_configurations_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("rbtt_configurations_Emails", null, value);
                this.OnPropertyChanged("rbtt_configurations_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_consent_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consent_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent rbtt_consent_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_consent_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consent_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_consent_Emails", null, value);
                this.OnPropertyChanged("rbtt_consent_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_consenttext_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consenttext_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext rbtt_consenttext_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_consenttext_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consenttext_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_consenttext_Emails", null, value);
                this.OnPropertyChanged("rbtt_consenttext_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_customermasterdataexchange_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_customermasterdataexchange_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange rbtt_customermasterdataexchange_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_customermasterdataexchange_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_customermasterdataexchange_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_customermasterdataexchange_Emails", null, value);
                this.OnPropertyChanged("rbtt_customermasterdataexchange_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_delivernote_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_delivernote_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote rbtt_delivernote_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_delivernote_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_delivernote_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_delivernote_Emails", null, value);
                this.OnPropertyChanged("rbtt_delivernote_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_processingactivity_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_processingactivity_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity rbtt_processingactivity_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_processingactivity_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_processingactivity_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_processingactivity_Emails", null, value);
                this.OnPropertyChanged("rbtt_processingactivity_Emails");
            }
        }

        /// <summary>
        /// N:1 rbtt_productionplants_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_productionplants_Emails")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants rbtt_productionplants_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_productionplants_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_productionplants_Emails");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_productionplants_Emails", null, value);
                this.OnPropertyChanged("rbtt_productionplants_Emails");
            }
        }

        /// <summary>
        /// N:1 SystemUser_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Email_EmailSender")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser SystemUser_Email_EmailSender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("SystemUser_Email_EmailSender", null);
            }
        }

        /// <summary>
        /// N:1 user_email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_email")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_email
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_email", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_email");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_email", null, value);
                this.OnPropertyChanged("user_email");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Email(object anonymousType) :
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