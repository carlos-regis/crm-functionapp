﻿namespace Ttms.Crm.FunctionApp.Shared.EntityModel
{
    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_AccountCategoryCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Architect", 7, "", "Architect")]
        Architect = 200005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Collective/Coorperative", 12, "", "Collective/Coorperative")]
        CollectiveCoorperative = 200010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial Consumer", 11, "", "Commercial Consumer")]
        CommercialConsumer = 200009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Consultant/Advisor", 6, "", "Consultant/Advisor")]
        ConsultantAdvisor = 200004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Contractor", 5, "", "Contractor")]
        Contractor = 200003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("End-Consumer", 14, "", "End-Consumer")]
        EndConsumer = 200012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Energy Supplier/Utilitity", 9, "", "Energy Supplier/Utilitity")]
        EnergySupplierUtilitity = 200007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Government", 10, "", "Government")]
        Government = 200008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Housing Association", 13, "", "Housing Association")]
        HousingAssociation = 200011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Installer", 3, "", "Installer")]
        Installer = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Investor/Builder", 8, "", "Investor/Builder")]
        InvestorBuilder = 200006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other", 18, "", "Other")]
        Other = 200015,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Planer/Design Institute", 16, "", "Planer/Design Institute")]
        PlanerDesignInstitute = 200014,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Preferred Customer", 0)]
        PreferredCustomer = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Retail", 15, "", "Retail")]
        Retail = 200013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Service & Maintenance", 17, "", "Service & Maintenance")]
        ServiceMaintenance = 962480000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Standard", 1)]
        Standard = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("TT Franchise", 2, "", "TT Franchise")]
        TTFranchise = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wholesaler", 4, "", "Wholesaler")]
        Wholesaler = 200002,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_AccountClassificationCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_AccountRatingCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Address1_AddressTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bill To", 0, "", "Bill To")]
        BillTo = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Delivery address", 1, "", "Delivery address")]
        Deliveryaddress = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other address", 4, "", "Other address")]
        Otheraddress = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Post address", 2, "", "Post address")]
        Postaddress = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Visit address", 3, "", "Visit address")]
        Visitaddress = 200000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Address1_FreightTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("FOB", 0, null, "FOB")]
        FOB = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No Charge", 1, null, "No Charge")]
        NoCharge = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Address1_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Airborne", 0, null, "Airborne")]
        Airborne = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("DHL", 1, null, "DHL")]
        DHL = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("FedEx", 2, null, "FedEx")]
        FedEx = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Full Load", 5, null, "Full Load")]
        FullLoad = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Postal Mail", 4, null, "Postal Mail")]
        PostalMail = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("UPS", 3, null, "UPS")]
        UPS = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Will Call", 6, null, "Will Call")]
        WillCall = 7,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Address2_AddressTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Address2_FreightTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Address2_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_btt_accountcategorycode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Agricultural", 0, "", "Agricultural")]
        Agricultural = 100000027,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Automotive", 1, "", "Automotive")]
        Automotive = 100000029,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Basic Franchise", 2, "", "Basic Franchise")]
        BasicFranchise = 100000001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Building Supplies", 3, "", "Building Supplies")]
        BuildingSupplies = 962480023,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Building Supplies (B2B only)", 4, "", "Building Supplies (B2B only)")]
        BuildingSupplies_B2Bonly = 962480024,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Certification Authority", 5, "", "Certification Authority")]
        CertificationAuthority = 100000019,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial", 6, "", "Commercial")]
        Commercial = 962480029,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial Cooling", 7, "#0000ff", "Commercial Cooling")]
        CommercialCooling = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial & Industrial Installer (Heating, Hotwater & Climate)", 9, "", "Commercial & Industrial Installer (Heating, Hotwater & Climate)")]
        CommercialIndustrialInstaller_HeatingHotwaterClimate = 962480009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial & Industrial Installer (Heating & Hotwater only)", 8, "", "Commercial & Industrial Installer (Heating & Hotwater only)")]
        CommercialIndustrialInstaller_HeatingHotwateronly = 962480008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial Installer (Heating, Hotwater & Climate)", 12, "", "Commercial Installer (Heating, Hotwater & Climate)")]
        CommercialInstaller_HeatingHotwaterClimate = 100000006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial Installer (Heating & Hotwater only)", 11, "", "Commercial Installer (Heating & Hotwater only)")]
        CommercialInstaller_HeatingHotwateronly = 100000005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial / Utility", 10, "", "Commercial / Utility")]
        CommercialUtility = 100000012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial/Utility & Residential/Domestic", 13, "", "Commercial/Utility & Residential/Domestic")]
        CommercialUtilityResidentialDomestic = 100000014,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Competition", 14, "", "Competition")]
        Competition = 962480044,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Consortium", 15, "", "Consortium")]
        Consortium = 100000032,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("District Heating", 16, "", "District Heating")]
        DistrictHeating = 962480051,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("District Heating / BHKW", 18, "", "District Heating / BHKW")]
        DistrictHeatingBHKW = 962480018,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("District Heating & Electricity", 17, "", "District Heating & Electricity")]
        DistrictHeatingElectricity = 962480052,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Education / School", 19, "", "Education / School")]
        EducationSchool = 100000022,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Electrical", 20, "", "Electrical")]
        Electrical = 962480033,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Electrician (Solar PV)", 21, "", "Electrician (Solar PV)")]
        Electrician_SolarPV = 962480035,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Electricity", 22, "", "Electricity")]
        Electricity = 962480015,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Energy consultant", 23, "", "Energy consultant")]
        Energyconsultant = 962480049,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ex Franchise", 24, "", "Ex Franchise")]
        ExFranchise = 100000002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Finance Company / Bank", 25, "", "Finance Company / Bank")]
        FinanceCompanyBank = 962480045,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Food and Beverage", 26, "", "Food and Beverage")]
        FoodandBeverage = 100000028,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Franchise", 27, "", "Franchise")]
        Franchise = 100000034,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Gas", 28, "", "Gas")]
        Gas = 962480014,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Gas & Electricity", 29, "", "Gas & Electricity")]
        GasElectricity = 962480016,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("General consultant", 30, "", "General consultant")]
        Generalconsultant = 962480048,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("General Contractor", 31, "", "General Contractor")]
        GeneralContractor = 100000010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Health and Care", 32, "", "Health and Care")]
        HealthandCare = 100000023,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Heating Management", 33, "", "Heating Management")]
        HeatingManagement = 962480040,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Hotels & Tourism", 34, "", "Hotels & Tourism")]
        HotelsTourism = 100000025,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial", 35, "", "Industrial")]
        Industrial = 962480030,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial BHKW", 36, "", "Industrial BHKW")]
        IndustrialBHKW = 962480004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial Installer General", 37, "", "Industrial Installer General")]
        IndustrialInstallerGeneral = 962480002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial Installer General & BHKW", 38, "", "Industrial Installer General & BHKW")]
        IndustrialInstallerGeneralBHKW = 962480006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial Installer General, BHKW & Steam", 40, "", "Industrial Installer General, BHKW & Steam")]
        IndustrialInstallerGeneralBHKWSteam = 962480007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial Installer General & Steam", 39, "", "Industrial Installer General & Steam")]
        IndustrialInstallerGeneralSteam = 962480005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial Installer Steam", 41, "", "Industrial Installer Steam")]
        IndustrialInstallerSteam = 962480003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industry / Process Heat", 42, "", "Industry / Process Heat")]
        IndustryProcessHeat = 100000024,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Installer Supplies", 45, "", "Installer Supplies")]
        InstallerSupplies = 962480025,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Installer Supplies (B2B only)", 46, "", "Installer Supplies (B2B only)")]
        InstallerSupplies_B2Bonly = 962480026,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Installer / Wholesale", 44, "", "Installer / Wholesale")]
        InstallerWholesale = 962480011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Install & Replace", 43, "", "Install & Replace")]
        InstallReplace = 962480053,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Lawyer", 47, "", "Lawyer")]
        Lawyer = 962480046,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Local Authority", 48, "", "Local Authority")]
        LocalAuthority = 100000020,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Marketing & PR Agency", 49, "", "Marketing & PR Agency")]
        MarketingPRAgency = 962480043,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("National Authority", 50, "", "National Authority")]
        NationalAuthority = 100000021,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No TT Product installed", 51, "", "No TT Product installed")]
        NoTTProductinstalled = 962480022,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Oil Supplier", 52, "", "Oil Supplier")]
        OilSupplier = 962480017,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Online Merchant", 53, "", "Online Merchant")]
        OnlineMerchant = 962480027,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other", 54, "", "Other")]
        Other = 100000017,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Owner Association", 55, "", "Owner Association")]
        OwnerAssociation = 100000031,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Petrol / Chemical", 56, "", "Petrol / Chemical")]
        PetrolChemical = 100000030,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Premium Franchise", 57, "", "Premium Franchise")]
        PremiumFranchise = 100000000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Private sector", 58, "", "Private sector")]
        Privatesector = 962480020,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Project Developer", 59, "", "Project Developer")]
        ProjectDeveloper = 100000015,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Public (social)", 61, "", "Public (social)")]
        Public_social = 962480019,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Public & Entertainment", 60, "", "Public & Entertainment")]
        PublicEntertainment = 100000026,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Purchase", 62, "", "Purchase")]
        Purchase = 100000033,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Real Estate Agent", 63, "", "Real Estate Agent")]
        RealEstateAgent = 100000016,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Regional Authority", 64, "", "Regional Authority")]
        RegionalAuthority = 100000018,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential", 65, "", "Residential")]
        Residential = 962480028,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential/Commercial", 74, "", "Residential/Commercial")]
        ResidentialCommercial = 962480031,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential & Commercial Electrician", 66, "#0000ff", "Residential & Commercial Electrician")]
        ResidentialCommercialElectrician = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential/Commercial/Industrial", 75, "", "Residential/Commercial/Industrial")]
        ResidentialCommercialIndustrial = 962480032,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential, Commercial & Industrial Installer", 73, "", "Residential, Commercial & Industrial Installer")]
        ResidentialCommercialIndustrialInstaller = 962480010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential & Commercial Installer (Heating, Hotwater & Climate)", 68, "", "Residential & Commercial Installer (Heating, Hotwater & Climate)")]
        ResidentialCommercialInstaller_HeatingHotwaterClimate = 962480001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential & Commercial Installer (Heating & Hotwater only)", 67, "", "Residential & Commercial Installer (Heating & Hotwater only)")]
        ResidentialCommercialInstaller_HeatingHotwateronly = 962480000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential & Commercial Ventilation", 69, "#0000ff", "Residential & Commercial Ventilation")]
        ResidentialCommercialVentilation = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential / Domestic", 70, "", "Residential / Domestic")]
        ResidentialDomestic = 100000013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential Installer (Heating, Hotwater & Climate)", 72, "", "Residential Installer (Heating, Hotwater & Climate)")]
        ResidentialInstaller_HeatingHotwaterClimate = 100000004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential Installer (Heating & Hotwater only)", 71, "", "Residential Installer (Heating & Hotwater only)")]
        ResidentialInstaller_HeatingHotwateronly = 100000003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Roofer", 76, "", "Roofer")]
        Roofer = 962480034,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("School / University", 77, "", "School / University")]
        SchoolUniversity = 962480042,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Service Partner", 78, "#0000ff", "Service Partner")]
        ServicePartner = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Smart Home / connectivity consultant", 79, "", "Smart Home / connectivity consultant")]
        SmartHomeconnectivityconsultant = 962480050,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Specific Sparepart Reseller", 80, "", "Specific Sparepart Reseller")]
        SpecificSparepartReseller = 962480012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sub Contractor", 81, "", "Sub Contractor")]
        SubContractor = 100000011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Supplier / Vendor", 82, "", "Supplier / Vendor")]
        SupplierVendor = 962480041,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Thermal insulation facade/ ceiling", 83, "", "Thermal insulation facade/ ceiling")]
        Thermalinsulationfacadeceiling = 962480036,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Thermal insulation General", 84, "", "Thermal insulation General")]
        ThermalinsulationGeneral = 962480038,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Thermal insulation roof", 85, "", "Thermal insulation roof")]
        Thermalinsulationroof = 962480037,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Trade Association", 86, "", "Trade Association")]
        TradeAssociation = 962480047,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("TT Product installed", 87, "", "TT Product installed")]
        TTProductinstalled = 962480021,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Turnkey House Builder", 88, "", "Turnkey House Builder")]
        TurnkeyHouseBuilder = 962480013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Turnkey Project Contractor", 89, "", "Turnkey Project Contractor")]
        TurnkeyProjectContractor = 100000009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wholesaler Branch", 91, "#0000ff", "Wholesaler Branch")]
        WholesalerBranch = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wholesaler Headquarter", 92, "#0000ff", "Wholesaler Headquarter")]
        WholesalerHeadquarter = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wholesaler / Installer", 90, "", "Wholesaler / Installer")]
        WholesalerInstaller = 100000008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wholesaler Only", 93, "", "Wholesaler Only")]
        WholesalerOnly = 100000007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Window & frame replacement", 94, "", "Window & frame replacement")]
        Windowframereplacement = 962480039,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Btt_Aftersalesservice
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bosch TT", 2, null, "Bosch TT")]
        BoschTT = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Himself", 0, null, "Himself")]
        Himself = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Others", 1, null, "Others")]
        Others = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_BTT_appointmentrhythmcode_ABC
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("1 Year", 9, null, "1 Year")]
        _1Year = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2 Months", 5, null, "2 Months")]
        _2Months = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2 Weeks", 1, null, "2 Weeks")]
        _2Weeks = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3 Months", 6, null, "3 Months")]
        _3Months = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3 Weeks", 2, null, "3 Weeks")]
        _3Weeks = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4 Months", 7, null, "4 Months")]
        _4Months = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4 Weeks", 3, null, "4 Weeks")]
        _4Weeks = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6 Months", 8, null, "6 Months")]
        _6Months = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6 Weeks", 4, null, "6 Weeks")]
        _6Weeks = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Never", 10, null, "Never")]
        Never = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Weekly", 0, null, "Weekly")]
        Weekly = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Btt_Calculationbasedon
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Amount of money", 0, null, "Amount of money")]
        Amountofmoney = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No. of appliances", 1, null, "No. of appliances")]
        Noofappliances = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Btt_hassparepartspresent
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("All", 0, null, "All")]
        All = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("few", 3, null, "few")]
        few = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("most", 1, null, "most")]
        most = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("none", 4, null, "none")]
        none = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("some", 2, null, "some")]
        some = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Btt_PartnerFunktion
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Goods receiver", 1, null, "Goods receiver")]
        Goodsreceiver = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Payer", 0, null, "Payer")]
        Payer = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Payer and receiver", 2, null, "Payer and receiver")]
        Payerandreceiver = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_BTT_Relationshiptous
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bad", 5, null, "Bad")]
        Bad = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Difficult", 4, null, "Difficult")]
        Difficult = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Good", 1, null, "Good")]
        Good = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Indifferent", 3, null, "Indifferent")]
        Indifferent = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("OK", 2, null, "OK")]
        OK = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Very Good", 0, null, "Very Good")]
        VeryGood = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Btt_Showroomsize_pic
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("10-40 m2", 1, null, "10-40 m2")]
        _1040m2 = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("< 10 m2", 0, null, "< 10 m2")]
        _10m2 = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("> 40 m2", 2, null, "> 40 m2")]
        _40m2 = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_BusinessTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_CustomerSizeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_CustomerTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Competitor", 0, null, "Competitor")]
        Competitor = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Consultant", 1, null, "Consultant")]
        Consultant = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Customer", 2, null, "Customer")]
        Customer = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Influencer", 5, null, "Influencer")]
        Influencer = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Investor", 3, null, "Investor")]
        Investor = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other", 11, null, "Other")]
        Other = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Partner", 4, null, "Partner")]
        Partner = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Press", 6, null, "Press")]
        Press = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Prospect", 7, null, "Prospect")]
        Prospect = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Reseller", 8, null, "Reseller")]
        Reseller = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Supplier", 9, null, "Supplier")]
        Supplier = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Vendor", 10, null, "Vendor")]
        Vendor = 11,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_IndustryCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Accounting", 0, null, "Accounting")]
        Accounting = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Agriculture and Non-petrol Natural Resource Extraction", 1, null, "Agriculture and Non-petrol Natural Resource Extraction")]
        AgricultureandNonpetrolNaturalResourceExtraction = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Broadcasting Printing and Publishing", 2, null, "Broadcasting Printing and Publishing")]
        BroadcastingPrintingandPublishing = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Brokers", 3, null, "Brokers")]
        Brokers = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Building Supply Retail", 4, null, "Building Supply Retail")]
        BuildingSupplyRetail = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Business Services", 5, null, "Business Services")]
        BusinessServices = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Consulting", 6, null, "Consulting")]
        Consulting = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Consumer Services", 7, null, "Consumer Services")]
        ConsumerServices = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Design, Direction and Creative Management", 8, null, "Design, Direction and Creative Management")]
        DesignDirectionandCreativeManagement = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Distributors, Dispatchers and Processors", 9, null, "Distributors, Dispatchers and Processors")]
        DistributorsDispatchersandProcessors = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Doctor\'s Offices and Clinics", 10, null, "Doctor\'s Offices and Clinics")]
        DoctorsOfficesandClinics = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Durable Manufacturing", 11, null, "Durable Manufacturing")]
        DurableManufacturing = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Eating and Drinking Places", 12, null, "Eating and Drinking Places")]
        EatingandDrinkingPlaces = 13,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Entertainment Retail", 13, null, "Entertainment Retail")]
        EntertainmentRetail = 14,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Equipment Rental and Leasing", 14, null, "Equipment Rental and Leasing")]
        EquipmentRentalandLeasing = 15,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Financial", 15, null, "Financial")]
        Financial = 16,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Food and Tobacco Processing", 16, null, "Food and Tobacco Processing")]
        FoodandTobaccoProcessing = 17,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inbound Capital Intensive Processing", 17, null, "Inbound Capital Intensive Processing")]
        InboundCapitalIntensiveProcessing = 18,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inbound Repair and Services", 18, null, "Inbound Repair and Services")]
        InboundRepairandServices = 19,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Insurance", 19, null, "Insurance")]
        Insurance = 20,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Legal Services", 20, null, "Legal Services")]
        LegalServices = 21,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Non-Durable Merchandise Retail", 21, null, "Non-Durable Merchandise Retail")]
        NonDurableMerchandiseRetail = 22,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Outbound Consumer Service", 22, null, "Outbound Consumer Service")]
        OutboundConsumerService = 23,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Petrochemical Extraction and Distribution", 23, null, "Petrochemical Extraction and Distribution")]
        PetrochemicalExtractionandDistribution = 24,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Service Retail", 24, null, "Service Retail")]
        ServiceRetail = 25,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SIG Affiliations", 25, null, "SIG Affiliations")]
        SIGAffiliations = 26,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Social Services", 26, null, "Social Services")]
        SocialServices = 27,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Special Outbound Trade Contractors", 27, null, "Special Outbound Trade Contractors")]
        SpecialOutboundTradeContractors = 28,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Specialty Realty", 28, null, "Specialty Realty")]
        SpecialtyRealty = 29,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Transportation", 29, null, "Transportation")]
        Transportation = 30,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Utility Creation and Distribution", 30, null, "Utility Creation and Distribution")]
        UtilityCreationandDistribution = 31,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Vehicle Retail", 31, null, "Vehicle Retail")]
        VehicleRetail = 32,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wholesale", 32, null, "Wholesale")]
        Wholesale = 33,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Orb_complexitycode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Complex", 2, null, "Complex")]
        Complex = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Estimated", 1, null, "Estimated")]
        Estimated = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Simple", 0, null, "Simple")]
        Simple = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_Orb_preferredappointmentdaycode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Friday", 4, null, "Friday")]
        Friday = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Monday", 0, null, "Monday")]
        Monday = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Saturday", 5, null, "Saturday")]
        Saturday = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sunday", 6, null, "Sunday")]
        Sunday = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Thursday", 3, null, "Thursday")]
        Thursday = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Tuesday", 1, null, "Tuesday")]
        Tuesday = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wednesday", 2, null, "Wednesday")]
        Wednesday = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_OwnershipCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other", 3, null, "Other")]
        Other = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Private", 1, null, "Private")]
        Private = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Public", 0, null, "Public")]
        Public = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Subsidiary", 2, null, "Subsidiary")]
        Subsidiary = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_PaymentTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2% 10, Net 30", 1, null, "2% 10, Net 30")]
        _210Net30 = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 30", 0, null, "Net 30")]
        Net30 = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 45", 2, null, "Net 45")]
        Net45 = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 60", 3, null, "Net 60")]
        Net60 = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_PreferredAppointmentDayCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Friday", 5, null, "Friday")]
        Friday = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Monday", 1, null, "Monday")]
        Monday = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Saturday", 6, null, "Saturday")]
        Saturday = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sunday", 0, null, "Sunday")]
        Sunday = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Thursday", 4, null, "Thursday")]
        Thursday = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Tuesday", 2, null, "Tuesday")]
        Tuesday = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wednesday", 3, null, "Wednesday")]
        Wednesday = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_PreferredAppointmentTimeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Afternoon", 1, null, "Afternoon")]
        Afternoon = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Evening", 2, null, "Evening")]
        Evening = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Morning", 0, null, "Morning")]
        Morning = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_PreferredContactMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Any", 0, null, "Any")]
        Any = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Email", 1, null, "Email")]
        Email = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Fax", 3, null, "Fax")]
        Fax = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Mail", 4, null, "Mail")]
        Mail = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Phone", 2, null, "Phone")]
        Phone = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_rbtt_AppointmentOverdue
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("< 30 days", 1, "#FFFF00", "< 30 days")]
        _30days_173140001 = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("> 30 days", 2, "#E20015", "> 30 days")]
        _30days_173140002 = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No", 0, "#78be20", "No")]
        No = 173140000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, "#0000ff", "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bankrupt", 1, "#0000ff", "Bankrupt")]
        Bankrupt = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Merged or taken over", 2, "#0000ff", "Merged or taken over")]
        Mergedortakenover = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other reason", 4, "#0000ff", "Other reason")]
        Otherreason = 200002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Out of business", 3, "#0000ff", "Out of business")]
        Outofbusiness = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Account_TerritoryCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("01", 0, null, "01")]
        _01 = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("03", 1, null, "03")]
        _03 = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("04", 2, null, "04")]
        _04 = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("06", 3, null, "06")]
        _06 = 200002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("07", 4, null, "07")]
        _07 = 200003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("08", 5, null, "08")]
        _08 = 200004,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ActivityParty_InstanceTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Not Recurring", 0)]
        NotRecurring = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Exception", 3)]
        RecurringException = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Future Exception", 4)]
        RecurringFutureException = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Instance", 2)]
        RecurringInstance = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Master", 1)]
        RecurringMaster = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ActivityParty_ParticipationTypeMask
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("BCC Recipient", 3)]
        BCCRecipient = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("CC Recipient", 2)]
        CCRecipient = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Customer", 10)]
        Customer = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Optional attendee", 5)]
        Optionalattendee = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Organizer", 6)]
        Organizer = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Owner", 8)]
        Owner = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Regarding", 7)]
        Regarding = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Required attendee", 4)]
        Requiredattendee = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Resource", 9)]
        Resource = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sender", 0)]
        Sender = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("To Recipient", 1)]
        ToRecipient = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum activitypointer_DeliveryPriorityCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("High", 2)]
        High = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Low", 0)]
        Low = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Normal", 1)]
        Normal = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum alegri_autonumbercounter_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Appointment_AttachmentErrors
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("None", 0, null, "None")]
        None = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("The appointment was saved as a Microsoft Dynamics CRM appointment record, but not" +
            " all the attachments could be saved with it. An attachment cannot be saved if it" +
            " is blocked or if its file type is invalid.", 1, null, "The appointment was saved as a Microsoft Dynamics CRM appointment record, but not" +
            " all the attachments could be saved with it. An attachment cannot be saved if it" +
            " is blocked or if its file type is invalid.")]
        TheappointmentwassavedasaMicrosoftDynamicsCRMappointmentrecordbutnotalltheattachmentscouldbesavedwithitAnattachmentcannotbesavedifitisblockedorifitsfiletypeisinvalid = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Appointment_btt_visitobjective1
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("1", 22, null, "1")]
        _1 = 100000010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("10", 23, null, "10")]
        _10 = 100000011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("11", 24, null, "11")]
        _11 = 100000012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("12", 25, null, "12")]
        _12 = 100000013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2", 26, null, "2")]
        _2 = 100000014,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3", 27, null, "3")]
        _3 = 100000015,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4", 28, null, "4")]
        _4 = 100000016,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("5", 29, null, "5")]
        _5 = 100000017,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6", 30, null, "6")]
        _6 = 100000018,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("7", 31, null, "7")]
        _7 = 100000019,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("8", 32, null, "8")]
        _8 = 100000020,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("9", 33, null, "9")]
        _9 = 100000021,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480000", 13, null, "962480000")]
        _962480000 = 100000001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480001", 14, null, "962480001")]
        _962480001 = 100000002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480002", 15, null, "962480002")]
        _962480002 = 100000003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480003", 16, null, "962480003")]
        _962480003 = 100000004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480005", 17, null, "962480005")]
        _962480005 = 100000005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480006", 18, null, "962480006")]
        _962480006 = 100000006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480007", 19, null, "962480007")]
        _962480007 = 100000007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480008", 20, null, "962480008")]
        _962480008 = 100000008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480011", 21, null, "962480011")]
        _962480011 = 100000009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administration: customer order", 7, null, "Administration: customer order")]
        Administrationcustomerorder = 962480007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administration: financial dispute", 8, null, "Administration: financial dispute")]
        Administrationfinancialdispute = 962480008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: definition of annual objective", 0, null, "Commercial: definition of annual objective")]
        Commercialdefinitionofannualobjective = 962480000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: new product presentation", 2, null, "Commercial: new product presentation")]
        Commercialnewproductpresentation = 962480002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: presentation product range and price list", 1, null, "Commercial: presentation product range and price list")]
        Commercialpresentationproductrangeandpricelist = 962480001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: punctual promotion presentation", 3, null, "Commercial: punctual promotion presentation")]
        Commercialpunctualpromotionpresentation = 962480003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: Solfea presentation", 4, null, "Commercial: Solfea presentation")]
        CommercialSolfeapresentation = 962480004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Distribution catalog Bosch LSS", 9, null, "Distribution catalog Bosch LSS")]
        DistributioncatalogBoschLSS = 962480009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("f426534a-21c0-e511-9413-005056814e1c", 12, null, "f426534a-21c0-e511-9413-005056814e1c")]
        f426534a21c0e5119413005056814e1c = 100000000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Hand-delivered catalog SPS 2013", 11, null, "Hand-delivered catalog SPS 2013")]
        HanddeliveredcatalogSPS2013 = 962480011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Presentation of the club", 10, null, "Presentation of the club")]
        Presentationoftheclub = 962480010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Technical: After-Sales", 5, null, "Technical: After-Sales")]
        TechnicalAfterSales = 962480005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Technical: on-site intervention", 6, null, "Technical: on-site intervention")]
        Technicalonsiteintervention = 962480006,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Appointment_btt_visitobjective2
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administration: customer order", 7, null, "Administration: customer order")]
        Administrationcustomerorder = 962480007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administration: financial dispute", 8, null, "Administration: financial dispute")]
        Administrationfinancialdispute = 962480008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: definition of annual objective", 0, null, "Commercial: definition of annual objective")]
        Commercialdefinitionofannualobjective = 962480000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: new product presentation", 2, null, "Commercial: new product presentation")]
        Commercialnewproductpresentation = 962480002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: presentation product range and price list", 1, null, "Commercial: presentation product range and price list")]
        Commercialpresentationproductrangeandpricelist = 962480001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: punctual promotion presentation", 3, null, "Commercial: punctual promotion presentation")]
        Commercialpunctualpromotionpresentation = 962480003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: Solfea presentation", 4, null, "Commercial: Solfea presentation")]
        CommercialSolfeapresentation = 962480004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Distribution catalog Bosch LSS", 9, null, "Distribution catalog Bosch LSS")]
        DistributioncatalogBoschLSS = 962480009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Hand-delivered catalog SPS 2013", 11, null, "Hand-delivered catalog SPS 2013")]
        HanddeliveredcatalogSPS2013 = 962480011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Presentation of the club", 10, null, "Presentation of the club")]
        Presentationoftheclub = 962480010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Technical: After-Sales", 5, null, "Technical: After-Sales")]
        TechnicalAfterSales = 962480005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Technical: on-site intervention", 6, null, "Technical: on-site intervention")]
        Technicalonsiteintervention = 962480006,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Appointment_btt_visitobjective3
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administration: customer order", 7, null, "Administration: customer order")]
        Administrationcustomerorder = 962480007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administration: financial dispute", 8, null, "Administration: financial dispute")]
        Administrationfinancialdispute = 962480008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: definition of annual objective", 0, null, "Commercial: definition of annual objective")]
        Commercialdefinitionofannualobjective = 962480000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: new product presentation", 2, null, "Commercial: new product presentation")]
        Commercialnewproductpresentation = 962480002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: presentation product range and price list", 1, null, "Commercial: presentation product range and price list")]
        Commercialpresentationproductrangeandpricelist = 962480001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: punctual promotion presentation", 3, null, "Commercial: punctual promotion presentation")]
        Commercialpunctualpromotionpresentation = 962480003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial: Solfea presentation", 4, null, "Commercial: Solfea presentation")]
        CommercialSolfeapresentation = 962480004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Distribution catalog Bosch LSS", 9, null, "Distribution catalog Bosch LSS")]
        DistributioncatalogBoschLSS = 962480009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Hand-delivered catalog SPS 2013", 11, null, "Hand-delivered catalog SPS 2013")]
        HanddeliveredcatalogSPS2013 = 962480011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Presentation of the club", 10, null, "Presentation of the club")]
        Presentationoftheclub = 962480010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Technical: After-Sales", 5, null, "Technical: After-Sales")]
        TechnicalAfterSales = 962480005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Technical: on-site intervention", 6, null, "Technical: on-site intervention")]
        Technicalonsiteintervention = 962480006,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Appointment_InstanceTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Not Recurring", 0, null, "Not Recurring")]
        NotRecurring = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Exception", 3, null, "Recurring Exception")]
        RecurringException = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Future Exception", 4, null, "Recurring Future Exception")]
        RecurringFutureException = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Instance", 2, null, "Recurring Instance")]
        RecurringInstance = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Recurring Master", 1, null, "Recurring Master")]
        RecurringMaster = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Appointment_PriorityCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("High", 2, null, "High")]
        High = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Low", 0, null, "Low")]
        Low = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Normal", 1, null, "Normal")]
        Normal = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Appointment_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Busy", 4, null, "Busy")]
        Busy = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Canceled", 3, null, "Canceled")]
        Canceled = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Completed", 2, null, "Completed")]
        Completed = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Free", 0, null, "Free")]
        Free = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Out of Office", 5, null, "Out of Office")]
        OutofOffice = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Tentative", 1, null, "Tentative")]
        Tentative = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum btt_Brands
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("All", 9, "", "All")]
        All = 962480004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bosch", 0, "", "Bosch")]
        Bosch = 962480000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Buderus", 1, "", "Buderus")]
        Buderus = 962480001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("ELM", 2, "", "e.l.m Leblanc")]
        ELM = 962480006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("IVT", 3, "", "IVT")]
        IVT = 962480007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Junkers", 4, "", "Junkers")]
        Junkers = 962480005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Milton", 5, "#0000ff", "Milton")]
        Milton = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Nefit", 6, "#0000ff", "Nefit")]
        Nefit = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Unknown", 10, "#FF0000", "Once the IF could not determine any brand inside the option set, set the Brand va" +
            "lue = Unknown")]
        Unknown = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Vulcano", 7, "#0000ff", "Vulcano")]
        Vulcano = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Worcester", 8, "#0000ff", "Worcester Brand")]
        Worcester = 173140002,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Btt_gratuity_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum btt_RhythmCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("1 Year", 9, "#0000ff", "1 Year")]
        _1Year = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2 Months", 5, "#0000ff", "2 Months")]
        _2Months = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2 Weeks", 1, "#0000ff", "2 Weeks")]
        _2Weeks = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3 Months", 6, "#0000ff", "3 Months")]
        _3Months = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3 Weeks", 2, "#0000ff", "3 Weeks")]
        _3Weeks = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4 Months", 7, "#0000ff", "4 Months")]
        _4Months = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4 Weeks", 3, "#0000ff", "4 Weeks")]
        _4Weeks = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6 Months", 8, "#0000ff", "6 Months")]
        _6Months = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6 Weeks", 4, "#0000ff", "6 Weeks")]
        _6Weeks = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Never", 10, "#0000ff", "Never")]
        Never = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Weekly", 0, "#0000ff", "Weekly")]
        Weekly = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum BudgetStatus
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Can Buy", 2)]
        CanBuy = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("May Buy", 1)]
        MayBuy = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No Committed Budget", 0)]
        NoCommittedBudget = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Will Buy", 3)]
        WillBuy = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum ComponentState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Deleted", 2)]
        Deleted = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Deleted Unpublished", 3)]
        DeletedUnpublished = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Published", 0)]
        Published = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Unpublished", 1)]
        Unpublished = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_AccountRoleCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Decider", 3, "", "Decider")]
        Decider = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Gatekeeper (those who control flow of Information)", 4, "", "Gatekeeper (those who control flow of Information)")]
        Gatekeeper_thosewhocontrolflowofInformation = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Influencer", 1, "", "Influencer")]
        Influencer = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Owner (if different from buyer)", 5, "", "Owner (if different from buyer)")]
        Owner_ifdifferentfrombuyer = 200002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Purchaser (Buyer)", 0, "", "Purchaser (Buyer)")]
        Purchaser_Buyer = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("User", 2, "", "User")]
        User = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address1_AddressTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bill To", 0, "#0000ff", "Bill To Address")]
        BillTo = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other", 5, "#0000ff", "Other Address")]
        Other = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Post Address", 3, "#0000ff", "Post Address")]
        PostAddress = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Primary", 2, "", "Primary Address")]
        Primary = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ship To", 1, "#0000ff", "Ship To Address")]
        ShipTo = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Visit Address", 4, "#0000ff", "Visit Address")]
        VisitAddress = 200004,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address1_FreightTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("FOB", 0, null, "FOB")]
        FOB = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No Charge", 1, null, "No Charge")]
        NoCharge = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address1_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Airborne", 0, null, "Airborne")]
        Airborne = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("DHL", 1, null, "DHL")]
        DHL = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("FedEx", 2, null, "FedEx")]
        FedEx = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Full Load", 5, null, "Full Load")]
        FullLoad = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Postal Mail", 4, null, "Postal Mail")]
        PostalMail = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("UPS", 3, null, "UPS")]
        UPS = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Will Call", 6, null, "Will Call")]
        WillCall = 7,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address2_AddressTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Company Address", 0, "", "Company Address")]
        CompanyAddress = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Post Address", 1, "", "Post Address")]
        PostAddress = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Visit Address", 2, "", "Visit Address")]
        VisitAddress = 200001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address2_FreightTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address2_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address3_AddressTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, "", "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address3_FreightTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, "", "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Address3_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, "", "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_BTT_DMUIsDecider
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("high", 2, null, "high")]
        high = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("low", 0, null, "low")]
        low = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("medium", 1, null, "medium")]
        medium = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_BTT_DMUIsGatekeeper
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("high", 2, null, "high")]
        high = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("low", 0, null, "low")]
        low = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("medium", 1, null, "medium")]
        medium = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_BTT_DMUIsInfluencer
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("high", 2, null, "high")]
        high = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("low", 0, null, "low")]
        low = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("medium", 1, null, "medium")]
        medium = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_BTT_DMUIsOwner
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("high", 2, null, "high")]
        high = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("low", 0, null, "low")]
        low = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("medium", 1, null, "medium")]
        medium = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_BTT_DMUIsPurchaser
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("high", 2, null, "high")]
        high = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("low", 0, null, "low")]
        low = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("medium", 1, null, "medium")]
        medium = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_BTT_DMUIsUser
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("high", 2, null, "high")]
        high = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("low", 0, null, "low")]
        low = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("medium", 1, null, "medium")]
        medium = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Btt_JobTitle
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480000", 16, null, "962480000")]
        _962480000 = 100000000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Chief editor", 13, null, "Chief editor")]
        Chiefeditor = 14,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Customer service", 8, null, "Customer service")]
        Customerservice = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Director", 2, null, "Director")]
        Director = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Doctor", 9, null, "Doctor")]
        Doctor = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Editor", 14, null, "Editor")]
        Editor = 15,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Engineer", 7, null, "Engineer")]
        Engineer = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("General manager", 1, null, "General manager")]
        Generalmanager = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Journalist", 15, null, "Journalist")]
        Journalist = 16,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Marketing manager", 4, null, "Marketing manager")]
        Marketingmanager = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Officials head", 11, null, "Officials head")]
        Officialshead = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Officials specialist", 12, null, "Officials specialist")]
        Officialsspecialist = 13,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("President", 0, null, "President")]
        President = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Professor", 10, null, "Professor")]
        Professor = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Project manager", 5, null, "Project manager")]
        Projectmanager = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Purchasing specialist", 6, null, "Purchasing specialist")]
        Purchasingspecialist = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sales manager", 3, null, "Sales manager")]
        Salesmanager = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Btt_roles
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Authorized Installer", 0, null, "Authorized Installer")]
        AuthorizedInstaller = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Authorized Point of Sale Employee", 6, null, "Authorized Point of Sale Employee")]
        AuthorizedPointofSaleEmployee = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Authorized Servie-Man", 4, null, "Authorized Servie-Man")]
        AuthorizedServieMan = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Authorized Trade Partner Employee", 5, null, "Authorized Trade Partner Employee")]
        AuthorizedTradePartnerEmployee = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Former AI", 1, null, "Former AI")]
        FormerAI = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other", 8, null, "Other")]
        Other = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Planner", 7, null, "Planner")]
        Planner = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Potential AI", 2, null, "Potential AI")]
        PotentialAI = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Promesowiec", 3, null, "Promesowiec")]
        Promesowiec = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Btt_Stamp
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Lack", 1, null, "Lack")]
        Lack = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sent", 0, null, "Sent")]
        Sent = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_Btt_TTbrand
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Buderus", 0, null, "Buderus")]
        Buderus = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("e.l.m. leblanc", 1, null, "e.l.m. leblanc")]
        elmleblanc = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Geminox", 2, null, "Geminox")]
        Geminox = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_CustomerSizeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_CustomerTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ambassador", 8, null, "Ambassador")]
        Ambassador = 200008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bad", 1, null, "Bad")]
        Bad = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Difficult", 2, null, "Difficult")]
        Difficult = 200002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("DON’T Know", 4, null, "DON’T Know")]
        DONTKnow = 200004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Good", 6, null, "Good")]
        Good = 200006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Indifferent", 3, null, "Indifferent")]
        Indifferent = 200003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ok", 5, null, "Ok")]
        Ok = 200005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Very Bad", 0, null, "Very Bad")]
        VeryBad = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Very good", 7, null, "Very good")]
        Verygood = 200007,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_EducationCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_FamilyStatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Divorced", 2, null, "Divorced")]
        Divorced = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Married", 1, null, "Married")]
        Married = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Single", 0, null, "Single")]
        Single = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Widowed", 3, null, "Widowed")]
        Widowed = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_GenderCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Female", 1, "", "Female")]
        Female = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Male", 0, "", "Male")]
        Male = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_HasChildrenCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_LeadSourceCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_msdyn_orgchangestatus
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Ignore", 2, "#0000ff")]
        Ignore = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No Feedback", 0, "#0000ff")]
        NoFeedback = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Not at Company", 1, "#0000ff")]
        NotatCompany = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_PaymentTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2% 10, Net 30", 1, null, "2% 10, Net 30")]
        _210Net30 = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 30", 0, null, "Net 30")]
        Net30 = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 45", 2, null, "Net 45")]
        Net45 = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 60", 3, null, "Net 60")]
        Net60 = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_PreferredAppointmentDayCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Friday", 5, null, "Friday")]
        Friday = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Monday", 1, null, "Monday")]
        Monday = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Saturday", 6, null, "Saturday")]
        Saturday = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sunday", 0, null, "Sunday")]
        Sunday = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Thursday", 4, null, "Thursday")]
        Thursday = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Tuesday", 2, null, "Tuesday")]
        Tuesday = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wednesday", 3, null, "Wednesday")]
        Wednesday = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_PreferredAppointmentTimeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Afternoon", 1, null, "Afternoon")]
        Afternoon = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Evening", 2, null, "Evening")]
        Evening = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Morning", 0, null, "Morning")]
        Morning = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_PreferredContactMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480000", 5, "", "962480000")]
        _962480000 = 100000000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480001", 6, "", "962480001")]
        _962480001 = 100000001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480002", 7, "", "962480002")]
        _962480002 = 100000002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480003", 8, "", "962480003")]
        _962480003 = 100000003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480004", 9, "", "962480004")]
        _962480004 = 100000004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480005", 10, "", "962480005")]
        _962480005 = 100000005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480006", 11, "", "962480006")]
        _962480006 = 100000006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480007", 12, "", "962480007")]
        _962480007 = 100000007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480008", 13, "", "962480008")]
        _962480008 = 100000008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480009", 14, "", "962480009")]
        _962480009 = 100000009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480011", 15, "", "962480011")]
        _962480011 = 100000010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480012", 16, "", "962480012")]
        _962480012 = 100000011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480013", 17, "", "962480013")]
        _962480013 = 100000012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480014", 18, "", "962480014")]
        _962480014 = 100000013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480015", 19, "", "962480015")]
        _962480015 = 100000014,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480016", 20, "", "962480016")]
        _962480016 = 100000015,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480017", 21, "", "962480017")]
        _962480017 = 100000016,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480018", 22, "", "962480018")]
        _962480018 = 100000017,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480020", 23, "", "962480020")]
        _962480020 = 100000018,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480021", 24, "", "962480021")]
        _962480021 = 100000019,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480022", 25, "", "962480022")]
        _962480022 = 100000020,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480023", 26, "", "962480023")]
        _962480023 = 100000021,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480024", 27, "", "962480024")]
        _962480024 = 100000022,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480025", 28, "", "962480025")]
        _962480025 = 100000023,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480026", 29, "", "962480026")]
        _962480026 = 100000024,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480027", 30, "", "962480027")]
        _962480027 = 100000025,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480028", 31, "", "962480028")]
        _962480028 = 100000026,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480029", 32, "", "962480029")]
        _962480029 = 100000027,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480030", 33, "", "962480030")]
        _962480030 = 100000028,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480031", 34, "", "962480031")]
        _962480031 = 100000029,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480033", 35, "", "962480033")]
        _962480033 = 100000030,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480034", 36, "", "962480034")]
        _962480034 = 100000031,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480035", 37, "", "962480035")]
        _962480035 = 100000032,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480036", 38, "", "962480036")]
        _962480036 = 100000033,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480037", 39, "", "962480037")]
        _962480037 = 100000034,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480038", 40, "", "962480038")]
        _962480038 = 100000035,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480039", 41, "", "962480039")]
        _962480039 = 100000036,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480040", 42, "", "962480040")]
        _962480040 = 100000037,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480041", 43, "", "962480041")]
        _962480041 = 100000038,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480042", 44, "", "962480042")]
        _962480042 = 100000039,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480043", 45, "", "962480043")]
        _962480043 = 100000040,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480044", 46, "", "962480044")]
        _962480044 = 100000041,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480045", 47, "", "962480045")]
        _962480045 = 100000042,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480046", 48, "", "962480046")]
        _962480046 = 100000043,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480047", 49, "", "962480047")]
        _962480047 = 100000044,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480048", 50, "", "962480048")]
        _962480048 = 100000045,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480049", 51, "", "962480049")]
        _962480049 = 100000046,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480051", 52, "", "962480051")]
        _962480051 = 100000047,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480052", 53, "", "962480052")]
        _962480052 = 100000048,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480053", 54, "", "962480053")]
        _962480053 = 100000049,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480054", 55, "", "962480054")]
        _962480054 = 100000050,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480055", 56, "", "962480055")]
        _962480055 = 100000051,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480056", 57, "", "962480056")]
        _962480056 = 100000052,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480057", 58, "", "962480057")]
        _962480057 = 100000053,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480058", 59, "", "962480058")]
        _962480058 = 100000054,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480059", 60, "", "962480059")]
        _962480059 = 100000055,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480060", 61, "", "962480060")]
        _962480060 = 100000056,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480061", 62, "", "962480061")]
        _962480061 = 100000057,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480062", 63, "", "962480062")]
        _962480062 = 100000058,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480063", 64, "", "962480063")]
        _962480063 = 100000059,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480064", 65, "", "962480064")]
        _962480064 = 100000060,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480065", 66, "", "962480065")]
        _962480065 = 100000061,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480066", 67, "", "962480066")]
        _962480066 = 100000062,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480068", 68, "", "962480068")]
        _962480068 = 100000063,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480069", 69, "", "962480069")]
        _962480069 = 100000064,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480070", 70, "", "962480070")]
        _962480070 = 100000065,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480071", 71, "", "962480071")]
        _962480071 = 100000066,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480072", 72, "", "962480072")]
        _962480072 = 100000067,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480073", 73, "", "962480073")]
        _962480073 = 100000068,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480074", 74, "", "962480074")]
        _962480074 = 100000069,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480075", 75, "", "962480075")]
        _962480075 = 100000070,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480076", 76, "", "962480076")]
        _962480076 = 100000071,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480077", 77, "", "962480077")]
        _962480077 = 100000072,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480078", 78, "", "962480078")]
        _962480078 = 100000073,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480079", 79, "", "962480079")]
        _962480079 = 100000074,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480080", 80, "", "962480080")]
        _962480080 = 100000075,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480081", 81, "", "962480081")]
        _962480081 = 100000076,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("962480082", 82, "", "962480082")]
        _962480082 = 100000077,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Any", 0, "", "Any")]
        Any = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Email", 1, "", "Email")]
        Email = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Fax", 3, "", "Fax")]
        Fax = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Mail", 4, "", "Mail")]
        Mail = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Phone", 2, "", "Phone")]
        Phone = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Contact_TerritoryCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Email_CorrelationMethod
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("ConversationIndex", 5)]
        ConversationIndex = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("CustomCorrelation", 7)]
        CustomCorrelation = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("InReplyTo", 3)]
        InReplyTo = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("None", 0)]
        None = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Skipped", 1)]
        Skipped = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SmartMatching", 6)]
        SmartMatching = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("TrackingToken", 4)]
        TrackingToken = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("XHeader", 2)]
        XHeader = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Email_EmailReminderStatus
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("NotSet", 0)]
        NotSet = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("ReminderExpired", 2)]
        ReminderExpired = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("ReminderInvalid", 3)]
        ReminderInvalid = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("ReminderSet", 1)]
        ReminderSet = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Email_EmailReminderType
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("If I do not receive a reply by", 0)]
        IfIdonotreceiveareplyby = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("If the email is not opened by", 1)]
        Iftheemailisnotopenedby = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Remind me anyways at", 2)]
        Remindmeanywaysat = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Email_Notifications
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("None", 0, null, "None")]
        None = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("The message was saved as a Microsoft Dynamics CRM email record, but not all the a" +
            "ttachments could be saved with it. An attachment cannot be saved if it is blocke" +
            "d or if its file type is invalid.", 1, null, "The message was saved as a Microsoft Dynamics CRM email record, but not all the a" +
            "ttachments could be saved with it. An attachment cannot be saved if it is blocke" +
            "d or if its file type is invalid.")]
        ThemessagewassavedasaMicrosoftDynamicsCRMemailrecordbutnotalltheattachmentscouldbesavedwithitAnattachmentcannotbesavedifitisblockedorifitsfiletypeisinvalid = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Truncated body.", 2, null, "Truncated body.")]
        Truncatedbody = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Email_PriorityCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("High", 2, null, "High")]
        High = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Low", 0, null, "Low")]
        Low = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Normal", 1, null, "Normal")]
        Normal = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Email_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Canceled", 4, null, "Canceled")]
        Canceled = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Completed", 1, null, "Completed")]
        Completed = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Draft", 0, null, "Draft")]
        Draft = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Failed", 7, null, "Failed")]
        Failed = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pending Send", 5, null, "Pending Send")]
        PendingSend = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Received", 3, null, "Received")]
        Received = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sending", 6, null, "Sending")]
        Sending = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sent", 2, null, "Sent")]
        Sent = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum InitialCommunication
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Contacted", 0)]
        Contacted = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Not Contacted", 1)]
        NotContacted = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Need
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Good to have", 2)]
        Goodtohave = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Must have", 0)]
        Musthave = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No need", 3)]
        Noneed = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Should have", 1)]
        Shouldhave = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_Btt_Contractwith
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("TTCB", 0, null, "TTCB")]
        TTCB = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("TTCW", 1, null, "TTCW")]
        TTCW = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("TTOI", 2, null, "TTOI")]
        TTOI = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_Btt_Productionlocation
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("International", 1, null, "International")]
        International = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("National", 0, null, "National")]
        National = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_Btt_projecttype1
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Initial purchase", 0, null, "Initial purchase")]
        Initialpurchase = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Replacement purchase", 1, null, "Replacement purchase")]
        Replacementpurchase = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_Btt_projecttype2
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Automotive", 7, "", "Automotive")]
        Automotive = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Banking & Finance", 16, "", "Banking & Finance")]
        BankingFinance = 14,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Beverage (Drinks)", 2, "#0000ff", "Beverage (Drinks)")]
        Beverage_Drinks = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Breweries & Distilleries", 3, "#0000ff", "Breweries & Distilleries")]
        BreweriesDistilleries = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Building Material", 9, "", "Building Material")]
        BuildingMaterial = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Chemical industry", 4, "", "Chemical industry")]
        Chemicalindustry = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial", 17, "", "Commercial")]
        Commercial = 15,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("District Heating", 23, "", "District Heating")]
        DistrictHeating = 21,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Educational", 20, "", "Educational")]
        Educational = 18,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Entertainment&Conference", 18, "", "Entertainment&Conference")]
        EntertainmentConference = 16,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Food (Agro Products)", 1, "#0000ff", "Food (Agro Products)")]
        Food_AgroProducts = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Food & Beverage", 0, "", "Food & Beverage")]
        FoodBeverage = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Government", 24, "", "Government")]
        Government = 22,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Healthcare", 21, "", "Healthcare")]
        Healthcare = 19,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Hotel", 15, "", "Hotel")]
        Hotel = 13,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Metallurgy", 14, "", "Metallurgy")]
        Metallurgy = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Military", 25, "", "Military")]
        Military = 23,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Mining", 13, "", "Mining")]
        Mining = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Oil & Gas", 12, "", "Oil & Gas")]
        OilGas = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other Manufacturing & Production", 10, "", "Other Manufacturing & Production")]
        OtherManufacturingProduction = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Others", 26, "", "Others")]
        Others = 24,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pharmacy", 8, "", "Pharmacy")]
        Pharmacy = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Power Plant", 11, "", "Power Plant")]
        PowerPlant = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential", 19, "", "Residential")]
        Residential = 17,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Textile & Clothing", 6, "", "Textile & Clothing")]
        TextileClothing = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Tobacco", 5, "", "Tobacco")]
        Tobacco = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Transportation", 22, "", "Transportation")]
        Transportation = 20,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_Btt_region
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("International", 3, null, "International")]
        International = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Local", 0, null, "Local")]
        Local = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("National", 2, null, "National")]
        National = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Regional", 1, null, "Regional")]
        Regional = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_Btt_SalesModel
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Direct", 0, null, "Direct")]
        Direct = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Indirect", 1, null, "Indirect")]
        Indirect = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_Btt_specialdiscounts
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Account discount", 1, null, "Account discount")]
        Accountdiscount = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("From system (Standard )", 0, null, "From system (Standard )")]
        Fromsystem_Standard = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Project discount", 2, null, "Project discount")]
        Projectdiscount = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Total extra discount", 3, null, "Total extra discount")]
        Totalextradiscount = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_OpportunityRatingCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Cold", 2, null, "Cold")]
        Cold = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Hot", 0, null, "Hot")]
        Hot = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Warm", 1, null, "Warm")]
        Warm = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_PriorityCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("0 %", 0, "#0000ff")]
        _0 = 200010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("100 %", 5, "", "100 %")]
        _100 = 200009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("20 %", 1, "", "20 %")]
        _20 = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("40 %", 2, "", "40 %")]
        _40 = 200003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("60 %", 3, "", "60 %")]
        _60 = 200005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("80 %", 4, "", "80 %")]
        _80 = 200007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 6)]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_rbtt_Application
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Central", 0, "#0000ff", "Central")]
        Central = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("De-central", 1, "#0000ff", "De-central")]
        Decentral = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Specialized steam", 3, "#0000ff", "Specialized steam")]
        Specializedsteam = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Standard steam", 2, "#0000ff", "Standard steam")]
        Standardsteam = 173140002,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_rbtt_BusinessSegment
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial", 1, "#0000ff", "Commercial")]
        Commercial = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial", 2, "#0000ff", "Industrial")]
        Industrial = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential", 0, "#0000ff", "Residential")]
        Residential = 173140000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_rbtt_ResidentialBuildingType
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("MFD - Multi Family Dwelling", 1, "#0000ff", "MFD - Multi Family Dwelling")]
        MFDMultiFamilyDwelling = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SFD - Single Family Dwelling", 0, "#0000ff", "SFD - Single Family Dwelling")]
        SFDSingleFamilyDwelling = 173140000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_rbtt_ScoringChance
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("0 %", 0, "#0000ff", "0 %")]
        _0 = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("100 %", 5, "#0000ff", "100 %")]
        _100 = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("20 %", 1, "#0000ff", "20 %")]
        _20 = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("40 %", 2, "#0000ff", "40 %")]
        _40 = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("60 %", 3, "#0000ff", "60 %")]
        _60 = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("80 %", 4, "#0000ff", "80 %")]
        _80 = 173140004,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_SalesStage
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Close", 3)]
        Close = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Develop", 1)]
        Develop = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Propose", 2)]
        Propose = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Qualify", 0)]
        Qualify = 0,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_SalesStageCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("1st offer send", 4, null, "1st offer send")]
        _1stoffersend = 200003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2nd offer send", 5, null, "2nd offer send")]
        _2ndoffersend = 200004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Done (Checked and Certified)", 9, null, "Done (Checked and Certified)")]
        Done_CheckedandCertified = 200008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Done (installed)", 8, null, "Done (installed)")]
        Done_installed = 200007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("In Progress / working on", 3, null, "In Progress / working on")]
        InProgressworkingon = 200002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Lead", 2, null, "Lead")]
        Lead = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Order", 6, null, "Order")]
        Order = 200005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Planned for construction", 1, null, "Planned for construction")]
        Plannedforconstruction = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Realization Phase", 7, null, "Realization Phase")]
        RealizationPhase = 200006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Rejected / failed to score", 10, null, "Rejected / failed to score")]
        Rejectedfailedtoscore = 200009,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("-", 10, "#0000ff")]
        _ = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Canceled", 11, "#0000ff", "Canceled")]
        Canceled = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Certification completed", 8, "#0000ff", "Certification completed")]
        Certificationcompleted = 200004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("In Progress", 1, "#0000ff", "Preparation")]
        InProgress = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Installation completed", 7, "#0000ff", "Installation completed")]
        Installationcompleted = 200003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Negotiations", 3, "#0000ff", "Negotiations")]
        Negotiations = 200000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("On Hold", 6, "#0000ff", "1st offer sent")]
        OnHold = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Order", 4, "#0000ff", "Order")]
        Order = 200001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other reason", 16, "#0000ff", "Other reason")]
        Otherreason = 200007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Out-Sold", 13, "#0000ff", "Product specification")]
        OutSold = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Plant capacity", 12, "#0000ff", "Plant capacity")]
        Plantcapacity = 200008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pre-Sales", 0, "#0000ff")]
        PreSales = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Price", 14, "#0000ff", "Price")]
        Price = 200005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Quotation", 2, "#0000ff")]
        Quotation = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Realization", 5, "#0000ff", "Realisation")]
        Realization = 200002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Relationship", 15, "#0000ff", "Relationship")]
        Relationship = 200006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Won", 9, "#0000ff", "Won")]
        Won = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Opportunity_TimeLine
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Immediate", 0, null, "Immediate")]
        Immediate = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Next Quarter", 2, null, "Next Quarter")]
        NextQuarter = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Not known", 4, null, "Not known")]
        Notknown = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("This Quarter", 1, null, "This Quarter")]
        ThisQuarter = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("This Year", 3, null, "This Year")]
        ThisYear = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_classificationbase_Btt_Calculationbasedon
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Amount of money", 0, null, "Amount of money")]
        Amountofmoney = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No. of appliances", 1, null, "No. of appliances")]
        Noofappliances = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_classificationbase_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_country_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_machine_BTT_FactoryNumber
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("373", 0, null, "373")]
        _373 = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("594", 2, null, "594")]
        _594 = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("829", 1, null, "829")]
        _829 = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_machine_Btt_status
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Imported", 0, "", "Imported")]
        Imported = 962480000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No Reward Plan", 3, "", "No Reward Plan")]
        NoRewardPlan = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Open", 1, "", "Open")]
        Open = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Paid out", 2, "", "Paid out")]
        Paidout = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_machine_rbtt_RegistrationReason
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Cash-Back", 0, "#0000ff", "Cash-Back")]
        CashBack = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Warranty Extension", 1, "#0000ff", "Warranty Extension")]
        WarrantyExtension = 173140001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_machine_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, "#0000ff", "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 3, "#0000ff", "Inactive")]
        Inactive = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pending for Validation", 1, "#fdcd5a")]
        PendingforValidation = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SPAM", 2, "#ec39c6")]
        SPAM = 173140001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_productgroup_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_productgroupclassification_Btt_Calculationbasedon
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Amount of money", 0, null, "Amount of money")]
        Amountofmoney = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No. of appliances", 1, null, "No. of appliances")]
        Noofappliances = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_productgroupclassification_Btt_Workswith
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No", 0, null, "No")]
        No = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Occasionally", 1, null, "Occasionally")]
        Occasionally = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Regular", 3, null, "Regular")]
        Regular = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sometimes", 2, null, "Sometimes")]
        Sometimes = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_productgroupclassification_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_visitplanningbase_Orb_Rhythm_Code
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("1 Year", 9, "", "1 Year")]
        _1Year = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2 Months", 5, "", "2 Months")]
        _2Months = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2 Weeks", 1, "", "2 Weeks")]
        _2Weeks = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3 Months", 6, "", "3 Months")]
        _3Months = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3 Weeks", 2, "", "3 Weeks")]
        _3Weeks = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4 Months", 7, "", "4 Months")]
        _4Months = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4 Weeks", 3, "", "4 Weeks")]
        _4Weeks = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6 Months", 8, "", "6 Months")]
        _6Months = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6 Weeks", 4, "", "6 Weeks")]
        _6Weeks = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Never", 10, "", "Never")]
        Never = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Weekly", 0, "", "Weekly")]
        Weekly = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_visitplanningbase_rbtt_Visitduration
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("120", 4, "#0000ff", "120")]
        _120 = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("15", 0, "#0000ff", "15")]
        _15 = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("180", 5, "#0000ff", "180")]
        _180 = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("240", 6, "#0000ff", "240")]
        _240 = 173140006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("30", 1, "#0000ff", "30")]
        _30 = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("300", 7, "#0000ff", "300")]
        _300 = 173140007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("60", 2, "#0000ff", "60")]
        _60 = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("90", 3, "#0000ff", "90")]
        _90 = 173140003,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Orb_visitplanningbase_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Product_Orb_ProductTypecode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Incentive", 0, null, "Incentive")]
        Incentive = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Product_ProductStructure
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Product", 0, null, "Product")]
        Product = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Product Bundle", 2, null, "Product Bundle")]
        ProductBundle = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Product Family", 1, null, "Product Family")]
        ProductFamily = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Product_ProductTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Miscellaneous Charges", 1, null, "Miscellaneous Charges")]
        MiscellaneousCharges = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sales Inventory", 0, null, "Sales Inventory")]
        SalesInventory = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Services", 2, null, "Services")]
        Services = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Spare Part", 3, null, "Spare Part")]
        SparePart = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Product_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 2, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Draft", 0, null, "Draft")]
        Draft = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Retired", 3, null, "Retired")]
        Retired = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Under Revision", 1, null, "Under Revision")]
        UnderRevision = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum PurchaseProcess
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Committee", 1)]
        Committee = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Individual", 0)]
        Individual = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Unknown", 2)]
        Unknown = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum PurchaseTimeFrame
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Immediate", 0)]
        Immediate = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Next Quarter", 2)]
        NextQuarter = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("This Quarter", 1)]
        ThisQuarter = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("This Year", 3)]
        ThisYear = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Unknown", 4)]
        Unknown = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Qooi_PricingErrorCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Base Currency Attribute Overflow", 36)]
        BaseCurrencyAttributeOverflow = 36,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Base Currency Attribute Underflow", 37)]
        BaseCurrencyAttributeUnderflow = 37,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Detail Error", 1)]
        DetailError = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Discount Type Invalid State", 27)]
        DiscountTypeInvalidState = 27,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive Discount Type", 33)]
        InactiveDiscountType = 33,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive Price Level", 3)]
        InactivePriceLevel = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Current Cost", 20)]
        InvalidCurrentCost = 20,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Discount", 28)]
        InvalidDiscount = 28,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Discount Type", 26)]
        InvalidDiscountType = 26,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Price", 19)]
        InvalidPrice = 19,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Price Level Amount", 17)]
        InvalidPriceLevelAmount = 17,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Price Level Currency", 34)]
        InvalidPriceLevelCurrency = 34,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Price Level Percentage", 18)]
        InvalidPriceLevelPercentage = 18,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Pricing Code", 9)]
        InvalidPricingCode = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Pricing Precision", 30)]
        InvalidPricingPrecision = 30,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Product", 7)]
        InvalidProduct = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Quantity", 29)]
        InvalidQuantity = 29,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Rounding Amount", 24)]
        InvalidRoundingAmount = 24,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Rounding Option", 23)]
        InvalidRoundingOption = 23,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Rounding Policy", 22)]
        InvalidRoundingPolicy = 22,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invalid Standard Cost", 21)]
        InvalidStandardCost = 21,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Current Cost", 15)]
        MissingCurrentCost = 15,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Price", 14)]
        MissingPrice = 14,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Price Level", 2)]
        MissingPriceLevel = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Price Level Amount", 12)]
        MissingPriceLevelAmount = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Price Level Percentage", 13)]
        MissingPriceLevelPercentage = 13,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Pricing Code", 8)]
        MissingPricingCode = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Product", 6)]
        MissingProduct = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Product Default UOM", 31)]
        MissingProductDefaultUOM = 31,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Product UOM Schedule ", 32)]
        MissingProductUOMSchedule = 32,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Quantity", 4)]
        MissingQuantity = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Standard Cost", 16)]
        MissingStandardCost = 16,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing Unit Price", 5)]
        MissingUnitPrice = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Missing UOM", 10)]
        MissingUOM = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("None", 0)]
        None = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Price Attribute Out Of Range", 35)]
        PriceAttributeOutOfRange = 35,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Price Calculation Error", 25)]
        PriceCalculationError = 25,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Product Not In Price Level", 11)]
        ProductNotInPriceLevel = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Transaction currency is not set for the product price list item", 38)]
        Transactioncurrencyisnotsetfortheproductpricelistitem = 38,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum qooi_skippricecalculation
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("DoPriceCalcAlways", 0)]
        DoPriceCalcAlways = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SkipPriceCalcOnRetrieve", 1)]
        SkipPriceCalcOnRetrieve = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Quote_FreightTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("FOB", 0, null, "FOB")]
        FOB = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("No Charge", 1, null, "No Charge")]
        NoCharge = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Quote_PaymentTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2% 10, Net 30", 1, null, "2% 10, Net 30")]
        _210Net30 = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 30", 0, null, "Net 30")]
        Net30 = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 45", 2, null, "Net 45")]
        Net45 = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Net 60", 3, null, "Net 60")]
        Net60 = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Quote_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Airborne", 0, null, "Airborne")]
        Airborne = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("DHL", 1, null, "DHL")]
        DHL = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("FedEx", 2, null, "FedEx")]
        FedEx = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Full Load", 5, null, "Full Load")]
        FullLoad = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Postal Mail", 4, null, "Postal Mail")]
        PostalMail = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("UPS", 3, null, "UPS")]
        UPS = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Will Call", 6, null, "Will Call")]
        WillCall = 7,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Quote_ShipTo_FreightTermsCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Quote_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Canceled", 6, "#D24726", "Canceled")]
        Canceled = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("In Progress", 1, "#0000ff", "In Progress")]
        InProgress_Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("In Progress", 2, "#0000ff", "In Progress")]
        InProgress_Inactive = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Lost", 5, "#D70012", "Lost")]
        Lost = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Open", 3, "#0000ff", "Open")]
        Open = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Revised", 7, "#0E78C5", "Revised")]
        Revised = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Won", 4, "#0000ff", "Won")]
        Won_Inactive_4 = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Won", 0, "#67B419", "Won")]
        Won_Inactive_719280000 = 719280000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Quote_ttpoico_Technologies
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Air conditioning", 0, "#0000ff", "Air conditioning")]
        Airconditioning = 719280000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("AVAC", 1, "#0000ff", "AVAC")]
        AVAC = 719280001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Electrical Water heater", 2, "#0000ff", "Electrical Water heater")]
        ElectricalWaterheater = 719280002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Floor boiler", 3, "#0000ff", "Floor boiler")]
        Floorboiler = 719280003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Heat pump", 4, "#0000ff", "Heat pump")]
        Heatpump = 719280004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Thermal solar", 5, "#0000ff", "Thermal solar")]
        Thermalsolar = 719280005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wall boiler", 6, "#0000ff", "Wall boiler")]
        Wallboiler = 719280006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Water heaters", 7, "#0000ff", "Water heaters")]
        Waterheaters = 719280007,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Quote_ttpoico_Type
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial project", 0, "#0000ff", "Commercial project")]
        Commercialproject = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Generic", 2, "#0000ff", "Generic")]
        Generic = 719280001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Industrial", 1, "#0000ff", "Industrial")]
        Industrial = 719280000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Multi family", 3, "#0000ff", "Multi family")]
        Multifamily = 719280002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential Calculation", 4, "#0000ff", "Residential Calculation")]
        ResidentialCalculation = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential Project", 5, "#0000ff", "Residential Project")]
        ResidentialProject = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential Quotation", 6, "#0000ff", "Residential Quotation")]
        ResidentialQuotation = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Single family", 7, "#0000ff", "Single family")]
        Singlefamily = 719280003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Tertiary", 8, "#0000ff", "Tertiary")]
        Tertiary = 719280004,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_ABCStatusPlan
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("A1", 0, "#0000ff", "A1")]
        A1 = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("A2", 1, "#0000ff", "A2")]
        A2 = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("A3", 2, "#0000ff", "A3")]
        A3 = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("B1", 3, "#0000ff", "B1")]
        B1 = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("B2", 4, "#0000ff", "B2")]
        B2 = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("B3", 5, "#0000ff", "B3")]
        B3 = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("C1", 6, "#0000ff", "C1")]
        C1 = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("C2", 7, "#0000ff", "C2")]
        C2 = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("C3", 8, "#0000ff", "C3")]
        C3 = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("D1", 9, "#0000ff", "D1")]
        D1 = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("D2", 10, "#0000ff", "D2")]
        D2 = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("D3", 11, "#0000ff", "D3")]
        D3 = 12,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_apimonitor_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Authorized", 0, "#0E78C5")]
        Authorized = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 2, "#0000ff")]
        Inactive = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Rejected", 1, "#E20015")]
        Rejected = 173140000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_appliance_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, "#68e183", "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 3, "#0000ff", "Inactive")]
        Inactive = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pending for Validation", 1, "#fdcd5a")]
        PendingforValidation = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SPAM", 2, "#ec39c6")]
        SPAM = 173140001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_applicationid_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_bookoffeedback_rbtt_Category
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Consulting", 3, "#0000ff")]
        Consulting = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Data Management", 4, "#0000ff")]
        DataManagement = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Generic", 5, "#0000ff")]
        Generic = 173140006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Incidents", 2, "#0000ff")]
        Incidents = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Translations", 1, "#0000ff")]
        Translations = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("User Management", 0, "#0000ff")]
        UserManagement = 173140001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_bookoffeedback_rbtt_Rating
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("*", 0, "#0000ff")]
        @__173140000 = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("**", 1, "#0000ff")]
        @__173140001 = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("***", 2, "#0000ff")]
        @__173140002 = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("****", 3, "#0000ff")]
        @__173140003 = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("*****", 4, "#0000ff")]
        @__173140004 = 173140004,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_bookoffeedback_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0)]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1)]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_configurations_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_consent_rbtt_StorageTyp
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("File share", 2, "#0000ff", "File share")]
        Fileshare = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("In source system", 0, "#0000ff", "In source system")]
        Insourcesystem = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Local paper file system", 1, "#0000ff", "Local paper file system")]
        Localpaperfilesystem = 173140001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_consent_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 1, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 2, null, "Inactive")]
        Inactive = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Re-Import", 0, "#0000ff")]
        ReImport = 100000000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_consentactivities
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("All Activities", 7, "#0000ff", "All Activities")]
        AllActivities = 173140007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Appointment", 2, "#0000ff", "Appointment")]
        Appointment = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Email", 1, "#0000ff", "Email")]
        Email = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Letter", 5, "#0000ff", "Letter")]
        Letter = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Phone call", 0, "#0000ff", "Phone call")]
        Phonecall = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sales Activities", 6, "#0000ff", "Sales Activities")]
        SalesActivities = 173140006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Service Activity", 3, "#0000ff", "Service Activity")]
        ServiceActivity = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Social Activity", 4, "#0000ff", "Social Activity")]
        SocialActivity = 173140004,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_ConsentActivityTypes
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Advertising", 3, "#0000ff", "Advertising")]
        Advertising = 173140006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Contractual interest", 14, "#0000ff", "tet")]
        Contractualinterest = 173140008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("E-Learning Newsletter", 4, "#0000ff", "E-Learning Newsletter")]
        ELearningNewsletter = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("---Explicit Consent---", 2, "#0000ff", "---Explicit Consent---")]
        ExplicitConsent = 173140012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Fiscal authorities", 15, "#0000ff", "aa")]
        Fiscalauthorities = 173140009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("General newsletter", 5, "#0000ff", "General newsletter")]
        Generalnewsletter = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("General Telephone Advertising", 6, "#0000ff", "General Telephone Advertising")]
        GeneralTelephoneAdvertising = 173140014,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("---Legal Obligation---", 13, "#0000ff", "---Legal Obligation---")]
        LegalObligation = 173140010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("---Legitimate interest---", 11, "#0000ff", "---Legitimate interest---")]
        Legitimateinterest = 173140013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Market Research", 7, "#0000ff", "Market Research")]
        MarketResearch = 173140007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Partner Program Newsletter", 8, "#0000ff", "Partner Program Newsletter")]
        PartnerProgramNewsletter = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Product Information", 9, "#0000ff", "Product Information")]
        ProductInformation = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Product recalls", 12, "#0000ff", "Product recalls")]
        Productrecalls = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("---Public---", 0, "#0000ff", "---Public---")]
        Public = 173140011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Public Information", 1, "#0000ff", "724")]
        PublicInformation = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Use of the image", 10, "#0000ff", "Use of the image")]
        Useoftheimage = 173140015,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_consenttext_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_customermasterdataexchange_rbtt_MDCStatus
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Approved", 2, "#0000ff", "Approved")]
        Approved = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Draft", 0, "#0000ff", "In Draft")]
        Draft = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Rejected", 3, "#0000ff", "Rejected")]
        Rejected = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Requested", 1, "#0000ff", "In Progress")]
        Requested = 173140001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_customermasterdataexchange_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_delivernote_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0)]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1)]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_delivernoteitem_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0)]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1)]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_DistanceList
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("...", 3, "#0000ff", "...")]
        _ = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("20 KM", 0, "#0000ff", "20 KM")]
        _20KM = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("30 KM", 1, "#0000ff", "30 KM")]
        _30KM = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("40 KM", 2, "#0000ff", "40 KM")]
        _40KM = 173140002,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_IndustryReference
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Automotive", 0, "#0000ff", "Automotive")]
        Automotive = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Banking & Finance", 1, "#0000ff", "Banking & Finance")]
        BankingFinance = 173140014,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Building Material", 2, "#0000ff", "Building Material")]
        BuildingMaterial = 173140006,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Chemical industry", 3, "#0000ff", "Chemical industry")]
        Chemicalindustry = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Commercial", 4, "#0000ff", "Commercial")]
        Commercial = 173140016,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Construction industry", 5, "#0000ff", "Construction industry")]
        Constructionindustry_173140028 = 173140028,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Construction industry", 6, "#0000ff", "Construction industry")]
        Constructionindustry_173140030 = 173140030,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("District Heating", 7, "#0000ff", "District Heating")]
        DistrictHeating = 173140022,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Educational", 8, "#0000ff", "Educational")]
        Educational = 173140019,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Energy industry / Power Plant", 9, "#0000ff", "Energy industry / Power Plant")]
        EnergyindustryPowerPlant = 173140009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Entertainment&Conference", 10, "#0000ff", "Entertainment&Conference")]
        EntertainmentConference = 173140017,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Food & Beverage", 11, "#0000ff", "Food & Beverage")]
        FoodBeverage = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Government", 12, "#0000ff", "Government")]
        Government = 173140023,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Healthcare", 13, "#0000ff", "Healthcare")]
        Healthcare = 173140020,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Hotel", 14, "#0000ff", "Hotel")]
        Hotel = 173140013,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Item", 15, "#0000ff", "Item")]
        Item_173140007 = 173140007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Item", 16, "#0000ff", "Item")]
        Item_173140015 = 173140015,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Laundries", 17, "#0000ff", "Laundries")]
        Laundries = 173140033,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Leather production", 18, "#0000ff", "Leather production")]
        Leatherproduction = 173140032,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Metallurgy", 19, "#0000ff", "Metallurgy")]
        Metallurgy = 173140012,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Military", 20, "#0000ff", "Military")]
        Military = 173140024,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Mining", 21, "#0000ff", "Mining")]
        Mining = 173140011,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Oil & Gas", 22, "#0000ff", "Oil & Gas")]
        OilGas = 173140010,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other Manufacturing & Production", 23, "#0000ff", "Other Manufacturing & Production")]
        OtherManufacturingProduction = 173140008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Others", 34, "#0000ff", "Others")]
        Others = 173140025,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Paper Industry", 24, "#0000ff", "Paper Industry")]
        PaperIndustry_173140026 = 173140026,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Paper Industry", 25, "#0000ff", "Paper Industry")]
        PaperIndustry_173140029 = 173140029,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pharmacy", 26, "#0000ff", "Pharmacy")]
        Pharmacy = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Residential", 27, "#0000ff", "Residential")]
        Residential = 173140018,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Rubber, plastic", 28, "#0000ff", "Rubber, plastic")]
        Rubberplastic = 173140027,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sewage / Recycling industry", 29, "#0000ff", "Sewage / Recycling industry")]
        SewageRecyclingindustry = 173140031,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Textile & Clothing", 30, "#0000ff", "Textile & Clothing")]
        TextileClothing = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Tobacco", 31, "#0000ff", "Tobacco")]
        Tobacco = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Transportation", 32, "#0000ff", "Transportation")]
        Transportation = 173140021,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Wood production", 33, "#0000ff", "Wood production")]
        Woodproduction = 173140034,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_PartnerStatusList
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Certified Partner", 1, "#0000ff", "3")]
        CertifiedPartner = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Partner", 0, "#0000ff", "2")]
        Partner = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Unknown", 2, "#0000ff", "Unknown")]
        Unknown = 173140002,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_processingactivity_rbtt_LegalBasis
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("0", 0, "#0000ff", "0")]
        _0 = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("1", 1, "#0000ff", "1")]
        _1 = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("2", 2, "#0000ff", "2")]
        _2 = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("3", 3, "#0000ff", "3")]
        _3 = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("4", 4, "#0000ff", "4")]
        _4 = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("5", 5, "#0000ff", "5")]
        _5 = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("6", 6, "#0000ff", "6")]
        _6 = 6,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_processingactivity_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_productionplants_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0, null, "Active")]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1, null, "Inactive")]
        Inactive = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_ProjectPhases
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pre-Sales", 0, "#0000ff", "Pre-Sales")]
        PreSales = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Quotation", 1, "#0000ff", "Quotation")]
        Quotation = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Realization", 2, "#0000ff", "Realization")]
        Realization = 173140002,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_ProjectType1
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Modification", 3, "#0000ff")]
        Modification = 100004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("New", 0, "#0000ff")]
        New = 100001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Renovation", 2, "#0000ff")]
        Renovation = 100003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Replacement", 1, "#0000ff")]
        Replacement = 100002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Retrofit", 4, "#0000ff")]
        Retrofit = 100005,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_RegistrationTypeList
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("CRM", 0, "#0000ff", "CRM")]
        CRM = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Project", 1, "#0000ff", "Project")]
        Project = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("ScannApp", 2, "#0000ff", "ScannApp")]
        ScannApp = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Web", 3, "#0000ff", "Web")]
        Web = 173140000,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_SARegion
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SA 1", 0, "#0000ff", "SA 1")]
        SA1 = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SA 2", 1, "#0000ff", "SA 2")]
        SA2 = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SA 3", 2, "#0000ff", "SA 3")]
        SA3 = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SA 4", 3, "#0000ff", "SA 4")]
        SA4 = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SA 5", 4, "#0000ff", "SA 5")]
        SA5 = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("SA 6", 5, "#0000ff", "SA 6")]
        SA6 = 173140005,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_SegmentationType
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Generalist", 0, "#0000ff")]
        Generalist = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Innovator", 4, "#0000ff")]
        Innovator = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Proud Craftsman", 2, "#0000ff")]
        ProudCraftsman = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Support Seeker", 3, "#0000ff")]
        SupportSeeker = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Traditionalist", 1, "#0000ff")]
        Traditionalist = 173140001,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum rbtt_SystemList
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Bosch Partner Portal", 0, "#0000ff", "Bosch Partner Portal")]
        BoschPartnerPortal = 173140007,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("eAcademy", 1, "#0000ff", "eAcademy")]
        eAcademy = 173140000,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("ERP", 2, "#0000ff", "ERP")]
        ERP = 173140001,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("GDPR Consent System", 3, "#0000ff", "GDPR Consent System")]
        GDPRConsentSystem = 173140003,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("GDPR Consent System Local", 4, "#0000ff", "GDPR Consent System Local")]
        GDPRConsentSystemLocal = 173140005,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Lead Management", 5, "#0000ff", "Lead Management")]
        LeadManagement = 173140008,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Optivo", 7, "#0000ff", "Optivo")]
        Optivo = 173140004,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Partner Program", 8, "#0000ff", "Partner Program")]
        PartnerProgram = 173140002,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Telephone Voice Record", 6, "#0000ff", "Telephone Voice Record")]
        TelephoneVoiceRecord = 173140009,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Website", 9, "#0000ff", "Website")]
        Website = 173140006,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SdkMessageProcessingStep_InvocationSource
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Child", 2)]
        Child = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Internal", 0)]
        Internal = -1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Parent", 1)]
        Parent = 0,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SdkMessageProcessingStep_Mode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Asynchronous", 1)]
        Asynchronous = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Synchronous", 0)]
        Synchronous = 0,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SdkMessageProcessingStep_Stage
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Final Post-operation (For internal use only)", 10)]
        FinalPostoperation_Forinternaluseonly = 55,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Initial Pre-operation (For internal use only)", 0)]
        InitialPreoperation_Forinternaluseonly = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Internal Post-operation After External Plugins (For internal use only)", 8)]
        InternalPostoperationAfterExternalPlugins_Forinternaluseonly = 45,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Internal Post-operation Before External Plugins (For internal use only)", 6)]
        InternalPostoperationBeforeExternalPlugins_Forinternaluseonly = 35,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Internal Pre-operation After External Plugins (For internal use only)", 4)]
        InternalPreoperationAfterExternalPlugins_Forinternaluseonly = 25,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Internal Pre-operation Before External Plugins (For internal use only)", 2)]
        InternalPreoperationBeforeExternalPlugins_Forinternaluseonly = 15,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Main Operation (For internal use only)", 5)]
        MainOperation_Forinternaluseonly = 30,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Post-Commit stage fired after transaction commit (For internal use only)", 12)]
        PostCommitstagefiredaftertransactioncommit_Forinternaluseonly = 90,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Post-operation", 7)]
        Postoperation = 40,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Post-operation (Deprecated)", 9)]
        Postoperation_Deprecated = 50,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pre-Commit stage fired before transaction commit (For internal use only)", 11)]
        PreCommitstagefiredbeforetransactioncommit_Forinternaluseonly = 80,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pre-operation", 3)]
        Preoperation = 20,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pre-validation", 1)]
        Prevalidation = 10,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SdkMessageProcessingStep_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Disabled", 1)]
        Disabled = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Enabled", 0)]
        Enabled = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SdkMessageProcessingStep_SupportedDeployment
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Both", 2)]
        Both = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Microsoft Dynamics 365 Client for Outlook Only", 1)]
        MicrosoftDynamics365ClientforOutlookOnly = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Server Only", 0)]
        ServerOnly = 0,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_AccessMode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administrative", 1, null, "Administrative")]
        Administrative = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Delegated Admin", 5, null, "Delegated Admin")]
        DelegatedAdmin = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Non-interactive", 4, null, "Non-interactive")]
        Noninteractive = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Read", 2, null, "Read")]
        Read = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Read-Write", 0, null, "Read-Write")]
        ReadWrite = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Support User", 3, null, "Support User")]
        SupportUser = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_Address1_AddressTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0)]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_Address1_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0)]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_Address2_AddressTypeCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0)]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_Address2_ShippingMethodCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0)]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_CALType
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Administrative", 1, null, "Administrative")]
        Administrative = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Basic", 2, null, "Basic")]
        Basic = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Device Basic", 4, null, "Device Basic")]
        DeviceBasic = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Device Enterprise", 8, null, "Device Enterprise")]
        DeviceEnterprise = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Device Essential", 6, null, "Device Essential")]
        DeviceEssential = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Device Professional", 3, null, "Device Professional")]
        DeviceProfessional = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Enterprise", 7, null, "Enterprise")]
        Enterprise = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Essential", 5, null, "Essential")]
        Essential = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Field Service", 11)]
        FieldService = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Professional", 0, null, "Professional")]
        Professional = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Project Service", 12)]
        ProjectService = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Sales", 9)]
        Sales = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Service", 10)]
        Service = 10,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_EmailRouterAccessApproval
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Approved", 1, null, "Approved")]
        Approved = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Empty", 0, null, "Empty")]
        Empty = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Pending Approval", 2, null, "Pending Approval")]
        PendingApproval = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Rejected", 3, null, "Rejected")]
        Rejected = 3,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_IncomingEmailDeliveryMethod
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Forward Mailbox", 3, null, "Forward Mailbox")]
        ForwardMailbox = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Microsoft Dynamics CRM for Outlook", 1, null, "Microsoft Dynamics CRM for Outlook")]
        MicrosoftDynamicsCRMforOutlook = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("None", 0, null, "None")]
        None = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Server-Side Synchronization or Email Router", 2, null, "Server-Side Synchronization or Email Router")]
        ServerSideSynchronizationorEmailRouter = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_InviteStatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invitation Accepted", 4, null, "Invitation Accepted")]
        InvitationAccepted = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invitation Expired", 3, null, "Invitation Expired")]
        InvitationExpired = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invitation Near Expired", 2, null, "Invitation Near Expired")]
        InvitationNearExpired = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invitation Not Sent", 0, null, "Invitation Not Sent")]
        InvitationNotSent = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invitation Rejected", 5, null, "Invitation Rejected")]
        InvitationRejected = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invitation Revoked", 6, null, "Invitation Revoked")]
        InvitationRevoked = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Invited", 1, null, "Invited")]
        Invited = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_OutgoingEmailDeliveryMethod
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Microsoft Dynamics CRM for Outlook", 1, null, "Microsoft Dynamics CRM for Outlook")]
        MicrosoftDynamicsCRMforOutlook = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("None", 0, null, "None")]
        None = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Server-Side Synchronization or Email Router", 2, null, "Server-Side Synchronization or Email Router")]
        ServerSideSynchronizationorEmailRouter = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_PreferredAddressCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Mailing Address", 0, null, "Mailing Address")]
        MailingAddress = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other Address", 1, null, "Other Address")]
        OtherAddress = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_PreferredEmailCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Default Value", 0, null, "Default Value")]
        DefaultValue = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum SystemUser_PreferredPhoneCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Home Phone", 2, null, "Home Phone")]
        HomePhone = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Main Phone", 0, null, "Main Phone")]
        MainPhone = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Mobile Phone", 3, null, "Mobile Phone")]
        MobilePhone = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other Phone", 1, null, "Other Phone")]
        OtherPhone = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Task_Btt_Taskcategory
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("General", 0, "", "General")]
        General = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Information", 1, "", "Information")]
        Information = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Other", 3, "", "Other")]
        Other = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Technical", 2, "", "Technical")]
        Technical = 2,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Task_PriorityCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("High", 2, null, "High")]
        High = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Low", 0, null, "Low")]
        Low = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Normal", 1, null, "Normal")]
        Normal = 1,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum Task_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Canceled", 4, null, "Canceled")]
        Canceled = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Completed", 3, null, "Completed")]
        Completed = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Deferred", 5, null, "Deferred")]
        Deferred = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("In Progress", 1, null, "In Progress")]
        InProgress = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Not Started", 0, null, "Not Started")]
        NotStarted = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Waiting on someone else", 2, null, "Waiting on someone else")]
        Waitingonsomeoneelse = 4,
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public enum UoMSchedule_StatusCode
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Active", 0)]
        Active = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        [OptionSetMetadataAttribute("Inactive", 1)]
        Inactive = 2,
    }
}
