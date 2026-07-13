#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary>MonitorActionGroup is the Schema for the MonitorActionGroups API. Manages an Action Group within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorActionGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2MonitorActionGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorActionGroupList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitoractiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorActionGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2MonitorActionGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2MonitorActionGroup> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecDeletionPolicyEnum>))]
public enum V1beta2MonitorActionGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderArmRoleReceiver
{
    /// <summary>The name of the ARM role receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderAutomationRunbookReceiver
{
    /// <summary>The automation account ID which holds this runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary>The name of the automation runbook receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderAzureAppPushReceiver
{
    /// <summary>The email address of the user signed into the mobile app who will receive push notifications from this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the Azure app push receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderAzureFunctionReceiver
{
    /// <summary>The Azure resource ID of the function app.</summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary>The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>The HTTP trigger url where HTTP request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary>The name of the Azure Function receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderEmailReceiver
{
    /// <summary>The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the email receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderEventHubReceiver
{
    /// <summary>The name of the specific Event Hub queue.</summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary>The namespace name of the Event Hub.</summary>
    [JsonPropertyName("eventHubNamespace")]
    public string? EventHubNamespace { get; set; }

    /// <summary>The name of the EventHub Receiver, must be unique within action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID for the subscription containing this Event Hub. Default to the subscription ID of the Action Group.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Tenant ID for the subscription containing this Event Hub.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderItsmReceiver
{
    /// <summary>The unique connection identifier of the ITSM connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The name of the ITSM receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region of the workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well.</summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary>The Azure Log Analytics workspace ID where this connection is defined. Format is &lt;subscription id&gt;|&lt;workspace id&gt;, for example 00000000-0000-0000-0000-000000000000|00000000-0000-0000-0000-000000000000.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderLogicAppReceiver
{
    /// <summary>The callback url where HTTP request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>The name of the logic app receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Azure resource ID of the logic app.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderSmsReceiver
{
    /// <summary>The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the SMS receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderVoiceReceiver
{
    /// <summary>The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the voice receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>The aad_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderWebhookReceiverAadAuth
{
    /// <summary>The identifier URI for AAD auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>The webhook application object Id for AAD auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id for AAD auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProviderWebhookReceiver
{
    /// <summary>The aad_auth block as defined below.</summary>
    [JsonPropertyName("aadAuth")]
    public V1beta2MonitorActionGroupSpecForProviderWebhookReceiverAadAuth? AadAuth { get; set; }

    /// <summary>The name of the webhook receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecForProvider
{
    /// <summary>One or more arm_role_receiver blocks as defined below.</summary>
    [JsonPropertyName("armRoleReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderArmRoleReceiver>? ArmRoleReceiver { get; set; }

    /// <summary>One or more automation_runbook_receiver blocks as defined below.</summary>
    [JsonPropertyName("automationRunbookReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderAutomationRunbookReceiver>? AutomationRunbookReceiver { get; set; }

    /// <summary>One or more azure_app_push_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureAppPushReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderAzureAppPushReceiver>? AzureAppPushReceiver { get; set; }

    /// <summary>One or more azure_function_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureFunctionReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderAzureFunctionReceiver>? AzureFunctionReceiver { get; set; }

    /// <summary>One or more email_receiver blocks as defined below.</summary>
    [JsonPropertyName("emailReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderEmailReceiver>? EmailReceiver { get; set; }

    /// <summary>Whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more event_hub_receiver blocks as defined below.</summary>
    [JsonPropertyName("eventHubReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderEventHubReceiver>? EventHubReceiver { get; set; }

    /// <summary>One or more itsm_receiver blocks as defined below.</summary>
    [JsonPropertyName("itsmReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderItsmReceiver>? ItsmReceiver { get; set; }

    /// <summary>The Azure Region where the Action Group should exist. Changing this forces a new Action Group to be created. Defaults to global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more logic_app_receiver blocks as defined below.</summary>
    [JsonPropertyName("logicAppReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderLogicAppReceiver>? LogicAppReceiver { get; set; }

    /// <summary>The name of the resource group in which to create the Action Group instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2MonitorActionGroupSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>One or more sms_receiver blocks as defined below.</summary>
    [JsonPropertyName("smsReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderSmsReceiver>? SmsReceiver { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more voice_receiver blocks as defined below.</summary>
    [JsonPropertyName("voiceReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderVoiceReceiver>? VoiceReceiver { get; set; }

    /// <summary>One or more webhook_receiver blocks as defined below.</summary>
    [JsonPropertyName("webhookReceiver")]
    public IList<V1beta2MonitorActionGroupSpecForProviderWebhookReceiver>? WebhookReceiver { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderArmRoleReceiver
{
    /// <summary>The name of the ARM role receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderAutomationRunbookReceiver
{
    /// <summary>The automation account ID which holds this runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary>The name of the automation runbook receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderAzureAppPushReceiver
{
    /// <summary>The email address of the user signed into the mobile app who will receive push notifications from this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the Azure app push receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderAzureFunctionReceiver
{
    /// <summary>The Azure resource ID of the function app.</summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary>The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>The HTTP trigger url where HTTP request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary>The name of the Azure Function receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderEmailReceiver
{
    /// <summary>The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the email receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderEventHubReceiver
{
    /// <summary>The name of the specific Event Hub queue.</summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary>The namespace name of the Event Hub.</summary>
    [JsonPropertyName("eventHubNamespace")]
    public string? EventHubNamespace { get; set; }

    /// <summary>The name of the EventHub Receiver, must be unique within action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID for the subscription containing this Event Hub. Default to the subscription ID of the Action Group.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Tenant ID for the subscription containing this Event Hub.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderItsmReceiver
{
    /// <summary>The unique connection identifier of the ITSM connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The name of the ITSM receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region of the workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well.</summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary>The Azure Log Analytics workspace ID where this connection is defined. Format is &lt;subscription id&gt;|&lt;workspace id&gt;, for example 00000000-0000-0000-0000-000000000000|00000000-0000-0000-0000-000000000000.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderLogicAppReceiver
{
    /// <summary>The callback url where HTTP request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>The name of the logic app receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Azure resource ID of the logic app.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderSmsReceiver
{
    /// <summary>The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the SMS receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderVoiceReceiver
{
    /// <summary>The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the voice receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>The aad_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderWebhookReceiverAadAuth
{
    /// <summary>The identifier URI for AAD auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>The webhook application object Id for AAD auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id for AAD auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProviderWebhookReceiver
{
    /// <summary>The aad_auth block as defined below.</summary>
    [JsonPropertyName("aadAuth")]
    public V1beta2MonitorActionGroupSpecInitProviderWebhookReceiverAadAuth? AadAuth { get; set; }

    /// <summary>The name of the webhook receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecInitProvider
{
    /// <summary>One or more arm_role_receiver blocks as defined below.</summary>
    [JsonPropertyName("armRoleReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderArmRoleReceiver>? ArmRoleReceiver { get; set; }

    /// <summary>One or more automation_runbook_receiver blocks as defined below.</summary>
    [JsonPropertyName("automationRunbookReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderAutomationRunbookReceiver>? AutomationRunbookReceiver { get; set; }

    /// <summary>One or more azure_app_push_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureAppPushReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderAzureAppPushReceiver>? AzureAppPushReceiver { get; set; }

    /// <summary>One or more azure_function_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureFunctionReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderAzureFunctionReceiver>? AzureFunctionReceiver { get; set; }

    /// <summary>One or more email_receiver blocks as defined below.</summary>
    [JsonPropertyName("emailReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderEmailReceiver>? EmailReceiver { get; set; }

    /// <summary>Whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more event_hub_receiver blocks as defined below.</summary>
    [JsonPropertyName("eventHubReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderEventHubReceiver>? EventHubReceiver { get; set; }

    /// <summary>One or more itsm_receiver blocks as defined below.</summary>
    [JsonPropertyName("itsmReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderItsmReceiver>? ItsmReceiver { get; set; }

    /// <summary>The Azure Region where the Action Group should exist. Changing this forces a new Action Group to be created. Defaults to global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more logic_app_receiver blocks as defined below.</summary>
    [JsonPropertyName("logicAppReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderLogicAppReceiver>? LogicAppReceiver { get; set; }

    /// <summary>The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>One or more sms_receiver blocks as defined below.</summary>
    [JsonPropertyName("smsReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderSmsReceiver>? SmsReceiver { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more voice_receiver blocks as defined below.</summary>
    [JsonPropertyName("voiceReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderVoiceReceiver>? VoiceReceiver { get; set; }

    /// <summary>One or more webhook_receiver blocks as defined below.</summary>
    [JsonPropertyName("webhookReceiver")]
    public IList<V1beta2MonitorActionGroupSpecInitProviderWebhookReceiver>? WebhookReceiver { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecManagementPoliciesEnum>))]
public enum V1beta2MonitorActionGroupSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2MonitorActionGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2MonitorActionGroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2MonitorActionGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2MonitorActionGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2MonitorActionGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2MonitorActionGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>MonitorActionGroupSpec defines the desired state of MonitorActionGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2MonitorActionGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2MonitorActionGroupSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2MonitorActionGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2MonitorActionGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2MonitorActionGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2MonitorActionGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderArmRoleReceiver
{
    /// <summary>The name of the ARM role receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The arm role id.</summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderAutomationRunbookReceiver
{
    /// <summary>The automation account ID which holds this runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Indicates whether this instance is global runbook.</summary>
    [JsonPropertyName("isGlobalRunbook")]
    public bool? IsGlobalRunbook { get; set; }

    /// <summary>The name of the automation runbook receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name for this runbook.</summary>
    [JsonPropertyName("runbookName")]
    public string? RunbookName { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }

    /// <summary>The resource id for webhook linked to this runbook.</summary>
    [JsonPropertyName("webhookResourceId")]
    public string? WebhookResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderAzureAppPushReceiver
{
    /// <summary>The email address of the user signed into the mobile app who will receive push notifications from this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the Azure app push receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderAzureFunctionReceiver
{
    /// <summary>The Azure resource ID of the function app.</summary>
    [JsonPropertyName("functionAppResourceId")]
    public string? FunctionAppResourceId { get; set; }

    /// <summary>The function name in the function app.</summary>
    [JsonPropertyName("functionName")]
    public string? FunctionName { get; set; }

    /// <summary>The HTTP trigger url where HTTP request sent to.</summary>
    [JsonPropertyName("httpTriggerUrl")]
    public string? HttpTriggerUrl { get; set; }

    /// <summary>The name of the Azure Function receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderEmailReceiver
{
    /// <summary>The email address of this receiver.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>The name of the email receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderEventHubReceiver
{
    /// <summary>The name of the specific Event Hub queue.</summary>
    [JsonPropertyName("eventHubName")]
    public string? EventHubName { get; set; }

    /// <summary>The namespace name of the Event Hub.</summary>
    [JsonPropertyName("eventHubNamespace")]
    public string? EventHubNamespace { get; set; }

    /// <summary>The name of the EventHub Receiver, must be unique within action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID for the subscription containing this Event Hub. Default to the subscription ID of the Action Group.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The Tenant ID for the subscription containing this Event Hub.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Indicates whether to use common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderItsmReceiver
{
    /// <summary>The unique connection identifier of the ITSM connection.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The name of the ITSM receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The region of the workspace.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well.</summary>
    [JsonPropertyName("ticketConfiguration")]
    public string? TicketConfiguration { get; set; }

    /// <summary>The Azure Log Analytics workspace ID where this connection is defined. Format is &lt;subscription id&gt;|&lt;workspace id&gt;, for example 00000000-0000-0000-0000-000000000000|00000000-0000-0000-0000-000000000000.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderLogicAppReceiver
{
    /// <summary>The callback url where HTTP request sent to.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>The name of the logic app receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Azure resource ID of the logic app.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderSmsReceiver
{
    /// <summary>The country code of the SMS receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the SMS receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the SMS receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderVoiceReceiver
{
    /// <summary>The country code of the voice receiver.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The name of the voice receiver.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The phone number of the voice receiver.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>The aad_auth block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderWebhookReceiverAadAuth
{
    /// <summary>The identifier URI for AAD auth.</summary>
    [JsonPropertyName("identifierUri")]
    public string? IdentifierUri { get; set; }

    /// <summary>The webhook application object Id for AAD auth.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id for AAD auth.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProviderWebhookReceiver
{
    /// <summary>The aad_auth block as defined below.</summary>
    [JsonPropertyName("aadAuth")]
    public V1beta2MonitorActionGroupStatusAtProviderWebhookReceiverAadAuth? AadAuth { get; set; }

    /// <summary>The name of the webhook receiver. Names must be unique (case-insensitive) across all receivers within an action group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The URI where webhooks should be sent.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }

    /// <summary>Enables or disables the common alert schema.</summary>
    [JsonPropertyName("useCommonAlertSchema")]
    public bool? UseCommonAlertSchema { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusAtProvider
{
    /// <summary>One or more arm_role_receiver blocks as defined below.</summary>
    [JsonPropertyName("armRoleReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderArmRoleReceiver>? ArmRoleReceiver { get; set; }

    /// <summary>One or more automation_runbook_receiver blocks as defined below.</summary>
    [JsonPropertyName("automationRunbookReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderAutomationRunbookReceiver>? AutomationRunbookReceiver { get; set; }

    /// <summary>One or more azure_app_push_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureAppPushReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderAzureAppPushReceiver>? AzureAppPushReceiver { get; set; }

    /// <summary>One or more azure_function_receiver blocks as defined below.</summary>
    [JsonPropertyName("azureFunctionReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderAzureFunctionReceiver>? AzureFunctionReceiver { get; set; }

    /// <summary>One or more email_receiver blocks as defined below.</summary>
    [JsonPropertyName("emailReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderEmailReceiver>? EmailReceiver { get; set; }

    /// <summary>Whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more event_hub_receiver blocks as defined below.</summary>
    [JsonPropertyName("eventHubReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderEventHubReceiver>? EventHubReceiver { get; set; }

    /// <summary>The ID of the Action Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more itsm_receiver blocks as defined below.</summary>
    [JsonPropertyName("itsmReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderItsmReceiver>? ItsmReceiver { get; set; }

    /// <summary>The Azure Region where the Action Group should exist. Changing this forces a new Action Group to be created. Defaults to global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more logic_app_receiver blocks as defined below.</summary>
    [JsonPropertyName("logicAppReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderLogicAppReceiver>? LogicAppReceiver { get; set; }

    /// <summary>The name of the resource group in which to create the Action Group instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The short name of the action group. This will be used in SMS messages.</summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>One or more sms_receiver blocks as defined below.</summary>
    [JsonPropertyName("smsReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderSmsReceiver>? SmsReceiver { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more voice_receiver blocks as defined below.</summary>
    [JsonPropertyName("voiceReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderVoiceReceiver>? VoiceReceiver { get; set; }

    /// <summary>One or more webhook_receiver blocks as defined below.</summary>
    [JsonPropertyName("webhookReceiver")]
    public IList<V1beta2MonitorActionGroupStatusAtProviderWebhookReceiver>? WebhookReceiver { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>MonitorActionGroupStatus defines the observed state of MonitorActionGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2MonitorActionGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2MonitorActionGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2MonitorActionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorActionGroup is the Schema for the MonitorActionGroups API. Manages an Action Group within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2MonitorActionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2MonitorActionGroupSpec>, IStatus<V1beta2MonitorActionGroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "MonitorActionGroup";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitoractiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitorActionGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorActionGroupSpec defines the desired state of MonitorActionGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta2MonitorActionGroupSpec Spec { get; set; }

    /// <summary>MonitorActionGroupStatus defines the observed state of MonitorActionGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta2MonitorActionGroupStatus? Status { get; set; }
}