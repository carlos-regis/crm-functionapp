namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum QuoteState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Draft = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Won = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Closed = 3,
    }

    /// <summary>
    /// Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("quote")]
    public partial class Quote : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string AccountId = "accountid";
            public const string BillTo_AddressId = "billto_addressid";
            public const string BillTo_City = "billto_city";
            public const string BillTo_Composite = "billto_composite";
            public const string BillTo_ContactName = "billto_contactname";
            public const string BillTo_Country = "billto_country";
            public const string BillTo_Fax = "billto_fax";
            public const string BillTo_Line1 = "billto_line1";
            public const string BillTo_Line2 = "billto_line2";
            public const string BillTo_Line3 = "billto_line3";
            public const string BillTo_Name = "billto_name";
            public const string BillTo_PostalCode = "billto_postalcode";
            public const string BillTo_StateOrProvince = "billto_stateorprovince";
            public const string BillTo_Telephone = "billto_telephone";
            public const string CampaignId = "campaignid";
            public const string ClosedOn = "closedon";
            public const string ContactId = "contactid";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CustomerId = "customerid";
            public const string Description = "description";
            public const string DiscountAmount = "discountamount";
            public const string DiscountAmount_Base = "discountamount_base";
            public const string DiscountPercentage = "discountpercentage";
            public const string EffectiveFrom = "effectivefrom";
            public const string EffectiveTo = "effectiveto";
            public const string EmailAddress = "emailaddress";
            public const string ExchangeRate = "exchangerate";
            public const string ExpiresOn = "expireson";
            public const string FreightAmount = "freightamount";
            public const string FreightAmount_Base = "freightamount_base";
            public const string FreightTermsCode = "freighttermscode";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Name = "name";
            public const string OnHoldTime = "onholdtime";
            public const string OpportunityId = "opportunityid";
            public const string Orb_client = "orb_client";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string PaymentTermsCode = "paymenttermscode";
            public const string PriceLevelId = "pricelevelid";
            public const string PricingErrorCode = "pricingerrorcode";
            public const string ProcessId = "processid";
            public const string QuoteId = "quoteid";
            public const string Id = "quoteid";
            public const string QuoteNumber = "quotenumber";
            public const string rbtt_WorkON_Link = "rbtt_workon_link";
            public const string rbtt_WorkON_Number = "rbtt_workon_number";
            public const string RequestDeliveryBy = "requestdeliveryby";
            public const string RevisionNumber = "revisionnumber";
            public const string ShippingMethodCode = "shippingmethodcode";
            public const string ShipTo_AddressId = "shipto_addressid";
            public const string ShipTo_City = "shipto_city";
            public const string ShipTo_Composite = "shipto_composite";
            public const string ShipTo_ContactName = "shipto_contactname";
            public const string ShipTo_Country = "shipto_country";
            public const string ShipTo_Fax = "shipto_fax";
            public const string ShipTo_FreightTermsCode = "shipto_freighttermscode";
            public const string ShipTo_Line1 = "shipto_line1";
            public const string ShipTo_Line2 = "shipto_line2";
            public const string ShipTo_Line3 = "shipto_line3";
            public const string ShipTo_Name = "shipto_name";
            public const string ShipTo_PostalCode = "shipto_postalcode";
            public const string ShipTo_StateOrProvince = "shipto_stateorprovince";
            public const string ShipTo_Telephone = "shipto_telephone";
            public const string SkipPriceCalculation = "skippricecalculation";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TotalAmount = "totalamount";
            public const string TotalAmount_Base = "totalamount_base";
            public const string TotalAmountLessFreight = "totalamountlessfreight";
            public const string TotalAmountLessFreight_Base = "totalamountlessfreight_base";
            public const string TotalDiscountAmount = "totaldiscountamount";
            public const string TotalDiscountAmount_Base = "totaldiscountamount_base";
            public const string TotalLineItemAmount = "totallineitemamount";
            public const string TotalLineItemAmount_Base = "totallineitemamount_base";
            public const string TotalLineItemDiscountAmount = "totallineitemdiscountamount";
            public const string TotalLineItemDiscountAmount_Base = "totallineitemdiscountamount_base";
            public const string TotalTax = "totaltax";
            public const string TotalTax_Base = "totaltax_base";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string ttpoico_Dateonclaimoflackofdata = "ttpoico_dateonclaimoflackofdata";
            public const string ttpoico_ERPNumber = "ttpoico_erpnumber";
            public const string ttpoico_PG1 = "ttpoico_pg1";
            public const string ttpoico_PG2 = "ttpoico_pg2";
            public const string ttpoico_PG3 = "ttpoico_pg3";
            public const string ttpoico_Productmaingroup = "ttpoico_productmaingroup";
            public const string ttpoico_Receptionorderdate = "ttpoico_receptionorderdate";
            public const string ttpoico_Technologies = "ttpoico_technologies";
            public const string ttpoico_TotalAmount = "ttpoico_totalamount";
            public const string ttpoico_totalamount_Base = "ttpoico_totalamount_base";
            public const string ttpoico_Totalshippingdate = "ttpoico_totalshippingdate";
            public const string ttpoico_Type = "ttpoico_type";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string WillCall = "willcall";
            public const string lk_quote_createdonbehalfby = "lk_quote_createdonbehalfby";
            public const string lk_quote_modifiedonbehalfby = "lk_quote_modifiedonbehalfby";
            public const string lk_quotebase_createdby = "lk_quotebase_createdby";
            public const string lk_quotebase_modifiedby = "lk_quotebase_modifiedby";
            public const string opportunity_quotes = "opportunity_quotes";
            public const string quote_customer_accounts = "quote_customer_accounts";
            public const string quote_customer_contacts = "quote_customer_contacts";
            public const string system_user_quotes = "system_user_quotes";
            public const string ttpoico_orb_productgroup_quote_PG1 = "ttpoico_orb_productgroup_quote_PG1";
            public const string ttpoico_orb_productgroup_quote_PG2 = "ttpoico_orb_productgroup_quote_PG2";
            public const string ttpoico_orb_productgroup_quote_PG3 = "ttpoico_orb_productgroup_quote_PG3";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Quote() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "quote";

        public const string EntitySchemaName = "Quote";

        public const string PrimaryIdAttribute = "quoteid";

        public const string PrimaryNameAttribute = "name";

        public const string EntityLogicalCollectionName = "quotes";

        public const string EntitySetName = "quotes";

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
        /// Unique identifier of the account with which the quote is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid");
            }
        }

        /// <summary>
        /// Unique identifier of the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_addressid")]
        public System.Nullable<System.Guid> BillTo_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("billto_addressid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_AddressId");
                this.SetAttributeValue("billto_addressid", value);
                this.OnPropertyChanged("BillTo_AddressId");
            }
        }

        /// <summary>
        /// Type the city for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_city")]
        public string BillTo_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_City");
                this.SetAttributeValue("billto_city", value);
                this.OnPropertyChanged("BillTo_City");
            }
        }

        /// <summary>
        /// Shows the complete Bill To address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_composite")]
        public string BillTo_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_composite");
            }
        }

        /// <summary>
        /// Type the primary contact name at the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_contactname")]
        public string BillTo_ContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_contactname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_ContactName");
                this.SetAttributeValue("billto_contactname", value);
                this.OnPropertyChanged("BillTo_ContactName");
            }
        }

        /// <summary>
        /// Type the country or region for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_country")]
        public string BillTo_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_Country");
                this.SetAttributeValue("billto_country", value);
                this.OnPropertyChanged("BillTo_Country");
            }
        }

        /// <summary>
        /// Type the fax number for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_fax")]
        public string BillTo_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_Fax");
                this.SetAttributeValue("billto_fax", value);
                this.OnPropertyChanged("BillTo_Fax");
            }
        }

        /// <summary>
        /// Type the first line of the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line1")]
        public string BillTo_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_line1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_Line1");
                this.SetAttributeValue("billto_line1", value);
                this.OnPropertyChanged("BillTo_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line2")]
        public string BillTo_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_line2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_Line2");
                this.SetAttributeValue("billto_line2", value);
                this.OnPropertyChanged("BillTo_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line3")]
        public string BillTo_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_line3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_Line3");
                this.SetAttributeValue("billto_line3", value);
                this.OnPropertyChanged("BillTo_Line3");
            }
        }

        /// <summary>
        /// Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_name")]
        public string BillTo_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_Name");
                this.SetAttributeValue("billto_name", value);
                this.OnPropertyChanged("BillTo_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_postalcode")]
        public string BillTo_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_PostalCode");
                this.SetAttributeValue("billto_postalcode", value);
                this.OnPropertyChanged("BillTo_PostalCode");
            }
        }

        /// <summary>
        /// Type the state or province for the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_stateorprovince")]
        public string BillTo_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_stateorprovince");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_StateOrProvince");
                this.SetAttributeValue("billto_stateorprovince", value);
                this.OnPropertyChanged("BillTo_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the phone number for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_telephone")]
        public string BillTo_Telephone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("billto_telephone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BillTo_Telephone");
                this.SetAttributeValue("billto_telephone", value);
                this.OnPropertyChanged("BillTo_Telephone");
            }
        }

        /// <summary>
        /// Shows the campaign that the order was created from.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                this.OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        /// Enter the date when the quote was closed to indicate the expiration, revision, or cancellation date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closedon")]
        public System.Nullable<System.DateTime> ClosedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("closedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ClosedOn");
                this.SetAttributeValue("closedon", value);
                this.OnPropertyChanged("ClosedOn");
            }
        }

        /// <summary>
        /// Unique identifier of the contact associated with the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid");
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
        /// Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Type additional information to describe the quote, such as the products or services offered or details about the customer's product preferences.
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
        /// Type the discount amount for the quote if the customer is eligible for special savings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DiscountAmount");
                this.SetAttributeValue("discountamount", value);
                this.OnPropertyChanged("DiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount_base")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount_base");
            }
        }

        /// <summary>
        /// Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountpercentage")]
        public System.Nullable<decimal> DiscountPercentage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("discountpercentage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DiscountPercentage");
                this.SetAttributeValue("discountpercentage", value);
                this.OnPropertyChanged("DiscountPercentage");
            }
        }

        /// <summary>
        /// Enter the date when the quote pricing is effective or was first communicated to the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivefrom")]
        public System.Nullable<System.DateTime> EffectiveFrom
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectivefrom");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EffectiveFrom");
                this.SetAttributeValue("effectivefrom", value);
                this.OnPropertyChanged("EffectiveFrom");
            }
        }

        /// <summary>
        /// Enter the expiration date or last day the quote pricing is effective for the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveto")]
        public System.Nullable<System.DateTime> EffectiveTo
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveto");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EffectiveTo");
                this.SetAttributeValue("effectiveto", value);
                this.OnPropertyChanged("EffectiveTo");
            }
        }

        /// <summary>
        /// The primary email address for the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EmailAddress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("emailaddress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EmailAddress");
                this.SetAttributeValue("emailaddress", value);
                this.OnPropertyChanged("EmailAddress");
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
        /// Enter the date a decision or order is due from the customer to indicate the expiration date of the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expireson")]
        public System.Nullable<System.DateTime> ExpiresOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("expireson");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ExpiresOn");
                this.SetAttributeValue("expireson", value);
                this.OnPropertyChanged("ExpiresOn");
            }
        }

        /// <summary>
        /// Type the cost of freight or shipping for the products included in the quote for use in calculating the Total Amount field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount")]
        public Microsoft.Xrm.Sdk.Money FreightAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FreightAmount");
                this.SetAttributeValue("freightamount", value);
                this.OnPropertyChanged("FreightAmount");
            }
        }

        /// <summary>
        /// Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount_base")]
        public Microsoft.Xrm.Sdk.Money FreightAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount_base");
            }
        }

        /// <summary>
        /// Select the freight terms to make sure shipping charges are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FreightTermsCode");
                this.SetAttributeValue("freighttermscode", value);
                this.OnPropertyChanged("FreightTermsCode");
            }
        }

        /// <summary>
        /// Select the freight terms to make sure shipping charges are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
        public virtual Quote_FreightTermsCode? FreightTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Quote_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "freighttermscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FreightTermsCode");
                this.SetAttributeValue("freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("FreightTermsCode");
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
        /// Contains the date time stamp of the last on hold time.
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
        /// Type a descriptive name for the quote.
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
        /// Shows the duration in minutes for which the quote was on hold.
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
        /// Choose the opportunity that the quote is related to for reporting and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference OpportunityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("opportunityid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OpportunityId");
                this.SetAttributeValue("opportunityid", value);
                this.OnPropertyChanged("OpportunityId");
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
        /// business_unit_quotes
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
        /// team_quotes
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
        /// system_user_quotes
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
        /// Select the payment terms to indicate when the customer needs to pay the total amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PaymentTermsCode");
                this.SetAttributeValue("paymenttermscode", value);
                this.OnPropertyChanged("PaymentTermsCode");
            }
        }

        /// <summary>
        /// Select the payment terms to indicate when the customer needs to pay the total amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
        public virtual Quote_PaymentTermsCode? PaymentTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Quote_PaymentTermsCode?)(EntityOptionSetEnum.GetEnum(this, "paymenttermscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PaymentTermsCode");
                this.SetAttributeValue("paymenttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PaymentTermsCode");
            }
        }

        /// <summary>
        /// Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.
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
        /// Pricing error for the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PricingErrorCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingerrorcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PricingErrorCode");
                this.SetAttributeValue("pricingerrorcode", value);
                this.OnPropertyChanged("PricingErrorCode");
            }
        }

        /// <summary>
        /// Pricing error for the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
        public virtual Qooi_PricingErrorCode? PricingErrorCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Qooi_PricingErrorCode?)(EntityOptionSetEnum.GetEnum(this, "pricingerrorcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PricingErrorCode");
                this.SetAttributeValue("pricingerrorcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PricingErrorCode");
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
        /// Unique identifier of the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
        public System.Nullable<System.Guid> QuoteId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("quoteid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QuoteId");
                this.SetAttributeValue("quoteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("QuoteId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
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
                this.QuoteId = value;
            }
        }

        /// <summary>
        /// Shows the quote number for customer reference and searching capabilities. The number cannot be modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotenumber")]
        public string QuoteNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("quotenumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QuoteNumber");
                this.SetAttributeValue("quotenumber", value);
                this.OnPropertyChanged("QuoteNumber");
            }
        }

        /// <summary>
        /// Link to WorkON
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_workon_link")]
        public string rbtt_WorkON_Link
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_workon_link");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_WorkON_Link");
                this.SetAttributeValue("rbtt_workon_link", value);
                this.OnPropertyChanged("rbtt_WorkON_Link");
            }
        }

        /// <summary>
        /// Number of the WorkON
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_workon_number")]
        public string rbtt_WorkON_Number
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_workon_number");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_WorkON_Number");
                this.SetAttributeValue("rbtt_workon_number", value);
                this.OnPropertyChanged("rbtt_WorkON_Number");
            }
        }

        /// <summary>
        /// Enter the delivery date requested by the customer for all products in the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requestdeliveryby")]
        public System.Nullable<System.DateTime> RequestDeliveryBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("requestdeliveryby");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("RequestDeliveryBy");
                this.SetAttributeValue("requestdeliveryby", value);
                this.OnPropertyChanged("RequestDeliveryBy");
            }
        }

        /// <summary>
        /// Shows the version number of the quote for revision history tracking.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revisionnumber")]
        public System.Nullable<int> RevisionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("revisionnumber");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShippingMethodCode");
                this.SetAttributeValue("shippingmethodcode", value);
                this.OnPropertyChanged("ShippingMethodCode");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
        public virtual Quote_ShippingMethodCode? ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Quote_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShippingMethodCode");
                this.SetAttributeValue("shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("ShippingMethodCode");
            }
        }

        /// <summary>
        /// Unique identifier of the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_addressid")]
        public System.Nullable<System.Guid> ShipTo_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("shipto_addressid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_AddressId");
                this.SetAttributeValue("shipto_addressid", value);
                this.OnPropertyChanged("ShipTo_AddressId");
            }
        }

        /// <summary>
        /// Type the city for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_city")]
        public string ShipTo_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_City");
                this.SetAttributeValue("shipto_city", value);
                this.OnPropertyChanged("ShipTo_City");
            }
        }

        /// <summary>
        /// Shows the complete Ship To address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_composite")]
        public string ShipTo_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_composite");
            }
        }

        /// <summary>
        /// Type the primary contact name at the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_contactname")]
        public string ShipTo_ContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_contactname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_ContactName");
                this.SetAttributeValue("shipto_contactname", value);
                this.OnPropertyChanged("ShipTo_ContactName");
            }
        }

        /// <summary>
        /// Type the country or region for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_country")]
        public string ShipTo_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_Country");
                this.SetAttributeValue("shipto_country", value);
                this.OnPropertyChanged("ShipTo_Country");
            }
        }

        /// <summary>
        /// Type the fax number for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_fax")]
        public string ShipTo_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_Fax");
                this.SetAttributeValue("shipto_fax", value);
                this.OnPropertyChanged("ShipTo_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ShipTo_FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shipto_freighttermscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_FreightTermsCode");
                this.SetAttributeValue("shipto_freighttermscode", value);
                this.OnPropertyChanged("ShipTo_FreightTermsCode");
            }
        }

        /// <summary>
        /// Select the freight terms to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_freighttermscode")]
        public virtual Quote_ShipTo_FreightTermsCode? ShipTo_FreightTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Quote_ShipTo_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "shipto_freighttermscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_FreightTermsCode");
                this.SetAttributeValue("shipto_freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("ShipTo_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the first line of the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line1")]
        public string ShipTo_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_line1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_Line1");
                this.SetAttributeValue("shipto_line1", value);
                this.OnPropertyChanged("ShipTo_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line2")]
        public string ShipTo_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_line2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_Line2");
                this.SetAttributeValue("shipto_line2", value);
                this.OnPropertyChanged("ShipTo_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line3")]
        public string ShipTo_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_line3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_Line3");
                this.SetAttributeValue("shipto_line3", value);
                this.OnPropertyChanged("ShipTo_Line3");
            }
        }

        /// <summary>
        /// Type a name for the customer's shipping address, such as "Headquarters" or "Field office", to identify the address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_name")]
        public string ShipTo_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_Name");
                this.SetAttributeValue("shipto_name", value);
                this.OnPropertyChanged("ShipTo_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_postalcode")]
        public string ShipTo_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_PostalCode");
                this.SetAttributeValue("shipto_postalcode", value);
                this.OnPropertyChanged("ShipTo_PostalCode");
            }
        }

        /// <summary>
        /// Type the state or province for the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_stateorprovince")]
        public string ShipTo_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_stateorprovince");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_StateOrProvince");
                this.SetAttributeValue("shipto_stateorprovince", value);
                this.OnPropertyChanged("ShipTo_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the phone number for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_telephone")]
        public string ShipTo_Telephone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("shipto_telephone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ShipTo_Telephone");
                this.SetAttributeValue("shipto_telephone", value);
                this.OnPropertyChanged("ShipTo_Telephone");
            }
        }

        /// <summary>
        /// Skip Price Calculation (For Internal use)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skippricecalculation")]
        public Microsoft.Xrm.Sdk.OptionSetValue SkipPriceCalculation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("skippricecalculation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SkipPriceCalculation");
                this.SetAttributeValue("skippricecalculation", value);
                this.OnPropertyChanged("SkipPriceCalculation");
            }
        }

        /// <summary>
        /// Skip Price Calculation (For Internal use)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skippricecalculation")]
        public virtual qooi_skippricecalculation? SkipPriceCalculationEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((qooi_skippricecalculation?)(EntityOptionSetEnum.GetEnum(this, "skippricecalculation")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SkipPriceCalculation");
                this.SetAttributeValue("skippricecalculation", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("SkipPriceCalculation");
            }
        }

        /// <summary>
        /// Choose the service level agreement (SLA) that you want to apply to the quote record.
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
        /// sla_quote
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
        /// processstage_quotes
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
        /// Shows whether the quote is draft, active, won, or closed. Only draft quotes can be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.QuoteState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.QuoteState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.QuoteState), optionSet.Value)));
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
        /// Select the quote's status.
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
        /// Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount")]
        public Microsoft.Xrm.Sdk.Money TotalAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalAmount");
                this.SetAttributeValue("totalamount", value);
                this.OnPropertyChanged("TotalAmount");
            }
        }

        /// <summary>
        /// Shows the Total Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount_base");
            }
        }

        /// <summary>
        /// Shows the total product amount for the quote, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalAmountLessFreight");
                this.SetAttributeValue("totalamountlessfreight", value);
                this.OnPropertyChanged("TotalAmountLessFreight");
            }
        }

        /// <summary>
        /// Shows the Pre-Freight Amount converted field to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight_base");
            }
        }

        /// <summary>
        /// Shows the total discount amount, based on the discount price and rate entered on the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalDiscountAmount");
                this.SetAttributeValue("totaldiscountamount", value);
                this.OnPropertyChanged("TotalDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Total Discount Amount converted field to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount_base");
            }
        }

        /// <summary>
        /// Shows the sum of all existing and write-in products included on the quote, based on the specified price list and quantities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalLineItemAmount");
                this.SetAttributeValue("totallineitemamount", value);
                this.OnPropertyChanged("TotalLineItemAmount");
            }
        }

        /// <summary>
        /// Shows the Detail Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount_base");
            }
        }

        /// <summary>
        /// Shows the total of the Manual Discount amounts specified on all products included in the quote. This value is reflected in the Detail Amount field on the quote and is added to any discount amount or rate specified on the quote
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalLineItemDiscountAmount");
                this.SetAttributeValue("totallineitemdiscountamount", value);
                this.OnPropertyChanged("TotalLineItemDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Total Line Item Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount_base");
            }
        }

        /// <summary>
        /// Shows the total of the Tax amounts specified on all products included in the quote, included in the Total Amount due calculation for the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax")]
        public Microsoft.Xrm.Sdk.Money TotalTax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TotalTax");
                this.SetAttributeValue("totaltax", value);
                this.OnPropertyChanged("TotalTax");
            }
        }

        /// <summary>
        /// Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax_base")]
        public Microsoft.Xrm.Sdk.Money TotalTax_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax_base");
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
        /// Date on claim of lack of data
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_dateonclaimoflackofdata")]
        public System.Nullable<System.DateTime> ttpoico_Dateonclaimoflackofdata
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("ttpoico_dateonclaimoflackofdata");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Dateonclaimoflackofdata");
                this.SetAttributeValue("ttpoico_dateonclaimoflackofdata", value);
                this.OnPropertyChanged("ttpoico_Dateonclaimoflackofdata");
            }
        }

        /// <summary>
        /// Number for the ERP system or the Local system
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_erpnumber")]
        public string ttpoico_ERPNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ttpoico_erpnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_ERPNumber");
                this.SetAttributeValue("ttpoico_erpnumber", value);
                this.OnPropertyChanged("ttpoico_ERPNumber");
            }
        }

        /// <summary>
        /// Product Group 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_pg1")]
        public Microsoft.Xrm.Sdk.EntityReference ttpoico_PG1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ttpoico_pg1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_PG1");
                this.SetAttributeValue("ttpoico_pg1", value);
                this.OnPropertyChanged("ttpoico_PG1");
            }
        }

        /// <summary>
        /// Product Group 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_pg2")]
        public Microsoft.Xrm.Sdk.EntityReference ttpoico_PG2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ttpoico_pg2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_PG2");
                this.SetAttributeValue("ttpoico_pg2", value);
                this.OnPropertyChanged("ttpoico_PG2");
            }
        }

        /// <summary>
        /// Product Group 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_pg3")]
        public Microsoft.Xrm.Sdk.EntityReference ttpoico_PG3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ttpoico_pg3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_PG3");
                this.SetAttributeValue("ttpoico_pg3", value);
                this.OnPropertyChanged("ttpoico_PG3");
            }
        }

        /// <summary>
        /// Product main group
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_productmaingroup")]
        public Microsoft.Xrm.Sdk.EntityReference ttpoico_Productmaingroup
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ttpoico_productmaingroup");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Productmaingroup");
                this.SetAttributeValue("ttpoico_productmaingroup", value);
                this.OnPropertyChanged("ttpoico_Productmaingroup");
            }
        }

        /// <summary>
        /// Reception order date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_receptionorderdate")]
        public System.Nullable<System.DateTime> ttpoico_Receptionorderdate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("ttpoico_receptionorderdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Receptionorderdate");
                this.SetAttributeValue("ttpoico_receptionorderdate", value);
                this.OnPropertyChanged("ttpoico_Receptionorderdate");
            }
        }

        /// <summary>
        /// Technologies
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_technologies")]
        public Microsoft.Xrm.Sdk.OptionSetValue ttpoico_Technologies
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ttpoico_technologies");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Technologies");
                this.SetAttributeValue("ttpoico_technologies", value);
                this.OnPropertyChanged("ttpoico_Technologies");
            }
        }

        /// <summary>
        /// Technologies
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_technologies")]
        public virtual Quote_ttpoico_Technologies? ttpoico_TechnologiesEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Quote_ttpoico_Technologies?)(EntityOptionSetEnum.GetEnum(this, "ttpoico_technologies")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Technologies");
                this.SetAttributeValue("ttpoico_technologies", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("ttpoico_Technologies");
            }
        }

        /// <summary>
        /// Total Amount
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_totalamount")]
        public Microsoft.Xrm.Sdk.Money ttpoico_TotalAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("ttpoico_totalamount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_TotalAmount");
                this.SetAttributeValue("ttpoico_totalamount", value);
                this.OnPropertyChanged("ttpoico_TotalAmount");
            }
        }

        /// <summary>
        /// Value of the Total Amount in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_totalamount_base")]
        public Microsoft.Xrm.Sdk.Money ttpoico_totalamount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("ttpoico_totalamount_base");
            }
        }

        /// <summary>
        /// Total shipping date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_totalshippingdate")]
        public System.Nullable<System.DateTime> ttpoico_Totalshippingdate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("ttpoico_totalshippingdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Totalshippingdate");
                this.SetAttributeValue("ttpoico_totalshippingdate", value);
                this.OnPropertyChanged("ttpoico_Totalshippingdate");
            }
        }

        /// <summary>
        /// Quote Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_type")]
        public Microsoft.Xrm.Sdk.OptionSetValue ttpoico_Type
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ttpoico_type");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Type");
                this.SetAttributeValue("ttpoico_type", value);
                this.OnPropertyChanged("ttpoico_Type");
            }
        }

        /// <summary>
        /// Quote Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_type")]
        public virtual Quote_ttpoico_Type? ttpoico_TypeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Quote_ttpoico_Type?)(EntityOptionSetEnum.GetEnum(this, "ttpoico_type")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_Type");
                this.SetAttributeValue("ttpoico_type", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("ttpoico_Type");
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
        /// Version number of the quote.
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
        /// Select whether the products included in the quote should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("willcall")]
        public System.Nullable<bool> WillCall
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("willcall");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("WillCall");
                this.SetAttributeValue("willcall", value);
                this.OnPropertyChanged("WillCall");
            }
        }

        /// <summary>
        /// 1:N quote_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> quote_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("quote_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("quote_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("quote_activity_parties", null, value);
                this.OnPropertyChanged("quote_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Quote_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> Quote_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Quote_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Quote_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Quote_Appointments", null, value);
                this.OnPropertyChanged("Quote_Appointments");
            }
        }

        /// <summary>
        /// 1:N Quote_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Quote_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Quote_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Quote_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Quote_Emails", null, value);
                this.OnPropertyChanged("Quote_Emails");
            }
        }

        /// <summary>
        /// 1:N Quote_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> Quote_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Quote_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Quote_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Quote_Tasks", null, value);
                this.OnPropertyChanged("Quote_Tasks");
            }
        }

        /// <summary>
        /// 1:N rbtt_quote_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_quote_opportunity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> rbtt_quote_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("rbtt_quote_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_quote_opportunity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("rbtt_quote_opportunity", null, value);
                this.OnPropertyChanged("rbtt_quote_opportunity");
            }
        }

        /// <summary>
        /// N:N contactquotes_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactquotes_association")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> contactquotes_association
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contactquotes_association", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contactquotes_association");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contactquotes_association", null, value);
                this.OnPropertyChanged("contactquotes_association");
            }
        }

        /// <summary>
        /// N:1 lk_quote_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_quote_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quote_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quote_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quote_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_quote_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_quote_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quote_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quote_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quote_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_quotebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_quotebase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quotebase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quotebase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quotebase_createdby", null, value);
                this.OnPropertyChanged("lk_quotebase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_quotebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_quotebase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quotebase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_quotebase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_quotebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_quotebase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 opportunity_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_quotes")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity opportunity_quotes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_quotes", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_quotes");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_quotes", null, value);
                this.OnPropertyChanged("opportunity_quotes");
            }
        }

        /// <summary>
        /// N:1 quote_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_customer_accounts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account quote_customer_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("quote_customer_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("quote_customer_accounts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("quote_customer_accounts", null, value);
                this.OnPropertyChanged("quote_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 quote_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_customer_contacts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact quote_customer_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("quote_customer_contacts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("quote_customer_contacts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("quote_customer_contacts", null, value);
                this.OnPropertyChanged("quote_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 system_user_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotes")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser system_user_quotes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_quotes", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_quotes");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_quotes", null, value);
                this.OnPropertyChanged("system_user_quotes");
            }
        }

        /// <summary>
        /// N:1 ttpoico_orb_productgroup_quote_PG1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_pg1")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ttpoico_orb_productgroup_quote_PG1")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup ttpoico_orb_productgroup_quote_PG1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("ttpoico_orb_productgroup_quote_PG1", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_orb_productgroup_quote_PG1");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("ttpoico_orb_productgroup_quote_PG1", null, value);
                this.OnPropertyChanged("ttpoico_orb_productgroup_quote_PG1");
            }
        }

        /// <summary>
        /// N:1 ttpoico_orb_productgroup_quote_PG2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_pg2")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ttpoico_orb_productgroup_quote_PG2")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup ttpoico_orb_productgroup_quote_PG2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("ttpoico_orb_productgroup_quote_PG2", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_orb_productgroup_quote_PG2");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("ttpoico_orb_productgroup_quote_PG2", null, value);
                this.OnPropertyChanged("ttpoico_orb_productgroup_quote_PG2");
            }
        }

        /// <summary>
        /// N:1 ttpoico_orb_productgroup_quote_PG3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttpoico_pg3")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ttpoico_orb_productgroup_quote_PG3")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup ttpoico_orb_productgroup_quote_PG3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("ttpoico_orb_productgroup_quote_PG3", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ttpoico_orb_productgroup_quote_PG3");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("ttpoico_orb_productgroup_quote_PG3", null, value);
                this.OnPropertyChanged("ttpoico_orb_productgroup_quote_PG3");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Quote(object anonymousType) :
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
                        Attributes["quoteid"] = base.Id;
                        break;
                    case "quoteid":
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