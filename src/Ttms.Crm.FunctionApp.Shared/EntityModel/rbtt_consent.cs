namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_consentState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Consent
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("rbtt_consent")]
    public partial class rbtt_consent : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
            public const string rbtt_Acceptedon = "rbtt_acceptedon";
            public const string rbtt_Allactivities = "rbtt_allactivities";
            public const string rbtt_BusinessActivity = "rbtt_businessactivity";
            public const string rbtt_Consent2 = "rbtt_consent2";
            public const string rbtt_consentId = "rbtt_consentid";
            public const string Id = "rbtt_consentid";
            public const string rbtt_ConsentName = "rbtt_consentname";
            public const string rbtt_ConsentTexts = "rbtt_consenttexts";
            public const string rbtt_Contact2 = "rbtt_contact2";
            public const string rbtt_ContactMethode = "rbtt_contactmethode";
            public const string rbtt_Country = "rbtt_country";
            public const string rbtt_Email = "rbtt_email";
            public const string rbtt_ExternalID = "rbtt_externalid";
            public const string rbtt_Fax = "rbtt_fax";
            public const string rbtt_GDPRLockConsents = "rbtt_gdprlockconsents";
            public const string rbtt_GDPRTrackingDate = "rbtt_gdprtrackingdate";
            public const string rbtt_InternalComments = "rbtt_internalcomments";
            public const string rbtt_IsBlocked = "rbtt_isblocked";
            public const string rbtt_LastActivity = "rbtt_lastactivity";
            public const string rbtt_LegalObligation = "rbtt_legalobligation";
            public const string rbtt_Legitimateinterest = "rbtt_legitimateinterest";
            public const string rbtt_Letter = "rbtt_letter";
            public const string rbtt_Mobilephone = "rbtt_mobilephone";
            public const string rbtt_Phone = "rbtt_phone";
            public const string rbtt_ProcessingActivity = "rbtt_processingactivity";
            public const string rbtt_Public = "rbtt_public";
            public const string rbtt_SourceApplication = "rbtt_sourceapplication";
            public const string rbtt_SourceApplication2 = "rbtt_sourceapplication2";
            public const string rbtt_StorageLocation = "rbtt_storagelocation";
            public const string rbtt_StorageTyp = "rbtt_storagetyp";
            public const string rbtt_Validtill = "rbtt_validtill";
            public const string rbtt_Version = "rbtt_version";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_rbtt_consent_createdby = "lk_rbtt_consent_createdby";
            public const string lk_rbtt_consent_createdonbehalfby = "lk_rbtt_consent_createdonbehalfby";
            public const string lk_rbtt_consent_modifiedby = "lk_rbtt_consent_modifiedby";
            public const string lk_rbtt_consent_modifiedonbehalfby = "lk_rbtt_consent_modifiedonbehalfby";
            public const string rbtt_contact_rbtt_consent_Contact2 = "rbtt_contact_rbtt_consent_Contact2";
            public const string rbtt_orb_country_rbtt_consent_Country = "rbtt_orb_country_rbtt_consent_Country";
            public const string rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2 = "rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2";
            public const string rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts = "rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts";
            public const string rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity = "rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_consent() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "rbtt_consent";

        public const string EntitySchemaName = "rbtt_consent";

        public const string PrimaryIdAttribute = "rbtt_consentid";

        public const string PrimaryNameAttribute = "rbtt_consentname";

        public const string EntityLogicalCollectionName = "rbtt_consents";

        public const string EntitySetName = "rbtt_consents";

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
        /// Accepted on
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_acceptedon")]
        public System.Nullable<System.DateTime> rbtt_Acceptedon
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_acceptedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Acceptedon");
                this.SetAttributeValue("rbtt_acceptedon", value);
                this.OnPropertyChanged("rbtt_Acceptedon");
            }
        }

        /// <summary>
        /// All activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_allactivities")]
        public System.Nullable<bool> rbtt_Allactivities
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_allactivities");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Allactivities");
                this.SetAttributeValue("rbtt_allactivities", value);
                this.OnPropertyChanged("rbtt_Allactivities");
            }
        }

        /// <summary>
        /// Business Activity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_businessactivity")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_BusinessActivity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_businessactivity");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_BusinessActivity");
                this.SetAttributeValue("rbtt_businessactivity", value);
                this.OnPropertyChanged("rbtt_BusinessActivity");
            }
        }

        /// <summary>
        /// Business Activity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_businessactivity")]
        public virtual rbtt_ConsentActivityTypes? rbtt_BusinessActivityEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_ConsentActivityTypes?)(EntityOptionSetEnum.GetEnum(this, "rbtt_businessactivity")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_BusinessActivity");
                this.SetAttributeValue("rbtt_businessactivity", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_BusinessActivity");
            }
        }

        /// <summary>
        /// Explecit Consent
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_consent2")]
        public System.Nullable<bool> rbtt_Consent2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_consent2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Consent2");
                this.SetAttributeValue("rbtt_consent2", value);
                this.OnPropertyChanged("rbtt_Consent2");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_consentid")]
        public System.Nullable<System.Guid> rbtt_consentId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("rbtt_consentid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consentId");
                this.SetAttributeValue("rbtt_consentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("rbtt_consentId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_consentid")]
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
                this.rbtt_consentId = value;
            }
        }

        /// <summary>
        /// The name of the custom entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_consentname")]
        public string rbtt_ConsentName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_consentname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ConsentName");
                this.SetAttributeValue("rbtt_consentname", value);
                this.OnPropertyChanged("rbtt_ConsentName");
            }
        }

        /// <summary>
        /// Consent Texts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_consenttexts")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ConsentTexts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_consenttexts");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ConsentTexts");
                this.SetAttributeValue("rbtt_consenttexts", value);
                this.OnPropertyChanged("rbtt_ConsentTexts");
            }
        }

        /// <summary>
        /// Customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_contact2")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Contact2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_contact2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Contact2");
                this.SetAttributeValue("rbtt_contact2", value);
                this.OnPropertyChanged("rbtt_Contact2");
            }
        }

        /// <summary>
        /// Contact Method
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_contactmethode")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_ContactMethode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_contactmethode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ContactMethode");
                this.SetAttributeValue("rbtt_contactmethode", value);
                this.OnPropertyChanged("rbtt_ContactMethode");
            }
        }

        /// <summary>
        /// Contact Method
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_contactmethode")]
        public virtual rbtt_consentactivities? rbtt_ContactMethodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_consentactivities?)(EntityOptionSetEnum.GetEnum(this, "rbtt_contactmethode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ContactMethode");
                this.SetAttributeValue("rbtt_contactmethode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_ContactMethode");
            }
        }

        /// <summary>
        /// Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Country");
                this.SetAttributeValue("rbtt_country", value);
                this.OnPropertyChanged("rbtt_Country");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_email")]
        public System.Nullable<bool> rbtt_Email
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_email");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Email");
                this.SetAttributeValue("rbtt_email", value);
                this.OnPropertyChanged("rbtt_Email");
            }
        }

        /// <summary>
        /// External ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_externalid")]
        public string rbtt_ExternalID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_externalid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ExternalID");
                this.SetAttributeValue("rbtt_externalid", value);
                this.OnPropertyChanged("rbtt_ExternalID");
            }
        }

        /// <summary>
        /// Fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_fax")]
        public System.Nullable<bool> rbtt_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Fax");
                this.SetAttributeValue("rbtt_fax", value);
                this.OnPropertyChanged("rbtt_Fax");
            }
        }

        /// <summary>
        /// GDPR Lock Consents
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdprlockconsents")]
        public System.Nullable<bool> rbtt_GDPRLockConsents
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_gdprlockconsents");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GDPRLockConsents");
                this.SetAttributeValue("rbtt_gdprlockconsents", value);
                this.OnPropertyChanged("rbtt_GDPRLockConsents");
            }
        }

        /// <summary>
        /// GDPR Tracking Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdprtrackingdate")]
        public System.Nullable<System.DateTime> rbtt_GDPRTrackingDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_gdprtrackingdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GDPRTrackingDate");
                this.SetAttributeValue("rbtt_gdprtrackingdate", value);
                this.OnPropertyChanged("rbtt_GDPRTrackingDate");
            }
        }

        /// <summary>
        /// Internal Comments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_internalcomments")]
        public string rbtt_InternalComments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_internalcomments");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_InternalComments");
                this.SetAttributeValue("rbtt_internalcomments", value);
                this.OnPropertyChanged("rbtt_InternalComments");
            }
        }

        /// <summary>
        /// Is Blocked
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_isblocked")]
        public System.Nullable<bool> rbtt_IsBlocked
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_isblocked");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_IsBlocked");
                this.SetAttributeValue("rbtt_isblocked", value);
                this.OnPropertyChanged("rbtt_IsBlocked");
            }
        }

        /// <summary>
        /// Last Activity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_lastactivity")]
        public System.Nullable<System.DateTime> rbtt_LastActivity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_lastactivity");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LastActivity");
                this.SetAttributeValue("rbtt_lastactivity", value);
                this.OnPropertyChanged("rbtt_LastActivity");
            }
        }

        /// <summary>
        /// Legal Obligation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_legalobligation")]
        public System.Nullable<bool> rbtt_LegalObligation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_legalobligation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LegalObligation");
                this.SetAttributeValue("rbtt_legalobligation", value);
                this.OnPropertyChanged("rbtt_LegalObligation");
            }
        }

        /// <summary>
        /// Legitimate interest
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_legitimateinterest")]
        public System.Nullable<bool> rbtt_Legitimateinterest
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_legitimateinterest");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Legitimateinterest");
                this.SetAttributeValue("rbtt_legitimateinterest", value);
                this.OnPropertyChanged("rbtt_Legitimateinterest");
            }
        }

        /// <summary>
        /// Letter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_letter")]
        public System.Nullable<bool> rbtt_Letter
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_letter");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Letter");
                this.SetAttributeValue("rbtt_letter", value);
                this.OnPropertyChanged("rbtt_Letter");
            }
        }

        /// <summary>
        /// Mobile phone
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_mobilephone")]
        public System.Nullable<bool> rbtt_Mobilephone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_mobilephone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Mobilephone");
                this.SetAttributeValue("rbtt_mobilephone", value);
                this.OnPropertyChanged("rbtt_Mobilephone");
            }
        }

        /// <summary>
        /// Phone
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_phone")]
        public System.Nullable<bool> rbtt_Phone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_phone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Phone");
                this.SetAttributeValue("rbtt_phone", value);
                this.OnPropertyChanged("rbtt_Phone");
            }
        }

        /// <summary>
        /// Processing Activity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_processingactivity")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ProcessingActivity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_processingactivity");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProcessingActivity");
                this.SetAttributeValue("rbtt_processingactivity", value);
                this.OnPropertyChanged("rbtt_ProcessingActivity");
            }
        }

        /// <summary>
        /// Public
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_public")]
        public System.Nullable<bool> rbtt_Public
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_public");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Public");
                this.SetAttributeValue("rbtt_public", value);
                this.OnPropertyChanged("rbtt_Public");
            }
        }

        /// <summary>
        /// Old Source Application
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_sourceapplication")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_SourceApplication
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_sourceapplication");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SourceApplication");
                this.SetAttributeValue("rbtt_sourceapplication", value);
                this.OnPropertyChanged("rbtt_SourceApplication");
            }
        }

        /// <summary>
        /// Old Source Application
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_sourceapplication")]
        public virtual rbtt_SystemList? rbtt_SourceApplicationEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_SystemList?)(EntityOptionSetEnum.GetEnum(this, "rbtt_sourceapplication")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SourceApplication");
                this.SetAttributeValue("rbtt_sourceapplication", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_SourceApplication");
            }
        }

        /// <summary>
        /// Source Application
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_sourceapplication2")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_SourceApplication2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_sourceapplication2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SourceApplication2");
                this.SetAttributeValue("rbtt_sourceapplication2", value);
                this.OnPropertyChanged("rbtt_SourceApplication2");
            }
        }

        /// <summary>
        /// Detailed information, where the consent could be found
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_storagelocation")]
        public string rbtt_StorageLocation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_storagelocation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_StorageLocation");
                this.SetAttributeValue("rbtt_storagelocation", value);
                this.OnPropertyChanged("rbtt_StorageLocation");
            }
        }

        /// <summary>
        /// How is the consent stored
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_storagetyp")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_StorageTyp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_storagetyp");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_StorageTyp");
                this.SetAttributeValue("rbtt_storagetyp", value);
                this.OnPropertyChanged("rbtt_StorageTyp");
            }
        }

        /// <summary>
        /// How is the consent stored
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_storagetyp")]
        public virtual rbtt_consent_rbtt_StorageTyp? rbtt_StorageTypEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_consent_rbtt_StorageTyp?)(EntityOptionSetEnum.GetEnum(this, "rbtt_storagetyp")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_StorageTyp");
                this.SetAttributeValue("rbtt_storagetyp", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_StorageTyp");
            }
        }

        /// <summary>
        /// Valid till
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_validtill")]
        public System.Nullable<System.DateTime> rbtt_Validtill
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_validtill");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Validtill");
                this.SetAttributeValue("rbtt_validtill", value);
                this.OnPropertyChanged("rbtt_Validtill");
            }
        }

        /// <summary>
        /// Privacy Notice
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_version")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Version
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_version");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Version");
                this.SetAttributeValue("rbtt_version", value);
                this.OnPropertyChanged("rbtt_Version");
            }
        }

        /// <summary>
        /// Status of the Consent
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consentState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consentState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consentState), optionSet.Value)));
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
        /// Reason for the status of the Consent
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
        /// Reason for the status of the Consent
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual rbtt_consent_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_consent_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N rbtt_consent_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consent_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> rbtt_consent_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_consent_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consent_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_consent_Appointments", null, value);
                this.OnPropertyChanged("rbtt_consent_Appointments");
            }
        }

        /// <summary>
        /// 1:N rbtt_consent_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consent_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> rbtt_consent_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_consent_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consent_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_consent_Emails", null, value);
                this.OnPropertyChanged("rbtt_consent_Emails");
            }
        }

        /// <summary>
        /// 1:N rbtt_consent_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_consent_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> rbtt_consent_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_consent_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_consent_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_consent_Tasks", null, value);
                this.OnPropertyChanged("rbtt_consent_Tasks");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_consent_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_consent_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_consent_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_consent_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_consent_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_consent_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_consent_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_consent_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_consent_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 rbtt_contact_rbtt_consent_Contact2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_contact2")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_rbtt_consent_Contact2")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact rbtt_contact_rbtt_consent_Contact2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_rbtt_consent_Contact2", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_rbtt_consent_Contact2");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_rbtt_consent_Contact2", null, value);
                this.OnPropertyChanged("rbtt_contact_rbtt_consent_Contact2");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_rbtt_consent_Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_rbtt_consent_Country")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_rbtt_consent_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_consent_Country", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_rbtt_consent_Country");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_consent_Country", null, value);
                this.OnPropertyChanged("rbtt_orb_country_rbtt_consent_Country");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_sourceapplication2")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2", null, value);
                this.OnPropertyChanged("rbtt_rbtt_applicationid_rbtt_consent_SourceApplication2");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_consenttexts")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts", null, value);
                this.OnPropertyChanged("rbtt_rbtt_consenttext_rbtt_consent_ConsentTexts");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_processingactivity")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity", null, value);
                this.OnPropertyChanged("rbtt_rbtt_processingactivity_rbtt_consent_ProcessingActivity");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_consent(object anonymousType) :
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
                        Attributes["rbtt_consentid"] = base.Id;
                        break;
                    case "rbtt_consentid":
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