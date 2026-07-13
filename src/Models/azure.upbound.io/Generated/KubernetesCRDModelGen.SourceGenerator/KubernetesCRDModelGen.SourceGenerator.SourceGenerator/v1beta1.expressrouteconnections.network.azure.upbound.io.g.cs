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
/// ExpressRouteConnection is the Schema for the ExpressRouteConnections API. Manages an Express Route Connection.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExpressRouteConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ExpressRouteConnection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRouteConnectionList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressrouteconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExpressRouteConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ExpressRouteConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ExpressRouteConnection> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicyResolveEnum
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
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicyResolveEnum
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
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelector
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
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicyResolveEnum
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
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ExpressRouteGateway in network to populate expressRouteGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicyResolveEnum
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
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ExpressRouteGateway in network to populate expressRouteGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelector
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
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecForProviderRoutingPropagatedRouteTable
{
    /// <summary>The list of labels to logically group route tables.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of IDs of the Virtual Hub Route Table to propagate routes from Express Route Connection to the route table.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecForProviderRouting
{
    /// <summary>The ID of the Virtual Hub Route Table associated with this Express Route Connection.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>The ID of the Route Map associated with this Express Route Connection for inbound routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The ID of the Route Map associated with this Express Route Connection for outbound routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1ExpressRouteConnectionSpecForProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecForProvider
{
    /// <summary>The authorization key to establish the Express Route Connection.</summary>
    [JsonPropertyName("authorizationKey")]
    public string? AuthorizationKey { get; set; }

    /// <summary>Is Internet security enabled for this Express Route Connection?</summary>
    [JsonPropertyName("enableInternetSecurity")]
    public bool? EnableInternetSecurity { get; set; }

    /// <summary>The ID of the Express Route Circuit Peering that this Express Route Connection connects with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitPeeringId")]
    public string? ExpressRouteCircuitPeeringId { get; set; }

    /// <summary>Reference to a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
    [JsonPropertyName("expressRouteCircuitPeeringIdRef")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdRef? ExpressRouteCircuitPeeringIdRef { get; set; }

    /// <summary>Selector for a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
    [JsonPropertyName("expressRouteCircuitPeeringIdSelector")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteCircuitPeeringIdSelector? ExpressRouteCircuitPeeringIdSelector { get; set; }

    /// <summary>Specified whether Fast Path is enabled for Virtual Wan Firewall Hub. Defaults to false.</summary>
    [JsonPropertyName("expressRouteGatewayBypassEnabled")]
    public bool? ExpressRouteGatewayBypassEnabled { get; set; }

    /// <summary>The ID of the Express Route Gateway that this Express Route Connection connects with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteGatewayId")]
    public string? ExpressRouteGatewayId { get; set; }

    /// <summary>Reference to a ExpressRouteGateway in network to populate expressRouteGatewayId.</summary>
    [JsonPropertyName("expressRouteGatewayIdRef")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdRef? ExpressRouteGatewayIdRef { get; set; }

    /// <summary>Selector for a ExpressRouteGateway in network to populate expressRouteGatewayId.</summary>
    [JsonPropertyName("expressRouteGatewayIdSelector")]
    public V1beta1ExpressRouteConnectionSpecForProviderExpressRouteGatewayIdSelector? ExpressRouteGatewayIdSelector { get; set; }

    /// <summary>Bypass the Express Route gateway when accessing private-links. When enabled express_route_gateway_bypass_enabled must be set to true. Defaults to false.</summary>
    [JsonPropertyName("privateLinkFastPathEnabled")]
    public bool? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1ExpressRouteConnectionSpecForProviderRouting>? Routing { get; set; }

    /// <summary>The routing weight associated to the Express Route Connection. Possible value is between 0 and 32000. Defaults to 0.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicyResolveEnum
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
public partial class V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicyResolveEnum
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
public partial class V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelector
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
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecInitProviderRoutingPropagatedRouteTable
{
    /// <summary>The list of labels to logically group route tables.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of IDs of the Virtual Hub Route Table to propagate routes from Express Route Connection to the route table.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecInitProviderRouting
{
    /// <summary>The ID of the Virtual Hub Route Table associated with this Express Route Connection.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>The ID of the Route Map associated with this Express Route Connection for inbound routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The ID of the Route Map associated with this Express Route Connection for outbound routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1ExpressRouteConnectionSpecInitProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }
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
public partial class V1beta1ExpressRouteConnectionSpecInitProvider
{
    /// <summary>The authorization key to establish the Express Route Connection.</summary>
    [JsonPropertyName("authorizationKey")]
    public string? AuthorizationKey { get; set; }

    /// <summary>Is Internet security enabled for this Express Route Connection?</summary>
    [JsonPropertyName("enableInternetSecurity")]
    public bool? EnableInternetSecurity { get; set; }

    /// <summary>The ID of the Express Route Circuit Peering that this Express Route Connection connects with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitPeeringId")]
    public string? ExpressRouteCircuitPeeringId { get; set; }

    /// <summary>Reference to a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
    [JsonPropertyName("expressRouteCircuitPeeringIdRef")]
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdRef? ExpressRouteCircuitPeeringIdRef { get; set; }

    /// <summary>Selector for a ExpressRouteCircuitPeering in network to populate expressRouteCircuitPeeringId.</summary>
    [JsonPropertyName("expressRouteCircuitPeeringIdSelector")]
    public V1beta1ExpressRouteConnectionSpecInitProviderExpressRouteCircuitPeeringIdSelector? ExpressRouteCircuitPeeringIdSelector { get; set; }

    /// <summary>Specified whether Fast Path is enabled for Virtual Wan Firewall Hub. Defaults to false.</summary>
    [JsonPropertyName("expressRouteGatewayBypassEnabled")]
    public bool? ExpressRouteGatewayBypassEnabled { get; set; }

    /// <summary>Bypass the Express Route gateway when accessing private-links. When enabled express_route_gateway_bypass_enabled must be set to true. Defaults to false.</summary>
    [JsonPropertyName("privateLinkFastPathEnabled")]
    public bool? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1ExpressRouteConnectionSpecInitProviderRouting>? Routing { get; set; }

    /// <summary>The routing weight associated to the Express Route Connection. Possible value is between 0 and 32000. Defaults to 0.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
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
public partial class V1beta1ExpressRouteConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ExpressRouteConnectionSpec defines the desired state of ExpressRouteConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionSpec
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
    public V1beta1ExpressRouteConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ExpressRouteConnectionSpecForProvider ForProvider { get; set; }

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
    public V1beta1ExpressRouteConnectionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ExpressRouteConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ExpressRouteConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ExpressRouteConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionStatusAtProviderRoutingPropagatedRouteTable
{
    /// <summary>The list of labels to logically group route tables.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>A list of IDs of the Virtual Hub Route Table to propagate routes from Express Route Connection to the route table.</summary>
    [JsonPropertyName("routeTableIds")]
    public IList<string>? RouteTableIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionStatusAtProviderRouting
{
    /// <summary>The ID of the Virtual Hub Route Table associated with this Express Route Connection.</summary>
    [JsonPropertyName("associatedRouteTableId")]
    public string? AssociatedRouteTableId { get; set; }

    /// <summary>The ID of the Route Map associated with this Express Route Connection for inbound routes.</summary>
    [JsonPropertyName("inboundRouteMapId")]
    public string? InboundRouteMapId { get; set; }

    /// <summary>The ID of the Route Map associated with this Express Route Connection for outbound routes.</summary>
    [JsonPropertyName("outboundRouteMapId")]
    public string? OutboundRouteMapId { get; set; }

    /// <summary>A propagated_route_table block as defined below.</summary>
    [JsonPropertyName("propagatedRouteTable")]
    public IList<V1beta1ExpressRouteConnectionStatusAtProviderRoutingPropagatedRouteTable>? PropagatedRouteTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionStatusAtProvider
{
    /// <summary>The authorization key to establish the Express Route Connection.</summary>
    [JsonPropertyName("authorizationKey")]
    public string? AuthorizationKey { get; set; }

    /// <summary>Is Internet security enabled for this Express Route Connection?</summary>
    [JsonPropertyName("enableInternetSecurity")]
    public bool? EnableInternetSecurity { get; set; }

    /// <summary>The ID of the Express Route Circuit Peering that this Express Route Connection connects with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitPeeringId")]
    public string? ExpressRouteCircuitPeeringId { get; set; }

    /// <summary>Specified whether Fast Path is enabled for Virtual Wan Firewall Hub. Defaults to false.</summary>
    [JsonPropertyName("expressRouteGatewayBypassEnabled")]
    public bool? ExpressRouteGatewayBypassEnabled { get; set; }

    /// <summary>The ID of the Express Route Gateway that this Express Route Connection connects with. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteGatewayId")]
    public string? ExpressRouteGatewayId { get; set; }

    /// <summary>The ID of the Express Route Connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Bypass the Express Route gateway when accessing private-links. When enabled express_route_gateway_bypass_enabled must be set to true. Defaults to false.</summary>
    [JsonPropertyName("privateLinkFastPathEnabled")]
    public bool? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>A routing block as defined below.</summary>
    [JsonPropertyName("routing")]
    public IList<V1beta1ExpressRouteConnectionStatusAtProviderRouting>? Routing { get; set; }

    /// <summary>The routing weight associated to the Express Route Connection. Possible value is between 0 and 32000. Defaults to 0.</summary>
    [JsonPropertyName("routingWeight")]
    public double? RoutingWeight { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionStatusConditions
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

/// <summary>ExpressRouteConnectionStatus defines the observed state of ExpressRouteConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRouteConnectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ExpressRouteConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ExpressRouteConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// ExpressRouteConnection is the Schema for the ExpressRouteConnections API. Manages an Express Route Connection.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExpressRouteConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ExpressRouteConnectionSpec>, IStatus<V1beta1ExpressRouteConnectionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRouteConnection";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressrouteconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExpressRouteConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExpressRouteConnectionSpec defines the desired state of ExpressRouteConnection</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ExpressRouteConnectionSpec Spec { get; set; }

    /// <summary>ExpressRouteConnectionStatus defines the observed state of ExpressRouteConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1ExpressRouteConnectionStatus? Status { get; set; }
}