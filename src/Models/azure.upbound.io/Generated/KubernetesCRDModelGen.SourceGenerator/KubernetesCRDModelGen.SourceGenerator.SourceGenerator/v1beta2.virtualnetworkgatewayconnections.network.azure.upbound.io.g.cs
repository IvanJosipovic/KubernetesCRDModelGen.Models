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
/// <summary>VirtualNetworkGatewayConnection is the Schema for the VirtualNetworkGatewayConnections API. Manages a connection in an existing Virtual Network Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VirtualNetworkGatewayConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2VirtualNetworkGatewayConnection>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VirtualNetworkGatewayConnectionList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualnetworkgatewayconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGatewayConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2VirtualNetworkGatewayConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2VirtualNetworkGatewayConnection> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecDeletionPolicyEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The authorization key associated with the Express Route Circuit. This field is required only if the type is an ExpressRoute connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderAuthorizationKeySecretRef
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
/// A custom_bgp_addresses block which is documented below.
/// The block can only be used on IPSec / activeactive connections,
/// For details about see the relevant section in the Azure documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderCustomBgpAddresses
{
    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (first one)</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (second one)</summary>
    [JsonPropertyName("secondary")]
    public string? Secondary { get; set; }
}

/// <summary>
/// A ipsec_policy block which is documented below.
/// Only a single policy can be defined for a connection. For details on
/// custom policies refer to the relevant section in the Azure documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderIpsecPolicy
{
    /// <summary>The DH group used in IKE phase 1 for initial SA. Valid options are DHGroup1, DHGroup14, DHGroup2, DHGroup2048, DHGroup24, ECP256, ECP384, or None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, or GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE integrity algorithm. Valid options are GCMAES128, GCMAES256, MD5, SHA1, SHA256, or SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, or None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm. Valid options are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1, or SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>
    /// The DH group used in IKE phase 2 for new child SA.
    /// Valid options are ECP256, ECP384, PFS1, PFS14, PFS2, PFS2048, PFS24, PFSMM,
    /// or None.
    /// </summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec SA payload size in KB. Must be at least 1024 KB. Defaults to 102400000 KB.</summary>
    [JsonPropertyName("saDatasize")]
    public double? SaDatasize { get; set; }

    /// <summary>The IPSec SA lifetime in seconds. Must be at least 300 seconds. Defaults to 27000 seconds.</summary>
    [JsonPropertyName("saLifetime")]
    public double? SaLifetime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelector
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
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelector
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
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelector
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
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The shared IPSec key. A key could be provided if a Site-to-Site, VNet-to-VNet or ExpressRoute connection is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderSharedKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderTrafficSelectorPolicy
{
    /// <summary>List of local CIDRs.</summary>
    [JsonPropertyName("localAddressCidrs")]
    public IList<string>? LocalAddressCidrs { get; set; }

    /// <summary>List of remote CIDRs.</summary>
    [JsonPropertyName("remoteAddressCidrs")]
    public IList<string>? RemoteAddressCidrs { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelector
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
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecForProvider
{
    /// <summary>The authorization key associated with the Express Route Circuit. This field is required only if the type is an ExpressRoute connection.</summary>
    [JsonPropertyName("authorizationKeySecretRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderAuthorizationKeySecretRef? AuthorizationKeySecretRef { get; set; }

    /// <summary>Connection mode to use. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default. Changing this value will force a resource to be created.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>
    /// The IKE protocol version to use. Possible values are IKEv1 and IKEv2, values are IKEv1 and IKEv2. Defaults to IKEv2. Changing this forces a new resource to be created.
    /// -&gt; Note: Only valid for IPSec connections on virtual network gateways with SKU VpnGw1, VpnGw2, VpnGw3, VpnGw1AZ, VpnGw2AZ or VpnGw3AZ.
    /// </summary>
    [JsonPropertyName("connectionProtocol")]
    public string? ConnectionProtocol { get; set; }

    /// <summary>
    /// A custom_bgp_addresses block which is documented below.
    /// The block can only be used on IPSec / activeactive connections,
    /// For details about see the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("customBgpAddresses")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderCustomBgpAddresses? CustomBgpAddresses { get; set; }

    /// <summary>The dead peer detection timeout of this connection in seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dpdTimeoutSeconds")]
    public double? DpdTimeoutSeconds { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) is enabled for this connection. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The ID of the Express Route Circuit when creating an ExpressRoute connection (i.e. when type is ExpressRoute). The Express Route Circuit can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitId")]
    public string? ExpressRouteCircuitId { get; set; }

    /// <summary>If true, data packets will bypass ExpressRoute Gateway for data forwarding This is only valid for ExpressRoute connections.</summary>
    [JsonPropertyName("expressRouteGatewayBypass")]
    public bool? ExpressRouteGatewayBypass { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>
    /// A ipsec_policy block which is documented below.
    /// Only a single policy can be defined for a connection. For details on
    /// custom policies refer to the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("ipsecPolicy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderIpsecPolicy? IpsecPolicy { get; set; }

    /// <summary>Use private local Azure IP for the connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The ID of the local network gateway when creating Site-to-Site connection (i.e. when type is IPsec).</summary>
    [JsonPropertyName("localNetworkGatewayId")]
    public string? LocalNetworkGatewayId { get; set; }

    /// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdRef? LocalNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdSelector")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderLocalNetworkGatewayIdSelector? LocalNetworkGatewayIdSelector { get; set; }

    /// <summary>The location/region where the connection is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the peer virtual network gateway when creating a VNet-to-VNet connection (i.e. when type is Vnet2Vnet). The peer Virtual Network Gateway can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayId")]
    public string? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdRef? PeerVirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdSelector")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderPeerVirtualNetworkGatewayIdSelector? PeerVirtualNetworkGatewayIdSelector { get; set; }

    /// <summary>Bypass the Express Route gateway when accessing private-links. When enabled express_route_gateway_bypass must be set to true. Defaults to false.</summary>
    [JsonPropertyName("privateLinkFastPathEnabled")]
    public bool? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the connection Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The routing weight. Defaults to 10.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }

    /// <summary>The shared IPSec key. A key could be provided if a Site-to-Site, VNet-to-VNet or ExpressRoute connection is created.</summary>
    [JsonPropertyName("sharedKeySecretRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderSharedKeySecretRef? SharedKeySecretRef { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// One or more traffic_selector_policy blocks which are documented below.
    /// A traffic_selector_policy allows to specify a traffic selector policy proposal to be used in a virtual network gateway connection.
    /// For details about traffic selectors refer to the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta2VirtualNetworkGatewayConnectionSpecForProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The type of connection. Valid options are IPsec (Site-to-Site), ExpressRoute (ExpressRoute), and Vnet2Vnet (VNet-to-VNet). Each connection type requires different mandatory arguments (refer to the examples above). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If true, policy-based traffic selectors are enabled for this connection. Enabling policy-based traffic selectors requires an ipsec_policy block. Defaults to false.</summary>
    [JsonPropertyName("usePolicyBasedTrafficSelectors")]
    public bool? UsePolicyBasedTrafficSelectors { get; set; }

    /// <summary>The ID of the Virtual Network Gateway in which the connection will be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkGatewayId")]
    public string? VirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdRef? VirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdSelector")]
    public V1beta2VirtualNetworkGatewayConnectionSpecForProviderVirtualNetworkGatewayIdSelector? VirtualNetworkGatewayIdSelector { get; set; }
}

/// <summary>The authorization key associated with the Express Route Circuit. This field is required only if the type is an ExpressRoute connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderAuthorizationKeySecretRef
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
/// A custom_bgp_addresses block which is documented below.
/// The block can only be used on IPSec / activeactive connections,
/// For details about see the relevant section in the Azure documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderCustomBgpAddresses
{
    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (first one)</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (second one)</summary>
    [JsonPropertyName("secondary")]
    public string? Secondary { get; set; }
}

/// <summary>
/// A ipsec_policy block which is documented below.
/// Only a single policy can be defined for a connection. For details on
/// custom policies refer to the relevant section in the Azure documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderIpsecPolicy
{
    /// <summary>The DH group used in IKE phase 1 for initial SA. Valid options are DHGroup1, DHGroup14, DHGroup2, DHGroup2048, DHGroup24, ECP256, ECP384, or None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, or GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE integrity algorithm. Valid options are GCMAES128, GCMAES256, MD5, SHA1, SHA256, or SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, or None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm. Valid options are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1, or SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>
    /// The DH group used in IKE phase 2 for new child SA.
    /// Valid options are ECP256, ECP384, PFS1, PFS14, PFS2, PFS2048, PFS24, PFSMM,
    /// or None.
    /// </summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec SA payload size in KB. Must be at least 1024 KB. Defaults to 102400000 KB.</summary>
    [JsonPropertyName("saDatasize")]
    public double? SaDatasize { get; set; }

    /// <summary>The IPSec SA lifetime in seconds. Must be at least 300 seconds. Defaults to 27000 seconds.</summary>
    [JsonPropertyName("saLifetime")]
    public double? SaLifetime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelector
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
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelector
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
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The shared IPSec key. A key could be provided if a Site-to-Site, VNet-to-VNet or ExpressRoute connection is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderSharedKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderTrafficSelectorPolicy
{
    /// <summary>List of local CIDRs.</summary>
    [JsonPropertyName("localAddressCidrs")]
    public IList<string>? LocalAddressCidrs { get; set; }

    /// <summary>List of remote CIDRs.</summary>
    [JsonPropertyName("remoteAddressCidrs")]
    public IList<string>? RemoteAddressCidrs { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelector
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
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2VirtualNetworkGatewayConnectionSpecInitProvider
{
    /// <summary>The authorization key associated with the Express Route Circuit. This field is required only if the type is an ExpressRoute connection.</summary>
    [JsonPropertyName("authorizationKeySecretRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderAuthorizationKeySecretRef? AuthorizationKeySecretRef { get; set; }

    /// <summary>Connection mode to use. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default. Changing this value will force a resource to be created.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>
    /// The IKE protocol version to use. Possible values are IKEv1 and IKEv2, values are IKEv1 and IKEv2. Defaults to IKEv2. Changing this forces a new resource to be created.
    /// -&gt; Note: Only valid for IPSec connections on virtual network gateways with SKU VpnGw1, VpnGw2, VpnGw3, VpnGw1AZ, VpnGw2AZ or VpnGw3AZ.
    /// </summary>
    [JsonPropertyName("connectionProtocol")]
    public string? ConnectionProtocol { get; set; }

    /// <summary>
    /// A custom_bgp_addresses block which is documented below.
    /// The block can only be used on IPSec / activeactive connections,
    /// For details about see the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("customBgpAddresses")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderCustomBgpAddresses? CustomBgpAddresses { get; set; }

    /// <summary>The dead peer detection timeout of this connection in seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dpdTimeoutSeconds")]
    public double? DpdTimeoutSeconds { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) is enabled for this connection. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The ID of the Express Route Circuit when creating an ExpressRoute connection (i.e. when type is ExpressRoute). The Express Route Circuit can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitId")]
    public string? ExpressRouteCircuitId { get; set; }

    /// <summary>If true, data packets will bypass ExpressRoute Gateway for data forwarding This is only valid for ExpressRoute connections.</summary>
    [JsonPropertyName("expressRouteGatewayBypass")]
    public bool? ExpressRouteGatewayBypass { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>
    /// A ipsec_policy block which is documented below.
    /// Only a single policy can be defined for a connection. For details on
    /// custom policies refer to the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("ipsecPolicy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderIpsecPolicy? IpsecPolicy { get; set; }

    /// <summary>Use private local Azure IP for the connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The ID of the local network gateway when creating Site-to-Site connection (i.e. when type is IPsec).</summary>
    [JsonPropertyName("localNetworkGatewayId")]
    public string? LocalNetworkGatewayId { get; set; }

    /// <summary>Reference to a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdRef? LocalNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a LocalNetworkGateway in network to populate localNetworkGatewayId.</summary>
    [JsonPropertyName("localNetworkGatewayIdSelector")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderLocalNetworkGatewayIdSelector? LocalNetworkGatewayIdSelector { get; set; }

    /// <summary>The location/region where the connection is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the peer virtual network gateway when creating a VNet-to-VNet connection (i.e. when type is Vnet2Vnet). The peer Virtual Network Gateway can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayId")]
    public string? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdRef? PeerVirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate peerVirtualNetworkGatewayId.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayIdSelector")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderPeerVirtualNetworkGatewayIdSelector? PeerVirtualNetworkGatewayIdSelector { get; set; }

    /// <summary>Bypass the Express Route gateway when accessing private-links. When enabled express_route_gateway_bypass must be set to true. Defaults to false.</summary>
    [JsonPropertyName("privateLinkFastPathEnabled")]
    public bool? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>The routing weight. Defaults to 10.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }

    /// <summary>The shared IPSec key. A key could be provided if a Site-to-Site, VNet-to-VNet or ExpressRoute connection is created.</summary>
    [JsonPropertyName("sharedKeySecretRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderSharedKeySecretRef? SharedKeySecretRef { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// One or more traffic_selector_policy blocks which are documented below.
    /// A traffic_selector_policy allows to specify a traffic selector policy proposal to be used in a virtual network gateway connection.
    /// For details about traffic selectors refer to the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta2VirtualNetworkGatewayConnectionSpecInitProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The type of connection. Valid options are IPsec (Site-to-Site), ExpressRoute (ExpressRoute), and Vnet2Vnet (VNet-to-VNet). Each connection type requires different mandatory arguments (refer to the examples above). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If true, policy-based traffic selectors are enabled for this connection. Enabling policy-based traffic selectors requires an ipsec_policy block. Defaults to false.</summary>
    [JsonPropertyName("usePolicyBasedTrafficSelectors")]
    public bool? UsePolicyBasedTrafficSelectors { get; set; }

    /// <summary>The ID of the Virtual Network Gateway in which the connection will be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkGatewayId")]
    public string? VirtualNetworkGatewayId { get; set; }

    /// <summary>Reference to a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdRef? VirtualNetworkGatewayIdRef { get; set; }

    /// <summary>Selector for a VirtualNetworkGateway in network to populate virtualNetworkGatewayId.</summary>
    [JsonPropertyName("virtualNetworkGatewayIdSelector")]
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProviderVirtualNetworkGatewayIdSelector? VirtualNetworkGatewayIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecManagementPoliciesEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>VirtualNetworkGatewayConnectionSpec defines the desired state of VirtualNetworkGatewayConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionSpec
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
    public V1beta2VirtualNetworkGatewayConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2VirtualNetworkGatewayConnectionSpecForProvider ForProvider { get; set; }

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
    public V1beta2VirtualNetworkGatewayConnectionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2VirtualNetworkGatewayConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2VirtualNetworkGatewayConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// A custom_bgp_addresses block which is documented below.
/// The block can only be used on IPSec / activeactive connections,
/// For details about see the relevant section in the Azure documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionStatusAtProviderCustomBgpAddresses
{
    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (first one)</summary>
    [JsonPropertyName("primary")]
    public string? Primary { get; set; }

    /// <summary>single IP address that is part of the azurerm_virtual_network_gateway ip_configuration (second one)</summary>
    [JsonPropertyName("secondary")]
    public string? Secondary { get; set; }
}

/// <summary>
/// A ipsec_policy block which is documented below.
/// Only a single policy can be defined for a connection. For details on
/// custom policies refer to the relevant section in the Azure documentation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionStatusAtProviderIpsecPolicy
{
    /// <summary>The DH group used in IKE phase 1 for initial SA. Valid options are DHGroup1, DHGroup14, DHGroup2, DHGroup2048, DHGroup24, ECP256, ECP384, or None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, or GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE integrity algorithm. Valid options are GCMAES128, GCMAES256, MD5, SHA1, SHA256, or SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm. Valid options are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256, or None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm. Valid options are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1, or SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>
    /// The DH group used in IKE phase 2 for new child SA.
    /// Valid options are ECP256, ECP384, PFS1, PFS14, PFS2, PFS2048, PFS24, PFSMM,
    /// or None.
    /// </summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec SA payload size in KB. Must be at least 1024 KB. Defaults to 102400000 KB.</summary>
    [JsonPropertyName("saDatasize")]
    public double? SaDatasize { get; set; }

    /// <summary>The IPSec SA lifetime in seconds. Must be at least 300 seconds. Defaults to 27000 seconds.</summary>
    [JsonPropertyName("saLifetime")]
    public double? SaLifetime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionStatusAtProviderTrafficSelectorPolicy
{
    /// <summary>List of local CIDRs.</summary>
    [JsonPropertyName("localAddressCidrs")]
    public IList<string>? LocalAddressCidrs { get; set; }

    /// <summary>List of remote CIDRs.</summary>
    [JsonPropertyName("remoteAddressCidrs")]
    public IList<string>? RemoteAddressCidrs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionStatusAtProvider
{
    /// <summary>Connection mode to use. Possible values are Default, InitiatorOnly and ResponderOnly. Defaults to Default. Changing this value will force a resource to be created.</summary>
    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    /// <summary>
    /// The IKE protocol version to use. Possible values are IKEv1 and IKEv2, values are IKEv1 and IKEv2. Defaults to IKEv2. Changing this forces a new resource to be created.
    /// -&gt; Note: Only valid for IPSec connections on virtual network gateways with SKU VpnGw1, VpnGw2, VpnGw3, VpnGw1AZ, VpnGw2AZ or VpnGw3AZ.
    /// </summary>
    [JsonPropertyName("connectionProtocol")]
    public string? ConnectionProtocol { get; set; }

    /// <summary>
    /// A custom_bgp_addresses block which is documented below.
    /// The block can only be used on IPSec / activeactive connections,
    /// For details about see the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("customBgpAddresses")]
    public V1beta2VirtualNetworkGatewayConnectionStatusAtProviderCustomBgpAddresses? CustomBgpAddresses { get; set; }

    /// <summary>The dead peer detection timeout of this connection in seconds. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dpdTimeoutSeconds")]
    public double? DpdTimeoutSeconds { get; set; }

    /// <summary>A list of the egress NAT Rule Ids.</summary>
    [JsonPropertyName("egressNatRuleIds")]
    public IList<string>? EgressNatRuleIds { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) is enabled for this connection. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The ID of the Express Route Circuit when creating an ExpressRoute connection (i.e. when type is ExpressRoute). The Express Route Circuit can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitId")]
    public string? ExpressRouteCircuitId { get; set; }

    /// <summary>If true, data packets will bypass ExpressRoute Gateway for data forwarding This is only valid for ExpressRoute connections.</summary>
    [JsonPropertyName("expressRouteGatewayBypass")]
    public bool? ExpressRouteGatewayBypass { get; set; }

    /// <summary>The ID of the Virtual Network Gateway Connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of the ingress NAT Rule Ids.</summary>
    [JsonPropertyName("ingressNatRuleIds")]
    public IList<string>? IngressNatRuleIds { get; set; }

    /// <summary>
    /// A ipsec_policy block which is documented below.
    /// Only a single policy can be defined for a connection. For details on
    /// custom policies refer to the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("ipsecPolicy")]
    public V1beta2VirtualNetworkGatewayConnectionStatusAtProviderIpsecPolicy? IpsecPolicy { get; set; }

    /// <summary>Use private local Azure IP for the connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("localAzureIpAddressEnabled")]
    public bool? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>The ID of the local network gateway when creating Site-to-Site connection (i.e. when type is IPsec).</summary>
    [JsonPropertyName("localNetworkGatewayId")]
    public string? LocalNetworkGatewayId { get; set; }

    /// <summary>The location/region where the connection is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the peer virtual network gateway when creating a VNet-to-VNet connection (i.e. when type is Vnet2Vnet). The peer Virtual Network Gateway can be in the same or in a different subscription. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerVirtualNetworkGatewayId")]
    public string? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>Bypass the Express Route gateway when accessing private-links. When enabled express_route_gateway_bypass must be set to true. Defaults to false.</summary>
    [JsonPropertyName("privateLinkFastPathEnabled")]
    public bool? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the connection Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The routing weight. Defaults to 10.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// One or more traffic_selector_policy blocks which are documented below.
    /// A traffic_selector_policy allows to specify a traffic selector policy proposal to be used in a virtual network gateway connection.
    /// For details about traffic selectors refer to the relevant section in the Azure documentation.
    /// </summary>
    [JsonPropertyName("trafficSelectorPolicy")]
    public IList<V1beta2VirtualNetworkGatewayConnectionStatusAtProviderTrafficSelectorPolicy>? TrafficSelectorPolicy { get; set; }

    /// <summary>The type of connection. Valid options are IPsec (Site-to-Site), ExpressRoute (ExpressRoute), and Vnet2Vnet (VNet-to-VNet). Each connection type requires different mandatory arguments (refer to the examples above). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>If true, policy-based traffic selectors are enabled for this connection. Enabling policy-based traffic selectors requires an ipsec_policy block. Defaults to false.</summary>
    [JsonPropertyName("usePolicyBasedTrafficSelectors")]
    public bool? UsePolicyBasedTrafficSelectors { get; set; }

    /// <summary>The ID of the Virtual Network Gateway in which the connection will be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkGatewayId")]
    public string? VirtualNetworkGatewayId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionStatusConditions
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

/// <summary>VirtualNetworkGatewayConnectionStatus defines the observed state of VirtualNetworkGatewayConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNetworkGatewayConnectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2VirtualNetworkGatewayConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2VirtualNetworkGatewayConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualNetworkGatewayConnection is the Schema for the VirtualNetworkGatewayConnections API. Manages a connection in an existing Virtual Network Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VirtualNetworkGatewayConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2VirtualNetworkGatewayConnectionSpec>, IStatus<V1beta2VirtualNetworkGatewayConnectionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VirtualNetworkGatewayConnection";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualnetworkgatewayconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGatewayConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualNetworkGatewayConnectionSpec defines the desired state of VirtualNetworkGatewayConnection</summary>
    [JsonPropertyName("spec")]
    public required V1beta2VirtualNetworkGatewayConnectionSpec Spec { get; set; }

    /// <summary>VirtualNetworkGatewayConnectionStatus defines the observed state of VirtualNetworkGatewayConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta2VirtualNetworkGatewayConnectionStatus? Status { get; set; }
}