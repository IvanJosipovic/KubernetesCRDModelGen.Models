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
/// <summary>ExpressRouteCircuitPeering is the Schema for the ExpressRouteCircuitPeerings API. Manages an ExpressRoute Circuit Peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ExpressRouteCircuitPeeringList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ExpressRouteCircuitPeering>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ExpressRouteCircuitPeeringList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressroutecircuitpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExpressRouteCircuitPeeringList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ExpressRouteCircuitPeering objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ExpressRouteCircuitPeering> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecDeletionPolicyEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicyResolutionEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicyResolveEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicyResolveEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelector
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
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A microsoft_peering block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderIpv6MicrosoftPeering
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary>A ipv6 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderIpv6
{
    /// <summary>A boolean value indicating whether the IPv6 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A microsoft_peering block as defined below.</summary>
    [JsonPropertyName("microsoftPeering")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderIpv6MicrosoftPeering? MicrosoftPeering { get; set; }

    /// <summary>A subnet for the primary link.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A subnet for the secondary link.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }
}

/// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderMicrosoftPeeringConfig
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelector
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
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The shared key. Can be a maximum of 25 characters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProviderSharedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecForProvider
{
    /// <summary>The name of the ExpressRoute Circuit in which to create the Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitName")]
    public string? ExpressRouteCircuitName { get; set; }

    /// <summary>Reference to a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
    [JsonPropertyName("expressRouteCircuitNameRef")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRef? ExpressRouteCircuitNameRef { get; set; }

    /// <summary>Selector for a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
    [JsonPropertyName("expressRouteCircuitNameSelector")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelector? ExpressRouteCircuitNameSelector { get; set; }

    /// <summary>A boolean value indicating whether the IPv4 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>A ipv6 block as defined below.</summary>
    [JsonPropertyName("ipv6")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderIpv6? Ipv6 { get; set; }

    /// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
    [JsonPropertyName("microsoftPeeringConfig")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderMicrosoftPeeringConfig? MicrosoftPeeringConfig { get; set; }

    /// <summary>The Either a 16-bit or a 32-bit ASN. Can either be public or private.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>A /30 subnet for the primary link. Required when config for IPv4.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The name of the resource group in which to create the Express Route Circuit Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A /30 subnet for the secondary link. Required when config for IPv4.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>The shared key. Can be a maximum of 25 characters.</summary>
    [JsonPropertyName("sharedKeySecretRef")]
    public V1beta2ExpressRouteCircuitPeeringSpecForProviderSharedKeySecretRef? SharedKeySecretRef { get; set; }

    /// <summary>A valid VLAN ID to establish this peering on.</summary>
    [JsonPropertyName("vlanId")]
    public double? VlanId { get; set; }
}

/// <summary>A microsoft_peering block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecInitProviderIpv6MicrosoftPeering
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary>A ipv6 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecInitProviderIpv6
{
    /// <summary>A boolean value indicating whether the IPv6 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A microsoft_peering block as defined below.</summary>
    [JsonPropertyName("microsoftPeering")]
    public V1beta2ExpressRouteCircuitPeeringSpecInitProviderIpv6MicrosoftPeering? MicrosoftPeering { get; set; }

    /// <summary>A subnet for the primary link.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A subnet for the secondary link.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }
}

/// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecInitProviderMicrosoftPeeringConfig
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary>The shared key. Can be a maximum of 25 characters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecInitProviderSharedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
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
public partial class V1beta2ExpressRouteCircuitPeeringSpecInitProvider
{
    /// <summary>A boolean value indicating whether the IPv4 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>A ipv6 block as defined below.</summary>
    [JsonPropertyName("ipv6")]
    public V1beta2ExpressRouteCircuitPeeringSpecInitProviderIpv6? Ipv6 { get; set; }

    /// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
    [JsonPropertyName("microsoftPeeringConfig")]
    public V1beta2ExpressRouteCircuitPeeringSpecInitProviderMicrosoftPeeringConfig? MicrosoftPeeringConfig { get; set; }

    /// <summary>The Either a 16-bit or a 32-bit ASN. Can either be public or private.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>A /30 subnet for the primary link. Required when config for IPv4.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A /30 subnet for the secondary link. Required when config for IPv4.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>The shared key. Can be a maximum of 25 characters.</summary>
    [JsonPropertyName("sharedKeySecretRef")]
    public V1beta2ExpressRouteCircuitPeeringSpecInitProviderSharedKeySecretRef? SharedKeySecretRef { get; set; }

    /// <summary>A valid VLAN ID to establish this peering on.</summary>
    [JsonPropertyName("vlanId")]
    public double? VlanId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecManagementPoliciesEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ExpressRouteCircuitPeeringSpec defines the desired state of ExpressRouteCircuitPeering</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringSpec
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
    public V1beta2ExpressRouteCircuitPeeringSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ExpressRouteCircuitPeeringSpecForProvider ForProvider { get; set; }

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
    public V1beta2ExpressRouteCircuitPeeringSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ExpressRouteCircuitPeeringSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ExpressRouteCircuitPeeringSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ExpressRouteCircuitPeeringSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A microsoft_peering block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringStatusAtProviderIpv6MicrosoftPeering
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary>A ipv6 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringStatusAtProviderIpv6
{
    /// <summary>A boolean value indicating whether the IPv6 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A microsoft_peering block as defined below.</summary>
    [JsonPropertyName("microsoftPeering")]
    public V1beta2ExpressRouteCircuitPeeringStatusAtProviderIpv6MicrosoftPeering? MicrosoftPeering { get; set; }

    /// <summary>A subnet for the primary link.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A subnet for the secondary link.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }
}

/// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringStatusAtProviderMicrosoftPeeringConfig
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringStatusAtProvider
{
    /// <summary>The ASN used by Azure.</summary>
    [JsonPropertyName("azureAsn")]
    public double? AzureAsn { get; set; }

    /// <summary>The name of the ExpressRoute Circuit in which to create the Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitName")]
    public string? ExpressRouteCircuitName { get; set; }

    [JsonPropertyName("gatewayManagerEtag")]
    public string? GatewayManagerEtag { get; set; }

    /// <summary>The ID of the ExpressRoute Circuit Peering.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A boolean value indicating whether the IPv4 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>A ipv6 block as defined below.</summary>
    [JsonPropertyName("ipv6")]
    public V1beta2ExpressRouteCircuitPeeringStatusAtProviderIpv6? Ipv6 { get; set; }

    /// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
    [JsonPropertyName("microsoftPeeringConfig")]
    public V1beta2ExpressRouteCircuitPeeringStatusAtProviderMicrosoftPeeringConfig? MicrosoftPeeringConfig { get; set; }

    /// <summary>The Either a 16-bit or a 32-bit ASN. Can either be public or private.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>The Primary Port used by Azure for this Peering.</summary>
    [JsonPropertyName("primaryAzurePort")]
    public string? PrimaryAzurePort { get; set; }

    /// <summary>A /30 subnet for the primary link. Required when config for IPv4.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The name of the resource group in which to create the Express Route Circuit Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>The Secondary Port used by Azure for this Peering.</summary>
    [JsonPropertyName("secondaryAzurePort")]
    public string? SecondaryAzurePort { get; set; }

    /// <summary>A /30 subnet for the secondary link. Required when config for IPv4.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>A valid VLAN ID to establish this peering on.</summary>
    [JsonPropertyName("vlanId")]
    public double? VlanId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringStatusConditions
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

/// <summary>ExpressRouteCircuitPeeringStatus defines the observed state of ExpressRouteCircuitPeering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ExpressRouteCircuitPeeringStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ExpressRouteCircuitPeeringStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ExpressRouteCircuitPeeringStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ExpressRouteCircuitPeering is the Schema for the ExpressRouteCircuitPeerings API. Manages an ExpressRoute Circuit Peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ExpressRouteCircuitPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ExpressRouteCircuitPeeringSpec>, IStatus<V1beta2ExpressRouteCircuitPeeringStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ExpressRouteCircuitPeering";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressroutecircuitpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExpressRouteCircuitPeering";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExpressRouteCircuitPeeringSpec defines the desired state of ExpressRouteCircuitPeering</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ExpressRouteCircuitPeeringSpec Spec { get; set; }

    /// <summary>ExpressRouteCircuitPeeringStatus defines the observed state of ExpressRouteCircuitPeering.</summary>
    [JsonPropertyName("status")]
    public V1beta2ExpressRouteCircuitPeeringStatus? Status { get; set; }
}