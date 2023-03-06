using System;

namespace SharedLibraries_Plugins.Models
{
    public partial class DeliveryNotesResponse
    {
        public deliveryCollection[] deliveryCollection { get; set; }
    }

    public class deliveryCollection
    {
        public string deliveryNoteId { get; set; }

        public DateTime deliveryCreationDate { get; set; }

        public DateTime deliveryDate { get; set; }

        public string plantOrg { get; set; }

        public string salesOrg { get; set; }

        public string invoiceId { get; set; }

        public string orderId { get; set; }

        public shipToParty shipToParty { get; set; }

        public itemCollection[] itemCollection { get; set; }
    }

    public class shipToParty
    {
        public string erpCustomerId { get; set; }

        public string vatid { get; set; }

        public string boschid { get; set; }

        public string name1 { get; set; }

        public string name2 { get; set; }

        public string street { get; set; }

        public string street2 { get; set; }

        public string street3 { get; set; }

        public string houseNr { get; set; }

        public string postalCode { get; set; }

        public string city { get; set; }

        public string country { get; set; }

        public string fax { get; set; }

        public string phone { get; set; }

        public string email { get; set; }
    }

    public class itemCollection
    {
        public string ttnr { get; set; }

        public int position { get; set; }

        public string scannRule { get; set; }

        public applianceCollection[] applianceCollection { get; set; }
    }

    public class applianceCollection
    {
        public string equipmentId { get; set; }

        public string scann { get; set; }

        public string serialNumber { get; set; }

        public string specialSn { get; set; }
    }
}