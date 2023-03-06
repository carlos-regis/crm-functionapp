using System;
using System.Diagnostics.CodeAnalysis;

namespace SharedLibraries_Plugins
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    [ExcludeFromCodeCoverage]
    public class PluginRegistrationAttribute : Attribute
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="entityLogicalName"></param>
        /// <param name="stage"></param>
        /// <param name="messageName"></param>
        /// <param name="includePreImage"></param>
        /// <param name="includePostImage"></param>
        /// <param name="preImageAlias"></param>
        /// <param name="postImageAlias"></param>
        /// <param name="mode"></param>
        public PluginRegistrationAttribute(string entityLogicalName,
            Stage stage,
            string messageName,
            bool includePreImage = false,
            bool includePostImage = false,
            string preImageAlias = "Default",
            string postImageAlias = "Default",
            SdkMessageProcessingStepMode mode = SdkMessageProcessingStepMode.Synchronous)
        {
            Stage = stage;
            MessageName = messageName;
            IncludePreImage = includePreImage;
            IncludePostImage = includePostImage;
            PreImageAlias = preImageAlias;
            PostImageAlias = postImageAlias;
            EntityLogicalName = entityLogicalName;
            AsAsync = mode == SdkMessageProcessingStepMode.Asynchronous;
        }

        /// <summary>
        /// The MessageName for which the plugin step shall be triggered
        /// </summary>
        /// <example>Create, Update, Delete</example>
        public string MessageName { get; set; }

        /// <summary>
        /// The Stage for which the plugin step shall be triggered
        /// </summary>
        public Stage Stage { get; set; }

        /// <summary>
        /// The Entity for which the plugin step shall be triggered
        /// </summary>
        public string EntityLogicalName { get; set; }

        /// <summary>
        /// True if the plugin step should be executed as asyncronous
        /// </summary>
        public bool AsAsync { get; set; }

        /// <summary>
        /// True if the plugin step shall include a PreImage including all attributes
        /// </summary>
        public bool IncludePreImage { get; set; }

        /// <summary>
        /// True if the plugin step shall include a PostImage including all attributes
        /// </summary>
        public bool IncludePostImage { get; set; }

        /// <summary>
        /// The alias name of the PreImage
        /// </summary>
        public string PreImageAlias { get; set; }

        /// <summary>
        /// The alias name of the PostImage
        /// </summary>
        public string PostImageAlias { get; set; }

        /// <summary>
        /// True if the plugin step shall include a PreImage including all attributes
        /// </summary>
        public string[] FilteredAttributes { get; set; }
    }

    public enum Stage
    {
        /// <summary>
        ///     Indicates no valid crm stage.
        /// </summary>
        Undefined = 0,

        /// <summary>
        ///     Pre validation stage
        /// </summary>
        PreValidation = 10,

        /// <summary>
        ///     Pre operation stage
        /// </summary>
        PreOperation = 20,

        /// <summary>
        ///     Main operation stage
        /// </summary>
        MainOperation = 30,

        /// <summary>
        ///     Post operation stage
        /// </summary>
        PostOperation = 40
    }

    public enum SdkMessageProcessingStepMode
    {
        Synchronous = 0,
        Asynchronous = 1
    }

    public static class MessageNames
    {
        /// <summary>
        ///     Message Send
        /// </summary>
        public const string Send = "Send";

        /// <summary>
        ///     Message DeliverIncoming
        /// </summary>
        public const string DeliverIncoming = "DeliverIncoming";

        /// <summary>
        ///     Message Retrieve
        /// </summary>
        public const string Retrieve = "Retrieve";

        /// <summary>
        ///     Message Assign
        /// </summary>
        public const string Assign = "Assign";

        /// <summary>
        ///     Message AddToQueue
        /// </summary>
        public const string AddToQueue = "AddToQueue";

        /// <summary>
        ///     Message Delete
        /// </summary>
        public const string Delete = "Delete";

        /// <summary>
        ///     Message Update
        /// </summary>
        public const string Update = "Update";

        /// <summary>
        ///     Message Create
        /// </summary>
        public const string Create = "Create";

        /// <summary>
        ///     Message RetrieveMultiple
        /// </summary>
        public const string RetrieveMultiple = "RetrieveMultiple";

        /// <summary>
        ///     Message SetState
        /// </summary>
        public const string SetState = "SetStateDynamicEntity";

        /// <summary>
        ///     Message Win
        /// </summary>
        public const string Win = "Win";

        /// <summary>
        ///     Message Lose
        /// </summary>
        public const string Lose = "Lose";

        /// <summary>
        ///     Message Cancel
        /// </summary>
        public const string Cancel = "Cancel";

        /// <summary>
        ///     Message for Case Closed.
        /// </summary>
        public const string Close = "Close";

        /// <summary>
        ///     Message for Reschedule
        /// </summary>
        public const string Reschedule = "Reschedule";

        /// <summary>
        ///     Message for Merge
        /// </summary>
        public const string Merge = "Merge";

        /// <summary>
        ///     QualifyLead Message Name
        /// </summary>
        public const string QualifyLead = "QualifyLead";

        /// <summary>
        ///     Message for RouteTo
        /// </summary>
        public const string RouteTo = "RouteTo";

        /// <summary>
        ///     Message for PickFromQueue
        /// </summary>
        public const string PickFromQueue = "PickFromQueue";

        /// <summary>
        ///     Message for ConvertActivity (internal only) used in ParentContext by CRM System
        /// </summary>
        public const string ConvertActivity = "ConvertActivity";

        /// <summary>
        /// Message for AddListMembers
        /// </summary>
        public const string AddListMembers = "AddListMembers";

        /// <summary>
        /// Message for Associate
        /// </summary>
        public const string Associate = "Associate";

        /// <summary>
        /// Message for AddMember
        /// </summary>
        public const string AddMember = "AddMember";

        /// <summary>
        /// Message for RemoveMember
        /// </summary>
        public const string RemoveMember = "RemoveMember";

        /// <summary>
        /// Message for Book
        /// </summary>
        public const string Book = "Book";

        /// <summary>
        /// Message for AddMember
        /// </summary>
        public const string AddUserToRecordTeam = "AddUserToRecordTeam";

        /// <summary>
        /// Message for RemoveMember
        /// </summary>
        public const string RemoveUserFromRecordTeam = "RemoveUserFromRecordTeam";
    }
}