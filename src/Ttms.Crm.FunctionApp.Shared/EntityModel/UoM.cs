namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    /// <summary>
    /// Unit of measure.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uom")]
    public partial class UoM : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string BaseUoM = "baseuom";
            public const string CreatedBy = "createdby";
            public const string CreatedByExternalParty = "createdbyexternalparty";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IsScheduleBaseUoM = "isschedulebaseuom";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByExternalParty = "modifiedbyexternalparty";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Name = "name";
            public const string OrganizationId = "organizationid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string Quantity = "quantity";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string UoMId = "uomid";
            public const string Id = "uomid";
            public const string UoMScheduleId = "uomscheduleid";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string lk_uom_createdonbehalfby = "lk_uom_createdonbehalfby";
            public const string lk_uom_modifiedonbehalfby = "lk_uom_modifiedonbehalfby";
            public const string lk_uombase_createdby = "lk_uombase_createdby";
            public const string lk_uombase_modifiedby = "lk_uombase_modifiedby";
            public const string unit_of_measure_schedule_conversions = "unit_of_measure_schedule_conversions";
            public const string Referencingunit_of_measurement_base_unit = "unit_of_measurement_base_unit";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public UoM() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "uom";

        public const string EntitySchemaName = "UoM";

        public const string PrimaryIdAttribute = "uomid";

        public const string PrimaryNameAttribute = "name";

        public const string EntityLogicalCollectionName = "uoms";

        public const string EntitySetName = "uoms";

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
        /// unit_of_measurement_base_unit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuom")]
        public Microsoft.Xrm.Sdk.EntityReference BaseUoM
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("baseuom");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BaseUoM");
                this.SetAttributeValue("baseuom", value);
                this.OnPropertyChanged("BaseUoM");
            }
        }

        /// <summary>
        /// lk_uombase_createdby
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
        /// Shows the external party who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
            }
        }

        /// <summary>
        /// Date and time when the unit was created.
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
        /// lk_uombase_createdonbehalfby
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
        /// Tells whether the unit is the base unit for the associated unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isschedulebaseuom")]
        public System.Nullable<bool> IsScheduleBaseUoM
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isschedulebaseuom");
            }
        }

        /// <summary>
        /// lk_uombase_modifiedby
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
        /// Shows the external party who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
            }
        }

        /// <summary>
        /// Date and time when the unit was last modified.
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
        /// lk_uombase_modifiedonbehalfby
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
        /// Type a descriptive title or name for the unit of measure.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the unit of measure.
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
        /// Unit quantity for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantity")]
        public System.Nullable<decimal> Quantity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("quantity");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Quantity");
                this.SetAttributeValue("quantity", value);
                this.OnPropertyChanged("Quantity");
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
        /// Unique identifier of the unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        public System.Nullable<System.Guid> UoMId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("uomid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UoMId");
                this.SetAttributeValue("uomid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UoMId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
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
                this.UoMId = value;
            }
        }

        /// <summary>
        /// unit_of_measure_schedule_conversions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        public Microsoft.Xrm.Sdk.EntityReference UoMScheduleId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomscheduleid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UoMScheduleId");
                this.SetAttributeValue("uomscheduleid", value);
                this.OnPropertyChanged("UoMScheduleId");
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
        /// Version number of the unit.
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
        /// 1:N unit_of_measurement_base_unit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM> Referencedunit_of_measurement_base_unit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedunit_of_measurement_base_unit");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedunit_of_measurement_base_unit");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_products")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> unit_of_measurement_products
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("unit_of_measurement_products", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("unit_of_measurement_products");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("unit_of_measurement_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_products");
            }
        }

        /// <summary>
        /// N:1 lk_uom_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uom_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uom_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uom_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uom_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_uom_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uom_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uom_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uom_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uom_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_uombase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uombase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uombase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uombase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uombase_createdby", null, value);
                this.OnPropertyChanged("lk_uombase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_uombase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_uombase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uombase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_uombase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_uombase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uombase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 unit_of_measure_schedule_conversions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_conversions")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule unit_of_measure_schedule_conversions
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("unit_of_measure_schedule_conversions", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("unit_of_measure_schedule_conversions");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("unit_of_measure_schedule_conversions", null, value);
                this.OnPropertyChanged("unit_of_measure_schedule_conversions");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_base_unit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuom")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.UoM Referencingunit_of_measurement_base_unit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingunit_of_measurement_base_unit");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingunit_of_measurement_base_unit");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public UoM(object anonymousType) :
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
                        Attributes["uomid"] = base.Id;
                        break;
                    case "uomid":
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