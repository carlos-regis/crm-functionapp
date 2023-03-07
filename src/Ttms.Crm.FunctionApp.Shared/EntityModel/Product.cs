namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ProductState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Draft = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnderRevision = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Information about products and their pricing information.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("product")]
    public partial class Product : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string Btt_IsCriticalProduct = "btt_iscriticalproduct";
            public const string CreatedBy = "createdby";
            public const string CreatedByExternalParty = "createdbyexternalparty";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CurrentCost = "currentcost";
            public const string CurrentCost_Base = "currentcost_base";
            public const string DefaultUoMId = "defaultuomid";
            public const string DefaultUoMScheduleId = "defaultuomscheduleid";
            public const string Description = "description";
            public const string DMTImportState = "dmtimportstate";
            public const string EntityImage = "entityimage";
            public const string EntityImage_Timestamp = "entityimage_timestamp";
            public const string EntityImage_URL = "entityimage_url";
            public const string EntityImageId = "entityimageid";
            public const string ExchangeRate = "exchangerate";
            public const string HierarchyPath = "hierarchypath";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IsKit = "iskit";
            public const string IsReparented = "isreparented";
            public const string IsStockItem = "isstockitem";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByExternalParty = "modifiedbyexternalparty";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Name = "name";
            public const string Orb_client = "orb_client";
            public const string Orb_customizable = "orb_customizable";
            public const string Orb_deletemarker = "orb_deletemarker";
            public const string Orb_ean = "orb_ean";
            public const string orb_producttyp = "orb_producttyp";
            public const string Orb_ProductTypecode = "orb_producttypecode";
            public const string Orb_sap_partnernumber = "orb_sap_partnernumber";
            public const string Orb_volume = "orb_volume";
            public const string OrganizationId = "organizationid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string ParentProductId = "parentproductid";
            public const string Price = "price";
            public const string Price_Base = "price_base";
            public const string PriceLevelId = "pricelevelid";
            public const string ProcessId = "processid";
            public const string ProductId = "productid";
            public const string Id = "productid";
            public const string ProductNumber = "productnumber";
            public const string ProductStructure = "productstructure";
            public const string ProductTypeCode = "producttypecode";
            public const string ProductUrl = "producturl";
            public const string QuantityDecimal = "quantitydecimal";
            public const string QuantityOnHand = "quantityonhand";
            public const string Size = "size";
            public const string StageId = "stageid";
            public const string StandardCost = "standardcost";
            public const string StandardCost_Base = "standardcost_base";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string StockVolume = "stockvolume";
            public const string StockWeight = "stockweight";
            public const string SubjectId = "subjectid";
            public const string SupplierName = "suppliername";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string ValidFromDate = "validfromdate";
            public const string ValidToDate = "validtodate";
            public const string VendorID = "vendorid";
            public const string VendorName = "vendorname";
            public const string VendorPartNumber = "vendorpartnumber";
            public const string VersionNumber = "versionnumber";
            public const string lk_product_createdonbehalfby = "lk_product_createdonbehalfby";
            public const string lk_product_modifiedonbehalfby = "lk_product_modifiedonbehalfby";
            public const string lk_productbase_createdby = "lk_productbase_createdby";
            public const string lk_productbase_modifiedby = "lk_productbase_modifiedby";
            public const string orb_orb_productgroup_product = "orb_orb_productgroup_product";
            public const string Referencingproduct_parent_product = "product_parent_product";
            public const string unit_of_measurement_products = "unit_of_measurement_products";
            public const string unit_of_measurement_schedule_products = "unit_of_measurement_schedule_products";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Product() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "product";

        public const string EntitySchemaName = "Product";

        public const string PrimaryIdAttribute = "productid";

        public const string PrimaryNameAttribute = "name";

        public const string EntityLogicalCollectionName = "products";

        public const string EntitySetName = "products";

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
        /// Flag. True when a product has been declared critical in terms of warranty. Rule set by local CRM organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_iscriticalproduct")]
        public System.Nullable<bool> Btt_IsCriticalProduct
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_iscriticalproduct");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_IsCriticalProduct");
                this.SetAttributeValue("btt_iscriticalproduct", value);
                this.OnPropertyChanged("Btt_IsCriticalProduct");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the product.
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
        /// Date and time when the product was created.
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
        /// Unique identifier of the delegate user who created the product.
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
        /// Current cost for the product item. Used in price calculations.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcost")]
        public Microsoft.Xrm.Sdk.Money CurrentCost
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("currentcost");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CurrentCost");
                this.SetAttributeValue("currentcost", value);
                this.OnPropertyChanged("CurrentCost");
            }
        }

        /// <summary>
        /// Base currency equivalent of the current cost for the product item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcost_base")]
        public Microsoft.Xrm.Sdk.Money CurrentCost_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("currentcost_base");
            }
        }

        /// <summary>
        /// Default unit for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultUoMId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultuomid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DefaultUoMId");
                this.SetAttributeValue("defaultuomid", value);
                this.OnPropertyChanged("DefaultUoMId");
            }
        }

        /// <summary>
        /// Default unit group for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomscheduleid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultUoMScheduleId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultuomscheduleid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DefaultUoMScheduleId");
                this.SetAttributeValue("defaultuomscheduleid", value);
                this.OnPropertyChanged("DefaultUoMScheduleId");
            }
        }

        /// <summary>
        /// Description of the product.
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
        /// Internal Use Only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dmtimportstate")]
        public System.Nullable<int> DMTImportState
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("dmtimportstate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DMTImportState");
                this.SetAttributeValue("dmtimportstate", value);
                this.OnPropertyChanged("DMTImportState");
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
        /// Exchange rate for the currency associated with the product with respect to the base currency.
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
        /// Hierarchy path of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchypath")]
        public string HierarchyPath
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("hierarchypath");
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
        /// Information that specifies whether the product is a kit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iskit")]
        public System.Nullable<bool> IsKit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("iskit");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsKit");
                this.SetAttributeValue("iskit", value);
                this.OnPropertyChanged("IsKit");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreparented")]
        public System.Nullable<bool> IsReparented
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isreparented");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsReparented");
                this.SetAttributeValue("isreparented", value);
                this.OnPropertyChanged("IsReparented");
            }
        }

        /// <summary>
        /// Information about whether the product is a stock item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isstockitem")]
        public System.Nullable<bool> IsStockItem
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isstockitem");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsStockItem");
                this.SetAttributeValue("isstockitem", value);
                this.OnPropertyChanged("IsStockItem");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the product.
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
        /// Date and time when the product was last modified.
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
        /// Unique identifier of the delegate user who last modified the product.
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
        /// Name of the product.
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
        /// SAP system client
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_client")]
        public string Orb_client
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_client");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_client");
                this.SetAttributeValue("orb_client", value);
                this.OnPropertyChanged("Orb_client");
            }
        }

        /// <summary>
        /// Customizable
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_customizable")]
        public System.Nullable<bool> Orb_customizable
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_customizable");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_customizable");
                this.SetAttributeValue("orb_customizable", value);
                this.OnPropertyChanged("Orb_customizable");
            }
        }

        /// <summary>
        /// The deletemarker
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_deletemarker")]
        public System.Nullable<bool> Orb_deletemarker
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_deletemarker");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_deletemarker");
                this.SetAttributeValue("orb_deletemarker", value);
                this.OnPropertyChanged("Orb_deletemarker");
            }
        }

        /// <summary>
        /// EAN
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_ean")]
        public string Orb_ean
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_ean");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_ean");
                this.SetAttributeValue("orb_ean", value);
                this.OnPropertyChanged("Orb_ean");
            }
        }

        /// <summary>
        /// Unique identifier for Product Group associated with Product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_producttyp")]
        public Microsoft.Xrm.Sdk.EntityReference orb_producttyp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_producttyp");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_producttyp");
                this.SetAttributeValue("orb_producttyp", value);
                this.OnPropertyChanged("orb_producttyp");
            }
        }

        /// <summary>
        /// Incentive
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_producttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Orb_ProductTypecode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("orb_producttypecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_ProductTypecode");
                this.SetAttributeValue("orb_producttypecode", value);
                this.OnPropertyChanged("Orb_ProductTypecode");
            }
        }

        /// <summary>
        /// Incentive
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_producttypecode")]
        public virtual Product_Orb_ProductTypecode? Orb_ProductTypecodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Product_Orb_ProductTypecode?)(EntityOptionSetEnum.GetEnum(this, "orb_producttypecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_ProductTypecode");
                this.SetAttributeValue("orb_producttypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Orb_ProductTypecode");
            }
        }

        /// <summary>
        /// SAP partner number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_sap_partnernumber")]
        public string Orb_sap_partnernumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_sap_partnernumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_sap_partnernumber");
                this.SetAttributeValue("orb_sap_partnernumber", value);
                this.OnPropertyChanged("Orb_sap_partnernumber");
            }
        }

        /// <summary>
        /// The product volume
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_volume")]
        public System.Nullable<double> Orb_volume
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_volume");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_volume");
                this.SetAttributeValue("orb_volume", value);
                this.OnPropertyChanged("Orb_volume");
            }
        }

        /// <summary>
        /// organization_products
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
        /// Specifies the parent product family hierarchy.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentproductid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentProductId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentproductid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentProductId");
                this.SetAttributeValue("parentproductid", value);
                this.OnPropertyChanged("ParentProductId");
            }
        }

        /// <summary>
        /// List price of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price")]
        public Microsoft.Xrm.Sdk.Money Price
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Price");
                this.SetAttributeValue("price", value);
                this.OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Base currency equivalent of the list price of the product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price_base")]
        public Microsoft.Xrm.Sdk.Money Price_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price_base");
            }
        }

        /// <summary>
        /// Select the default price list for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PriceLevelId");
                this.SetAttributeValue("pricelevelid", value);
                this.OnPropertyChanged("PriceLevelId");
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
        /// Unique identifier of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        public System.Nullable<System.Guid> ProductId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("productid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProductId");
                this.SetAttributeValue("productid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProductId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
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
                this.ProductId = value;
            }
        }

        /// <summary>
        /// User-defined product ID.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productnumber")]
        public string ProductNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("productnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProductNumber");
                this.SetAttributeValue("productnumber", value);
                this.OnPropertyChanged("ProductNumber");
            }
        }

        /// <summary>
        /// Product Structure.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productstructure")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProductStructure
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("productstructure");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProductStructure");
                this.SetAttributeValue("productstructure", value);
                this.OnPropertyChanged("ProductStructure");
            }
        }

        /// <summary>
        /// Product Structure.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productstructure")]
        public virtual Product_ProductStructure? ProductStructureEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Product_ProductStructure?)(EntityOptionSetEnum.GetEnum(this, "productstructure")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProductStructure");
                this.SetAttributeValue("productstructure", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("ProductStructure");
            }
        }

        /// <summary>
        /// Type of product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProductTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("producttypecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProductTypeCode");
                this.SetAttributeValue("producttypecode", value);
                this.OnPropertyChanged("ProductTypeCode");
            }
        }

        /// <summary>
        /// Type of product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producttypecode")]
        public virtual Product_ProductTypeCode? ProductTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Product_ProductTypeCode?)(EntityOptionSetEnum.GetEnum(this, "producttypecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProductTypeCode");
                this.SetAttributeValue("producttypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("ProductTypeCode");
            }
        }

        /// <summary>
        /// URL for the Website associated with the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producturl")]
        public string ProductUrl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("producturl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProductUrl");
                this.SetAttributeValue("producturl", value);
                this.OnPropertyChanged("ProductUrl");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used in monetary amounts for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitydecimal")]
        public System.Nullable<int> QuantityDecimal
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("quantitydecimal");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QuantityDecimal");
                this.SetAttributeValue("quantitydecimal", value);
                this.OnPropertyChanged("QuantityDecimal");
            }
        }

        /// <summary>
        /// Quantity of the product in stock.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantityonhand")]
        public System.Nullable<decimal> QuantityOnHand
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("quantityonhand");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QuantityOnHand");
                this.SetAttributeValue("quantityonhand", value);
                this.OnPropertyChanged("QuantityOnHand");
            }
        }

        /// <summary>
        /// Product size.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("size")]
        public string Size
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("size");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Size");
                this.SetAttributeValue("size", value);
                this.OnPropertyChanged("Size");
            }
        }

        /// <summary>
        /// processstage_products
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
        /// Standard cost of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardcost")]
        public Microsoft.Xrm.Sdk.Money StandardCost
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("standardcost");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StandardCost");
                this.SetAttributeValue("standardcost", value);
                this.OnPropertyChanged("StandardCost");
            }
        }

        /// <summary>
        /// Base currency equivalent of the standard cost of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardcost_base")]
        public Microsoft.Xrm.Sdk.Money StandardCost_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("standardcost_base");
            }
        }

        /// <summary>
        /// Status of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.ProductState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.ProductState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.ProductState), optionSet.Value)));
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
        /// Reason for the status of the product.
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
        /// Reason for the status of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Product_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Product_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// Stock volume of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockvolume")]
        public System.Nullable<decimal> StockVolume
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("stockvolume");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StockVolume");
                this.SetAttributeValue("stockvolume", value);
                this.OnPropertyChanged("StockVolume");
            }
        }

        /// <summary>
        /// Stock weight of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockweight")]
        public System.Nullable<decimal> StockWeight
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("stockweight");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StockWeight");
                this.SetAttributeValue("stockweight", value);
                this.OnPropertyChanged("StockWeight");
            }
        }

        /// <summary>
        /// Select a category for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        public Microsoft.Xrm.Sdk.EntityReference SubjectId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("subjectid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SubjectId");
                this.SetAttributeValue("subjectid", value);
                this.OnPropertyChanged("SubjectId");
            }
        }

        /// <summary>
        /// Name of the product's supplier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suppliername")]
        public string SupplierName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("suppliername");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SupplierName");
                this.SetAttributeValue("suppliername", value);
                this.OnPropertyChanged("SupplierName");
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
        /// Unique identifier of the currency associated with the product.
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
        /// Date from which this product is valid.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validfromdate")]
        public System.Nullable<System.DateTime> ValidFromDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("validfromdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ValidFromDate");
                this.SetAttributeValue("validfromdate", value);
                this.OnPropertyChanged("ValidFromDate");
            }
        }

        /// <summary>
        /// Date to which this product is valid.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validtodate")]
        public System.Nullable<System.DateTime> ValidToDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("validtodate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ValidToDate");
                this.SetAttributeValue("validtodate", value);
                this.OnPropertyChanged("ValidToDate");
            }
        }

        /// <summary>
        /// Unique identifier of vendor supplying the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorid")]
        public string VendorID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("vendorid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("VendorID");
                this.SetAttributeValue("vendorid", value);
                this.OnPropertyChanged("VendorID");
            }
        }

        /// <summary>
        /// Name of the product vendor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorname")]
        public string VendorName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("vendorname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("VendorName");
                this.SetAttributeValue("vendorname", value);
                this.OnPropertyChanged("VendorName");
            }
        }

        /// <summary>
        /// Unique part identifier in vendor catalog of this product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorpartnumber")]
        public string VendorPartNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("vendorpartnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("VendorPartNumber");
                this.SetAttributeValue("vendorpartnumber", value);
                this.OnPropertyChanged("VendorPartNumber");
            }
        }

        /// <summary>
        /// Version number of the product.
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
        /// 1:N btt_product_btt_gratuity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_product_btt_gratuity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> btt_product_btt_gratuity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("btt_product_btt_gratuity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_product_btt_gratuity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("btt_product_btt_gratuity", null, value);
                this.OnPropertyChanged("btt_product_btt_gratuity");
            }
        }

        /// <summary>
        /// 1:N product_parent_product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Product> Referencedproduct_parent_product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedproduct_parent_product");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedproduct_parent_product");
            }
        }

        /// <summary>
        /// 1:N rbtt_product_rbtt_appliance_Product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_product_rbtt_appliance_Product")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance> rbtt_product_rbtt_appliance_Product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_product_rbtt_appliance_Product", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_product_rbtt_appliance_Product");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_appliance>("rbtt_product_rbtt_appliance_Product", null, value);
                this.OnPropertyChanged("rbtt_product_rbtt_appliance_Product");
            }
        }

        /// <summary>
        /// 1:N rbtt_product_rbtt_delivernoteitem_Product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_product_rbtt_delivernoteitem_Product")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem> rbtt_product_rbtt_delivernoteitem_Product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("rbtt_product_rbtt_delivernoteitem_Product", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_product_rbtt_delivernoteitem_Product");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernoteitem>("rbtt_product_rbtt_delivernoteitem_Product", null, value);
                this.OnPropertyChanged("rbtt_product_rbtt_delivernoteitem_Product");
            }
        }

        /// <summary>
        /// N:1 lk_product_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_product_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_product_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_product_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_product_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_product_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_product_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_product_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_product_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_product_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_productbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_productbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_productbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_productbase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_productbase_createdby", null, value);
                this.OnPropertyChanged("lk_productbase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_productbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_productbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_productbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_productbase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_productbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_productbase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 orb_orb_productgroup_product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_producttyp")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_productgroup_product")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup orb_orb_productgroup_product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("orb_orb_productgroup_product", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_productgroup_product");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("orb_orb_productgroup_product", null, value);
                this.OnPropertyChanged("orb_orb_productgroup_product");
            }
        }

        /// <summary>
        /// N:1 product_parent_product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentproductid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Product Referencingproduct_parent_product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingproduct_parent_product");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingproduct_parent_product");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_products")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.UoM unit_of_measurement_products
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measurement_products", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("unit_of_measurement_products");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoM>("unit_of_measurement_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_products");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_schedule_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomscheduleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_schedule_products")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule unit_of_measurement_schedule_products
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("unit_of_measurement_schedule_products", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("unit_of_measurement_schedule_products");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.UoMSchedule>("unit_of_measurement_schedule_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_schedule_products");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Product(object anonymousType) :
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
                        Attributes["productid"] = base.Id;
                        break;
                    case "productid":
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