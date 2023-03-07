namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum AccountState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactive = 1,
    }

    /// <summary>
    /// Business that represents a customer or potential customer. The company that is billed in business transactions.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
    public partial class Account : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string AccountCategoryCode = "accountcategorycode";
            public const string AccountClassificationCode = "accountclassificationcode";
            public const string AccountId = "accountid";
            public const string Id = "accountid";
            public const string AccountNumber = "accountnumber";
            public const string AccountRatingCode = "accountratingcode";
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
            public const string Aging30 = "aging30";
            public const string Aging30_Base = "aging30_base";
            public const string Aging60 = "aging60";
            public const string Aging60_Base = "aging60_base";
            public const string Aging90 = "aging90";
            public const string Aging90_Base = "aging90_base";
            public const string btt_abcstatus_y1 = "btt_abcstatus_y1";
            public const string btt_abcstatus_y2 = "btt_abcstatus_y2";
            public const string Btt_acceptance_addressusage = "btt_acceptance_addressusage";
            public const string btt_accountcategorycode = "btt_accountcategorycode";
            public const string Btt_accountname = "btt_accountname";
            public const string Btt_Aftersalesservice = "btt_aftersalesservice";
            public const string Btt_analysisopportunity = "btt_analysisopportunity";
            public const string Btt_analysisoverview = "btt_analysisoverview";
            public const string Btt_analysisstrength = "btt_analysisstrength";
            public const string Btt_analysisthreat = "btt_analysisthreat";
            public const string Btt_analysisweakness = "btt_analysisweakness";
            public const string BTT_appointmentrhythmcode_ABC = "btt_appointmentrhythmcode_abc";
            public const string Btt_authorizedforonlinesales = "btt_authorizedforonlinesales";
            public const string Btt_authorizednumbersubdealers = "btt_authorizednumbersubdealers";
            public const string Btt_authorizedsalesarea = "btt_authorizedsalesarea";
            public const string Btt_Authorizedshowroom = "btt_authorizedshowroom";
            public const string Btt_boschclimatepartner = "btt_boschclimatepartner";
            public const string Btt_BrandBosch = "btt_brandbosch";
            public const string Btt_brandBuderus = "btt_brandbuderus";
            public const string Btt_BrandIVT = "btt_brandivt";
            public const string Btt_BrandLoos = "btt_brandloos";
            public const string Btt_brandusage = "btt_brandusage";
            public const string Btt_businessconnectionsince = "btt_businessconnectionsince";
            public const string Btt_Calculationbasedon = "btt_calculationbasedon";
            public const string btt_Certified_Partner_Gas = "btt_certified_partner_gas";
            public const string btt_Certified_Partner_Heatpump = "btt_certified_partner_heatpump";
            public const string btt_Certified_Partner_HotWater = "btt_certified_partner_hotwater";
            public const string btt_Certified_Partner_Oil = "btt_certified_partner_oil";
            public const string btt_Certified_Partner_Solar = "btt_certified_partner_solar";
            public const string btt_Certified_Partner_SolidFuels = "btt_certified_partner_solidfuels";
            public const string btt_CertifiedPartner = "btt_certifiedpartner";
            public const string btt_CompetitionPartner1 = "btt_competitionpartner1";
            public const string btt_CompetitionPartner2 = "btt_competitionpartner2";
            public const string btt_CompetitionPartner3 = "btt_competitionpartner3";
            public const string Btt_cooperationsince = "btt_cooperationsince";
            public const string btt_CRMAccountNumber = "btt_crmaccountnumber";
            public const string Btt_distributeragreement = "btt_distributeragreement";
            public const string btt_donotsms = "btt_donotsms";
            public const string Btt_Duplicate = "btt_duplicate";
            public const string Btt_EMailacceptance = "btt_emailacceptance";
            public const string Btt_FaxAcceptance = "btt_faxacceptance";
            public const string Btt_founded = "btt_founded";
            public const string Btt_hasshowroom = "btt_hasshowroom";
            public const string Btt_hassparepartspresent = "btt_hassparepartspresent";
            public const string btt_industryresponsibleid = "btt_industryresponsibleid";
            public const string Btt_installationlicense = "btt_installationlicense";
            public const string btt_InstallationLicense1 = "btt_installationlicense1";
            public const string btt_InstallationLicense2 = "btt_installationlicense2";
            public const string btt_InstallationLicense3 = "btt_installationlicense3";
            public const string Btt_KeyAccount = "btt_keyaccount";
            public const string btt_LocalPreference1 = "btt_localpreference1";
            public const string btt_LocalPreference2 = "btt_localpreference2";
            public const string btt_LocalPreference3 = "btt_localpreference3";
            public const string Btt_MarketingBudget = "btt_marketingbudget";
            public const string btt_marketingbudget_Base = "btt_marketingbudget_base";
            public const string Btt_oursaloon = "btt_oursaloon";
            public const string Btt_PartnerFunktion = "btt_partnerfunktion";
            public const string btt_PartnerProgramDetails = "btt_partnerprogramdetails";
            public const string Btt_PhoneAcceptance = "btt_phoneacceptance";
            public const string Btt_ProvinceId = "btt_provinceid";
            public const string BTT_Relationshiptous = "btt_relationshiptous";
            public const string Btt_Reliabilityindex = "btt_reliabilityindex";
            public const string Btt_remarks = "btt_remarks";
            public const string BTT_RhythmCodesuggested = "btt_rhythmcodesuggested";
            public const string btt_rhythmcodesuggestedbyindustry = "btt_rhythmcodesuggestedbyindustry";
            public const string btt_rhythmcodesuggestedprimary = "btt_rhythmcodesuggestedprimary";
            public const string btt_role_servicecompany = "btt_role_servicecompany";
            public const string btt_Service_Partner_Gas = "btt_service_partner_gas";
            public const string btt_Service_Partner_Heatpumps = "btt_service_partner_heatpumps";
            public const string btt_Service_Partner_Industrial = "btt_service_partner_industrial";
            public const string btt_Service_Partner_Oil = "btt_service_partner_oil";
            public const string btt_Service_Partner_SolidFuels = "btt_service_partner_solidfuels";
            public const string Btt_serviceemployeesnumber = "btt_serviceemployeesnumber";
            public const string btt_servicepartnerdetails = "btt_servicepartnerdetails";
            public const string btt_showroomcompetitorsbrand1id = "btt_showroomcompetitorsbrand1id";
            public const string btt_showroomcompetitorsbrand2id = "btt_showroomcompetitorsbrand2id";
            public const string btt_showroomcompetitorsbrand3id = "btt_showroomcompetitorsbrand3id";
            public const string Btt_Showroomsize_pic = "btt_showroomsize_pic";
            public const string btt_smsacceptance = "btt_smsacceptance";
            public const string btt_StartDateServicePartnerContract = "btt_startdateservicepartnercontract";
            public const string Btt_technicalemployeesnumber = "btt_technicalemployeesnumber";
            public const string Btt_Totalnumberappl_simple = "btt_totalnumberappl_simple";
            public const string Btt_Totalpotential = "btt_totalpotential";
            public const string btt_totalpotential_Base = "btt_totalpotential_base";
            public const string btt_totalpotential_y1 = "btt_totalpotential_y1";
            public const string btt_totalpotential_y1_Base = "btt_totalpotential_y1_base";
            public const string btt_totalpotential_y2 = "btt_totalpotential_y2";
            public const string btt_totalpotential_y2_Base = "btt_totalpotential_y2_base";
            public const string Btt_Totalpotentialcomplex = "btt_totalpotentialcomplex";
            public const string btt_totalpotentialcomplex_Base = "btt_totalpotentialcomplex_base";
            public const string Btt_Totalpotentialestimated = "btt_totalpotentialestimated";
            public const string btt_totalpotentialestimated_Base = "btt_totalpotentialestimated_base";
            public const string Btt_Totalpotentialsimple = "btt_totalpotentialsimple";
            public const string btt_totalpotentialsimple_Base = "btt_totalpotentialsimple_base";
            public const string Btt_TT_numberappl_simple = "btt_tt_numberappl_simple";
            public const string Btt_TT_Turnover = "btt_tt_turnover";
            public const string btt_tt_turnover_Base = "btt_tt_turnover_base";
            public const string btt_tt_turnover_y1 = "btt_tt_turnover_y1";
            public const string btt_tt_turnover_y1_Base = "btt_tt_turnover_y1_base";
            public const string btt_tt_turnover_y2 = "btt_tt_turnover_y2";
            public const string btt_tt_turnover_y2_Base = "btt_tt_turnover_y2_base";
            public const string Btt_TT_Turnovercomplex = "btt_tt_turnovercomplex";
            public const string btt_tt_turnovercomplex_Base = "btt_tt_turnovercomplex_base";
            public const string Btt_TT_Turnoverestimated = "btt_tt_turnoverestimated";
            public const string btt_tt_turnoverestimated_Base = "btt_tt_turnoverestimated_base";
            public const string Btt_TT_Turnoversimple = "btt_tt_turnoversimple";
            public const string btt_tt_turnoversimple_Base = "btt_tt_turnoversimple_base";
            public const string btt_TTPartner = "btt_ttpartner";
            public const string btt_TTPartnerProgram2 = "btt_ttpartnerprogram2";
            public const string btt_ttpartnerprogramm = "btt_ttpartnerprogramm";
            public const string Btt_TTShare = "btt_ttshare";
            public const string btt_ttshare_y1 = "btt_ttshare_y1";
            public const string btt_ttshare_y2 = "btt_ttshare_y2";
            public const string Btt_Turnoverpresentyear = "btt_turnoverpresentyear";
            public const string btt_turnoverpresentyear_Base = "btt_turnoverpresentyear_base";
            public const string Btt_Turnoverpreviousyear = "btt_turnoverpreviousyear";
            public const string btt_turnoverpreviousyear_Base = "btt_turnoverpreviousyear_base";
            public const string Btt_TurnoverY2 = "btt_turnovery2";
            public const string btt_turnovery2_Base = "btt_turnovery2_base";
            public const string Btt_valueperappliance = "btt_valueperappliance";
            public const string btt_valueperappliance_Base = "btt_valueperappliance_base";
            public const string btt_visitplanningresetdate = "btt_visitplanningresetdate";
            public const string btt_visitscompletedindustryresp = "btt_visitscompletedindustryresp";
            public const string btt_visitscompletedprimaryresp = "btt_visitscompletedprimaryresp";
            public const string Btt_websiteurl2 = "btt_websiteurl2";
            public const string BusinessTypeCode = "businesstypecode";
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
            public const string Description = "description";
            public const string DoNotBulkEMail = "donotbulkemail";
            public const string DoNotBulkPostalMail = "donotbulkpostalmail";
            public const string DoNotEMail = "donotemail";
            public const string DoNotFax = "donotfax";
            public const string DoNotPhone = "donotphone";
            public const string DoNotPostalMail = "donotpostalmail";
            public const string DoNotSendMM = "donotsendmm";
            public const string EMailAddress1 = "emailaddress1";
            public const string EMailAddress2 = "emailaddress2";
            public const string EMailAddress3 = "emailaddress3";
            public const string EntityImage = "entityimage";
            public const string EntityImage_Timestamp = "entityimage_timestamp";
            public const string EntityImage_URL = "entityimage_url";
            public const string EntityImageId = "entityimageid";
            public const string ExchangeRate = "exchangerate";
            public const string Fax = "fax";
            public const string FollowEmail = "followemail";
            public const string FtpSiteURL = "ftpsiteurl";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IndustryCode = "industrycode";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string LastUsedInCampaign = "lastusedincampaign";
            public const string MarketCap = "marketcap";
            public const string MarketCap_Base = "marketcap_base";
            public const string MarketingOnly = "marketingonly";
            public const string MasterId = "masterid";
            public const string Merged = "merged";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedByExternalParty = "modifiedbyexternalparty";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string Name = "name";
            public const string NumberOfEmployees = "numberofemployees";
            public const string OnHoldTime = "onholdtime";
            public const string OpenDeals = "opendeals";
            public const string OpenDeals_Date = "opendeals_date";
            public const string OpenDeals_State = "opendeals_state";
            public const string OpenRevenue = "openrevenue";
            public const string OpenRevenue_Base = "openrevenue_base";
            public const string OpenRevenue_Date = "openrevenue_date";
            public const string OpenRevenue_State = "openrevenue_state";
            public const string Orb_BorderCD = "orb_bordercd";
            public const string Orb_classification = "orb_classification";
            public const string orb_classificationbaseid = "orb_classificationbaseid";
            public const string Orb_complexitycode = "orb_complexitycode";
            public const string orb_countryid = "orb_countryid";
            public const string Orb_estimatedturnover = "orb_estimatedturnover";
            public const string Orb_lastscheduledappointment = "orb_lastscheduledappointment";
            public const string Orb_name2 = "orb_name2";
            public const string Orb_name3 = "orb_name3";
            public const string Orb_nextappointment = "orb_nextappointment";
            public const string Orb_nextscheduledappointment = "orb_nextscheduledappointment";
            public const string Orb_nextsecondappointment = "orb_nextsecondappointment";
            public const string Orb_potential = "orb_potential";
            public const string Orb_potentiala = "orb_potentiala";
            public const string Orb_potentialb = "orb_potentialb";
            public const string Orb_preferredappointmentdaycode = "orb_preferredappointmentdaycode";
            public const string Orb_reorgflag = "orb_reorgflag";
            public const string Orb_tour = "orb_tour";
            public const string Orb_useofpotential1 = "orb_useofpotential1";
            public const string Orb_useofpotential2 = "orb_useofpotential2";
            public const string Orb_vatnumber = "orb_vatnumber";
            public const string Orb_visitcountactual = "orb_visitcountactual";
            public const string Orb_visitcountplanned = "orb_visitcountplanned";
            public const string OriginatingLeadId = "originatingleadid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwnershipCode = "ownershipcode";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string ParentAccountId = "parentaccountid";
            public const string ParticipatesInWorkflow = "participatesinworkflow";
            public const string PaymentTermsCode = "paymenttermscode";
            public const string PreferredAppointmentDayCode = "preferredappointmentdaycode";
            public const string PreferredAppointmentTimeCode = "preferredappointmenttimecode";
            public const string PreferredContactMethodCode = "preferredcontactmethodcode";
            public const string PreferredEquipmentId = "preferredequipmentid";
            public const string PreferredServiceId = "preferredserviceid";
            public const string PreferredSystemUserId = "preferredsystemuserid";
            public const string PrimaryContactId = "primarycontactid";
            public const string PrimarySatoriId = "primarysatoriid";
            public const string PrimaryTwitterId = "primarytwitterid";
            public const string ProcessId = "processid";
            public const string rbtt_ABCStatusPlan = "rbtt_abcstatusplan";
            public const string rbtt_Account_MappingId = "rbtt_account_mappingid";
            public const string rbtt_AppointmentOverdue = "rbtt_appointmentoverdue";
            public const string rbtt_Brand = "rbtt_brand";
            public const string rbtt_Code = "rbtt_code";
            public const string rbtt_CustomerAssetTotal = "rbtt_customerassettotal";
            public const string rbtt_CustomerAssetTotal_Date = "rbtt_customerassettotal_date";
            public const string rbtt_CustomerAssetTotal_State = "rbtt_customerassettotal_state";
            public const string rbtt_CustomerMasterData = "rbtt_customermasterdata";
            public const string rbtt_ERPCustomerNumber = "rbtt_erpcustomernumber";
            public const string rbtt_ERPShiptoNumber = "rbtt_erpshiptonumber";
            public const string rbtt_ERPSupplierNumber = "rbtt_erpsuppliernumber";
            public const string rbtt_ExternalAccountNumber = "rbtt_externalaccountnumber";
            public const string rbtt_GlobalPPinuse = "rbtt_globalppinuse";
            public const string rbtt_GratuitiesTotalY1 = "rbtt_gratuitiestotaly1";
            public const string rbtt_gratuitiestotaly1_Base = "rbtt_gratuitiestotaly1_base";
            public const string rbtt_GratuitiesTotalYTD = "rbtt_gratuitiestotalytd";
            public const string rbtt_gratuitiestotalytd_Base = "rbtt_gratuitiestotalytd_base";
            public const string rbtt_Housenumber = "rbtt_housenumber";
            public const string rbtt_IsBlocked = "rbtt_isblocked";
            public const string rbtt_Language = "rbtt_language";
            public const string rbtt_Name = "rbtt_name";
            public const string rbtt_NoofRegistrationsY1 = "rbtt_noofregistrationsy1";
            public const string rbtt_NoofRegistrationsY2 = "rbtt_noofregistrationsy2";
            public const string rbtt_NoofRegistrationsYTD = "rbtt_noofregistrationsytd";
            public const string rbtt_OrganizationID = "rbtt_organizationid";
            public const string rbtt_PartnerLevel = "rbtt_partnerlevel";
            public const string rbtt_PartnerStatus = "rbtt_partnerstatus";
            public const string rbtt_preferredappointmentrhythmcode = "rbtt_preferredappointmentrhythmcode";
            public const string rbtt_RegQ1A3 = "rbtt_regq1a3";
            public const string rbtt_RelationsEmail = "rbtt_relationsemail";
            public const string rbtt_RelationsNumber = "rbtt_relationsnumber";
            public const string rbtt_RelationsRole = "rbtt_relationsrole";
            public const string rbtt_RhythmCodeadjustedbymanager = "rbtt_rhythmcodeadjustedbymanager";
            public const string rbtt_SalesOrganization = "rbtt_salesorganization";
            public const string rbtt_SegmentationType = "rbtt_segmentationtype";
            public const string rbtt_TotalNoofRegistrations = "rbtt_totalnoofregistrations";
            public const string Revenue = "revenue";
            public const string Revenue_Base = "revenue_base";
            public const string SharesOutstanding = "sharesoutstanding";
            public const string ShippingMethodCode = "shippingmethodcode";
            public const string SIC = "sic";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string StockExchange = "stockexchange";
            public const string TeamsFollowed = "teamsfollowed";
            public const string Telephone1 = "telephone1";
            public const string Telephone2 = "telephone2";
            public const string Telephone3 = "telephone3";
            public const string TerritoryCode = "territorycode";
            public const string TerritoryId = "territoryid";
            public const string TickerSymbol = "tickersymbol";
            public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string TTFR_CodeNAF = "ttfr_codenaf";
            public const string Ttfr_CodeNAF_2 = "ttfr_codenaf_2";
            public const string TTFR_Codesirensiret = "ttfr_codesirensiret";
            public const string TTFR_Numkompass = "ttfr_numkompass";
            public const string TTFR_org_proPG = "ttfr_org_propg";
            public const string TTFR_org_proQualibois = "ttfr_org_proqualibois";
            public const string TTFR_org_proQualipac = "ttfr_org_proqualipac";
            public const string TTFR_org_proQualisolCESI = "ttfr_org_proqualisolcesi";
            public const string TTFR_org_proQualisolSSC = "ttfr_org_proqualisolssc";
            public const string TTFR_WordingNAF = "ttfr_wordingnaf";
            public const string Ttfr_WordingNAF_2 = "ttfr_wordingnaf_2";
            public const string TTIB_BaseDiscount = "ttib_basediscount";
            public const string TTIB_Discountcomponet1 = "ttib_discountcomponet1";
            public const string TTIB_Discountcomponet2 = "ttib_discountcomponet2";
            public const string TTIB_Discountcomponet3 = "ttib_discountcomponet3";
            public const string TTIB_Discountcomponet4 = "ttib_discountcomponet4";
            public const string TTIB_Discountcomponet5 = "ttib_discountcomponet5";
            public const string TTIB_Discountcomponet6 = "ttib_discountcomponet6";
            public const string TTIB_Discountcomponet7 = "ttib_discountcomponet7";
            public const string TTIB_Veicoli = "ttib_veicoli";
            public const string TTIB_VeicoliCamion = "ttib_veicolicamion";
            public const string TTIB_VeicoliVeicoliLeggeri = "ttib_veicoliveicolileggeri";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string WebSiteURL = "websiteurl";
            public const string YomiName = "yominame";
            public const string Referencingaccount_master_account = "account_master_account";
            public const string Referencingaccount_parent_account = "account_parent_account";
            public const string account_primary_contact = "account_primary_contact";
            public const string btt_systemuser_account = "btt_systemuser_account";
            public const string lk_accountbase_createdby = "lk_accountbase_createdby";
            public const string lk_accountbase_createdonbehalfby = "lk_accountbase_createdonbehalfby";
            public const string lk_accountbase_modifiedby = "lk_accountbase_modifiedby";
            public const string lk_accountbase_modifiedonbehalfby = "lk_accountbase_modifiedonbehalfby";
            public const string orb_orb_classificationbase_account = "orb_orb_classificationbase_account";
            public const string orb_orb_country_account = "orb_orb_country_account";
            public const string rbtt_rbtt_productionplants_account_SalesOrganization = "rbtt_rbtt_productionplants_account_SalesOrganization";
            public const string system_user_accounts = "system_user_accounts";
            public const string user_accounts = "user_accounts";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Account() :
                base(EntityLogicalName)
        {
        }

        public const string AlternateKeys = "rbtt_externalaccountnumber|btt_crmaccountnumber";

        public const string EntityLogicalName = "account";

        public const string EntitySchemaName = "Account";

        public const string PrimaryIdAttribute = "accountid";

        public const string PrimaryNameAttribute = "name";

        public const string EntityLogicalCollectionName = "accounts";

        public const string EntitySetName = "accounts";

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
        /// Drop-down list for selecting the role of the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountCategoryCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountcategorycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountCategoryCode");
                this.SetAttributeValue("accountcategorycode", value);
                this.OnPropertyChanged("AccountCategoryCode");
            }
        }

        /// <summary>
        /// Drop-down list for selecting the role of the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountcategorycode")]
        public virtual Account_AccountCategoryCode? AccountCategoryCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_AccountCategoryCode?)(EntityOptionSetEnum.GetEnum(this, "accountcategorycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountCategoryCode");
                this.SetAttributeValue("accountcategorycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("AccountCategoryCode");
            }
        }

        /// <summary>
        /// Select a classification code to indicate the potential value of the customer account based on the opportunityed return on investment, cooperation level, sales cycle length or other criteria.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountClassificationCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountclassificationcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountClassificationCode");
                this.SetAttributeValue("accountclassificationcode", value);
                this.OnPropertyChanged("AccountClassificationCode");
            }
        }

        /// <summary>
        /// Select a classification code to indicate the potential value of the customer account based on the opportunityed return on investment, cooperation level, sales cycle length or other criteria.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountclassificationcode")]
        public virtual Account_AccountClassificationCode? AccountClassificationCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_AccountClassificationCode?)(EntityOptionSetEnum.GetEnum(this, "accountclassificationcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountClassificationCode");
                this.SetAttributeValue("accountclassificationcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("AccountClassificationCode");
            }
        }

        /// <summary>
        /// Unique identifier of the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public System.Nullable<System.Guid> AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountId");
                this.SetAttributeValue("accountid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("AccountId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
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
                this.AccountId = value;
            }
        }

        /// <summary>
        /// Type an ID number or code for the account to quickly search and identify the account in system views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountnumber")]
        public string AccountNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("accountnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountNumber");
                this.SetAttributeValue("accountnumber", value);
                this.OnPropertyChanged("AccountNumber");
            }
        }

        /// <summary>
        /// Select a rating to indicate the value of the customer account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountRatingCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountratingcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountRatingCode");
                this.SetAttributeValue("accountratingcode", value);
                this.OnPropertyChanged("AccountRatingCode");
            }
        }

        /// <summary>
        /// Select a rating to indicate the value of the customer account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountratingcode")]
        public virtual Account_AccountRatingCode? AccountRatingCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_AccountRatingCode?)(EntityOptionSetEnum.GetEnum(this, "accountratingcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("AccountRatingCode");
                this.SetAttributeValue("accountratingcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("AccountRatingCode");
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
        public virtual Account_Address1_AddressTypeCode? Address1_AddressTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Address1_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address1_addresstypecode")));
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
        public virtual Account_Address1_FreightTermsCode? Address1_FreightTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Address1_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address1_freighttermscode")));
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
        public virtual Account_Address1_ShippingMethodCode? Address1_ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Address1_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address1_shippingmethodcode")));
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
        public virtual Account_Address2_AddressTypeCode? Address2_AddressTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Address2_AddressTypeCode?)(EntityOptionSetEnum.GetEnum(this, "address2_addresstypecode")));
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
        public virtual Account_Address2_FreightTermsCode? Address2_FreightTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Address2_FreightTermsCode?)(EntityOptionSetEnum.GetEnum(this, "address2_freighttermscode")));
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
        public virtual Account_Address2_ShippingMethodCode? Address2_ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Address2_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "address2_shippingmethodcode")));
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
        /// The base currency equivalent of the aging 30 field.
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
        /// The base currency equivalent of the aging 60 field.
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
        /// The base currency equivalent of the aging 90 field.
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
        /// ABC Status Y-1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_abcstatus_y1")]
        public string btt_abcstatus_y1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_abcstatus_y1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_abcstatus_y1");
                this.SetAttributeValue("btt_abcstatus_y1", value);
                this.OnPropertyChanged("btt_abcstatus_y1");
            }
        }

        /// <summary>
        /// ABC Status Y-2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_abcstatus_y2")]
        public string btt_abcstatus_y2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_abcstatus_y2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_abcstatus_y2");
                this.SetAttributeValue("btt_abcstatus_y2", value);
                this.OnPropertyChanged("btt_abcstatus_y2");
            }
        }

        /// <summary>
        /// Address usage allowed
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_acceptance_addressusage")]
        public System.Nullable<bool> Btt_acceptance_addressusage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_acceptance_addressusage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_acceptance_addressusage");
                this.SetAttributeValue("btt_acceptance_addressusage", value);
                this.OnPropertyChanged("Btt_acceptance_addressusage");
            }
        }

        /// <summary>
        /// Role 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_accountcategorycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_accountcategorycode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_accountcategorycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_accountcategorycode");
                this.SetAttributeValue("btt_accountcategorycode", value);
                this.OnPropertyChanged("btt_accountcategorycode");
            }
        }

        /// <summary>
        /// Role 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_accountcategorycode")]
        public virtual Account_btt_accountcategorycode? btt_accountcategorycodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_btt_accountcategorycode?)(EntityOptionSetEnum.GetEnum(this, "btt_accountcategorycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_accountcategorycode");
                this.SetAttributeValue("btt_accountcategorycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_accountcategorycode");
            }
        }

        /// <summary>
        /// Account Name 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_accountname")]
        public string Btt_accountname
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_accountname");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_accountname");
                this.SetAttributeValue("btt_accountname", value);
                this.OnPropertyChanged("Btt_accountname");
            }
        }

        /// <summary>
        /// After Sales Service
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_aftersalesservice")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Aftersalesservice
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_aftersalesservice");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Aftersalesservice");
                this.SetAttributeValue("btt_aftersalesservice", value);
                this.OnPropertyChanged("Btt_Aftersalesservice");
            }
        }

        /// <summary>
        /// After Sales Service
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_aftersalesservice")]
        public virtual Account_Btt_Aftersalesservice? Btt_AftersalesserviceEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Btt_Aftersalesservice?)(EntityOptionSetEnum.GetEnum(this, "btt_aftersalesservice")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Aftersalesservice");
                this.SetAttributeValue("btt_aftersalesservice", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Aftersalesservice");
            }
        }

        /// <summary>
        /// Opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_analysisopportunity")]
        public string Btt_analysisopportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_analysisopportunity");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_analysisopportunity");
                this.SetAttributeValue("btt_analysisopportunity", value);
                this.OnPropertyChanged("Btt_analysisopportunity");
            }
        }

        /// <summary>
        /// Overview
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_analysisoverview")]
        public string Btt_analysisoverview
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_analysisoverview");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_analysisoverview");
                this.SetAttributeValue("btt_analysisoverview", value);
                this.OnPropertyChanged("Btt_analysisoverview");
            }
        }

        /// <summary>
        /// Strengths
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_analysisstrength")]
        public string Btt_analysisstrength
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_analysisstrength");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_analysisstrength");
                this.SetAttributeValue("btt_analysisstrength", value);
                this.OnPropertyChanged("Btt_analysisstrength");
            }
        }

        /// <summary>
        /// Threats
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_analysisthreat")]
        public string Btt_analysisthreat
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_analysisthreat");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_analysisthreat");
                this.SetAttributeValue("btt_analysisthreat", value);
                this.OnPropertyChanged("Btt_analysisthreat");
            }
        }

        /// <summary>
        /// Weaknesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_analysisweakness")]
        public string Btt_analysisweakness
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_analysisweakness");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_analysisweakness");
                this.SetAttributeValue("btt_analysisweakness", value);
                this.OnPropertyChanged("Btt_analysisweakness");
            }
        }

        /// <summary>
        /// Rhythm Code from ABC
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_appointmentrhythmcode_abc")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_appointmentrhythmcode_ABC
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_appointmentrhythmcode_abc");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_appointmentrhythmcode_ABC");
                this.SetAttributeValue("btt_appointmentrhythmcode_abc", value);
                this.OnPropertyChanged("BTT_appointmentrhythmcode_ABC");
            }
        }

        /// <summary>
        /// Rhythm Code from ABC
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_appointmentrhythmcode_abc")]
        public virtual Account_BTT_appointmentrhythmcode_ABC? BTT_appointmentrhythmcode_ABCEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_BTT_appointmentrhythmcode_ABC?)(EntityOptionSetEnum.GetEnum(this, "btt_appointmentrhythmcode_abc")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_appointmentrhythmcode_ABC");
                this.SetAttributeValue("btt_appointmentrhythmcode_abc", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_appointmentrhythmcode_ABC");
            }
        }

        /// <summary>
        /// Authorized for Online Sales
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_authorizedforonlinesales")]
        public System.Nullable<bool> Btt_authorizedforonlinesales
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_authorizedforonlinesales");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_authorizedforonlinesales");
                this.SetAttributeValue("btt_authorizedforonlinesales", value);
                this.OnPropertyChanged("Btt_authorizedforonlinesales");
            }
        }

        /// <summary>
        /// Authorized number of sub dealers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_authorizednumbersubdealers")]
        public System.Nullable<decimal> Btt_authorizednumbersubdealers
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("btt_authorizednumbersubdealers");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_authorizednumbersubdealers");
                this.SetAttributeValue("btt_authorizednumbersubdealers", value);
                this.OnPropertyChanged("Btt_authorizednumbersubdealers");
            }
        }

        /// <summary>
        /// Authorized sales area
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_authorizedsalesarea")]
        public string Btt_authorizedsalesarea
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_authorizedsalesarea");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_authorizedsalesarea");
                this.SetAttributeValue("btt_authorizedsalesarea", value);
                this.OnPropertyChanged("Btt_authorizedsalesarea");
            }
        }

        /// <summary>
        /// Authorized showroom
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_authorizedshowroom")]
        public System.Nullable<bool> Btt_Authorizedshowroom
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_authorizedshowroom");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Authorizedshowroom");
                this.SetAttributeValue("btt_authorizedshowroom", value);
                this.OnPropertyChanged("Btt_Authorizedshowroom");
            }
        }

        /// <summary>
        /// Bosch Climate Partner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_boschclimatepartner")]
        public System.Nullable<bool> Btt_boschclimatepartner
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_boschclimatepartner");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_boschclimatepartner");
                this.SetAttributeValue("btt_boschclimatepartner", value);
                this.OnPropertyChanged("Btt_boschclimatepartner");
            }
        }

        /// <summary>
        /// Brand Bosch
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_brandbosch")]
        public System.Nullable<bool> Btt_BrandBosch
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_brandbosch");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_BrandBosch");
                this.SetAttributeValue("btt_brandbosch", value);
                this.OnPropertyChanged("Btt_BrandBosch");
            }
        }

        /// <summary>
        /// Brand Buderus
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_brandbuderus")]
        public System.Nullable<bool> Btt_brandBuderus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_brandbuderus");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_brandBuderus");
                this.SetAttributeValue("btt_brandbuderus", value);
                this.OnPropertyChanged("Btt_brandBuderus");
            }
        }

        /// <summary>
        /// Local Brand 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_brandivt")]
        public System.Nullable<bool> Btt_BrandIVT
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_brandivt");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_BrandIVT");
                this.SetAttributeValue("btt_brandivt", value);
                this.OnPropertyChanged("Btt_BrandIVT");
            }
        }

        /// <summary>
        /// Local Brand 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_brandloos")]
        public System.Nullable<bool> Btt_BrandLoos
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_brandloos");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_BrandLoos");
                this.SetAttributeValue("btt_brandloos", value);
                this.OnPropertyChanged("Btt_BrandLoos");
            }
        }

        /// <summary>
        /// Authorisation for brand usage
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_brandusage")]
        public System.Nullable<bool> Btt_brandusage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_brandusage");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_brandusage");
                this.SetAttributeValue("btt_brandusage", value);
                this.OnPropertyChanged("Btt_brandusage");
            }
        }

        /// <summary>
        /// Works with us since ( in Year)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_businessconnectionsince")]
        public System.Nullable<System.DateTime> Btt_businessconnectionsince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_businessconnectionsince");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_businessconnectionsince");
                this.SetAttributeValue("btt_businessconnectionsince", value);
                this.OnPropertyChanged("Btt_businessconnectionsince");
            }
        }

        /// <summary>
        /// Indicates whether the ABC calculation is based on amount of money OR on the number of appliances.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_calculationbasedon")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Calculationbasedon
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_calculationbasedon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Calculationbasedon");
                this.SetAttributeValue("btt_calculationbasedon", value);
                this.OnPropertyChanged("Btt_Calculationbasedon");
            }
        }

        /// <summary>
        /// Indicates whether the ABC calculation is based on amount of money OR on the number of appliances.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_calculationbasedon")]
        public virtual Account_Btt_Calculationbasedon? Btt_CalculationbasedonEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Btt_Calculationbasedon?)(EntityOptionSetEnum.GetEnum(this, "btt_calculationbasedon")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Calculationbasedon");
                this.SetAttributeValue("btt_calculationbasedon", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Calculationbasedon");
            }
        }

        /// <summary>
        /// Certified Partner Gas
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_gas")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Certified_Partner_Gas
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_certified_partner_gas");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Gas");
                this.SetAttributeValue("btt_certified_partner_gas", value);
                this.OnPropertyChanged("btt_Certified_Partner_Gas");
            }
        }

        /// <summary>
        /// Certified Partner Gas
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_gas")]
        public virtual btt_Brands? btt_Certified_Partner_GasEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_certified_partner_gas")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Gas");
                this.SetAttributeValue("btt_certified_partner_gas", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Certified_Partner_Gas");
            }
        }

        /// <summary>
        /// Certified Partner Heatpump
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_heatpump")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Certified_Partner_Heatpump
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_certified_partner_heatpump");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Heatpump");
                this.SetAttributeValue("btt_certified_partner_heatpump", value);
                this.OnPropertyChanged("btt_Certified_Partner_Heatpump");
            }
        }

        /// <summary>
        /// Certified Partner Heatpump
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_heatpump")]
        public virtual btt_Brands? btt_Certified_Partner_HeatpumpEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_certified_partner_heatpump")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Heatpump");
                this.SetAttributeValue("btt_certified_partner_heatpump", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Certified_Partner_Heatpump");
            }
        }

        /// <summary>
        /// Certified Partner Hot Water
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_hotwater")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Certified_Partner_HotWater
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_certified_partner_hotwater");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_HotWater");
                this.SetAttributeValue("btt_certified_partner_hotwater", value);
                this.OnPropertyChanged("btt_Certified_Partner_HotWater");
            }
        }

        /// <summary>
        /// Certified Partner Hot Water
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_hotwater")]
        public virtual btt_Brands? btt_Certified_Partner_HotWaterEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_certified_partner_hotwater")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_HotWater");
                this.SetAttributeValue("btt_certified_partner_hotwater", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Certified_Partner_HotWater");
            }
        }

        /// <summary>
        /// Certified Partner Oil
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_oil")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Certified_Partner_Oil
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_certified_partner_oil");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Oil");
                this.SetAttributeValue("btt_certified_partner_oil", value);
                this.OnPropertyChanged("btt_Certified_Partner_Oil");
            }
        }

        /// <summary>
        /// Certified Partner Oil
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_oil")]
        public virtual btt_Brands? btt_Certified_Partner_OilEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_certified_partner_oil")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Oil");
                this.SetAttributeValue("btt_certified_partner_oil", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Certified_Partner_Oil");
            }
        }

        /// <summary>
        /// Certified Partner Solar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_solar")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Certified_Partner_Solar
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_certified_partner_solar");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Solar");
                this.SetAttributeValue("btt_certified_partner_solar", value);
                this.OnPropertyChanged("btt_Certified_Partner_Solar");
            }
        }

        /// <summary>
        /// Certified Partner Solar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_solar")]
        public virtual btt_Brands? btt_Certified_Partner_SolarEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_certified_partner_solar")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_Solar");
                this.SetAttributeValue("btt_certified_partner_solar", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Certified_Partner_Solar");
            }
        }

        /// <summary>
        /// Certified Partner Solid Fuels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_solidfuels")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Certified_Partner_SolidFuels
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_certified_partner_solidfuels");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_SolidFuels");
                this.SetAttributeValue("btt_certified_partner_solidfuels", value);
                this.OnPropertyChanged("btt_Certified_Partner_SolidFuels");
            }
        }

        /// <summary>
        /// Certified Partner Solid Fuels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certified_partner_solidfuels")]
        public virtual btt_Brands? btt_Certified_Partner_SolidFuelsEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_certified_partner_solidfuels")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Certified_Partner_SolidFuels");
                this.SetAttributeValue("btt_certified_partner_solidfuels", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Certified_Partner_SolidFuels");
            }
        }

        /// <summary>
        /// Certified Partner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_certifiedpartner")]
        public System.Nullable<bool> btt_CertifiedPartner
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_certifiedpartner");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CertifiedPartner");
                this.SetAttributeValue("btt_certifiedpartner", value);
                this.OnPropertyChanged("btt_CertifiedPartner");
            }
        }

        /// <summary>
        /// Competition Partner 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_competitionpartner1")]
        public Microsoft.Xrm.Sdk.EntityReference btt_CompetitionPartner1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_competitionpartner1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CompetitionPartner1");
                this.SetAttributeValue("btt_competitionpartner1", value);
                this.OnPropertyChanged("btt_CompetitionPartner1");
            }
        }

        /// <summary>
        /// Competition Partner 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_competitionpartner2")]
        public Microsoft.Xrm.Sdk.EntityReference btt_CompetitionPartner2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_competitionpartner2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CompetitionPartner2");
                this.SetAttributeValue("btt_competitionpartner2", value);
                this.OnPropertyChanged("btt_CompetitionPartner2");
            }
        }

        /// <summary>
        /// Competition Partner 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_competitionpartner3")]
        public Microsoft.Xrm.Sdk.EntityReference btt_CompetitionPartner3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_competitionpartner3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CompetitionPartner3");
                this.SetAttributeValue("btt_competitionpartner3", value);
                this.OnPropertyChanged("btt_CompetitionPartner3");
            }
        }

        /// <summary>
        /// Cooperation with TT since
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_cooperationsince")]
        public System.Nullable<System.DateTime> Btt_cooperationsince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_cooperationsince");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_cooperationsince");
                this.SetAttributeValue("btt_cooperationsince", value);
                this.OnPropertyChanged("Btt_cooperationsince");
            }
        }

        /// <summary>
        /// CRM Account Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_crmaccountnumber")]
        public string btt_CRMAccountNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_crmaccountnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_CRMAccountNumber");
                this.SetAttributeValue("btt_crmaccountnumber", value);
                this.OnPropertyChanged("btt_CRMAccountNumber");
            }
        }

        /// <summary>
        /// Distributer agreement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_distributeragreement")]
        public System.Nullable<bool> Btt_distributeragreement
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_distributeragreement");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_distributeragreement");
                this.SetAttributeValue("btt_distributeragreement", value);
                this.OnPropertyChanged("Btt_distributeragreement");
            }
        }

        /// <summary>
        /// SMS
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_donotsms")]
        public System.Nullable<bool> btt_donotsms
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_donotsms");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_donotsms");
                this.SetAttributeValue("btt_donotsms", value);
                this.OnPropertyChanged("btt_donotsms");
            }
        }

        /// <summary>
        /// Duplicate
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_duplicate")]
        public System.Nullable<bool> Btt_Duplicate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_duplicate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Duplicate");
                this.SetAttributeValue("btt_duplicate", value);
                this.OnPropertyChanged("Btt_Duplicate");
            }
        }

        /// <summary>
        /// E-Mail Acceptance for promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_emailacceptance")]
        public System.Nullable<bool> Btt_EMailacceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_emailacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_EMailacceptance");
                this.SetAttributeValue("btt_emailacceptance", value);
                this.OnPropertyChanged("Btt_EMailacceptance");
            }
        }

        /// <summary>
        /// Fax Acceptance for promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_faxacceptance")]
        public System.Nullable<bool> Btt_FaxAcceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_faxacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_FaxAcceptance");
                this.SetAttributeValue("btt_faxacceptance", value);
                this.OnPropertyChanged("Btt_FaxAcceptance");
            }
        }

        /// <summary>
        /// Founded in (Year)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_founded")]
        public System.Nullable<System.DateTime> Btt_founded
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_founded");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_founded");
                this.SetAttributeValue("btt_founded", value);
                this.OnPropertyChanged("Btt_founded");
            }
        }

        /// <summary>
        /// Has showroom (heating).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_hasshowroom")]
        public System.Nullable<bool> Btt_hasshowroom
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_hasshowroom");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_hasshowroom");
                this.SetAttributeValue("btt_hasshowroom", value);
                this.OnPropertyChanged("Btt_hasshowroom");
            }
        }

        /// <summary>
        /// Has spareparts present
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_hassparepartspresent")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_hassparepartspresent
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_hassparepartspresent");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_hassparepartspresent");
                this.SetAttributeValue("btt_hassparepartspresent", value);
                this.OnPropertyChanged("Btt_hassparepartspresent");
            }
        }

        /// <summary>
        /// Has spareparts present
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_hassparepartspresent")]
        public virtual Account_Btt_hassparepartspresent? Btt_hassparepartspresentEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Btt_hassparepartspresent?)(EntityOptionSetEnum.GetEnum(this, "btt_hassparepartspresent")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_hassparepartspresent");
                this.SetAttributeValue("btt_hassparepartspresent", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_hassparepartspresent");
            }
        }

        /// <summary>
        /// Unique identifier for User associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_industryresponsibleid")]
        public Microsoft.Xrm.Sdk.EntityReference btt_industryresponsibleid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_industryresponsibleid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_industryresponsibleid");
                this.SetAttributeValue("btt_industryresponsibleid", value);
                this.OnPropertyChanged("btt_industryresponsibleid");
            }
        }

        /// <summary>
        /// Installation License
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installationlicense")]
        public string Btt_installationlicense
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_installationlicense");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_installationlicense");
                this.SetAttributeValue("btt_installationlicense", value);
                this.OnPropertyChanged("Btt_installationlicense");
            }
        }

        /// <summary>
        /// Installation License 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installationlicense1")]
        public System.Nullable<bool> btt_InstallationLicense1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_installationlicense1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_InstallationLicense1");
                this.SetAttributeValue("btt_installationlicense1", value);
                this.OnPropertyChanged("btt_InstallationLicense1");
            }
        }

        /// <summary>
        /// Installation License 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installationlicense2")]
        public System.Nullable<bool> btt_InstallationLicense2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_installationlicense2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_InstallationLicense2");
                this.SetAttributeValue("btt_installationlicense2", value);
                this.OnPropertyChanged("btt_InstallationLicense2");
            }
        }

        /// <summary>
        /// Installation License 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_installationlicense3")]
        public System.Nullable<bool> btt_InstallationLicense3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_installationlicense3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_InstallationLicense3");
                this.SetAttributeValue("btt_installationlicense3", value);
                this.OnPropertyChanged("btt_InstallationLicense3");
            }
        }

        /// <summary>
        /// Key Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_keyaccount")]
        public System.Nullable<bool> Btt_KeyAccount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_keyaccount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_KeyAccount");
                this.SetAttributeValue("btt_keyaccount", value);
                this.OnPropertyChanged("Btt_KeyAccount");
            }
        }

        /// <summary>
        /// Local Preference 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_localpreference1")]
        public System.Nullable<bool> btt_LocalPreference1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_localpreference1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_LocalPreference1");
                this.SetAttributeValue("btt_localpreference1", value);
                this.OnPropertyChanged("btt_LocalPreference1");
            }
        }

        /// <summary>
        /// Local Preference 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_localpreference2")]
        public System.Nullable<bool> btt_LocalPreference2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_localpreference2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_LocalPreference2");
                this.SetAttributeValue("btt_localpreference2", value);
                this.OnPropertyChanged("btt_LocalPreference2");
            }
        }

        /// <summary>
        /// Local Preference 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_localpreference3")]
        public System.Nullable<bool> btt_LocalPreference3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_localpreference3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_LocalPreference3");
                this.SetAttributeValue("btt_localpreference3", value);
                this.OnPropertyChanged("btt_LocalPreference3");
            }
        }

        /// <summary>
        /// Marketing Budget
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_marketingbudget")]
        public Microsoft.Xrm.Sdk.Money Btt_MarketingBudget
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_marketingbudget");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_MarketingBudget");
                this.SetAttributeValue("btt_marketingbudget", value);
                this.OnPropertyChanged("Btt_MarketingBudget");
            }
        }

        /// <summary>
        /// Value of the Marketing Budget in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_marketingbudget_base")]
        public Microsoft.Xrm.Sdk.Money btt_marketingbudget_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_marketingbudget_base");
            }
        }

        /// <summary>
        /// TT products displayed
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_oursaloon")]
        public System.Nullable<bool> Btt_oursaloon
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_oursaloon");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_oursaloon");
                this.SetAttributeValue("btt_oursaloon", value);
                this.OnPropertyChanged("Btt_oursaloon");
            }
        }

        /// <summary>
        /// Partner Function
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_partnerfunktion")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_PartnerFunktion
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_partnerfunktion");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PartnerFunktion");
                this.SetAttributeValue("btt_partnerfunktion", value);
                this.OnPropertyChanged("Btt_PartnerFunktion");
            }
        }

        /// <summary>
        /// Partner Function
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_partnerfunktion")]
        public virtual Account_Btt_PartnerFunktion? Btt_PartnerFunktionEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Btt_PartnerFunktion?)(EntityOptionSetEnum.GetEnum(this, "btt_partnerfunktion")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PartnerFunktion");
                this.SetAttributeValue("btt_partnerfunktion", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_PartnerFunktion");
            }
        }

        /// <summary>
        /// Partner Program Details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_partnerprogramdetails")]
        public string btt_PartnerProgramDetails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_partnerprogramdetails");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_PartnerProgramDetails");
                this.SetAttributeValue("btt_partnerprogramdetails", value);
                this.OnPropertyChanged("btt_PartnerProgramDetails");
            }
        }

        /// <summary>
        /// Phone Acceptance for promotion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_phoneacceptance")]
        public System.Nullable<bool> Btt_PhoneAcceptance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_phoneacceptance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_PhoneAcceptance");
                this.SetAttributeValue("btt_phoneacceptance", value);
                this.OnPropertyChanged("Btt_PhoneAcceptance");
            }
        }

        /// <summary>
        /// Unique identifier for Province associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_provinceid")]
        public Microsoft.Xrm.Sdk.EntityReference Btt_ProvinceId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_provinceid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_ProvinceId");
                this.SetAttributeValue("btt_provinceid", value);
                this.OnPropertyChanged("Btt_ProvinceId");
            }
        }

        /// <summary>
        /// Relationship to us
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_relationshiptous")]
        public Microsoft.Xrm.Sdk.OptionSetValue BTT_Relationshiptous
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_relationshiptous");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_Relationshiptous");
                this.SetAttributeValue("btt_relationshiptous", value);
                this.OnPropertyChanged("BTT_Relationshiptous");
            }
        }

        /// <summary>
        /// Relationship to us
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_relationshiptous")]
        public virtual Account_BTT_Relationshiptous? BTT_RelationshiptousEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_BTT_Relationshiptous?)(EntityOptionSetEnum.GetEnum(this, "btt_relationshiptous")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_Relationshiptous");
                this.SetAttributeValue("btt_relationshiptous", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BTT_Relationshiptous");
            }
        }

        /// <summary>
        /// Reliability index in %
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_reliabilityindex")]
        public System.Nullable<int> Btt_Reliabilityindex
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_reliabilityindex");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Reliabilityindex");
                this.SetAttributeValue("btt_reliabilityindex", value);
                this.OnPropertyChanged("Btt_Reliabilityindex");
            }
        }

        /// <summary>
        /// Remarks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_remarks")]
        public string Btt_remarks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_remarks");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_remarks");
                this.SetAttributeValue("btt_remarks", value);
                this.OnPropertyChanged("Btt_remarks");
            }
        }

        /// <summary>
        /// Rhythm code suggested by employee for the visit planning.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_rhythmcodesuggested")]
        public string BTT_RhythmCodesuggested
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_rhythmcodesuggested");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BTT_RhythmCodesuggested");
                this.SetAttributeValue("btt_rhythmcodesuggested", value);
                this.OnPropertyChanged("BTT_RhythmCodesuggested");
            }
        }

        /// <summary>
        /// Rhythm Code suggested by industry responsible
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_rhythmcodesuggestedbyindustry")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_rhythmcodesuggestedbyindustry
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_rhythmcodesuggestedbyindustry");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_rhythmcodesuggestedbyindustry");
                this.SetAttributeValue("btt_rhythmcodesuggestedbyindustry", value);
                this.OnPropertyChanged("btt_rhythmcodesuggestedbyindustry");
            }
        }

        /// <summary>
        /// Rhythm Code suggested by industry responsible
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_rhythmcodesuggestedbyindustry")]
        public virtual btt_RhythmCode? btt_rhythmcodesuggestedbyindustryEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_RhythmCode?)(EntityOptionSetEnum.GetEnum(this, "btt_rhythmcodesuggestedbyindustry")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_rhythmcodesuggestedbyindustry");
                this.SetAttributeValue("btt_rhythmcodesuggestedbyindustry", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_rhythmcodesuggestedbyindustry");
            }
        }

        /// <summary>
        /// Rhythm Code suggested by primary responsible
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_rhythmcodesuggestedprimary")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_rhythmcodesuggestedprimary
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_rhythmcodesuggestedprimary");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_rhythmcodesuggestedprimary");
                this.SetAttributeValue("btt_rhythmcodesuggestedprimary", value);
                this.OnPropertyChanged("btt_rhythmcodesuggestedprimary");
            }
        }

        /// <summary>
        /// Rhythm Code suggested by primary responsible
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_rhythmcodesuggestedprimary")]
        public virtual btt_RhythmCode? btt_rhythmcodesuggestedprimaryEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_RhythmCode?)(EntityOptionSetEnum.GetEnum(this, "btt_rhythmcodesuggestedprimary")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_rhythmcodesuggestedprimary");
                this.SetAttributeValue("btt_rhythmcodesuggestedprimary", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_rhythmcodesuggestedprimary");
            }
        }

        /// <summary>
        /// Role service company
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_role_servicecompany")]
        public System.Nullable<bool> btt_role_servicecompany
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_role_servicecompany");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_role_servicecompany");
                this.SetAttributeValue("btt_role_servicecompany", value);
                this.OnPropertyChanged("btt_role_servicecompany");
            }
        }

        /// <summary>
        /// Service Partner Gas
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_gas")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Service_Partner_Gas
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_service_partner_gas");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Gas");
                this.SetAttributeValue("btt_service_partner_gas", value);
                this.OnPropertyChanged("btt_Service_Partner_Gas");
            }
        }

        /// <summary>
        /// Service Partner Gas
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_gas")]
        public virtual btt_Brands? btt_Service_Partner_GasEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_service_partner_gas")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Gas");
                this.SetAttributeValue("btt_service_partner_gas", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Service_Partner_Gas");
            }
        }

        /// <summary>
        /// Service Partner Heatpumps
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_heatpumps")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Service_Partner_Heatpumps
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_service_partner_heatpumps");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Heatpumps");
                this.SetAttributeValue("btt_service_partner_heatpumps", value);
                this.OnPropertyChanged("btt_Service_Partner_Heatpumps");
            }
        }

        /// <summary>
        /// Service Partner Heatpumps
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_heatpumps")]
        public virtual btt_Brands? btt_Service_Partner_HeatpumpsEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_service_partner_heatpumps")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Heatpumps");
                this.SetAttributeValue("btt_service_partner_heatpumps", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Service_Partner_Heatpumps");
            }
        }

        /// <summary>
        /// Service Partner Industrial
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_industrial")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Service_Partner_Industrial
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_service_partner_industrial");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Industrial");
                this.SetAttributeValue("btt_service_partner_industrial", value);
                this.OnPropertyChanged("btt_Service_Partner_Industrial");
            }
        }

        /// <summary>
        /// Service Partner Industrial
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_industrial")]
        public virtual btt_Brands? btt_Service_Partner_IndustrialEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_service_partner_industrial")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Industrial");
                this.SetAttributeValue("btt_service_partner_industrial", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Service_Partner_Industrial");
            }
        }

        /// <summary>
        /// Service Partner Oil
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_oil")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Service_Partner_Oil
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_service_partner_oil");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Oil");
                this.SetAttributeValue("btt_service_partner_oil", value);
                this.OnPropertyChanged("btt_Service_Partner_Oil");
            }
        }

        /// <summary>
        /// Service Partner Oil
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_oil")]
        public virtual btt_Brands? btt_Service_Partner_OilEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_service_partner_oil")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_Oil");
                this.SetAttributeValue("btt_service_partner_oil", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Service_Partner_Oil");
            }
        }

        /// <summary>
        /// Service Partner Solid Fuels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_solidfuels")]
        public Microsoft.Xrm.Sdk.OptionSetValue btt_Service_Partner_SolidFuels
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_service_partner_solidfuels");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_SolidFuels");
                this.SetAttributeValue("btt_service_partner_solidfuels", value);
                this.OnPropertyChanged("btt_Service_Partner_SolidFuels");
            }
        }

        /// <summary>
        /// Service Partner Solid Fuels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_service_partner_solidfuels")]
        public virtual btt_Brands? btt_Service_Partner_SolidFuelsEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_Brands?)(EntityOptionSetEnum.GetEnum(this, "btt_service_partner_solidfuels")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_Service_Partner_SolidFuels");
                this.SetAttributeValue("btt_service_partner_solidfuels", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("btt_Service_Partner_SolidFuels");
            }
        }

        /// <summary>
        /// Number of service technicians.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_serviceemployeesnumber")]
        public System.Nullable<int> Btt_serviceemployeesnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_serviceemployeesnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_serviceemployeesnumber");
                this.SetAttributeValue("btt_serviceemployeesnumber", value);
                this.OnPropertyChanged("Btt_serviceemployeesnumber");
            }
        }

        /// <summary>
        /// Service Partner Details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_servicepartnerdetails")]
        public string btt_servicepartnerdetails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_servicepartnerdetails");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_servicepartnerdetails");
                this.SetAttributeValue("btt_servicepartnerdetails", value);
                this.OnPropertyChanged("btt_servicepartnerdetails");
            }
        }

        /// <summary>
        /// Unique identifier for Competitor associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_showroomcompetitorsbrand1id")]
        public Microsoft.Xrm.Sdk.EntityReference btt_showroomcompetitorsbrand1id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_showroomcompetitorsbrand1id");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_showroomcompetitorsbrand1id");
                this.SetAttributeValue("btt_showroomcompetitorsbrand1id", value);
                this.OnPropertyChanged("btt_showroomcompetitorsbrand1id");
            }
        }

        /// <summary>
        /// Unique identifier for Competitor associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_showroomcompetitorsbrand2id")]
        public Microsoft.Xrm.Sdk.EntityReference btt_showroomcompetitorsbrand2id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_showroomcompetitorsbrand2id");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_showroomcompetitorsbrand2id");
                this.SetAttributeValue("btt_showroomcompetitorsbrand2id", value);
                this.OnPropertyChanged("btt_showroomcompetitorsbrand2id");
            }
        }

        /// <summary>
        /// Unique identifier for Competitor associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_showroomcompetitorsbrand3id")]
        public Microsoft.Xrm.Sdk.EntityReference btt_showroomcompetitorsbrand3id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("btt_showroomcompetitorsbrand3id");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_showroomcompetitorsbrand3id");
                this.SetAttributeValue("btt_showroomcompetitorsbrand3id", value);
                this.OnPropertyChanged("btt_showroomcompetitorsbrand3id");
            }
        }

        /// <summary>
        /// Showroom size
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_showroomsize_pic")]
        public Microsoft.Xrm.Sdk.OptionSetValue Btt_Showroomsize_pic
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("btt_showroomsize_pic");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Showroomsize_pic");
                this.SetAttributeValue("btt_showroomsize_pic", value);
                this.OnPropertyChanged("Btt_Showroomsize_pic");
            }
        }

        /// <summary>
        /// Showroom size
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_showroomsize_pic")]
        public virtual Account_Btt_Showroomsize_pic? Btt_Showroomsize_picEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Btt_Showroomsize_pic?)(EntityOptionSetEnum.GetEnum(this, "btt_showroomsize_pic")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Showroomsize_pic");
                this.SetAttributeValue("btt_showroomsize_pic", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Btt_Showroomsize_pic");
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
        /// Start Date of Service Partner Contract
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_startdateservicepartnercontract")]
        public System.Nullable<System.DateTime> btt_StartDateServicePartnerContract
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_startdateservicepartnercontract");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_StartDateServicePartnerContract");
                this.SetAttributeValue("btt_startdateservicepartnercontract", value);
                this.OnPropertyChanged("btt_StartDateServicePartnerContract");
            }
        }

        /// <summary>
        /// Number of technical employees.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_technicalemployeesnumber")]
        public System.Nullable<int> Btt_technicalemployeesnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_technicalemployeesnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_technicalemployeesnumber");
                this.SetAttributeValue("btt_technicalemployeesnumber", value);
                this.OnPropertyChanged("Btt_technicalemployeesnumber");
            }
        }

        /// <summary>
        /// Total number of appliances (simple)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalnumberappl_simple")]
        public System.Nullable<double> Btt_Totalnumberappl_simple
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_totalnumberappl_simple");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Totalnumberappl_simple");
                this.SetAttributeValue("btt_totalnumberappl_simple", value);
                this.OnPropertyChanged("Btt_Totalnumberappl_simple");
            }
        }

        /// <summary>
        /// Total potential Y-1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential")]
        public Microsoft.Xrm.Sdk.Money Btt_Totalpotential
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Totalpotential");
                this.SetAttributeValue("btt_totalpotential", value);
                this.OnPropertyChanged("Btt_Totalpotential");
            }
        }

        /// <summary>
        /// Value of the Total potential in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential_base")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotential_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential_base");
            }
        }

        /// <summary>
        /// Total Potential Y-2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential_y1")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotential_y1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential_y1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_totalpotential_y1");
                this.SetAttributeValue("btt_totalpotential_y1", value);
                this.OnPropertyChanged("btt_totalpotential_y1");
            }
        }

        /// <summary>
        /// Value of the Total Potential Y-1 in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential_y1_base")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotential_y1_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential_y1_base");
            }
        }

        /// <summary>
        /// Total Potential Y-3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential_y2")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotential_y2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential_y2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_totalpotential_y2");
                this.SetAttributeValue("btt_totalpotential_y2", value);
                this.OnPropertyChanged("btt_totalpotential_y2");
            }
        }

        /// <summary>
        /// Value of the Total Potential Y-2 in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotential_y2_base")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotential_y2_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotential_y2_base");
            }
        }

        /// <summary>
        /// Total potential (complex)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotentialcomplex")]
        public Microsoft.Xrm.Sdk.Money Btt_Totalpotentialcomplex
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotentialcomplex");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Totalpotentialcomplex");
                this.SetAttributeValue("btt_totalpotentialcomplex", value);
                this.OnPropertyChanged("Btt_Totalpotentialcomplex");
            }
        }

        /// <summary>
        /// Value of the Total potential (complex) in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotentialcomplex_base")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotentialcomplex_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotentialcomplex_base");
            }
        }

        /// <summary>
        /// Total potential (estimated)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotentialestimated")]
        public Microsoft.Xrm.Sdk.Money Btt_Totalpotentialestimated
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotentialestimated");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Totalpotentialestimated");
                this.SetAttributeValue("btt_totalpotentialestimated", value);
                this.OnPropertyChanged("Btt_Totalpotentialestimated");
            }
        }

        /// <summary>
        /// Value of the Total potential (estimated) in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotentialestimated_base")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotentialestimated_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotentialestimated_base");
            }
        }

        /// <summary>
        /// Total potential (simple)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotentialsimple")]
        public Microsoft.Xrm.Sdk.Money Btt_Totalpotentialsimple
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotentialsimple");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Totalpotentialsimple");
                this.SetAttributeValue("btt_totalpotentialsimple", value);
                this.OnPropertyChanged("Btt_Totalpotentialsimple");
            }
        }

        /// <summary>
        /// Value of the Total potential (simple) in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_totalpotentialsimple_base")]
        public Microsoft.Xrm.Sdk.Money btt_totalpotentialsimple_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_totalpotentialsimple_base");
            }
        }

        /// <summary>
        /// TT number of appliances (simple)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_numberappl_simple")]
        public System.Nullable<double> Btt_TT_numberappl_simple
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_tt_numberappl_simple");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TT_numberappl_simple");
                this.SetAttributeValue("btt_tt_numberappl_simple", value);
                this.OnPropertyChanged("Btt_TT_numberappl_simple");
            }
        }

        /// <summary>
        /// TT Turnover Y-1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover")]
        public Microsoft.Xrm.Sdk.Money Btt_TT_Turnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TT_Turnover");
                this.SetAttributeValue("btt_tt_turnover", value);
                this.OnPropertyChanged("Btt_TT_Turnover");
            }
        }

        /// <summary>
        /// Value of the TT Turnover in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover_base")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnover_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover_base");
            }
        }

        /// <summary>
        /// TT Turnover Y-2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover_y1")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnover_y1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover_y1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_tt_turnover_y1");
                this.SetAttributeValue("btt_tt_turnover_y1", value);
                this.OnPropertyChanged("btt_tt_turnover_y1");
            }
        }

        /// <summary>
        /// Value of the TT Turnover Y-1 in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover_y1_base")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnover_y1_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover_y1_base");
            }
        }

        /// <summary>
        /// TT Turnover Y-3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover_y2")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnover_y2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover_y2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_tt_turnover_y2");
                this.SetAttributeValue("btt_tt_turnover_y2", value);
                this.OnPropertyChanged("btt_tt_turnover_y2");
            }
        }

        /// <summary>
        /// Value of the TT Turnover Y-2 in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnover_y2_base")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnover_y2_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnover_y2_base");
            }
        }

        /// <summary>
        /// TT Turnover (complex)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnovercomplex")]
        public Microsoft.Xrm.Sdk.Money Btt_TT_Turnovercomplex
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnovercomplex");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TT_Turnovercomplex");
                this.SetAttributeValue("btt_tt_turnovercomplex", value);
                this.OnPropertyChanged("Btt_TT_Turnovercomplex");
            }
        }

        /// <summary>
        /// Value of the TT Turnover (complex) in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnovercomplex_base")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnovercomplex_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnovercomplex_base");
            }
        }

        /// <summary>
        /// TT Turnover (estimated)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnoverestimated")]
        public Microsoft.Xrm.Sdk.Money Btt_TT_Turnoverestimated
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnoverestimated");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TT_Turnoverestimated");
                this.SetAttributeValue("btt_tt_turnoverestimated", value);
                this.OnPropertyChanged("Btt_TT_Turnoverestimated");
            }
        }

        /// <summary>
        /// Value of the TT Turnover (estimated) in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnoverestimated_base")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnoverestimated_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnoverestimated_base");
            }
        }

        /// <summary>
        /// TT Turnover (simple)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnoversimple")]
        public Microsoft.Xrm.Sdk.Money Btt_TT_Turnoversimple
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnoversimple");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TT_Turnoversimple");
                this.SetAttributeValue("btt_tt_turnoversimple", value);
                this.OnPropertyChanged("Btt_TT_Turnoversimple");
            }
        }

        /// <summary>
        /// Value of the TT Turnover (simple) in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_tt_turnoversimple_base")]
        public Microsoft.Xrm.Sdk.Money btt_tt_turnoversimple_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_tt_turnoversimple_base");
            }
        }

        /// <summary>
        /// TT Partner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttpartner")]
        public System.Nullable<bool> btt_TTPartner
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("btt_ttpartner");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_TTPartner");
                this.SetAttributeValue("btt_ttpartner", value);
                this.OnPropertyChanged("btt_TTPartner");
            }
        }

        /// <summary>
        /// TT Partner Program 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttpartnerprogram2")]
        public string btt_TTPartnerProgram2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_ttpartnerprogram2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_TTPartnerProgram2");
                this.SetAttributeValue("btt_ttpartnerprogram2", value);
                this.OnPropertyChanged("btt_TTPartnerProgram2");
            }
        }

        /// <summary>
        /// TT Partner Programm
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttpartnerprogramm")]
        public string btt_ttpartnerprogramm
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_ttpartnerprogramm");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_ttpartnerprogramm");
                this.SetAttributeValue("btt_ttpartnerprogramm", value);
                this.OnPropertyChanged("btt_ttpartnerprogramm");
            }
        }

        /// <summary>
        /// TT Share
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttshare")]
        public System.Nullable<double> Btt_TTShare
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_ttshare");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TTShare");
                this.SetAttributeValue("btt_ttshare", value);
                this.OnPropertyChanged("Btt_TTShare");
            }
        }

        /// <summary>
        /// TT Share Y-1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttshare_y1")]
        public System.Nullable<double> btt_ttshare_y1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_ttshare_y1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_ttshare_y1");
                this.SetAttributeValue("btt_ttshare_y1", value);
                this.OnPropertyChanged("btt_ttshare_y1");
            }
        }

        /// <summary>
        /// TT Share Y-2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_ttshare_y2")]
        public System.Nullable<double> btt_ttshare_y2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("btt_ttshare_y2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_ttshare_y2");
                this.SetAttributeValue("btt_ttshare_y2", value);
                this.OnPropertyChanged("btt_ttshare_y2");
            }
        }

        /// <summary>
        /// Turnover present year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_turnoverpresentyear")]
        public Microsoft.Xrm.Sdk.Money Btt_Turnoverpresentyear
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_turnoverpresentyear");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Turnoverpresentyear");
                this.SetAttributeValue("btt_turnoverpresentyear", value);
                this.OnPropertyChanged("Btt_Turnoverpresentyear");
            }
        }

        /// <summary>
        /// Value of the Turnover present year in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_turnoverpresentyear_base")]
        public Microsoft.Xrm.Sdk.Money btt_turnoverpresentyear_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_turnoverpresentyear_base");
            }
        }

        /// <summary>
        /// Turnover previous year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_turnoverpreviousyear")]
        public Microsoft.Xrm.Sdk.Money Btt_Turnoverpreviousyear
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_turnoverpreviousyear");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_Turnoverpreviousyear");
                this.SetAttributeValue("btt_turnoverpreviousyear", value);
                this.OnPropertyChanged("Btt_Turnoverpreviousyear");
            }
        }

        /// <summary>
        /// Value of the Turnover previous year in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_turnoverpreviousyear_base")]
        public Microsoft.Xrm.Sdk.Money btt_turnoverpreviousyear_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_turnoverpreviousyear_base");
            }
        }

        /// <summary>
        /// Turnover Y-2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_turnovery2")]
        public Microsoft.Xrm.Sdk.Money Btt_TurnoverY2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_turnovery2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_TurnoverY2");
                this.SetAttributeValue("btt_turnovery2", value);
                this.OnPropertyChanged("Btt_TurnoverY2");
            }
        }

        /// <summary>
        /// Value of the Turnover Y-2 in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_turnovery2_base")]
        public Microsoft.Xrm.Sdk.Money btt_turnovery2_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_turnovery2_base");
            }
        }

        /// <summary>
        /// Estimated value per appliance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_valueperappliance")]
        public Microsoft.Xrm.Sdk.Money Btt_valueperappliance
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_valueperappliance");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_valueperappliance");
                this.SetAttributeValue("btt_valueperappliance", value);
                this.OnPropertyChanged("Btt_valueperappliance");
            }
        }

        /// <summary>
        /// Value of the Estimated value per appliance in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_valueperappliance_base")]
        public Microsoft.Xrm.Sdk.Money btt_valueperappliance_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("btt_valueperappliance_base");
            }
        }

        /// <summary>
        /// Visit Planning Reset Date
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitplanningresetdate")]
        public System.Nullable<System.DateTime> btt_visitplanningresetdate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("btt_visitplanningresetdate");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitplanningresetdate");
                this.SetAttributeValue("btt_visitplanningresetdate", value);
                this.OnPropertyChanged("btt_visitplanningresetdate");
            }
        }

        /// <summary>
        /// Visits completed YTD (industry resp.)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitscompletedindustryresp")]
        public System.Nullable<int> btt_visitscompletedindustryresp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_visitscompletedindustryresp");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitscompletedindustryresp");
                this.SetAttributeValue("btt_visitscompletedindustryresp", value);
                this.OnPropertyChanged("btt_visitscompletedindustryresp");
            }
        }

        /// <summary>
        /// Visits completed YTD (primary resp.)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_visitscompletedprimaryresp")]
        public System.Nullable<int> btt_visitscompletedprimaryresp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("btt_visitscompletedprimaryresp");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_visitscompletedprimaryresp");
                this.SetAttributeValue("btt_visitscompletedprimaryresp", value);
                this.OnPropertyChanged("btt_visitscompletedprimaryresp");
            }
        }

        /// <summary>
        /// The other web site URL for the customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_websiteurl2")]
        public string Btt_websiteurl2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("btt_websiteurl2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Btt_websiteurl2");
                this.SetAttributeValue("btt_websiteurl2", value);
                this.OnPropertyChanged("Btt_websiteurl2");
            }
        }

        /// <summary>
        /// Select the legal designation or other business type of the account for contracts or reporting purposes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue BusinessTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("businesstypecode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BusinessTypeCode");
                this.SetAttributeValue("businesstypecode", value);
                this.OnPropertyChanged("BusinessTypeCode");
            }
        }

        /// <summary>
        /// Select the legal designation or other business type of the account for contracts or reporting purposes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesstypecode")]
        public virtual Account_BusinessTypeCode? BusinessTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_BusinessTypeCode?)(EntityOptionSetEnum.GetEnum(this, "businesstypecode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BusinessTypeCode");
                this.SetAttributeValue("businesstypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("BusinessTypeCode");
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
        /// Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.
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
        /// Shows the credit limit converted to the system's default base currency for reporting purposes.
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
        /// Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.
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
        /// Select the size category or range of the account for segmentation and reporting purposes.
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
        /// Select the size category or range of the account for segmentation and reporting purposes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersizecode")]
        public virtual Account_CustomerSizeCode? CustomerSizeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_CustomerSizeCode?)(EntityOptionSetEnum.GetEnum(this, "customersizecode")));
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
        /// Select the category that best describes the relationship between the account and your organization.
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
        /// Select the category that best describes the relationship between the account and your organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customertypecode")]
        public virtual Account_CustomerTypeCode? CustomerTypeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_CustomerTypeCode?)(EntityOptionSetEnum.GetEnum(this, "customertypecode")));
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
        /// Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
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
        /// Type additional information to describe the account, such as an excerpt from the company's website.
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
        /// Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.
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
        /// Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.
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
        /// Select whether the account allows direct email sent from Microsoft Dynamics 365.
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
        /// Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.
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
        /// Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.
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
        /// Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.
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
        /// Select whether the account accepts marketing materials, such as brochures or catalogs.
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
        /// Type the primary email address for the account.
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
        /// Type the secondary email address for the account.
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
        /// Type an alternate email address for the account.
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
        /// Type the fax number for the account.
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
        /// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the account.
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
        /// Type the URL for the account's FTP site to enable users to access data and share documents.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
        public string FtpSiteURL
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ftpsiteurl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FtpSiteURL");
                this.SetAttributeValue("ftpsiteurl", value);
                this.OnPropertyChanged("FtpSiteURL");
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
        /// Select the account's primary industry for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IndustryCode");
                this.SetAttributeValue("industrycode", value);
                this.OnPropertyChanged("IndustryCode");
            }
        }

        /// <summary>
        /// Select the account's primary industry for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
        public virtual Account_IndustryCode? IndustryCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_IndustryCode?)(EntityOptionSetEnum.GetEnum(this, "industrycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IndustryCode");
                this.SetAttributeValue("industrycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("IndustryCode");
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
        /// Shows the date when the account was last included in a marketing campaign or quick campaign.
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
        /// Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap")]
        public Microsoft.Xrm.Sdk.Money MarketCap
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MarketCap");
                this.SetAttributeValue("marketcap", value);
                this.OnPropertyChanged("MarketCap");
            }
        }

        /// <summary>
        /// Shows the market capitalization converted to the system's default base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("marketcap_base")]
        public Microsoft.Xrm.Sdk.Money MarketCap_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap_base");
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
        /// Shows the master account that the account was merged with.
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
        /// Shows whether the account has been merged with another account.
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
        /// Shows who created the record on behalf of another user.
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
        /// Type the company or business name.
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
        /// Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
        public System.Nullable<int> NumberOfEmployees
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("NumberOfEmployees");
                this.SetAttributeValue("numberofemployees", value);
                this.OnPropertyChanged("NumberOfEmployees");
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
        /// Number of open opportunities against an account and its child accounts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals")]
        public System.Nullable<int> OpenDeals
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("opendeals");
            }
        }

        /// <summary>
        /// The date time for Open Deals.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_date")]
        public System.Nullable<System.DateTime> OpenDeals_Date
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("opendeals_date");
            }
        }

        /// <summary>
        /// State of Open Deals.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opendeals_state")]
        public System.Nullable<int> OpenDeals_State
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("opendeals_state");
            }
        }

        /// <summary>
        /// Sum of open revenue against an account and its child accounts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue")]
        public Microsoft.Xrm.Sdk.Money OpenRevenue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue");
            }
        }

        /// <summary>
        /// Sum of open revenue against an account and its child accounts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_base")]
        public Microsoft.Xrm.Sdk.Money OpenRevenue_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue_base");
            }
        }

        /// <summary>
        /// The date time for Open Revenue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_date")]
        public System.Nullable<System.DateTime> OpenRevenue_Date
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("openrevenue_date");
            }
        }

        /// <summary>
        /// State of Open Revenue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("openrevenue_state")]
        public System.Nullable<int> OpenRevenue_State
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("openrevenue_state");
            }
        }

        /// <summary>
        /// Border: C - D
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_bordercd")]
        public System.Nullable<double> Orb_BorderCD
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_bordercd");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_BorderCD");
                this.SetAttributeValue("orb_bordercd", value);
                this.OnPropertyChanged("Orb_BorderCD");
            }
        }

        /// <summary>
        /// ABC Status
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classification")]
        public string Orb_classification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_classification");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_classification");
                this.SetAttributeValue("orb_classification", value);
                this.OnPropertyChanged("Orb_classification");
            }
        }

        /// <summary>
        /// Unique identifier for ClassificationBase associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classificationbaseid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_classificationbaseid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_classificationbaseid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_classificationbaseid");
                this.SetAttributeValue("orb_classificationbaseid", value);
                this.OnPropertyChanged("orb_classificationbaseid");
            }
        }

        /// <summary>
        /// Calculation method
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_complexitycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Orb_complexitycode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("orb_complexitycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_complexitycode");
                this.SetAttributeValue("orb_complexitycode", value);
                this.OnPropertyChanged("Orb_complexitycode");
            }
        }

        /// <summary>
        /// Calculation method
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_complexitycode")]
        public virtual Account_Orb_complexitycode? Orb_complexitycodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Orb_complexitycode?)(EntityOptionSetEnum.GetEnum(this, "orb_complexitycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_complexitycode");
                this.SetAttributeValue("orb_complexitycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Orb_complexitycode");
            }
        }

        /// <summary>
        /// Unique identifier for country associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_countryid")]
        public Microsoft.Xrm.Sdk.EntityReference orb_countryid
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("orb_countryid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_countryid");
                this.SetAttributeValue("orb_countryid", value);
                this.OnPropertyChanged("orb_countryid");
            }
        }

        /// <summary>
        /// Estimated turnover per employee
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_estimatedturnover")]
        public System.Nullable<double> Orb_estimatedturnover
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_estimatedturnover");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_estimatedturnover");
                this.SetAttributeValue("orb_estimatedturnover", value);
                this.OnPropertyChanged("Orb_estimatedturnover");
            }
        }

        /// <summary>
        /// Last completed appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_lastscheduledappointment")]
        public System.Nullable<System.DateTime> Orb_lastscheduledappointment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_lastscheduledappointment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_lastscheduledappointment");
                this.SetAttributeValue("orb_lastscheduledappointment", value);
                this.OnPropertyChanged("Orb_lastscheduledappointment");
            }
        }

        /// <summary>
        /// Name 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_name2")]
        public string Orb_name2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_name2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_name2");
                this.SetAttributeValue("orb_name2", value);
                this.OnPropertyChanged("Orb_name2");
            }
        }

        /// <summary>
        /// Name 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_name3")]
        public string Orb_name3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_name3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_name3");
                this.SetAttributeValue("orb_name3", value);
                this.OnPropertyChanged("Orb_name3");
            }
        }

        /// <summary>
        /// Proposal next appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_nextappointment")]
        public System.Nullable<System.DateTime> Orb_nextappointment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_nextappointment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_nextappointment");
                this.SetAttributeValue("orb_nextappointment", value);
                this.OnPropertyChanged("Orb_nextappointment");
            }
        }

        /// <summary>
        /// Next planned appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_nextscheduledappointment")]
        public System.Nullable<System.DateTime> Orb_nextscheduledappointment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_nextscheduledappointment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_nextscheduledappointment");
                this.SetAttributeValue("orb_nextscheduledappointment", value);
                this.OnPropertyChanged("Orb_nextscheduledappointment");
            }
        }

        /// <summary>
        /// Proposal 2.nd next Appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_nextsecondappointment")]
        public System.Nullable<System.DateTime> Orb_nextsecondappointment
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("orb_nextsecondappointment");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_nextsecondappointment");
                this.SetAttributeValue("orb_nextsecondappointment", value);
                this.OnPropertyChanged("Orb_nextsecondappointment");
            }
        }

        /// <summary>
        /// Total potential per year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potential")]
        public System.Nullable<double> Orb_potential
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potential");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potential");
                this.SetAttributeValue("orb_potential", value);
                this.OnPropertyChanged("Orb_potential");
            }
        }

        /// <summary>
        /// Border: x2 - x1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentiala")]
        public System.Nullable<double> Orb_potentiala
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentiala");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentiala");
                this.SetAttributeValue("orb_potentiala", value);
                this.OnPropertyChanged("Orb_potentiala");
            }
        }

        /// <summary>
        /// Border: x3 - x2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_potentialb")]
        public System.Nullable<double> Orb_potentialb
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_potentialb");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_potentialb");
                this.SetAttributeValue("orb_potentialb", value);
                this.OnPropertyChanged("Orb_potentialb");
            }
        }

        /// <summary>
        /// The preferred appointment day code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_preferredappointmentdaycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Orb_preferredappointmentdaycode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("orb_preferredappointmentdaycode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_preferredappointmentdaycode");
                this.SetAttributeValue("orb_preferredappointmentdaycode", value);
                this.OnPropertyChanged("Orb_preferredappointmentdaycode");
            }
        }

        /// <summary>
        /// The preferred appointment day code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_preferredappointmentdaycode")]
        public virtual Account_Orb_preferredappointmentdaycode? Orb_preferredappointmentdaycodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_Orb_preferredappointmentdaycode?)(EntityOptionSetEnum.GetEnum(this, "orb_preferredappointmentdaycode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_preferredappointmentdaycode");
                this.SetAttributeValue("orb_preferredappointmentdaycode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("Orb_preferredappointmentdaycode");
            }
        }

        /// <summary>
        /// Reorg Flag
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_reorgflag")]
        public System.Nullable<bool> Orb_reorgflag
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("orb_reorgflag");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_reorgflag");
                this.SetAttributeValue("orb_reorgflag", value);
                this.OnPropertyChanged("Orb_reorgflag");
            }
        }

        /// <summary>
        /// Tour
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_tour")]
        public string Orb_tour
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_tour");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_tour");
                this.SetAttributeValue("orb_tour", value);
                this.OnPropertyChanged("Orb_tour");
            }
        }

        /// <summary>
        /// Border: A - B  represents TT share of customer wallet
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_useofpotential1")]
        public System.Nullable<double> Orb_useofpotential1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_useofpotential1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_useofpotential1");
                this.SetAttributeValue("orb_useofpotential1", value);
                this.OnPropertyChanged("Orb_useofpotential1");
            }
        }

        /// <summary>
        /// Border: B - C
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_useofpotential2")]
        public System.Nullable<double> Orb_useofpotential2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("orb_useofpotential2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_useofpotential2");
                this.SetAttributeValue("orb_useofpotential2", value);
                this.OnPropertyChanged("Orb_useofpotential2");
            }
        }

        /// <summary>
        /// value added tax identification number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_vatnumber")]
        public string Orb_vatnumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("orb_vatnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_vatnumber");
                this.SetAttributeValue("orb_vatnumber", value);
                this.OnPropertyChanged("Orb_vatnumber");
            }
        }

        /// <summary>
        /// Visits completed YTD.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_visitcountactual")]
        public System.Nullable<int> Orb_visitcountactual
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("orb_visitcountactual");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_visitcountactual");
                this.SetAttributeValue("orb_visitcountactual", value);
                this.OnPropertyChanged("Orb_visitcountactual");
            }
        }

        /// <summary>
        /// Visits count planned.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_visitcountplanned")]
        public System.Nullable<int> Orb_visitcountplanned
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("orb_visitcountplanned");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Orb_visitcountplanned");
                this.SetAttributeValue("orb_visitcountplanned", value);
                this.OnPropertyChanged("Orb_visitcountplanned");
            }
        }

        /// <summary>
        /// Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics 365. This is used to relate the account to data on the originating lead for use in reporting and analytics.
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
        /// Select the account's ownership structure, such as public or private.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue OwnershipCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ownershipcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwnershipCode");
                this.SetAttributeValue("ownershipcode", value);
                this.OnPropertyChanged("OwnershipCode");
            }
        }

        /// <summary>
        /// Select the account's ownership structure, such as public or private.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownershipcode")]
        public virtual Account_OwnershipCode? OwnershipCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_OwnershipCode?)(EntityOptionSetEnum.GetEnum(this, "ownershipcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwnershipCode");
                this.SetAttributeValue("ownershipcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("OwnershipCode");
            }
        }

        /// <summary>
        /// Shows the business unit that the record owner belongs to.
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
        /// Unique identifier of the team who owns the account.
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
        /// Unique identifier of the user who owns the account.
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
        /// Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentAccountId");
                this.SetAttributeValue("parentaccountid", value);
                this.OnPropertyChanged("ParentAccountId");
            }
        }

        /// <summary>
        /// For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.
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
        public virtual Account_PaymentTermsCode? PaymentTermsCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_PaymentTermsCode?)(EntityOptionSetEnum.GetEnum(this, "paymenttermscode")));
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
        public virtual Account_PreferredAppointmentDayCode? PreferredAppointmentDayCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_PreferredAppointmentDayCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmentdaycode")));
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
        public virtual Account_PreferredAppointmentTimeCode? PreferredAppointmentTimeCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_PreferredAppointmentTimeCode?)(EntityOptionSetEnum.GetEnum(this, "preferredappointmenttimecode")));
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
        public virtual Account_PreferredContactMethodCode? PreferredContactMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_PreferredContactMethodCode?)(EntityOptionSetEnum.GetEnum(this, "preferredcontactmethodcode")));
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
        /// Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
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
        /// Choose the account's preferred service for reference when you schedule service activities.
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
        /// Choose the preferred service representative for reference when you schedule service activities for the account.
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
        /// Choose the primary contact for the account to provide quick access to contact details.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
        public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PrimaryContactId");
                this.SetAttributeValue("primarycontactid", value);
                this.OnPropertyChanged("PrimaryContactId");
            }
        }

        /// <summary>
        /// Primary Satori ID for Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarysatoriid")]
        public string PrimarySatoriId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("primarysatoriid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PrimarySatoriId");
                this.SetAttributeValue("primarysatoriid", value);
                this.OnPropertyChanged("PrimarySatoriId");
            }
        }

        /// <summary>
        /// Primary Twitter ID for Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarytwitterid")]
        public string PrimaryTwitterId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("primarytwitterid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PrimaryTwitterId");
                this.SetAttributeValue("primarytwitterid", value);
                this.OnPropertyChanged("PrimaryTwitterId");
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
        /// ABC Status Plan
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_abcstatusplan")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_ABCStatusPlan
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_abcstatusplan");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ABCStatusPlan");
                this.SetAttributeValue("rbtt_abcstatusplan", value);
                this.OnPropertyChanged("rbtt_ABCStatusPlan");
            }
        }

        /// <summary>
        /// ABC Status Plan
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_abcstatusplan")]
        public virtual rbtt_ABCStatusPlan? rbtt_ABCStatusPlanEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_ABCStatusPlan?)(EntityOptionSetEnum.GetEnum(this, "rbtt_abcstatusplan")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ABCStatusPlan");
                this.SetAttributeValue("rbtt_abcstatusplan", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_ABCStatusPlan");
            }
        }

        /// <summary>
        /// Unique identifier for System Registration associated with Account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_account_mappingid")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Account_MappingId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_account_mappingid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Account_MappingId");
                this.SetAttributeValue("rbtt_account_mappingid", value);
                this.OnPropertyChanged("rbtt_Account_MappingId");
            }
        }

        /// <summary>
        /// Appointment Overdue
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_appointmentoverdue")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_AppointmentOverdue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_appointmentoverdue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_AppointmentOverdue");
                this.SetAttributeValue("rbtt_appointmentoverdue", value);
                this.OnPropertyChanged("rbtt_AppointmentOverdue");
            }
        }

        /// <summary>
        /// Appointment Overdue
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_appointmentoverdue")]
        public virtual Account_rbtt_AppointmentOverdue? rbtt_AppointmentOverdueEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_rbtt_AppointmentOverdue?)(EntityOptionSetEnum.GetEnum(this, "rbtt_appointmentoverdue")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_AppointmentOverdue");
                this.SetAttributeValue("rbtt_appointmentoverdue", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_AppointmentOverdue");
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
        /// Code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_code")]
        public string rbtt_Code
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_code");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Code");
                this.SetAttributeValue("rbtt_code", value);
                this.OnPropertyChanged("rbtt_Code");
            }
        }

        /// <summary>
        /// Show the count of all installed assets for the particular customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_customerassettotal")]
        public System.Nullable<int> rbtt_CustomerAssetTotal
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_customerassettotal");
            }
        }

        /// <summary>
        /// Last Updated time of rollup field Customer Asset:Total.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_customerassettotal_date")]
        public System.Nullable<System.DateTime> rbtt_CustomerAssetTotal_Date
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("rbtt_customerassettotal_date");
            }
        }

        /// <summary>
        /// State of rollup field Customer Asset:Total.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_customerassettotal_state")]
        public System.Nullable<int> rbtt_CustomerAssetTotal_State
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_customerassettotal_state");
            }
        }

        /// <summary>
        /// When set as True, the Account is triggered to be synchronized with the SAP ERP system.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_customermasterdata")]
        public System.Nullable<bool> rbtt_CustomerMasterData
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_customermasterdata");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_CustomerMasterData");
                this.SetAttributeValue("rbtt_customermasterdata", value);
                this.OnPropertyChanged("rbtt_CustomerMasterData");
            }
        }

        /// <summary>
        /// Account/ Company ERP number as customer of TT
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_erpcustomernumber")]
        public string rbtt_ERPCustomerNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_erpcustomernumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ERPCustomerNumber");
                this.SetAttributeValue("rbtt_erpcustomernumber", value);
                this.OnPropertyChanged("rbtt_ERPCustomerNumber");
            }
        }

        /// <summary>
        /// Identifies the ERP number when the customer has different branches
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_erpshiptonumber")]
        public string rbtt_ERPShiptoNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_erpshiptonumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ERPShiptoNumber");
                this.SetAttributeValue("rbtt_erpshiptonumber", value);
                this.OnPropertyChanged("rbtt_ERPShiptoNumber");
            }
        }

        /// <summary>
        /// Identifies the supplier, when the customer of TT is a supplier of TT as well
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_erpsuppliernumber")]
        public string rbtt_ERPSupplierNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_erpsuppliernumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_ERPSupplierNumber");
                this.SetAttributeValue("rbtt_erpsuppliernumber", value);
                this.OnPropertyChanged("rbtt_ERPSupplierNumber");
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
        /// Global PP in use
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_globalppinuse")]
        public System.Nullable<bool> rbtt_GlobalPPinuse
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rbtt_globalppinuse");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GlobalPPinuse");
                this.SetAttributeValue("rbtt_globalppinuse", value);
                this.OnPropertyChanged("rbtt_GlobalPPinuse");
            }
        }

        /// <summary>
        /// Gratuities Total: last year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gratuitiestotaly1")]
        public Microsoft.Xrm.Sdk.Money rbtt_GratuitiesTotalY1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rbtt_gratuitiestotaly1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GratuitiesTotalY1");
                this.SetAttributeValue("rbtt_gratuitiestotaly1", value);
                this.OnPropertyChanged("rbtt_GratuitiesTotalY1");
            }
        }

        /// <summary>
        /// Value of the Gratuities Total YTD-1 in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gratuitiestotaly1_base")]
        public Microsoft.Xrm.Sdk.Money rbtt_gratuitiestotaly1_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rbtt_gratuitiestotaly1_base");
            }
        }

        /// <summary>
        /// Gratuities Total: current year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gratuitiestotalytd")]
        public Microsoft.Xrm.Sdk.Money rbtt_GratuitiesTotalYTD
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rbtt_gratuitiestotalytd");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_GratuitiesTotalYTD");
                this.SetAttributeValue("rbtt_gratuitiestotalytd", value);
                this.OnPropertyChanged("rbtt_GratuitiesTotalYTD");
            }
        }

        /// <summary>
        /// Value of the Gratuities Total YTD in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_gratuitiestotalytd_base")]
        public Microsoft.Xrm.Sdk.Money rbtt_gratuitiestotalytd_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rbtt_gratuitiestotalytd_base");
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
        /// Blocked by GS
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
        /// This field indicate the base language of the customer, not limit the language of each contact in the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_language")]
        public Microsoft.Xrm.Sdk.EntityReference rbtt_Language
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rbtt_language");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Language");
                this.SetAttributeValue("rbtt_language", value);
                this.OnPropertyChanged("rbtt_Language");
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_name")]
        public string rbtt_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_name");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_Name");
                this.SetAttributeValue("rbtt_name", value);
                this.OnPropertyChanged("rbtt_Name");
            }
        }

        /// <summary>
        /// No. of Registrations Y-1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_noofregistrationsy1")]
        public System.Nullable<int> rbtt_NoofRegistrationsY1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_noofregistrationsy1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_NoofRegistrationsY1");
                this.SetAttributeValue("rbtt_noofregistrationsy1", value);
                this.OnPropertyChanged("rbtt_NoofRegistrationsY1");
            }
        }

        /// <summary>
        /// No. of Registrations Y-2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_noofregistrationsy2")]
        public System.Nullable<int> rbtt_NoofRegistrationsY2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_noofregistrationsy2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_NoofRegistrationsY2");
                this.SetAttributeValue("rbtt_noofregistrationsy2", value);
                this.OnPropertyChanged("rbtt_NoofRegistrationsY2");
            }
        }

        /// <summary>
        /// No. of Registrations YTD
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_noofregistrationsytd")]
        public System.Nullable<int> rbtt_NoofRegistrationsYTD
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_noofregistrationsytd");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_NoofRegistrationsYTD");
                this.SetAttributeValue("rbtt_noofregistrationsytd", value);
                this.OnPropertyChanged("rbtt_NoofRegistrationsYTD");
            }
        }

        /// <summary>
        /// Organization ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_organizationid")]
        public string rbtt_OrganizationID
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_organizationid");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_OrganizationID");
                this.SetAttributeValue("rbtt_organizationid", value);
                this.OnPropertyChanged("rbtt_OrganizationID");
            }
        }

        /// <summary>
        /// Shows the Partner Level from partner program (eg. Bronze, Silver, Gold,..)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_partnerlevel")]
        public string rbtt_PartnerLevel
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_partnerlevel");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PartnerLevel");
                this.SetAttributeValue("rbtt_partnerlevel", value);
                this.OnPropertyChanged("rbtt_PartnerLevel");
            }
        }

        /// <summary>
        /// Partner Status from Partner Program
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_partnerstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_PartnerStatus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_partnerstatus");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PartnerStatus");
                this.SetAttributeValue("rbtt_partnerstatus", value);
                this.OnPropertyChanged("rbtt_PartnerStatus");
            }
        }

        /// <summary>
        /// Partner Status from Partner Program
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_partnerstatus")]
        public virtual rbtt_PartnerStatusList? rbtt_PartnerStatusEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_PartnerStatusList?)(EntityOptionSetEnum.GetEnum(this, "rbtt_partnerstatus")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_PartnerStatus");
                this.SetAttributeValue("rbtt_partnerstatus", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_PartnerStatus");
            }
        }

        /// <summary>
        /// The preferred appointment rhythm code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_preferredappointmentrhythmcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_preferredappointmentrhythmcode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_preferredappointmentrhythmcode");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_preferredappointmentrhythmcode");
                this.SetAttributeValue("rbtt_preferredappointmentrhythmcode", value);
                this.OnPropertyChanged("rbtt_preferredappointmentrhythmcode");
            }
        }

        /// <summary>
        /// The preferred appointment rhythm code
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_preferredappointmentrhythmcode")]
        public virtual btt_RhythmCode? rbtt_preferredappointmentrhythmcodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_RhythmCode?)(EntityOptionSetEnum.GetEnum(this, "rbtt_preferredappointmentrhythmcode")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_preferredappointmentrhythmcode");
                this.SetAttributeValue("rbtt_preferredappointmentrhythmcode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_preferredappointmentrhythmcode");
            }
        }

        /// <summary>
        /// Answer 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_regq1a3")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_RegQ1A3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_regq1a3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RegQ1A3");
                this.SetAttributeValue("rbtt_regq1a3", value);
                this.OnPropertyChanged("rbtt_RegQ1A3");
            }
        }

        /// <summary>
        /// Answer 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_regq1a3")]
        public virtual rbtt_DistanceList? rbtt_RegQ1A3Enum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_DistanceList?)(EntityOptionSetEnum.GetEnum(this, "rbtt_regq1a3")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RegQ1A3");
                this.SetAttributeValue("rbtt_regq1a3", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_RegQ1A3");
            }
        }

        /// <summary>
        /// Relations Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_relationsemail")]
        public string rbtt_RelationsEmail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_relationsemail");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RelationsEmail");
                this.SetAttributeValue("rbtt_relationsemail", value);
                this.OnPropertyChanged("rbtt_RelationsEmail");
            }
        }

        /// <summary>
        /// Relations Number
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_relationsnumber")]
        public string rbtt_RelationsNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_relationsnumber");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RelationsNumber");
                this.SetAttributeValue("rbtt_relationsnumber", value);
                this.OnPropertyChanged("rbtt_RelationsNumber");
            }
        }

        /// <summary>
        /// Relations Role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_relationsrole")]
        public string rbtt_RelationsRole
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("rbtt_relationsrole");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RelationsRole");
                this.SetAttributeValue("rbtt_relationsrole", value);
                this.OnPropertyChanged("rbtt_RelationsRole");
            }
        }

        /// <summary>
        /// Rhythm Code adjusted by manager
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_rhythmcodeadjustedbymanager")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_RhythmCodeadjustedbymanager
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_rhythmcodeadjustedbymanager");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RhythmCodeadjustedbymanager");
                this.SetAttributeValue("rbtt_rhythmcodeadjustedbymanager", value);
                this.OnPropertyChanged("rbtt_RhythmCodeadjustedbymanager");
            }
        }

        /// <summary>
        /// Rhythm Code adjusted by manager
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_rhythmcodeadjustedbymanager")]
        public virtual btt_RhythmCode? rbtt_RhythmCodeadjustedbymanagerEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((btt_RhythmCode?)(EntityOptionSetEnum.GetEnum(this, "rbtt_rhythmcodeadjustedbymanager")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_RhythmCodeadjustedbymanager");
                this.SetAttributeValue("rbtt_rhythmcodeadjustedbymanager", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_RhythmCodeadjustedbymanager");
            }
        }

        /// <summary>
        /// The information maintained in this field is used to can activate the Customer Master Data interface with the right ERP Sales Organization
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
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_segmentationtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue rbtt_SegmentationType
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("rbtt_segmentationtype");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SegmentationType");
                this.SetAttributeValue("rbtt_segmentationtype", value);
                this.OnPropertyChanged("rbtt_SegmentationType");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_segmentationtype")]
        public virtual rbtt_SegmentationType? rbtt_SegmentationTypeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((rbtt_SegmentationType?)(EntityOptionSetEnum.GetEnum(this, "rbtt_segmentationtype")));
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_SegmentationType");
                this.SetAttributeValue("rbtt_segmentationtype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
                this.OnPropertyChanged("rbtt_SegmentationType");
            }
        }

        /// <summary>
        /// Total No. of Registrations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_totalnoofregistrations")]
        public System.Nullable<int> rbtt_TotalNoofRegistrations
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rbtt_totalnoofregistrations");
            }
        }

        /// <summary>
        /// Type the annual revenue for the account, used as an indicator in financial performance analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
        public Microsoft.Xrm.Sdk.Money Revenue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Revenue");
                this.SetAttributeValue("revenue", value);
                this.OnPropertyChanged("Revenue");
            }
        }

        /// <summary>
        /// Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
        public Microsoft.Xrm.Sdk.Money Revenue_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base");
            }
        }

        /// <summary>
        /// Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharesoutstanding")]
        public System.Nullable<int> SharesOutstanding
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("sharesoutstanding");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SharesOutstanding");
                this.SetAttributeValue("sharesoutstanding", value);
                this.OnPropertyChanged("SharesOutstanding");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.
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
        /// Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
        public virtual Account_ShippingMethodCode? ShippingMethodCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_ShippingMethodCode?)(EntityOptionSetEnum.GetEnum(this, "shippingmethodcode")));
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
        /// Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
        public string SIC
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("sic");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SIC");
                this.SetAttributeValue("sic", value);
                this.OnPropertyChanged("SIC");
            }
        }

        /// <summary>
        /// Choose the service level agreement (SLA) that you want to apply to the Account record.
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
        /// Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Ttms.Crm.FunctionApp.Shared.EntityModel.AccountState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((Ttms.Crm.FunctionApp.Shared.EntityModel.AccountState)(System.Enum.ToObject(typeof(Ttms.Crm.FunctionApp.Shared.EntityModel.AccountState), optionSet.Value)));
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
        /// Status reason of the account.
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
        /// Status reason of the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public virtual Account_StatusCode? StatusCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
        /// Type the stock exchange at which the account is listed to track their stock and financial performance of the company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
        public string StockExchange
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("stockexchange");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StockExchange");
                this.SetAttributeValue("stockexchange", value);
                this.OnPropertyChanged("StockExchange");
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
        /// Type the main phone number for this account.
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
        /// Type a second phone number for this account.
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
        /// Type a third phone number for this account.
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
        /// Select a region or territory for the account for use in segmentation and analysis.
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
        /// Select a region or territory for the account for use in segmentation and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territorycode")]
        public virtual Account_TerritoryCode? TerritoryCodeEnum
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return ((Account_TerritoryCode?)(EntityOptionSetEnum.GetEnum(this, "territorycode")));
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
        /// Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.
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
        /// Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
        public string TickerSymbol
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("tickersymbol");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TickerSymbol");
                this.SetAttributeValue("tickersymbol", value);
                this.OnPropertyChanged("TickerSymbol");
            }
        }

        /// <summary>
        /// Total time spent for emails (read and write) and meetings by me in relation to account record.
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
        /// Code NAF 2003
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_codenaf")]
        public string TTFR_CodeNAF
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ttfr_codenaf");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_CodeNAF");
                this.SetAttributeValue("ttfr_codenaf", value);
                this.OnPropertyChanged("TTFR_CodeNAF");
            }
        }

        /// <summary>
        /// Code NAF 2008
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_codenaf_2")]
        public string Ttfr_CodeNAF_2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ttfr_codenaf_2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Ttfr_CodeNAF_2");
                this.SetAttributeValue("ttfr_codenaf_2", value);
                this.OnPropertyChanged("Ttfr_CodeNAF_2");
            }
        }

        /// <summary>
        /// Code siren/siret
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_codesirensiret")]
        public string TTFR_Codesirensiret
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ttfr_codesirensiret");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_Codesirensiret");
                this.SetAttributeValue("ttfr_codesirensiret", value);
                this.OnPropertyChanged("TTFR_Codesirensiret");
            }
        }

        /// <summary>
        /// Kompass number of the Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_numkompass")]
        public string TTFR_Numkompass
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ttfr_numkompass");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_Numkompass");
                this.SetAttributeValue("ttfr_numkompass", value);
                this.OnPropertyChanged("TTFR_Numkompass");
            }
        }

        /// <summary>
        /// PG
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_org_propg")]
        public System.Nullable<bool> TTFR_org_proPG
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ttfr_org_propg");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_org_proPG");
                this.SetAttributeValue("ttfr_org_propg", value);
                this.OnPropertyChanged("TTFR_org_proPG");
            }
        }

        /// <summary>
        /// Qualibois
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_org_proqualibois")]
        public System.Nullable<bool> TTFR_org_proQualibois
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ttfr_org_proqualibois");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_org_proQualibois");
                this.SetAttributeValue("ttfr_org_proqualibois", value);
                this.OnPropertyChanged("TTFR_org_proQualibois");
            }
        }

        /// <summary>
        /// Qualipac
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_org_proqualipac")]
        public System.Nullable<bool> TTFR_org_proQualipac
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ttfr_org_proqualipac");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_org_proQualipac");
                this.SetAttributeValue("ttfr_org_proqualipac", value);
                this.OnPropertyChanged("TTFR_org_proQualipac");
            }
        }

        /// <summary>
        /// Qualisol CESI
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_org_proqualisolcesi")]
        public System.Nullable<bool> TTFR_org_proQualisolCESI
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ttfr_org_proqualisolcesi");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_org_proQualisolCESI");
                this.SetAttributeValue("ttfr_org_proqualisolcesi", value);
                this.OnPropertyChanged("TTFR_org_proQualisolCESI");
            }
        }

        /// <summary>
        /// Qualisol SSC
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_org_proqualisolssc")]
        public System.Nullable<bool> TTFR_org_proQualisolSSC
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ttfr_org_proqualisolssc");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_org_proQualisolSSC");
                this.SetAttributeValue("ttfr_org_proqualisolssc", value);
                this.OnPropertyChanged("TTFR_org_proQualisolSSC");
            }
        }

        /// <summary>
        /// Wording NAF 2003
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_wordingnaf")]
        public string TTFR_WordingNAF
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ttfr_wordingnaf");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTFR_WordingNAF");
                this.SetAttributeValue("ttfr_wordingnaf", value);
                this.OnPropertyChanged("TTFR_WordingNAF");
            }
        }

        /// <summary>
        /// Wording NAF 2008
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttfr_wordingnaf_2")]
        public string Ttfr_WordingNAF_2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("ttfr_wordingnaf_2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Ttfr_WordingNAF_2");
                this.SetAttributeValue("ttfr_wordingnaf_2", value);
                this.OnPropertyChanged("Ttfr_WordingNAF_2");
            }
        }

        /// <summary>
        /// Base Discount
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_basediscount")]
        public System.Nullable<decimal> TTIB_BaseDiscount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_basediscount");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_BaseDiscount");
                this.SetAttributeValue("ttib_basediscount", value);
                this.OnPropertyChanged("TTIB_BaseDiscount");
            }
        }

        /// <summary>
        /// Discount componet 1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_discountcomponet1")]
        public System.Nullable<decimal> TTIB_Discountcomponet1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_discountcomponet1");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Discountcomponet1");
                this.SetAttributeValue("ttib_discountcomponet1", value);
                this.OnPropertyChanged("TTIB_Discountcomponet1");
            }
        }

        /// <summary>
        /// Discount componet 2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_discountcomponet2")]
        public System.Nullable<decimal> TTIB_Discountcomponet2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_discountcomponet2");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Discountcomponet2");
                this.SetAttributeValue("ttib_discountcomponet2", value);
                this.OnPropertyChanged("TTIB_Discountcomponet2");
            }
        }

        /// <summary>
        /// Discount componet 3
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_discountcomponet3")]
        public System.Nullable<decimal> TTIB_Discountcomponet3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_discountcomponet3");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Discountcomponet3");
                this.SetAttributeValue("ttib_discountcomponet3", value);
                this.OnPropertyChanged("TTIB_Discountcomponet3");
            }
        }

        /// <summary>
        /// Discount componet 4
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_discountcomponet4")]
        public System.Nullable<decimal> TTIB_Discountcomponet4
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_discountcomponet4");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Discountcomponet4");
                this.SetAttributeValue("ttib_discountcomponet4", value);
                this.OnPropertyChanged("TTIB_Discountcomponet4");
            }
        }

        /// <summary>
        /// Discount componet 5
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_discountcomponet5")]
        public System.Nullable<decimal> TTIB_Discountcomponet5
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_discountcomponet5");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Discountcomponet5");
                this.SetAttributeValue("ttib_discountcomponet5", value);
                this.OnPropertyChanged("TTIB_Discountcomponet5");
            }
        }

        /// <summary>
        /// Discount componet 6
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_discountcomponet6")]
        public System.Nullable<decimal> TTIB_Discountcomponet6
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_discountcomponet6");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Discountcomponet6");
                this.SetAttributeValue("ttib_discountcomponet6", value);
                this.OnPropertyChanged("TTIB_Discountcomponet6");
            }
        }

        /// <summary>
        /// Discount componet 7
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_discountcomponet7")]
        public System.Nullable<decimal> TTIB_Discountcomponet7
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("ttib_discountcomponet7");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Discountcomponet7");
                this.SetAttributeValue("ttib_discountcomponet7", value);
                this.OnPropertyChanged("TTIB_Discountcomponet7");
            }
        }

        /// <summary>
        /// Veicoli Auto
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_veicoli")]
        public System.Nullable<int> TTIB_Veicoli
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("ttib_veicoli");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_Veicoli");
                this.SetAttributeValue("ttib_veicoli", value);
                this.OnPropertyChanged("TTIB_Veicoli");
            }
        }

        /// <summary>
        /// Veicoli Camion
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_veicolicamion")]
        public System.Nullable<int> TTIB_VeicoliCamion
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("ttib_veicolicamion");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_VeicoliCamion");
                this.SetAttributeValue("ttib_veicolicamion", value);
                this.OnPropertyChanged("TTIB_VeicoliCamion");
            }
        }

        /// <summary>
        /// Veicoli Veicoli Leggeri
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ttib_veicoliveicolileggeri")]
        public System.Nullable<int> TTIB_VeicoliVeicoliLeggeri
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("ttib_veicoliveicolileggeri");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TTIB_VeicoliVeicoliLeggeri");
                this.SetAttributeValue("ttib_veicoliveicolileggeri", value);
                this.OnPropertyChanged("TTIB_VeicoliVeicoliLeggeri");
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
        /// Version number of the account.
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
        /// Type the account's website URL to get quick details about the company profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
        public string WebSiteURL
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("websiteurl");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("WebSiteURL");
                this.SetAttributeValue("websiteurl", value);
                this.OnPropertyChanged("WebSiteURL");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
        public string YomiName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetAttributeValue<string>("yominame");
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiName");
                this.SetAttributeValue("yominame", value);
                this.OnPropertyChanged("YomiName");
            }
        }

        /// <summary>
        /// 1:N account_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty> account_activity_parties
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("account_activity_parties", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("account_activity_parties");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.ActivityParty>("account_activity_parties", null, value);
                this.OnPropertyChanged("account_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Account_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Appointments")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment> Account_Appointments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Account_Appointments", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Appointments");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Appointment>("Account_Appointments", null, value);
                this.OnPropertyChanged("Account_Appointments");
            }
        }

        /// <summary>
        /// 1:N Account_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Account_Email_EmailSender
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Account_Email_EmailSender", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Email_EmailSender");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Account_Email_EmailSender", null, value);
                this.OnPropertyChanged("Account_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N Account_Email_SendersAccount
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Email_SendersAccount")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Account_Email_SendersAccount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Account_Email_SendersAccount", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Email_SendersAccount");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Account_Email_SendersAccount", null, value);
                this.OnPropertyChanged("Account_Email_SendersAccount");
            }
        }

        /// <summary>
        /// 1:N Account_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Emails")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Email> Account_Emails
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Account_Emails", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Emails");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Email>("Account_Emails", null, value);
                this.OnPropertyChanged("Account_Emails");
            }
        }

        /// <summary>
        /// 1:N account_master_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> Referencedaccount_master_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedaccount_master_account");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedaccount_master_account");
            }
        }

        /// <summary>
        /// 1:N account_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Account> Referencedaccount_parent_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencedaccount_parent_account");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedaccount_parent_account");
            }
        }

        /// <summary>
        /// 1:N Account_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Tasks")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Task> Account_Tasks
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Account_Tasks", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Account_Tasks");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Task>("Account_Tasks", null, value);
                this.OnPropertyChanged("Account_Tasks");
            }
        }

        /// <summary>
        /// 1:N btt_account_btt_gratuity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_account_btt_gratuity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity> btt_account_btt_gratuity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("btt_account_btt_gratuity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_account_btt_gratuity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Btt_gratuity>("btt_account_btt_gratuity", null, value);
                this.OnPropertyChanged("btt_account_btt_gratuity");
            }
        }

        /// <summary>
        /// 1:N btt_account_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_account_orb_machine")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> btt_account_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("btt_account_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_account_orb_machine");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("btt_account_orb_machine", null, value);
                this.OnPropertyChanged("btt_account_orb_machine");
            }
        }

        /// <summary>
        /// 1:N btt_accountplanner_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_accountplanner_opportunity")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> btt_accountplanner_opportunity
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_accountplanner_opportunity", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_accountplanner_opportunity");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("btt_accountplanner_opportunity", null, value);
                this.OnPropertyChanged("btt_accountplanner_opportunity");
            }
        }

        /// <summary>
        /// 1:N btt_setup_account_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_setup_account_orb_machine")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> btt_setup_account_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("btt_setup_account_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_setup_account_orb_machine");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("btt_setup_account_orb_machine", null, value);
                this.OnPropertyChanged("btt_setup_account_orb_machine");
            }
        }

        /// <summary>
        /// 1:N contact_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> contact_customer_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_customer_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("contact_customer_accounts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("contact_customer_accounts", null, value);
                this.OnPropertyChanged("contact_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N opportunity_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> opportunity_customer_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_customer_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_customer_accounts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_customer_accounts", null, value);
                this.OnPropertyChanged("opportunity_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N opportunity_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_account")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> opportunity_parent_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_parent_account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("opportunity_parent_account");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("opportunity_parent_account", null, value);
                this.OnPropertyChanged("opportunity_parent_account");
            }
        }

        /// <summary>
        /// 1:N orb_account_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_account_orb_machine")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> orb_account_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_account_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_account_orb_machine");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_account_orb_machine", null, value);
                this.OnPropertyChanged("orb_account_orb_machine");
            }
        }

        /// <summary>
        /// 1:N orb_account_orb_productgroupclassification
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_account_orb_productgroupclassification")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification> orb_account_orb_productgroupclassification
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("orb_account_orb_productgroupclassification", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_account_orb_productgroupclassification");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_productgroupclassification>("orb_account_orb_productgroupclassification", null, value);
                this.OnPropertyChanged("orb_account_orb_productgroupclassification");
            }
        }

        /// <summary>
        /// 1:N orb_recipient_orb_machine
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_recipient_orb_machine")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> orb_recipient_orb_machine
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_recipient_orb_machine", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_recipient_orb_machine");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("orb_recipient_orb_machine", null, value);
                this.OnPropertyChanged("orb_recipient_orb_machine");
            }
        }

        /// <summary>
        /// 1:N quote_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote> quote_customer_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("quote_customer_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("quote_customer_accounts");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Quote>("quote_customer_accounts", null, value);
                this.OnPropertyChanged("quote_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_opportunity_SalesOrganization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_opportunity_SalesOrganization")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity> rbtt_account_opportunity_SalesOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("rbtt_account_opportunity_SalesOrganization", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_opportunity_SalesOrganization");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Opportunity>("rbtt_account_opportunity_SalesOrganization", null, value);
                this.OnPropertyChanged("rbtt_account_opportunity_SalesOrganization");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_orb_machine_AccountId
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_AccountId")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_account_orb_machine_AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_AccountId", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_AccountId");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_AccountId", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_AccountId");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_orb_machine_EndCustomer
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_EndCustomer")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_account_orb_machine_EndCustomer
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_EndCustomer", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_EndCustomer");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_EndCustomer", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_EndCustomer");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_orb_machine_LocationContact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_LocationContact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_account_orb_machine_LocationContact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_LocationContact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_LocationContact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_LocationContact", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_LocationContact");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_orb_machine_StartUpdoneby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_orb_machine_StartUpdoneby")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine> rbtt_account_orb_machine_StartUpdoneby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_StartUpdoneby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_orb_machine_StartUpdoneby");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_machine>("rbtt_account_orb_machine_StartUpdoneby", null, value);
                this.OnPropertyChanged("rbtt_account_orb_machine_StartUpdoneby");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_rbtt_customermasterdataexchange_Account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_rbtt_customermasterdataexchange_Account")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange> rbtt_account_rbtt_customermasterdataexchange_Account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_account_rbtt_customermasterdataexchange_Account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_rbtt_customermasterdataexchange_Account");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_customermasterdataexchange>("rbtt_account_rbtt_customermasterdataexchange_Account", null, value);
                this.OnPropertyChanged("rbtt_account_rbtt_customermasterdataexchange_Account");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_rbtt_delivernote_ShiptoParty
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_rbtt_delivernote_ShiptoParty")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote> rbtt_account_rbtt_delivernote_ShiptoParty
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_account_rbtt_delivernote_ShiptoParty", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_rbtt_delivernote_ShiptoParty");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_delivernote>("rbtt_account_rbtt_delivernote_ShiptoParty", null, value);
                this.OnPropertyChanged("rbtt_account_rbtt_delivernote_ShiptoParty");
            }
        }

        /// <summary>
        /// 1:N rbtt_account_systemuser_SalesOrganization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_systemuser_SalesOrganization")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser> rbtt_account_systemuser_SalesOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("rbtt_account_systemuser_SalesOrganization", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_systemuser_SalesOrganization");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("rbtt_account_systemuser_SalesOrganization", null, value);
                this.OnPropertyChanged("rbtt_account_systemuser_SalesOrganization");
            }
        }

        /// <summary>
        /// N:N rbtt_account_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_account_contact")]
        public System.Collections.Generic.IEnumerable<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact> rbtt_account_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_account_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_account_contact");
                this.SetRelatedEntities<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("rbtt_account_contact", null, value);
                this.OnPropertyChanged("rbtt_account_contact");
            }
        }

        /// <summary>
        /// N:1 account_master_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account Referencingaccount_master_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 account_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Account Referencingaccount_parent_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Referencingaccount_parent_account");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingaccount_parent_account");
            }
        }

        /// <summary>
        /// N:1 account_primary_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_primary_contact")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Contact account_primary_contact
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("account_primary_contact", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("account_primary_contact");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Contact>("account_primary_contact", null, value);
                this.OnPropertyChanged("account_primary_contact");
            }
        }

        /// <summary>
        /// N:1 btt_systemuser_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("btt_industryresponsibleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("btt_systemuser_account")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser btt_systemuser_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_systemuser_account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("btt_systemuser_account");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("btt_systemuser_account", null, value);
                this.OnPropertyChanged("btt_systemuser_account");
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_accountbase_createdby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_createdby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_createdby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdby");
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_accountbase_createdonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_createdonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_accountbase_modifiedby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_modifiedby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedby");
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser lk_accountbase_modifiedonbehalfby
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_modifiedonbehalfby", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedonbehalfby");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("lk_accountbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:1 orb_orb_classificationbase_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_classificationbaseid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_classificationbase_account")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase orb_orb_classificationbase_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("orb_orb_classificationbase_account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_classificationbase_account");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_classificationbase>("orb_orb_classificationbase_account", null, value);
                this.OnPropertyChanged("orb_orb_classificationbase_account");
            }
        }

        /// <summary>
        /// N:1 orb_orb_country_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orb_countryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orb_orb_country_account")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country orb_orb_country_account
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("orb_orb_country_account", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("orb_orb_country_account");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.Orb_country>("orb_orb_country_account", null, value);
                this.OnPropertyChanged("orb_orb_country_account");
            }
        }

        /// <summary>
        /// N:1 rbtt_rbtt_productionplants_account_SalesOrganization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rbtt_salesorganization")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rbtt_rbtt_productionplants_account_SalesOrganization")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants rbtt_rbtt_productionplants_account_SalesOrganization
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_rbtt_productionplants_account_SalesOrganization", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("rbtt_rbtt_productionplants_account_SalesOrganization");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.rbtt_productionplants>("rbtt_rbtt_productionplants_account_SalesOrganization", null, value);
                this.OnPropertyChanged("rbtt_rbtt_productionplants_account_SalesOrganization");
            }
        }

        /// <summary>
        /// N:1 system_user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser system_user_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("system_user_accounts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("system_user_accounts", null, value);
                this.OnPropertyChanged("system_user_accounts");
            }
        }

        /// <summary>
        /// N:1 user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
        public Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser user_accounts
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                return this.GetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_accounts", null);
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("user_accounts");
                this.SetRelatedEntity<Ttms.Crm.FunctionApp.Shared.EntityModel.SystemUser>("user_accounts", null, value);
                this.OnPropertyChanged("user_accounts");
            }
        }

        /// <summary>
        /// Constructor for populating via LINQ queries given a LINQ anonymous type
        /// <param name="anonymousType">LINQ anonymous type.</param>
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Account(object anonymousType) :
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
                        Attributes["accountid"] = base.Id;
                        break;
                    case "accountid":
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