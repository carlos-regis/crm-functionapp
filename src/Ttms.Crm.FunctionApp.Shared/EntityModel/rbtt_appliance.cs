namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_applianceState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Use it to store appliances (serial numbers) coming from the LogInformation-ability interface or even coming from the Partner Program interface
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("rbtt_appliance")]
    public partial class rbtt_appliance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
            public const string rbtt_applianceId = "rbtt_applianceid";
            public const string Id = "rbtt_applianceid";
            public const string rbtt_Brand = "rbtt_brand";
            public const string rbtt_Componentfor = "rbtt_componentfor";
            public const string rbtt_FakeSNSAP = "rbtt_fakesnsap";
            public const string rbtt_ManufacturingDate = "rbtt_manufacturingdate";
            public const string rbtt_Product = "rbtt_product";
            public const string rbtt_ProductionCounter = "rbtt_productioncounter";
            public const string rbtt_ProductionPlant = "rbtt_productionplant";
            public const string rbtt_PTTEquipmentID = "rbtt_pttequipmentid";
            public const string rbtt_RawSerialNumber = "rbtt_rawserialnumber";
            public const string rbtt_serialnumber = "rbtt_serialnumber";
            public const string rbtt_Systemof = "rbtt_systemof";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_rbtt_appliance_createdby = "lk_rbtt_appliance_createdby";
            public const string lk_rbtt_appliance_createdonbehalfby = "lk_rbtt_appliance_createdonbehalfby";
            public const string lk_rbtt_appliance_modifiedby = "lk_rbtt_appliance_modifiedby";
            public const string lk_rbtt_appliance_modifiedonbehalfby = "lk_rbtt_appliance_modifiedonbehalfby";
            public const string rbtt_product_rbtt_appliance_Product = "rbtt_product_rbtt_appliance_Product";
            public const string Referencingrbtt_rbtt_appliance_rbtt_appliance_Componentfor = "rbtt_rbtt_appliance_rbtt_appliance_Componentfor";
            public const string Referencingrbtt_rbtt_appliance_rbtt_appliance_Systemof = "rbtt_rbtt_appliance_rbtt_appliance_Systemof";
            public const string rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant = "rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_appliance() :
                base(EntityLogicalName)
        {
        }

        public const string AlternateKeys = "rbtt_serialnumber";

        public const string EntityLogicalName = "rbtt_appliance";

        public const string EntitySchemaName = "rbtt_appliance";

        public const string PrimaryIdAttribute = "rbtt_applianceid";

        public const string PrimaryNameAttribute = "rbtt_serialnumber";

        public const string EntityLogicalCollectionName = "rbtt_appliances";

        public const string EntitySetName = "rbtt_appliances";

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
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_applianceid")]
        public System.Nullable<System.Guid> rbtt_applianceId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("rbtt_applianceid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_applianceId");
                this.SetAttributeValue("rbtt_applianceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("rbtt_applianceId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_applianceid")]
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
                this.rbtt_applianceId = value;
            }
        }

        /// <summary>
        /// Identify the brand of the appliance
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
        /// Identify the brand of the appliance
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
        /// Identify when the appliance is a component for other appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_componentfor")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Componentfor
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_componentfor");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Componentfor");
                this.SetAttributeValue("rbtt_componentfor", value);
                this.OnPropertyChanged("rbtt_Componentfor");
            }
        }

        /// <summary>
        /// This field stores the S/N, which is generated by SAP but not representing this S/N printed on the label. It could be used to build the Link between a "virtual" S/N and the real S/N on the appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_fakesnsap")]
        public string rbtt_FakeSNSAP
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_fakesnsap");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_FakeSNSAP");
                this.SetAttributeValue("rbtt_fakesnsap", value);
                this.OnPropertyChanged("rbtt_FakeSNSAP");
            }
        }

        /// <summary>
        /// Identify the manufacture date of the appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_manufacturingdate")]
        public System.Nullable<System.DateTime> rbtt_ManufacturingDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_manufacturingdate");
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
        /// Identify the appliance product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_product")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_product");
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
        /// Production Counter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_productioncounter")]
        public string rbtt_ProductionCounter
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_productioncounter");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProductionCounter");
                this.SetAttributeValue("rbtt_productioncounter", value);
                this.OnPropertyChanged("rbtt_ProductionCounter");
            }
        }

        /// <summary>
        /// Identify where the appliance was manufactured
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_productionplant")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_ProductionPlant
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_productionplant");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ProductionPlant");
                this.SetAttributeValue("rbtt_productionplant", value);
                this.OnPropertyChanged("rbtt_ProductionPlant");
            }
        }

        /// <summary>
        /// SAP equipment represents a physical object which can be independently maintained in the industry
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_pttequipmentid")]
        public string rbtt_PTTEquipmentID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_pttequipmentid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PTTEquipmentID");
                this.SetAttributeValue("rbtt_pttequipmentid", value);
                this.OnPropertyChanged("rbtt_PTTEquipmentID");
            }
        }

        /// <summary>
        /// Identify the Raw Serial Number of the Appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_rawserialnumber")]
        public string rbtt_RawSerialNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_rawserialnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RawSerialNumber");
                this.SetAttributeValue("rbtt_rawserialnumber", value);
                this.OnPropertyChanged("rbtt_RawSerialNumber");
            }
        }

        /// <summary>
        /// The serial number of the appliance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_serialnumber")]
        public string rbtt_serialnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_serialnumber");
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
        /// Identify when the appliance is part of another system
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_systemof")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Systemof
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_systemof");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Systemof");
                this.SetAttributeValue("rbtt_systemof", value);
                this.OnPropertyChanged("rbtt_Systemof");
            }
        }

        /// <summary>
        /// Status of the Appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applianceState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applianceState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_applianceState), optionSet.Value)));
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
        /// Reason for the status of the Appliance
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
        /// Reason for the status of the Appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual rbtt_appliance_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_appliance_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// 1:N rbtt_appliance_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_appliance_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> rbtt_appliance_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_appliance_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_appliance_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("rbtt_appliance_Appointments", null, value);
                this.OnPropertyChanged("rbtt_appliance_Appointments");
            }
        }

        /// <summary>
        /// 1:N rbtt_appliance_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_appliance_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> rbtt_appliance_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_appliance_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_appliance_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("rbtt_appliance_Emails", null, value);
                this.OnPropertyChanged("rbtt_appliance_Emails");
            }
        }

        /// <summary>
        /// 1:N rbtt_appliance_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_appliance_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> rbtt_appliance_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_appliance_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_appliance_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("rbtt_appliance_Tasks", null, value);
                this.OnPropertyChanged("rbtt_appliance_Tasks");
            }
        }

        /// <summary>
        /// 1:N rbtt_rbtt_appliance_orb_machine_serialnumber
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_appliance_orb_machine_serialnumber")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_rbtt_appliance_orb_machine_serialnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_rbtt_appliance_orb_machine_serialnumber", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_appliance_orb_machine_serialnumber");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_rbtt_appliance_orb_machine_serialnumber", null, value);
                this.OnPropertyChanged("rbtt_rbtt_appliance_orb_machine_serialnumber");
            }
        }

        /// <summary>
        /// 1:N rbtt_rbtt_appliance_rbtt_appliance_Componentfor
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_appliance_rbtt_appliance_Componentfor", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance> Referencedrbtt_rbtt_appliance_rbtt_appliance_Componentfor
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Componentfor", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedrbtt_rbtt_appliance_rbtt_appliance_Componentfor");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Componentfor", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedrbtt_rbtt_appliance_rbtt_appliance_Componentfor");
            }
        }

        /// <summary>
        /// 1:N rbtt_rbtt_appliance_rbtt_appliance_Systemof
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_appliance_rbtt_appliance_Systemof", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance> Referencedrbtt_rbtt_appliance_rbtt_appliance_Systemof
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Systemof", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedrbtt_rbtt_appliance_rbtt_appliance_Systemof");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Systemof", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedrbtt_rbtt_appliance_rbtt_appliance_Systemof");
            }
        }

        /// <summary>
        /// 1:N rbtt_rbtt_appliance_rbtt_delivernoteitem_Appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_appliance_rbtt_delivernoteitem_Appliance")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem> rbtt_rbtt_appliance_rbtt_delivernoteitem_Appliance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("rbtt_rbtt_appliance_rbtt_delivernoteitem_Appliance", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_appliance_rbtt_delivernoteitem_Appliance");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("rbtt_rbtt_appliance_rbtt_delivernoteitem_Appliance", null, value);
                this.OnPropertyChanged("rbtt_rbtt_appliance_rbtt_delivernoteitem_Appliance");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_appliance_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_appliance_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_createdby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_appliance_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_appliance_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_appliance_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_appliance_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_modifiedby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_rbtt_appliance_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rbtt_appliance_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_rbtt_appliance_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_rbtt_appliance_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_rbtt_appliance_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rbtt_appliance_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 rbtt_product_rbtt_appliance_Product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_product")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_product_rbtt_appliance_Product")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Product rbtt_product_rbtt_appliance_Product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("rbtt_product_rbtt_appliance_Product", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_product_rbtt_appliance_Product");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("rbtt_product_rbtt_appliance_Product", null, value);
                this.OnPropertyChanged("rbtt_product_rbtt_appliance_Product");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_appliance_rbtt_appliance_Componentfor
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_componentfor")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_appliance_rbtt_appliance_Componentfor", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance Referencingrbtt_rbtt_appliance_rbtt_appliance_Componentfor
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Componentfor", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingrbtt_rbtt_appliance_rbtt_appliance_Componentfor");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Componentfor", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingrbtt_rbtt_appliance_rbtt_appliance_Componentfor");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_appliance_rbtt_appliance_Systemof
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_systemof")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_appliance_rbtt_appliance_Systemof", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance Referencingrbtt_rbtt_appliance_rbtt_appliance_Systemof
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Systemof", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingrbtt_rbtt_appliance_rbtt_appliance_Systemof");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_rbtt_appliance_rbtt_appliance_Systemof", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingrbtt_rbtt_appliance_rbtt_appliance_Systemof");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_productionplant")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant", null, value);
                this.OnPropertyChanged("rbtt_rbtt_productionplants_rbtt_appliance_ProductionPlant");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public rbtt_appliance(object anonymousType) :
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
                        Attributes["rbtt_applianceid"] = base.Id;
                        break;
                    case "rbtt_applianceid":
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