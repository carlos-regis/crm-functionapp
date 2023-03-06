namespace SharedLibraries_Plugins.Models
{
    public class webproductdataserviceResponse
    {
        public Documents[] Documents { get; set; }

        public Properties Properties { get; set; }

        public string DbId { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public string MaterialNumber { get; set; }

        public string ErpClass { get; set; }

        public string MarketGenericDescription { get; set; }

        public string HeatingEfficiencyClass { get; set; }

        public string DhwEfficiencyClass { get; set; }

        public string MetaCategory { get; set; }

        public string FamilyName { get; set; }

        public string FamilyThumbNail { get; set; }

        public string FluorinatedGasRelevant { get; set; }

        public string ErpComplete { get; set; }

        public string MaterialState { get; set; }
    }

    public class Documents
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }
    }

    public class Properties
    {
        public string COUNTRIES_OF_SALE { get; set; }
    }
}