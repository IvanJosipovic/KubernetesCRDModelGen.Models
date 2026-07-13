#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>PacketMirroring is the Schema for the PacketMirrorings API. Packet Mirroring mirrors traffic to and from particular VM instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PacketMirroringList : IKubernetesObject<V1ListMeta>, IItems<V1beta2PacketMirroring>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PacketMirroringList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "packetmirrorings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PacketMirroringList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2PacketMirroring objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2PacketMirroring> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecDeletionPolicyEnum>))]
public enum V1beta2PacketMirroringSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelector
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
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
/// that will be used as collector for mirrored traffic. The
/// specified forwarding rule must have is_mirroring_collector
/// set to true.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderCollectorIlb
{
    /// <summary>The URL of the forwarding rule.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlbUrlSelector? UrlSelector { get; set; }
}

/// <summary>
/// A filter for mirrored traffic.  If unset, all traffic is mirrored.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderFilter
{
    /// <summary>
    /// IP CIDR ranges that apply as a filter on the source (ingress) or
    /// destination (egress) IP in the IP header. Only IPv4 is supported.
    /// </summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>
    /// Direction of traffic to mirror.
    /// Default value is BOTH.
    /// Possible values are: INGRESS, EGRESS, BOTH.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Possible IP protocols including tcp, udp, icmp and esp</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelector
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
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderMirroredResourcesInstances
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta2PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelector? UrlSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderMirroredResourcesSubnetworks
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A means of specifying which resources to mirror.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderMirroredResources
{
    /// <summary>
    /// All the listed instances will be mirrored.  Specify at most 50.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instances")]
    public IList<V1beta2PacketMirroringSpecForProviderMirroredResourcesInstances>? Instances { get; set; }

    /// <summary>
    /// All instances in one of these subnetworks will be mirrored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subnetworks")]
    public IList<V1beta2PacketMirroringSpecForProviderMirroredResourcesSubnetworks>? Subnetworks { get; set; }

    /// <summary>All instances with these tags will be mirrored.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PacketMirroringSpecForProviderNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderNetworkUrlSelector
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
    public V1beta2PacketMirroringSpecForProviderNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the mirrored VPC network. Only packets in this network
/// will be mirrored. All mirrored VMs should have a NIC in the given
/// network. All mirrored subnetworks should belong to the given network.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProviderNetwork
{
    /// <summary>The full self_link URL of the network where this rule is active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Network in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta2PacketMirroringSpecForProviderNetworkUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta2PacketMirroringSpecForProviderNetworkUrlSelector? UrlSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecForProvider
{
    /// <summary>
    /// The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
    /// that will be used as collector for mirrored traffic. The
    /// specified forwarding rule must have is_mirroring_collector
    /// set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collectorIlb")]
    public V1beta2PacketMirroringSpecForProviderCollectorIlb? CollectorIlb { get; set; }

    /// <summary>A human-readable description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A filter for mirrored traffic.  If unset, all traffic is mirrored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1beta2PacketMirroringSpecForProviderFilter? Filter { get; set; }

    /// <summary>
    /// A means of specifying which resources to mirror.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mirroredResources")]
    public V1beta2PacketMirroringSpecForProviderMirroredResources? MirroredResources { get; set; }

    /// <summary>
    /// Specifies the mirrored VPC network. Only packets in this network
    /// will be mirrored. All mirrored VMs should have a NIC in the given
    /// network. All mirrored subnetworks should belong to the given network.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("network")]
    public V1beta2PacketMirroringSpecForProviderNetwork? Network { get; set; }

    /// <summary>
    /// Since only one rule can be active at a time, priority is
    /// used to break ties in the case of two rules that apply to
    /// the same instances.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelector
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
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
/// that will be used as collector for mirrored traffic. The
/// specified forwarding rule must have is_mirroring_collector
/// set to true.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderCollectorIlb
{
    /// <summary>The URL of the forwarding rule.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlbUrlSelector? UrlSelector { get; set; }
}

/// <summary>
/// A filter for mirrored traffic.  If unset, all traffic is mirrored.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderFilter
{
    /// <summary>
    /// IP CIDR ranges that apply as a filter on the source (ingress) or
    /// destination (egress) IP in the IP header. Only IPv4 is supported.
    /// </summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>
    /// Direction of traffic to mirror.
    /// Default value is BOTH.
    /// Possible values are: INGRESS, EGRESS, BOTH.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Possible IP protocols including tcp, udp, icmp and esp</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelector
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
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstances
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelector? UrlSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderMirroredResourcesSubnetworks
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A means of specifying which resources to mirror.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderMirroredResources
{
    /// <summary>
    /// All the listed instances will be mirrored.  Specify at most 50.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instances")]
    public IList<V1beta2PacketMirroringSpecInitProviderMirroredResourcesInstances>? Instances { get; set; }

    /// <summary>
    /// All instances in one of these subnetworks will be mirrored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subnetworks")]
    public IList<V1beta2PacketMirroringSpecInitProviderMirroredResourcesSubnetworks>? Subnetworks { get; set; }

    /// <summary>All instances with these tags will be mirrored.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate url.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderNetworkUrlSelector
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
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the mirrored VPC network. Only packets in this network
/// will be mirrored. All mirrored VMs should have a NIC in the given
/// network. All mirrored subnetworks should belong to the given network.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecInitProviderNetwork
{
    /// <summary>The full self_link URL of the network where this rule is active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Network in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta2PacketMirroringSpecInitProviderNetworkUrlSelector? UrlSelector { get; set; }
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
public partial class V1beta2PacketMirroringSpecInitProvider
{
    /// <summary>
    /// The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
    /// that will be used as collector for mirrored traffic. The
    /// specified forwarding rule must have is_mirroring_collector
    /// set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collectorIlb")]
    public V1beta2PacketMirroringSpecInitProviderCollectorIlb? CollectorIlb { get; set; }

    /// <summary>A human-readable description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A filter for mirrored traffic.  If unset, all traffic is mirrored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1beta2PacketMirroringSpecInitProviderFilter? Filter { get; set; }

    /// <summary>
    /// A means of specifying which resources to mirror.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mirroredResources")]
    public V1beta2PacketMirroringSpecInitProviderMirroredResources? MirroredResources { get; set; }

    /// <summary>
    /// Specifies the mirrored VPC network. Only packets in this network
    /// will be mirrored. All mirrored VMs should have a NIC in the given
    /// network. All mirrored subnetworks should belong to the given network.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("network")]
    public V1beta2PacketMirroringSpecInitProviderNetwork? Network { get; set; }

    /// <summary>
    /// Since only one rule can be active at a time, priority is
    /// used to break ties in the case of two rules that apply to
    /// the same instances.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecManagementPoliciesEnum>))]
public enum V1beta2PacketMirroringSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2PacketMirroringSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PacketMirroringSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2PacketMirroringSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PacketMirroringSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PacketMirroringSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PacketMirroringSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PacketMirroringSpec defines the desired state of PacketMirroring</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringSpec
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
    public V1beta2PacketMirroringSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2PacketMirroringSpecForProvider ForProvider { get; set; }

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
    public V1beta2PacketMirroringSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2PacketMirroringSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2PacketMirroringSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2PacketMirroringSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
/// that will be used as collector for mirrored traffic. The
/// specified forwarding rule must have is_mirroring_collector
/// set to true.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusAtProviderCollectorIlb
{
    /// <summary>The URL of the forwarding rule.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A filter for mirrored traffic.  If unset, all traffic is mirrored.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusAtProviderFilter
{
    /// <summary>
    /// IP CIDR ranges that apply as a filter on the source (ingress) or
    /// destination (egress) IP in the IP header. Only IPv4 is supported.
    /// </summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>
    /// Direction of traffic to mirror.
    /// Default value is BOTH.
    /// Possible values are: INGRESS, EGRESS, BOTH.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Possible IP protocols including tcp, udp, icmp and esp</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusAtProviderMirroredResourcesInstances
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusAtProviderMirroredResourcesSubnetworks
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A means of specifying which resources to mirror.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusAtProviderMirroredResources
{
    /// <summary>
    /// All the listed instances will be mirrored.  Specify at most 50.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("instances")]
    public IList<V1beta2PacketMirroringStatusAtProviderMirroredResourcesInstances>? Instances { get; set; }

    /// <summary>
    /// All instances in one of these subnetworks will be mirrored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subnetworks")]
    public IList<V1beta2PacketMirroringStatusAtProviderMirroredResourcesSubnetworks>? Subnetworks { get; set; }

    /// <summary>All instances with these tags will be mirrored.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>
/// Specifies the mirrored VPC network. Only packets in this network
/// will be mirrored. All mirrored VMs should have a NIC in the given
/// network. All mirrored subnetworks should belong to the given network.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusAtProviderNetwork
{
    /// <summary>The full self_link URL of the network where this rule is active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusAtProvider
{
    /// <summary>
    /// The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
    /// that will be used as collector for mirrored traffic. The
    /// specified forwarding rule must have is_mirroring_collector
    /// set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("collectorIlb")]
    public V1beta2PacketMirroringStatusAtProviderCollectorIlb? CollectorIlb { get; set; }

    /// <summary>A human-readable description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A filter for mirrored traffic.  If unset, all traffic is mirrored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1beta2PacketMirroringStatusAtProviderFilter? Filter { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/packetMirrorings/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A means of specifying which resources to mirror.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mirroredResources")]
    public V1beta2PacketMirroringStatusAtProviderMirroredResources? MirroredResources { get; set; }

    /// <summary>
    /// Specifies the mirrored VPC network. Only packets in this network
    /// will be mirrored. All mirrored VMs should have a NIC in the given
    /// network. All mirrored subnetworks should belong to the given network.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("network")]
    public V1beta2PacketMirroringStatusAtProviderNetwork? Network { get; set; }

    /// <summary>
    /// Since only one rule can be active at a time, priority is
    /// used to break ties in the case of two rules that apply to
    /// the same instances.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatusConditions
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

/// <summary>PacketMirroringStatus defines the observed state of PacketMirroring.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PacketMirroringStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2PacketMirroringStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2PacketMirroringStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PacketMirroring is the Schema for the PacketMirrorings API. Packet Mirroring mirrors traffic to and from particular VM instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PacketMirroring : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PacketMirroringSpec>, IStatus<V1beta2PacketMirroringStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PacketMirroring";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "packetmirrorings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PacketMirroring";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PacketMirroringSpec defines the desired state of PacketMirroring</summary>
    [JsonPropertyName("spec")]
    public required V1beta2PacketMirroringSpec Spec { get; set; }

    /// <summary>PacketMirroringStatus defines the observed state of PacketMirroring.</summary>
    [JsonPropertyName("status")]
    public V1beta2PacketMirroringStatus? Status { get; set; }
}