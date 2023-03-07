namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    /// <summary>
    /// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
    public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string AccessMode = "accessmode";
            public const string Address1_AddressId = "address1_addressid";
            public const string Address1_AddressTypeCode = "address1_addresstypecode";
            public const string Address1_City = "address1_city";
            public const string Address1_Composite = "address1_composite";
            public const string Address1_Country = "address1_country";
            public const string Address1_County = "address1_county";
            public const string Address1_Fax = "address1_fax";
            public const string Address1_Latitude = "address1_latitude";
            public const string Address1_Line1 = "address1_line1";
            public const string Address1_Line2 = "address1_line2";
            public const string Address1_Line3 = "address1_line3";
            public const string Address1_Longitude = "address1_longitude";
            public const string Address1_Name = "address1_name";
            public const string Address1_PostalCode = "address1_postalcode";
            public const string Address1_PostOfficeBox = "address1_postofficebox";
            public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
            public const string Address1_StateOrProvince = "address1_stateorprovince";
            public const string Address1_Telephone1 = "address1_telephone1";
            public const string Address1_Telephone2 = "address1_telephone2";
            public const string Address1_Telephone3 = "address1_telephone3";
            public const string Address1_UPSZone = "address1_upszone";
            public const string Address1_UTCOffset = "address1_utcoffset";
            public const string Address2_AddressId = "address2_addressid";
            public const string Address2_AddressTypeCode = "address2_addresstypecode";
            public const string Address2_City = "address2_city";
            public const string Address2_Composite = "address2_composite";
            public const string Address2_Country = "address2_country";
            public const string Address2_County = "address2_county";
            public const string Address2_Fax = "address2_fax";
            public const string Address2_Latitude = "address2_latitude";
            public const string Address2_Line1 = "address2_line1";
            public const string Address2_Line2 = "address2_line2";
            public const string Address2_Line3 = "address2_line3";
            public const string Address2_Longitude = "address2_longitude";
            public const string Address2_Name = "address2_name";
            public const string Address2_PostalCode = "address2_postalcode";
            public const string Address2_PostOfficeBox = "address2_postofficebox";
            public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
            public const string Address2_StateOrProvince = "address2_stateorprovince";
            public const string Address2_Telephone1 = "address2_telephone1";
            public const string Address2_Telephone2 = "address2_telephone2";
            public const string Address2_Telephone3 = "address2_telephone3";
            public const string Address2_UPSZone = "address2_upszone";
            public const string Address2_UTCOffset = "address2_utcoffset";
            public const string ApplicationId = "applicationid";
            public const string ApplicationIdUri = "applicationiduri";
            public const string AzureActiveDirectoryObjectId = "azureactivedirectoryobjectid";
            public const string Btt_ADCode = "btt_adcode";
            public const string btt_CostCenter = "btt_costcenter";
            public const string btt_CountryId = "btt_countryid";
            public const string Btt_CreatesOnlyPartners = "btt_createsonlypartners";
            public const string Btt_Department = "btt_department";
            public const string BusinessUnitId = "businessunitid";
            public const string CalendarId = "calendarid";
            public const string CALType = "caltype";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string DefaultFiltersPopulated = "defaultfilterspopulated";
            public const string DefaultMailbox = "defaultmailbox";
            public const string DefaultOdbFolderName = "defaultodbfoldername";
            public const string DisabledReason = "disabledreason";
            public const string DisplayInServiceViews = "displayinserviceviews";
            public const string DomainName = "domainname";
            public const string EmailRouterAccessApproval = "emailrouteraccessapproval";
            public const string EmployeeId = "employeeid";
            public const string EntityImage = "entityimage";
            public const string EntityImage_Timestamp = "entityimage_timestamp";
            public const string EntityImage_URL = "entityimage_url";
            public const string EntityImageId = "entityimageid";
            public const string ExchangeRate = "exchangerate";
            public const string FirstName = "firstname";
            public const string FullName = "fullname";
            public const string GovernmentId = "governmentid";
            public const string HomePhone = "homephone";
            public const string IdentityId = "identityid";
            public const string im_IsInterfaceUser = "im_isinterfaceuser";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IncomingEmailDeliveryMethod = "incomingemaildeliverymethod";
            public const string InternalEMailAddress = "internalemailaddress";
            public const string InviteStatusCode = "invitestatuscode";
            public const string IsDisabled = "isdisabled";
            public const string IsEmailAddressApprovedByO365Admin = "isemailaddressapprovedbyo365admin";
            public const string IsIntegrationUser = "isintegrationuser";
            public const string IsLicensed = "islicensed";
            public const string IsSyncWithDirectory = "issyncwithdirectory";
            public const string JobTitle = "jobtitle";
            public const string LastName = "lastname";
            public const string MiddleName = "middlename";
            public const string MobileAlertEMail = "mobilealertemail";
            public const string MobileOfflineProfileId = "mobileofflineprofileid";
            public const string MobilePhone = "mobilephone";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string msdyn_gdproptout = "msdyn_gdproptout";
            public const string NickName = "nickname";
            public const string Orb_code = "orb_code";
            public const string OrganizationId = "organizationid";
            public const string OutgoingEmailDeliveryMethod = "outgoingemaildeliverymethod";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string ParentSystemUserId = "parentsystemuserid";
            public const string PassportHi = "passporthi";
            public const string PassportLo = "passportlo";
            public const string PersonalEMailAddress = "personalemailaddress";
            public const string PhotoUrl = "photourl";
            public const string PositionId = "positionid";
            public const string PreferredAddressCode = "preferredaddresscode";
            public const string PreferredEmailCode = "preferredemailcode";
            public const string PreferredPhoneCode = "preferredphonecode";
            public const string ProcessId = "processid";
            public const string QueueId = "queueid";
            public const string rbtt_IsUpdatedFromForm = "rbtt_isupdatedfromform";
            public const string rbtt_ProjectTypes = "rbtt_projecttypes";
            public const string rbtt_ProjectTypesValue = "rbtt_projecttypesvalue";
            public const string rbtt_SalesOrganization = "rbtt_salesorganization";
            public const string rbtt_SalesOrganizationsValue = "rbtt_salesorganizationsvalue";
            public const string Salutation = "salutation";
            public const string SetupUser = "setupuser";
            public const string SharePointEmailAddress = "sharepointemailaddress";
            public const string SiteId = "siteid";
            public const string Skills = "skills";
            public const string StageId = "stageid";
            public const string SystemUserId = "systemuserid";
            public const string Id = "systemuserid";
            public const string TerritoryId = "territoryid";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string Title = "title";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UserLicenseType = "userlicensetype";
            public const string UserPuid = "userpuid";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string WindowsLiveID = "windowsliveid";
            public const string YammerEmailAddress = "yammeremailaddress";
            public const string YammerUserId = "yammeruserid";
            public const string YomiFirstName = "yomifirstname";
            public const string YomiFullName = "yomifullname";
            public const string YomiLastName = "yomilastname";
            public const string YomiMiddleName = "yomimiddlename";
            public const string btt_orb_country_systemuser = "btt_orb_country_systemuser";
            public const string Referencinglk_systemuser_createdonbehalfby = "lk_systemuser_createdonbehalfby";
            public const string Referencinglk_systemuser_modifiedonbehalfby = "lk_systemuser_modifiedonbehalfby";
            public const string Referencinglk_systemuserbase_createdby = "lk_systemuserbase_createdby";
            public const string Referencinglk_systemuserbase_modifiedby = "lk_systemuserbase_modifiedby";
            public const string rbtt_account_systemuser_SalesOrganization = "rbtt_account_systemuser_SalesOrganization";
            public const string Referencinguser_parent_user = "user_parent_user";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public SystemUser() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuser";

        public const string EntitySchemaName = "SystemUser";

        public const string PrimaryIdAttribute = "systemuserid";

        public const string PrimaryNameAttribute = "fullname";

        public const string EntityLogicalCollectionName = "systemusers";

        public const string EntitySetName = "systemusers";

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
        /// Type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccessMode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accessmode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccessMode");
                this.SetAttributeValue("accessmode", value);
                this.OnPropertyChanged("AccessMode");
            }
        }

        /// <summary>
        /// Type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
        public virtual SystemUser_AccessMode? AccessModeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_AccessMode?)(EntityOptionSetEnum.GetEnum(this, "accessmode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccessMode");
                this.SetAttributeValue("accessmode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("AccessMode");
            }
        }

        /// <summary>
        /// Unique identifier for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_AddressId");
                this.SetAttributeValue("address1_addressid", value);
                this.OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 1, such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_AddressTypeCode");
                this.SetAttributeValue("address1_addresstypecode", value);
                this.OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type of address for address 1, such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public virtual SystemUser_Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_AddressTypeCode");
                this.SetAttributeValue("address1_addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
        public string Address1_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_City");
                this.SetAttributeValue("address1_city", value);
                this.OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        /// Shows the complete primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
        public string Address1_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_composite");
            }
        }

        /// <summary>
        /// Country/region name in address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
        public string Address1_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Country");
                this.SetAttributeValue("address1_country", value);
                this.OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        /// County name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
        public string Address1_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_county");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_County");
                this.SetAttributeValue("address1_county", value);
                this.OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        /// Fax number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
        public string Address1_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Fax");
                this.SetAttributeValue("address1_fax", value);
                this.OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Latitude");
                this.SetAttributeValue("address1_latitude", value);
                this.OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
        public string Address1_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_line1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line1");
                this.SetAttributeValue("address1_line1", value);
                this.OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
        public string Address1_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_line2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line2");
                this.SetAttributeValue("address1_line2", value);
                this.OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
        public string Address1_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_line3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line3");
                this.SetAttributeValue("address1_line3", value);
                this.OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Longitude");
                this.SetAttributeValue("address1_longitude", value);
                this.OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
        public string Address1_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Name");
                this.SetAttributeValue("address1_name", value);
                this.OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
        public string Address1_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PostalCode");
                this.SetAttributeValue("address1_postalcode", value);
                this.OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_postofficebox");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PostOfficeBox");
                this.SetAttributeValue("address1_postofficebox", value);
                this.OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_ShippingMethodCode");
                this.SetAttributeValue("address1_shippingmethodcode", value);
                this.OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        /// Method of shipment for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public virtual SystemUser_Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_ShippingMethodCode");
                this.SetAttributeValue("address1_shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_stateorprovince");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_StateOrProvince");
                this.SetAttributeValue("address1_stateorprovince", value);
                this.OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
        public string Address1_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_telephone1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone1");
                this.SetAttributeValue("address1_telephone1", value);
                this.OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
        public string Address1_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_telephone2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone2");
                this.SetAttributeValue("address1_telephone2", value);
                this.OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
        public string Address1_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_telephone3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone3");
                this.SetAttributeValue("address1_telephone3", value);
                this.OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
        public string Address1_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_upszone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_UPSZone");
                this.SetAttributeValue("address1_upszone", value);
                this.OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_UTCOffset");
                this.SetAttributeValue("address1_utcoffset", value);
                this.OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_AddressId");
                this.SetAttributeValue("address2_addressid", value);
                this.OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 2, such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_AddressTypeCode");
                this.SetAttributeValue("address2_addresstypecode", value);
                this.OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type of address for address 2, such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public virtual SystemUser_Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_AddressTypeCode");
                this.SetAttributeValue("address2_addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
        public string Address2_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_City");
                this.SetAttributeValue("address2_city", value);
                this.OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        /// Shows the complete secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
        public string Address2_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_composite");
            }
        }

        /// <summary>
        /// Country/region name in address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
        public string Address2_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Country");
                this.SetAttributeValue("address2_country", value);
                this.OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        /// County name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
        public string Address2_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_county");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_County");
                this.SetAttributeValue("address2_county", value);
                this.OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        /// Fax number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
        public string Address2_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Fax");
                this.SetAttributeValue("address2_fax", value);
                this.OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Latitude");
                this.SetAttributeValue("address2_latitude", value);
                this.OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
        public string Address2_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_line1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line1");
                this.SetAttributeValue("address2_line1", value);
                this.OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
        public string Address2_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_line2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line2");
                this.SetAttributeValue("address2_line2", value);
                this.OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
        public string Address2_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_line3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line3");
                this.SetAttributeValue("address2_line3", value);
                this.OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Longitude");
                this.SetAttributeValue("address2_longitude", value);
                this.OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
        public string Address2_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Name");
                this.SetAttributeValue("address2_name", value);
                this.OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
        public string Address2_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PostalCode");
                this.SetAttributeValue("address2_postalcode", value);
                this.OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_postofficebox");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PostOfficeBox");
                this.SetAttributeValue("address2_postofficebox", value);
                this.OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_ShippingMethodCode");
                this.SetAttributeValue("address2_shippingmethodcode", value);
                this.OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        /// Method of shipment for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public virtual SystemUser_Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_ShippingMethodCode");
                this.SetAttributeValue("address2_shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_stateorprovince");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_StateOrProvince");
                this.SetAttributeValue("address2_stateorprovince", value);
                this.OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
        public string Address2_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_telephone1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone1");
                this.SetAttributeValue("address2_telephone1", value);
                this.OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
        public string Address2_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_telephone2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone2");
                this.SetAttributeValue("address2_telephone2", value);
                this.OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
        public string Address2_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_telephone3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone3");
                this.SetAttributeValue("address2_telephone3", value);
                this.OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
        public string Address2_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_upszone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_UPSZone");
                this.SetAttributeValue("address2_upszone", value);
                this.OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_UTCOffset");
                this.SetAttributeValue("address2_utcoffset", value);
                this.OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        /// The identifier for the application. This is used to access data in another application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationid")]
        public System.Nullable<System.Guid> ApplicationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("applicationid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ApplicationId");
                this.SetAttributeValue("applicationid", value);
                this.OnPropertyChanged("ApplicationId");
            }
        }

        /// <summary>
        /// The URI used as a unique logical identifier for the external app. This can be used to validate the application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicationiduri")]
        public string ApplicationIdUri
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("applicationiduri");
            }
        }

        /// <summary>
        /// This is the application directory object Id.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("azureactivedirectoryobjectid")]
        public System.Nullable<System.Guid> AzureActiveDirectoryObjectId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("azureactivedirectoryobjectid");
            }
        }

        /// <summary>
        /// AD Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_adcode")]
        public string Btt_ADCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_adcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ADCode");
                this.SetAttributeValue("btt_adcode", value);
                this.OnPropertyChanged("Btt_ADCode");
            }
        }

        /// <summary>
        /// Cost  Center
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_costcenter")]
        public string btt_CostCenter
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_costcenter");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CostCenter");
                this.SetAttributeValue("btt_costcenter", value);
                this.OnPropertyChanged("btt_CostCenter");
            }
        }

        /// <summary>
        /// Unique identifier for Country associated with User.
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
        /// Attribute is TRUE if User has only right to create Accounts of type/role="Partner"
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_createsonlypartners")]
        public System.Nullable<bool> Btt_CreatesOnlyPartners
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_createsonlypartners");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_CreatesOnlyPartners");
                this.SetAttributeValue("btt_createsonlypartners", value);
                this.OnPropertyChanged("Btt_CreatesOnlyPartners");
            }
        }

        /// <summary>
        /// Department Abbreviation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_department")]
        public string Btt_Department
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_department");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Department");
                this.SetAttributeValue("btt_department", value);
                this.OnPropertyChanged("Btt_Department");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Fiscal calendar associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public Microsoft.Xrm.Sdk.EntityReference CalendarId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CalendarId");
                this.SetAttributeValue("calendarid", value);
                this.OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        /// License type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
        public Microsoft.Xrm.Sdk.OptionSetValue CALType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("caltype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CALType");
                this.SetAttributeValue("caltype", value);
                this.OnPropertyChanged("CALType");
            }
        }

        /// <summary>
        /// License type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
        public virtual SystemUser_CALType? CALTypeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_CALType?)(EntityOptionSetEnum.GetEnum(this, "caltype")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CALType");
                this.SetAttributeValue("caltype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("CALType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the user.
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
        /// Date and time when the user was created.
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
        /// Unique identifier of the delegate user who created the systemuser.
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
        /// Indicates if default outlook filters have been populated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
        public System.Nullable<bool> DefaultFiltersPopulated
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated");
            }
        }

        /// <summary>
        /// Select the mailbox associated with this user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultMailbox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultmailbox");
            }
        }

        /// <summary>
        /// Type a default folder name for the user's OneDrive For Business location.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultodbfoldername")]
        public string DefaultOdbFolderName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("defaultodbfoldername");
            }
        }

        /// <summary>
        /// Reason for disabling the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
        public string DisabledReason
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("disabledreason");
            }
        }

        /// <summary>
        /// Whether to display the user in service views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
        public System.Nullable<bool> DisplayInServiceViews
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DisplayInServiceViews");
                this.SetAttributeValue("displayinserviceviews", value);
                this.OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        /// Active Directory domain of which the user is a member.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
        public string DomainName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("domainname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DomainName");
                this.SetAttributeValue("domainname", value);
                this.OnPropertyChanged("DomainName");
            }
        }

        /// <summary>
        /// Shows the status of the primary email address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
        public Microsoft.Xrm.Sdk.OptionSetValue EmailRouterAccessApproval
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailrouteraccessapproval");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailRouterAccessApproval");
                this.SetAttributeValue("emailrouteraccessapproval", value);
                this.OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        /// Shows the status of the primary email address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
        public virtual SystemUser_EmailRouterAccessApproval? EmailRouterAccessApprovalEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_EmailRouterAccessApproval?)(EntityOptionSetEnum.GetEnum(this, "emailrouteraccessapproval")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailRouterAccessApproval");
                this.SetAttributeValue("emailrouteraccessapproval", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        /// Employee identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
        public string EmployeeId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("employeeid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmployeeId");
                this.SetAttributeValue("employeeid", value);
                this.OnPropertyChanged("EmployeeId");
            }
        }

        /// <summary>
        /// Shows the default image for the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<byte[]>("entityimage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("entityimage_url");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the systemuser with respect to the base currency.
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
        /// First name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("firstname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FirstName");
                this.SetAttributeValue("firstname", value);
                this.OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("fullname");
            }
        }

        /// <summary>
        /// Government identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
        public string GovernmentId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("governmentid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("GovernmentId");
                this.SetAttributeValue("governmentid", value);
                this.OnPropertyChanged("GovernmentId");
            }
        }

        /// <summary>
        /// Home phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
        public string HomePhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("homephone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("HomePhone");
                this.SetAttributeValue("homephone", value);
                this.OnPropertyChanged("HomePhone");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identityid")]
        public System.Nullable<int> IdentityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("identityid");
            }
        }

        /// <summary>
        /// Is Interface User
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("im_isinterfaceuser")]
        public System.Nullable<bool> im_IsInterfaceUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("im_isinterfaceuser");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("im_IsInterfaceUser");
                this.SetAttributeValue("im_isinterfaceuser", value);
                this.OnPropertyChanged("im_IsInterfaceUser");
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
        /// Incoming email delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailDeliveryMethod
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemaildeliverymethod");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IncomingEmailDeliveryMethod");
                this.SetAttributeValue("incomingemaildeliverymethod", value);
                this.OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Incoming email delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
        public virtual SystemUser_IncomingEmailDeliveryMethod? IncomingEmailDeliveryMethodEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_IncomingEmailDeliveryMethod?)(EntityOptionSetEnum.GetEnum(this, "incomingemaildeliverymethod")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IncomingEmailDeliveryMethod");
                this.SetAttributeValue("incomingemaildeliverymethod", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Internal email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
        public string InternalEMailAddress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("internalemailaddress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("InternalEMailAddress");
                this.SetAttributeValue("internalemailaddress", value);
                this.OnPropertyChanged("InternalEMailAddress");
            }
        }

        /// <summary>
        /// User invitation status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InviteStatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invitestatuscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("InviteStatusCode");
                this.SetAttributeValue("invitestatuscode", value);
                this.OnPropertyChanged("InviteStatusCode");
            }
        }

        /// <summary>
        /// User invitation status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
        public virtual SystemUser_InviteStatusCode? InviteStatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_InviteStatusCode?)(EntityOptionSetEnum.GetEnum(this, "invitestatuscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("InviteStatusCode");
                this.SetAttributeValue("invitestatuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("InviteStatusCode");
            }
        }

        /// <summary>
        /// Information about whether the user is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsDisabled");
                this.SetAttributeValue("isdisabled", value);
                this.OnPropertyChanged("IsDisabled");
            }
        }

        /// <summary>
        /// Shows the status of approval of the email address by O365 Admin.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailaddressapprovedbyo365admin")]
        public System.Nullable<bool> IsEmailAddressApprovedByO365Admin
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isemailaddressapprovedbyo365admin");
            }
        }

        /// <summary>
        /// Check if user is an integration user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
        public System.Nullable<bool> IsIntegrationUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsIntegrationUser");
                this.SetAttributeValue("isintegrationuser", value);
                this.OnPropertyChanged("IsIntegrationUser");
            }
        }

        /// <summary>
        /// Information about whether the user is licensed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
        public System.Nullable<bool> IsLicensed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsLicensed");
                this.SetAttributeValue("islicensed", value);
                this.OnPropertyChanged("IsLicensed");
            }
        }

        /// <summary>
        /// Information about whether the user is synced with the directory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
        public System.Nullable<bool> IsSyncWithDirectory
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsSyncWithDirectory");
                this.SetAttributeValue("issyncwithdirectory", value);
                this.OnPropertyChanged("IsSyncWithDirectory");
            }
        }

        /// <summary>
        /// Job title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
        public string JobTitle
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("jobtitle");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("JobTitle");
                this.SetAttributeValue("jobtitle", value);
                this.OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("lastname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastName");
                this.SetAttributeValue("lastname", value);
                this.OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Middle name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
        public string MiddleName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("middlename");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MiddleName");
                this.SetAttributeValue("middlename", value);
                this.OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Mobile alert email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
        public string MobileAlertEMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("mobilealertemail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MobileAlertEMail");
                this.SetAttributeValue("mobilealertemail", value);
                this.OnPropertyChanged("MobileAlertEMail");
            }
        }

        /// <summary>
        /// Items contained with a particular SystemUser.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileid")]
        public Microsoft.Xrm.Sdk.EntityReference MobileOfflineProfileId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("mobileofflineprofileid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MobileOfflineProfileId");
                this.SetAttributeValue("mobileofflineprofileid", value);
                this.OnPropertyChanged("MobileOfflineProfileId");
            }
        }

        /// <summary>
        /// Mobile phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
        public string MobilePhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("mobilephone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MobilePhone");
                this.SetAttributeValue("mobilephone", value);
                this.OnPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the user.
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
        /// Date and time when the user was last modified.
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
        /// Unique identifier of the delegate user who last modified the systemuser.
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
        /// Describes whether user is opted out or not
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
        public System.Nullable<bool> msdyn_gdproptout
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msdyn_gdproptout");
                this.SetAttributeValue("msdyn_gdproptout", value);
                this.OnPropertyChanged("msdyn_gdproptout");
            }
        }

        /// <summary>
        /// Nickname of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
        public string NickName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("nickname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("NickName");
                this.SetAttributeValue("nickname", value);
                this.OnPropertyChanged("NickName");
            }
        }

        /// <summary>
        /// Agent Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_code")]
        public string Orb_code
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_code");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_code");
                this.SetAttributeValue("orb_code", value);
                this.OnPropertyChanged("Orb_code");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
            }
        }

        /// <summary>
        /// Outgoing email delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue OutgoingEmailDeliveryMethod
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemaildeliverymethod");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
                this.SetAttributeValue("outgoingemaildeliverymethod", value);
                this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Outgoing email delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
        public virtual SystemUser_OutgoingEmailDeliveryMethod? OutgoingEmailDeliveryMethodEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_OutgoingEmailDeliveryMethod?)(EntityOptionSetEnum.GetEnum(this, "outgoingemaildeliverymethod")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
                this.SetAttributeValue("outgoingemaildeliverymethod", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
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
        /// Unique identifier of the manager of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentSystemUserId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentSystemUserId");
                this.SetAttributeValue("parentsystemuserid", value);
                this.OnPropertyChanged("ParentSystemUserId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
        public System.Nullable<int> PassportHi
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passporthi");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PassportHi");
                this.SetAttributeValue("passporthi", value);
                this.OnPropertyChanged("PassportHi");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
        public System.Nullable<int> PassportLo
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passportlo");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PassportLo");
                this.SetAttributeValue("passportlo", value);
                this.OnPropertyChanged("PassportLo");
            }
        }

        /// <summary>
        /// Personal email address of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
        public string PersonalEMailAddress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("personalemailaddress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PersonalEMailAddress");
                this.SetAttributeValue("personalemailaddress", value);
                this.OnPropertyChanged("PersonalEMailAddress");
            }
        }

        /// <summary>
        /// URL for the Website on which a photo of the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
        public string PhotoUrl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("photourl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PhotoUrl");
                this.SetAttributeValue("photourl", value);
                this.OnPropertyChanged("PhotoUrl");
            }
        }

        /// <summary>
        /// User's position in hierarchical security model.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
        public Microsoft.Xrm.Sdk.EntityReference PositionId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("positionid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PositionId");
                this.SetAttributeValue("positionid", value);
                this.OnPropertyChanged("PositionId");
            }
        }

        /// <summary>
        /// Preferred address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAddressCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredaddresscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAddressCode");
                this.SetAttributeValue("preferredaddresscode", value);
                this.OnPropertyChanged("PreferredAddressCode");
            }
        }

        /// <summary>
        /// Preferred address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
        public virtual SystemUser_PreferredAddressCode? PreferredAddressCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_PreferredAddressCode?)(EntityOptionSetEnum.GetEnum(this, "preferredaddresscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAddressCode");
                this.SetAttributeValue("preferredaddresscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PreferredAddressCode");
            }
        }

        /// <summary>
        /// Preferred email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredEmailCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredemailcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredEmailCode");
                this.SetAttributeValue("preferredemailcode", value);
                this.OnPropertyChanged("PreferredEmailCode");
            }
        }

        /// <summary>
        /// Preferred email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
        public virtual SystemUser_PreferredEmailCode? PreferredEmailCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_PreferredEmailCode?)(EntityOptionSetEnum.GetEnum(this, "preferredemailcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredEmailCode");
                this.SetAttributeValue("preferredemailcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PreferredEmailCode");
            }
        }

        /// <summary>
        /// Preferred phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredPhoneCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredphonecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredPhoneCode");
                this.SetAttributeValue("preferredphonecode", value);
                this.OnPropertyChanged("PreferredPhoneCode");
            }
        }

        /// <summary>
        /// Preferred phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
        public virtual SystemUser_PreferredPhoneCode? PreferredPhoneCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((SystemUser_PreferredPhoneCode?)(EntityOptionSetEnum.GetEnum(this, "preferredphonecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredPhoneCode");
                this.SetAttributeValue("preferredphonecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PreferredPhoneCode");
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
        /// Unique identifier of the default queue for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Sdk.EntityReference QueueId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QueueId");
                this.SetAttributeValue("queueid", value);
                this.OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        /// Is Updated From Form
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_isupdatedfromform")]
        public System.Nullable<bool> rbtt_IsUpdatedFromForm
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_isupdatedfromform");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_IsUpdatedFromForm");
                this.SetAttributeValue("rbtt_isupdatedfromform", value);
                this.OnPropertyChanged("rbtt_IsUpdatedFromForm");
            }
        }

        /// <summary>
        /// Project Types
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projecttypes")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ProjectTypes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_projecttypes");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectTypes");
                this.SetAttributeValue("rbtt_projecttypes", value);
                this.OnPropertyChanged("rbtt_ProjectTypes");
            }
        }

        /// <summary>
        /// Project Types Value
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_projecttypesvalue")]
        public string rbtt_ProjectTypesValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_projecttypesvalue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProjectTypesValue");
                this.SetAttributeValue("rbtt_projecttypesvalue", value);
                this.OnPropertyChanged("rbtt_ProjectTypesValue");
            }
        }

        /// <summary>
        /// Sales Organizations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_salesorganization")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_SalesOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_salesorganization");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SalesOrganization");
                this.SetAttributeValue("rbtt_salesorganization", value);
                this.OnPropertyChanged("rbtt_SalesOrganization");
            }
        }

        /// <summary>
        /// Sales Organizations Value
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_salesorganizationsvalue")]
        public string rbtt_SalesOrganizationsValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_salesorganizationsvalue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SalesOrganizationsValue");
                this.SetAttributeValue("rbtt_salesorganizationsvalue", value);
                this.OnPropertyChanged("rbtt_SalesOrganizationsValue");
            }
        }

        /// <summary>
        /// Salutation for correspondence with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
        public string Salutation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("salutation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Salutation");
                this.SetAttributeValue("salutation", value);
                this.OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        /// Check if user is a setup user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
        public System.Nullable<bool> SetupUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("setupuser");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SetupUser");
                this.SetAttributeValue("setupuser", value);
                this.OnPropertyChanged("SetupUser");
            }
        }

        /// <summary>
        /// SharePoint Work Email Address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointemailaddress")]
        public string SharePointEmailAddress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("sharepointemailaddress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SharePointEmailAddress");
                this.SetAttributeValue("sharepointemailaddress", value);
                this.OnPropertyChanged("SharePointEmailAddress");
            }
        }

        /// <summary>
        /// Site at which the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Sdk.EntityReference SiteId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                this.OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// Skill set of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
        public string Skills
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("skills");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Skills");
                this.SetAttributeValue("skills", value);
                this.OnPropertyChanged("Skills");
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
        /// Unique identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SystemUserId");
                this.SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
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
                this.SystemUserId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the territory to which the user is assigned.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        public Microsoft.Xrm.Sdk.EntityReference TerritoryId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TerritoryId");
                this.SetAttributeValue("territoryid", value);
                this.OnPropertyChanged("TerritoryId");
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
        /// Title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("title");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the systemuser.
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
        /// Shows the type of user license.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userlicensetype")]
        public System.Nullable<int> UserLicenseType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("userlicensetype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UserLicenseType");
                this.SetAttributeValue("userlicensetype", value);
                this.OnPropertyChanged("UserLicenseType");
            }
        }

        /// <summary>
        ///  User PUID User Identifiable Information
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userpuid")]
        public string UserPuid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("userpuid");
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
        /// Version number of the user.
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
        /// Windows Live ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
        public string WindowsLiveID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("windowsliveid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("WindowsLiveID");
                this.SetAttributeValue("windowsliveid", value);
                this.OnPropertyChanged("WindowsLiveID");
            }
        }

        /// <summary>
        /// User's Yammer login email address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeremailaddress")]
        public string YammerEmailAddress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("yammeremailaddress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YammerEmailAddress");
                this.SetAttributeValue("yammeremailaddress", value);
                this.OnPropertyChanged("YammerEmailAddress");
            }
        }

        /// <summary>
        /// User's Yammer ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeruserid")]
        public string YammerUserId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("yammeruserid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YammerUserId");
                this.SetAttributeValue("yammeruserid", value);
                this.OnPropertyChanged("YammerUserId");
            }
        }

        /// <summary>
        /// Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("yomifirstname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiFirstName");
                this.SetAttributeValue("yomifirstname", value);
                this.OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        /// Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("yomifullname");
            }
        }

        /// <summary>
        /// Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("yomilastname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiLastName");
                this.SetAttributeValue("yomilastname", value);
                this.OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        /// Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
        public string YomiMiddleName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("yomimiddlename");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiMiddleName");
                this.SetAttributeValue("yomimiddlename", value);
                this.OnPropertyChanged("YomiMiddleName");
            }
        }

        /// <summary>
        /// 1:N btt_customerservice_user_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_customerservice_user_contact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> btt_customerservice_user_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_customerservice_user_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_customerservice_user_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_customerservice_user_contact", null, value);
                this.OnPropertyChanged("btt_customerservice_user_contact");
            }
        }

        /// <summary>
        /// 1:N btt_systemuser_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_systemuser_account")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> btt_systemuser_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_systemuser_account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_systemuser_account");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_systemuser_account", null, value);
                this.OnPropertyChanged("btt_systemuser_account");
            }
        }

        /// <summary>
        /// 1:N btt_systemuser_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_systemuser_contact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> btt_systemuser_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_systemuser_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_systemuser_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_systemuser_contact", null, value);
                this.OnPropertyChanged("btt_systemuser_contact");
            }
        }

        /// <summary>
        /// 1:N contact_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> contact_owning_user
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_owning_user", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contact_owning_user");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_owning_user", null, value);
                this.OnPropertyChanged("contact_owning_user");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessage")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage> createdby_sdkmessage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("createdby_sdkmessage", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("createdby_sdkmessage");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("createdby_sdkmessage", null, value);
                this.OnPropertyChanged("createdby_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep> createdby_sdkmessageprocessingstep
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageprocessingstep");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("createdby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N impersonatinguserid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("impersonatinguserid_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep> impersonatinguserid_sdkmessageprocessingstep
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> lk_accountbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_createdby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> lk_accountbase_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> lk_accountbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> lk_accountbase_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("lk_accountbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_alegri_autonumbercounter_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_alegri_autonumbercounter_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter> lk_alegri_autonumbercounter_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_alegri_autonumbercounter_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_createdby", null, value);
                this.OnPropertyChanged("lk_alegri_autonumbercounter_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_alegri_autonumbercounter_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_alegri_autonumbercounter_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter> lk_alegri_autonumbercounter_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_alegri_autonumbercounter_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_alegri_autonumbercounter_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_alegri_autonumbercounter_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_alegri_autonumbercounter_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter> lk_alegri_autonumbercounter_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_alegri_autonumbercounter_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_modifiedby", null, value);
                this.OnPropertyChanged("lk_alegri_autonumbercounter_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_alegri_autonumbercounter_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_alegri_autonumbercounter_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter> lk_alegri_autonumbercounter_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_alegri_autonumbercounter_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.alegri_autonumbercounter>("lk_alegri_autonumbercounter_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_alegri_autonumbercounter_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> lk_appointment_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_createdby", null, value);
                this.OnPropertyChanged("lk_appointment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> lk_appointment_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> lk_appointment_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_modifiedby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> lk_appointment_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("lk_appointment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_btt_gratuity_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_btt_gratuity_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> lk_btt_gratuity_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_btt_gratuity_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_createdby", null, value);
                this.OnPropertyChanged("lk_btt_gratuity_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_btt_gratuity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_btt_gratuity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> lk_btt_gratuity_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_btt_gratuity_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_btt_gratuity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_btt_gratuity_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_btt_gratuity_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> lk_btt_gratuity_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_btt_gratuity_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_modifiedby", null, value);
                this.OnPropertyChanged("lk_btt_gratuity_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_btt_gratuity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_btt_gratuity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> lk_btt_gratuity_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_btt_gratuity_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("lk_btt_gratuity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_btt_gratuity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contact_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> lk_contact_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contact_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contact_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contact_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contact_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> lk_contact_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contact_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contact_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contact_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contactbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> lk_contactbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contactbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contactbase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contactbase_createdby", null, value);
                this.OnPropertyChanged("lk_contactbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contactbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> lk_contactbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contactbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contactbase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("lk_contactbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contactbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_email_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> lk_email_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_createdby", null, value);
                this.OnPropertyChanged("lk_email_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_email_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> lk_email_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_email_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> lk_email_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_modifiedby", null, value);
                this.OnPropertyChanged("lk_email_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_email_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> lk_email_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_email_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("lk_email_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> lk_opportunity_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunity_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunity_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> lk_opportunity_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunity_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunity_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> lk_opportunitybase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunitybase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunitybase_createdby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> lk_opportunitybase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunitybase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("lk_opportunitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_classificationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase> lk_orb_classificationbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_createdby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_classificationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase> lk_orb_classificationbase_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_classificationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase> lk_orb_classificationbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_classificationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_classificationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase> lk_orb_classificationbase_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_classificationbase_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("lk_orb_classificationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_classificationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_country_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_country_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country> lk_orb_country_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_country_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_createdby", null, value);
                this.OnPropertyChanged("lk_orb_country_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_country_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_country_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country> lk_orb_country_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_country_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_country_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_country_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_country_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country> lk_orb_country_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_country_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_country_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_country_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_country_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country> lk_orb_country_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_country_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("lk_orb_country_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_country_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_machine_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> lk_orb_machine_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_createdby", null, value);
                this.OnPropertyChanged("lk_orb_machine_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_machine_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> lk_orb_machine_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_machine_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_machine_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> lk_orb_machine_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_machine_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_machine_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> lk_orb_machine_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("lk_orb_machine_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_machine_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroup_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup> lk_orb_productgroup_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_createdby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroup_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup> lk_orb_productgroup_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroup_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup> lk_orb_productgroup_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroup_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroup_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup> lk_orb_productgroup_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroup_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("lk_orb_productgroup_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroup_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroupclassification_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> lk_orb_productgroupclassification_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_createdby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroupclassification_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> lk_orb_productgroupclassification_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroupclassification_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> lk_orb_productgroupclassification_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_productgroupclassification_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_productgroupclassification_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> lk_orb_productgroupclassification_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_productgroupclassification_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("lk_orb_productgroupclassification_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_productgroupclassification_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_visitplanningbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_visitplanningbase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase> lk_orb_visitplanningbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_visitplanningbase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_createdby", null, value);
                this.OnPropertyChanged("lk_orb_visitplanningbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_visitplanningbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_visitplanningbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase> lk_orb_visitplanningbase_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_visitplanningbase_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_visitplanningbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_visitplanningbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_visitplanningbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase> lk_orb_visitplanningbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_visitplanningbase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_visitplanningbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orb_visitplanningbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_visitplanningbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase> lk_orb_visitplanningbase_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_visitplanningbase_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_visitplanningbase>("lk_orb_visitplanningbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_visitplanningbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_product_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> lk_product_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_product_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_product_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_product_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_product_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> lk_product_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_product_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_product_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_product_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_productbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> lk_productbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_productbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_productbase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_productbase_createdby", null, value);
                this.OnPropertyChanged("lk_productbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_productbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> lk_productbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_productbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_productbase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("lk_productbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_productbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_quote_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> lk_quote_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quote_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quote_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quote_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quote_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> lk_quote_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quote_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quote_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quote_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> lk_quotebase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quotebase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quotebase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quotebase_createdby", null, value);
                this.OnPropertyChanged("lk_quotebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quotebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> lk_quotebase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quotebase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quotebase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("lk_quotebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_quotebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_apimonitor_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor> lk_rbtt_apimonitor_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_apimonitor_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor> lk_rbtt_apimonitor_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_apimonitor_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor> lk_rbtt_apimonitor_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_apimonitor_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_apimonitor_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor> lk_rbtt_apimonitor_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_apimonitor_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("lk_rbtt_apimonitor_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_apimonitor_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_appliance_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance> lk_rbtt_appliance_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_appliance_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance> lk_rbtt_appliance_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_appliance_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance> lk_rbtt_appliance_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_appliance_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance> lk_rbtt_appliance_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("lk_rbtt_appliance_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_applicationid_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_applicationid_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid> lk_rbtt_applicationid_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_applicationid_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_applicationid_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_applicationid_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_applicationid_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid> lk_rbtt_applicationid_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_applicationid_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_applicationid_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_applicationid_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_applicationid_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid> lk_rbtt_applicationid_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_applicationid_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_applicationid_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_applicationid_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_applicationid_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid> lk_rbtt_applicationid_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_applicationid_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("lk_rbtt_applicationid_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_applicationid_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_bookoffeedback_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_bookoffeedback_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback> lk_rbtt_bookoffeedback_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_bookoffeedback_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_bookoffeedback_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_bookoffeedback_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_bookoffeedback_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback> lk_rbtt_bookoffeedback_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_bookoffeedback_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_bookoffeedback_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_bookoffeedback_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_bookoffeedback_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback> lk_rbtt_bookoffeedback_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_bookoffeedback_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_bookoffeedback_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_bookoffeedback_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_bookoffeedback_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback> lk_rbtt_bookoffeedback_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_bookoffeedback_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_bookoffeedback>("lk_rbtt_bookoffeedback_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_bookoffeedback_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_configurations_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations> lk_rbtt_configurations_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_configurations_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations> lk_rbtt_configurations_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_configurations_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations> lk_rbtt_configurations_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_configurations_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_configurations_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations> lk_rbtt_configurations_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_configurations_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_configurations>("lk_rbtt_configurations_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_configurations_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consent_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent> lk_rbtt_consent_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consent_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent> lk_rbtt_consent_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consent_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent> lk_rbtt_consent_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consent_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consent_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent> lk_rbtt_consent_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consent_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("lk_rbtt_consent_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_consent_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consenttext_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consenttext_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext> lk_rbtt_consenttext_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consenttext_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_consenttext_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consenttext_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consenttext_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext> lk_rbtt_consenttext_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consenttext_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_consenttext_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consenttext_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consenttext_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext> lk_rbtt_consenttext_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consenttext_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_consenttext_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_consenttext_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_consenttext_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext> lk_rbtt_consenttext_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_consenttext_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consenttext>("lk_rbtt_consenttext_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_consenttext_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_customermasterdataexchange_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange> lk_rbtt_customermasterdataexchange_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_customermasterdataexchange_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange> lk_rbtt_customermasterdataexchange_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_customermasterdataexchange_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange> lk_rbtt_customermasterdataexchange_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_customermasterdataexchange_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_customermasterdataexchange_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange> lk_rbtt_customermasterdataexchange_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_customermasterdataexchange_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("lk_rbtt_customermasterdataexchange_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_customermasterdataexchange_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernote_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernote_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote> lk_rbtt_delivernote_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernote_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernote_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernote_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernote_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote> lk_rbtt_delivernote_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernote_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernote_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernote_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernote_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote> lk_rbtt_delivernote_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernote_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernote_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernote_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernote_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote> lk_rbtt_delivernote_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernote_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("lk_rbtt_delivernote_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernote_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernoteitem_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernoteitem_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem> lk_rbtt_delivernoteitem_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernoteitem_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernoteitem_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernoteitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernoteitem_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem> lk_rbtt_delivernoteitem_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernoteitem_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernoteitem_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernoteitem_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernoteitem_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem> lk_rbtt_delivernoteitem_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernoteitem_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernoteitem_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_delivernoteitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_delivernoteitem_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem> lk_rbtt_delivernoteitem_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_delivernoteitem_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("lk_rbtt_delivernoteitem_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_delivernoteitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_processingactivity_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_processingactivity_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity> lk_rbtt_processingactivity_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_processingactivity_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_processingactivity_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_processingactivity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_processingactivity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity> lk_rbtt_processingactivity_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_processingactivity_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_processingactivity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_processingactivity_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_processingactivity_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity> lk_rbtt_processingactivity_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_processingactivity_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_processingactivity_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_processingactivity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_processingactivity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity> lk_rbtt_processingactivity_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_processingactivity_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_processingactivity>("lk_rbtt_processingactivity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_processingactivity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_productionplants_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_productionplants_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants> lk_rbtt_productionplants_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_productionplants_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_productionplants_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_productionplants_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_productionplants_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants> lk_rbtt_productionplants_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_productionplants_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_productionplants_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_productionplants_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_productionplants_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants> lk_rbtt_productionplants_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_productionplants_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_productionplants_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rbtt_productionplants_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_productionplants_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants> lk_rbtt_productionplants_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_productionplants_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("lk_rbtt_productionplants_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_productionplants_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessage_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage> lk_sdkmessage_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("lk_sdkmessage_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_sdkmessage_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("lk_sdkmessage_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessage_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessage_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage> lk_sdkmessage_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_sdkmessage_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessage_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstep_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep> lk_sdkmessageprocessingstep_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstep_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstep_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstep_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep> lk_sdkmessageprocessingstep_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstep_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstep_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser> Referencedlk_systemuser_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser> Referencedlk_systemuser_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser> Referencedlk_systemuserbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser> Referencedlk_systemuserbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_task_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> lk_task_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_createdby", null, value);
                this.OnPropertyChanged("lk_task_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_task_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> lk_task_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_task_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> lk_task_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_modifiedby", null, value);
                this.OnPropertyChanged("lk_task_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_task_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> lk_task_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_task_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("lk_task_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uom_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM> lk_uom_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uom_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uom_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uom_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uom_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM> lk_uom_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uom_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uom_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uom_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uombase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM> lk_uombase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uombase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uombase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uombase_createdby", null, value);
                this.OnPropertyChanged("lk_uombase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_uombase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM> lk_uombase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uombase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uombase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("lk_uombase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uombase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule> lk_uomschedule_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedule_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedule_createdonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule> lk_uomschedule_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedule_modifiedonbehalfby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule> lk_uomschedulebase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedulebase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_createdby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedulebase_createdby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule> lk_uomschedulebase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedulebase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_modifiedby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("lk_uomschedulebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessage")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage> modifiedby_sdkmessage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("modifiedby_sdkmessage", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessage");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessage>("modifiedby_sdkmessage", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep> modifiedby_sdkmessageprocessingstep
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageprocessingstep");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N opportunity_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> opportunity_owning_user
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_owning_user", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_owning_user");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_owning_user", null, value);
                this.OnPropertyChanged("opportunity_owning_user");
            }
        }

        /// <summary>
        /// 1:N rbtt_systemuser_orb_country_GDPRMailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_systemuser_orb_country_GDPRMailbox")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country> rbtt_systemuser_orb_country_GDPRMailbox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_systemuser_orb_country_GDPRMailbox", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_systemuser_orb_country_GDPRMailbox");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_systemuser_orb_country_GDPRMailbox", null, value);
                this.OnPropertyChanged("rbtt_systemuser_orb_country_GDPRMailbox");
            }
        }

        /// <summary>
        /// 1:N rbtt_systemuser_task_RhythmUpdatedBy
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_systemuser_task_RhythmUpdatedBy")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> rbtt_systemuser_task_RhythmUpdatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_systemuser_task_RhythmUpdatedBy", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_systemuser_task_RhythmUpdatedBy");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_systemuser_task_RhythmUpdatedBy", null, value);
                this.OnPropertyChanged("rbtt_systemuser_task_RhythmUpdatedBy");
            }
        }

        /// <summary>
        /// 1:N system_user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> system_user_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("system_user_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_accounts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("system_user_accounts", null, value);
                this.OnPropertyChanged("system_user_accounts");
            }
        }

        /// <summary>
        /// 1:N system_user_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> system_user_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("system_user_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("system_user_activity_parties", null, value);
                this.OnPropertyChanged("system_user_activity_parties");
            }
        }

        /// <summary>
        /// 1:N system_user_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> system_user_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("system_user_contacts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_contacts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("system_user_contacts", null, value);
                this.OnPropertyChanged("system_user_contacts");
            }
        }

        /// <summary>
        /// 1:N system_user_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotes")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> system_user_quotes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("system_user_quotes", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_quotes");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("system_user_quotes", null, value);
                this.OnPropertyChanged("system_user_quotes");
            }
        }

        /// <summary>
        /// 1:N SystemUser_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> SystemUser_Email_EmailSender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("SystemUser_Email_EmailSender", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SystemUser_Email_EmailSender");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("SystemUser_Email_EmailSender", null, value);
                this.OnPropertyChanged("SystemUser_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> user_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("user_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_accounts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("user_accounts", null, value);
                this.OnPropertyChanged("user_accounts");
            }
        }

        /// <summary>
        /// 1:N user_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_appointment")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> user_appointment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("user_appointment", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_appointment");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("user_appointment", null, value);
                this.OnPropertyChanged("user_appointment");
            }
        }

        /// <summary>
        /// 1:N user_btt_gratuity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_btt_gratuity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> user_btt_gratuity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("user_btt_gratuity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_btt_gratuity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("user_btt_gratuity", null, value);
                this.OnPropertyChanged("user_btt_gratuity");
            }
        }

        /// <summary>
        /// 1:N user_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_email")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> user_email
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("user_email", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_email");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("user_email", null, value);
                this.OnPropertyChanged("user_email");
            }
        }

        /// <summary>
        /// 1:N user_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orb_machine")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> user_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("user_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_orb_machine");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("user_orb_machine", null, value);
                this.OnPropertyChanged("user_orb_machine");
            }
        }

        /// <summary>
        /// 1:N user_orb_productgroup
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orb_productgroup")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup> user_orb_productgroup
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("user_orb_productgroup", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_orb_productgroup");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("user_orb_productgroup", null, value);
                this.OnPropertyChanged("user_orb_productgroup");
            }
        }

        /// <summary>
        /// 1:N user_orb_productgroupclassification
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orb_productgroupclassification")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> user_orb_productgroupclassification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("user_orb_productgroupclassification", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_orb_productgroupclassification");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("user_orb_productgroupclassification", null, value);
                this.OnPropertyChanged("user_orb_productgroupclassification");
            }
        }

        /// <summary>
        /// 1:N user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser> Referenceduser_parent_user
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referenceduser_parent_user");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referenceduser_parent_user");
            }
        }

        /// <summary>
        /// 1:N user_rbtt_apimonitor
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_rbtt_apimonitor")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor> user_rbtt_apimonitor
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("user_rbtt_apimonitor", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_rbtt_apimonitor");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_apimonitor>("user_rbtt_apimonitor", null, value);
                this.OnPropertyChanged("user_rbtt_apimonitor");
            }
        }

        /// <summary>
        /// 1:N user_rbtt_applicationid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_rbtt_applicationid")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid> user_rbtt_applicationid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("user_rbtt_applicationid", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_rbtt_applicationid");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applicationid>("user_rbtt_applicationid", null, value);
                this.OnPropertyChanged("user_rbtt_applicationid");
            }
        }

        /// <summary>
        /// 1:N user_rbtt_customermasterdataexchange
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_rbtt_customermasterdataexchange")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange> user_rbtt_customermasterdataexchange
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("user_rbtt_customermasterdataexchange", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_rbtt_customermasterdataexchange");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("user_rbtt_customermasterdataexchange", null, value);
                this.OnPropertyChanged("user_rbtt_customermasterdataexchange");
            }
        }

        /// <summary>
        /// 1:N user_rbtt_delivernote
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_rbtt_delivernote")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote> user_rbtt_delivernote
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("user_rbtt_delivernote", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_rbtt_delivernote");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("user_rbtt_delivernote", null, value);
                this.OnPropertyChanged("user_rbtt_delivernote");
            }
        }

        /// <summary>
        /// 1:N user_rbtt_delivernoteitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_rbtt_delivernoteitem")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem> user_rbtt_delivernoteitem
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("user_rbtt_delivernoteitem", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_rbtt_delivernoteitem");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("user_rbtt_delivernoteitem", null, value);
                this.OnPropertyChanged("user_rbtt_delivernoteitem");
            }
        }

        /// <summary>
        /// 1:N user_task
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_task")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> user_task
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("user_task", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_task");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("user_task", null, value);
                this.OnPropertyChanged("user_task");
            }
        }

        /// <summary>
        /// N:N btt_opportunity_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_opportunity_systemuser")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> btt_opportunity_systemuser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_opportunity_systemuser", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_opportunity_systemuser");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_opportunity_systemuser", null, value);
                this.OnPropertyChanged("btt_opportunity_systemuser");
            }
        }

        /// <summary>
        /// N:1 btt_orb_country_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_countryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_country_systemuser")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country btt_orb_country_systemuser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_systemuser", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_country_systemuser");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("btt_orb_country_systemuser", null, value);
                this.OnPropertyChanged("btt_orb_country_systemuser");
            }
        }

        /// <summary>
        /// N:1 lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser Referencinglk_systemuser_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencinglk_systemuser_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinglk_systemuser_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser Referencinglk_systemuser_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencinglk_systemuser_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinglk_systemuser_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser Referencinglk_systemuserbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencinglk_systemuserbase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinglk_systemuserbase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser Referencinglk_systemuserbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencinglk_systemuserbase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinglk_systemuserbase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 rbtt_account_systemuser_SalesOrganization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_salesorganization")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_systemuser_SalesOrganization")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account rbtt_account_systemuser_SalesOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_systemuser_SalesOrganization", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_systemuser_SalesOrganization");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_systemuser_SalesOrganization", null, value);
                this.OnPropertyChanged("rbtt_account_systemuser_SalesOrganization");
            }
        }

        /// <summary>
        /// N:1 user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser Referencinguser_parent_user
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencinguser_parent_user");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinguser_parent_user");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public SystemUser(object anonymousType) :
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
                        Attributes["systemuserid"] = base.Id;
                        break;
                    case "systemuserid":
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