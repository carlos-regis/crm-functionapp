//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SharedLibraries_Plugins.EntityModel
{
	
	/// <summary>
	/// Message that is supported by the SDK.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessage")]
	public partial class SdkMessage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AutoTransact = "autotransact";
			public const string Availability = "availability";
			public const string CategoryName = "categoryname";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CustomizationLevel = "customizationlevel";
			public const string ExecutePrivilegeName = "executeprivilegename";
			public const string Expand = "expand";
			public const string IntroducedVersion = "introducedversion";
			public const string IsActive = "isactive";
			public const string IsManaged = "ismanaged";
			public const string IsPrivate = "isprivate";
			public const string IsReadOnly = "isreadonly";
			public const string IsValidForExecuteAsync = "isvalidforexecuteasync";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string SdkMessageId = "sdkmessageid";
			public const string Id = "sdkmessageid";
			public const string SdkMessageIdUnique = "sdkmessageidunique";
			public const string SolutionId = "solutionid";
			public const string Template = "template";
			public const string ThrottleSettings = "throttlesettings";
			public const string VersionNumber = "versionnumber";
			public const string WorkflowSdkStepEnabled = "workflowsdkstepenabled";
			public const string createdby_sdkmessage = "createdby_sdkmessage";
			public const string lk_sdkmessage_createdonbehalfby = "lk_sdkmessage_createdonbehalfby";
			public const string lk_sdkmessage_modifiedonbehalfby = "lk_sdkmessage_modifiedonbehalfby";
			public const string modifiedby_sdkmessage = "modifiedby_sdkmessage";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SdkMessage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessage";
		
		public const string EntitySchemaName = "SdkMessage";
		
		public const string PrimaryIdAttribute = "sdkmessageid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "sdkmessages";
		
		public const string EntitySetName = "sdkmessages";
		
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
		/// Information about whether the SDK message is automatically transacted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("autotransact")]
		public System.Nullable<bool> AutoTransact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("autotransact");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AutoTransact");
				this.SetAttributeValue("autotransact", value);
				this.OnPropertyChanged("AutoTransact");
			}
		}
		
		/// <summary>
		/// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("availability")]
		public System.Nullable<int> Availability
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("availability");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Availability");
				this.SetAttributeValue("availability", value);
				this.OnPropertyChanged("Availability");
			}
		}
		
		/// <summary>
		/// If this is a categorized method, this is the name, otherwise None.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("categoryname")]
		public string CategoryName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("categoryname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CategoryName");
				this.SetAttributeValue("categoryname", value);
				this.OnPropertyChanged("CategoryName");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual ComponentState? ComponentStateEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentState?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message.
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
		/// Date and time when the SDK message was created.
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
		/// Unique identifier of the delegate user who created the sdkmessage.
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
		/// Customization level of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Name of the privilege that allows execution of the SDK message
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executeprivilegename")]
		public string ExecutePrivilegeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("executeprivilegename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExecutePrivilegeName");
				this.SetAttributeValue("executeprivilegename", value);
				this.OnPropertyChanged("ExecutePrivilegeName");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expand")]
		public System.Nullable<bool> Expand
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("expand");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Expand");
				this.SetAttributeValue("expand", value);
				this.OnPropertyChanged("Expand");
			}
		}
		
		/// <summary>
		/// Version in which the component is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Information about whether the SDK message is active.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isactive")]
		public System.Nullable<bool> IsActive
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isactive");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsActive");
				this.SetAttributeValue("isactive", value);
				this.OnPropertyChanged("IsActive");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is private.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsPrivate");
				this.SetAttributeValue("isprivate", value);
				this.OnPropertyChanged("IsPrivate");
			}
		}
		
		/// <summary>
		/// Identifies whether an SDK message will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly .
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreadonly")]
		public System.Nullable<bool> IsReadOnly
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isreadonly");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsReadOnly");
				this.SetAttributeValue("isreadonly", value);
				this.OnPropertyChanged("IsReadOnly");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalidforexecuteasync")]
		public System.Nullable<bool> IsValidForExecuteAsync
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvalidforexecuteasync");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message.
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
		/// Date and time when the SDK message was last modified.
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
		/// Unique identifier of the delegate user who last modified the sdkmessage.
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
		/// Name of the SDK message.
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
		/// Unique identifier of the organization with which the SDK message is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public System.Nullable<System.Guid> SdkMessageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SdkMessageId");
				this.SetAttributeValue("sdkmessageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
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
				this.SdkMessageId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageidunique")]
		public System.Nullable<System.Guid> SdkMessageIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is a template.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("template")]
		public System.Nullable<bool> Template
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("template");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Template");
				this.SetAttributeValue("template", value);
				this.OnPropertyChanged("Template");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("throttlesettings")]
		public string ThrottleSettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("throttlesettings");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the SDK message. 
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
		/// Whether or not the SDK message can be called from a workflow.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowsdkstepenabled")]
		public System.Nullable<bool> WorkflowSdkStepEnabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("workflowsdkstepenabled");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<SharedLibraries_Plugins.EntityModel.SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<SharedLibraries_Plugins.EntityModel.SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
				this.SetRelatedEntities<SharedLibraries_Plugins.EntityModel.SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 createdby_sdkmessage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessage")]
		public SharedLibraries_Plugins.EntityModel.SystemUser createdby_sdkmessage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("createdby_sdkmessage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("createdby_sdkmessage");
				this.SetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("createdby_sdkmessage", null, value);
				this.OnPropertyChanged("createdby_sdkmessage");
			}
		}
		
		/// <summary>
		/// N:1 lk_sdkmessage_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_createdonbehalfby")]
		public SharedLibraries_Plugins.EntityModel.SystemUser lk_sdkmessage_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("lk_sdkmessage_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_sdkmessage_createdonbehalfby");
				this.SetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("lk_sdkmessage_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_sdkmessage_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_sdkmessage_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_modifiedonbehalfby")]
		public SharedLibraries_Plugins.EntityModel.SystemUser lk_sdkmessage_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("lk_sdkmessage_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_sdkmessage_modifiedonbehalfby");
				this.SetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("lk_sdkmessage_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_sdkmessage_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 modifiedby_sdkmessage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessage")]
		public SharedLibraries_Plugins.EntityModel.SystemUser modifiedby_sdkmessage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("modifiedby_sdkmessage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("modifiedby_sdkmessage");
				this.SetRelatedEntity<SharedLibraries_Plugins.EntityModel.SystemUser>("modifiedby_sdkmessage", null, value);
				this.OnPropertyChanged("modifiedby_sdkmessage");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SdkMessage(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["sdkmessageid"] = base.Id;
                        break;
                    case "sdkmessageid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
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