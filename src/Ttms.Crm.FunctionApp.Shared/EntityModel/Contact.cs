﻿namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ContactState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Person with whom a business unit has a relationship, such as customer, supplier, and colleague.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contact")]
    public partial class Contact : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string AccountId = "accountid";
            public const string AccountRoleCode = "accountrolecode";
            public const string Address1_AddressId = "address1_addressid";
            public const string Address1_AddressTypeCode = "address1_addresstypecode";
            public const string Address1_City = "address1_city";
            public const string Address1_Composite = "address1_composite";
            public const string Address1_Country = "address1_country";
            public const string Address1_County = "address1_county";
            public const string Address1_Fax = "address1_fax";
            public const string Address1_FreightTermsCode = "address1_freighttermscode";
            public const string Address1_Latitude = "address1_latitude";
            public const string Address1_Line1 = "address1_line1";
            public const string Address1_Line2 = "address1_line2";
            public const string Address1_Line3 = "address1_line3";
            public const string Address1_Longitude = "address1_longitude";
            public const string Address1_Name = "address1_name";
            public const string Address1_PostalCode = "address1_postalcode";
            public const string Address1_PostOfficeBox = "address1_postofficebox";
            public const string Address1_PrimaryContactName = "address1_primarycontactname";
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
            public const string Address2_FreightTermsCode = "address2_freighttermscode";
            public const string Address2_Latitude = "address2_latitude";
            public const string Address2_Line1 = "address2_line1";
            public const string Address2_Line2 = "address2_line2";
            public const string Address2_Line3 = "address2_line3";
            public const string Address2_Longitude = "address2_longitude";
            public const string Address2_Name = "address2_name";
            public const string Address2_PostalCode = "address2_postalcode";
            public const string Address2_PostOfficeBox = "address2_postofficebox";
            public const string Address2_PrimaryContactName = "address2_primarycontactname";
            public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
            public const string Address2_StateOrProvince = "address2_stateorprovince";
            public const string Address2_Telephone1 = "address2_telephone1";
            public const string Address2_Telephone2 = "address2_telephone2";
            public const string Address2_Telephone3 = "address2_telephone3";
            public const string Address2_UPSZone = "address2_upszone";
            public const string Address2_UTCOffset = "address2_utcoffset";
            public const string Address3_AddressId = "address3_addressid";
            public const string Address3_AddressTypeCode = "address3_addresstypecode";
            public const string Address3_City = "address3_city";
            public const string Address3_Composite = "address3_composite";
            public const string Address3_Country = "address3_country";
            public const string Address3_County = "address3_county";
            public const string Address3_Fax = "address3_fax";
            public const string Address3_FreightTermsCode = "address3_freighttermscode";
            public const string Address3_Latitude = "address3_latitude";
            public const string Address3_Line1 = "address3_line1";
            public const string Address3_Line2 = "address3_line2";
            public const string Address3_Line3 = "address3_line3";
            public const string Address3_Longitude = "address3_longitude";
            public const string Address3_Name = "address3_name";
            public const string Address3_PostalCode = "address3_postalcode";
            public const string Address3_PostOfficeBox = "address3_postofficebox";
            public const string Address3_PrimaryContactName = "address3_primarycontactname";
            public const string Address3_ShippingMethodCode = "address3_shippingmethodcode";
            public const string Address3_StateOrProvince = "address3_stateorprovince";
            public const string Address3_Telephone1 = "address3_telephone1";
            public const string Address3_Telephone2 = "address3_telephone2";
            public const string Address3_Telephone3 = "address3_telephone3";
            public const string Address3_UPSZone = "address3_upszone";
            public const string Address3_UTCOffset = "address3_utcoffset";
            public const string Aging30 = "aging30";
            public const string Aging30_Base = "aging30_base";
            public const string Aging60 = "aging60";
            public const string Aging60_Base = "aging60_base";
            public const string Aging90 = "aging90";
            public const string Aging90_Base = "aging90_base";
            public const string Anniversary = "anniversary";
            public const string AnnualIncome = "annualincome";
            public const string AnnualIncome_Base = "annualincome_base";
            public const string AssistantName = "assistantname";
            public const string AssistantPhone = "assistantphone";
            public const string BirthDate = "birthdate";
            public const string Btt_AC = "btt_ac";
            public const string Btt_Acceptance_addressusage = "btt_acceptance_addressusage";
            public const string Btt_Acceptanceforpublication = "btt_acceptanceforpublication";
            public const string Btt_activity_projects = "btt_activity_projects";
            public const string Btt_activity_Trade = "btt_activity_trade";
            public const string Btt_activity_workmanship = "btt_activity_workmanship";
            public const string Btt_Additionalnotes = "btt_additionalnotes";
            public const string Btt_address_private_city = "btt_address_private_city";
            public const string Btt_address_private_country = "btt_address_private_country";
            public const string Btt_address_private_fax = "btt_address_private_fax";
            public const string Btt_address_private_line1 = "btt_address_private_line1";
            public const string Btt_address_private_line2 = "btt_address_private_line2";
            public const string Btt_address_private_line3 = "btt_address_private_line3";
            public const string Btt_address_private_postalcode = "btt_address_private_postalcode";
            public const string Btt_address_private_telephone1 = "btt_address_private_telephone1";
            public const string Btt_AHU = "btt_ahu";
            public const string Btt_ASHP = "btt_ashp";
            public const string btt_authorizationnumber = "btt_authorizationnumber";
            public const string BTT_Biomass_pg = "btt_biomass_pg";
            public const string btt_Brand = "btt_brand";
            public const string Btt_calculationprogram = "btt_calculationprogram";
            public const string btt_CentrifugalChiller = "btt_centrifugalchiller";
            public const string btt_clubelmavantagesmember = "btt_clubelmavantagesmember";
            public const string btt_competitorid = "btt_competitorid";
            public const string Btt_contactstatus = "btt_contactstatus";
            public const string BTT_ConventionalHeating_pg = "btt_conventionalheating_pg";
            public const string Btt_conventionalheatingstanding = "btt_conventionalheatingstanding";
            public const string Btt_conventionalheatingwallhung = "btt_conventionalheatingwallhung";
            public const string btt_CRMContactNumber = "btt_crmcontactnumber";
            public const string Btt_Date_endofcooperation = "btt_date_endofcooperation";
            public const string Btt_Date_startofcooperation = "btt_date_startofcooperation";
            public const string btt_DateCancellationSubscription = "btt_datecancellationsubscription";
            public const string btt_DateofClickingDOILink = "btt_dateofclickingdoilink";
            public const string btt_dateofconfirmationemail = "btt_dateofconfirmationemail";
            public const string Btt_Dateofpurchase = "btt_dateofpurchase";
            public const string btt_DateofRegistrationSubscription = "btt_dateofregistrationsubscription";
            public const string BTT_DMUIsDecider = "btt_dmuisdecider";
            public const string BTT_DMUIsGatekeeper = "btt_dmuisgatekeeper";
            public const string BTT_DMUIsInfluencer = "btt_dmuisinfluencer";
            public const string BTT_DMUIsOwner = "btt_dmuisowner";
            public const string BTT_DMUIsPurchaser = "btt_dmuispurchaser";
            public const string BTT_DMUIsUser = "btt_dmuisuser";
            public const string Btt_DonotSMS = "btt_donotsms";
            public const string btt_eAcademyNumber = "btt_eacademynumber";
            public const string Btt_electric = "btt_electric";
            public const string Btt_Electricalentitlement = "btt_electricalentitlement";
            public const string Btt_ElectricHeatPumpAirtoAir = "btt_electricheatpumpairtoair";
            public const string Btt_ElectricHeatPumpAirtoWater = "btt_electricheatpumpairtowater";
            public const string Btt_ElectricHeatPumpExhaustairliquid = "btt_electricheatpumpexhaustairliquid";
            public const string Btt_ElectricHeatPumpGroundSource = "btt_electricheatpumpgroundsource";
            public const string BTT_emailacceptance = "btt_emailacceptance";
            public const string Btt_EWS = "btt_ews";
            public const string btt_externalnumber = "btt_externalnumber";
            public const string BTT_faxacceptance = "btt_faxacceptance";
            public const string Btt_FCU = "btt_fcu";
            public const string Btt_Field_boilerrooms = "btt_field_boilerrooms";
            public const string Btt_Field_centralheating = "btt_field_centralheating";
            public const string Btt_Field_climate = "btt_field_climate";
            public const string Btt_Field_coolingsystems = "btt_field_coolingsystems";
            public const string Btt_Field_domestichotwater = "btt_field_domestichotwater";
            public const string Btt_Field_heatpumps = "btt_field_heatpumps";
            public const string Btt_Field_sewagesystems = "btt_field_sewagesystems";
            public const string Btt_Field_solarsystems = "btt_field_solarsystems";
            public const string Btt_Field_ventilation = "btt_field_ventilation";
            public const string Btt_formalitiesinprogress = "btt_formalitiesinprogress";
            public const string Btt_FSB = "btt_fsb";
            public const string Btt_fzk = "btt_fzk";
            public const string Btt_gas = "btt_gas";
            public const string Btt_GWI = "btt_gwi";
            public const string btt_HardBounces = "btt_hardbounces";
            public const string Btt_has_contract = "btt_has_contract";
            public const string BTT_HeatDistributionOther_pg = "btt_heatdistributionother_pg";
            public const string BTT_HeatingPumpwithExpansionTank_pg = "btt_heatingpumpwithexpansiontank_pg";
            public const string Btt_HPWH = "btt_hpwh";
            public const string Btt_HST = "btt_hst";
            public const string Btt_Importflag = "btt_importflag";
            public const string Btt_INBImport = "btt_inbimport";
            public const string Btt_INBLocal = "btt_inblocal";
            public const string Btt_installationleader = "btt_installationleader";
            public const string Btt_Installerauthorizationnumber = "btt_installerauthorizationnumber";
            public const string Btt_Interested_planningdoc = "btt_interested_planningdoc";
            public const string Btt_Interested_training = "btt_interested_training";
            public const string Btt_JobTitle = "btt_jobtitle";
            public const string btt_LastAppointmentCompletedById = "btt_lastappointmentcompletedbyid";
            public const string Btt_PGRelevanceCondensingFloor = "btt_pgrelevancecondensingfloor";
            public const string Btt_PGRelevanceCondensingWall = "btt_pgrelevancecondensingwall";
            public const string BTT_phoneacceptance = "btt_phoneacceptance";
            public const string BTT_PrivateAddressAcceptance = "btt_privateaddressacceptance";
            public const string BTT_privatedataacceptance = "btt_privatedataacceptance";
            public const string btt_Province = "btt_province";
            public const string Btt_Registration = "btt_registration";
            public const string Btt_RenewablesAdviser = "btt_renewablesadviser";
            public const string btt_replacementcontactid = "btt_replacementcontactid";
            public const string Btt_ResponsibleAll = "btt_responsibleall";
            public const string Btt_ResponsibleControlling = "btt_responsiblecontrolling";
            public const string Btt_ResponsibleManagement = "btt_responsiblemanagement";
            public const string Btt_ResponsiblePurchasing = "btt_responsiblepurchasing";
            public const string Btt_ResponsibleSales = "btt_responsiblesales";
            public const string Btt_ResponsibleService = "btt_responsibleservice";
            public const string btt_responsibleservice_userid = "btt_responsibleservice_userid";
            public const string Btt_role = "btt_role";
            public const string Btt_Role_authorizedinstaller = "btt_role_authorizedinstaller";
            public const string Btt_Role_authorizedpointofsaleemployee = "btt_role_authorizedpointofsaleemployee";
            public const string Btt_Role_authorizedserviceman = "btt_role_authorizedserviceman";
            public const string Btt_Role_authorizedtradepartneremployee = "btt_role_authorizedtradepartneremployee";
            public const string Btt_Role_formerauthorizedinstaller = "btt_role_formerauthorizedinstaller";
            public const string Btt_Role_formerauthorizedserviceman = "btt_role_formerauthorizedserviceman";
            public const string Btt_Role_installerwithpromisecontract = "btt_role_installerwithpromisecontract";
            public const string Btt_Role_other = "btt_role_other";
            public const string Btt_Role_planner = "btt_role_planner";
            public const string Btt_Role_potentialauthorizedinstaller = "btt_role_potentialauthorizedinstaller";
            public const string Btt_roles = "btt_roles";
            public const string btt_ScrewChiller = "btt_screwchiller";
            public const string Btt_Servicemanauthorizationnumber = "btt_servicemanauthorizationnumber";
            public const string Btt_Size = "btt_size";
            public const string btt_smsacceptance = "btt_smsacceptance";
            public const string btt_SoftBounces = "btt_softbounces";
            public const string BTT_SolarPhotovoltaic_pg = "btt_solarphotovoltaic_pg";
            public const string BTT_SolarThermic_pg = "btt_solarthermic_pg";
            public const string Btt_Stamp = "btt_stamp";
            public const string Btt_STS = "btt_sts";
            public const string Btt_TechnicalAdvisor = "btt_technicaladvisor";
            public const string Btt_tradeMailing = "btt_trademailing";
            public const string btt_traininglocationid = "btt_traininglocationid";
            public const string Btt_trigger_price = "btt_trigger_price";
            public const string Btt_trigger_product = "btt_trigger_product";
            public const string Btt_trigger_relationship = "btt_trigger_relationship";
            public const string Btt_trigger_service = "btt_trigger_service";
            public const string Btt_trigger_technicalsupport = "btt_trigger_technicalsupport";
            public const string Btt_TTbrand = "btt_ttbrand";
            public const string BTT_UnderfloorHeating_pg = "btt_underfloorheating_pg";
            public const string Btt_Usage_AutoCAD = "btt_usage_autocad";
            public const string Btt_useprivateaddress = "btt_useprivateaddress";
            public const string Btt_WB = "btt_wb";
            public const string Btt_WSHP = "btt_wshp";
            public const string Business2 = "business2";
            public const string BusinessCard = "businesscard";
            public const string BusinessCardAttributes = "businesscardattributes";
            public const string Callback = "callback";
            public const string ChildrensNames = "childrensnames";
            public const string Company = "company";
            public const string ContactId = "contactid";
            public const string Id = "contactid";
            public const string CreatedBy = "createdby";
            public const string CreatedByExternalParty = "createdbyexternalparty";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CreditLimit = "creditlimit";
            public const string CreditLimit_Base = "creditlimit_base";
            public const string CreditOnHold = "creditonhold";
            public const string CustomerSizeCode = "customersizecode";
            public const string CustomerTypeCode = "customertypecode";
            public const string DefaultPriceLevelId = "defaultpricelevelid";
            public const string Department = "department";
            public const string Description = "description";
            public const string DoNotBulkEMail = "donotbulkemail";
            public const string DoNotBulkPostalMail = "donotbulkpostalmail";
            public const string DoNotEMail = "donotemail";
            public const string DoNotFax = "donotfax";
            public const string DoNotPhone = "donotphone";
            public const string DoNotPostalMail = "donotpostalmail";
            public const string DoNotSendMM = "donotsendmm";
            public const string EducationCode = "educationcode";
            public const string EMailAddress1 = "emailaddress1";
            public const string EMailAddress2 = "emailaddress2";
            public const string EMailAddress3 = "emailaddress3";
            public const string EmployeeId = "employeeid";
            public const string EntityImage = "entityimage";
            public const string EntityImage_Timestamp = "entityimage_timestamp";
            public const string EntityImage_URL = "entityimage_url";
            public const string EntityImageId = "entityimageid";
            public const string ExchangeRate = "exchangerate";
            public const string ExternalUserIdentifier = "externaluseridentifier";
            public const string FamilyStatusCode = "familystatuscode";
            public const string Fax = "fax";
            public const string FirstName = "firstname";
            public const string FollowEmail = "followemail";
            public const string FtpSiteUrl = "ftpsiteurl";
            public const string FullName = "fullname";
            public const string GenderCode = "gendercode";
            public const string GovernmentId = "governmentid";
            public const string HasChildrenCode = "haschildrencode";
            public const string Home2 = "home2";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IsBackofficeCustomer = "isbackofficecustomer";
            public const string JobTitle = "jobtitle";
            public const string LastName = "lastname";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string LastUsedInCampaign = "lastusedincampaign";
            public const string LeadSourceCode = "leadsourcecode";
            public const string ManagerName = "managername";
            public const string ManagerPhone = "managerphone";
            public const string MarketingOnly = "marketingonly";
            public const string MasterId = "masterid";
            public const string Merged = "merged";
            public const string MiddleName = "middlename";
            public const string MobilePhone = "mobilephone";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByExternalParty = "modifiedbyexternalparty";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string msdyn_gdproptout = "msdyn_gdproptout";
            public const string msdyn_orgchangestatus = "msdyn_orgchangestatus";
            public const string NickName = "nickname";
            public const string NumberOfChildren = "numberofchildren";
            public const string OnHoldTime = "onholdtime";
            public const string OriginatingLeadId = "originatingleadid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string Pager = "pager";
            public const string ParentContactId = "parentcontactid";
            public const string ParentCustomerId = "parentcustomerid";
            public const string ParticipatesInWorkflow = "participatesinworkflow";
            public const string PaymentTermsCode = "paymenttermscode";
            public const string PreferredAppointmentDayCode = "preferredappointmentdaycode";
            public const string PreferredAppointmentTimeCode = "preferredappointmenttimecode";
            public const string PreferredContactMethodCode = "preferredcontactmethodcode";
            public const string PreferredEquipmentId = "preferredequipmentid";
            public const string PreferredServiceId = "preferredserviceid";
            public const string PreferredSystemUserId = "preferredsystemuserid";
            public const string ProcessId = "processid";
            public const string rbtt_bounce = "rbtt_bounce";
            public const string rbtt_CIAMID = "rbtt_ciamid";
            public const string rbtt_Contact_MappingId = "rbtt_contact_mappingid";
            public const string rbtt_CountryId = "rbtt_countryid";
            public const string rbtt_datanormnewsletteremail = "rbtt_datanormnewsletteremail";
            public const string rbtt_elearningnewsletteremail = "rbtt_elearningnewsletteremail";
            public const string rbtt_emailbounce = "rbtt_emailbounce";
            public const string rbtt_epioutbounce_email = "rbtt_epioutbounce_email";
            public const string rbtt_ExternalContactNumber = "rbtt_externalcontactnumber";
            public const string rbtt_GDPR_Emergeny_Block_Count = "rbtt_gdpr_emergeny_block_count";
            public const string rbtt_GDPR_Mail_Trigger = "rbtt_gdpr_mail_trigger";
            public const string rbtt_GDPRBlock = "rbtt_gdprblock";
            public const string rbtt_GDPRConsentCount1 = "rbtt_gdprconsentcount1";
            public const string rbtt_GDPRConsentCount1_Date = "rbtt_gdprconsentcount1_date";
            public const string rbtt_GDPRConsentCount1_State = "rbtt_gdprconsentcount1_state";
            public const string rbtt_generalnewsletteremail = "rbtt_generalnewsletteremail";
            public const string rbtt_heatpumpnewsletteremail = "rbtt_heatpumpnewsletteremail";
            public const string rbtt_Housenumber = "rbtt_housenumber";
            public const string rbtt_LanguageId = "rbtt_languageid";
            public const string rbtt_partnerprogramnewsletteremail = "rbtt_partnerprogramnewsletteremail";
            public const string Salutation = "salutation";
            public const string ShippingMethodCode = "shippingmethodcode";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string SpousesName = "spousesname";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string SubscriptionId = "subscriptionid";
            public const string Suffix = "suffix";
            public const string TeamsFollowed = "teamsfollowed";
            public const string Telephone1 = "telephone1";
            public const string Telephone2 = "telephone2";
            public const string Telephone3 = "telephone3";
            public const string TerritoryCode = "territorycode";
            public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string WebSiteUrl = "websiteurl";
            public const string YomiFirstName = "yomifirstname";
            public const string YomiFullName = "yomifullname";
            public const string YomiLastName = "yomilastname";
            public const string YomiMiddleName = "yomimiddlename";
            public const string Referencingbtt_contact_contact = "btt_contact_contact";
            public const string btt_customerservice_user_contact = "btt_customerservice_user_contact";
            public const string btt_systemuser_contact = "btt_systemuser_contact";
            public const string contact_customer_accounts = "contact_customer_accounts";
            public const string Referencingcontact_customer_contacts = "contact_customer_contacts";
            public const string Referencingcontact_master_contact = "contact_master_contact";
            public const string contact_owning_user = "contact_owning_user";
            public const string lk_contact_createdonbehalfby = "lk_contact_createdonbehalfby";
            public const string lk_contact_modifiedonbehalfby = "lk_contact_modifiedonbehalfby";
            public const string lk_contactbase_createdby = "lk_contactbase_createdby";
            public const string lk_contactbase_modifiedby = "lk_contactbase_modifiedby";
            public const string rbtt_orb_country_contact_CountryId = "rbtt_orb_country_contact_CountryId";
            public const string system_user_contacts = "system_user_contacts";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Contact() :
                base(EntityLogicalName)
        {
        }

        public const string AlternateKeys = "btt_crmcontactnumber|rbtt_externalcontactnumber";

        public const string EntityLogicalName = "contact";

        public const string EntitySchemaName = "Contact";

        public const string PrimaryIdAttribute = "contactid";

        public const string PrimaryNameAttribute = "fullname";

        public const string EntityLogicalCollectionName = "contacts";

        public const string EntitySetName = "contacts";

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
        /// Unique identifier of the account with which the contact is associated.
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
        /// Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountRoleCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountrolecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountRoleCode");
                this.SetAttributeValue("accountrolecode", value);
                this.OnPropertyChanged("AccountRoleCode");
            }
        }

        /// <summary>
        /// Select the contact's role within the company or sales process, such as decision maker, employee, or influencer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountrolecode")]
        public virtual Contact_AccountRoleCode? AccountRoleCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_AccountRoleCode?)(EntityOptionSetEnum.GetEnum(this, "accountrolecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountRoleCode");
                this.SetAttributeValue("accountrolecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("AccountRoleCode");
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
        /// Select the primary address type.
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
        /// Select the primary address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public virtual Contact_Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
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
        /// Type the city for the primary address.
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
        /// Type the country or region for the primary address.
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
        /// Type the county for the primary address.
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
        /// Type the fax number associated with the primary address.
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
        /// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_FreightTermsCode");
                this.SetAttributeValue("address1_freighttermscode", value);
                this.OnPropertyChanged("Address1_FreightTermsCode");
            }
        }

        /// <summary>
        /// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_freighttermscode")]
        public virtual Contact_Address1_FreightTermsCode? Address1_FreightTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address1_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address1_freighttermscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_FreightTermsCode");
                this.SetAttributeValue("address1_freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address1_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the primary address for use in mapping and other applications.
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
        /// Type the first line of the primary address.
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
        /// Type the second line of the primary address.
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
        /// Type the third line of the primary address.
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
        /// Type the longitude value for the primary address for use in mapping and other applications.
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
        /// Type a descriptive name for the primary address, such as Corporate Headquarters.
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
        /// Type the ZIP Code or postal code for the primary address.
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
        /// Type the post office box number of the primary address.
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
        /// Type the name of the main contact at the account's primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_primarycontactname")]
        public string Address1_PrimaryContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address1_primarycontactname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PrimaryContactName");
                this.SetAttributeValue("address1_primarycontactname", value);
                this.OnPropertyChanged("Address1_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
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
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public virtual Contact_Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
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
        /// Voivodship for address 1.
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
        /// Type the main phone number associated with the primary address.
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
        /// Type a second phone number associated with the primary address.
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
        /// Type a third phone number associated with the primary address.
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
        /// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
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
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
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
        /// Select the secondary address type.
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
        /// Select the secondary address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public virtual Contact_Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
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
        /// Type the city for the secondary address.
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
        /// Type the country or region for the secondary address.
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
        /// Type the county for the secondary address.
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
        /// Type the fax number associated with the secondary address.
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
        /// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_FreightTermsCode");
                this.SetAttributeValue("address2_freighttermscode", value);
                this.OnPropertyChanged("Address2_FreightTermsCode");
            }
        }

        /// <summary>
        /// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_freighttermscode")]
        public virtual Contact_Address2_FreightTermsCode? Address2_FreightTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address2_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address2_freighttermscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_FreightTermsCode");
                this.SetAttributeValue("address2_freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address2_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the secondary address for use in mapping and other applications.
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
        /// Type the first line of the secondary address.
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
        /// Type the second line of the secondary address.
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
        /// Type the third line of the secondary address.
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
        /// Type the longitude value for the secondary address for use in mapping and other applications.
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
        /// Type a descriptive name for the secondary address, such as Corporate Headquarters.
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
        /// Type the ZIP Code or postal code for the secondary address.
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
        /// Type the post office box number of the secondary address.
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
        /// Type the name of the main contact at the account's secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_primarycontactname")]
        public string Address2_PrimaryContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address2_primarycontactname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PrimaryContactName");
                this.SetAttributeValue("address2_primarycontactname", value);
                this.OnPropertyChanged("Address2_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
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
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public virtual Contact_Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
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
        /// Type the state or province of the secondary address.
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
        /// Type the main phone number associated with the secondary address.
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
        /// Type a second phone number associated with the secondary address.
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
        /// Type a third phone number associated with the secondary address.
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
        /// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
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
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
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
        /// Unique identifier for address 3.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addressid")]
        public System.Nullable<System.Guid> Address3_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address3_addressid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_AddressId");
                this.SetAttributeValue("address3_addressid", value);
                this.OnPropertyChanged("Address3_AddressId");
            }
        }

        /// <summary>
        /// Select the third address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address3_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_addresstypecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_AddressTypeCode");
                this.SetAttributeValue("address3_addresstypecode", value);
                this.OnPropertyChanged("Address3_AddressTypeCode");
            }
        }

        /// <summary>
        /// Select the third address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_addresstypecode")]
        public virtual Contact_Address3_AddressTypeCode? Address3_AddressTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address3_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address3_addresstypecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_AddressTypeCode");
                this.SetAttributeValue("address3_addresstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address3_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type the city for the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_city")]
        public string Address3_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_City");
                this.SetAttributeValue("address3_city", value);
                this.OnPropertyChanged("Address3_City");
            }
        }

        /// <summary>
        /// Shows the complete third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_composite")]
        public string Address3_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_composite");
            }
        }

        /// <summary>
        /// the country or region for the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_country")]
        public string Address3_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Country");
                this.SetAttributeValue("address3_country", value);
                this.OnPropertyChanged("Address3_Country");
            }
        }

        /// <summary>
        /// Type the county for the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_county")]
        public string Address3_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_county");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_County");
                this.SetAttributeValue("address3_county", value);
                this.OnPropertyChanged("Address3_County");
            }
        }

        /// <summary>
        /// Type the fax number associated with the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_fax")]
        public string Address3_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Fax");
                this.SetAttributeValue("address3_fax", value);
                this.OnPropertyChanged("Address3_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms for the third address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address3_FreightTermsCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_freighttermscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_FreightTermsCode");
                this.SetAttributeValue("address3_freighttermscode", value);
                this.OnPropertyChanged("Address3_FreightTermsCode");
            }
        }

        /// <summary>
        /// Select the freight terms for the third address to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_freighttermscode")]
        public virtual Contact_Address3_FreightTermsCode? Address3_FreightTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address3_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address3_freighttermscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_FreightTermsCode");
                this.SetAttributeValue("address3_freighttermscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address3_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the third address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_latitude")]
        public System.Nullable<double> Address3_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address3_latitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Latitude");
                this.SetAttributeValue("address3_latitude", value);
                this.OnPropertyChanged("Address3_Latitude");
            }
        }

        /// <summary>
        /// the first line of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line1")]
        public string Address3_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_line1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Line1");
                this.SetAttributeValue("address3_line1", value);
                this.OnPropertyChanged("Address3_Line1");
            }
        }

        /// <summary>
        /// the second line of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line2")]
        public string Address3_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_line2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Line2");
                this.SetAttributeValue("address3_line2", value);
                this.OnPropertyChanged("Address3_Line2");
            }
        }

        /// <summary>
        /// the third line of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_line3")]
        public string Address3_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_line3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Line3");
                this.SetAttributeValue("address3_line3", value);
                this.OnPropertyChanged("Address3_Line3");
            }
        }

        /// <summary>
        /// Type the longitude value for the third address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_longitude")]
        public System.Nullable<double> Address3_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address3_longitude");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Longitude");
                this.SetAttributeValue("address3_longitude", value);
                this.OnPropertyChanged("Address3_Longitude");
            }
        }

        /// <summary>
        /// Type a descriptive name for the third address, such as Corporate Headquarters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_name")]
        public string Address3_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Name");
                this.SetAttributeValue("address3_name", value);
                this.OnPropertyChanged("Address3_Name");
            }
        }

        /// <summary>
        /// the ZIP Code or postal code for the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postalcode")]
        public string Address3_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_PostalCode");
                this.SetAttributeValue("address3_postalcode", value);
                this.OnPropertyChanged("Address3_PostalCode");
            }
        }

        /// <summary>
        /// the post office box number of the 3rd address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_postofficebox")]
        public string Address3_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_postofficebox");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_PostOfficeBox");
                this.SetAttributeValue("address3_postofficebox", value);
                this.OnPropertyChanged("Address3_PostOfficeBox");
            }
        }

        /// <summary>
        /// Type the name of the main contact at the account's third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_primarycontactname")]
        public string Address3_PrimaryContactName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_primarycontactname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_PrimaryContactName");
                this.SetAttributeValue("address3_primarycontactname", value);
                this.OnPropertyChanged("Address3_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address3_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address3_shippingmethodcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_ShippingMethodCode");
                this.SetAttributeValue("address3_shippingmethodcode", value);
                this.OnPropertyChanged("Address3_ShippingMethodCode");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_shippingmethodcode")]
        public virtual Contact_Address3_ShippingMethodCode? Address3_ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Address3_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address3_shippingmethodcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_ShippingMethodCode");
                this.SetAttributeValue("address3_shippingmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Address3_ShippingMethodCode");
            }
        }

        /// <summary>
        /// the state or province of the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_stateorprovince")]
        public string Address3_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_stateorprovince");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_StateOrProvince");
                this.SetAttributeValue("address3_stateorprovince", value);
                this.OnPropertyChanged("Address3_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the main phone number associated with the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone1")]
        public string Address3_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_telephone1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Telephone1");
                this.SetAttributeValue("address3_telephone1", value);
                this.OnPropertyChanged("Address3_Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number associated with the third address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone2")]
        public string Address3_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_telephone2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Telephone2");
                this.SetAttributeValue("address3_telephone2", value);
                this.OnPropertyChanged("Address3_Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_telephone3")]
        public string Address3_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_telephone3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_Telephone3");
                this.SetAttributeValue("address3_telephone3", value);
                this.OnPropertyChanged("Address3_Telephone3");
            }
        }

        /// <summary>
        /// Type the UPS zone of the third address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_upszone")]
        public string Address3_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("address3_upszone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_UPSZone");
                this.SetAttributeValue("address3_upszone", value);
                this.OnPropertyChanged("Address3_UPSZone");
            }
        }

        /// <summary>
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address3_utcoffset")]
        public System.Nullable<int> Address3_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address3_utcoffset");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address3_UTCOffset");
                this.SetAttributeValue("address3_utcoffset", value);
                this.OnPropertyChanged("Address3_UTCOffset");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30")]
        public Microsoft.Xrm.Sdk.Money Aging30
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
            }
        }

        /// <summary>
        /// Shows the Aging 30 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging30_base")]
        public Microsoft.Xrm.Sdk.Money Aging30_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60")]
        public Microsoft.Xrm.Sdk.Money Aging60
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
            }
        }

        /// <summary>
        /// Shows the Aging 60 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging60_base")]
        public Microsoft.Xrm.Sdk.Money Aging60_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90")]
        public Microsoft.Xrm.Sdk.Money Aging90
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
            }
        }

        /// <summary>
        /// Shows the Aging 90 field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aging90_base")]
        public Microsoft.Xrm.Sdk.Money Aging90_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
            }
        }

        /// <summary>
        /// Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anniversary")]
        public System.Nullable<System.DateTime> Anniversary
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("anniversary");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Anniversary");
                this.SetAttributeValue("anniversary", value);
                this.OnPropertyChanged("Anniversary");
            }
        }

        /// <summary>
        /// Type the contact's annual income for use in profiling and financial analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome")]
        public Microsoft.Xrm.Sdk.Money AnnualIncome
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AnnualIncome");
                this.SetAttributeValue("annualincome", value);
                this.OnPropertyChanged("AnnualIncome");
            }
        }

        /// <summary>
        /// Shows the Annual Income field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annualincome_base")]
        public Microsoft.Xrm.Sdk.Money AnnualIncome_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annualincome_base");
            }
        }

        /// <summary>
        /// Type the name of the contact's assistant.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantname")]
        public string AssistantName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("assistantname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AssistantName");
                this.SetAttributeValue("assistantname", value);
                this.OnPropertyChanged("AssistantName");
            }
        }

        /// <summary>
        /// Type the phone number for the contact's assistant.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assistantphone")]
        public string AssistantPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("assistantphone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AssistantPhone");
                this.SetAttributeValue("assistantphone", value);
                this.OnPropertyChanged("AssistantPhone");
            }
        }

        /// <summary>
        /// Enter the contact's birthday for use in customer gift programs or other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("birthdate")]
        public System.Nullable<System.DateTime> BirthDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("birthdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BirthDate");
                this.SetAttributeValue("birthdate", value);
                this.OnPropertyChanged("BirthDate");
            }
        }

        /// <summary>
        /// AC
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ac")]
        public System.Nullable<bool> Btt_AC
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_ac");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_AC");
                this.SetAttributeValue("btt_ac", value);
                this.OnPropertyChanged("Btt_AC");
            }
        }

        /// <summary>
        /// Acceptance for address usage available
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_acceptance_addressusage")]
        public System.Nullable<bool> Btt_Acceptance_addressusage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_acceptance_addressusage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Acceptance_addressusage");
                this.SetAttributeValue("btt_acceptance_addressusage", value);
                this.OnPropertyChanged("Btt_Acceptance_addressusage");
            }
        }

        /// <summary>
        /// Acceptance for publication available
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_acceptanceforpublication")]
        public System.Nullable<bool> Btt_Acceptanceforpublication
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_acceptanceforpublication");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Acceptanceforpublication");
                this.SetAttributeValue("btt_acceptanceforpublication", value);
                this.OnPropertyChanged("Btt_Acceptanceforpublication");
            }
        }

        /// <summary>
        /// Type of activity - opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_activity_projects")]
        public System.Nullable<bool> Btt_activity_projects
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_activity_projects");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_activity_projects");
                this.SetAttributeValue("btt_activity_projects", value);
                this.OnPropertyChanged("Btt_activity_projects");
            }
        }

        /// <summary>
        /// Type of activity - Trade
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_activity_trade")]
        public System.Nullable<bool> Btt_activity_Trade
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_activity_trade");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_activity_Trade");
                this.SetAttributeValue("btt_activity_trade", value);
                this.OnPropertyChanged("Btt_activity_Trade");
            }
        }

        /// <summary>
        /// Type of activity - workmanship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_activity_workmanship")]
        public System.Nullable<bool> Btt_activity_workmanship
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_activity_workmanship");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_activity_workmanship");
                this.SetAttributeValue("btt_activity_workmanship", value);
                this.OnPropertyChanged("Btt_activity_workmanship");
            }
        }

        /// <summary>
        /// Additional notes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_additionalnotes")]
        public string Btt_Additionalnotes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_additionalnotes");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Additionalnotes");
                this.SetAttributeValue("btt_additionalnotes", value);
                this.OnPropertyChanged("Btt_Additionalnotes");
            }
        }

        /// <summary>
        /// Address (priv.): City
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_city")]
        public string Btt_address_private_city
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_city");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_city");
                this.SetAttributeValue("btt_address_private_city", value);
                this.OnPropertyChanged("Btt_address_private_city");
            }
        }

        /// <summary>
        /// Address (priv.): Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_country")]
        public string Btt_address_private_country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_country");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_country");
                this.SetAttributeValue("btt_address_private_country", value);
                this.OnPropertyChanged("Btt_address_private_country");
            }
        }

        /// <summary>
        /// Address (priv.): Fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_fax")]
        public string Btt_address_private_fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_fax");
                this.SetAttributeValue("btt_address_private_fax", value);
                this.OnPropertyChanged("Btt_address_private_fax");
            }
        }

        /// <summary>
        /// Address (priv.): Street line 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_line1")]
        public string Btt_address_private_line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_line1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_line1");
                this.SetAttributeValue("btt_address_private_line1", value);
                this.OnPropertyChanged("Btt_address_private_line1");
            }
        }

        /// <summary>
        /// Address (priv.): Street line 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_line2")]
        public string Btt_address_private_line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_line2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_line2");
                this.SetAttributeValue("btt_address_private_line2", value);
                this.OnPropertyChanged("Btt_address_private_line2");
            }
        }

        /// <summary>
        /// Address (priv.): Street line 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_line3")]
        public string Btt_address_private_line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_line3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_line3");
                this.SetAttributeValue("btt_address_private_line3", value);
                this.OnPropertyChanged("Btt_address_private_line3");
            }
        }

        /// <summary>
        /// Address (priv.): ZIP/Postal Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_postalcode")]
        public string Btt_address_private_postalcode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_postalcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_postalcode");
                this.SetAttributeValue("btt_address_private_postalcode", value);
                this.OnPropertyChanged("Btt_address_private_postalcode");
            }
        }

        /// <summary>
        /// Address (priv.): Phone
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_address_private_telephone1")]
        public string Btt_address_private_telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_address_private_telephone1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_address_private_telephone1");
                this.SetAttributeValue("btt_address_private_telephone1", value);
                this.OnPropertyChanged("Btt_address_private_telephone1");
            }
        }

        /// <summary>
        /// AHU
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ahu")]
        public System.Nullable<bool> Btt_AHU
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_ahu");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_AHU");
                this.SetAttributeValue("btt_ahu", value);
                this.OnPropertyChanged("Btt_AHU");
            }
        }

        /// <summary>
        /// ASHP
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ashp")]
        public System.Nullable<bool> Btt_ASHP
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_ashp");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ASHP");
                this.SetAttributeValue("btt_ashp", value);
                this.OnPropertyChanged("Btt_ASHP");
            }
        }

        /// <summary>
        /// Authorization Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_authorizationnumber")]
        public string btt_authorizationnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_authorizationnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_authorizationnumber");
                this.SetAttributeValue("btt_authorizationnumber", value);
                this.OnPropertyChanged("btt_authorizationnumber");
            }
        }

        /// <summary>
        /// Biomass
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_biomass_pg")]
        public System.Nullable<bool> BTT_Biomass_pg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_biomass_pg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_Biomass_pg");
                this.SetAttributeValue("btt_biomass_pg", value);
                this.OnPropertyChanged("BTT_Biomass_pg");
            }
        }

        /// <summary>
        /// Brand
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_brand")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Brand
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_brand");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Brand");
                this.SetAttributeValue("btt_brand", value);
                this.OnPropertyChanged("btt_Brand");
            }
        }

        /// <summary>
        /// Brand
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_brand")]
        public virtual btt_Brands? btt_BrandEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_brand")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Brand");
                this.SetAttributeValue("btt_brand", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Brand");
            }
        }

        /// <summary>
        /// Authorized
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_calculationprogram")]
        public System.Nullable<bool> Btt_calculationprogram
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_calculationprogram");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_calculationprogram");
                this.SetAttributeValue("btt_calculationprogram", value);
                this.OnPropertyChanged("Btt_calculationprogram");
            }
        }

        /// <summary>
        /// Centrifugal Chiller
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_centrifugalchiller")]
        public System.Nullable<bool> btt_CentrifugalChiller
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_centrifugalchiller");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CentrifugalChiller");
                this.SetAttributeValue("btt_centrifugalchiller", value);
                this.OnPropertyChanged("btt_CentrifugalChiller");
            }
        }

        /// <summary>
        /// Main Contact Partner Program
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_clubelmavantagesmember")]
        public System.Nullable<bool> btt_clubelmavantagesmember
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_clubelmavantagesmember");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_clubelmavantagesmember");
                this.SetAttributeValue("btt_clubelmavantagesmember", value);
                this.OnPropertyChanged("btt_clubelmavantagesmember");
            }
        }

        /// <summary>
        /// Unique identifier for Competitor related to Contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_competitorid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_competitorid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_competitorid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_competitorid");
                this.SetAttributeValue("btt_competitorid", value);
                this.OnPropertyChanged("btt_competitorid");
            }
        }

        /// <summary>
        /// Information about whether the contact is active.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_contactstatus")]
        public System.Nullable<bool> Btt_contactstatus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_contactstatus");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_contactstatus");
                this.SetAttributeValue("btt_contactstatus", value);
                this.OnPropertyChanged("Btt_contactstatus");
            }
        }

        /// <summary>
        /// Conventional Heating
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_conventionalheating_pg")]
        public System.Nullable<bool> BTT_ConventionalHeating_pg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_conventionalheating_pg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_ConventionalHeating_pg");
                this.SetAttributeValue("btt_conventionalheating_pg", value);
                this.OnPropertyChanged("BTT_ConventionalHeating_pg");
            }
        }

        /// <summary>
        /// Conventional Heating Standing
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_conventionalheatingstanding")]
        public System.Nullable<bool> Btt_conventionalheatingstanding
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_conventionalheatingstanding");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_conventionalheatingstanding");
                this.SetAttributeValue("btt_conventionalheatingstanding", value);
                this.OnPropertyChanged("Btt_conventionalheatingstanding");
            }
        }

        /// <summary>
        /// Conventional Heating Wall Hung
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_conventionalheatingwallhung")]
        public System.Nullable<bool> Btt_conventionalheatingwallhung
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_conventionalheatingwallhung");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_conventionalheatingwallhung");
                this.SetAttributeValue("btt_conventionalheatingwallhung", value);
                this.OnPropertyChanged("Btt_conventionalheatingwallhung");
            }
        }

        /// <summary>
        /// CRM Contact Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_crmcontactnumber")]
        public string btt_CRMContactNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_crmcontactnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CRMContactNumber");
                this.SetAttributeValue("btt_crmcontactnumber", value);
                this.OnPropertyChanged("btt_CRMContactNumber");
            }
        }

        /// <summary>
        /// Date end of cooperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_date_endofcooperation")]
        public System.Nullable<System.DateTime> Btt_Date_endofcooperation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_date_endofcooperation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Date_endofcooperation");
                this.SetAttributeValue("btt_date_endofcooperation", value);
                this.OnPropertyChanged("Btt_Date_endofcooperation");
            }
        }

        /// <summary>
        /// Date start of cooperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_date_startofcooperation")]
        public System.Nullable<System.DateTime> Btt_Date_startofcooperation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_date_startofcooperation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Date_startofcooperation");
                this.SetAttributeValue("btt_date_startofcooperation", value);
                this.OnPropertyChanged("Btt_Date_startofcooperation");
            }
        }

        /// <summary>
        /// Date of Cancellation of Subscription
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_datecancellationsubscription")]
        public System.Nullable<System.DateTime> btt_DateCancellationSubscription
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_datecancellationsubscription");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_DateCancellationSubscription");
                this.SetAttributeValue("btt_datecancellationsubscription", value);
                this.OnPropertyChanged("btt_DateCancellationSubscription");
            }
        }

        /// <summary>
        /// Date of Clicking DOI Link
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dateofclickingdoilink")]
        public System.Nullable<System.DateTime> btt_DateofClickingDOILink
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_dateofclickingdoilink");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_DateofClickingDOILink");
                this.SetAttributeValue("btt_dateofclickingdoilink", value);
                this.OnPropertyChanged("btt_DateofClickingDOILink");
            }
        }

        /// <summary>
        /// Date of Confirmation Email (DOI email)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dateofconfirmationemail")]
        public System.Nullable<System.DateTime> btt_dateofconfirmationemail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_dateofconfirmationemail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_dateofconfirmationemail");
                this.SetAttributeValue("btt_dateofconfirmationemail", value);
                this.OnPropertyChanged("btt_dateofconfirmationemail");
            }
        }

        /// <summary>
        /// Date of purchase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dateofpurchase")]
        public System.Nullable<System.DateTime> Btt_Dateofpurchase
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_dateofpurchase");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Dateofpurchase");
                this.SetAttributeValue("btt_dateofpurchase", value);
                this.OnPropertyChanged("Btt_Dateofpurchase");
            }
        }

        /// <summary>
        /// Date of Registration/Subscription
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dateofregistrationsubscription")]
        public System.Nullable<System.DateTime> btt_DateofRegistrationSubscription
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_dateofregistrationsubscription");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_DateofRegistrationSubscription");
                this.SetAttributeValue("btt_dateofregistrationsubscription", value);
                this.OnPropertyChanged("btt_DateofRegistrationSubscription");
            }
        }

        /// <summary>
        /// Decider
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisdecider")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_DMUIsDecider
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_dmuisdecider");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsDecider");
                this.SetAttributeValue("btt_dmuisdecider", value);
                this.OnPropertyChanged("BTT_DMUIsDecider");
            }
        }

        /// <summary>
        /// Decider
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisdecider")]
        public virtual Contact_BTT_DMUIsDecider? BTT_DMUIsDeciderEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_BTT_DMUIsDecider?)(EntityOptionSetEnum.GetEnum(this, "btt_dmuisdecider")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsDecider");
                this.SetAttributeValue("btt_dmuisdecider", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_DMUIsDecider");
            }
        }

        /// <summary>
        /// Gatekeeper (controls flow of information)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisgatekeeper")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_DMUIsGatekeeper
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_dmuisgatekeeper");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsGatekeeper");
                this.SetAttributeValue("btt_dmuisgatekeeper", value);
                this.OnPropertyChanged("BTT_DMUIsGatekeeper");
            }
        }

        /// <summary>
        /// Gatekeeper (controls flow of information)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisgatekeeper")]
        public virtual Contact_BTT_DMUIsGatekeeper? BTT_DMUIsGatekeeperEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_BTT_DMUIsGatekeeper?)(EntityOptionSetEnum.GetEnum(this, "btt_dmuisgatekeeper")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsGatekeeper");
                this.SetAttributeValue("btt_dmuisgatekeeper", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_DMUIsGatekeeper");
            }
        }

        /// <summary>
        /// Influencer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisinfluencer")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_DMUIsInfluencer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_dmuisinfluencer");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsInfluencer");
                this.SetAttributeValue("btt_dmuisinfluencer", value);
                this.OnPropertyChanged("BTT_DMUIsInfluencer");
            }
        }

        /// <summary>
        /// Influencer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisinfluencer")]
        public virtual Contact_BTT_DMUIsInfluencer? BTT_DMUIsInfluencerEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_BTT_DMUIsInfluencer?)(EntityOptionSetEnum.GetEnum(this, "btt_dmuisinfluencer")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsInfluencer");
                this.SetAttributeValue("btt_dmuisinfluencer", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_DMUIsInfluencer");
            }
        }

        /// <summary>
        /// Owner (if different from Buyer)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisowner")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_DMUIsOwner
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_dmuisowner");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsOwner");
                this.SetAttributeValue("btt_dmuisowner", value);
                this.OnPropertyChanged("BTT_DMUIsOwner");
            }
        }

        /// <summary>
        /// Owner (if different from Buyer)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisowner")]
        public virtual Contact_BTT_DMUIsOwner? BTT_DMUIsOwnerEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_BTT_DMUIsOwner?)(EntityOptionSetEnum.GetEnum(this, "btt_dmuisowner")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsOwner");
                this.SetAttributeValue("btt_dmuisowner", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_DMUIsOwner");
            }
        }

        /// <summary>
        /// Purchaser (buyer)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuispurchaser")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_DMUIsPurchaser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_dmuispurchaser");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsPurchaser");
                this.SetAttributeValue("btt_dmuispurchaser", value);
                this.OnPropertyChanged("BTT_DMUIsPurchaser");
            }
        }

        /// <summary>
        /// Purchaser (buyer)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuispurchaser")]
        public virtual Contact_BTT_DMUIsPurchaser? BTT_DMUIsPurchaserEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_BTT_DMUIsPurchaser?)(EntityOptionSetEnum.GetEnum(this, "btt_dmuispurchaser")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsPurchaser");
                this.SetAttributeValue("btt_dmuispurchaser", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_DMUIsPurchaser");
            }
        }

        /// <summary>
        /// User
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisuser")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_DMUIsUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_dmuisuser");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsUser");
                this.SetAttributeValue("btt_dmuisuser", value);
                this.OnPropertyChanged("BTT_DMUIsUser");
            }
        }

        /// <summary>
        /// User
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_dmuisuser")]
        public virtual Contact_BTT_DMUIsUser? BTT_DMUIsUserEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_BTT_DMUIsUser?)(EntityOptionSetEnum.GetEnum(this, "btt_dmuisuser")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_DMUIsUser");
                this.SetAttributeValue("btt_dmuisuser", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_DMUIsUser");
            }
        }

        /// <summary>
        /// Do not allow SMS
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_donotsms")]
        public System.Nullable<bool> Btt_DonotSMS
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_donotsms");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_DonotSMS");
                this.SetAttributeValue("btt_donotsms", value);
                this.OnPropertyChanged("Btt_DonotSMS");
            }
        }

        /// <summary>
        /// eAcademy Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_eacademynumber")]
        public string btt_eAcademyNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_eacademynumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_eAcademyNumber");
                this.SetAttributeValue("btt_eacademynumber", value);
                this.OnPropertyChanged("btt_eAcademyNumber");
            }
        }

        /// <summary>
        /// Electric
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_electric")]
        public System.Nullable<bool> Btt_electric
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_electric");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_electric");
                this.SetAttributeValue("btt_electric", value);
                this.OnPropertyChanged("Btt_electric");
            }
        }

        /// <summary>
        /// Electrical entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_electricalentitlement")]
        public System.Nullable<bool> Btt_Electricalentitlement
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_electricalentitlement");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Electricalentitlement");
                this.SetAttributeValue("btt_electricalentitlement", value);
                this.OnPropertyChanged("Btt_Electricalentitlement");
            }
        }

        /// <summary>
        /// Electric Heat Pump Air to Air
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_electricheatpumpairtoair")]
        public System.Nullable<bool> Btt_ElectricHeatPumpAirtoAir
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_electricheatpumpairtoair");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ElectricHeatPumpAirtoAir");
                this.SetAttributeValue("btt_electricheatpumpairtoair", value);
                this.OnPropertyChanged("Btt_ElectricHeatPumpAirtoAir");
            }
        }

        /// <summary>
        /// Electric Heat Pump Air to Water
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_electricheatpumpairtowater")]
        public System.Nullable<bool> Btt_ElectricHeatPumpAirtoWater
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_electricheatpumpairtowater");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ElectricHeatPumpAirtoWater");
                this.SetAttributeValue("btt_electricheatpumpairtowater", value);
                this.OnPropertyChanged("Btt_ElectricHeatPumpAirtoWater");
            }
        }

        /// <summary>
        /// Electric Heat Pump Exhaust-air/liquid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_electricheatpumpexhaustairliquid")]
        public System.Nullable<bool> Btt_ElectricHeatPumpExhaustairliquid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_electricheatpumpexhaustairliquid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ElectricHeatPumpExhaustairliquid");
                this.SetAttributeValue("btt_electricheatpumpexhaustairliquid", value);
                this.OnPropertyChanged("Btt_ElectricHeatPumpExhaustairliquid");
            }
        }

        /// <summary>
        /// Electric Heat Pump Ground-Source
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_electricheatpumpgroundsource")]
        public System.Nullable<bool> Btt_ElectricHeatPumpGroundSource
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_electricheatpumpgroundsource");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ElectricHeatPumpGroundSource");
                this.SetAttributeValue("btt_electricheatpumpgroundsource", value);
                this.OnPropertyChanged("Btt_ElectricHeatPumpGroundSource");
            }
        }

        /// <summary>
        /// E-Mail Acceptance for promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_emailacceptance")]
        public System.Nullable<bool> BTT_emailacceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_emailacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_emailacceptance");
                this.SetAttributeValue("btt_emailacceptance", value);
                this.OnPropertyChanged("BTT_emailacceptance");
            }
        }

        /// <summary>
        /// EWS
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ews")]
        public System.Nullable<bool> Btt_EWS
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_ews");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_EWS");
                this.SetAttributeValue("btt_ews", value);
                this.OnPropertyChanged("Btt_EWS");
            }
        }

        /// <summary>
        /// External Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_externalnumber")]
        public string btt_externalnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_externalnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_externalnumber");
                this.SetAttributeValue("btt_externalnumber", value);
                this.OnPropertyChanged("btt_externalnumber");
            }
        }

        /// <summary>
        /// Fax Acceptance for promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_faxacceptance")]
        public System.Nullable<bool> BTT_faxacceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_faxacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_faxacceptance");
                this.SetAttributeValue("btt_faxacceptance", value);
                this.OnPropertyChanged("BTT_faxacceptance");
            }
        }

        /// <summary>
        /// FCU
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_fcu")]
        public System.Nullable<bool> Btt_FCU
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_fcu");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_FCU");
                this.SetAttributeValue("btt_fcu", value);
                this.OnPropertyChanged("Btt_FCU");
            }
        }

        /// <summary>
        /// Field - boiler rooms
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_boilerrooms")]
        public System.Nullable<bool> Btt_Field_boilerrooms
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_boilerrooms");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_boilerrooms");
                this.SetAttributeValue("btt_field_boilerrooms", value);
                this.OnPropertyChanged("Btt_Field_boilerrooms");
            }
        }

        /// <summary>
        /// Field - central heating
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_centralheating")]
        public System.Nullable<bool> Btt_Field_centralheating
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_centralheating");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_centralheating");
                this.SetAttributeValue("btt_field_centralheating", value);
                this.OnPropertyChanged("Btt_Field_centralheating");
            }
        }

        /// <summary>
        /// Field - climate
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_climate")]
        public System.Nullable<bool> Btt_Field_climate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_climate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_climate");
                this.SetAttributeValue("btt_field_climate", value);
                this.OnPropertyChanged("Btt_Field_climate");
            }
        }

        /// <summary>
        /// Field - cooling systems
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_coolingsystems")]
        public System.Nullable<bool> Btt_Field_coolingsystems
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_coolingsystems");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_coolingsystems");
                this.SetAttributeValue("btt_field_coolingsystems", value);
                this.OnPropertyChanged("Btt_Field_coolingsystems");
            }
        }

        /// <summary>
        /// Field - domestic hot water
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_domestichotwater")]
        public System.Nullable<bool> Btt_Field_domestichotwater
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_domestichotwater");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_domestichotwater");
                this.SetAttributeValue("btt_field_domestichotwater", value);
                this.OnPropertyChanged("Btt_Field_domestichotwater");
            }
        }

        /// <summary>
        /// Field - heat pumps
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_heatpumps")]
        public System.Nullable<bool> Btt_Field_heatpumps
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_heatpumps");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_heatpumps");
                this.SetAttributeValue("btt_field_heatpumps", value);
                this.OnPropertyChanged("Btt_Field_heatpumps");
            }
        }

        /// <summary>
        /// Field - sewage systems
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_sewagesystems")]
        public System.Nullable<bool> Btt_Field_sewagesystems
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_sewagesystems");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_sewagesystems");
                this.SetAttributeValue("btt_field_sewagesystems", value);
                this.OnPropertyChanged("Btt_Field_sewagesystems");
            }
        }

        /// <summary>
        /// Field - solar systems
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_solarsystems")]
        public System.Nullable<bool> Btt_Field_solarsystems
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_solarsystems");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_solarsystems");
                this.SetAttributeValue("btt_field_solarsystems", value);
                this.OnPropertyChanged("Btt_Field_solarsystems");
            }
        }

        /// <summary>
        /// Field - ventilation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_field_ventilation")]
        public System.Nullable<bool> Btt_Field_ventilation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_field_ventilation");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Field_ventilation");
                this.SetAttributeValue("btt_field_ventilation", value);
                this.OnPropertyChanged("Btt_Field_ventilation");
            }
        }

        /// <summary>
        /// Formalities in progress
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_formalitiesinprogress")]
        public System.Nullable<bool> Btt_formalitiesinprogress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_formalitiesinprogress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_formalitiesinprogress");
                this.SetAttributeValue("btt_formalitiesinprogress", value);
                this.OnPropertyChanged("Btt_formalitiesinprogress");
            }
        }

        /// <summary>
        /// FSB
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_fsb")]
        public System.Nullable<bool> Btt_FSB
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_fsb");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_FSB");
                this.SetAttributeValue("btt_fsb", value);
                this.OnPropertyChanged("Btt_FSB");
            }
        }

        /// <summary>
        /// FZK (Floor Standing Solid Fuel Boiler
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_fzk")]
        public System.Nullable<bool> Btt_fzk
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_fzk");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_fzk");
                this.SetAttributeValue("btt_fzk", value);
                this.OnPropertyChanged("Btt_fzk");
            }
        }

        /// <summary>
        /// Gas boiler
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_gas")]
        public System.Nullable<bool> Btt_gas
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_gas");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_gas");
                this.SetAttributeValue("btt_gas", value);
                this.OnPropertyChanged("Btt_gas");
            }
        }

        /// <summary>
        /// GWI
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_gwi")]
        public System.Nullable<bool> Btt_GWI
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_gwi");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_GWI");
                this.SetAttributeValue("btt_gwi", value);
                this.OnPropertyChanged("Btt_GWI");
            }
        }

        /// <summary>
        /// Hard Bounces
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_hardbounces")]
        public System.Nullable<int> btt_HardBounces
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_hardbounces");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_HardBounces");
                this.SetAttributeValue("btt_hardbounces", value);
                this.OnPropertyChanged("btt_HardBounces");
            }
        }

        /// <summary>
        /// Has contract with us
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_has_contract")]
        public System.Nullable<bool> Btt_has_contract
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_has_contract");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_has_contract");
                this.SetAttributeValue("btt_has_contract", value);
                this.OnPropertyChanged("Btt_has_contract");
            }
        }

        /// <summary>
        /// Heat Distribution Other
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_heatdistributionother_pg")]
        public System.Nullable<bool> BTT_HeatDistributionOther_pg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_heatdistributionother_pg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_HeatDistributionOther_pg");
                this.SetAttributeValue("btt_heatdistributionother_pg", value);
                this.OnPropertyChanged("BTT_HeatDistributionOther_pg");
            }
        }

        /// <summary>
        /// Heating Pump with Expansion Tank
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_heatingpumpwithexpansiontank_pg")]
        public System.Nullable<bool> BTT_HeatingPumpwithExpansionTank_pg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_heatingpumpwithexpansiontank_pg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_HeatingPumpwithExpansionTank_pg");
                this.SetAttributeValue("btt_heatingpumpwithexpansiontank_pg", value);
                this.OnPropertyChanged("BTT_HeatingPumpwithExpansionTank_pg");
            }
        }

        /// <summary>
        /// HPWH
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_hpwh")]
        public System.Nullable<bool> Btt_HPWH
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_hpwh");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_HPWH");
                this.SetAttributeValue("btt_hpwh", value);
                this.OnPropertyChanged("Btt_HPWH");
            }
        }

        /// <summary>
        /// HST
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_hst")]
        public System.Nullable<bool> Btt_HST
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_hst");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_HST");
                this.SetAttributeValue("btt_hst", value);
                this.OnPropertyChanged("Btt_HST");
            }
        }

        /// <summary>
        /// Help attribute for imports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_importflag")]
        public System.Nullable<bool> Btt_Importflag
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_importflag");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Importflag");
                this.SetAttributeValue("btt_importflag", value);
                this.OnPropertyChanged("Btt_Importflag");
            }
        }

        /// <summary>
        /// INB Import
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_inbimport")]
        public System.Nullable<bool> Btt_INBImport
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_inbimport");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_INBImport");
                this.SetAttributeValue("btt_inbimport", value);
                this.OnPropertyChanged("Btt_INBImport");
            }
        }

        /// <summary>
        /// INB Local
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_inblocal")]
        public System.Nullable<bool> Btt_INBLocal
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_inblocal");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_INBLocal");
                this.SetAttributeValue("btt_inblocal", value);
                this.OnPropertyChanged("Btt_INBLocal");
            }
        }

        /// <summary>
        /// Installation leader (years)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installationleader")]
        public string Btt_installationleader
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_installationleader");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_installationleader");
                this.SetAttributeValue("btt_installationleader", value);
                this.OnPropertyChanged("Btt_installationleader");
            }
        }

        /// <summary>
        /// Installer authorization number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installerauthorizationnumber")]
        public string Btt_Installerauthorizationnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_installerauthorizationnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Installerauthorizationnumber");
                this.SetAttributeValue("btt_installerauthorizationnumber", value);
                this.OnPropertyChanged("Btt_Installerauthorizationnumber");
            }
        }

        /// <summary>
        /// Interested in planning documentation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_interested_planningdoc")]
        public System.Nullable<bool> Btt_Interested_planningdoc
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_interested_planningdoc");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Interested_planningdoc");
                this.SetAttributeValue("btt_interested_planningdoc", value);
                this.OnPropertyChanged("Btt_Interested_planningdoc");
            }
        }

        /// <summary>
        /// Interested in training
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_interested_training")]
        public System.Nullable<bool> Btt_Interested_training
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_interested_training");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Interested_training");
                this.SetAttributeValue("btt_interested_training", value);
                this.OnPropertyChanged("Btt_Interested_training");
            }
        }

        /// <summary>
        /// Job
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_jobtitle")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_JobTitle
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_jobtitle");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_JobTitle");
                this.SetAttributeValue("btt_jobtitle", value);
                this.OnPropertyChanged("Btt_JobTitle");
            }
        }

        /// <summary>
        /// Job
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_jobtitle")]
        public virtual Contact_Btt_JobTitle? Btt_JobTitleEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Btt_JobTitle?)(EntityOptionSetEnum.GetEnum(this, "btt_jobtitle")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_JobTitle");
                this.SetAttributeValue("btt_jobtitle", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_JobTitle");
            }
        }

        /// <summary>
        /// Unique identifier for User associated with Contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_lastappointmentcompletedbyid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_LastAppointmentCompletedById
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_lastappointmentcompletedbyid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_LastAppointmentCompletedById");
                this.SetAttributeValue("btt_lastappointmentcompletedbyid", value);
                this.OnPropertyChanged("btt_LastAppointmentCompletedById");
            }
        }

        /// <summary>
        /// Condensing (floor)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_pgrelevancecondensingfloor")]
        public System.Nullable<bool> Btt_PGRelevanceCondensingFloor
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_pgrelevancecondensingfloor");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PGRelevanceCondensingFloor");
                this.SetAttributeValue("btt_pgrelevancecondensingfloor", value);
                this.OnPropertyChanged("Btt_PGRelevanceCondensingFloor");
            }
        }

        /// <summary>
        /// Condensing (wall)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_pgrelevancecondensingwall")]
        public System.Nullable<bool> Btt_PGRelevanceCondensingWall
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_pgrelevancecondensingwall");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PGRelevanceCondensingWall");
                this.SetAttributeValue("btt_pgrelevancecondensingwall", value);
                this.OnPropertyChanged("Btt_PGRelevanceCondensingWall");
            }
        }

        /// <summary>
        /// Phone Acceptance for promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_phoneacceptance")]
        public System.Nullable<bool> BTT_phoneacceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_phoneacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_phoneacceptance");
                this.SetAttributeValue("btt_phoneacceptance", value);
                this.OnPropertyChanged("BTT_phoneacceptance");
            }
        }

        /// <summary>
        /// Private address acceptance needed
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_privateaddressacceptance")]
        public System.Nullable<bool> BTT_PrivateAddressAcceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_privateaddressacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_PrivateAddressAcceptance");
                this.SetAttributeValue("btt_privateaddressacceptance", value);
                this.OnPropertyChanged("BTT_PrivateAddressAcceptance");
            }
        }

        /// <summary>
        /// Customer's consent is valid for all personal data provided by the customer to our enterprise, also for private address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_privatedataacceptance")]
        public System.Nullable<bool> BTT_privatedataacceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_privatedataacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_privatedataacceptance");
                this.SetAttributeValue("btt_privatedataacceptance", value);
                this.OnPropertyChanged("BTT_privatedataacceptance");
            }
        }

        /// <summary>
        /// Province
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_province")]
        public Microsoft.Xrm.Sdk.EntityReference btt_Province
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_province");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Province");
                this.SetAttributeValue("btt_province", value);
                this.OnPropertyChanged("btt_Province");
            }
        }

        /// <summary>
        /// Registration
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_registration")]
        public System.Nullable<bool> Btt_Registration
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_registration");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Registration");
                this.SetAttributeValue("btt_registration", value);
                this.OnPropertyChanged("Btt_Registration");
            }
        }

        /// <summary>
        /// Junkers Renewables Adviser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_renewablesadviser")]
        public System.Nullable<bool> Btt_RenewablesAdviser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_renewablesadviser");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_RenewablesAdviser");
                this.SetAttributeValue("btt_renewablesadviser", value);
                this.OnPropertyChanged("Btt_RenewablesAdviser");
            }
        }

        /// <summary>
        /// Unique identifier for Contact associated with Contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_replacementcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_replacementcontactid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_replacementcontactid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_replacementcontactid");
                this.SetAttributeValue("btt_replacementcontactid", value);
                this.OnPropertyChanged("btt_replacementcontactid");
            }
        }

        /// <summary>
        /// Receives all info
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsibleall")]
        public System.Nullable<bool> Btt_ResponsibleAll
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_responsibleall");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ResponsibleAll");
                this.SetAttributeValue("btt_responsibleall", value);
                this.OnPropertyChanged("Btt_ResponsibleAll");
            }
        }

        /// <summary>
        /// Responsible for Controlling
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsiblecontrolling")]
        public System.Nullable<bool> Btt_ResponsibleControlling
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_responsiblecontrolling");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ResponsibleControlling");
                this.SetAttributeValue("btt_responsiblecontrolling", value);
                this.OnPropertyChanged("Btt_ResponsibleControlling");
            }
        }

        /// <summary>
        /// Responsible for Management
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsiblemanagement")]
        public System.Nullable<bool> Btt_ResponsibleManagement
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_responsiblemanagement");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ResponsibleManagement");
                this.SetAttributeValue("btt_responsiblemanagement", value);
                this.OnPropertyChanged("Btt_ResponsibleManagement");
            }
        }

        /// <summary>
        /// Responsible for Purchasing
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsiblepurchasing")]
        public System.Nullable<bool> Btt_ResponsiblePurchasing
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_responsiblepurchasing");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ResponsiblePurchasing");
                this.SetAttributeValue("btt_responsiblepurchasing", value);
                this.OnPropertyChanged("Btt_ResponsiblePurchasing");
            }
        }

        /// <summary>
        /// Responsible for Sales
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsiblesales")]
        public System.Nullable<bool> Btt_ResponsibleSales
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_responsiblesales");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ResponsibleSales");
                this.SetAttributeValue("btt_responsiblesales", value);
                this.OnPropertyChanged("Btt_ResponsibleSales");
            }
        }

        /// <summary>
        /// Responsible for Service
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsibleservice")]
        public System.Nullable<bool> Btt_ResponsibleService
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_responsibleservice");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ResponsibleService");
                this.SetAttributeValue("btt_responsibleservice", value);
                this.OnPropertyChanged("Btt_ResponsibleService");
            }
        }

        /// <summary>
        /// Unique identifier for User associated with Contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsibleservice_userid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_responsibleservice_userid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_responsibleservice_userid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_responsibleservice_userid");
                this.SetAttributeValue("btt_responsibleservice_userid", value);
                this.OnPropertyChanged("btt_responsibleservice_userid");
            }
        }

        /// <summary>
        /// Role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role")]
        public string Btt_role
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_role");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_role");
                this.SetAttributeValue("btt_role", value);
                this.OnPropertyChanged("Btt_role");
            }
        }

        /// <summary>
        /// Role authorized installer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_authorizedinstaller")]
        public System.Nullable<bool> Btt_Role_authorizedinstaller
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_authorizedinstaller");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_authorizedinstaller");
                this.SetAttributeValue("btt_role_authorizedinstaller", value);
                this.OnPropertyChanged("Btt_Role_authorizedinstaller");
            }
        }

        /// <summary>
        /// Role authorized point of sale employee
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_authorizedpointofsaleemployee")]
        public System.Nullable<bool> Btt_Role_authorizedpointofsaleemployee
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_authorizedpointofsaleemployee");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_authorizedpointofsaleemployee");
                this.SetAttributeValue("btt_role_authorizedpointofsaleemployee", value);
                this.OnPropertyChanged("Btt_Role_authorizedpointofsaleemployee");
            }
        }

        /// <summary>
        /// Role authorized serviceman
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_authorizedserviceman")]
        public System.Nullable<bool> Btt_Role_authorizedserviceman
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_authorizedserviceman");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_authorizedserviceman");
                this.SetAttributeValue("btt_role_authorizedserviceman", value);
                this.OnPropertyChanged("Btt_Role_authorizedserviceman");
            }
        }

        /// <summary>
        /// Role authorized trade partner employee
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_authorizedtradepartneremployee")]
        public System.Nullable<bool> Btt_Role_authorizedtradepartneremployee
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_authorizedtradepartneremployee");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_authorizedtradepartneremployee");
                this.SetAttributeValue("btt_role_authorizedtradepartneremployee", value);
                this.OnPropertyChanged("Btt_Role_authorizedtradepartneremployee");
            }
        }

        /// <summary>
        /// Role former authorized installer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_formerauthorizedinstaller")]
        public System.Nullable<bool> Btt_Role_formerauthorizedinstaller
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_formerauthorizedinstaller");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_formerauthorizedinstaller");
                this.SetAttributeValue("btt_role_formerauthorizedinstaller", value);
                this.OnPropertyChanged("Btt_Role_formerauthorizedinstaller");
            }
        }

        /// <summary>
        /// Role former authorized serviceman
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_formerauthorizedserviceman")]
        public System.Nullable<bool> Btt_Role_formerauthorizedserviceman
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_formerauthorizedserviceman");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_formerauthorizedserviceman");
                this.SetAttributeValue("btt_role_formerauthorizedserviceman", value);
                this.OnPropertyChanged("Btt_Role_formerauthorizedserviceman");
            }
        }

        /// <summary>
        /// Role installer with promise contract
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_installerwithpromisecontract")]
        public System.Nullable<bool> Btt_Role_installerwithpromisecontract
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_installerwithpromisecontract");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_installerwithpromisecontract");
                this.SetAttributeValue("btt_role_installerwithpromisecontract", value);
                this.OnPropertyChanged("Btt_Role_installerwithpromisecontract");
            }
        }

        /// <summary>
        /// Role other
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_other")]
        public System.Nullable<bool> Btt_Role_other
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_other");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_other");
                this.SetAttributeValue("btt_role_other", value);
                this.OnPropertyChanged("Btt_Role_other");
            }
        }

        /// <summary>
        /// Role planner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_planner")]
        public System.Nullable<bool> Btt_Role_planner
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_planner");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_planner");
                this.SetAttributeValue("btt_role_planner", value);
                this.OnPropertyChanged("Btt_Role_planner");
            }
        }

        /// <summary>
        /// Role potential authorized installer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_potentialauthorizedinstaller")]
        public System.Nullable<bool> Btt_Role_potentialauthorizedinstaller
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_potentialauthorizedinstaller");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Role_potentialauthorizedinstaller");
                this.SetAttributeValue("btt_role_potentialauthorizedinstaller", value);
                this.OnPropertyChanged("Btt_Role_potentialauthorizedinstaller");
            }
        }

        /// <summary>
        /// Role Picklist
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_roles")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_roles
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_roles");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_roles");
                this.SetAttributeValue("btt_roles", value);
                this.OnPropertyChanged("Btt_roles");
            }
        }

        /// <summary>
        /// Role Picklist
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_roles")]
        public virtual Contact_Btt_roles? Btt_rolesEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Btt_roles?)(EntityOptionSetEnum.GetEnum(this, "btt_roles")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_roles");
                this.SetAttributeValue("btt_roles", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_roles");
            }
        }

        /// <summary>
        /// Screw Chiller
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_screwchiller")]
        public System.Nullable<bool> btt_ScrewChiller
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_screwchiller");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_ScrewChiller");
                this.SetAttributeValue("btt_screwchiller", value);
                this.OnPropertyChanged("btt_ScrewChiller");
            }
        }

        /// <summary>
        /// Serviceman authorization number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_servicemanauthorizationnumber")]
        public string Btt_Servicemanauthorizationnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_servicemanauthorizationnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Servicemanauthorizationnumber");
                this.SetAttributeValue("btt_servicemanauthorizationnumber", value);
                this.OnPropertyChanged("Btt_Servicemanauthorizationnumber");
            }
        }

        /// <summary>
        /// Size
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_size")]
        public string Btt_Size
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_size");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Size");
                this.SetAttributeValue("btt_size", value);
                this.OnPropertyChanged("Btt_Size");
            }
        }

        /// <summary>
        /// SMS Acceptance for promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_smsacceptance")]
        public System.Nullable<bool> btt_smsacceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_smsacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_smsacceptance");
                this.SetAttributeValue("btt_smsacceptance", value);
                this.OnPropertyChanged("btt_smsacceptance");
            }
        }

        /// <summary>
        /// Soft Bounces
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_softbounces")]
        public System.Nullable<int> btt_SoftBounces
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_softbounces");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_SoftBounces");
                this.SetAttributeValue("btt_softbounces", value);
                this.OnPropertyChanged("btt_SoftBounces");
            }
        }

        /// <summary>
        /// Solar Photovoltaic
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_solarphotovoltaic_pg")]
        public System.Nullable<bool> BTT_SolarPhotovoltaic_pg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_solarphotovoltaic_pg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_SolarPhotovoltaic_pg");
                this.SetAttributeValue("btt_solarphotovoltaic_pg", value);
                this.OnPropertyChanged("BTT_SolarPhotovoltaic_pg");
            }
        }

        /// <summary>
        /// Solar Thermic
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_solarthermic_pg")]
        public System.Nullable<bool> BTT_SolarThermic_pg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_solarthermic_pg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_SolarThermic_pg");
                this.SetAttributeValue("btt_solarthermic_pg", value);
                this.OnPropertyChanged("BTT_SolarThermic_pg");
            }
        }

        /// <summary>
        /// Stamp
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_stamp")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Stamp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_stamp");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Stamp");
                this.SetAttributeValue("btt_stamp", value);
                this.OnPropertyChanged("Btt_Stamp");
            }
        }

        /// <summary>
        /// Stamp
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_stamp")]
        public virtual Contact_Btt_Stamp? Btt_StampEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Btt_Stamp?)(EntityOptionSetEnum.GetEnum(this, "btt_stamp")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Stamp");
                this.SetAttributeValue("btt_stamp", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Stamp");
            }
        }

        /// <summary>
        /// STS
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_sts")]
        public System.Nullable<bool> Btt_STS
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_sts");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_STS");
                this.SetAttributeValue("btt_sts", value);
                this.OnPropertyChanged("Btt_STS");
            }
        }

        /// <summary>
        /// Junkers Technical Advisor
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_technicaladvisor")]
        public System.Nullable<bool> Btt_TechnicalAdvisor
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_technicaladvisor");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TechnicalAdvisor");
                this.SetAttributeValue("btt_technicaladvisor", value);
                this.OnPropertyChanged("Btt_TechnicalAdvisor");
            }
        }

        /// <summary>
        /// Do not allow Trade Mailing
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trademailing")]
        public System.Nullable<bool> Btt_tradeMailing
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trademailing");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_tradeMailing");
                this.SetAttributeValue("btt_trademailing", value);
                this.OnPropertyChanged("Btt_tradeMailing");
            }
        }

        /// <summary>
        /// Unique identifier for Training Location associated with Contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_traininglocationid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_traininglocationid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_traininglocationid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_traininglocationid");
                this.SetAttributeValue("btt_traininglocationid", value);
                this.OnPropertyChanged("btt_traininglocationid");
            }
        }

        /// <summary>
        /// Can be triggerd with  price.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_price")]
        public System.Nullable<bool> Btt_trigger_price
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_price");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_price");
                this.SetAttributeValue("btt_trigger_price", value);
                this.OnPropertyChanged("Btt_trigger_price");
            }
        }

        /// <summary>
        /// Can be triggerd with product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_product")]
        public System.Nullable<bool> Btt_trigger_product
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_product");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_product");
                this.SetAttributeValue("btt_trigger_product", value);
                this.OnPropertyChanged("Btt_trigger_product");
            }
        }

        /// <summary>
        /// Can be triggerd with  relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_relationship")]
        public System.Nullable<bool> Btt_trigger_relationship
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_relationship");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_relationship");
                this.SetAttributeValue("btt_trigger_relationship", value);
                this.OnPropertyChanged("Btt_trigger_relationship");
            }
        }

        /// <summary>
        /// Can be triggerd with  service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_service")]
        public System.Nullable<bool> Btt_trigger_service
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_service");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_service");
                this.SetAttributeValue("btt_trigger_service", value);
                this.OnPropertyChanged("Btt_trigger_service");
            }
        }

        /// <summary>
        /// Can be triggerd with  technical support.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_trigger_technicalsupport")]
        public System.Nullable<bool> Btt_trigger_technicalsupport
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_trigger_technicalsupport");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_trigger_technicalsupport");
                this.SetAttributeValue("btt_trigger_technicalsupport", value);
                this.OnPropertyChanged("Btt_trigger_technicalsupport");
            }
        }

        /// <summary>
        /// TT brand
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttbrand")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_TTbrand
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_ttbrand");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TTbrand");
                this.SetAttributeValue("btt_ttbrand", value);
                this.OnPropertyChanged("Btt_TTbrand");
            }
        }

        /// <summary>
        /// TT brand
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttbrand")]
        public virtual Contact_Btt_TTbrand? Btt_TTbrandEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_Btt_TTbrand?)(EntityOptionSetEnum.GetEnum(this, "btt_ttbrand")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TTbrand");
                this.SetAttributeValue("btt_ttbrand", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_TTbrand");
            }
        }

        /// <summary>
        /// Underfloor Heating
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_underfloorheating_pg")]
        public System.Nullable<bool> BTT_UnderfloorHeating_pg
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_underfloorheating_pg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_UnderfloorHeating_pg");
                this.SetAttributeValue("btt_underfloorheating_pg", value);
                this.OnPropertyChanged("BTT_UnderfloorHeating_pg");
            }
        }

        /// <summary>
        /// Usage Auto CAD
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_usage_autocad")]
        public System.Nullable<bool> Btt_Usage_AutoCAD
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_usage_autocad");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Usage_AutoCAD");
                this.SetAttributeValue("btt_usage_autocad", value);
                this.OnPropertyChanged("Btt_Usage_AutoCAD");
            }
        }

        /// <summary>
        /// To use (or not) the private address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_useprivateaddress")]
        public System.Nullable<bool> Btt_useprivateaddress
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_useprivateaddress");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_useprivateaddress");
                this.SetAttributeValue("btt_useprivateaddress", value);
                this.OnPropertyChanged("Btt_useprivateaddress");
            }
        }

        /// <summary>
        /// WB
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_wb")]
        public System.Nullable<bool> Btt_WB
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_wb");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_WB");
                this.SetAttributeValue("btt_wb", value);
                this.OnPropertyChanged("Btt_WB");
            }
        }

        /// <summary>
        /// WSHP
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_wshp")]
        public System.Nullable<bool> Btt_WSHP
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_wshp");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_WSHP");
                this.SetAttributeValue("btt_wshp", value);
                this.OnPropertyChanged("Btt_WSHP");
            }
        }

        /// <summary>
        /// Type a second business phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("business2")]
        public string Business2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("business2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Business2");
                this.SetAttributeValue("business2", value);
                this.OnPropertyChanged("Business2");
            }
        }

        /// <summary>
        /// Stores Image of the Business Card
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesscard")]
        public string BusinessCard
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("businesscard");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BusinessCard");
                this.SetAttributeValue("businesscard", value);
                this.OnPropertyChanged("BusinessCard");
            }
        }

        /// <summary>
        /// Stores Business Card Control Properties.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesscardattributes")]
        public string BusinessCardAttributes
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("businesscardattributes");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BusinessCardAttributes");
                this.SetAttributeValue("businesscardattributes", value);
                this.OnPropertyChanged("BusinessCardAttributes");
            }
        }

        /// <summary>
        /// Type a callback phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callback")]
        public string Callback
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("callback");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Callback");
                this.SetAttributeValue("callback", value);
                this.OnPropertyChanged("Callback");
            }
        }

        /// <summary>
        /// Type the names of the contact's children for reference in communications and client programs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childrensnames")]
        public string ChildrensNames
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("childrensnames");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ChildrensNames");
                this.SetAttributeValue("childrensnames", value);
                this.OnPropertyChanged("ChildrensNames");
            }
        }

        /// <summary>
        /// Type the company phone of the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("company")]
        public string Company
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("company");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Company");
                this.SetAttributeValue("company", value);
                this.OnPropertyChanged("Company");
            }
        }

        /// <summary>
        /// Unique identifier of the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public System.Nullable<System.Guid> ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ContactId");
                this.SetAttributeValue("contactid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContactId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
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
                this.ContactId = value;
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
        /// Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
        public Microsoft.Xrm.Sdk.Money CreditLimit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreditLimit");
                this.SetAttributeValue("creditlimit", value);
                this.OnPropertyChanged("CreditLimit");
            }
        }

        /// <summary>
        /// Shows the Credit Limit field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit_base")]
        public Microsoft.Xrm.Sdk.Money CreditLimit_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
            }
        }

        /// <summary>
        /// Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditonhold")]
        public System.Nullable<bool> CreditOnHold
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreditOnHold");
                this.SetAttributeValue("creditonhold", value);
                this.OnPropertyChanged("CreditOnHold");
            }
        }

        /// <summary>
        /// Select the size of the contact's company for segmentation and reporting purposes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerSizeCode");
                this.SetAttributeValue("customersizecode", value);
                this.OnPropertyChanged("CustomerSizeCode");
            }
        }

        /// <summary>
        /// Select the size of the contact's company for segmentation and reporting purposes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
        public virtual Contact_CustomerSizeCode? CustomerSizeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_CustomerSizeCode?)(EntityOptionSetEnum.GetEnum(this, "customersizecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerSizeCode");
                this.SetAttributeValue("customersizecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("CustomerSizeCode");
            }
        }

        /// <summary>
        /// Select the category that best describes the relationship between the contact and your organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerTypeCode");
                this.SetAttributeValue("customertypecode", value);
                this.OnPropertyChanged("CustomerTypeCode");
            }
        }

        /// <summary>
        /// Select the category that best describes the relationship between the contact and your organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
        public virtual Contact_CustomerTypeCode? CustomerTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_CustomerTypeCode?)(EntityOptionSetEnum.GetEnum(this, "customertypecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerTypeCode");
                this.SetAttributeValue("customertypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("CustomerTypeCode");
            }
        }

        /// <summary>
        /// Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultpricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DefaultPriceLevelId");
                this.SetAttributeValue("defaultpricelevelid", value);
                this.OnPropertyChanged("DefaultPriceLevelId");
            }
        }

        /// <summary>
        /// Type the department or business unit where the contact works in the parent company or business.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("department")]
        public string Department
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("department");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Department");
                this.SetAttributeValue("department", value);
                this.OnPropertyChanged("Department");
            }
        }

        /// <summary>
        /// Type additional information to describe the contact, such as an excerpt from the company's website.
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
        /// Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
        public System.Nullable<bool> DoNotBulkEMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotBulkEMail");
                this.SetAttributeValue("donotbulkemail", value);
                this.OnPropertyChanged("DoNotBulkEMail");
            }
        }

        /// <summary>
        /// Select whether the contact accepts bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the letters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkpostalmail")]
        public System.Nullable<bool> DoNotBulkPostalMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotBulkPostalMail");
                this.SetAttributeValue("donotbulkpostalmail", value);
                this.OnPropertyChanged("DoNotBulkPostalMail");
            }
        }

        /// <summary>
        /// Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotEMail");
                this.SetAttributeValue("donotemail", value);
                this.OnPropertyChanged("DoNotEMail");
            }
        }

        /// <summary>
        /// Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotFax");
                this.SetAttributeValue("donotfax", value);
                this.OnPropertyChanged("DoNotFax");
            }
        }

        /// <summary>
        /// Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotPhone");
                this.SetAttributeValue("donotphone", value);
                this.OnPropertyChanged("DoNotPhone");
            }
        }

        /// <summary>
        /// Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotPostalMail");
                this.SetAttributeValue("donotpostalmail", value);
                this.OnPropertyChanged("DoNotPostalMail");
            }
        }

        /// <summary>
        /// Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
        public System.Nullable<bool> DoNotSendMM
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotSendMM");
                this.SetAttributeValue("donotsendmm", value);
                this.OnPropertyChanged("DoNotSendMM");
            }
        }

        /// <summary>
        /// Select the contact's highest level of education for use in segmentation and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue EducationCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("educationcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EducationCode");
                this.SetAttributeValue("educationcode", value);
                this.OnPropertyChanged("EducationCode");
            }
        }

        /// <summary>
        /// Select the contact's highest level of education for use in segmentation and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("educationcode")]
        public virtual Contact_EducationCode? EducationCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_EducationCode?)(EntityOptionSetEnum.GetEnum(this, "educationcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EducationCode");
                this.SetAttributeValue("educationcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("EducationCode");
            }
        }

        /// <summary>
        /// Type the primary email address for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
        public string EMailAddress1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("emailaddress1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress1");
                this.SetAttributeValue("emailaddress1", value);
                this.OnPropertyChanged("EMailAddress1");
            }
        }

        /// <summary>
        /// Type the secondary email address for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
        public string EMailAddress2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("emailaddress2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress2");
                this.SetAttributeValue("emailaddress2", value);
                this.OnPropertyChanged("EMailAddress2");
            }
        }

        /// <summary>
        /// Type an alternate email address for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
        public string EMailAddress3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("emailaddress3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress3");
                this.SetAttributeValue("emailaddress3", value);
                this.OnPropertyChanged("EMailAddress3");
            }
        }

        /// <summary>
        /// Type the employee ID or number for the contact for reference in orders, service cases, or other communications with the contact's organization.
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
        /// Identifier for an external user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("externaluseridentifier")]
        public string ExternalUserIdentifier
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("externaluseridentifier");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ExternalUserIdentifier");
                this.SetAttributeValue("externaluseridentifier", value);
                this.OnPropertyChanged("ExternalUserIdentifier");
            }
        }

        /// <summary>
        /// Select the marital status of the contact for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FamilyStatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("familystatuscode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FamilyStatusCode");
                this.SetAttributeValue("familystatuscode", value);
                this.OnPropertyChanged("FamilyStatusCode");
            }
        }

        /// <summary>
        /// Select the marital status of the contact for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("familystatuscode")]
        public virtual Contact_FamilyStatusCode? FamilyStatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_FamilyStatusCode?)(EntityOptionSetEnum.GetEnum(this, "familystatuscode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FamilyStatusCode");
                this.SetAttributeValue("familystatuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("FamilyStatusCode");
            }
        }

        /// <summary>
        /// Type the fax number for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
        public string Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("fax");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Fax");
                this.SetAttributeValue("fax", value);
                this.OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        /// Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
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
        /// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
        public System.Nullable<bool> FollowEmail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("followemail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FollowEmail");
                this.SetAttributeValue("followemail", value);
                this.OnPropertyChanged("FollowEmail");
            }
        }

        /// <summary>
        /// Type the URL for the contact's FTP site to enable users to access data and share documents.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
        public string FtpSiteUrl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ftpsiteurl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FtpSiteUrl");
                this.SetAttributeValue("ftpsiteurl", value);
                this.OnPropertyChanged("FtpSiteUrl");
            }
        }

        /// <summary>
        /// Combines and shows the contact's first and last names so that the full name can be displayed in views and reports.
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
        /// Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
        public Microsoft.Xrm.Sdk.OptionSetValue GenderCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("gendercode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("GenderCode");
                this.SetAttributeValue("gendercode", value);
                this.OnPropertyChanged("GenderCode");
            }
        }

        /// <summary>
        /// Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gendercode")]
        public virtual Contact_GenderCode? GenderCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_GenderCode?)(EntityOptionSetEnum.GetEnum(this, "gendercode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("GenderCode");
                this.SetAttributeValue("gendercode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("GenderCode");
            }
        }

        /// <summary>
        /// Type the passport number or other government ID for the contact for use in documents or reports.
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
        /// Select whether the contact has any children for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
        public Microsoft.Xrm.Sdk.OptionSetValue HasChildrenCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("haschildrencode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("HasChildrenCode");
                this.SetAttributeValue("haschildrencode", value);
                this.OnPropertyChanged("HasChildrenCode");
            }
        }

        /// <summary>
        /// Select whether the contact has any children for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("haschildrencode")]
        public virtual Contact_HasChildrenCode? HasChildrenCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_HasChildrenCode?)(EntityOptionSetEnum.GetEnum(this, "haschildrencode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("HasChildrenCode");
                this.SetAttributeValue("haschildrencode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("HasChildrenCode");
            }
        }

        /// <summary>
        /// Type a second home phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("home2")]
        public string Home2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("home2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Home2");
                this.SetAttributeValue("home2", value);
                this.OnPropertyChanged("Home2");
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
        /// Select whether the contact exists in a separate accounting or other system, such as Microsoft Dynamics GP or another ERP database, for use in integration processes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbackofficecustomer")]
        public System.Nullable<bool> IsBackofficeCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isbackofficecustomer");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IsBackofficeCustomer");
                this.SetAttributeValue("isbackofficecustomer", value);
                this.OnPropertyChanged("IsBackofficeCustomer");
            }
        }

        /// <summary>
        /// Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
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
        /// Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
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
        /// Shows the date when the contact was last included in a marketing campaign or quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
        public System.Nullable<System.DateTime> LastUsedInCampaign
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastUsedInCampaign");
                this.SetAttributeValue("lastusedincampaign", value);
                this.OnPropertyChanged("LastUsedInCampaign");
            }
        }

        /// <summary>
        /// Select the primary marketing source that directed the contact to your organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LeadSourceCode");
                this.SetAttributeValue("leadsourcecode", value);
                this.OnPropertyChanged("LeadSourceCode");
            }
        }

        /// <summary>
        /// Select the primary marketing source that directed the contact to your organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
        public virtual Contact_LeadSourceCode? LeadSourceCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_LeadSourceCode?)(EntityOptionSetEnum.GetEnum(this, "leadsourcecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LeadSourceCode");
                this.SetAttributeValue("leadsourcecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("LeadSourceCode");
            }
        }

        /// <summary>
        /// Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managername")]
        public string ManagerName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("managername");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ManagerName");
                this.SetAttributeValue("managername", value);
                this.OnPropertyChanged("ManagerName");
            }
        }

        /// <summary>
        /// Type the phone number for the contact's manager.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerphone")]
        public string ManagerPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("managerphone");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ManagerPhone");
                this.SetAttributeValue("managerphone", value);
                this.OnPropertyChanged("ManagerPhone");
            }
        }

        /// <summary>
        /// Whether is only for marketing
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketingonly")]
        public System.Nullable<bool> MarketingOnly
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("marketingonly");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MarketingOnly");
                this.SetAttributeValue("marketingonly", value);
                this.OnPropertyChanged("MarketingOnly");
            }
        }

        /// <summary>
        /// Unique identifier of the master contact for merge.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        public Microsoft.Xrm.Sdk.EntityReference MasterId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
            }
        }

        /// <summary>
        /// Shows whether the account has been merged with a master contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
        public System.Nullable<bool> Merged
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("merged");
            }
        }

        /// <summary>
        /// Type the contact's middle name or initial to make sure the contact is addressed correctly.
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
        /// Type the mobile phone number for the contact.
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
        /// Describes whether contact is opted out or not
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
        /// Whether or not the contact belongs to the associated account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_orgchangestatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue msdyn_orgchangestatus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_orgchangestatus");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msdyn_orgchangestatus");
                this.SetAttributeValue("msdyn_orgchangestatus", value);
                this.OnPropertyChanged("msdyn_orgchangestatus");
            }
        }

        /// <summary>
        /// Whether or not the contact belongs to the associated account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_orgchangestatus")]
        public virtual Contact_msdyn_orgchangestatus? msdyn_orgchangestatusEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_msdyn_orgchangestatus?)(EntityOptionSetEnum.GetEnum(this, "msdyn_orgchangestatus")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msdyn_orgchangestatus");
                this.SetAttributeValue("msdyn_orgchangestatus", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("msdyn_orgchangestatus");
            }
        }

        /// <summary>
        /// Type the contact's nickname.
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
        /// Type the number of children the contact has for reference in follow-up phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofchildren")]
        public System.Nullable<int> NumberOfChildren
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("numberofchildren");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("NumberOfChildren");
                this.SetAttributeValue("numberofchildren", value);
                this.OnPropertyChanged("NumberOfChildren");
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
        /// Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OriginatingLeadId");
                this.SetAttributeValue("originatingleadid", value);
                this.OnPropertyChanged("OriginatingLeadId");
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
        /// Unique identifier of the business unit that owns the contact.
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
        /// Unique identifier of the team who owns the contact.
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
        /// Unique identifier of the user who owns the contact.
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
        /// Type the pager number for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
        public string Pager
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("pager");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Pager");
                this.SetAttributeValue("pager", value);
                this.OnPropertyChanged("Pager");
            }
        }

        /// <summary>
        /// Unique identifier of the parent contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid");
            }
        }

        /// <summary>
        /// Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentCustomerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcustomerid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentCustomerId");
                this.SetAttributeValue("parentcustomerid", value);
                this.OnPropertyChanged("ParentCustomerId");
            }
        }

        /// <summary>
        /// Shows whether the contact participates in workflow rules.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParticipatesInWorkflow");
                this.SetAttributeValue("participatesinworkflow", value);
                this.OnPropertyChanged("ParticipatesInWorkflow");
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
        public virtual Contact_PaymentTermsCode? PaymentTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_PaymentTermsCode?)(EntityOptionSetEnum.GetEnum(this, "paymenttermscode")));
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
        /// Select the preferred day of the week for service appointments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAppointmentDayCode");
                this.SetAttributeValue("preferredappointmentdaycode", value);
                this.OnPropertyChanged("PreferredAppointmentDayCode");
            }
        }

        /// <summary>
        /// Select the preferred day of the week for service appointments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmentdaycode")]
        public virtual Contact_PreferredAppointmentDayCode? PreferredAppointmentDayCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_PreferredAppointmentDayCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmentdaycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAppointmentDayCode");
                this.SetAttributeValue("preferredappointmentdaycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PreferredAppointmentDayCode");
            }
        }

        /// <summary>
        /// Select the preferred time of day for service appointments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAppointmentTimeCode");
                this.SetAttributeValue("preferredappointmenttimecode", value);
                this.OnPropertyChanged("PreferredAppointmentTimeCode");
            }
        }

        /// <summary>
        /// Select the preferred time of day for service appointments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredappointmenttimecode")]
        public virtual Contact_PreferredAppointmentTimeCode? PreferredAppointmentTimeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_PreferredAppointmentTimeCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmenttimecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredAppointmentTimeCode");
                this.SetAttributeValue("preferredappointmenttimecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PreferredAppointmentTimeCode");
            }
        }

        /// <summary>
        /// Select the preferred method of contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredContactMethodCode");
                this.SetAttributeValue("preferredcontactmethodcode", value);
                this.OnPropertyChanged("PreferredContactMethodCode");
            }
        }

        /// <summary>
        /// Select the preferred method of contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
        public virtual Contact_PreferredContactMethodCode? PreferredContactMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_PreferredContactMethodCode?)(EntityOptionSetEnum.GetEnum(this, "preferredcontactmethodcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredContactMethodCode");
                this.SetAttributeValue("preferredcontactmethodcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("PreferredContactMethodCode");
            }
        }

        /// <summary>
        /// Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredequipmentid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredEquipmentId");
                this.SetAttributeValue("preferredequipmentid", value);
                this.OnPropertyChanged("PreferredEquipmentId");
            }
        }

        /// <summary>
        /// Choose the contact's preferred service to make sure services are scheduled correctly for the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredserviceid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredServiceId");
                this.SetAttributeValue("preferredserviceid", value);
                this.OnPropertyChanged("PreferredServiceId");
            }
        }

        /// <summary>
        /// Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredSystemUserId");
                this.SetAttributeValue("preferredsystemuserid", value);
                this.OnPropertyChanged("PreferredSystemUserId");
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
        /// bounce
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_bounce")]
        public System.Nullable<bool> rbtt_bounce
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_bounce");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_bounce");
                this.SetAttributeValue("rbtt_bounce", value);
                this.OnPropertyChanged("rbtt_bounce");
            }
        }

        /// <summary>
        /// This is the unique identifier Bosch Worldwide for the contact person. This ID must be linked to the CIAM tool
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_ciamid")]
        public string rbtt_CIAMID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_ciamid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_CIAMID");
                this.SetAttributeValue("rbtt_ciamid", value);
                this.OnPropertyChanged("rbtt_CIAMID");
            }
        }

        /// <summary>
        /// Unique identifier for System Registration associated with Contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_contact_mappingid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Contact_MappingId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_contact_mappingid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Contact_MappingId");
                this.SetAttributeValue("rbtt_contact_mappingid", value);
                this.OnPropertyChanged("rbtt_Contact_MappingId");
            }
        }

        /// <summary>
        /// Country
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_countryid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_CountryId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_countryid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_CountryId");
                this.SetAttributeValue("rbtt_countryid", value);
                this.OnPropertyChanged("rbtt_CountryId");
            }
        }

        /// <summary>
        /// Data Norm Newsletter (E-Mail)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_datanormnewsletteremail")]
        public System.Nullable<bool> rbtt_datanormnewsletteremail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_datanormnewsletteremail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_datanormnewsletteremail");
                this.SetAttributeValue("rbtt_datanormnewsletteremail", value);
                this.OnPropertyChanged("rbtt_datanormnewsletteremail");
            }
        }

        /// <summary>
        /// E-Learning Newsletter (E-Mail)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_elearningnewsletteremail")]
        public System.Nullable<bool> rbtt_elearningnewsletteremail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_elearningnewsletteremail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_elearningnewsletteremail");
                this.SetAttributeValue("rbtt_elearningnewsletteremail", value);
                this.OnPropertyChanged("rbtt_elearningnewsletteremail");
            }
        }

        /// <summary>
        /// email_bounce
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_emailbounce")]
        public System.Nullable<bool> rbtt_emailbounce
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_emailbounce");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_emailbounce");
                this.SetAttributeValue("rbtt_emailbounce", value);
                this.OnPropertyChanged("rbtt_emailbounce");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_epioutbounce_email")]
        public System.Nullable<bool> rbtt_epioutbounce_email
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_epioutbounce_email");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_epioutbounce_email");
                this.SetAttributeValue("rbtt_epioutbounce_email", value);
                this.OnPropertyChanged("rbtt_epioutbounce_email");
            }
        }

        /// <summary>
        /// need to be unique in order to can register the user in the system registration entity
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
        /// GDPR Emergeny Block Count
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdpr_emergeny_block_count")]
        public System.Nullable<int> rbtt_GDPR_Emergeny_Block_Count
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_gdpr_emergeny_block_count");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GDPR_Emergeny_Block_Count");
                this.SetAttributeValue("rbtt_gdpr_emergeny_block_count", value);
                this.OnPropertyChanged("rbtt_GDPR_Emergeny_Block_Count");
            }
        }

        /// <summary>
        /// GDPR Mail Trigger
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdpr_mail_trigger")]
        public System.Nullable<int> rbtt_GDPR_Mail_Trigger
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_gdpr_mail_trigger");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GDPR_Mail_Trigger");
                this.SetAttributeValue("rbtt_gdpr_mail_trigger", value);
                this.OnPropertyChanged("rbtt_GDPR_Mail_Trigger");
            }
        }

        /// <summary>
        /// GDPR Block
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdprblock")]
        public System.Nullable<bool> rbtt_GDPRBlock
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_gdprblock");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GDPRBlock");
                this.SetAttributeValue("rbtt_gdprblock", value);
                this.OnPropertyChanged("rbtt_GDPRBlock");
            }
        }

        /// <summary>
        /// GDPR Consent Count
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdprconsentcount1")]
        public System.Nullable<int> rbtt_GDPRConsentCount1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_gdprconsentcount1");
            }
        }

        /// <summary>
        /// Last Updated time of rollup field GDPR Consent Count.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdprconsentcount1_date")]
        public System.Nullable<System.DateTime> rbtt_GDPRConsentCount1_Date
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_gdprconsentcount1_date");
            }
        }

        /// <summary>
        /// State of rollup field GDPR Consent Count.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gdprconsentcount1_state")]
        public System.Nullable<int> rbtt_GDPRConsentCount1_State
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_gdprconsentcount1_state");
            }
        }

        /// <summary>
        /// General Newsletter (E-Mail)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_generalnewsletteremail")]
        public System.Nullable<bool> rbtt_generalnewsletteremail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_generalnewsletteremail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_generalnewsletteremail");
                this.SetAttributeValue("rbtt_generalnewsletteremail", value);
                this.OnPropertyChanged("rbtt_generalnewsletteremail");
            }
        }

        /// <summary>
        /// Heat-Pump Newsletter (E-Mail)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_heatpumpnewsletteremail")]
        public System.Nullable<bool> rbtt_heatpumpnewsletteremail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_heatpumpnewsletteremail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_heatpumpnewsletteremail");
                this.SetAttributeValue("rbtt_heatpumpnewsletteremail", value);
                this.OnPropertyChanged("rbtt_heatpumpnewsletteremail");
            }
        }

        /// <summary>
        /// House number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_housenumber")]
        public string rbtt_Housenumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_housenumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Housenumber");
                this.SetAttributeValue("rbtt_housenumber", value);
                this.OnPropertyChanged("rbtt_Housenumber");
            }
        }

        /// <summary>
        /// Language
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_languageid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_LanguageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_languageid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_LanguageId");
                this.SetAttributeValue("rbtt_languageid", value);
                this.OnPropertyChanged("rbtt_LanguageId");
            }
        }

        /// <summary>
        /// Partner Program Newsletter (E-Mail)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_partnerprogramnewsletteremail")]
        public System.Nullable<bool> rbtt_partnerprogramnewsletteremail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_partnerprogramnewsletteremail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_partnerprogramnewsletteremail");
                this.SetAttributeValue("rbtt_partnerprogramnewsletteremail", value);
                this.OnPropertyChanged("rbtt_partnerprogramnewsletteremail");
            }
        }

        /// <summary>
        /// Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns.
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
        public virtual Contact_ShippingMethodCode? ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
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
        /// Choose the service level agreement (SLA) that you want to apply to the Contact record.
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
        /// Last SLA that was applied to this case. This field is for internal use only.
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
        /// Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("spousesname")]
        public string SpousesName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("spousesname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SpousesName");
                this.SetAttributeValue("spousesname", value);
                this.OnPropertyChanged("SpousesName");
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
        /// Shows whether the contact is active or inactive. Inactive contacts are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.ContactState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.ContactState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.ContactState), optionSet.Value)));
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
        /// Select the contact's status.
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
        /// Select the contact's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Contact_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
        public System.Nullable<System.Guid> SubscriptionId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SubscriptionId");
                this.SetAttributeValue("subscriptionid", value);
                this.OnPropertyChanged("SubscriptionId");
            }
        }

        /// <summary>
        /// Type the suffix used in the contact's name, such as Jr. or Sr. to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suffix")]
        public string Suffix
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("suffix");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Suffix");
                this.SetAttributeValue("suffix", value);
                this.OnPropertyChanged("Suffix");
            }
        }

        /// <summary>
        /// Number of users or conversations followed the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
        public System.Nullable<int> TeamsFollowed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TeamsFollowed");
                this.SetAttributeValue("teamsfollowed", value);
                this.OnPropertyChanged("TeamsFollowed");
            }
        }

        /// <summary>
        /// Type the main phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
        public string Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("telephone1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone1");
                this.SetAttributeValue("telephone1", value);
                this.OnPropertyChanged("Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
        public string Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("telephone2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone2");
                this.SetAttributeValue("telephone2", value);
                this.OnPropertyChanged("Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number for this contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
        public string Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("telephone3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone3");
                this.SetAttributeValue("telephone3", value);
                this.OnPropertyChanged("Telephone3");
            }
        }

        /// <summary>
        /// Select a region or territory for the contact for use in segmentation and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TerritoryCode");
                this.SetAttributeValue("territorycode", value);
                this.OnPropertyChanged("TerritoryCode");
            }
        }

        /// <summary>
        /// Select a region or territory for the contact for use in segmentation and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
        public virtual Contact_TerritoryCode? TerritoryCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Contact_TerritoryCode?)(EntityOptionSetEnum.GetEnum(this, "territorycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TerritoryCode");
                this.SetAttributeValue("territorycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("TerritoryCode");
            }
        }

        /// <summary>
        /// Total time spent for emails (read and write) and meetings by me in relation to the contact record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
        public string TimeSpentByMeOnEmailAndMeetings
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("timespentbymeonemailandmeetings");
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
        /// Version number of the contact.
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
        /// Type the contact's professional or personal website or blog URL.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
        public string WebSiteUrl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("websiteurl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("WebSiteUrl");
                this.SetAttributeValue("websiteurl", value);
                this.OnPropertyChanged("WebSiteUrl");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the contact's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
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
        /// Shows the combined Yomi first and last names of the contact so that the full phonetic name can be displayed in views and reports.
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
        /// Type the phonetic spelling of the contact's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
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
        /// Type the phonetic spelling of the contact's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the contact.
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
        /// 1:N account_primary_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> account_primary_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_primary_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("account_primary_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_primary_contact", null, value);
                this.OnPropertyChanged("account_primary_contact");
            }
        }

        /// <summary>
        /// 1:N btt_contact_btt_gratuity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_contact_btt_gratuity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> btt_contact_btt_gratuity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("btt_contact_btt_gratuity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_contact_btt_gratuity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("btt_contact_btt_gratuity", null, value);
                this.OnPropertyChanged("btt_contact_btt_gratuity");
            }
        }

        /// <summary>
        /// 1:N btt_contact_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_contact_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> Referencedbtt_contact_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_contact_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedbtt_contact_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_contact_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedbtt_contact_contact");
            }
        }

        /// <summary>
        /// 1:N btt_contactplanner_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_contactplanner_opportunity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> btt_contactplanner_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_contactplanner_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_contactplanner_opportunity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_contactplanner_opportunity", null, value);
                this.OnPropertyChanged("btt_contactplanner_opportunity");
            }
        }

        /// <summary>
        /// 1:N contact_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> contact_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("contact_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contact_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("contact_activity_parties", null, value);
                this.OnPropertyChanged("contact_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Contact_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> Contact_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Contact_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Contact_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Contact_Appointments", null, value);
                this.OnPropertyChanged("Contact_Appointments");
            }
        }

        /// <summary>
        /// 1:N contact_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> Referencedcontact_customer_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedcontact_customer_contacts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedcontact_customer_contacts");
            }
        }

        /// <summary>
        /// 1:N Contact_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Contact_Email_EmailSender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Contact_Email_EmailSender", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Contact_Email_EmailSender");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Contact_Email_EmailSender", null, value);
                this.OnPropertyChanged("Contact_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N Contact_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Contact_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Contact_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Contact_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Contact_Emails", null, value);
                this.OnPropertyChanged("Contact_Emails");
            }
        }

        /// <summary>
        /// 1:N contact_master_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> Referencedcontact_master_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedcontact_master_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedcontact_master_contact");
            }
        }

        /// <summary>
        /// 1:N Contact_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> Contact_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Contact_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Contact_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Contact_Tasks", null, value);
                this.OnPropertyChanged("Contact_Tasks");
            }
        }

        /// <summary>
        /// 1:N opportunity_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_contacts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> opportunity_customer_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_customer_contacts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_customer_contacts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_customer_contacts", null, value);
                this.OnPropertyChanged("opportunity_customer_contacts");
            }
        }

        /// <summary>
        /// 1:N opportunity_parent_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_contact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> opportunity_parent_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_parent_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_parent_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_parent_contact", null, value);
                this.OnPropertyChanged("opportunity_parent_contact");
            }
        }

        /// <summary>
        /// 1:N orb_contact_orb_productgroup
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_contact_orb_productgroup")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup> orb_contact_orb_productgroup
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("orb_contact_orb_productgroup", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_contact_orb_productgroup");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroup>("orb_contact_orb_productgroup", null, value);
                this.OnPropertyChanged("orb_contact_orb_productgroup");
            }
        }

        /// <summary>
        /// 1:N quote_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_customer_contacts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> quote_customer_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("quote_customer_contacts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("quote_customer_contacts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("quote_customer_contacts", null, value);
                this.OnPropertyChanged("quote_customer_contacts");
            }
        }

        /// <summary>
        /// 1:N rbtt_contact_orb_country_CMDMailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_country_CMDMailbox")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country> rbtt_contact_orb_country_CMDMailbox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_contact_orb_country_CMDMailbox", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_country_CMDMailbox");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_contact_orb_country_CMDMailbox", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_country_CMDMailbox");
            }
        }

        /// <summary>
        /// 1:N rbtt_contact_orb_machine_ContactId
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_ContactId")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_contact_orb_machine_ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_ContactId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_ContactId");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_ContactId", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_ContactId");
            }
        }

        /// <summary>
        /// 1:N rbtt_contact_orb_machine_EndCustomer
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_EndCustomer")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_contact_orb_machine_EndCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_EndCustomer", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_EndCustomer");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_EndCustomer", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_EndCustomer");
            }
        }

        /// <summary>
        /// 1:N rbtt_contact_orb_machine_LocationContact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_LocationContact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_contact_orb_machine_LocationContact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_LocationContact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_LocationContact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_LocationContact", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_LocationContact");
            }
        }

        /// <summary>
        /// 1:N rbtt_contact_orb_machine_StartUpdoneby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_orb_machine_StartUpdoneby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_contact_orb_machine_StartUpdoneby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_StartUpdoneby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_orb_machine_StartUpdoneby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_contact_orb_machine_StartUpdoneby", null, value);
                this.OnPropertyChanged("rbtt_contact_orb_machine_StartUpdoneby");
            }
        }

        /// <summary>
        /// 1:N rbtt_contact_rbtt_consent_Contact2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_rbtt_consent_Contact2")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent> rbtt_contact_rbtt_consent_Contact2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_contact_rbtt_consent_Contact2", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_rbtt_consent_Contact2");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_consent>("rbtt_contact_rbtt_consent_Contact2", null, value);
                this.OnPropertyChanged("rbtt_contact_rbtt_consent_Contact2");
            }
        }

        /// <summary>
        /// 1:N rbtt_contact_rbtt_delivernote_ShiptoParty
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_contact_rbtt_delivernote_ShiptoParty")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote> rbtt_contact_rbtt_delivernote_ShiptoParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_contact_rbtt_delivernote_ShiptoParty", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_contact_rbtt_delivernote_ShiptoParty");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_contact_rbtt_delivernote_ShiptoParty", null, value);
                this.OnPropertyChanged("rbtt_contact_rbtt_delivernote_ShiptoParty");
            }
        }

        /// <summary>
        /// N:N contactquotes_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactquotes_association")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> contactquotes_association
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("contactquotes_association", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contactquotes_association");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("contactquotes_association", null, value);
                this.OnPropertyChanged("contactquotes_association");
            }
        }

        /// <summary>
        /// N:N rbtt_account_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_contact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> rbtt_account_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("rbtt_account_contact", null, value);
                this.OnPropertyChanged("rbtt_account_contact");
            }
        }

        /// <summary>
        /// N:1 btt_contact_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_replacementcontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_contact_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact Referencingbtt_contact_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_contact_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingbtt_contact_contact");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("btt_contact_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingbtt_contact_contact");
            }
        }

        /// <summary>
        /// N:1 btt_customerservice_user_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_responsibleservice_userid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_customerservice_user_contact")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser btt_customerservice_user_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_customerservice_user_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_customerservice_user_contact");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_customerservice_user_contact", null, value);
                this.OnPropertyChanged("btt_customerservice_user_contact");
            }
        }

        /// <summary>
        /// N:1 btt_systemuser_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_lastappointmentcompletedbyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_systemuser_contact")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser btt_systemuser_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_systemuser_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_systemuser_contact");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_systemuser_contact", null, value);
                this.OnPropertyChanged("btt_systemuser_contact");
            }
        }

        /// <summary>
        /// N:1 contact_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account contact_customer_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("contact_customer_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contact_customer_accounts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("contact_customer_accounts", null, value);
                this.OnPropertyChanged("contact_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 contact_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact Referencingcontact_customer_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingcontact_customer_contacts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_customer_contacts", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingcontact_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 contact_master_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact Referencingcontact_master_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_master_contact", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 contact_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser contact_owning_user
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("contact_owning_user", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contact_owning_user");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("contact_owning_user", null, value);
                this.OnPropertyChanged("contact_owning_user");
            }
        }

        /// <summary>
        /// N:1 lk_contact_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_contact_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contact_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contact_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contact_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_contact_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_contact_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contact_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contact_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contact_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_contactbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_contactbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contactbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contactbase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contactbase_createdby", null, value);
                this.OnPropertyChanged("lk_contactbase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_contactbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_contactbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contactbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_contactbase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_contactbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contactbase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 rbtt_orb_country_contact_CountryId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_countryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_orb_country_contact_CountryId")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country rbtt_orb_country_contact_CountryId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_contact_CountryId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_orb_country_contact_CountryId");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("rbtt_orb_country_contact_CountryId", null, value);
                this.OnPropertyChanged("rbtt_orb_country_contact_CountryId");
            }
        }

        /// <summary>
        /// N:1 system_user_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser system_user_contacts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_contacts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_contacts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_contacts", null, value);
                this.OnPropertyChanged("system_user_contacts");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Contact(object anonymousType) :
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
                        Attributes["contactid"] = base.Id;
                        break;
                    case "contactid":
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