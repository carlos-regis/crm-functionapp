using FakeXrmEasy.Abstractions.Plugins.Enums;
using Microsoft.Xrm.Sdk;
using System.Runtime.Serialization;

namespace Ttms.Crm.FunctionApp.UnitTests.Common
{
    /// <summary>
    /// Holds custom properties of a RemoteExecutionContext
    /// Defines the contextual information sent to a remote service endpoint at run-time.
    /// Extracted from https://learn.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.remoteexecutioncontext?view=dataverse-sdk-latest#properties
    /// </summary>
    [DataContract(Name = "RemoteExecutionContext", Namespace = "")]
    public class FakeRemoteExecutionContext : IPluginExecutionContext, IExtensibleDataObject
    {
        [DataMember(Order = 1)]
        public Guid BusinessUnitId { get; set; }

        [DataMember(Order = 2)]
        public Guid CorrelationId { get; set; }

        [DataMember(Order = 3)]
        public int Depth { get; set; }

        [DataMember(Order = 4)]
        public ExtensionDataObject? ExtensionData { get; set; }

        [DataMember(Order = 5)]
        public Guid InitiatingUserAzureActiveDirectoryObjectId { get; set; }

        [DataMember(Order = 6)]
        public Guid InitiatingUserId { get; set; }

        [DataMember(Order = 7)]
        public ParameterCollection InputParameters { get; set; }

        [DataMember(Order = 8)]
        public bool IsExecutingOffline { get; set; }

        [DataMember(Order = 9)]
        public bool IsInTransaction
        {
            get => Stage == (int)ProcessingStepStage.Preoperation || Stage == (int)ProcessingStepStage.Postoperation && Mode == (int)ProcessingStepMode.Synchronous;
            set {  /* This property is writable only to correctly support serialization/deserialization */ }
        }

        [DataMember(Order = 10)]
        public bool IsOfflinePlayback { get; set; }

        [DataMember(Order = 11)]
        public int IsolationMode { get; set; }

        [DataMember(Order = 12)]
        public string MessageName { get; set; }

        [DataMember(Order = 13)]
        public int Mode { get; set; }

        [DataMember(Order = 14)]
        public DateTime OperationCreatedOn { get; set; }

        [DataMember(Order = 15)]
        public Guid OperationId { get; set; }

        [DataMember(Order = 16)]
        public Guid OrganizationId { get; set; }

        [DataMember(Order = 17)]
        public string OrganizationName { get; set; } = string.Empty;

        [DataMember(Order = 18)]
        public ParameterCollection OutputParameters { get; set; }

        [DataMember(Order = 19)]
        public EntityReference OwningExtension { get; set; } = null!;

        [DataMember(Order = 20)]
        public IPluginExecutionContext ParentContext { get; set; }

        [DataMember(Order = 21)]
        public EntityImageCollection PostEntityImages { get; set; }

        [DataMember(Order = 22)]
        public EntityImageCollection PreEntityImages { get; set; }

        [DataMember(Order = 23)]
        public Guid PrimaryEntityId { get; set; }

        [DataMember(Order = 24)]
        public string PrimaryEntityName { get; set; } = string.Empty;

        [DataMember(Order = 25)]
        public Guid? RequestId { get; set; }

        [DataMember(Order = 26)]
        public string SecondaryEntityName { get; set; } = string.Empty;

        [DataMember(Order = 27)]
        public ParameterCollection SharedVariables { get; set; }

        [DataMember(Order = 28)]
        public int Stage { get; set; }

        [DataMember(Order = 29)]
        public Guid UserAzureActiveDirectoryObjectId { get; set; }

        [DataMember(Order = 30)]
        public Guid UserId { get; set; }

        public FakeRemoteExecutionContext()
        {
            Depth = 1;
            IsExecutingOffline = false;
            MessageName = "Create";
            IsolationMode = 1;
            InputParameters = new ParameterCollection();
            OutputParameters = new ParameterCollection();
            SharedVariables = new ParameterCollection();
            PreEntityImages = new EntityImageCollection();
            PostEntityImages = new EntityImageCollection();
            ParentContext = new RemoteExecutionContext();
            OperationCreatedOn = DateTime.UtcNow;
        }
    }
}
