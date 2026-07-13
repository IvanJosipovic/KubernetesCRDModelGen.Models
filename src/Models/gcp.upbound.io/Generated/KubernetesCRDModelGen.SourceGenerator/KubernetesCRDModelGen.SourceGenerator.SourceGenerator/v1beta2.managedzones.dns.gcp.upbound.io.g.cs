#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dns.gcp.upbound.io;
/// <summary>ManagedZone is the Schema for the ManagedZones API. A zone is a subtree of the DNS namespace under one administrative responsibility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagedZoneList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ManagedZone>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagedZoneList";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "managedzones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedZoneList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ManagedZone objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ManagedZone> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecDeletionPolicyEnum>))]
public enum V1beta2ManagedZoneSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Cloud logging configuration
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderDnssecConfigDefaultKeySpecs
{
    /// <summary>
    /// String mnemonic specifying the DNSSEC algorithm of this key
    /// Possible values are: ecdsap256sha256, ecdsap384sha384, rsasha1, rsasha256, rsasha512.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits</summary>
    [JsonPropertyName("keyLength")]
    public double? KeyLength { get; set; }

    /// <summary>
    /// Specifies whether this is a key signing key (KSK) or a zone
    /// signing key (ZSK). Key signing keys have the Secure Entry
    /// Point flag set and, when active, will only be used to sign
    /// resource record sets of type DNSKEY. Zone signing keys do
    /// not have the Secure Entry Point flag set and will be used
    /// to sign all other types of resource record sets.
    /// Possible values are: keySigning, zoneSigning.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>
/// DNSSEC configuration
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderDnssecConfig
{
    /// <summary>
    /// Specifies parameters that will be used for generating initial DnsKeys
    /// for this ManagedZone. If you provide a spec for keySigning or zoneSigning,
    /// you must also provide one for the other.
    /// default_key_specs can only be updated when the state is off.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta2ManagedZoneSpecForProviderDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is off.
    /// Possible values are: nsec, nsec3.
    /// </summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in
    /// Possible values are: off, on, transfer.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderForwardingConfigTargetNameServers
{
    /// <summary>Fully qualified domain name for the forwarding target.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding
    /// decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go
    /// to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target
    /// Possible values are: default, private.
    /// </summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>
/// The presence for this field indicates that outbound forwarding is enabled
/// for this zone. The value of this field contains the set of destinations
/// to forward to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderForwardingConfig
{
    /// <summary>
    /// List of target name servers to forward to. Cloud DNS will
    /// select the best available name server if more than
    /// one target is given.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta2ManagedZoneSpecForProviderForwardingConfigTargetNameServers>? TargetNameServers { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelector
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
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The network with which to peer.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetwork
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like projects/{project}/global/networks/{network} or
    /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetworkNetworkUrlSelector? NetworkUrlSelector { get; set; }
}

/// <summary>
/// The presence of this field indicates that DNS Peering is enabled for this
/// zone. The value of this field contains the network to peer with.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPeeringConfig
{
    /// <summary>
    /// The network with which to peer.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetNetwork")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfigTargetNetwork? TargetNetwork { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector
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
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClusters
{
    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// projects/*/locations/*/clusters/*
    /// </summary>
    [JsonPropertyName("gkeClusterName")]
    public string? GkeClusterName { get; set; }

    /// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameRef")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef? GkeClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameSelector")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector? GkeClusterNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelector
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
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworks
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like projects/{project}/global/networks/{network} or
    /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworksNetworkUrlSelector? NetworkUrlSelector { get; set; }
}

/// <summary>
/// For privately visible zones, the set of Virtual Private Cloud
/// resources that the zone is visible from. At least one of gke_clusters or networks must be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfig
{
    /// <summary>
    /// The list of Google Kubernetes Engine clusters that can see this zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    /// <summary>
    /// The list of VPC networks that can see this zone.12 SDK in a future release, you
    /// may experience issues with this resource while updating. If you encounter this issue, remove all networks
    /// blocks in an update and then apply another update adding all of them back simultaneously.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networks")]
    public IList<V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfigNetworks>? Networks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecForProvider
{
    /// <summary>
    /// Cloud logging configuration
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public V1beta2ManagedZoneSpecForProviderCloudLoggingConfig? CloudLoggingConfig { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The DNS name of this managed zone, for instance &quot;example.com.&quot;.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>
    /// DNSSEC configuration
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dnssecConfig")]
    public V1beta2ManagedZoneSpecForProviderDnssecConfig? DnssecConfig { get; set; }

    /// <summary>Set this true to delete all records in the zone.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>
    /// The presence for this field indicates that outbound forwarding is enabled
    /// for this zone. The value of this field contains the set of destinations
    /// to forward to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("forwardingConfig")]
    public V1beta2ManagedZoneSpecForProviderForwardingConfig? ForwardingConfig { get; set; }

    /// <summary>A set of key/value label pairs to assign to this ManagedZone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The presence of this field indicates that DNS Peering is enabled for this
    /// zone. The value of this field contains the network to peer with.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("peeringConfig")]
    public V1beta2ManagedZoneSpecForProviderPeeringConfig? PeeringConfig { get; set; }

    /// <summary>
    /// For privately visible zones, the set of Virtual Private Cloud
    /// resources that the zone is visible from. At least one of gke_clusters or networks must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public V1beta2ManagedZoneSpecForProviderPrivateVisibilityConfig? PrivateVisibilityConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The zone&apos;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources.
    /// Default value is public.
    /// Possible values are: private, public.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// Cloud logging configuration
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderDnssecConfigDefaultKeySpecs
{
    /// <summary>
    /// String mnemonic specifying the DNSSEC algorithm of this key
    /// Possible values are: ecdsap256sha256, ecdsap384sha384, rsasha1, rsasha256, rsasha512.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits</summary>
    [JsonPropertyName("keyLength")]
    public double? KeyLength { get; set; }

    /// <summary>
    /// Specifies whether this is a key signing key (KSK) or a zone
    /// signing key (ZSK). Key signing keys have the Secure Entry
    /// Point flag set and, when active, will only be used to sign
    /// resource record sets of type DNSKEY. Zone signing keys do
    /// not have the Secure Entry Point flag set and will be used
    /// to sign all other types of resource record sets.
    /// Possible values are: keySigning, zoneSigning.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>
/// DNSSEC configuration
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderDnssecConfig
{
    /// <summary>
    /// Specifies parameters that will be used for generating initial DnsKeys
    /// for this ManagedZone. If you provide a spec for keySigning or zoneSigning,
    /// you must also provide one for the other.
    /// default_key_specs can only be updated when the state is off.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta2ManagedZoneSpecInitProviderDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is off.
    /// Possible values are: nsec, nsec3.
    /// </summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in
    /// Possible values are: off, on, transfer.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderForwardingConfigTargetNameServers
{
    /// <summary>Fully qualified domain name for the forwarding target.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding
    /// decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go
    /// to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target
    /// Possible values are: default, private.
    /// </summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>
/// The presence for this field indicates that outbound forwarding is enabled
/// for this zone. The value of this field contains the set of destinations
/// to forward to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderForwardingConfig
{
    /// <summary>
    /// List of target name servers to forward to. Cloud DNS will
    /// select the best available name server if more than
    /// one target is given.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta2ManagedZoneSpecInitProviderForwardingConfigTargetNameServers>? TargetNameServers { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelector
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
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The network with which to peer.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetwork
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like projects/{project}/global/networks/{network} or
    /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetworkNetworkUrlSelector? NetworkUrlSelector { get; set; }
}

/// <summary>
/// The presence of this field indicates that DNS Peering is enabled for this
/// zone. The value of this field contains the network to peer with.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPeeringConfig
{
    /// <summary>
    /// The network with which to peer.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetNetwork")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfigTargetNetwork? TargetNetwork { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector
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
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClusters
{
    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// projects/*/locations/*/clusters/*
    /// </summary>
    [JsonPropertyName("gkeClusterName")]
    public string? GkeClusterName { get; set; }

    /// <summary>Reference to a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameRef")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameRef? GkeClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate gkeClusterName.</summary>
    [JsonPropertyName("gkeClusterNameSelector")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClustersGkeClusterNameSelector? GkeClusterNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate networkUrl.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelector
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
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworks
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like projects/{project}/global/networks/{network} or
    /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }

    /// <summary>Reference to a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlRef")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlRef? NetworkUrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate networkUrl.</summary>
    [JsonPropertyName("networkUrlSelector")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworksNetworkUrlSelector? NetworkUrlSelector { get; set; }
}

/// <summary>
/// For privately visible zones, the set of Virtual Private Cloud
/// resources that the zone is visible from. At least one of gke_clusters or networks must be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfig
{
    /// <summary>
    /// The list of Google Kubernetes Engine clusters that can see this zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    /// <summary>
    /// The list of VPC networks that can see this zone.12 SDK in a future release, you
    /// may experience issues with this resource while updating. If you encounter this issue, remove all networks
    /// blocks in an update and then apply another update adding all of them back simultaneously.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networks")]
    public IList<V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfigNetworks>? Networks { get; set; }
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
public partial class V1beta2ManagedZoneSpecInitProvider
{
    /// <summary>
    /// Cloud logging configuration
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public V1beta2ManagedZoneSpecInitProviderCloudLoggingConfig? CloudLoggingConfig { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The DNS name of this managed zone, for instance &quot;example.com.&quot;.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>
    /// DNSSEC configuration
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dnssecConfig")]
    public V1beta2ManagedZoneSpecInitProviderDnssecConfig? DnssecConfig { get; set; }

    /// <summary>Set this true to delete all records in the zone.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>
    /// The presence for this field indicates that outbound forwarding is enabled
    /// for this zone. The value of this field contains the set of destinations
    /// to forward to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("forwardingConfig")]
    public V1beta2ManagedZoneSpecInitProviderForwardingConfig? ForwardingConfig { get; set; }

    /// <summary>A set of key/value label pairs to assign to this ManagedZone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The presence of this field indicates that DNS Peering is enabled for this
    /// zone. The value of this field contains the network to peer with.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("peeringConfig")]
    public V1beta2ManagedZoneSpecInitProviderPeeringConfig? PeeringConfig { get; set; }

    /// <summary>
    /// For privately visible zones, the set of Virtual Private Cloud
    /// resources that the zone is visible from. At least one of gke_clusters or networks must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public V1beta2ManagedZoneSpecInitProviderPrivateVisibilityConfig? PrivateVisibilityConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The zone&apos;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources.
    /// Default value is public.
    /// Possible values are: private, public.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecManagementPoliciesEnum>))]
public enum V1beta2ManagedZoneSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ManagedZoneSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedZoneSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ManagedZoneSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedZoneSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedZoneSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedZoneSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ManagedZoneSpec defines the desired state of ManagedZone</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneSpec
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
    public V1beta2ManagedZoneSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ManagedZoneSpecForProvider ForProvider { get; set; }

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
    public V1beta2ManagedZoneSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ManagedZoneSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ManagedZoneSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ManagedZoneSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Cloud logging configuration
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderCloudLoggingConfig
{
    /// <summary>If set, enable query logging for this ManagedZone. False by default, making logging opt-in.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderDnssecConfigDefaultKeySpecs
{
    /// <summary>
    /// String mnemonic specifying the DNSSEC algorithm of this key
    /// Possible values are: ecdsap256sha256, ecdsap384sha384, rsasha1, rsasha256, rsasha512.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Length of the keys in bits</summary>
    [JsonPropertyName("keyLength")]
    public double? KeyLength { get; set; }

    /// <summary>
    /// Specifies whether this is a key signing key (KSK) or a zone
    /// signing key (ZSK). Key signing keys have the Secure Entry
    /// Point flag set and, when active, will only be used to sign
    /// resource record sets of type DNSKEY. Zone signing keys do
    /// not have the Secure Entry Point flag set and will be used
    /// to sign all other types of resource record sets.
    /// Possible values are: keySigning, zoneSigning.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>
/// DNSSEC configuration
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderDnssecConfig
{
    /// <summary>
    /// Specifies parameters that will be used for generating initial DnsKeys
    /// for this ManagedZone. If you provide a spec for keySigning or zoneSigning,
    /// you must also provide one for the other.
    /// default_key_specs can only be updated when the state is off.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultKeySpecs")]
    public IList<V1beta2ManagedZoneStatusAtProviderDnssecConfigDefaultKeySpecs>? DefaultKeySpecs { get; set; }

    /// <summary>Identifies what kind of resource this is</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is off.
    /// Possible values are: nsec, nsec3.
    /// </summary>
    [JsonPropertyName("nonExistence")]
    public string? NonExistence { get; set; }

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in
    /// Possible values are: off, on, transfer.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderForwardingConfigTargetNameServers
{
    /// <summary>Fully qualified domain name for the forwarding target.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// Forwarding path for this TargetNameServer. If unset or default Cloud DNS will make forwarding
    /// decision based on address ranges, i.e. RFC1918 addresses go to the VPC, Non-RFC1918 addresses go
    /// to the Internet. When set to private, Cloud DNS will always send queries through VPC for this target
    /// Possible values are: default, private.
    /// </summary>
    [JsonPropertyName("forwardingPath")]
    public string? ForwardingPath { get; set; }

    /// <summary>IPv4 address of a target name server.</summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>
/// The presence for this field indicates that outbound forwarding is enabled
/// for this zone. The value of this field contains the set of destinations
/// to forward to.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderForwardingConfig
{
    /// <summary>
    /// List of target name servers to forward to. Cloud DNS will
    /// select the best available name server if more than
    /// one target is given.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetNameServers")]
    public IList<V1beta2ManagedZoneStatusAtProviderForwardingConfigTargetNameServers>? TargetNameServers { get; set; }
}

/// <summary>
/// The network with which to peer.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderPeeringConfigTargetNetwork
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like projects/{project}/global/networks/{network} or
    /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }
}

/// <summary>
/// The presence of this field indicates that DNS Peering is enabled for this
/// zone. The value of this field contains the network to peer with.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderPeeringConfig
{
    /// <summary>
    /// The network with which to peer.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("targetNetwork")]
    public V1beta2ManagedZoneStatusAtProviderPeeringConfigTargetNetwork? TargetNetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderPrivateVisibilityConfigGkeClusters
{
    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// projects/*/locations/*/clusters/*
    /// </summary>
    [JsonPropertyName("gkeClusterName")]
    public string? GkeClusterName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderPrivateVisibilityConfigNetworks
{
    /// <summary>
    /// The id or fully qualified URL of the VPC network to forward queries to.
    /// This should be formatted like projects/{project}/global/networks/{network} or
    /// https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}
    /// </summary>
    [JsonPropertyName("networkUrl")]
    public string? NetworkUrl { get; set; }
}

/// <summary>
/// For privately visible zones, the set of Virtual Private Cloud
/// resources that the zone is visible from. At least one of gke_clusters or networks must be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProviderPrivateVisibilityConfig
{
    /// <summary>
    /// The list of Google Kubernetes Engine clusters that can see this zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gkeClusters")]
    public IList<V1beta2ManagedZoneStatusAtProviderPrivateVisibilityConfigGkeClusters>? GkeClusters { get; set; }

    /// <summary>
    /// The list of VPC networks that can see this zone.12 SDK in a future release, you
    /// may experience issues with this resource while updating. If you encounter this issue, remove all networks
    /// blocks in an update and then apply another update adding all of them back simultaneously.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networks")]
    public IList<V1beta2ManagedZoneStatusAtProviderPrivateVisibilityConfigNetworks>? Networks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusAtProvider
{
    /// <summary>
    /// Cloud logging configuration
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cloudLoggingConfig")]
    public V1beta2ManagedZoneStatusAtProviderCloudLoggingConfig? CloudLoggingConfig { get; set; }

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>A textual description field.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The DNS name of this managed zone, for instance &quot;example.com.&quot;.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>
    /// DNSSEC configuration
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dnssecConfig")]
    public V1beta2ManagedZoneStatusAtProviderDnssecConfig? DnssecConfig { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Set this true to delete all records in the zone.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>
    /// The presence for this field indicates that outbound forwarding is enabled
    /// for this zone. The value of this field contains the set of destinations
    /// to forward to.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("forwardingConfig")]
    public V1beta2ManagedZoneStatusAtProviderForwardingConfig? ForwardingConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/managedZones/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A set of key/value label pairs to assign to this ManagedZone.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Unique identifier for the resource; defined by the server.</summary>
    [JsonPropertyName("managedZoneId")]
    public double? ManagedZoneId { get; set; }

    /// <summary>
    /// Delegate your managed_zone to these virtual name servers;
    /// defined by the server
    /// </summary>
    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }

    /// <summary>
    /// The presence of this field indicates that DNS Peering is enabled for this
    /// zone. The value of this field contains the network to peer with.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("peeringConfig")]
    public V1beta2ManagedZoneStatusAtProviderPeeringConfig? PeeringConfig { get; set; }

    /// <summary>
    /// For privately visible zones, the set of Virtual Private Cloud
    /// resources that the zone is visible from. At least one of gke_clusters or networks must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("privateVisibilityConfig")]
    public V1beta2ManagedZoneStatusAtProviderPrivateVisibilityConfig? PrivateVisibilityConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// The zone&apos;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources.
    /// Default value is public.
    /// Possible values are: private, public.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatusConditions
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

/// <summary>ManagedZoneStatus defines the observed state of ManagedZone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedZoneStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ManagedZoneStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ManagedZoneStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ManagedZone is the Schema for the ManagedZones API. A zone is a subtree of the DNS namespace under one administrative responsibility.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagedZone : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ManagedZoneSpec>, IStatus<V1beta2ManagedZoneStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagedZone";
    public const string KubeGroup = "dns.gcp.upbound.io";
    public const string KubePluralName = "managedzones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dns.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedZone";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedZoneSpec defines the desired state of ManagedZone</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ManagedZoneSpec Spec { get; set; }

    /// <summary>ManagedZoneStatus defines the observed state of ManagedZone.</summary>
    [JsonPropertyName("status")]
    public V1beta2ManagedZoneStatus? Status { get; set; }
}