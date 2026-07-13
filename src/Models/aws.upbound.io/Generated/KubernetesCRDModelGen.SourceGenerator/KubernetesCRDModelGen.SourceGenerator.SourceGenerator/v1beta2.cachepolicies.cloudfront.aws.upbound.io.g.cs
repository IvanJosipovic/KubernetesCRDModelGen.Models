#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.upbound.io;
/// <summary>CachePolicy is the Schema for the CachePolicys API. Use the</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CachePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2CachePolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CachePolicyList";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "cachepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CachePolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2CachePolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2CachePolicy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CachePolicySpecDeletionPolicyEnum>))]
public enum V1beta2CachePolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for cookie_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
    [JsonPropertyName("cookies")]
    public V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies? Cookies { get; set; }
}

/// <summary>Object contains a list of header names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig
{
    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for header_behavior are none and whitelist.</summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary>Object contains a list of header names. See Items for more information.</summary>
    [JsonPropertyName("headers")]
    public V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders? Headers { get; set; }
}

/// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
{
    /// <summary>Whether URL query strings in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for query_string_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
    [JsonPropertyName("queryStrings")]
    public V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings? QueryStrings { get; set; }
}

/// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOrigin
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig? CookiesConfig { get; set; }

    /// <summary>Flag determines whether the Accept-Encoding HTTP header is included in the cache key and in requests that CloudFront sends to the origin.</summary>
    [JsonPropertyName("enableAcceptEncodingBrotli")]
    public bool? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>Whether the Accept-Encoding HTTP header is included in the cache key and in requests sent to the origin by CloudFront.</summary>
    [JsonPropertyName("enableAcceptEncodingGzip")]
    public bool? EnableAcceptEncodingGzip { get; set; }

    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig? HeadersConfig { get; set; }

    /// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig? QueryStringsConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecForProvider
{
    /// <summary>Description for the cache policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Amount of time, in seconds, that objects are allowed to remain in the CloudFront cache before CloudFront sends a new request to the origin server to check if the object has been updated.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Maximum amount of time, in seconds, that objects stay in the CloudFront cache before CloudFront sends another request to the origin to see if the object has been updated.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time, in seconds, that objects should remain in the CloudFront cache before a new request is sent to the origin to check for updates.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique name used to identify the cache policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
    [JsonPropertyName("parametersInCacheKeyAndForwardedToOrigin")]
    public V1beta2CachePolicySpecForProviderParametersInCacheKeyAndForwardedToOrigin? ParametersInCacheKeyAndForwardedToOrigin { get; set; }
}

/// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for cookie_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
    [JsonPropertyName("cookies")]
    public V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies? Cookies { get; set; }
}

/// <summary>Object contains a list of header names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig
{
    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for header_behavior are none and whitelist.</summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary>Object contains a list of header names. See Items for more information.</summary>
    [JsonPropertyName("headers")]
    public V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders? Headers { get; set; }
}

/// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
{
    /// <summary>Whether URL query strings in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for query_string_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
    [JsonPropertyName("queryStrings")]
    public V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings? QueryStrings { get; set; }
}

/// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOrigin
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig? CookiesConfig { get; set; }

    /// <summary>Flag determines whether the Accept-Encoding HTTP header is included in the cache key and in requests that CloudFront sends to the origin.</summary>
    [JsonPropertyName("enableAcceptEncodingBrotli")]
    public bool? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>Whether the Accept-Encoding HTTP header is included in the cache key and in requests sent to the origin by CloudFront.</summary>
    [JsonPropertyName("enableAcceptEncodingGzip")]
    public bool? EnableAcceptEncodingGzip { get; set; }

    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig? HeadersConfig { get; set; }

    /// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig? QueryStringsConfig { get; set; }
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
public partial class V1beta2CachePolicySpecInitProvider
{
    /// <summary>Description for the cache policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Amount of time, in seconds, that objects are allowed to remain in the CloudFront cache before CloudFront sends a new request to the origin server to check if the object has been updated.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Maximum amount of time, in seconds, that objects stay in the CloudFront cache before CloudFront sends another request to the origin to see if the object has been updated.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time, in seconds, that objects should remain in the CloudFront cache before a new request is sent to the origin to check for updates.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique name used to identify the cache policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
    [JsonPropertyName("parametersInCacheKeyAndForwardedToOrigin")]
    public V1beta2CachePolicySpecInitProviderParametersInCacheKeyAndForwardedToOrigin? ParametersInCacheKeyAndForwardedToOrigin { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CachePolicySpecManagementPoliciesEnum>))]
public enum V1beta2CachePolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CachePolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CachePolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CachePolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CachePolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CachePolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CachePolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CachePolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CachePolicySpec defines the desired state of CachePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicySpec
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
    public V1beta2CachePolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CachePolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2CachePolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CachePolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CachePolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CachePolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for cookie_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary>Object that contains a list of cookie names. See Items for more information.</summary>
    [JsonPropertyName("cookies")]
    public V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies? Cookies { get; set; }
}

/// <summary>Object contains a list of header names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig
{
    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for header_behavior are none and whitelist.</summary>
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary>Object contains a list of header names. See Items for more information.</summary>
    [JsonPropertyName("headers")]
    public V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfigHeaders? Headers { get; set; }
}

/// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings
{
    /// <summary>List of item names, such as cookies, headers, or query strings.</summary>
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig
{
    /// <summary>Whether URL query strings in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. Valid values for query_string_behavior are none, whitelist, allExcept, and all.</summary>
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary>Configuration parameter that contains a list of query string names. See Items for more information.</summary>
    [JsonPropertyName("queryStrings")]
    public V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfigQueryStrings? QueryStrings { get; set; }
}

/// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOrigin
{
    /// <summary>Whether any cookies in viewer requests are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Cookies Config for more information.</summary>
    [JsonPropertyName("cookiesConfig")]
    public V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginCookiesConfig? CookiesConfig { get; set; }

    /// <summary>Flag determines whether the Accept-Encoding HTTP header is included in the cache key and in requests that CloudFront sends to the origin.</summary>
    [JsonPropertyName("enableAcceptEncodingBrotli")]
    public bool? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>Whether the Accept-Encoding HTTP header is included in the cache key and in requests sent to the origin by CloudFront.</summary>
    [JsonPropertyName("enableAcceptEncodingGzip")]
    public bool? EnableAcceptEncodingGzip { get; set; }

    /// <summary>Whether any HTTP headers are included in the cache key and automatically included in requests that CloudFront sends to the origin. See Headers Config for more information.</summary>
    [JsonPropertyName("headersConfig")]
    public V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginHeadersConfig? HeadersConfig { get; set; }

    /// <summary>Whether any URL query strings in viewer requests are included in the cache key. It also automatically includes these query strings in requests that CloudFront sends to the origin. Please refer to the Query String Config for more information.</summary>
    [JsonPropertyName("queryStringsConfig")]
    public V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOriginQueryStringsConfig? QueryStringsConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusAtProvider
{
    /// <summary>The cache policy ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description for the cache policy.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Amount of time, in seconds, that objects are allowed to remain in the CloudFront cache before CloudFront sends a new request to the origin server to check if the object has been updated.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Current version of the cache policy.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Identifier for the cache policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Maximum amount of time, in seconds, that objects stay in the CloudFront cache before CloudFront sends another request to the origin to see if the object has been updated.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time, in seconds, that objects should remain in the CloudFront cache before a new request is sent to the origin to check for updates.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique name used to identify the cache policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration for including HTTP headers, cookies, and URL query strings in the cache key. For more information, refer to the Parameters In Cache Key And Forwarded To Origin section.</summary>
    [JsonPropertyName("parametersInCacheKeyAndForwardedToOrigin")]
    public V1beta2CachePolicyStatusAtProviderParametersInCacheKeyAndForwardedToOrigin? ParametersInCacheKeyAndForwardedToOrigin { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatusConditions
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

/// <summary>CachePolicyStatus defines the observed state of CachePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CachePolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CachePolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CachePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CachePolicy is the Schema for the CachePolicys API. Use the</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CachePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CachePolicySpec>, IStatus<V1beta2CachePolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CachePolicy";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "cachepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CachePolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CachePolicySpec defines the desired state of CachePolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CachePolicySpec Spec { get; set; }

    /// <summary>CachePolicyStatus defines the observed state of CachePolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2CachePolicyStatus? Status { get; set; }
}