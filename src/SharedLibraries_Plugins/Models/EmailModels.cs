using Microsoft.Xrm.Sdk;
using System;

namespace SharedLibraries_Plugins.Models
{
    public class EmailModels
    {
        public PartyId from { get; set; }
        public PartyId to { get; set; }
        public PartyId CC { get; set; }
        public PartyId BCC { get; set; }
        public EntityReference regardingobjectid { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public bool directioncode { get; set; }
        public Guid TemplateGuid { get; set; }
        public string TemplateName { get; set; }
        public Guid owner { get; set; }
        public Message message { get; set; }
    }

    public class PartyId
    {
        public Guid Id { get; set; }
        public string entity { get; set; }
    }

    public class Message
    {
        public string origin { get; set; }
        public string URL { get; set; }
        public DateTime when { get; set; }
        public string error { get; set; }
    }
}