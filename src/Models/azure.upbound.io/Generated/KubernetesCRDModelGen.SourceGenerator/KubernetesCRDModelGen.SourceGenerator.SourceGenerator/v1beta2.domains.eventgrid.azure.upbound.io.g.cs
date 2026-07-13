#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.upbound.io;
/// <summary>Domain is the Schema for the Domains API. Manages an EventGrid Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Domain>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Domain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Domain> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecDeletionPolicyEnum>))]
public enum V1beta2DomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Domain.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Domain. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderResourceGroupNameSelector
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
    public V1beta2DomainSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProvider
{
    /// <summary>Whether to create the domain topic when the first event subscription at the scope of the domain topic is created. Defaults to true.</summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>Whether to delete the domain topic when the last event subscription at the scope of the domain topic is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2DomainSpecForProviderIdentity? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta2DomainSpecForProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public V1beta2DomainSpecForProviderInputMappingDefaultValues? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public V1beta2DomainSpecForProviderInputMappingFields? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Domain. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2DomainSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2DomainSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Domain.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Domain. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProvider
{
    /// <summary>Whether to create the domain topic when the first event subscription at the scope of the domain topic is created. Defaults to true.</summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>Whether to delete the domain topic when the last event subscription at the scope of the domain topic is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2DomainSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta2DomainSpecInitProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public V1beta2DomainSpecInitProviderInputMappingDefaultValues? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public V1beta2DomainSpecInitProviderInputMappingFields? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Domain. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecManagementPoliciesEnum>))]
public enum V1beta2DomainSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpec
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
    public V1beta2DomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DomainSpecForProvider ForProvider { get; set; }

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
    public V1beta2DomainSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Domain.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Domain. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProvider
{
    /// <summary>Whether to create the domain topic when the first event subscription at the scope of the domain topic is created. Defaults to true.</summary>
    [JsonPropertyName("autoCreateTopicWithFirstSubscription")]
    public bool? AutoCreateTopicWithFirstSubscription { get; set; }

    /// <summary>Whether to delete the domain topic when the last event subscription at the scope of the domain topic is deleted. Defaults to true.</summary>
    [JsonPropertyName("autoDeleteTopicWithLastSubscription")]
    public bool? AutoDeleteTopicWithLastSubscription { get; set; }

    /// <summary>The Endpoint associated with the EventGrid Domain.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The ID of the EventGrid Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2DomainStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta2DomainStatusAtProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public V1beta2DomainStatusAtProviderInputMappingDefaultValues? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public V1beta2DomainStatusAtProviderInputMappingFields? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Domain. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusConditions
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

/// <summary>DomainStatus defines the observed state of Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DomainStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Domain is the Schema for the Domains API. Manages an EventGrid Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DomainSpec>, IStatus<V1beta2DomainStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DomainSpec Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain.</summary>
    [JsonPropertyName("status")]
    public V1beta2DomainStatus? Status { get; set; }
}