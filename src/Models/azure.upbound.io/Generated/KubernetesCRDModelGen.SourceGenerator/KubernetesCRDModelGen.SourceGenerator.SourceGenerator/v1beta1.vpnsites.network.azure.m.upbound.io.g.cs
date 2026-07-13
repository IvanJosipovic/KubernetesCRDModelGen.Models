#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>VPNSite is the Schema for the VPNSites API. Manages a VPN Site.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNSiteList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPNSite>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNSiteList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "vpnsites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPNSiteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1VPNSite objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1VPNSite> Items { get; set; }
}

/// <summary>A bgp block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderLinkBgp
{
    /// <summary>The BGP speaker&apos;s ASN.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The BGP peering IP address.</summary>
    [JsonPropertyName("peeringAddress")]
    public string? PeeringAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderLink
{
    /// <summary>A bgp block as defined above.</summary>
    [JsonPropertyName("bgp")]
    public V1beta1VPNSiteSpecForProviderLinkBgp? Bgp { get; set; }

    /// <summary>The FQDN of this VPN Site Link.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The IP address of this VPN Site Link.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this VPN Site Link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the physical link at the VPN Site. Example: ATT, Verizon.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The speed of the VPN device at the branch location in unit of mbps. Defaults to 0.</summary>
    [JsonPropertyName("speedInMbps")]
    public double? SpeedInMbps { get; set; }
}

/// <summary>A traffic_category block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderO365PolicyTrafficCategory
{
    /// <summary>Is allow endpoint enabled? The Allow endpoint is required for connectivity to specific O365 services and features, but are not as sensitive to network performance and latency as other endpoint types. Defaults to false.</summary>
    [JsonPropertyName("allowEndpointEnabled")]
    public bool? AllowEndpointEnabled { get; set; }

    /// <summary>Is default endpoint enabled? The Default endpoint represents O365 services and dependencies that do not require any optimization, and can be treated by customer networks as normal Internet bound traffic. Defaults to false.</summary>
    [JsonPropertyName("defaultEndpointEnabled")]
    public bool? DefaultEndpointEnabled { get; set; }

    /// <summary>Is optimize endpoint enabled? The Optimize endpoint is required for connectivity to every O365 service and represents the O365 scenario that is the most sensitive to network performance, latency, and availability. Defaults to false.</summary>
    [JsonPropertyName("optimizeEndpointEnabled")]
    public bool? OptimizeEndpointEnabled { get; set; }
}

/// <summary>An o365_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderO365Policy
{
    /// <summary>A traffic_category block as defined above.</summary>
    [JsonPropertyName("trafficCategory")]
    public V1beta1VPNSiteSpecForProviderO365PolicyTrafficCategory? TrafficCategory { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolutionEnum>))]
public enum V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolveEnum>))]
public enum V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolutionEnum>))]
public enum V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolveEnum>))]
public enum V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecForProvider
{
    /// <summary>Specifies a list of IP address CIDRs that are located on your on-premises site. Traffic destined for these address spaces is routed to your local site.</summary>
    [JsonPropertyName("addressCidrs")]
    public IList<string>? AddressCidrs { get; set; }

    /// <summary>The model of the VPN device.</summary>
    [JsonPropertyName("deviceModel")]
    public string? DeviceModel { get; set; }

    /// <summary>The name of the VPN device vendor.</summary>
    [JsonPropertyName("deviceVendor")]
    public string? DeviceVendor { get; set; }

    /// <summary>One or more link blocks as defined below.</summary>
    [JsonPropertyName("link")]
    public IList<V1beta1VPNSiteSpecForProviderLink>? Link { get; set; }

    /// <summary>The Azure Region where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An o365_policy block as defined below.</summary>
    [JsonPropertyName("o365Policy")]
    public V1beta1VPNSiteSpecForProviderO365Policy? O365Policy { get; set; }

    /// <summary>The name of the Resource Group where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the VPN Site.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Wan where this VPN site resides in. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("virtualWanId")]
    public string? VirtualWanId { get; set; }

    /// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdRef")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRef? VirtualWanIdRef { get; set; }

    /// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdSelector")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelector? VirtualWanIdSelector { get; set; }
}

/// <summary>A bgp block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderLinkBgp
{
    /// <summary>The BGP speaker&apos;s ASN.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The BGP peering IP address.</summary>
    [JsonPropertyName("peeringAddress")]
    public string? PeeringAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderLink
{
    /// <summary>A bgp block as defined above.</summary>
    [JsonPropertyName("bgp")]
    public V1beta1VPNSiteSpecInitProviderLinkBgp? Bgp { get; set; }

    /// <summary>The FQDN of this VPN Site Link.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The IP address of this VPN Site Link.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this VPN Site Link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the physical link at the VPN Site. Example: ATT, Verizon.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The speed of the VPN device at the branch location in unit of mbps. Defaults to 0.</summary>
    [JsonPropertyName("speedInMbps")]
    public double? SpeedInMbps { get; set; }
}

/// <summary>A traffic_category block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderO365PolicyTrafficCategory
{
    /// <summary>Is allow endpoint enabled? The Allow endpoint is required for connectivity to specific O365 services and features, but are not as sensitive to network performance and latency as other endpoint types. Defaults to false.</summary>
    [JsonPropertyName("allowEndpointEnabled")]
    public bool? AllowEndpointEnabled { get; set; }

    /// <summary>Is default endpoint enabled? The Default endpoint represents O365 services and dependencies that do not require any optimization, and can be treated by customer networks as normal Internet bound traffic. Defaults to false.</summary>
    [JsonPropertyName("defaultEndpointEnabled")]
    public bool? DefaultEndpointEnabled { get; set; }

    /// <summary>Is optimize endpoint enabled? The Optimize endpoint is required for connectivity to every O365 service and represents the O365 scenario that is the most sensitive to network performance, latency, and availability. Defaults to false.</summary>
    [JsonPropertyName("optimizeEndpointEnabled")]
    public bool? OptimizeEndpointEnabled { get; set; }
}

/// <summary>An o365_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderO365Policy
{
    /// <summary>A traffic_category block as defined above.</summary>
    [JsonPropertyName("trafficCategory")]
    public V1beta1VPNSiteSpecInitProviderO365PolicyTrafficCategory? TrafficCategory { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolutionEnum>))]
public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolveEnum>))]
public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolutionEnum>))]
public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolveEnum>))]
public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1VPNSiteSpecInitProvider
{
    /// <summary>Specifies a list of IP address CIDRs that are located on your on-premises site. Traffic destined for these address spaces is routed to your local site.</summary>
    [JsonPropertyName("addressCidrs")]
    public IList<string>? AddressCidrs { get; set; }

    /// <summary>The model of the VPN device.</summary>
    [JsonPropertyName("deviceModel")]
    public string? DeviceModel { get; set; }

    /// <summary>The name of the VPN device vendor.</summary>
    [JsonPropertyName("deviceVendor")]
    public string? DeviceVendor { get; set; }

    /// <summary>One or more link blocks as defined below.</summary>
    [JsonPropertyName("link")]
    public IList<V1beta1VPNSiteSpecInitProviderLink>? Link { get; set; }

    /// <summary>The Azure Region where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An o365_policy block as defined below.</summary>
    [JsonPropertyName("o365Policy")]
    public V1beta1VPNSiteSpecInitProviderO365Policy? O365Policy { get; set; }

    /// <summary>A mapping of tags which should be assigned to the VPN Site.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Wan where this VPN site resides in. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("virtualWanId")]
    public string? VirtualWanId { get; set; }

    /// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdRef")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRef? VirtualWanIdRef { get; set; }

    /// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdSelector")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelector? VirtualWanIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecManagementPoliciesEnum>))]
public enum V1beta1VPNSiteSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>VPNSiteSpec defines the desired state of VPNSite</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1VPNSiteSpecForProvider ForProvider { get; set; }

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
    public V1beta1VPNSiteSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPNSiteSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNSiteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNSiteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A bgp block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteStatusAtProviderLinkBgp
{
    /// <summary>The BGP speaker&apos;s ASN.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The BGP peering IP address.</summary>
    [JsonPropertyName("peeringAddress")]
    public string? PeeringAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteStatusAtProviderLink
{
    /// <summary>A bgp block as defined above.</summary>
    [JsonPropertyName("bgp")]
    public V1beta1VPNSiteStatusAtProviderLinkBgp? Bgp { get; set; }

    /// <summary>The FQDN of this VPN Site Link.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The ID of the VPN Site Link.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IP address of this VPN Site Link.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this VPN Site Link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the physical link at the VPN Site. Example: ATT, Verizon.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The speed of the VPN device at the branch location in unit of mbps. Defaults to 0.</summary>
    [JsonPropertyName("speedInMbps")]
    public double? SpeedInMbps { get; set; }
}

/// <summary>A traffic_category block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteStatusAtProviderO365PolicyTrafficCategory
{
    /// <summary>Is allow endpoint enabled? The Allow endpoint is required for connectivity to specific O365 services and features, but are not as sensitive to network performance and latency as other endpoint types. Defaults to false.</summary>
    [JsonPropertyName("allowEndpointEnabled")]
    public bool? AllowEndpointEnabled { get; set; }

    /// <summary>Is default endpoint enabled? The Default endpoint represents O365 services and dependencies that do not require any optimization, and can be treated by customer networks as normal Internet bound traffic. Defaults to false.</summary>
    [JsonPropertyName("defaultEndpointEnabled")]
    public bool? DefaultEndpointEnabled { get; set; }

    /// <summary>Is optimize endpoint enabled? The Optimize endpoint is required for connectivity to every O365 service and represents the O365 scenario that is the most sensitive to network performance, latency, and availability. Defaults to false.</summary>
    [JsonPropertyName("optimizeEndpointEnabled")]
    public bool? OptimizeEndpointEnabled { get; set; }
}

/// <summary>An o365_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteStatusAtProviderO365Policy
{
    /// <summary>A traffic_category block as defined above.</summary>
    [JsonPropertyName("trafficCategory")]
    public V1beta1VPNSiteStatusAtProviderO365PolicyTrafficCategory? TrafficCategory { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteStatusAtProvider
{
    /// <summary>Specifies a list of IP address CIDRs that are located on your on-premises site. Traffic destined for these address spaces is routed to your local site.</summary>
    [JsonPropertyName("addressCidrs")]
    public IList<string>? AddressCidrs { get; set; }

    /// <summary>The model of the VPN device.</summary>
    [JsonPropertyName("deviceModel")]
    public string? DeviceModel { get; set; }

    /// <summary>The name of the VPN device vendor.</summary>
    [JsonPropertyName("deviceVendor")]
    public string? DeviceVendor { get; set; }

    /// <summary>The ID of the VPN Site.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more link blocks as defined below.</summary>
    [JsonPropertyName("link")]
    public IList<V1beta1VPNSiteStatusAtProviderLink>? Link { get; set; }

    /// <summary>The Azure Region where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An o365_policy block as defined below.</summary>
    [JsonPropertyName("o365Policy")]
    public V1beta1VPNSiteStatusAtProviderO365Policy? O365Policy { get; set; }

    /// <summary>The name of the Resource Group where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the VPN Site.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Wan where this VPN site resides in. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("virtualWanId")]
    public string? VirtualWanId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteStatusConditions
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

/// <summary>VPNSiteStatus defines the observed state of VPNSite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNSiteStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1VPNSiteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNSiteStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VPNSite is the Schema for the VPNSites API. Manages a VPN Site.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNSite : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNSiteSpec>, IStatus<V1beta1VPNSiteStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNSite";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "vpnsites";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPNSite";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNSiteSpec defines the desired state of VPNSite</summary>
    [JsonPropertyName("spec")]
    public required V1beta1VPNSiteSpec Spec { get; set; }

    /// <summary>VPNSiteStatus defines the observed state of VPNSite.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNSiteStatus? Status { get; set; }
}