namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_machineState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Product Registrations
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("orb_machine")]
    public partial class Orb_machine : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string Btt_attention = "btt_attention";
            public const string BTT_Counter = "btt_counter";
            public const string Btt_dateofpayment = "btt_dateofpayment";
            public const string BTT_FactoryNumber = "btt_factorynumber";
            public const string Btt_fdnumber = "btt_fdnumber";
            public const string Btt_installationcertnumber = "btt_installationcertnumber";
            public const string btt_installerid = "btt_installerid";
            public const string Btt_locationname = "btt_locationname";
            public const string Btt_LocationPostalCode = "btt_locationpostalcode";
            public const string Btt_LocationStreet = "btt_locationstreet";
            public const string Btt_Partofproject = "btt_partofproject";
            public const string btt_productgroupid = "btt_productgroupid";
            public const string Btt_Productiondate = "btt_productiondate";
            public const string Btt_Productnumber = "btt_productnumber";
            public const string btt_rewardplanid = "btt_rewardplanid";
            public const string Btt_sapnumber = "btt_sapnumber";
            public const string btt_servicecompanyid = "btt_servicecompanyid";
            public const string Btt_startupcertnumber = "btt_startupcertnumber";
            public const string Btt_status = "btt_status";
            public const string Btt_street = "btt_street";
            public const string Btt_telephone = "btt_telephone";
            public const string Btt_Telephone1 = "btt_telephone1";
            public const string Btt_WarrantyStartDate = "btt_warrantystartdate";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Orb_acceptancedate = "orb_acceptancedate";
            public const string orb_accountid = "orb_accountid";
            public const string Orb_contractnumber = "orb_contractnumber";
            public const string Orb_Description = "orb_description";
            public const string Orb_installationEndDate = "orb_installationenddate";
            public const string Orb_isaccepted = "orb_isaccepted";
            public const string Orb_isserviced = "orb_isserviced";
            public const string Orb_machineId = "orb_machineid";
            public const string Id = "orb_machineid";
            public const string Orb_name = "orb_name";
            public const string orb_recipientid = "orb_recipientid";
            public const string Orb_serviceenddate = "orb_serviceenddate";
            public const string Orb_servicestartdate = "orb_servicestartdate";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string rbtt_AccountId = "rbtt_accountid";
            public const string rbtt_Address1_City = "rbtt_address1_city";
            public const string rbtt_Address1_HouseNumber = "rbtt_address1_housenumber";
            public const string rbtt_Address1_PostalCode = "rbtt_address1_postalcode";
            public const string rbtt_Address1Latitude = "rbtt_address1latitude";
            public const string rbtt_Address1Longitude = "rbtt_address1longitude";
            public const string rbtt_BasicGarantyEndDate = "rbtt_basicgarantyenddate";
            public const string rbtt_Brand = "rbtt_brand";
            public const string rbtt_ContactId = "rbtt_contactid";
            public const string rbtt_CounterProduction = "rbtt_counterproduction";
            public const string rbtt_Country = "rbtt_country";
            public const string rbtt_EndCustomer = "rbtt_endcustomer";
            public const string rbtt_ExtendedGarantyEndDate = "rbtt_extendedgarantyenddate";
            public const string rbtt_ExternalAccountNumber = "rbtt_externalaccountnumber";
            public const string rbtt_ExternalContactNumber = "rbtt_externalcontactnumber";
            public const string rbtt_ExternalRegistrationNumber = "rbtt_externalregistrationnumber";
            public const string rbtt_InstallationDate = "rbtt_installationdate";
            public const string rbtt_InterestedInExtendedGaranty = "rbtt_interestedinextendedgaranty";
            public const string rbtt_InterestedInMaintenance = "rbtt_interestedinmaintenance";
            public const string rbtt_LocationContact = "rbtt_locationcontact";
            public const string rbtt_Locationname = "rbtt_locationname";
            public const string rbtt_LPKEquipment = "rbtt_lpkequipment";
            public const string rbtt_mainasset = "rbtt_mainasset";
            public const string rbtt_ManufacturingDate = "rbtt_manufacturingdate";
            public const string rbtt_Points = "rbtt_points";
            public const string rbtt_Product = "rbtt_product";
            public const string rbtt_PTTFunctionalLocationNo = "rbtt_pttfunctionallocationno";
            public const string rbtt_registered = "rbtt_registered";
            public const string rbtt_RegistrationDate = "rbtt_registrationdate";
            public const string rbtt_RegistrationReason = "rbtt_registrationreason";
            public const string rbtt_RegistrationType = "rbtt_registrationtype";
            public const string rbtt_serialnumber = "rbtt_serialnumber";
            public const string rbtt_StartUpdate = "rbtt_startupdate";
            public const string rbtt_StartUpdoneby = "rbtt_startupdoneby";
            public const string rbtt_Street2 = "rbtt_street2";
            public const string rbtt_Supplier = "rbtt_supplier";
            public const string rbtt_Technology = "rbtt_technology";
            public const string rbtt_TotalGarantyEndDate = "rbtt_totalgarantyenddate";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string btt_account_orb_machine = "btt_account_orb_machine";
            public const string btt_orb_productgroup_orb_machine = "btt_orb_productgroup_orb_machine";
            public const string btt_setup_account_orb_machine = "btt_setup_account_orb_machine";
            public const string lk_orb_machine_createdby = "lk_orb_machine_createdby";
            public const string lk_orb_machine_createdonbehalfby = "lk_orb_machine_createdonbehalfby";
            public const string lk_orb_machine_modifiedby = "lk_orb_machine_modifiedby";
            public const string lk_orb_machine_modifiedonbehalfby = "lk_orb_machine_modifiedonbehalfby";
            public const string orb_account_orb_machine = "orb_account_orb_machine";
            public const string orb_recipient_orb_machine = "orb_recipient_orb_machine";
            public const string rbtt_account_orb_machine_AccountId = "rbtt_account_orb_machine_AccountId";
            public const string rbtt_account_orb_machine_EndCustomer = "rbtt_account_orb_machine_EndCustomer";
            public const string rbtt_account_orb_machine_LocationContact = "rbtt_account_orb_machine_LocationContact";
            public const string rbtt_account_orb_machine_StartUpdoneby = "rbtt_account_orb_machine_StartUpdoneby";
            public const string rbtt_contact_orb_machine_ContactId = "rbtt_contact_orb_machine_ContactId";
            public const string rbtt_contact_orb_machine_EndCustomer = "rbtt_contact_orb_machine_EndCustomer";
            public const string rbtt_contact_orb_machine_LocationContact = "rbtt_contact_orb_machine_LocationContact";
            public const string rbtt_contact_orb_machine_StartUpdoneby = "rbtt_contact_orb_machine_StartUpdoneby";
            public const string rbtt_orb_country_orb_machine_Country = "rbtt_orb_country_orb_machine_Country";
            public const string Referencingrbtt_orb_machine_orb_machine_Main = "rbtt_orb_machine_orb_machine_Main";
            public const string rbtt_rbtt_appliance_orb_machine_serialnumber = "rbtt_rbtt_appliance_orb_machine_serialnumber";
            public const string user_orb_machine = "user_orb_machine";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_machine() :
                base(EntityLogicalName)
        {
        }

        public const string AlternateKeys = "orb_name,rbtt_externalregistrationnumber";

        public const string EntityLogicalName = "orb_machine";

        public const string EntitySchemaName = "Orb_machine";

        public const string PrimaryIdAttribute = "orb_machineid";

        public const string PrimaryNameAttribute = "orb_name";

        public const string EntityLogicalCollectionName = "orb_machines";

        public const string EntitySetName = "orb_machines";

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
        /// Attention
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_attention")]
        public string Btt_attention
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_attention");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_attention");
                this.SetAttributeValue("btt_attention", value);
                this.OnPropertyChanged("Btt_attention");
            }
        }

        /// <summary>
        /// Serial number of the machine: Counter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_counter")]
        public System.Nullable<int> BTT_Counter
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_counter");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_Counter");
                this.SetAttributeValue("btt_counter", value);
                this.OnPropertyChanged("BTT_Counter");
            }
        }

        /// <summary>
        /// Date of payment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dateofpayment")]
        public System.Nullable<System.DateTime> Btt_dateofpayment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_dateofpayment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_dateofpayment");
                this.SetAttributeValue("btt_dateofpayment", value);
                this.OnPropertyChanged("Btt_dateofpayment");
            }
        }

        /// <summary>
        /// Serial number of the machine: 3 digit factory number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_factorynumber")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_FactoryNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_factorynumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_FactoryNumber");
                this.SetAttributeValue("btt_factorynumber", value);
                this.OnPropertyChanged("BTT_FactoryNumber");
            }
        }

        /// <summary>
        /// Serial number of the machine: 3 digit factory number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_factorynumber")]
        public virtual Orb_machine_BTT_FactoryNumber? BTT_FactoryNumberEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_machine_BTT_FactoryNumber?)(EntityOptionSetEnum.GetEnum(this, "btt_factorynumber")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_FactoryNumber");
                this.SetAttributeValue("btt_factorynumber", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_FactoryNumber");
            }
        }

        /// <summary>
        /// FD no.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_fdnumber")]
        public string Btt_fdnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_fdnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_fdnumber");
                this.SetAttributeValue("btt_fdnumber", value);
                this.OnPropertyChanged("Btt_fdnumber");
            }
        }

        /// <summary>
        /// A Certificate no. (installer)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installationcertnumber")]
        public string Btt_installationcertnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_installationcertnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_installationcertnumber");
                this.SetAttributeValue("btt_installationcertnumber", value);
                this.OnPropertyChanged("Btt_installationcertnumber");
            }
        }

        /// <summary>
        /// Installer/Account who did the Product Installation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installerid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_installerid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_installerid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_installerid");
                this.SetAttributeValue("btt_installerid", value);
                this.OnPropertyChanged("btt_installerid");
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_locationname")]
        public string Btt_locationname
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_locationname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_locationname");
                this.SetAttributeValue("btt_locationname", value);
                this.OnPropertyChanged("Btt_locationname");
            }
        }

        /// <summary>
        /// Location: ZIP/Postal code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_locationpostalcode")]
        public string Btt_LocationPostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_locationpostalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_LocationPostalCode");
                this.SetAttributeValue("btt_locationpostalcode", value);
                this.OnPropertyChanged("Btt_LocationPostalCode");
            }
        }

        /// <summary>
        /// Location: Street
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_locationstreet")]
        public string Btt_LocationStreet
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_locationstreet");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_LocationStreet");
                this.SetAttributeValue("btt_locationstreet", value);
                this.OnPropertyChanged("Btt_LocationStreet");
            }
        }

        /// <summary>
        /// Part of a opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_partofproject")]
        public System.Nullable<bool> Btt_Partofproject
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_partofproject");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Partofproject");
                this.SetAttributeValue("btt_partofproject", value);
                this.OnPropertyChanged("Btt_Partofproject");
            }
        }

        /// <summary>
        /// Unique identifier for Product Group associated with Appliance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productgroupid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_productgroupid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_productgroupid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_productgroupid");
                this.SetAttributeValue("btt_productgroupid", value);
                this.OnPropertyChanged("btt_productgroupid");
            }
        }

        /// <summary>
        /// Serial number of the machine: 3 or 4 digit production date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productiondate")]
        public System.Nullable<int> Btt_Productiondate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_productiondate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Productiondate");
                this.SetAttributeValue("btt_productiondate", value);
                this.OnPropertyChanged("Btt_Productiondate");
            }
        }

        /// <summary>
        /// Product number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productnumber")]
        public string Btt_Productnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_productnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Productnumber");
                this.SetAttributeValue("btt_productnumber", value);
                this.OnPropertyChanged("Btt_Productnumber");
            }
        }

        /// <summary>
        /// Unique identifier for Reward plan associated with Product Registration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_rewardplanid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_rewardplanid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_rewardplanid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_rewardplanid");
                this.SetAttributeValue("btt_rewardplanid", value);
                this.OnPropertyChanged("btt_rewardplanid");
            }
        }

        /// <summary>
        /// SAP no.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_sapnumber")]
        public string Btt_sapnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_sapnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_sapnumber");
                this.SetAttributeValue("btt_sapnumber", value);
                this.OnPropertyChanged("Btt_sapnumber");
            }
        }

        /// <summary>
        /// Unique identifier for Account associated with Appliance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_servicecompanyid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_servicecompanyid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_servicecompanyid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_servicecompanyid");
                this.SetAttributeValue("btt_servicecompanyid", value);
                this.OnPropertyChanged("btt_servicecompanyid");
            }
        }

        /// <summary>
        /// A Certificate no. (service company)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_startupcertnumber")]
        public string Btt_startupcertnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_startupcertnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_startupcertnumber");
                this.SetAttributeValue("btt_startupcertnumber", value);
                this.OnPropertyChanged("Btt_startupcertnumber");
            }
        }

        /// <summary>
        /// Payment status
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_status")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_status
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_status");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_status");
                this.SetAttributeValue("btt_status", value);
                this.OnPropertyChanged("Btt_status");
            }
        }

        /// <summary>
        /// Payment status
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_status")]
        public virtual Orb_machine_Btt_status? Btt_statusEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_machine_Btt_status?)(EntityOptionSetEnum.GetEnum(this, "btt_status")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_status");
                this.SetAttributeValue("btt_status", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_status");
            }
        }

        /// <summary>
        /// Street
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_street")]
        public string Btt_street
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_street");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_street");
                this.SetAttributeValue("btt_street", value);
                this.OnPropertyChanged("Btt_street");
            }
        }

        /// <summary>
        /// Telephone
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_telephone")]
        public string Btt_telephone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_telephone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_telephone");
                this.SetAttributeValue("btt_telephone", value);
                this.OnPropertyChanged("Btt_telephone");
            }
        }

        /// <summary>
        /// Telephone Other
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_telephone1")]
        public string Btt_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_telephone1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Telephone1");
                this.SetAttributeValue("btt_telephone1", value);
                this.OnPropertyChanged("Btt_Telephone1");
            }
        }

        /// <summary>
        /// Product Registration Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_warrantystartdate")]
        public System.Nullable<System.DateTime> Btt_WarrantyStartDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_warrantystartdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_WarrantyStartDate");
                this.SetAttributeValue("btt_warrantystartdate", value);
                this.OnPropertyChanged("Btt_WarrantyStartDate");
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
        /// Acceptance Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_acceptancedate")]
        public System.Nullable<System.DateTime> Orb_acceptancedate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_acceptancedate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_acceptancedate");
                this.SetAttributeValue("orb_acceptancedate", value);
                this.OnPropertyChanged("Orb_acceptancedate");
            }
        }

        /// <summary>
        /// Unique identifier for Account associated with Product Registration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_accountid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_accountid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_accountid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_accountid");
                this.SetAttributeValue("orb_accountid", value);
                this.OnPropertyChanged("orb_accountid");
            }
        }

        /// <summary>
        /// Contract Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_contractnumber")]
        public string Orb_contractnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_contractnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_contractnumber");
                this.SetAttributeValue("orb_contractnumber", value);
                this.OnPropertyChanged("Orb_contractnumber");
            }
        }

        /// <summary>
        /// Description
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_description")]
        public string Orb_Description
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_description");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_Description");
                this.SetAttributeValue("orb_description", value);
                this.OnPropertyChanged("Orb_Description");
            }
        }

        /// <summary>
        /// Installation end date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_installationenddate")]
        public System.Nullable<System.DateTime> Orb_installationEndDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_installationenddate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_installationEndDate");
                this.SetAttributeValue("orb_installationenddate", value);
                this.OnPropertyChanged("Orb_installationEndDate");
            }
        }

        /// <summary>
        /// Is accepted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_isaccepted")]
        public System.Nullable<bool> Orb_isaccepted
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_isaccepted");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_isaccepted");
                this.SetAttributeValue("orb_isaccepted", value);
                this.OnPropertyChanged("Orb_isaccepted");
            }
        }

        /// <summary>
        /// Is serviced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_isserviced")]
        public System.Nullable<bool> Orb_isserviced
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_isserviced");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_isserviced");
                this.SetAttributeValue("orb_isserviced", value);
                this.OnPropertyChanged("Orb_isserviced");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_machineid")]
        public System.Nullable<System.Guid> Orb_machineId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("orb_machineid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_machineId");
                this.SetAttributeValue("orb_machineid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("Orb_machineId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_machineid")]
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
                this.Orb_machineId = value;
            }
        }

        /// <summary>
        /// The Serial Number of the Product Registration entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_name")]
        public string Orb_name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_name");
                this.SetAttributeValue("orb_name", value);
                this.OnPropertyChanged("Orb_name");
            }
        }

        /// <summary>
        /// Unique identifier for Account associated with Product Registration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_recipientid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_recipientid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_recipientid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_recipientid");
                this.SetAttributeValue("orb_recipientid", value);
                this.OnPropertyChanged("orb_recipientid");
            }
        }

        /// <summary>
        /// Service end date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_serviceenddate")]
        public System.Nullable<System.DateTime> Orb_serviceenddate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_serviceenddate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_serviceenddate");
                this.SetAttributeValue("orb_serviceenddate", value);
                this.OnPropertyChanged("Orb_serviceenddate");
            }
        }

        /// <summary>
        /// Service start date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_servicestartdate")]
        public System.Nullable<System.DateTime> Orb_servicestartdate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_servicestartdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_servicestartdate");
                this.SetAttributeValue("orb_servicestartdate", value);
                this.OnPropertyChanged("Orb_servicestartdate");
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
        /// Company/Account who did the Product Registration
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_accountid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_accountid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_AccountId");
                this.SetAttributeValue("rbtt_accountid", value);
                this.OnPropertyChanged("rbtt_AccountId");
            }
        }

        /// <summary>
        /// City
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_address1_city")]
        public string rbtt_Address1_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_address1_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Address1_City");
                this.SetAttributeValue("rbtt_address1_city", value);
                this.OnPropertyChanged("rbtt_Address1_City");
            }
        }

        /// <summary>
        /// House Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_address1_housenumber")]
        public string rbtt_Address1_HouseNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_address1_housenumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Address1_HouseNumber");
                this.SetAttributeValue("rbtt_address1_housenumber", value);
                this.OnPropertyChanged("rbtt_Address1_HouseNumber");
            }
        }

        /// <summary>
        /// ZIP/Postal Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_address1_postalcode")]
        public string rbtt_Address1_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_address1_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Address1_PostalCode");
                this.SetAttributeValue("rbtt_address1_postalcode", value);
                this.OnPropertyChanged("rbtt_Address1_PostalCode");
            }
        }

        /// <summary>
        /// Latitude coordinate where the Appliance was installed
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_address1latitude")]
        public System.Nullable<double> rbtt_Address1Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("rbtt_address1latitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Address1Latitude");
                this.SetAttributeValue("rbtt_address1latitude", value);
                this.OnPropertyChanged("rbtt_Address1Latitude");
            }
        }

        /// <summary>
        /// Longitude coordinate where the Appliance was installed
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_address1longitude")]
        public System.Nullable<double> rbtt_Address1Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("rbtt_address1longitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Address1Longitude");
                this.SetAttributeValue("rbtt_address1longitude", value);
                this.OnPropertyChanged("rbtt_Address1Longitude");
            }
        }

        /// <summary>
        /// Basic Warranty End Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_basicgarantyenddate")]
        public System.Nullable<System.DateTime> rbtt_BasicGarantyEndDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_basicgarantyenddate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_BasicGarantyEndDate");
                this.SetAttributeValue("rbtt_basicgarantyenddate", value);
                this.OnPropertyChanged("rbtt_BasicGarantyEndDate");
            }
        }

        /// <summary>
        /// Brand
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_brand")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_Brand
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_brand");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Brand");
                this.SetAttributeValue("rbtt_brand", value);
                this.OnPropertyChanged("rbtt_Brand");
            }
        }

        /// <summary>
        /// Brand
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_brand")]
        public virtual btt_Brands? rbtt_BrandEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "rbtt_brand")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Brand");
                this.SetAttributeValue("rbtt_brand", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_Brand");
            }
        }

        /// <summary>
        /// Contact Id
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_contactid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_contactid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ContactId");
                this.SetAttributeValue("rbtt_contactid", value);
                this.OnPropertyChanged("rbtt_ContactId");
            }
        }

        /// <summary>
        /// Counter Production
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_counterproduction")]
        public string rbtt_CounterProduction
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_counterproduction");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_CounterProduction");
                this.SetAttributeValue("rbtt_counterproduction", value);
                this.OnPropertyChanged("rbtt_CounterProduction");
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
        /// End-Customer of the appliance. Could be Account or Contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_endcustomer")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_EndCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_endcustomer");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_EndCustomer");
                this.SetAttributeValue("rbtt_endcustomer", value);
                this.OnPropertyChanged("rbtt_EndCustomer");
            }
        }

        /// <summary>
        /// Extended Warranty End Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_extendedgarantyenddate")]
        public System.Nullable<System.DateTime> rbtt_ExtendedGarantyEndDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_extendedgarantyenddate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ExtendedGarantyEndDate");
                this.SetAttributeValue("rbtt_extendedgarantyenddate", value);
                this.OnPropertyChanged("rbtt_ExtendedGarantyEndDate");
            }
        }

        /// <summary>
        /// External Account Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_externalaccountnumber")]
        public string rbtt_ExternalAccountNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_externalaccountnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ExternalAccountNumber");
                this.SetAttributeValue("rbtt_externalaccountnumber", value);
                this.OnPropertyChanged("rbtt_ExternalAccountNumber");
            }
        }

        /// <summary>
        /// External Contact Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_externalcontactnumber")]
        public string rbtt_ExternalContactNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_externalcontactnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ExternalContactNumber");
                this.SetAttributeValue("rbtt_externalcontactnumber", value);
                this.OnPropertyChanged("rbtt_ExternalContactNumber");
            }
        }

        /// <summary>
        /// External Registration Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_externalregistrationnumber")]
        public string rbtt_ExternalRegistrationNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_externalregistrationnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ExternalRegistrationNumber");
                this.SetAttributeValue("rbtt_externalregistrationnumber", value);
                this.OnPropertyChanged("rbtt_ExternalRegistrationNumber");
            }
        }

        /// <summary>
        /// Installation Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_installationdate")]
        public System.Nullable<System.DateTime> rbtt_InstallationDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_installationdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_InstallationDate");
                this.SetAttributeValue("rbtt_installationdate", value);
                this.OnPropertyChanged("rbtt_InstallationDate");
            }
        }

        /// <summary>
        /// Interested In Extended Warranty
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_interestedinextendedgaranty")]
        public System.Nullable<bool> rbtt_InterestedInExtendedGaranty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_interestedinextendedgaranty");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_InterestedInExtendedGaranty");
                this.SetAttributeValue("rbtt_interestedinextendedgaranty", value);
                this.OnPropertyChanged("rbtt_InterestedInExtendedGaranty");
            }
        }

        /// <summary>
        /// Interested In Maintenance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_interestedinmaintenance")]
        public System.Nullable<bool> rbtt_InterestedInMaintenance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_interestedinmaintenance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_InterestedInMaintenance");
                this.SetAttributeValue("rbtt_interestedinmaintenance", value);
                this.OnPropertyChanged("rbtt_InterestedInMaintenance");
            }
        }

        /// <summary>
        /// Customer (Account/Contact) that can be contacted in case of need it.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_locationcontact")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_LocationContact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_locationcontact");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LocationContact");
                this.SetAttributeValue("rbtt_locationcontact", value);
                this.OnPropertyChanged("rbtt_LocationContact");
            }
        }

        /// <summary>
        /// Location name
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_locationname")]
        public string rbtt_Locationname
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_locationname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Locationname");
                this.SetAttributeValue("rbtt_locationname", value);
                this.OnPropertyChanged("rbtt_Locationname");
            }
        }

        /// <summary>
        /// LPK Equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_lpkequipment")]
        public System.Nullable<bool> rbtt_LPKEquipment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_lpkequipment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LPKEquipment");
                this.SetAttributeValue("rbtt_lpkequipment", value);
                this.OnPropertyChanged("rbtt_LPKEquipment");
            }
        }

        /// <summary>
        /// Main Asset
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_mainasset")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_mainasset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_mainasset");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_mainasset");
                this.SetAttributeValue("rbtt_mainasset", value);
                this.OnPropertyChanged("rbtt_mainasset");
            }
        }

        /// <summary>
        /// Manufacturing Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_manufacturingdate")]
        public string rbtt_ManufacturingDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_manufacturingdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ManufacturingDate");
                this.SetAttributeValue("rbtt_manufacturingdate", value);
                this.OnPropertyChanged("rbtt_ManufacturingDate");
            }
        }

        /// <summary>
        /// Points
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_points")]
        public string rbtt_Points
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_points");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Points");
                this.SetAttributeValue("rbtt_points", value);
                this.OnPropertyChanged("rbtt_Points");
            }
        }

        /// <summary>
        /// Product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_product")]
        public string rbtt_Product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_product");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Product");
                this.SetAttributeValue("rbtt_product", value);
                this.OnPropertyChanged("rbtt_Product");
            }
        }

        /// <summary>
        /// SAP-PTT Functional Location
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_pttfunctionallocationno")]
        public string rbtt_PTTFunctionalLocationNo
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_pttfunctionallocationno");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PTTFunctionalLocationNo");
                this.SetAttributeValue("rbtt_pttfunctionallocationno", value);
                this.OnPropertyChanged("rbtt_PTTFunctionalLocationNo");
            }
        }

        /// <summary>
        /// Registered
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_registered")]
        public System.Nullable<bool> rbtt_registered
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_registered");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_registered");
                this.SetAttributeValue("rbtt_registered", value);
                this.OnPropertyChanged("rbtt_registered");
            }
        }

        /// <summary>
        /// Registration Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_registrationdate")]
        public System.Nullable<System.DateTime> rbtt_RegistrationDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_registrationdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RegistrationDate");
                this.SetAttributeValue("rbtt_registrationdate", value);
                this.OnPropertyChanged("rbtt_RegistrationDate");
            }
        }

        /// <summary>
        /// Identify why the registration was done
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_registrationreason")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_RegistrationReason
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_registrationreason");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RegistrationReason");
                this.SetAttributeValue("rbtt_registrationreason", value);
                this.OnPropertyChanged("rbtt_RegistrationReason");
            }
        }

        /// <summary>
        /// Identify why the registration was done
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_registrationreason")]
        public virtual Orb_machine_rbtt_RegistrationReason? rbtt_RegistrationReasonEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_machine_rbtt_RegistrationReason?)(EntityOptionSetEnum.GetEnum(this, "rbtt_registrationreason")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RegistrationReason");
                this.SetAttributeValue("rbtt_registrationreason", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_RegistrationReason");
            }
        }

        /// <summary>
        /// Registration Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_registrationtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_RegistrationType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_registrationtype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RegistrationType");
                this.SetAttributeValue("rbtt_registrationtype", value);
                this.OnPropertyChanged("rbtt_RegistrationType");
            }
        }

        /// <summary>
        /// Registration Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_registrationtype")]
        public virtual rbtt_RegistrationTypeList? rbtt_RegistrationTypeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_RegistrationTypeList?)(EntityOptionSetEnum.GetEnum(this, "rbtt_registrationtype")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RegistrationType");
                this.SetAttributeValue("rbtt_registrationtype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_RegistrationType");
            }
        }

        /// <summary>
        /// Serial Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_serialnumber")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_serialnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_serialnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_serialnumber");
                this.SetAttributeValue("rbtt_serialnumber", value);
                this.OnPropertyChanged("rbtt_serialnumber");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_startupdate")]
        public System.Nullable<System.DateTime> rbtt_StartUpdate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_startupdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_StartUpdate");
                this.SetAttributeValue("rbtt_startupdate", value);
                this.OnPropertyChanged("rbtt_StartUpdate");
            }
        }

        /// <summary>
        /// Start-up customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_startupdoneby")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_StartUpdoneby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_startupdoneby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_StartUpdoneby");
                this.SetAttributeValue("rbtt_startupdoneby", value);
                this.OnPropertyChanged("rbtt_StartUpdoneby");
            }
        }

        /// <summary>
        /// Street 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_street2")]
        public string rbtt_Street2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_street2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Street2");
                this.SetAttributeValue("rbtt_street2", value);
                this.OnPropertyChanged("rbtt_Street2");
            }
        }

        /// <summary>
        /// Supplier
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_supplier")]
        public string rbtt_Supplier
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_supplier");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Supplier");
                this.SetAttributeValue("rbtt_supplier", value);
                this.OnPropertyChanged("rbtt_Supplier");
            }
        }

        /// <summary>
        /// Technology
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_technology")]
        public string rbtt_Technology
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_technology");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Technology");
                this.SetAttributeValue("rbtt_technology", value);
                this.OnPropertyChanged("rbtt_Technology");
            }
        }

        /// <summary>
        /// Total Warranty End Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_totalgarantyenddate")]
        public System.Nullable<System.DateTime> rbtt_TotalGarantyEndDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_totalgarantyenddate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_TotalGarantyEndDate");
                this.SetAttributeValue("rbtt_totalgarantyenddate", value);
                this.OnPropertyChanged("rbtt_TotalGarantyEndDate");
            }
        }

        /// <summary>
        /// Status of the Machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machineState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machineState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machineState), optionSet.Value)));
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
        /// Reason for the status of the Machine
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
        /// Reason for the status of the Machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Orb_machine_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Orb_machine_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N orb_machine_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_machine_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> orb_machine_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("orb_machine_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_machine_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("orb_machine_Appointments", null, value);
                this.OnPropertyChanged("orb_machine_Appointments");
            }
        }

        /// <summary>
        /// 1:N orb_machine_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_machine_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> orb_machine_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("orb_machine_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_machine_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("orb_machine_Emails", null, value);
                this.OnPropertyChanged("orb_machine_Emails");
            }
        }

        /// <summary>
        /// 1:N orb_machine_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_machine_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> orb_machine_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("orb_machine_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_machine_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("orb_machine_Tasks", null, value);
                this.OnPropertyChanged("orb_machine_Tasks");
            }
        }

        /// <summary>
        /// 1:N rbtt_orb_machine_opportunity_PlantLocationId
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_machine_opportunity_PlantLocationId")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> rbtt_orb_machine_opportunity_PlantLocationId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("rbtt_orb_machine_opportunity_PlantLocationId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_machine_opportunity_PlantLocationId");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("rbtt_orb_machine_opportunity_PlantLocationId", null, value);
                this.OnPropertyChanged("rbtt_orb_machine_opportunity_PlantLocationId");
            }
        }

        /// <summary>
        /// 1:N rbtt_orb_machine_orb_machine_Main
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_machine_orb_machine_Main", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> Referencedrbtt_orb_machine_orb_machine_Main
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_orb_machine_orb_machine_Main", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedrbtt_orb_machine_orb_machine_Main");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_orb_machine_orb_machine_Main", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedrbtt_orb_machine_orb_machine_Main");
            }
        }

        /// <summary>
        /// N:1 btt_account_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_account_orb_machine")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account btt_account_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_account_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_account_orb_machine");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_account_orb_machine", null, value);
                this.OnPropertyChanged("btt_account_orb_machine");
            }
        }

        /// <summary>
        /// N:1 btt_orb_productgroup_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_productgroupid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_orb_productgroup_orb_machine")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup btt_orb_productgroup_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_orb_productgroup_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_orb_productgroup_orb_machine");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("btt_orb_productgroup_orb_machine", null, value);
                this.OnPropertyChanged("btt_orb_productgroup_orb_machine");
            }
        }

        /// <summary>
        /// N:1 btt_setup_account_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_servicecompanyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_setup_account_orb_machine")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account btt_setup_account_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_setup_account_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_setup_account_orb_machine");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("btt_setup_account_orb_machine", null, value);
                this.OnPropertyChanged("btt_setup_account_orb_machine");
            }
        }

        /// <summary>
        /// N:1 lk_orb_machine_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_machine_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_createdby", null, value);
                this.OnPropertyChanged("lk_orb_machine_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_machine_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_machine_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_machine_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_machine_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_machine_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_modifiedby", null, value);
                this.OnPropertyChanged("lk_orb_machine_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_orb_machine_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orb_machine_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_orb_machine_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_orb_machine_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_orb_machine_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orb_machine_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 orb_account_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_accountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_account_orb_machine")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account orb_account_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_account_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_account_orb_machine");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_account_orb_machine", null, value);
                this.OnPropertyChanged("orb_account_orb_machine");
            }
        }

        /// <summary>
        /// N:1 orb_recipient_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_recipientid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_recipient_orb_machine")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account orb_recipient_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_recipient_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_recipient_orb_machine");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("orb_recipient_orb_machine", null, value);
                this.OnPropertyChanged("orb_recipient_orb_machine");
            }
        }

        /// <summary>
        /// N:1 rbtt_account_orb_machine_AccountId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_accountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_AccountId")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account rbtt_account_orb_machine_AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_AccountId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_AccountId");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_AccountId", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_AccountId");
            }
        }

        /// <summary>
        /// N:1 rbtt_account_orb_machine_EndCustomer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_endcustomer")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_EndCustomer")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account rbtt_account_orb_machine_EndCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_EndCustomer", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_EndCustomer");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_EndCustomer", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_EndCustomer");
            }
        }

        /// <summary>
        /// N:1 rbtt_account_orb_machine_LocationContact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_locationcontact")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_LocationContact")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account rbtt_account_orb_machine_LocationContact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_LocationContact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_LocationContact");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_LocationContact", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_LocationContact");
            }
        }

        /// <summary>
        /// N:1 rbtt_account_orb_machine_StartUpdoneby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_startupdoneby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_StartUpdoneby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account rbtt_account_orb_machine_StartUpdoneby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_StartUpdoneby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_StartUpdoneby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_orb_machine_StartUpdoneby", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_StartUpdoneby");
            }
        }

        /// <summary>
        /// N:1 rbtt_contact_orb_machine_ContactId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_contactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_ContactId")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact rbtt_contact_orb_machine_ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_ContactId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_ContactId");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_ContactId", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_ContactId");
            }
        }

        /// <summary>
        /// N:1 rbtt_contact_orb_machine_EndCustomer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_endcustomer")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_EndCustomer")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact rbtt_contact_orb_machine_EndCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_EndCustomer", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_EndCustomer");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_EndCustomer", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_EndCustomer");
            }
        }

        /// <summary>
        /// N:1 rbtt_contact_orb_machine_LocationContact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_locationcontact")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_LocationContact")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact rbtt_contact_orb_machine_LocationContact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_LocationContact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_LocationContact");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_LocationContact", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_LocationContact");
            }
        }

        /// <summary>
        /// N:1 rbtt_contact_orb_machine_StartUpdoneby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_startupdoneby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_StartUpdoneby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact rbtt_contact_orb_machine_StartUpdoneby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_StartUpdoneby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_StartUpdoneby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_contact_orb_machine_StartUpdoneby", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_StartUpdoneby");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_orb_machine_Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_country")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_orb_machine_Country")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_orb_machine_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_orb_machine_Country", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_orb_machine_Country");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_orb_machine_Country", null, value);
                this.OnPropertyChanged("rbtt_orb_country_orb_machine_Country");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_machine_orb_machine_Main
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_mainasset")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_machine_orb_machine_Main", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine Referencingrbtt_orb_machine_orb_machine_Main
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_orb_machine_orb_machine_Main", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingrbtt_orb_machine_orb_machine_Main");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_orb_machine_orb_machine_Main", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingrbtt_orb_machine_orb_machine_Main");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_appliance_orb_machine_serialnumber
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_serialnumber")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_appliance_orb_machine_serialnumber")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance rbtt_rbtt_appliance_orb_machine_serialnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_orb_machine_serialnumber", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_appliance_orb_machine_serialnumber");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_orb_machine_serialnumber", null, value);
                this.OnPropertyChanged("rbtt_rbtt_appliance_orb_machine_serialnumber");
            }
        }

        /// <summary>
        /// N:1 user_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orb_machine")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_orb_machine");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_orb_machine", null, value);
                this.OnPropertyChanged("user_orb_machine");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Orb_machine(object anonymousType) :
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
                        Attributes["orb_machineid"] = base.Id;
                        break;
                    case "orb_machineid":
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