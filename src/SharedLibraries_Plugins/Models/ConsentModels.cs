using System;
using System.Runtime.Serialization;

namespace SharedLibraries_Plugins.Models
{
    internal class ConsentModels
    {
    }

    [DataContract]
    [KnownType(typeof(ConsentObject))]
    [Serializable]
    public class ConsentObject
    {
        public string authorize_url { get; set; }
        public string access_token_url { get; set; }
        public string bearer_token { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string proxy_url { get; set; }
        public int proxy_port { get; set; }
        public string proxy { get; set; }
        public string frameURL { get; set; }

        public string id { get; set; }
        public int subjectIdentifierType { get; set; }
        public string subjectIdentifier { get; set; }
        public string sourceApplicationId { get; set; }
        public int consentTextRevision { get; set; }
        public int storageType { get; set; }
        public string storageLocation { get; set; }
        public string documentedOn { get; set; }
        public string lastUsed { get; set; }

        public string jsonBody { get; set; }
    }

    [DataContract]
    [KnownType(typeof(ConsentsCreateResponseObject))]
    [Serializable]
    public class ConsentsCreateResponseObject
    {
        public string id { get; set; }
        public string subjectIdentifier { get; set; }
        public string entryType { get; set; }
        public string documentedOn { get; set; }
        public string lastUsed { get; set; }
        public string expiresAfter { get; set; }
        public string expiresOn { get; set; }
        public string timestamp { get; set; }
    }

    [DataContract]
    [KnownType(typeof(ConsentsUpdateResponseObject))]
    [Serializable]
    public class ConsentsUpdateResponseObject
    {
        public string result { get; set; }
        public string resultStatus { get; set; }
        public ConsentEntry entry { get; set; }
    }

    public class ConsentEntry
    {
        public string id { get; set; }
        public string activityId { get; set; }
        public string subjectIdentifierType { get; set; }
        public string subjectIdentifierTypeName { get; set; }
        public string subjectIdentifier { get; set; }
        public string entryType { get; set; }
        public string sourceApplicationId { get; set; }
        public string consentTextRevision { get; set; }
        public string storageType { get; set; }
        public string documentedOn { get; set; }
        public string lastUsed { get; set; }
        public string timestamp { get; set; }
    }
}