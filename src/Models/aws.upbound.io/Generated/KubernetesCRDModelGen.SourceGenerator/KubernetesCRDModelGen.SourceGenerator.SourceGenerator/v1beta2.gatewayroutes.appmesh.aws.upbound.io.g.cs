#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.upbound.io;
/// <summary>GatewayRoute is the Schema for the GatewayRoutes API. Provides an AWS App Mesh gateway route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2GatewayRouteList : IKubernetesObject<V1ListMeta>, IItems<V1beta2GatewayRoute>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "GatewayRouteList";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "gatewayroutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayRouteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2GatewayRoute objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2GatewayRoute> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecDeletionPolicyEnum>))]
public enum V1beta2GatewayRouteSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecGrpcRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecGrpcRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteSpecForProviderSpecGrpcRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecGrpcRouteAction
{
    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteSpecForProviderSpecGrpcRouteActionTarget? Target { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecGrpcRouteMatch
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Specification of a gRPC gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteSpecForProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecForProviderSpecGrpcRouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP/2 gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2RouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector
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
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }

    /// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameRef")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef? VirtualServiceNameRef { get; set; }

    /// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameSelector")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector? VirtualServiceNameSelector { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRouteMatch? Match { get; set; }
}

/// <summary>Gateway route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderSpec
{
    /// <summary>Specification of a gRPC gateway route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta2GatewayRouteSpecForProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>Specification of an HTTP/2 gateway route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta2GatewayRouteSpecForProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>Specification of an HTTP gateway route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta2GatewayRouteSpecForProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the gateway route, between 0 and 1000.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelector
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
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecForProvider
{
    /// <summary>Name of the service mesh in which to create the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Gateway route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2GatewayRouteSpecForProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual gateway to associate the gateway route with. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualGatewayName")]
    public string? VirtualGatewayName { get; set; }

    /// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameRef")]
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameRef? VirtualGatewayNameRef { get; set; }

    /// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameSelector")]
    public V1beta2GatewayRouteSpecForProviderVirtualGatewayNameSelector? VirtualGatewayNameSelector { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteAction
{
    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteActionTarget? Target { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteMatch
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Specification of a gRPC gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecInitProviderSpecGrpcRouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP/2 gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2RouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector
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
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }

    /// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameRef")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef? VirtualServiceNameRef { get; set; }

    /// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameSelector")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector? VirtualServiceNameSelector { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRouteMatch? Match { get; set; }
}

/// <summary>Gateway route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderSpec
{
    /// <summary>Specification of a gRPC gateway route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta2GatewayRouteSpecInitProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>Specification of an HTTP/2 gateway route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>Specification of an HTTP gateway route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta2GatewayRouteSpecInitProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the gateway route, between 0 and 1000.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelector
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
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2GatewayRouteSpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gateway route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2GatewayRouteSpecInitProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual gateway to associate the gateway route with. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualGatewayName")]
    public string? VirtualGatewayName { get; set; }

    /// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameRef")]
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameRef? VirtualGatewayNameRef { get; set; }

    /// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameSelector")]
    public V1beta2GatewayRouteSpecInitProviderVirtualGatewayNameSelector? VirtualGatewayNameSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecManagementPoliciesEnum>))]
public enum V1beta2GatewayRouteSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2GatewayRouteSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GatewayRouteSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2GatewayRouteSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GatewayRouteSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GatewayRouteSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GatewayRouteSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>GatewayRouteSpec defines the desired state of GatewayRoute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteSpec
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
    public V1beta2GatewayRouteSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2GatewayRouteSpecForProvider ForProvider { get; set; }

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
    public V1beta2GatewayRouteSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2GatewayRouteSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2GatewayRouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2GatewayRouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteAction
{
    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteActionTarget? Target { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteMatch
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Specification of a gRPC gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteStatusAtProviderSpecGrpcRouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP/2 gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2RouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRouteMatch? Match { get; set; }
}

/// <summary>Gateway route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProviderSpec
{
    /// <summary>Specification of a gRPC gateway route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta2GatewayRouteStatusAtProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>Specification of an HTTP/2 gateway route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>Specification of an HTTP gateway route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta2GatewayRouteStatusAtProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the gateway route, between 0 and 1000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusAtProvider
{
    /// <summary>ARN of the gateway route.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the gateway route.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the gateway route.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the gateway route.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource owner&apos;s AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Gateway route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2GatewayRouteStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Name of the virtual gateway to associate the gateway route with. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualGatewayName")]
    public string? VirtualGatewayName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatusConditions
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

/// <summary>GatewayRouteStatus defines the observed state of GatewayRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GatewayRouteStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2GatewayRouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2GatewayRouteStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GatewayRoute is the Schema for the GatewayRoutes API. Provides an AWS App Mesh gateway route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2GatewayRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2GatewayRouteSpec>, IStatus<V1beta2GatewayRouteStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "GatewayRoute";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "gatewayroutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayRoute";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GatewayRouteSpec defines the desired state of GatewayRoute</summary>
    [JsonPropertyName("spec")]
    public required V1beta2GatewayRouteSpec Spec { get; set; }

    /// <summary>GatewayRouteStatus defines the observed state of GatewayRoute.</summary>
    [JsonPropertyName("status")]
    public V1beta2GatewayRouteStatus? Status { get; set; }
}