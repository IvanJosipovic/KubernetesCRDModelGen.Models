#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>SecurityGroup is the Schema for the SecurityGroups API. Manages a network security group that contains a list of network security rules. Network security groups enable inbound or outbound traffic to be enabled or denied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecurityGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SecurityGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityGroupList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "securitygroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SecurityGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SecurityGroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecDeletionPolicyEnum>))]
public enum V1beta1SecurityGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecForProviderResourceGroupNameSelector
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
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecForProviderSecurityRule
{
    /// <summary>Specifies whether network traffic is allowed or denied. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>A description for this rule. Restricted to 140 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>CIDR or destination IP range or * to match any IP. Tags such as VirtualNetwork, AzureLoadBalancer and Internet can also be used. This is required if destination_address_prefixes is not specified.</summary>
    [JsonPropertyName("destinationAddressPrefix")]
    public string? DestinationAddressPrefix { get; set; }

    /// <summary>List of destination address prefixes. Tags may not be used. This is required if destination_address_prefix is not specified.</summary>
    [JsonPropertyName("destinationAddressPrefixes")]
    public IList<string>? DestinationAddressPrefixes { get; set; }

    /// <summary>A List of destination Application Security Group IDs</summary>
    [JsonPropertyName("destinationApplicationSecurityGroupIds")]
    public IList<string>? DestinationApplicationSecurityGroupIds { get; set; }

    /// <summary>Destination Port or Range. Integer or range between 0 and 65535 or * to match any. This is required if destination_port_ranges is not specified.</summary>
    [JsonPropertyName("destinationPortRange")]
    public string? DestinationPortRange { get; set; }

    /// <summary>List of destination ports or port ranges. This is required if destination_port_range is not specified.</summary>
    [JsonPropertyName("destinationPortRanges")]
    public IList<string>? DestinationPortRanges { get; set; }

    /// <summary>The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are Inbound and Outbound.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The name of the security rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Network protocol this rule applies to. Possible values include Tcp, Udp, Icmp, Esp, Ah or * (which matches all).</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>CIDR or source IP range or * to match any IP. Tags such as VirtualNetwork, AzureLoadBalancer and Internet can also be used. This is required if source_address_prefixes is not specified.</summary>
    [JsonPropertyName("sourceAddressPrefix")]
    public string? SourceAddressPrefix { get; set; }

    /// <summary>List of source address prefixes. Tags may not be used. This is required if source_address_prefix is not specified.</summary>
    [JsonPropertyName("sourceAddressPrefixes")]
    public IList<string>? SourceAddressPrefixes { get; set; }

    /// <summary>A List of source Application Security Group IDs</summary>
    [JsonPropertyName("sourceApplicationSecurityGroupIds")]
    public IList<string>? SourceApplicationSecurityGroupIds { get; set; }

    /// <summary>Source Port or Range. Integer or range between 0 and 65535 or * to match any. This is required if source_port_ranges is not specified.</summary>
    [JsonPropertyName("sourcePortRange")]
    public string? SourcePortRange { get; set; }

    /// <summary>List of source ports or port ranges. This is required if source_port_range is not specified.</summary>
    [JsonPropertyName("sourcePortRanges")]
    public IList<string>? SourcePortRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecForProvider
{
    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the network security group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SecurityGroupSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>List of security_rule objects representing security rules, as defined below.</summary>
    [JsonPropertyName("securityRule")]
    public IList<V1beta1SecurityGroupSpecForProviderSecurityRule>? SecurityRule { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecInitProviderSecurityRule
{
    /// <summary>Specifies whether network traffic is allowed or denied. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>A description for this rule. Restricted to 140 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>CIDR or destination IP range or * to match any IP. Tags such as VirtualNetwork, AzureLoadBalancer and Internet can also be used. This is required if destination_address_prefixes is not specified.</summary>
    [JsonPropertyName("destinationAddressPrefix")]
    public string? DestinationAddressPrefix { get; set; }

    /// <summary>List of destination address prefixes. Tags may not be used. This is required if destination_address_prefix is not specified.</summary>
    [JsonPropertyName("destinationAddressPrefixes")]
    public IList<string>? DestinationAddressPrefixes { get; set; }

    /// <summary>A List of destination Application Security Group IDs</summary>
    [JsonPropertyName("destinationApplicationSecurityGroupIds")]
    public IList<string>? DestinationApplicationSecurityGroupIds { get; set; }

    /// <summary>Destination Port or Range. Integer or range between 0 and 65535 or * to match any. This is required if destination_port_ranges is not specified.</summary>
    [JsonPropertyName("destinationPortRange")]
    public string? DestinationPortRange { get; set; }

    /// <summary>List of destination ports or port ranges. This is required if destination_port_range is not specified.</summary>
    [JsonPropertyName("destinationPortRanges")]
    public IList<string>? DestinationPortRanges { get; set; }

    /// <summary>The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are Inbound and Outbound.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The name of the security rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Network protocol this rule applies to. Possible values include Tcp, Udp, Icmp, Esp, Ah or * (which matches all).</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>CIDR or source IP range or * to match any IP. Tags such as VirtualNetwork, AzureLoadBalancer and Internet can also be used. This is required if source_address_prefixes is not specified.</summary>
    [JsonPropertyName("sourceAddressPrefix")]
    public string? SourceAddressPrefix { get; set; }

    /// <summary>List of source address prefixes. Tags may not be used. This is required if source_address_prefix is not specified.</summary>
    [JsonPropertyName("sourceAddressPrefixes")]
    public IList<string>? SourceAddressPrefixes { get; set; }

    /// <summary>A List of source Application Security Group IDs</summary>
    [JsonPropertyName("sourceApplicationSecurityGroupIds")]
    public IList<string>? SourceApplicationSecurityGroupIds { get; set; }

    /// <summary>Source Port or Range. Integer or range between 0 and 65535 or * to match any. This is required if source_port_ranges is not specified.</summary>
    [JsonPropertyName("sourcePortRange")]
    public string? SourcePortRange { get; set; }

    /// <summary>List of source ports or port ranges. This is required if source_port_range is not specified.</summary>
    [JsonPropertyName("sourcePortRanges")]
    public IList<string>? SourcePortRanges { get; set; }
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
public partial class V1beta1SecurityGroupSpecInitProvider
{
    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>List of security_rule objects representing security rules, as defined below.</summary>
    [JsonPropertyName("securityRule")]
    public IList<V1beta1SecurityGroupSpecInitProviderSecurityRule>? SecurityRule { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecManagementPoliciesEnum>))]
public enum V1beta1SecurityGroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1SecurityGroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SecurityGroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1SecurityGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SecurityGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SecurityGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SecurityGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecurityGroupSpec defines the desired state of SecurityGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupSpec
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
    public V1beta1SecurityGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1SecurityGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1SecurityGroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1SecurityGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SecurityGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SecurityGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupStatusAtProviderSecurityRule
{
    /// <summary>Specifies whether network traffic is allowed or denied. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("access")]
    public string? Access { get; set; }

    /// <summary>A description for this rule. Restricted to 140 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>CIDR or destination IP range or * to match any IP. Tags such as VirtualNetwork, AzureLoadBalancer and Internet can also be used. This is required if destination_address_prefixes is not specified.</summary>
    [JsonPropertyName("destinationAddressPrefix")]
    public string? DestinationAddressPrefix { get; set; }

    /// <summary>List of destination address prefixes. Tags may not be used. This is required if destination_address_prefix is not specified.</summary>
    [JsonPropertyName("destinationAddressPrefixes")]
    public IList<string>? DestinationAddressPrefixes { get; set; }

    /// <summary>A List of destination Application Security Group IDs</summary>
    [JsonPropertyName("destinationApplicationSecurityGroupIds")]
    public IList<string>? DestinationApplicationSecurityGroupIds { get; set; }

    /// <summary>Destination Port or Range. Integer or range between 0 and 65535 or * to match any. This is required if destination_port_ranges is not specified.</summary>
    [JsonPropertyName("destinationPortRange")]
    public string? DestinationPortRange { get; set; }

    /// <summary>List of destination ports or port ranges. This is required if destination_port_range is not specified.</summary>
    [JsonPropertyName("destinationPortRanges")]
    public IList<string>? DestinationPortRanges { get; set; }

    /// <summary>The direction specifies if rule will be evaluated on incoming or outgoing traffic. Possible values are Inbound and Outbound.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The name of the security rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Network protocol this rule applies to. Possible values include Tcp, Udp, Icmp, Esp, Ah or * (which matches all).</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>CIDR or source IP range or * to match any IP. Tags such as VirtualNetwork, AzureLoadBalancer and Internet can also be used. This is required if source_address_prefixes is not specified.</summary>
    [JsonPropertyName("sourceAddressPrefix")]
    public string? SourceAddressPrefix { get; set; }

    /// <summary>List of source address prefixes. Tags may not be used. This is required if source_address_prefix is not specified.</summary>
    [JsonPropertyName("sourceAddressPrefixes")]
    public IList<string>? SourceAddressPrefixes { get; set; }

    /// <summary>A List of source Application Security Group IDs</summary>
    [JsonPropertyName("sourceApplicationSecurityGroupIds")]
    public IList<string>? SourceApplicationSecurityGroupIds { get; set; }

    /// <summary>Source Port or Range. Integer or range between 0 and 65535 or * to match any. This is required if source_port_ranges is not specified.</summary>
    [JsonPropertyName("sourcePortRange")]
    public string? SourcePortRange { get; set; }

    /// <summary>List of source ports or port ranges. This is required if source_port_range is not specified.</summary>
    [JsonPropertyName("sourcePortRanges")]
    public IList<string>? SourcePortRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupStatusAtProvider
{
    /// <summary>The ID of the Network Security Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group in which to create the network security group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>List of security_rule objects representing security rules, as defined below.</summary>
    [JsonPropertyName("securityRule")]
    public IList<V1beta1SecurityGroupStatusAtProviderSecurityRule>? SecurityRule { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupStatusConditions
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

/// <summary>SecurityGroupStatus defines the observed state of SecurityGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecurityGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1SecurityGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecurityGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecurityGroup is the Schema for the SecurityGroups API. Manages a network security group that contains a list of network security rules. Network security groups enable inbound or outbound traffic to be enabled or denied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecurityGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecurityGroupSpec>, IStatus<V1beta1SecurityGroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecurityGroup";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "securitygroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecurityGroupSpec defines the desired state of SecurityGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1SecurityGroupSpec Spec { get; set; }

    /// <summary>SecurityGroupStatus defines the observed state of SecurityGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1SecurityGroupStatus? Status { get; set; }
}