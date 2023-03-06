namespace SharedLibraries_Plugins.Models
{
    public class CustomerIdStructure
    {
        //[JsonProperty("Country")]
        public string Country { get; set; }

        //[JsonProperty("Brand")]
        public string Brand { get; set; }

        //[JsonProperty("CustomerNumber")]
        public string CustomerNumber { get; set; }
    }

    public class Address
    {
        public string Title { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string HouseNumber { get; set; }
        public string HouseNumber2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public string Province { get; set; }
        public string Website { get; set; }
    }

    public class BankDetails
    {
        public string AccountNumber { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Status
    {
        public string Blocked { get; set; }
    }

    public class Relations
    {
        public string Role { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
    }

    public class GetCustomerInformationResponse
    {
        public CustomerIdStructure CustomerIdStructure { get; set; }
        public Address Address { get; set; }
        public BankDetails BankDetails { get; set; }
        public Status Status { get; set; }
        public Relations Relations { get; set; }
        public string SalesTaxIdentNumber { get; set; }
    }

    public partial class RootGetCustomerInformationResponse
    {
        public GetCustomerInformationResponse GetCustomerInformationResponse { get; set; }
    }

    public partial class GetCustomerUpdatesResponses
    {
        //[JsonProperty("GetCustomerUpdatesResponse")]
        public GetCustomerUpdatesResponse GetCustomerUpdatesResponse { get; set; }
    }

    public class GetCustomerUpdatesResponse
    {
        //[JsonProperty("ChangedCustomer")]
        public ChangedCustomer[] ChangedCustomer { get; set; }
    }

    public class ChangedCustomer
    {
        //[JsonProperty("CustomerIdStructure")]
        public CustomerIdStructure CustomerIdStructure { get; set; }
    }

    public partial class GetCustomerUpdatesResponsesSingle
    {
        //[JsonProperty("GetCustomerUpdatesResponse")]
        public GetCustomerUpdatesResponseSingle GetCustomerUpdatesResponse { get; set; }
    }

    public class GetCustomerUpdatesResponseSingle
    {
        //[JsonProperty("ChangedCustomer")]
        public ChangedCustomer ChangedCustomer { get; set; }
    }
}