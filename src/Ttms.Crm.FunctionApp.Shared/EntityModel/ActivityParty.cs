namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    /// <summary>
    /// Person or group associated with an activity. An activity can have multiple activity parties.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
    public partial class ActivityParty : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string ActivityId = "activityid";
            public const string ActivityPartyId = "activitypartyid";
            public const string Id = "activitypartyid";
            public const string AddressUsed = "addressused";
            public const string AddressUsedEmailColumnNumber = "addressusedemailcolumnnumber";
            public const string DoNotEmail = "donotemail";
            public const string DoNotFax = "donotfax";
            public const string DoNotPhone = "donotphone";
            public const string DoNotPostalMail = "donotpostalmail";
            public const string Effort = "effort";
            public const string ExchangeEntryId = "exchangeentryid";
            public const string InstanceTypeCode = "instancetypecode";
            public const string IsPartyDeleted = "ispartydeleted";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningUser = "owninguser";
            public const string ParticipationTypeMask = "participationtypemask";
            public const string PartyId = "partyid";
            public const string ResourceSpecId = "resourcespecid";
            public const string ScheduledEnd = "scheduledend";
            public const string ScheduledStart = "scheduledstart";
            public const string VersionNumber = "versionnumber";
            public const string account_activity_parties = "account_activity_parties";
            public const string appointment_activity_parties = "appointment_activity_parties";
            public const string contact_activity_parties = "contact_activity_parties";
            public const string email_activity_parties = "email_activity_parties";
            public const string opportunity_activity_parties = "opportunity_activity_parties";
            public const string quote_activity_parties = "quote_activity_parties";
            public const string system_user_activity_parties = "system_user_activity_parties";
            public const string task_activity_parties = "task_activity_parties";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public ActivityParty() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "activityparty";

        public const string EntitySchemaName = "ActivityParty";

        public const string PrimaryIdAttribute = "activitypartyid";

        public const string PrimaryNameAttribute = "partyidname";

        public const string EntityLogicalCollectionName = "activityparties";

        public const string EntitySetName = "activityparties";

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
        /// quoteclose_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public Microsoft.Xrm.Sdk.EntityReference ActivityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActivityId");
                this.SetAttributeValue("activityid", value);
                this.OnPropertyChanged("ActivityId");
            }
        }

        /// <summary>
        /// Unique identifier of the activity party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
        public System.Nullable<System.Guid> ActivityPartyId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ActivityPartyId");
                this.SetAttributeValue("activitypartyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ActivityPartyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
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
                this.ActivityPartyId = value;
            }
        }

        /// <summary>
        /// Email address to which an email is delivered, and which is associated with the target entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
        public string AddressUsed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("addressused");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AddressUsed");
                this.SetAttributeValue("addressused", value);
                this.OnPropertyChanged("AddressUsed");
            }
        }

        /// <summary>
        /// Email address column number from associated party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressusedemailcolumnnumber")]
        public System.Nullable<int> AddressUsedEmailColumnNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("addressusedemailcolumnnumber");
            }
        }

        /// <summary>
        /// Information about whether to allow sending email to the activity party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEmail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
            }
        }

        /// <summary>
        /// Information about whether to allow sending faxes to the activity party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
            }
        }

        /// <summary>
        /// Information about whether to allow phone calls to the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
            }
        }

        /// <summary>
        /// Information about whether to allow sending postal mail to the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
            }
        }

        /// <summary>
        /// Amount of effort used by the resource in a service appointment activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
        public System.Nullable<double> Effort
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("effort");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Effort");
                this.SetAttributeValue("effort", value);
                this.OnPropertyChanged("Effort");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
        public string ExchangeEntryId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("exchangeentryid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ExchangeEntryId");
                this.SetAttributeValue("exchangeentryid", value);
                this.OnPropertyChanged("ExchangeEntryId");
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
        public virtual ActivityParty_InstanceTypeCode? InstanceTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((ActivityParty_InstanceTypeCode?)(EntityOptionSetEnum.GetEnum(this, "instancetypecode")));
            }
        }

        /// <summary>
        /// Information about whether the underlying entity record is deleted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
        public System.Nullable<bool> IsPartyDeleted
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the activity_party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
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
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser");
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
        /// Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
        public Microsoft.Xrm.Sdk.OptionSetValue ParticipationTypeMask
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("participationtypemask");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParticipationTypeMask");
                this.SetAttributeValue("participationtypemask", value);
                this.OnPropertyChanged("ParticipationTypeMask");
            }
        }

        /// <summary>
        /// Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
        public virtual ActivityParty_ParticipationTypeMask? ParticipationTypeMaskEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((ActivityParty_ParticipationTypeMask?)(EntityOptionSetEnum.GetEnum(this, "participationtypemask")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParticipationTypeMask");
                this.SetAttributeValue("participationtypemask", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("ParticipationTypeMask");
            }
        }

        /// <summary>
        /// salesorder_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        public Microsoft.Xrm.Sdk.EntityReference PartyId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PartyId");
                this.SetAttributeValue("partyid", value);
                this.OnPropertyChanged("PartyId");
            }
        }

        /// <summary>
        /// ActivityPartyResourceSpec
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
        public Microsoft.Xrm.Sdk.EntityReference ResourceSpecId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ResourceSpecId");
                this.SetAttributeValue("resourcespecid", value);
                this.OnPropertyChanged("ResourceSpecId");
            }
        }

        /// <summary>
        /// Scheduled end time of the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
            }
        }

        /// <summary>
        /// Scheduled start time of the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
            }
        }

        /// <summary>
        ///
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
        /// N:1 account_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account account_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("account_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_activity_parties", null, value);
                this.OnPropertyChanged("account_activity_parties");
            }
        }

        /// <summary>
        /// N:1 appointment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment appointment_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("appointment_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("appointment_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("appointment_activity_parties", null, value);
                this.OnPropertyChanged("appointment_activity_parties");
            }
        }

        /// <summary>
        /// N:1 contact_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact contact_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contact_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_activity_parties", null, value);
                this.OnPropertyChanged("contact_activity_parties");
            }
        }

        /// <summary>
        /// N:1 email_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Email email_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("email_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("email_activity_parties", null, value);
                this.OnPropertyChanged("email_activity_parties");
            }
        }

        /// <summary>
        /// N:1 opportunity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity opportunity_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_activity_parties", null, value);
                this.OnPropertyChanged("opportunity_activity_parties");
            }
        }

        /// <summary>
        /// N:1 quote_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Quote quote_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("quote_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("quote_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("quote_activity_parties", null, value);
                this.OnPropertyChanged("quote_activity_parties");
            }
        }

        /// <summary>
        /// N:1 system_user_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser system_user_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_activity_parties", null, value);
                this.OnPropertyChanged("system_user_activity_parties");
            }
        }

        /// <summary>
        /// N:1 task_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_activity_parties")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Task task_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("task_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("task_activity_parties");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("task_activity_parties", null, value);
                this.OnPropertyChanged("task_activity_parties");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public ActivityParty(object anonymousType) :
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
                        Attributes["activitypartyid"] = base.Id;
                        break;
                    case "activitypartyid":
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