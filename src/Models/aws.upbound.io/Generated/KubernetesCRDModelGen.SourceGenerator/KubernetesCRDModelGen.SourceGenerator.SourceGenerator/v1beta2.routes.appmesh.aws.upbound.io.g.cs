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
/// <summary>Route is the Schema for the Routes API. Provides an AWS App Mesh route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RouteList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Route>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RouteList";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "routes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RouteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Route objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Route> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecDeletionPolicyEnum>))]
public enum V1beta2RouteSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderMeshNameRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderMeshNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderMeshNameRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderMeshNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderMeshNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderMeshNameSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderMeshNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderMeshNameSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderMeshNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderMeshNameSelector
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
    public V1beta2RouteSpecForProviderMeshNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecForProviderSpecGrpcRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteMatchMetadataMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteMatchMetadataMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteMatchMetadataMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteMatchMetadata
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteMatchMetadataMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteMatch
{
    /// <summary>Data to match from the gRPC request.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta2RouteSpecForProviderSpecGrpcRouteMatchMetadata>? Metadata { get; set; }

    /// <summary>Method name to match from the request. If you specify a name, you must also specify a service_name.</summary>
    [JsonPropertyName("methodName")]
    public string? MethodName { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteRetryPolicy
{
    /// <summary>
    /// List of gRPC retry events.
    /// Valid values: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.
    /// </summary>
    [JsonPropertyName("grpcRetryEvents")]
    public IList<string>? GrpcRetryEvents { get; set; }

    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>GRPC routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecForProviderSpecGrpcRouteTimeout? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecForProviderSpecHttp2RouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2RouteSpecForProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2RouteSpecForProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteRetryPolicy
{
    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2RouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>HTTP/2 routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecForProviderSpecHttp2RouteTimeout? Timeout { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecForProviderSpecHttpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2RouteSpecForProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta2RouteSpecForProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2RouteSpecForProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteRetryPolicy
{
    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteSpecForProviderSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecForProviderSpecHttpRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteSpecForProviderSpecHttpRouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>HTTP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecForProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecHttpRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteSpecForProviderSpecHttpRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecForProviderSpecHttpRouteTimeout? Timeout { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecForProviderSpecTcpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteMatch
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecForProviderSpecTcpRouteTimeoutIdle? Idle { get; set; }
}

/// <summary>TCP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpecTcpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecForProviderSpecTcpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecForProviderSpecTcpRouteMatch? Match { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecForProviderSpecTcpRouteTimeout? Timeout { get; set; }
}

/// <summary>Route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderSpec
{
    /// <summary>GRPC routing information for the route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta2RouteSpecForProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>HTTP/2 routing information for the route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta2RouteSpecForProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>HTTP routing information for the route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta2RouteSpecForProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>
    /// Priority for the route, between 0 and 1000.
    /// Routes are matched based on the specified value, where 0 is the highest priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>TCP routing information for the route.</summary>
    [JsonPropertyName("tcpRoute")]
    public V1beta2RouteSpecForProviderSpecTcpRoute? TcpRoute { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVirtualRouterNameRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderVirtualRouterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVirtualRouterNameRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderVirtualRouterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderVirtualRouterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderVirtualRouterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderVirtualRouterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderVirtualRouterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecForProviderVirtualRouterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProviderVirtualRouterNameSelector
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
    public V1beta2RouteSpecForProviderVirtualRouterNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecForProvider
{
    /// <summary>Name of the service mesh in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta2RouteSpecForProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta2RouteSpecForProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2RouteSpecForProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual router in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }

    /// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameRef")]
    public V1beta2RouteSpecForProviderVirtualRouterNameRef? VirtualRouterNameRef { get; set; }

    /// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameSelector")]
    public V1beta2RouteSpecForProviderVirtualRouterNameSelector? VirtualRouterNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderMeshNameRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderMeshNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderMeshNameRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderMeshNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderMeshNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderMeshNameSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderMeshNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderMeshNameSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderMeshNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderMeshNameSelector
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
    public V1beta2RouteSpecInitProviderMeshNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecInitProviderSpecGrpcRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteMatchMetadata
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteMatch
{
    /// <summary>Data to match from the gRPC request.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta2RouteSpecInitProviderSpecGrpcRouteMatchMetadata>? Metadata { get; set; }

    /// <summary>Method name to match from the request. If you specify a name, you must also specify a service_name.</summary>
    [JsonPropertyName("methodName")]
    public string? MethodName { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteRetryPolicy
{
    /// <summary>
    /// List of gRPC retry events.
    /// Valid values: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.
    /// </summary>
    [JsonPropertyName("grpcRetryEvents")]
    public IList<string>? GrpcRetryEvents { get; set; }

    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>GRPC routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecInitProviderSpecGrpcRouteTimeout? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecInitProviderSpecHttp2RouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2RouteSpecInitProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2RouteSpecInitProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteRetryPolicy
{
    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2RouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>HTTP/2 routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecInitProviderSpecHttp2RouteTimeout? Timeout { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecInitProviderSpecHttpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2RouteSpecInitProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2RouteSpecInitProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteRetryPolicy
{
    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>HTTP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecInitProviderSpecHttpRouteTimeout? Timeout { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteSpecInitProviderSpecTcpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteMatch
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteTimeoutIdle? Idle { get; set; }
}

/// <summary>TCP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpecTcpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteMatch? Match { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteSpecInitProviderSpecTcpRouteTimeout? Timeout { get; set; }
}

/// <summary>Route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderSpec
{
    /// <summary>GRPC routing information for the route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta2RouteSpecInitProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>HTTP/2 routing information for the route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta2RouteSpecInitProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>HTTP routing information for the route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta2RouteSpecInitProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>
    /// Priority for the route, between 0 and 1000.
    /// Routes are matched based on the specified value, where 0 is the highest priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>TCP routing information for the route.</summary>
    [JsonPropertyName("tcpRoute")]
    public V1beta2RouteSpecInitProviderSpecTcpRoute? TcpRoute { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderVirtualRouterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecInitProviderVirtualRouterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicyResolveEnum>))]
public enum V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecInitProviderVirtualRouterNameSelector
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
    public V1beta2RouteSpecInitProviderVirtualRouterNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RouteSpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta2RouteSpecInitProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta2RouteSpecInitProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2RouteSpecInitProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual router in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }

    /// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameRef")]
    public V1beta2RouteSpecInitProviderVirtualRouterNameRef? VirtualRouterNameRef { get; set; }

    /// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameSelector")]
    public V1beta2RouteSpecInitProviderVirtualRouterNameSelector? VirtualRouterNameSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecManagementPoliciesEnum>))]
public enum V1beta2RouteSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RouteSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RouteSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RouteSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RouteSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RouteSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RouteSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RouteSpec defines the desired state of Route</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteSpec
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
    public V1beta2RouteSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RouteSpecForProvider ForProvider { get; set; }

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
    public V1beta2RouteSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RouteSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteStatusAtProviderSpecGrpcRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteMatchMetadata
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteMatch
{
    /// <summary>Data to match from the gRPC request.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta2RouteStatusAtProviderSpecGrpcRouteMatchMetadata>? Metadata { get; set; }

    /// <summary>Method name to match from the request. If you specify a name, you must also specify a service_name.</summary>
    [JsonPropertyName("methodName")]
    public string? MethodName { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteRetryPolicy
{
    /// <summary>
    /// List of gRPC retry events.
    /// Valid values: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.
    /// </summary>
    [JsonPropertyName("grpcRetryEvents")]
    public IList<string>? GrpcRetryEvents { get; set; }

    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>GRPC routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteStatusAtProviderSpecGrpcRouteTimeout? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteStatusAtProviderSpecHttp2RouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2RouteStatusAtProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2RouteStatusAtProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteRetryPolicy
{
    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2RouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>HTTP/2 routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteStatusAtProviderSpecHttp2RouteTimeout? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteStatusAtProviderSpecHttpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2RouteStatusAtProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta2RouteStatusAtProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteRetryPolicy
{
    /// <summary>
    /// List of HTTP retry events.
    /// Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).
    /// </summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteTimeoutPerRequest? PerRequest { get; set; }
}

/// <summary>HTTP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteStatusAtProviderSpecHttpRouteTimeout? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecTcpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecTcpRouteAction
{
    /// <summary>
    /// Targets that traffic is routed to when a request matches the route.
    /// You can specify one or more targets and their relative weights with which to distribute traffic.
    /// </summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta2RouteStatusAtProviderSpecTcpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}

/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecTcpRouteMatch
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecTcpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecTcpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2RouteStatusAtProviderSpecTcpRouteTimeoutIdle? Idle { get; set; }
}

/// <summary>TCP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpecTcpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta2RouteStatusAtProviderSpecTcpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta2RouteStatusAtProviderSpecTcpRouteMatch? Match { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2RouteStatusAtProviderSpecTcpRouteTimeout? Timeout { get; set; }
}

/// <summary>Route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProviderSpec
{
    /// <summary>GRPC routing information for the route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta2RouteStatusAtProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>HTTP/2 routing information for the route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta2RouteStatusAtProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>HTTP routing information for the route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta2RouteStatusAtProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>
    /// Priority for the route, between 0 and 1000.
    /// Routes are matched based on the specified value, where 0 is the highest priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>TCP routing information for the route.</summary>
    [JsonPropertyName("tcpRoute")]
    public V1beta2RouteStatusAtProviderSpecTcpRoute? TcpRoute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusAtProvider
{
    /// <summary>ARN of the route.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the route.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the route.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the route.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
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

    /// <summary>Route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2RouteStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Name of the virtual router in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatusConditions
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

/// <summary>RouteStatus defines the observed state of Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RouteStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RouteStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Route is the Schema for the Routes API. Provides an AWS App Mesh route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Route : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RouteSpec>, IStatus<V1beta2RouteStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Route";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "routes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Route";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RouteSpec defines the desired state of Route</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RouteSpec Spec { get; set; }

    /// <summary>RouteStatus defines the observed state of Route.</summary>
    [JsonPropertyName("status")]
    public V1beta2RouteStatus? Status { get; set; }
}