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
/// <summary>
/// VirtualNetworkGateway is the Schema for the VirtualNetworkGateways API. Manages a virtual network gateway to establish secure, cross-premises connectivity.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualNetworkGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VirtualNetworkGateway>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualNetworkGatewayList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1VirtualNetworkGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1VirtualNetworkGateway> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderBgpSettingsPeeringAddresses
{
    /// <summary>A list of Azure custom APIPA addresses assigned to the BGP peer of the Virtual Network Gateway.</summary>
    [JsonPropertyName("apipaAddresses")]
    public IList<string>? ApipaAddresses { get; set; }

    /// <summary>The name of the IP configuration of this Virtual Network Gateway. In case there are multiple ip_configuration blocks defined, this property is required to specify.</summary>
    [JsonPropertyName("ipConfigurationName")]
    public string? IpConfigurationName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderBgpSettings
{
    /// <summary>The Autonomous System Number (ASN) to use as part of the BGP.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The weight added to routes which have been learned through BGP peering. Valid values can be between 0 and 100.</summary>
    [JsonPropertyName("peerWeight")]
    public double? PeerWeight { get; set; }

    /// <summary>A list of peering_addresses blocks as defined below. Only one peering_addresses block can be specified except when active_active of this Virtual Network Gateway is true.</summary>
    [JsonPropertyName("peeringAddresses")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderBgpSettingsPeeringAddresses>? PeeringAddresses { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderCustomRoute
{
    /// <summary>A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelector
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
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelector
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
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderIpConfiguration
{
    /// <summary>A user-defined name of the IP configuration. Defaults to vnetGatewayConfig.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Defines how the private IP address of the gateways virtual interface is assigned. The only valid value is Dynamic for Virtual Network Gateway (Static is not supported by the service yet). Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the public IP address to associate with the Virtual Network Gateway.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdRef")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdRef? PublicIpAddressIdRef { get; set; }

    /// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdSelector")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationPublicIpAddressIdSelector? PublicIpAddressIdSelector { get; set; }

    /// <summary>The ID of the gateway subnet of a virtual network in which the virtual network gateway will be created. It is mandatory that the associated subnet is named GatewaySubnet. Therefore, each virtual network can contain at most a single Virtual Network Gateway.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1VirtualNetworkGatewaySpecForProviderIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderPolicyGroupPolicyMember
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Virtual Network Gateway. Valid options are Vpn or ExpressRoute. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of attribute that is used for this Virtual Network Gateway Policy Group Member.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderPolicyGroup
{
    /// <summary>Is this a Default Virtual Network Gateway Policy Group? Defaults to false.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The name of the Virtual Network Gateway Policy Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more policy_member blocks as defined below.</summary>
    [JsonPropertyName("policyMember")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderPolicyGroupPolicyMember>? PolicyMember { get; set; }

    /// <summary>The priority for the Virtual Network Gateway Policy Group. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelector
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
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values are DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values are GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values are ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel. Possible values are between 1024 and 2147483647.</summary>
    [JsonPropertyName("saDataSizeInKilobytes")]
    public double? SaDataSizeInKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel. Possible values are between 300 and 172799.</summary>
    [JsonPropertyName("saLifetimeInSeconds")]
    public double? SaLifetimeInSeconds { get; set; }
}

/// <summary>The secret that is used to communicate with the Radius Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRadiusServerSecretSecretRef
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRadiusServer
{
    /// <summary>The address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The score of the Radius Server determines the priority of the server. Possible values are between 1 and 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }

    /// <summary>The secret that is used to communicate with the Radius Server.</summary>
    [JsonPropertyName("secretSecretRef")]
    public required V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRadiusServerSecretSecretRef SecretSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRevokedCertificate
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the public data of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRootCertificate
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The public certificate of the root certificate authority. The certificate must be provided in Base-64 encoded X.509 format (PEM). In particular, this argument must not include the -----BEGIN CERTIFICATE----- or -----END CERTIFICATE----- markers, nor any newlines.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationVirtualNetworkGatewayClientConnection
{
    /// <summary>A list of address prefixes for P2S VPN Client.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of names of Virtual Network Gateway Policy Groups.</summary>
    [JsonPropertyName("policyGroupNames")]
    public IList<string>? PolicyGroupNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfiguration
{
    /// <summary>
    /// The client id of the Azure VPN application.
    /// See Create an Active Directory (AD) tenant for P2S OpenVPN protocol connections for values
    /// </summary>
    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    /// <summary>The STS url for your tenant</summary>
    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    /// <summary>AzureAD Tenant URL</summary>
    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    /// <summary>The address space out of which IP addresses for vpn clients will be taken. You can provide more than one address space, e.g. in CIDR notation.</summary>
    [JsonPropertyName("addressSpace")]
    public IList<string>? AddressSpace { get; set; }

    /// <summary>An ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>One or more radius_server blocks as defined below.</summary>
    [JsonPropertyName("radiusServer")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRadiusServer>? RadiusServer { get; set; }

    /// <summary>The address of the Radius server.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>The secret used by the Radius server.</summary>
    [JsonPropertyName("radiusServerSecret")]
    public string? RadiusServerSecret { get; set; }

    /// <summary>One or more revoked_certificate blocks which are defined below.</summary>
    [JsonPropertyName("revokedCertificate")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRevokedCertificate>? RevokedCertificate { get; set; }

    /// <summary>One or more root_certificate blocks which are defined below. These root certificates are used to sign the client certificate used by the VPN clients to connect to the gateway.</summary>
    [JsonPropertyName("rootCertificate")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationRootCertificate>? RootCertificate { get; set; }

    /// <summary>One or more virtual_network_gateway_client_connection blocks as defined below.</summary>
    [JsonPropertyName("virtualNetworkGatewayClientConnection")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfigurationVirtualNetworkGatewayClientConnection>? VirtualNetworkGatewayClientConnection { get; set; }

    /// <summary>
    /// List of the vpn authentication types for the virtual network gateway.
    /// The supported values are AAD, Radius and Certificate.
    /// </summary>
    [JsonPropertyName("vpnAuthTypes")]
    public IList<string>? VpnAuthTypes { get; set; }

    /// <summary>
    /// List of the protocols supported by the vpn client.
    /// The supported values are SSTP, IkeV2 and OpenVPN.
    /// Values SSTP and IkeV2 are incompatible with the use of
    /// aad_tenant, aad_audience and aad_issuer.
    /// </summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecForProvider
{
    /// <summary>If true, an active-active Virtual Network Gateway will be created. An active-active gateway requires a HighPerformance or an UltraPerformance SKU. If false, an active-standby gateway will be created. Defaults to false.</summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>Is BGP Route Translation for NAT enabled? Defaults to false.</summary>
    [JsonPropertyName("bgpRouteTranslationForNatEnabled")]
    public bool? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>A bgp_settings block which is documented below. In this block the BGP specific settings can be defined.</summary>
    [JsonPropertyName("bgpSettings")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderBgpSettings>? BgpSettings { get; set; }

    /// <summary>A custom_route block as defined below. Specifies a custom routes address space for a virtual network gateway and a VpnClient.</summary>
    [JsonPropertyName("customRoute")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderCustomRoute>? CustomRoute { get; set; }

    /// <summary>The ID of the local network gateway through which outbound Internet traffic from the virtual network in which the gateway is created will be routed (forced tunnelling). Refer to the Azure documentation on forced tunnelling. If not specified, forced tunnelling is disabled.</summary>
    [JsonPropertyName("defaultLocalNetworkGatewayId")]
    public string? DefaultLocalNetworkGatewayId { get; set; }

    /// <summary>Is DNS forwarding enabled?</summary>
    [JsonPropertyName("dnsForwardingEnabled")]
    public bool? DnsForwardingEnabled { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Virtual Network Gateway should exist. Changing this forces a new Virtual Network Gateway to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) will be enabled for this Virtual Network Gateway. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The Generation of the Virtual Network gateway. Possible values include Generation1, Generation2 or None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>
    /// One or more (up to 3) ip_configuration blocks documented below.
    /// An active-standby gateway requires exactly one ip_configuration block,
    /// an active-active gateway requires exactly two ip_configuration blocks whereas
    /// an active-active zone redundant gateway with P2S configuration requires exactly three ip_configuration blocks.
    /// </summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>Is IP Sec Replay Protection enabled? Defaults to true.</summary>
    [JsonPropertyName("ipSecReplayProtectionEnabled")]
    public bool? IpSecReplayProtectionEnabled { get; set; }

    /// <summary>The location/region where the Virtual Network Gateway is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more policy_group blocks as defined below.</summary>
    [JsonPropertyName("policyGroup")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderPolicyGroup>? PolicyGroup { get; set; }

    /// <summary>Should private IP be enabled on this gateway for connections? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateIpAddressEnabled")]
    public bool? PrivateIpAddressEnabled { get; set; }

    /// <summary>Is remote vnet traffic that is used to configure this gateway to accept traffic from other Azure Virtual Networks enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteVnetTrafficEnabled")]
    public bool? RemoteVnetTrafficEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Virtual Network Gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VirtualNetworkGatewaySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Configuration of the size and capacity of the virtual network gateway. Valid options are Basic, Standard, HighPerformance, UltraPerformance, ErGw1AZ, ErGw2AZ, ErGw3AZ, VpnGw1, VpnGw2, VpnGw3, VpnGw4,VpnGw5, VpnGw1AZ, VpnGw2AZ, VpnGw3AZ,VpnGw4AZ and VpnGw5AZ and depend on the type, vpn_type and generation arguments. A PolicyBased gateway only supports the Basic SKU. Further, the UltraPerformance SKU is only supported by an ExpressRoute gateway.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the Virtual Network Gateway. Valid options are Vpn or ExpressRoute. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Is remote vnet traffic that is used to configure this gateway to accept traffic from remote Virtual WAN networks enabled? Defaults to false.</summary>
    [JsonPropertyName("virtualWanTrafficEnabled")]
    public bool? VirtualWanTrafficEnabled { get; set; }

    /// <summary>A vpn_client_configuration block which is documented below. In this block the Virtual Network Gateway can be configured to accept IPSec point-to-site connections.</summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public IList<V1beta1VirtualNetworkGatewaySpecForProviderVpnClientConfiguration>? VpnClientConfiguration { get; set; }

    /// <summary>The routing type of the Virtual Network Gateway. Valid options are RouteBased or PolicyBased. Defaults to RouteBased. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderBgpSettingsPeeringAddresses
{
    /// <summary>A list of Azure custom APIPA addresses assigned to the BGP peer of the Virtual Network Gateway.</summary>
    [JsonPropertyName("apipaAddresses")]
    public IList<string>? ApipaAddresses { get; set; }

    /// <summary>The name of the IP configuration of this Virtual Network Gateway. In case there are multiple ip_configuration blocks defined, this property is required to specify.</summary>
    [JsonPropertyName("ipConfigurationName")]
    public string? IpConfigurationName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderBgpSettings
{
    /// <summary>The Autonomous System Number (ASN) to use as part of the BGP.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The weight added to routes which have been learned through BGP peering. Valid values can be between 0 and 100.</summary>
    [JsonPropertyName("peerWeight")]
    public double? PeerWeight { get; set; }

    /// <summary>A list of peering_addresses blocks as defined below. Only one peering_addresses block can be specified except when active_active of this Virtual Network Gateway is true.</summary>
    [JsonPropertyName("peeringAddresses")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderBgpSettingsPeeringAddresses>? PeeringAddresses { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderCustomRoute
{
    /// <summary>A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelector
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
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelector
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
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderIpConfiguration
{
    /// <summary>A user-defined name of the IP configuration. Defaults to vnetGatewayConfig.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Defines how the private IP address of the gateways virtual interface is assigned. The only valid value is Dynamic for Virtual Network Gateway (Static is not supported by the service yet). Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the public IP address to associate with the Virtual Network Gateway.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdRef")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdRef? PublicIpAddressIdRef { get; set; }

    /// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdSelector")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationPublicIpAddressIdSelector? PublicIpAddressIdSelector { get; set; }

    /// <summary>The ID of the gateway subnet of a virtual network in which the virtual network gateway will be created. It is mandatory that the associated subnet is named GatewaySubnet. Therefore, each virtual network can contain at most a single Virtual Network Gateway.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1VirtualNetworkGatewaySpecInitProviderIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderPolicyGroupPolicyMember
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Virtual Network Gateway. Valid options are Vpn or ExpressRoute. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of attribute that is used for this Virtual Network Gateway Policy Group Member.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderPolicyGroup
{
    /// <summary>Is this a Default Virtual Network Gateway Policy Group? Defaults to false.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The name of the Virtual Network Gateway Policy Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more policy_member blocks as defined below.</summary>
    [JsonPropertyName("policyMember")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderPolicyGroupPolicyMember>? PolicyMember { get; set; }

    /// <summary>The priority for the Virtual Network Gateway Policy Group. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values are DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values are GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values are ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel. Possible values are between 1024 and 2147483647.</summary>
    [JsonPropertyName("saDataSizeInKilobytes")]
    public double? SaDataSizeInKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel. Possible values are between 300 and 172799.</summary>
    [JsonPropertyName("saLifetimeInSeconds")]
    public double? SaLifetimeInSeconds { get; set; }
}

/// <summary>The secret that is used to communicate with the Radius Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRadiusServerSecretSecretRef
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRadiusServer
{
    /// <summary>The address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The score of the Radius Server determines the priority of the server. Possible values are between 1 and 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }

    /// <summary>The secret that is used to communicate with the Radius Server.</summary>
    [JsonPropertyName("secretSecretRef")]
    public required V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRadiusServerSecretSecretRef SecretSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRevokedCertificate
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the public data of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRootCertificate
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The public certificate of the root certificate authority. The certificate must be provided in Base-64 encoded X.509 format (PEM). In particular, this argument must not include the -----BEGIN CERTIFICATE----- or -----END CERTIFICATE----- markers, nor any newlines.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationVirtualNetworkGatewayClientConnection
{
    /// <summary>A list of address prefixes for P2S VPN Client.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of names of Virtual Network Gateway Policy Groups.</summary>
    [JsonPropertyName("policyGroupNames")]
    public IList<string>? PolicyGroupNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfiguration
{
    /// <summary>
    /// The client id of the Azure VPN application.
    /// See Create an Active Directory (AD) tenant for P2S OpenVPN protocol connections for values
    /// </summary>
    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    /// <summary>The STS url for your tenant</summary>
    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    /// <summary>AzureAD Tenant URL</summary>
    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    /// <summary>The address space out of which IP addresses for vpn clients will be taken. You can provide more than one address space, e.g. in CIDR notation.</summary>
    [JsonPropertyName("addressSpace")]
    public IList<string>? AddressSpace { get; set; }

    /// <summary>An ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>One or more radius_server blocks as defined below.</summary>
    [JsonPropertyName("radiusServer")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRadiusServer>? RadiusServer { get; set; }

    /// <summary>The address of the Radius server.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>The secret used by the Radius server.</summary>
    [JsonPropertyName("radiusServerSecret")]
    public string? RadiusServerSecret { get; set; }

    /// <summary>One or more revoked_certificate blocks which are defined below.</summary>
    [JsonPropertyName("revokedCertificate")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRevokedCertificate>? RevokedCertificate { get; set; }

    /// <summary>One or more root_certificate blocks which are defined below. These root certificates are used to sign the client certificate used by the VPN clients to connect to the gateway.</summary>
    [JsonPropertyName("rootCertificate")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationRootCertificate>? RootCertificate { get; set; }

    /// <summary>One or more virtual_network_gateway_client_connection blocks as defined below.</summary>
    [JsonPropertyName("virtualNetworkGatewayClientConnection")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfigurationVirtualNetworkGatewayClientConnection>? VirtualNetworkGatewayClientConnection { get; set; }

    /// <summary>
    /// List of the vpn authentication types for the virtual network gateway.
    /// The supported values are AAD, Radius and Certificate.
    /// </summary>
    [JsonPropertyName("vpnAuthTypes")]
    public IList<string>? VpnAuthTypes { get; set; }

    /// <summary>
    /// List of the protocols supported by the vpn client.
    /// The supported values are SSTP, IkeV2 and OpenVPN.
    /// Values SSTP and IkeV2 are incompatible with the use of
    /// aad_tenant, aad_audience and aad_issuer.
    /// </summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecInitProvider
{
    /// <summary>If true, an active-active Virtual Network Gateway will be created. An active-active gateway requires a HighPerformance or an UltraPerformance SKU. If false, an active-standby gateway will be created. Defaults to false.</summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>Is BGP Route Translation for NAT enabled? Defaults to false.</summary>
    [JsonPropertyName("bgpRouteTranslationForNatEnabled")]
    public bool? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>A bgp_settings block which is documented below. In this block the BGP specific settings can be defined.</summary>
    [JsonPropertyName("bgpSettings")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderBgpSettings>? BgpSettings { get; set; }

    /// <summary>A custom_route block as defined below. Specifies a custom routes address space for a virtual network gateway and a VpnClient.</summary>
    [JsonPropertyName("customRoute")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderCustomRoute>? CustomRoute { get; set; }

    /// <summary>The ID of the local network gateway through which outbound Internet traffic from the virtual network in which the gateway is created will be routed (forced tunnelling). Refer to the Azure documentation on forced tunnelling. If not specified, forced tunnelling is disabled.</summary>
    [JsonPropertyName("defaultLocalNetworkGatewayId")]
    public string? DefaultLocalNetworkGatewayId { get; set; }

    /// <summary>Is DNS forwarding enabled?</summary>
    [JsonPropertyName("dnsForwardingEnabled")]
    public bool? DnsForwardingEnabled { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Virtual Network Gateway should exist. Changing this forces a new Virtual Network Gateway to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) will be enabled for this Virtual Network Gateway. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The Generation of the Virtual Network gateway. Possible values include Generation1, Generation2 or None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>
    /// One or more (up to 3) ip_configuration blocks documented below.
    /// An active-standby gateway requires exactly one ip_configuration block,
    /// an active-active gateway requires exactly two ip_configuration blocks whereas
    /// an active-active zone redundant gateway with P2S configuration requires exactly three ip_configuration blocks.
    /// </summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>Is IP Sec Replay Protection enabled? Defaults to true.</summary>
    [JsonPropertyName("ipSecReplayProtectionEnabled")]
    public bool? IpSecReplayProtectionEnabled { get; set; }

    /// <summary>The location/region where the Virtual Network Gateway is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more policy_group blocks as defined below.</summary>
    [JsonPropertyName("policyGroup")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderPolicyGroup>? PolicyGroup { get; set; }

    /// <summary>Should private IP be enabled on this gateway for connections? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateIpAddressEnabled")]
    public bool? PrivateIpAddressEnabled { get; set; }

    /// <summary>Is remote vnet traffic that is used to configure this gateway to accept traffic from other Azure Virtual Networks enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteVnetTrafficEnabled")]
    public bool? RemoteVnetTrafficEnabled { get; set; }

    /// <summary>Configuration of the size and capacity of the virtual network gateway. Valid options are Basic, Standard, HighPerformance, UltraPerformance, ErGw1AZ, ErGw2AZ, ErGw3AZ, VpnGw1, VpnGw2, VpnGw3, VpnGw4,VpnGw5, VpnGw1AZ, VpnGw2AZ, VpnGw3AZ,VpnGw4AZ and VpnGw5AZ and depend on the type, vpn_type and generation arguments. A PolicyBased gateway only supports the Basic SKU. Further, the UltraPerformance SKU is only supported by an ExpressRoute gateway.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the Virtual Network Gateway. Valid options are Vpn or ExpressRoute. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Is remote vnet traffic that is used to configure this gateway to accept traffic from remote Virtual WAN networks enabled? Defaults to false.</summary>
    [JsonPropertyName("virtualWanTrafficEnabled")]
    public bool? VirtualWanTrafficEnabled { get; set; }

    /// <summary>A vpn_client_configuration block which is documented below. In this block the Virtual Network Gateway can be configured to accept IPSec point-to-site connections.</summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public IList<V1beta1VirtualNetworkGatewaySpecInitProviderVpnClientConfiguration>? VpnClientConfiguration { get; set; }

    /// <summary>The routing type of the Virtual Network Gateway. Valid options are RouteBased or PolicyBased. Defaults to RouteBased. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>VirtualNetworkGatewaySpec defines the desired state of VirtualNetworkGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewaySpec
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
    public V1beta1VirtualNetworkGatewaySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1VirtualNetworkGatewaySpecForProvider ForProvider { get; set; }

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
    public V1beta1VirtualNetworkGatewaySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1VirtualNetworkGatewaySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualNetworkGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualNetworkGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderBgpSettingsPeeringAddresses
{
    /// <summary>A list of Azure custom APIPA addresses assigned to the BGP peer of the Virtual Network Gateway.</summary>
    [JsonPropertyName("apipaAddresses")]
    public IList<string>? ApipaAddresses { get; set; }

    /// <summary>A list of peering address assigned to the BGP peer of the Virtual Network Gateway.</summary>
    [JsonPropertyName("defaultAddresses")]
    public IList<string>? DefaultAddresses { get; set; }

    /// <summary>The name of the IP configuration of this Virtual Network Gateway. In case there are multiple ip_configuration blocks defined, this property is required to specify.</summary>
    [JsonPropertyName("ipConfigurationName")]
    public string? IpConfigurationName { get; set; }

    /// <summary>A list of tunnel IP addresses assigned to the BGP peer of the Virtual Network Gateway.</summary>
    [JsonPropertyName("tunnelIpAddresses")]
    public IList<string>? TunnelIpAddresses { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderBgpSettings
{
    /// <summary>The Autonomous System Number (ASN) to use as part of the BGP.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The weight added to routes which have been learned through BGP peering. Valid values can be between 0 and 100.</summary>
    [JsonPropertyName("peerWeight")]
    public double? PeerWeight { get; set; }

    /// <summary>A list of peering_addresses blocks as defined below. Only one peering_addresses block can be specified except when active_active of this Virtual Network Gateway is true.</summary>
    [JsonPropertyName("peeringAddresses")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderBgpSettingsPeeringAddresses>? PeeringAddresses { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderCustomRoute
{
    /// <summary>A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderIpConfiguration
{
    /// <summary>A user-defined name of the IP configuration. Defaults to vnetGatewayConfig.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Defines how the private IP address of the gateways virtual interface is assigned. The only valid value is Dynamic for Virtual Network Gateway (Static is not supported by the service yet). Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the public IP address to associate with the Virtual Network Gateway.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>The ID of the gateway subnet of a virtual network in which the virtual network gateway will be created. It is mandatory that the associated subnet is named GatewaySubnet. Therefore, each virtual network can contain at most a single Virtual Network Gateway.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderPolicyGroupPolicyMember
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Virtual Network Gateway. Valid options are Vpn or ExpressRoute. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of attribute that is used for this Virtual Network Gateway Policy Group Member.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderPolicyGroup
{
    /// <summary>Is this a Default Virtual Network Gateway Policy Group? Defaults to false.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The name of the Virtual Network Gateway Policy Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more policy_member blocks as defined below.</summary>
    [JsonPropertyName("policyMember")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderPolicyGroupPolicyMember>? PolicyMember { get; set; }

    /// <summary>The priority for the Virtual Network Gateway Policy Group. Defaults to 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values are DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values are GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values are AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values are GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values are ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel. Possible values are between 1024 and 2147483647.</summary>
    [JsonPropertyName("saDataSizeInKilobytes")]
    public double? SaDataSizeInKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel. Possible values are between 300 and 172799.</summary>
    [JsonPropertyName("saLifetimeInSeconds")]
    public double? SaLifetimeInSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationRadiusServer
{
    /// <summary>The address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The score of the Radius Server determines the priority of the server. Possible values are between 1 and 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationRevokedCertificate
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the public data of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationRootCertificate
{
    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The public certificate of the root certificate authority. The certificate must be provided in Base-64 encoded X.509 format (PEM). In particular, this argument must not include the -----BEGIN CERTIFICATE----- or -----END CERTIFICATE----- markers, nor any newlines.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationVirtualNetworkGatewayClientConnection
{
    /// <summary>A list of address prefixes for P2S VPN Client.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>The name of the Virtual Network Gateway Client Connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of names of Virtual Network Gateway Policy Groups.</summary>
    [JsonPropertyName("policyGroupNames")]
    public IList<string>? PolicyGroupNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfiguration
{
    /// <summary>
    /// The client id of the Azure VPN application.
    /// See Create an Active Directory (AD) tenant for P2S OpenVPN protocol connections for values
    /// </summary>
    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    /// <summary>The STS url for your tenant</summary>
    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    /// <summary>AzureAD Tenant URL</summary>
    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    /// <summary>The address space out of which IP addresses for vpn clients will be taken. You can provide more than one address space, e.g. in CIDR notation.</summary>
    [JsonPropertyName("addressSpace")]
    public IList<string>? AddressSpace { get; set; }

    /// <summary>An ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationIpsecPolicy>? IpsecPolicy { get; set; }

    /// <summary>One or more radius_server blocks as defined below.</summary>
    [JsonPropertyName("radiusServer")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationRadiusServer>? RadiusServer { get; set; }

    /// <summary>The address of the Radius server.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>The secret used by the Radius server.</summary>
    [JsonPropertyName("radiusServerSecret")]
    public string? RadiusServerSecret { get; set; }

    /// <summary>One or more revoked_certificate blocks which are defined below.</summary>
    [JsonPropertyName("revokedCertificate")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationRevokedCertificate>? RevokedCertificate { get; set; }

    /// <summary>One or more root_certificate blocks which are defined below. These root certificates are used to sign the client certificate used by the VPN clients to connect to the gateway.</summary>
    [JsonPropertyName("rootCertificate")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationRootCertificate>? RootCertificate { get; set; }

    /// <summary>One or more virtual_network_gateway_client_connection blocks as defined below.</summary>
    [JsonPropertyName("virtualNetworkGatewayClientConnection")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfigurationVirtualNetworkGatewayClientConnection>? VirtualNetworkGatewayClientConnection { get; set; }

    /// <summary>
    /// List of the vpn authentication types for the virtual network gateway.
    /// The supported values are AAD, Radius and Certificate.
    /// </summary>
    [JsonPropertyName("vpnAuthTypes")]
    public IList<string>? VpnAuthTypes { get; set; }

    /// <summary>
    /// List of the protocols supported by the vpn client.
    /// The supported values are SSTP, IkeV2 and OpenVPN.
    /// Values SSTP and IkeV2 are incompatible with the use of
    /// aad_tenant, aad_audience and aad_issuer.
    /// </summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusAtProvider
{
    /// <summary>If true, an active-active Virtual Network Gateway will be created. An active-active gateway requires a HighPerformance or an UltraPerformance SKU. If false, an active-standby gateway will be created. Defaults to false.</summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>Is BGP Route Translation for NAT enabled? Defaults to false.</summary>
    [JsonPropertyName("bgpRouteTranslationForNatEnabled")]
    public bool? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>A bgp_settings block which is documented below. In this block the BGP specific settings can be defined.</summary>
    [JsonPropertyName("bgpSettings")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderBgpSettings>? BgpSettings { get; set; }

    /// <summary>A custom_route block as defined below. Specifies a custom routes address space for a virtual network gateway and a VpnClient.</summary>
    [JsonPropertyName("customRoute")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderCustomRoute>? CustomRoute { get; set; }

    /// <summary>The ID of the local network gateway through which outbound Internet traffic from the virtual network in which the gateway is created will be routed (forced tunnelling). Refer to the Azure documentation on forced tunnelling. If not specified, forced tunnelling is disabled.</summary>
    [JsonPropertyName("defaultLocalNetworkGatewayId")]
    public string? DefaultLocalNetworkGatewayId { get; set; }

    /// <summary>Is DNS forwarding enabled?</summary>
    [JsonPropertyName("dnsForwardingEnabled")]
    public bool? DnsForwardingEnabled { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Virtual Network Gateway should exist. Changing this forces a new Virtual Network Gateway to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>If true, BGP (Border Gateway Protocol) will be enabled for this Virtual Network Gateway. Defaults to false.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>The Generation of the Virtual Network gateway. Possible values include Generation1, Generation2 or None. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    /// <summary>The ID of the Virtual Network Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// One or more (up to 3) ip_configuration blocks documented below.
    /// An active-standby gateway requires exactly one ip_configuration block,
    /// an active-active gateway requires exactly two ip_configuration blocks whereas
    /// an active-active zone redundant gateway with P2S configuration requires exactly three ip_configuration blocks.
    /// </summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>Is IP Sec Replay Protection enabled? Defaults to true.</summary>
    [JsonPropertyName("ipSecReplayProtectionEnabled")]
    public bool? IpSecReplayProtectionEnabled { get; set; }

    /// <summary>The location/region where the Virtual Network Gateway is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more policy_group blocks as defined below.</summary>
    [JsonPropertyName("policyGroup")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderPolicyGroup>? PolicyGroup { get; set; }

    /// <summary>Should private IP be enabled on this gateway for connections? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateIpAddressEnabled")]
    public bool? PrivateIpAddressEnabled { get; set; }

    /// <summary>Is remote vnet traffic that is used to configure this gateway to accept traffic from other Azure Virtual Networks enabled? Defaults to false.</summary>
    [JsonPropertyName("remoteVnetTrafficEnabled")]
    public bool? RemoteVnetTrafficEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Virtual Network Gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Configuration of the size and capacity of the virtual network gateway. Valid options are Basic, Standard, HighPerformance, UltraPerformance, ErGw1AZ, ErGw2AZ, ErGw3AZ, VpnGw1, VpnGw2, VpnGw3, VpnGw4,VpnGw5, VpnGw1AZ, VpnGw2AZ, VpnGw3AZ,VpnGw4AZ and VpnGw5AZ and depend on the type, vpn_type and generation arguments. A PolicyBased gateway only supports the Basic SKU. Further, the UltraPerformance SKU is only supported by an ExpressRoute gateway.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of the Virtual Network Gateway. Valid options are Vpn or ExpressRoute. Changing the type forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Is remote vnet traffic that is used to configure this gateway to accept traffic from remote Virtual WAN networks enabled? Defaults to false.</summary>
    [JsonPropertyName("virtualWanTrafficEnabled")]
    public bool? VirtualWanTrafficEnabled { get; set; }

    /// <summary>A vpn_client_configuration block which is documented below. In this block the Virtual Network Gateway can be configured to accept IPSec point-to-site connections.</summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public IList<V1beta1VirtualNetworkGatewayStatusAtProviderVpnClientConfiguration>? VpnClientConfiguration { get; set; }

    /// <summary>The routing type of the Virtual Network Gateway. Valid options are RouteBased or PolicyBased. Defaults to RouteBased. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatusConditions
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

/// <summary>VirtualNetworkGatewayStatus defines the observed state of VirtualNetworkGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1VirtualNetworkGatewayStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualNetworkGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualNetworkGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// VirtualNetworkGateway is the Schema for the VirtualNetworkGateways API. Manages a virtual network gateway to establish secure, cross-premises connectivity.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualNetworkGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualNetworkGatewaySpec>, IStatus<V1beta1VirtualNetworkGatewayStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualNetworkGateway";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualNetworkGatewaySpec defines the desired state of VirtualNetworkGateway</summary>
    [JsonPropertyName("spec")]
    public required V1beta1VirtualNetworkGatewaySpec Spec { get; set; }

    /// <summary>VirtualNetworkGatewayStatus defines the observed state of VirtualNetworkGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualNetworkGatewayStatus? Status { get; set; }
}