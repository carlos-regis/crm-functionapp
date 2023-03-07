namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_customermasterdataexchangeState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Customer Master Data Exchange
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("rbtt_customermasterdataexchange")]
    public partial class rbtt_customermasterdataexchange : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
            public const string rbtt_Account = "rbtt_account";
            public const string rbtt_AccountNumber_New = "rbtt_accountnumber_new";
            public const string rbtt_AccountNumber_Old = "rbtt_accountnumber_old";
            public const string rbtt_Blocked_New = "rbtt_blocked_new";
            public const string rbtt_Blocked_Old = "rbtt_blocked_old";
            public const string rbtt_City_New = "rbtt_city_new";
            public const string rbtt_City_Old = "rbtt_city_old";
            public const string rbtt_Code_New = "rbtt_code_new";
            public const string rbtt_Code_Old = "rbtt_code_old";
            public const string rbtt_Country_New = "rbtt_country_new";
            public const string rbtt_Country_New_Address = "rbtt_country_new_address";
            public const string rbtt_Country_Old = "rbtt_country_old";
            public const string rbtt_Country_Old_Address = "rbtt_country_old_address";
            public const string rbtt_customermasterdataexchangeId = "rbtt_customermasterdataexchangeid";
            public const string Id = "rbtt_customermasterdataexchangeid";
            public const string rbtt_Email_New = "rbtt_email_new";
            public const string rbtt_Email_New_Relations = "rbtt_email_new_relations";
            public const string rbtt_Email_Old = "rbtt_email_old";
            public const string rbtt_Email_Old_Relations = "rbtt_email_old_relations";
            public const string rbtt_Fax_New = "rbtt_fax_new";
            public const string rbtt_Fax_Old = "rbtt_fax_old";
            public const string rbtt_HouseNumber_New = "rbtt_housenumber_new";
            public const string rbtt_HouseNumber_Old = "rbtt_housenumber_old";
            public const string rbtt_IsRegisterCustomer = "rbtt_isregistercustomer";
            public const string rbtt_MDCStatus = "rbtt_mdcstatus";
            public const string rbtt_name = "rbtt_name";
            public const string rbtt_Name_New = "rbtt_name_new";
            public const string rbtt_Name_Old = "rbtt_name_old";
            public const string rbtt_Name1_New = "rbtt_name1_new";
            public const string rbtt_Name1_Old = "rbtt_name1_old";
            public const string rbtt_Name2_New = "rbtt_name2_new";
            public const string rbtt_Name2_Old = "rbtt_name2_old";
            public const string rbtt_Name3_New = "rbtt_name3_new";
            public const string rbtt_Name3_Old = "rbtt_name3_old";
            public const string rbtt_Name4_New = "rbtt_name4_new";
            public const string rbtt_Name4_Old = "rbtt_name4_old";
            public const string rbtt_NewBrand = "rbtt_newbrand";
            public const string rbtt_Number_New = "rbtt_number_new";
            public const string rbtt_Number_Old = "rbtt_number_old";
            public const string rbtt_OldBrands = "rbtt_oldbrands";
            public const string rbtt_Phone_New = "rbtt_phone_new";
            public const string rbtt_Phone_Old = "rbtt_phone_old";
            public const string rbtt_PostalCode_New = "rbtt_postalcode_new";
            public const string rbtt_PostalCode_Old = "rbtt_postalcode_old";
            public const string rbtt_ReasonForRejection = "rbtt_reasonforrejection";
            public const string rbtt_Role_New = "rbtt_role_new";
            public const string rbtt_Role_Old = "rbtt_role_old";
            public const string rbtt_Street_New = "rbtt_street_new";
            public const string rbtt_Street_Old = "rbtt_street_old";
            public const string rbtt_Street2_New = "rbtt_street2_new";
            public const string rbtt_Street2_Old = "rbtt_street2_old";
            public const string rbtt_Street3_New = "rbtt_street3_new";
            public const string rbtt_Street3_Old = "rbtt_street3_old";
            public const string rbtt_Title_New = "rbtt_title_new";
            public const string rbtt_Title_Old = "rbtt_title_old";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_rbtt_customermasterdataexchange_createdby = "lk_rbtt_customermasterdataexchange_createdby";
            public const string lk_rbtt_customermasterdataexchange_createdonbehalfby = "lk_rbtt_customermasterdataexchange_createdonbehalfby";
            public const string lk_rbtt_customermasterdataexchange_modifiedby = "lk_rbtt_customermasterdataexchange_modifiedby";
            public const string lk_rbtt_customermasterdataexchange_modifiedonbehalfby = "lk_rbtt_customermasterdataexchange_modifiedonbehalfby";
            public const string rbtt_account_rbtt_customermasterdataexchange_Account = "rbtt_account_rbtt_customermasterdataexchange_Account";
            public const string rbtt_orb_country_rbtt_customermasterdataexchange_Country_New = "rbtt_orb_country_rbtt_customermasterdataexchange_Country_New";
            public const string rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address = "rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address";
            public const string rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old = "rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old";
            public const string rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address = "rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address";
            public const string user_rbtt_customermasterdataexchange = "user_rbtt_customermasterdataexchange";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_customermasterdataexchange() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "rbtt_customermasterdataexchange";

        public const string EntitySchemaName = "rbtt_customermasterdataexchange";

        public const string PrimaryIdAttribute = "rbtt_customermasterdataexchangeid";

        public const string PrimaryNameAttribute = "rbtt_name";

        public const string EntityLogicalCollectionName = "rbtt_customermasterdataexchanges";

        public const string EntitySetName = "rbtt_customermasterdataexchanges";

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
        /// Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_account")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_account");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Account");
                this.SetAttributeValue("rbtt_account", value);
                this.OnPropertyChanged("rbtt_Account");
            }
        }

        /// <summary>
        /// AccountNumber
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_accountnumber_new")]
        public string rbtt_AccountNumber_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_accountnumber_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_AccountNumber_New");
                this.SetAttributeValue("rbtt_accountnumber_new", value);
                this.OnPropertyChanged("rbtt_AccountNumber_New");
            }
        }

        /// <summary>
        /// Account Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_accountnumber_old")]
        public string rbtt_AccountNumber_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_accountnumber_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_AccountNumber_Old");
                this.SetAttributeValue("rbtt_accountnumber_old", value);
                this.OnPropertyChanged("rbtt_AccountNumber_Old");
            }
        }

        /// <summary>
        /// Blocked
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_blocked_new")]
        public System.Nullable<bool> rbtt_Blocked_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_blocked_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Blocked_New");
                this.SetAttributeValue("rbtt_blocked_new", value);
                this.OnPropertyChanged("rbtt_Blocked_New");
            }
        }

        /// <summary>
        /// Blocked
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_blocked_old")]
        public System.Nullable<bool> rbtt_Blocked_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_blocked_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Blocked_Old");
                this.SetAttributeValue("rbtt_blocked_old", value);
                this.OnPropertyChanged("rbtt_Blocked_Old");
            }
        }

        /// <summary>
        /// City
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_city_new")]
        public string rbtt_City_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_city_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_City_New");
                this.SetAttributeValue("rbtt_city_new", value);
                this.OnPropertyChanged("rbtt_City_New");
            }
        }

        /// <summary>
        /// City
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_city_old")]
        public string rbtt_City_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_city_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_City_Old");
                this.SetAttributeValue("rbtt_city_old", value);
                this.OnPropertyChanged("rbtt_City_Old");
            }
        }

        /// <summary>
        /// Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_code_new")]
        public string rbtt_Code_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_code_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Code_New");
                this.SetAttributeValue("rbtt_code_new", value);
                this.OnPropertyChanged("rbtt_Code_New");
            }
        }

        /// <summary>
        /// Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_code_old")]
        public string rbtt_Code_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_code_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Code_Old");
                this.SetAttributeValue("rbtt_code_old", value);
                this.OnPropertyChanged("rbtt_Code_Old");
            }
        }

        /// <summary>
        /// Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_new")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Country_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_country_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Country_New");
                this.SetAttributeValue("rbtt_country_new", value);
                this.OnPropertyChanged("rbtt_Country_New");
            }
        }

        /// <summary>
        /// New Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_new_address")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Country_New_Address
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_country_new_address");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Country_New_Address");
                this.SetAttributeValue("rbtt_country_new_address", value);
                this.OnPropertyChanged("rbtt_Country_New_Address");
            }
        }

        /// <summary>
        /// Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_old")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Country_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_country_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Country_Old");
                this.SetAttributeValue("rbtt_country_old", value);
                this.OnPropertyChanged("rbtt_Country_Old");
            }
        }

        /// <summary>
        /// Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_old_address")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Country_Old_Address
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_country_old_address");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Country_Old_Address");
                this.SetAttributeValue("rbtt_country_old_address", value);
                this.OnPropertyChanged("rbtt_Country_Old_Address");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_customermasterdataexchangeid")]
        public System.Nullable<System.Guid> rbtt_customermasterdataexchangeId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("rbtt_customermasterdataexchangeid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_customermasterdataexchangeId");
                this.SetAttributeValue("rbtt_customermasterdataexchangeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("rbtt_customermasterdataexchangeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_customermasterdataexchangeid")]
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
                this.rbtt_customermasterdataexchangeId = value;
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_email_new")]
        public string rbtt_Email_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_email_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Email_New");
                this.SetAttributeValue("rbtt_email_new", value);
                this.OnPropertyChanged("rbtt_Email_New");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_email_new_relations")]
        public string rbtt_Email_New_Relations
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_email_new_relations");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Email_New_Relations");
                this.SetAttributeValue("rbtt_email_new_relations", value);
                this.OnPropertyChanged("rbtt_Email_New_Relations");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_email_old")]
        public string rbtt_Email_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_email_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Email_Old");
                this.SetAttributeValue("rbtt_email_old", value);
                this.OnPropertyChanged("rbtt_Email_Old");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_email_old_relations")]
        public string rbtt_Email_Old_Relations
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_email_old_relations");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Email_Old_Relations");
                this.SetAttributeValue("rbtt_email_old_relations", value);
                this.OnPropertyChanged("rbtt_Email_Old_Relations");
            }
        }

        /// <summary>
        /// Fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_fax_new")]
        public string rbtt_Fax_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_fax_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Fax_New");
                this.SetAttributeValue("rbtt_fax_new", value);
                this.OnPropertyChanged("rbtt_Fax_New");
            }
        }

        /// <summary>
        /// Fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_fax_old")]
        public string rbtt_Fax_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_fax_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Fax_Old");
                this.SetAttributeValue("rbtt_fax_old", value);
                this.OnPropertyChanged("rbtt_Fax_Old");
            }
        }

        /// <summary>
        /// HouseNumber
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_housenumber_new")]
        public string rbtt_HouseNumber_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_housenumber_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_HouseNumber_New");
                this.SetAttributeValue("rbtt_housenumber_new", value);
                this.OnPropertyChanged("rbtt_HouseNumber_New");
            }
        }

        /// <summary>
        /// HouseNumber
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_housenumber_old")]
        public string rbtt_HouseNumber_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_housenumber_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_HouseNumber_Old");
                this.SetAttributeValue("rbtt_housenumber_old", value);
                this.OnPropertyChanged("rbtt_HouseNumber_Old");
            }
        }

        /// <summary>
        /// Is Register Customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_isregistercustomer")]
        public System.Nullable<bool> rbtt_IsRegisterCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_isregistercustomer");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_IsRegisterCustomer");
                this.SetAttributeValue("rbtt_isregistercustomer", value);
                this.OnPropertyChanged("rbtt_IsRegisterCustomer");
            }
        }

        /// <summary>
        /// MDC Status
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_mdcstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_MDCStatus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_mdcstatus");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_MDCStatus");
                this.SetAttributeValue("rbtt_mdcstatus", value);
                this.OnPropertyChanged("rbtt_MDCStatus");
            }
        }

        /// <summary>
        /// MDC Status
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_mdcstatus")]
        public virtual rbtt_customermasterdataexchange_rbtt_MDCStatus? rbtt_MDCStatusEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_customermasterdataexchange_rbtt_MDCStatus?)(EntityOptionSetEnum.GetEnum(this, "rbtt_mdcstatus")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_MDCStatus");
                this.SetAttributeValue("rbtt_mdcstatus", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_MDCStatus");
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
        /// Name
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name_new")]
        public string rbtt_Name_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name_New");
                this.SetAttributeValue("rbtt_name_new", value);
                this.OnPropertyChanged("rbtt_Name_New");
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name_old")]
        public string rbtt_Name_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name_Old");
                this.SetAttributeValue("rbtt_name_old", value);
                this.OnPropertyChanged("rbtt_Name_Old");
            }
        }

        /// <summary>
        /// Name1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name1_new")]
        public string rbtt_Name1_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name1_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name1_New");
                this.SetAttributeValue("rbtt_name1_new", value);
                this.OnPropertyChanged("rbtt_Name1_New");
            }
        }

        /// <summary>
        /// Name1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name1_old")]
        public string rbtt_Name1_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name1_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name1_Old");
                this.SetAttributeValue("rbtt_name1_old", value);
                this.OnPropertyChanged("rbtt_Name1_Old");
            }
        }

        /// <summary>
        /// Name2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name2_new")]
        public string rbtt_Name2_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name2_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name2_New");
                this.SetAttributeValue("rbtt_name2_new", value);
                this.OnPropertyChanged("rbtt_Name2_New");
            }
        }

        /// <summary>
        /// Name2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name2_old")]
        public string rbtt_Name2_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name2_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name2_Old");
                this.SetAttributeValue("rbtt_name2_old", value);
                this.OnPropertyChanged("rbtt_Name2_Old");
            }
        }

        /// <summary>
        /// Name3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name3_new")]
        public string rbtt_Name3_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name3_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name3_New");
                this.SetAttributeValue("rbtt_name3_new", value);
                this.OnPropertyChanged("rbtt_Name3_New");
            }
        }

        /// <summary>
        /// Name3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name3_old")]
        public string rbtt_Name3_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name3_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name3_Old");
                this.SetAttributeValue("rbtt_name3_old", value);
                this.OnPropertyChanged("rbtt_Name3_Old");
            }
        }

        /// <summary>
        /// Name4
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name4_new")]
        public string rbtt_Name4_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name4_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name4_New");
                this.SetAttributeValue("rbtt_name4_new", value);
                this.OnPropertyChanged("rbtt_Name4_New");
            }
        }

        /// <summary>
        /// Name4
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name4_old")]
        public string rbtt_Name4_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name4_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name4_Old");
                this.SetAttributeValue("rbtt_name4_old", value);
                this.OnPropertyChanged("rbtt_Name4_Old");
            }
        }

        /// <summary>
        /// New Brands
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_newbrand")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_NewBrand
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_newbrand");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_NewBrand");
                this.SetAttributeValue("rbtt_newbrand", value);
                this.OnPropertyChanged("rbtt_NewBrand");
            }
        }

        /// <summary>
        /// New Brands
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_newbrand")]
        public virtual btt_Brands? rbtt_NewBrandEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "rbtt_newbrand")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_NewBrand");
                this.SetAttributeValue("rbtt_newbrand", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_NewBrand");
            }
        }

        /// <summary>
        /// Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_number_new")]
        public string rbtt_Number_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_number_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Number_New");
                this.SetAttributeValue("rbtt_number_new", value);
                this.OnPropertyChanged("rbtt_Number_New");
            }
        }

        /// <summary>
        /// Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_number_old")]
        public string rbtt_Number_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_number_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Number_Old");
                this.SetAttributeValue("rbtt_number_old", value);
                this.OnPropertyChanged("rbtt_Number_Old");
            }
        }

        /// <summary>
        /// Old Brands
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_oldbrands")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_OldBrands
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_oldbrands");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_OldBrands");
                this.SetAttributeValue("rbtt_oldbrands", value);
                this.OnPropertyChanged("rbtt_OldBrands");
            }
        }

        /// <summary>
        /// Old Brands
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_oldbrands")]
        public virtual btt_Brands? rbtt_OldBrandsEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "rbtt_oldbrands")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_OldBrands");
                this.SetAttributeValue("rbtt_oldbrands", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_OldBrands");
            }
        }

        /// <summary>
        /// Phone
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_phone_new")]
        public string rbtt_Phone_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_phone_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Phone_New");
                this.SetAttributeValue("rbtt_phone_new", value);
                this.OnPropertyChanged("rbtt_Phone_New");
            }
        }

        /// <summary>
        /// Phone
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_phone_old")]
        public string rbtt_Phone_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_phone_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Phone_Old");
                this.SetAttributeValue("rbtt_phone_old", value);
                this.OnPropertyChanged("rbtt_Phone_Old");
            }
        }

        /// <summary>
        /// PostalCode
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_postalcode_new")]
        public string rbtt_PostalCode_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_postalcode_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PostalCode_New");
                this.SetAttributeValue("rbtt_postalcode_new", value);
                this.OnPropertyChanged("rbtt_PostalCode_New");
            }
        }

        /// <summary>
        /// PostalCode
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_postalcode_old")]
        public string rbtt_PostalCode_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_postalcode_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PostalCode_Old");
                this.SetAttributeValue("rbtt_postalcode_old", value);
                this.OnPropertyChanged("rbtt_PostalCode_Old");
            }
        }

        /// <summary>
        /// Reason For Rejection
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_reasonforrejection")]
        public string rbtt_ReasonForRejection
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_reasonforrejection");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ReasonForRejection");
                this.SetAttributeValue("rbtt_reasonforrejection", value);
                this.OnPropertyChanged("rbtt_ReasonForRejection");
            }
        }

        /// <summary>
        /// Role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_role_new")]
        public string rbtt_Role_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_role_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Role_New");
                this.SetAttributeValue("rbtt_role_new", value);
                this.OnPropertyChanged("rbtt_Role_New");
            }
        }

        /// <summary>
        /// Role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_role_old")]
        public string rbtt_Role_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_role_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Role_Old");
                this.SetAttributeValue("rbtt_role_old", value);
                this.OnPropertyChanged("rbtt_Role_Old");
            }
        }

        /// <summary>
        /// Street
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_street_new")]
        public string rbtt_Street_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_street_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Street_New");
                this.SetAttributeValue("rbtt_street_new", value);
                this.OnPropertyChanged("rbtt_Street_New");
            }
        }

        /// <summary>
        /// Street
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_street_old")]
        public string rbtt_Street_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_street_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Street_Old");
                this.SetAttributeValue("rbtt_street_old", value);
                this.OnPropertyChanged("rbtt_Street_Old");
            }
        }

        /// <summary>
        /// Street2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_street2_new")]
        public string rbtt_Street2_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_street2_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Street2_New");
                this.SetAttributeValue("rbtt_street2_new", value);
                this.OnPropertyChanged("rbtt_Street2_New");
            }
        }

        /// <summary>
        /// Street2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_street2_old")]
        public string rbtt_Street2_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_street2_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Street2_Old");
                this.SetAttributeValue("rbtt_street2_old", value);
                this.OnPropertyChanged("rbtt_Street2_Old");
            }
        }

        /// <summary>
        /// Street3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_street3_new")]
        public string rbtt_Street3_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_street3_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Street3_New");
                this.SetAttributeValue("rbtt_street3_new", value);
                this.OnPropertyChanged("rbtt_Street3_New");
            }
        }

        /// <summary>
        /// Street3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_street3_old")]
        public string rbtt_Street3_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_street3_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Street3_Old");
                this.SetAttributeValue("rbtt_street3_old", value);
                this.OnPropertyChanged("rbtt_Street3_Old");
            }
        }

        /// <summary>
        /// Title
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_title_new")]
        public string rbtt_Title_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_title_new");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Title_New");
                this.SetAttributeValue("rbtt_title_new", value);
                this.OnPropertyChanged("rbtt_Title_New");
            }
        }

        /// <summary>
        /// Title
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_title_old")]
        public string rbtt_Title_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_title_old");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Title_Old");
                this.SetAttributeValue("rbtt_title_old", value);
                this.OnPropertyChanged("rbtt_Title_Old");
            }
        }

        /// <summary>
        /// Status of the Customer Master Data Exchange
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchangeState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchangeState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchangeState), optionSet.Value)));
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
        /// Reason for the status of the Customer Master Data Exchange
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
        /// Reason for the status of the Customer Master Data Exchange
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual rbtt_customermasterdataexchange_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_customermasterdataexchange_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N rbtt_customermasterdataexchange_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_customermasterdataexchange_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> rbtt_customermasterdataexchange_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_customermasterdataexchange_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_customermasterdataexchange_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_customermasterdataexchange_Appointments", null, value);
                this.OnPropertyChanged("rbtt_customermasterdataexchange_Appointments");
            }
        }

        /// <summary>
        /// 1:N rbtt_customermasterdataexchange_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_customermasterdataexchange_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> rbtt_customermasterdataexchange_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_customermasterdataexchange_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_customermasterdataexchange_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_customermasterdataexchange_Emails", null, value);
                this.OnPropertyChanged("rbtt_customermasterdataexchange_Emails");
            }
        }

        /// <summary>
        /// 1:N rbtt_customermasterdataexchange_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_customermasterdataexchange_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> rbtt_customermasterdataexchange_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_customermasterdataexchange_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_customermasterdataexchange_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_customermasterdataexchange_Tasks", null, value);
                this.OnPropertyChanged("rbtt_customermasterdataexchange_Tasks");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_customermasterdataexchange_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_customermasterdataexchange_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_customermasterdataexchange_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_customermasterdataexchange_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_customermasterdataexchange_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_customermasterdataexchange_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_customermasterdataexchange_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_customermasterdataexchange_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_customermasterdataexchange_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 rbtt_account_rbtt_customermasterdataexchange_Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_account")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_rbtt_customermasterdataexchange_Account")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account rbtt_account_rbtt_customermasterdataexchange_Account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_rbtt_customermasterdataexchange_Account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_rbtt_customermasterdataexchange_Account");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_rbtt_customermasterdataexchange_Account", null, value);
                this.OnPropertyChanged("rbtt_account_rbtt_customermasterdataexchange_Account");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_rbtt_customermasterdataexchange_Country_New
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_new")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_rbtt_customermasterdataexchange_Country_New
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New", null, value);
                this.OnPropertyChanged("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_new_address")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address", null, value);
                this.OnPropertyChanged("rbtt_orb_country_rbtt_customermasterdataexchange_Country_New_Address");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_old")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old", null, value);
                this.OnPropertyChanged("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country_old_address")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address", null, value);
                this.OnPropertyChanged("rbtt_orb_country_rbtt_customermasterdataexchange_Country_Old_Address");
            }
        }

        /// <summary>
        /// N:1 user_rbtt_customermasterdataexchange
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_rbtt_customermasterdataexchange")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_rbtt_customermasterdataexchange
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_rbtt_customermasterdataexchange", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_rbtt_customermasterdataexchange");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_rbtt_customermasterdataexchange", null, value);
                this.OnPropertyChanged("user_rbtt_customermasterdataexchange");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_customermasterdataexchange(object anonymousType) :
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
                        Attributes["rbtt_customermasterdataexchangeid"] = base.Id;
                        break;
                    case "rbtt_customermasterdataexchangeid":
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