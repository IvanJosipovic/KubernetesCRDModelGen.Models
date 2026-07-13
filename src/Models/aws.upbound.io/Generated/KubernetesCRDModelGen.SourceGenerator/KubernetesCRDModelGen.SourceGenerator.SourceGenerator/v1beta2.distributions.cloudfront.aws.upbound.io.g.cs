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
/// <summary>Distribution is the Schema for the Distributions API. Provides a CloudFront web distribution resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DistributionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Distribution>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DistributionList";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "distributions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DistributionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Distribution objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Distribution> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecDeletionPolicyEnum>))]
public enum V1beta2DistributionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A connection function association configuration block (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderConnectionFunctionAssociation
{
    /// <summary>Identifier of the connection function to associate with the distribution.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderCustomErrorResponse
{
    /// <summary>Minimum amount of time you want HTTP error codes to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated.</summary>
    [JsonPropertyName("errorCachingMinTtl")]
    public double? ErrorCachingMinTtl { get; set; }

    /// <summary>4xx or 5xx HTTP status code that you want to customize.</summary>
    [JsonPropertyName("errorCode")]
    public double? ErrorCode { get; set; }

    /// <summary>HTTP status code that you want CloudFront to return with the custom error page to the viewer.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Path of the custom error page (for example, /custom_404.html).</summary>
    [JsonPropertyName("responsePagePath")]
    public string? ResponsePagePath { get; set; }
}

/// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderDefaultCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderDefaultCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public V1beta2DistributionSpecForProviderDefaultCacheBehaviorForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderDefaultCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary>A config block that sets the grpc config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderDefaultCacheBehaviorGrpcConfig
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderDefaultCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderDefaultCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public V1beta2DistributionSpecForProviderDefaultCacheBehaviorForwardedValues? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta2DistributionSpecForProviderDefaultCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that sets the grpc config.</summary>
    [JsonPropertyName("grpcConfig")]
    public V1beta2DistributionSpecForProviderDefaultCacheBehaviorGrpcConfig? GrpcConfig { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta2DistributionSpecForProviderDefaultCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary>The logging configuration that controls how logs are written to your distribution (maximum one). AWS provides two versions of access logs for CloudFront: Legacy and v2. This argument configures legacy version standard logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderLoggingConfig
{
    /// <summary>Amazon S3 bucket for V1 logging where access logs are stored, for example, myawslogbucket.s3.amazonaws.com. V1 logging is enabled when this argument is specified. The bucket must have correct ACL attached with &quot;FULL_CONTROL&quot; permission for &quot;awslogsdelivery&quot; account (Canonical ID: &quot;c4c1ede66af53448b93c283ce9448c4ba468c9432aa01d700d3878632f77d2d0&quot;) for log transfer to work.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether to include cookies in access logs (default: false). This argument applies to both V1 and V2 logging.</summary>
    [JsonPropertyName("includeCookies")]
    public bool? IncludeCookies { get; set; }

    /// <summary>Prefix added to the access log file names for V1 logging, for example, myprefix/. This argument is effective only when V1 logging is enabled.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector
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
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnRef")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef? FunctionArnRef { get; set; }

    /// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnSelector")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector? FunctionArnSelector { get; set; }
}

/// <summary>A config block that sets the grpc config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorGrpcConfig
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector
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
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector? LambdaArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrderedCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorForwardedValues? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta2DistributionSpecForProviderOrderedCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that sets the grpc config.</summary>
    [JsonPropertyName("grpcConfig")]
    public V1beta2DistributionSpecForProviderOrderedCacheBehaviorGrpcConfig? GrpcConfig { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta2DistributionSpecForProviderOrderedCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>Pattern (for example, images/*.jpg) that specifies which requests you want this cache behavior to apply to.</summary>
    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginCustomHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginCustomOriginConfig
{
    /// <summary>HTTP port the custom origin listens on.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>HTTPS port the custom origin listens on.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>IP protocol CloudFront uses when connecting to your origin. Valid values: ipv4, ipv6, dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>Origin protocol policy to apply to your origin. One of http-only, https-only, or match-viewer.</summary>
    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>List of SSL/TLS protocols that CloudFront can use when connecting to your origin over HTTPS. Valid values: SSLv3, TLSv1, TLSv1.1, TLSv1.2. For more information, see Minimum Origin SSL Protocol in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originSslProtocols")]
    public IList<string>? OriginSslProtocols { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelector
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
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelectorPolicy? Policy { get; set; }
}

/// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginOriginShield
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>AWS Region for Origin Shield. To specify a region, use the region code, not the region name. For example, specify the US East (Ohio) region as us-east-2.</summary>
    [JsonPropertyName("originShieldRegion")]
    public string? OriginShieldRegion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelector
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
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy? Policy { get; set; }
}

/// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginS3OriginConfig
{
    /// <summary>The CloudFront origin access identity to associate with the origin.</summary>
    [JsonPropertyName("originAccessIdentity")]
    public string? OriginAccessIdentity { get; set; }

    /// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentityRef")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentityRef? OriginAccessIdentityRef { get; set; }

    /// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentitySelector")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfigOriginAccessIdentitySelector? OriginAccessIdentitySelector { get; set; }
}

/// <summary>The VPC origin configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginVpcOriginConfig
{
    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>The AWS account ID that owns the VPC origin. Required when referencing a VPC origin from a different AWS account for cross-account VPC origin access.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>The VPC origin ID.</summary>
    [JsonPropertyName("vpcOriginId")]
    public string? VpcOriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOrigin
{
    /// <summary>Number of times that CloudFront attempts to connect to the origin. Must be between 1-3. Defaults to 3.</summary>
    [JsonPropertyName("connectionAttempts")]
    public double? ConnectionAttempts { get; set; }

    /// <summary>Number of seconds that CloudFront waits when trying to establish a connection to the origin. Must be between 1-10. Defaults to 10.</summary>
    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    /// <summary>One or more sub-resources with name and value parameters that specify header data that will be sent to the origin (multiples allowed).</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta2DistributionSpecForProviderOriginCustomHeader>? CustomHeader { get; set; }

    /// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
    [JsonPropertyName("customOriginConfig")]
    public V1beta2DistributionSpecForProviderOriginCustomOriginConfig? CustomOriginConfig { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Unique identifier of a CloudFront origin access control for this origin.</summary>
    [JsonPropertyName("originAccessControlId")]
    public string? OriginAccessControlId { get; set; }

    /// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdRef")]
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdRef? OriginAccessControlIdRef { get; set; }

    /// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdSelector")]
    public V1beta2DistributionSpecForProviderOriginOriginAccessControlIdSelector? OriginAccessControlIdSelector { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }

    /// <summary>Optional element that causes CloudFront to request your content from a directory in your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originShield")]
    public V1beta2DistributionSpecForProviderOriginOriginShield? OriginShield { get; set; }

    /// <summary>Time (in seconds) that a request from CloudFront to the origin can stay open and wait for a response. Must be integer greater than or equal to the value of origin_read_timeout. If omitted or explicitly set to 0, no maximum value is enforced.</summary>
    [JsonPropertyName("responseCompletionTimeout")]
    public double? ResponseCompletionTimeout { get; set; }

    /// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
    [JsonPropertyName("s3OriginConfig")]
    public V1beta2DistributionSpecForProviderOriginS3OriginConfig? S3OriginConfig { get; set; }

    /// <summary>The VPC origin configuration.</summary>
    [JsonPropertyName("vpcOriginConfig")]
    public V1beta2DistributionSpecForProviderOriginVpcOriginConfig? VpcOriginConfig { get; set; }
}

/// <summary>The failover criteria for when to failover to the secondary origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginGroupFailoverCriteria
{
    /// <summary>List of HTTP status codes for the origin group.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<double>? StatusCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginGroupMember
{
    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderOriginGroup
{
    /// <summary>The failover criteria for when to failover to the secondary origin.</summary>
    [JsonPropertyName("failoverCriteria")]
    public V1beta2DistributionSpecForProviderOriginGroupFailoverCriteria? FailoverCriteria { get; set; }

    /// <summary>Ordered member configuration blocks assigned to the origin group, where the first member is the primary origin. You must specify two members.</summary>
    [JsonPropertyName("member")]
    public IList<V1beta2DistributionSpecForProviderOriginGroupMember>? Member { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderRestrictionsGeoRestriction
{
    /// <summary>ISO 3166-1-alpha-2 codes for which you want CloudFront either to distribute your content (whitelist) or not distribute your content (blacklist). If the type is specified as none an empty array can be used.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Method that you want to use to restrict distribution of your content by country: none, whitelist, or blacklist.</summary>
    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary>The restriction configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderRestrictions
{
    [JsonPropertyName("geoRestriction")]
    public V1beta2DistributionSpecForProviderRestrictionsGeoRestriction? GeoRestriction { get; set; }
}

/// <summary>The SSL configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderViewerCertificate
{
    /// <summary>ARN of the AWS Certificate Manager certificate that you wish to use with this distribution. Specify this, cloudfront_default_certificate, or iam_certificate_id.  The ACM certificate must be in  US-EAST-1.</summary>
    [JsonPropertyName("acmCertificateArn")]
    public string? AcmCertificateArn { get; set; }

    /// <summary>true if you want viewers to use HTTPS to request your objects and you&apos;re using the CloudFront domain name for your distribution. Specify this, acm_certificate_arn, or iam_certificate_id.</summary>
    [JsonPropertyName("cloudfrontDefaultCertificate")]
    public bool? CloudfrontDefaultCertificate { get; set; }

    /// <summary>IAM certificate identifier of the custom viewer certificate for this distribution if you are using a custom domain. Specify this, acm_certificate_arn, or cloudfront_default_certificate.</summary>
    [JsonPropertyName("iamCertificateId")]
    public string? IamCertificateId { get; set; }

    /// <summary>Minimum version of the SSL protocol that you want CloudFront to use for HTTPS connections. Can only be set if cloudfront_default_certificate = false. See all possible values in this table under &quot;Security policy.&quot; Some examples include: TLSv1.2_2019 and TLSv1.2_2021. Default: TLSv1. NOTE: If you are using a custom certificate (specified with acm_certificate_arn or iam_certificate_id), and have specified sni-only in ssl_support_method, TLSv1 or later must be specified. If you have specified vip in ssl_support_method, only SSLv3 or TLSv1 can be specified. If you have specified cloudfront_default_certificate, TLSv1 must be specified.</summary>
    [JsonPropertyName("minimumProtocolVersion")]
    public string? MinimumProtocolVersion { get; set; }

    /// <summary>How you want CloudFront to serve HTTPS requests. One of vip, sni-only, or static-ip. Required if you specify acm_certificate_arn or iam_certificate_id. NOTE: vip causes CloudFront to use a dedicated IP address and may incur extra charges.</summary>
    [JsonPropertyName("sslSupportMethod")]
    public string? SslSupportMethod { get; set; }
}

/// <summary>The trust store configuration for viewer mTLS (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderViewerMtlsConfigTrustStoreConfig
{
    /// <summary>Whether to advertise the trust store CA names to clients. Defaults to false.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public bool? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>Whether to ignore certificate expiry for viewer mTLS. Defaults to false.</summary>
    [JsonPropertyName("ignoreCertificateExpiry")]
    public bool? IgnoreCertificateExpiry { get; set; }

    /// <summary>Identifier of the trust store to use for viewer mTLS.</summary>
    [JsonPropertyName("trustStoreId")]
    public string? TrustStoreId { get; set; }
}

/// <summary>The viewer mTLS configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProviderViewerMtlsConfig
{
    /// <summary>The mode for viewer mTLS. Valid values: required, optional.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The trust store configuration for viewer mTLS (maximum one).</summary>
    [JsonPropertyName("trustStoreConfig")]
    public V1beta2DistributionSpecForProviderViewerMtlsConfigTrustStoreConfig? TrustStoreConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecForProvider
{
    /// <summary>Extra CNAMEs (alternate domain names), if any, for this distribution.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>ID of the Anycast static IP list that is associated with the distribution.</summary>
    [JsonPropertyName("anycastIpListId")]
    public string? AnycastIpListId { get; set; }

    /// <summary>Any comments you want to include about the distribution.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A connection function association configuration block (maximum one).</summary>
    [JsonPropertyName("connectionFunctionAssociation")]
    public V1beta2DistributionSpecForProviderConnectionFunctionAssociation? ConnectionFunctionAssociation { get; set; }

    /// <summary>Identifier of a continuous deployment policy. This argument should only be set on a production distribution. See the aws_cloudfront_continuous_deployment_policy resource for additional details.</summary>
    [JsonPropertyName("continuousDeploymentPolicyId")]
    public string? ContinuousDeploymentPolicyId { get; set; }

    /// <summary>One or more custom error response elements (multiples allowed).</summary>
    [JsonPropertyName("customErrorResponse")]
    public IList<V1beta2DistributionSpecForProviderCustomErrorResponse>? CustomErrorResponse { get; set; }

    /// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
    [JsonPropertyName("defaultCacheBehavior")]
    public V1beta2DistributionSpecForProviderDefaultCacheBehavior? DefaultCacheBehavior { get; set; }

    /// <summary>Object that you want CloudFront to return (for example, index.html) when an end user requests the root URL.</summary>
    [JsonPropertyName("defaultRootObject")]
    public string? DefaultRootObject { get; set; }

    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Maximum HTTP version to support on the distribution. Allowed values are http1.1, http2, http2and3 and http3. The default is http2.</summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }

    /// <summary>Whether the IPv6 is enabled for the distribution.</summary>
    [JsonPropertyName("isIpv6Enabled")]
    public bool? IsIpv6Enabled { get; set; }

    /// <summary>The logging configuration that controls how logs are written to your distribution (maximum one). AWS provides two versions of access logs for CloudFront: Legacy and v2. This argument configures legacy version standard logs.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2DistributionSpecForProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Ordered list of cache behaviors resource for this distribution. List from top to bottom in order of precedence. The topmost cache behavior will have precedence 0.</summary>
    [JsonPropertyName("orderedCacheBehavior")]
    public IList<V1beta2DistributionSpecForProviderOrderedCacheBehavior>? OrderedCacheBehavior { get; set; }

    /// <summary>One or more origins for this distribution (multiples allowed).</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta2DistributionSpecForProviderOrigin>? Origin { get; set; }

    /// <summary>One or more origin_group for this distribution (multiples allowed).</summary>
    [JsonPropertyName("originGroup")]
    public IList<V1beta2DistributionSpecForProviderOriginGroup>? OriginGroup { get; set; }

    /// <summary>Price class for this distribution. One of PriceClass_All, PriceClass_200, PriceClass_100.</summary>
    [JsonPropertyName("priceClass")]
    public string? PriceClass { get; set; }

    /// <summary>The restriction configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("restrictions")]
    public V1beta2DistributionSpecForProviderRestrictions? Restrictions { get; set; }

    /// <summary>If this is set, the distribution needs to be deleted manually afterwards. Default: false.</summary>
    [JsonPropertyName("retainOnDelete")]
    public bool? RetainOnDelete { get; set; }

    /// <summary>A Boolean that indicates whether this is a staging distribution. Defaults to false.</summary>
    [JsonPropertyName("staging")]
    public bool? Staging { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The SSL configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerCertificate")]
    public V1beta2DistributionSpecForProviderViewerCertificate? ViewerCertificate { get; set; }

    /// <summary>The viewer mTLS configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerMtlsConfig")]
    public V1beta2DistributionSpecForProviderViewerMtlsConfig? ViewerMtlsConfig { get; set; }

    /// <summary>If enabled, the resource will wait for the distribution status to change from InProgress to Deployed. Setting this tofalse will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForDeployment")]
    public bool? WaitForDeployment { get; set; }

    /// <summary>Unique identifier that specifies the AWS WAF web ACL, if any, to associate with this distribution. To specify a web ACL created using the latest version of AWS WAF (WAFv2), use the ACL ARN, for example aws_wafv2_web_acl.example.arn. To specify a web ACL created using AWS WAF Classic, use the ACL ID, for example aws_waf_web_acl.example.id. The WAF Web ACL must exist in the WAF Global (CloudFront) region and the credentials configuring this argument must have waf:GetWebACL permissions assigned.</summary>
    [JsonPropertyName("webAclId")]
    public string? WebAclId { get; set; }
}

/// <summary>A connection function association configuration block (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderConnectionFunctionAssociation
{
    /// <summary>Identifier of the connection function to associate with the distribution.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderCustomErrorResponse
{
    /// <summary>Minimum amount of time you want HTTP error codes to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated.</summary>
    [JsonPropertyName("errorCachingMinTtl")]
    public double? ErrorCachingMinTtl { get; set; }

    /// <summary>4xx or 5xx HTTP status code that you want to customize.</summary>
    [JsonPropertyName("errorCode")]
    public double? ErrorCode { get; set; }

    /// <summary>HTTP status code that you want CloudFront to return with the custom error page to the viewer.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Path of the custom error page (for example, /custom_404.html).</summary>
    [JsonPropertyName("responsePagePath")]
    public string? ResponsePagePath { get; set; }
}

/// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderDefaultCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderDefaultCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public V1beta2DistributionSpecInitProviderDefaultCacheBehaviorForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderDefaultCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary>A config block that sets the grpc config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderDefaultCacheBehaviorGrpcConfig
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderDefaultCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderDefaultCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public V1beta2DistributionSpecInitProviderDefaultCacheBehaviorForwardedValues? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta2DistributionSpecInitProviderDefaultCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that sets the grpc config.</summary>
    [JsonPropertyName("grpcConfig")]
    public V1beta2DistributionSpecInitProviderDefaultCacheBehaviorGrpcConfig? GrpcConfig { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta2DistributionSpecInitProviderDefaultCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary>The logging configuration that controls how logs are written to your distribution (maximum one). AWS provides two versions of access logs for CloudFront: Legacy and v2. This argument configures legacy version standard logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderLoggingConfig
{
    /// <summary>Amazon S3 bucket for V1 logging where access logs are stored, for example, myawslogbucket.s3.amazonaws.com. V1 logging is enabled when this argument is specified. The bucket must have correct ACL attached with &quot;FULL_CONTROL&quot; permission for &quot;awslogsdelivery&quot; account (Canonical ID: &quot;c4c1ede66af53448b93c283ce9448c4ba468c9432aa01d700d3878632f77d2d0&quot;) for log transfer to work.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether to include cookies in access logs (default: false). This argument applies to both V1 and V2 logging.</summary>
    [JsonPropertyName("includeCookies")]
    public bool? IncludeCookies { get; set; }

    /// <summary>Prefix added to the access log file names for V1 logging, for example, myprefix/. This argument is effective only when V1 logging is enabled.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector
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
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }

    /// <summary>Reference to a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnRef")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnRef? FunctionArnRef { get; set; }

    /// <summary>Selector for a Function in cloudfront to populate functionArn.</summary>
    [JsonPropertyName("functionArnSelector")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociationFunctionArnSelector? FunctionArnSelector { get; set; }
}

/// <summary>A config block that sets the grpc config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorGrpcConfig
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector
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
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociationLambdaArnSelector? LambdaArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrderedCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorForwardedValues? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that sets the grpc config.</summary>
    [JsonPropertyName("grpcConfig")]
    public V1beta2DistributionSpecInitProviderOrderedCacheBehaviorGrpcConfig? GrpcConfig { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta2DistributionSpecInitProviderOrderedCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>Pattern (for example, images/*.jpg) that specifies which requests you want this cache behavior to apply to.</summary>
    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginCustomHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginCustomOriginConfig
{
    /// <summary>HTTP port the custom origin listens on.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>HTTPS port the custom origin listens on.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>IP protocol CloudFront uses when connecting to your origin. Valid values: ipv4, ipv6, dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>Origin protocol policy to apply to your origin. One of http-only, https-only, or match-viewer.</summary>
    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>List of SSL/TLS protocols that CloudFront can use when connecting to your origin over HTTPS. Valid values: SSLv3, TLSv1, TLSv1.1, TLSv1.2. For more information, see Minimum Origin SSL Protocol in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originSslProtocols")]
    public IList<string>? OriginSslProtocols { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelector
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
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelectorPolicy? Policy { get; set; }
}

/// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginOriginShield
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>AWS Region for Origin Shield. To specify a region, use the region code, not the region name. For example, specify the US East (Ohio) region as us-east-2.</summary>
    [JsonPropertyName("originShieldRegion")]
    public string? OriginShieldRegion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum>))]
public enum V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelector
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
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelectorPolicy? Policy { get; set; }
}

/// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginS3OriginConfig
{
    /// <summary>The CloudFront origin access identity to associate with the origin.</summary>
    [JsonPropertyName("originAccessIdentity")]
    public string? OriginAccessIdentity { get; set; }

    /// <summary>Reference to a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentityRef")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentityRef? OriginAccessIdentityRef { get; set; }

    /// <summary>Selector for a OriginAccessIdentity in cloudfront to populate originAccessIdentity.</summary>
    [JsonPropertyName("originAccessIdentitySelector")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfigOriginAccessIdentitySelector? OriginAccessIdentitySelector { get; set; }
}

/// <summary>The VPC origin configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginVpcOriginConfig
{
    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>The AWS account ID that owns the VPC origin. Required when referencing a VPC origin from a different AWS account for cross-account VPC origin access.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>The VPC origin ID.</summary>
    [JsonPropertyName("vpcOriginId")]
    public string? VpcOriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOrigin
{
    /// <summary>Number of times that CloudFront attempts to connect to the origin. Must be between 1-3. Defaults to 3.</summary>
    [JsonPropertyName("connectionAttempts")]
    public double? ConnectionAttempts { get; set; }

    /// <summary>Number of seconds that CloudFront waits when trying to establish a connection to the origin. Must be between 1-10. Defaults to 10.</summary>
    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    /// <summary>One or more sub-resources with name and value parameters that specify header data that will be sent to the origin (multiples allowed).</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta2DistributionSpecInitProviderOriginCustomHeader>? CustomHeader { get; set; }

    /// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
    [JsonPropertyName("customOriginConfig")]
    public V1beta2DistributionSpecInitProviderOriginCustomOriginConfig? CustomOriginConfig { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Unique identifier of a CloudFront origin access control for this origin.</summary>
    [JsonPropertyName("originAccessControlId")]
    public string? OriginAccessControlId { get; set; }

    /// <summary>Reference to a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdRef")]
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdRef? OriginAccessControlIdRef { get; set; }

    /// <summary>Selector for a OriginAccessControl in cloudfront to populate originAccessControlId.</summary>
    [JsonPropertyName("originAccessControlIdSelector")]
    public V1beta2DistributionSpecInitProviderOriginOriginAccessControlIdSelector? OriginAccessControlIdSelector { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }

    /// <summary>Optional element that causes CloudFront to request your content from a directory in your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originShield")]
    public V1beta2DistributionSpecInitProviderOriginOriginShield? OriginShield { get; set; }

    /// <summary>Time (in seconds) that a request from CloudFront to the origin can stay open and wait for a response. Must be integer greater than or equal to the value of origin_read_timeout. If omitted or explicitly set to 0, no maximum value is enforced.</summary>
    [JsonPropertyName("responseCompletionTimeout")]
    public double? ResponseCompletionTimeout { get; set; }

    /// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
    [JsonPropertyName("s3OriginConfig")]
    public V1beta2DistributionSpecInitProviderOriginS3OriginConfig? S3OriginConfig { get; set; }

    /// <summary>The VPC origin configuration.</summary>
    [JsonPropertyName("vpcOriginConfig")]
    public V1beta2DistributionSpecInitProviderOriginVpcOriginConfig? VpcOriginConfig { get; set; }
}

/// <summary>The failover criteria for when to failover to the secondary origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginGroupFailoverCriteria
{
    /// <summary>List of HTTP status codes for the origin group.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<double>? StatusCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginGroupMember
{
    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderOriginGroup
{
    /// <summary>The failover criteria for when to failover to the secondary origin.</summary>
    [JsonPropertyName("failoverCriteria")]
    public V1beta2DistributionSpecInitProviderOriginGroupFailoverCriteria? FailoverCriteria { get; set; }

    /// <summary>Ordered member configuration blocks assigned to the origin group, where the first member is the primary origin. You must specify two members.</summary>
    [JsonPropertyName("member")]
    public IList<V1beta2DistributionSpecInitProviderOriginGroupMember>? Member { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderRestrictionsGeoRestriction
{
    /// <summary>ISO 3166-1-alpha-2 codes for which you want CloudFront either to distribute your content (whitelist) or not distribute your content (blacklist). If the type is specified as none an empty array can be used.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Method that you want to use to restrict distribution of your content by country: none, whitelist, or blacklist.</summary>
    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary>The restriction configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderRestrictions
{
    [JsonPropertyName("geoRestriction")]
    public V1beta2DistributionSpecInitProviderRestrictionsGeoRestriction? GeoRestriction { get; set; }
}

/// <summary>The SSL configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderViewerCertificate
{
    /// <summary>ARN of the AWS Certificate Manager certificate that you wish to use with this distribution. Specify this, cloudfront_default_certificate, or iam_certificate_id.  The ACM certificate must be in  US-EAST-1.</summary>
    [JsonPropertyName("acmCertificateArn")]
    public string? AcmCertificateArn { get; set; }

    /// <summary>true if you want viewers to use HTTPS to request your objects and you&apos;re using the CloudFront domain name for your distribution. Specify this, acm_certificate_arn, or iam_certificate_id.</summary>
    [JsonPropertyName("cloudfrontDefaultCertificate")]
    public bool? CloudfrontDefaultCertificate { get; set; }

    /// <summary>IAM certificate identifier of the custom viewer certificate for this distribution if you are using a custom domain. Specify this, acm_certificate_arn, or cloudfront_default_certificate.</summary>
    [JsonPropertyName("iamCertificateId")]
    public string? IamCertificateId { get; set; }

    /// <summary>Minimum version of the SSL protocol that you want CloudFront to use for HTTPS connections. Can only be set if cloudfront_default_certificate = false. See all possible values in this table under &quot;Security policy.&quot; Some examples include: TLSv1.2_2019 and TLSv1.2_2021. Default: TLSv1. NOTE: If you are using a custom certificate (specified with acm_certificate_arn or iam_certificate_id), and have specified sni-only in ssl_support_method, TLSv1 or later must be specified. If you have specified vip in ssl_support_method, only SSLv3 or TLSv1 can be specified. If you have specified cloudfront_default_certificate, TLSv1 must be specified.</summary>
    [JsonPropertyName("minimumProtocolVersion")]
    public string? MinimumProtocolVersion { get; set; }

    /// <summary>How you want CloudFront to serve HTTPS requests. One of vip, sni-only, or static-ip. Required if you specify acm_certificate_arn or iam_certificate_id. NOTE: vip causes CloudFront to use a dedicated IP address and may incur extra charges.</summary>
    [JsonPropertyName("sslSupportMethod")]
    public string? SslSupportMethod { get; set; }
}

/// <summary>The trust store configuration for viewer mTLS (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderViewerMtlsConfigTrustStoreConfig
{
    /// <summary>Whether to advertise the trust store CA names to clients. Defaults to false.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public bool? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>Whether to ignore certificate expiry for viewer mTLS. Defaults to false.</summary>
    [JsonPropertyName("ignoreCertificateExpiry")]
    public bool? IgnoreCertificateExpiry { get; set; }

    /// <summary>Identifier of the trust store to use for viewer mTLS.</summary>
    [JsonPropertyName("trustStoreId")]
    public string? TrustStoreId { get; set; }
}

/// <summary>The viewer mTLS configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecInitProviderViewerMtlsConfig
{
    /// <summary>The mode for viewer mTLS. Valid values: required, optional.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The trust store configuration for viewer mTLS (maximum one).</summary>
    [JsonPropertyName("trustStoreConfig")]
    public V1beta2DistributionSpecInitProviderViewerMtlsConfigTrustStoreConfig? TrustStoreConfig { get; set; }
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
public partial class V1beta2DistributionSpecInitProvider
{
    /// <summary>Extra CNAMEs (alternate domain names), if any, for this distribution.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>ID of the Anycast static IP list that is associated with the distribution.</summary>
    [JsonPropertyName("anycastIpListId")]
    public string? AnycastIpListId { get; set; }

    /// <summary>Any comments you want to include about the distribution.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A connection function association configuration block (maximum one).</summary>
    [JsonPropertyName("connectionFunctionAssociation")]
    public V1beta2DistributionSpecInitProviderConnectionFunctionAssociation? ConnectionFunctionAssociation { get; set; }

    /// <summary>Identifier of a continuous deployment policy. This argument should only be set on a production distribution. See the aws_cloudfront_continuous_deployment_policy resource for additional details.</summary>
    [JsonPropertyName("continuousDeploymentPolicyId")]
    public string? ContinuousDeploymentPolicyId { get; set; }

    /// <summary>One or more custom error response elements (multiples allowed).</summary>
    [JsonPropertyName("customErrorResponse")]
    public IList<V1beta2DistributionSpecInitProviderCustomErrorResponse>? CustomErrorResponse { get; set; }

    /// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
    [JsonPropertyName("defaultCacheBehavior")]
    public V1beta2DistributionSpecInitProviderDefaultCacheBehavior? DefaultCacheBehavior { get; set; }

    /// <summary>Object that you want CloudFront to return (for example, index.html) when an end user requests the root URL.</summary>
    [JsonPropertyName("defaultRootObject")]
    public string? DefaultRootObject { get; set; }

    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Maximum HTTP version to support on the distribution. Allowed values are http1.1, http2, http2and3 and http3. The default is http2.</summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }

    /// <summary>Whether the IPv6 is enabled for the distribution.</summary>
    [JsonPropertyName("isIpv6Enabled")]
    public bool? IsIpv6Enabled { get; set; }

    /// <summary>The logging configuration that controls how logs are written to your distribution (maximum one). AWS provides two versions of access logs for CloudFront: Legacy and v2. This argument configures legacy version standard logs.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2DistributionSpecInitProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Ordered list of cache behaviors resource for this distribution. List from top to bottom in order of precedence. The topmost cache behavior will have precedence 0.</summary>
    [JsonPropertyName("orderedCacheBehavior")]
    public IList<V1beta2DistributionSpecInitProviderOrderedCacheBehavior>? OrderedCacheBehavior { get; set; }

    /// <summary>One or more origins for this distribution (multiples allowed).</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta2DistributionSpecInitProviderOrigin>? Origin { get; set; }

    /// <summary>One or more origin_group for this distribution (multiples allowed).</summary>
    [JsonPropertyName("originGroup")]
    public IList<V1beta2DistributionSpecInitProviderOriginGroup>? OriginGroup { get; set; }

    /// <summary>Price class for this distribution. One of PriceClass_All, PriceClass_200, PriceClass_100.</summary>
    [JsonPropertyName("priceClass")]
    public string? PriceClass { get; set; }

    /// <summary>The restriction configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("restrictions")]
    public V1beta2DistributionSpecInitProviderRestrictions? Restrictions { get; set; }

    /// <summary>If this is set, the distribution needs to be deleted manually afterwards. Default: false.</summary>
    [JsonPropertyName("retainOnDelete")]
    public bool? RetainOnDelete { get; set; }

    /// <summary>A Boolean that indicates whether this is a staging distribution. Defaults to false.</summary>
    [JsonPropertyName("staging")]
    public bool? Staging { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The SSL configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerCertificate")]
    public V1beta2DistributionSpecInitProviderViewerCertificate? ViewerCertificate { get; set; }

    /// <summary>The viewer mTLS configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerMtlsConfig")]
    public V1beta2DistributionSpecInitProviderViewerMtlsConfig? ViewerMtlsConfig { get; set; }

    /// <summary>If enabled, the resource will wait for the distribution status to change from InProgress to Deployed. Setting this tofalse will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForDeployment")]
    public bool? WaitForDeployment { get; set; }

    /// <summary>Unique identifier that specifies the AWS WAF web ACL, if any, to associate with this distribution. To specify a web ACL created using the latest version of AWS WAF (WAFv2), use the ACL ARN, for example aws_wafv2_web_acl.example.arn. To specify a web ACL created using AWS WAF Classic, use the ACL ID, for example aws_waf_web_acl.example.id. The WAF Web ACL must exist in the WAF Global (CloudFront) region and the credentials configuring this argument must have waf:GetWebACL permissions assigned.</summary>
    [JsonPropertyName("webAclId")]
    public string? WebAclId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecManagementPoliciesEnum>))]
public enum V1beta2DistributionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DistributionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DistributionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DistributionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DistributionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DistributionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DistributionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DistributionSpec defines the desired state of Distribution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionSpec
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
    public V1beta2DistributionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DistributionSpecForProvider ForProvider { get; set; }

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
    public V1beta2DistributionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DistributionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DistributionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DistributionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A connection function association configuration block (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderConnectionFunctionAssociation
{
    /// <summary>Identifier of the connection function to associate with the distribution.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderCustomErrorResponse
{
    /// <summary>Minimum amount of time you want HTTP error codes to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated.</summary>
    [JsonPropertyName("errorCachingMinTtl")]
    public double? ErrorCachingMinTtl { get; set; }

    /// <summary>4xx or 5xx HTTP status code that you want to customize.</summary>
    [JsonPropertyName("errorCode")]
    public double? ErrorCode { get; set; }

    /// <summary>HTTP status code that you want CloudFront to return with the custom error page to the viewer.</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Path of the custom error page (for example, /custom_404.html).</summary>
    [JsonPropertyName("responsePagePath")]
    public string? ResponsePagePath { get; set; }
}

/// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderDefaultCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderDefaultCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public V1beta2DistributionStatusAtProviderDefaultCacheBehaviorForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderDefaultCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary>A config block that sets the grpc config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderDefaultCacheBehaviorGrpcConfig
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderDefaultCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

/// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderDefaultCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public V1beta2DistributionStatusAtProviderDefaultCacheBehaviorForwardedValues? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta2DistributionStatusAtProviderDefaultCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that sets the grpc config.</summary>
    [JsonPropertyName("grpcConfig")]
    public V1beta2DistributionStatusAtProviderDefaultCacheBehaviorGrpcConfig? GrpcConfig { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta2DistributionStatusAtProviderDefaultCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary>The logging configuration that controls how logs are written to your distribution (maximum one). AWS provides two versions of access logs for CloudFront: Legacy and v2. This argument configures legacy version standard logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderLoggingConfig
{
    /// <summary>Amazon S3 bucket for V1 logging where access logs are stored, for example, myawslogbucket.s3.amazonaws.com. V1 logging is enabled when this argument is specified. The bucket must have correct ACL attached with &quot;FULL_CONTROL&quot; permission for &quot;awslogsdelivery&quot; account (Canonical ID: &quot;c4c1ede66af53448b93c283ce9448c4ba468c9432aa01d700d3878632f77d2d0&quot;) for log transfer to work.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Whether to include cookies in access logs (default: false). This argument applies to both V1 and V2 logging.</summary>
    [JsonPropertyName("includeCookies")]
    public bool? IncludeCookies { get; set; }

    /// <summary>Prefix added to the access log file names for V1 logging, for example, myprefix/. This argument is effective only when V1 logging is enabled.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOrderedCacheBehaviorForwardedValuesCookies
{
    /// <summary>Whether you want CloudFront to forward cookies to the origin that is associated with this cache behavior. You can specify all, none or whitelist. If whitelist, you must include the subsequent whitelisted_names.</summary>
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>If you have specified whitelist to forward, the whitelisted cookies that you want CloudFront to forward to your origin.</summary>
    [JsonPropertyName("whitelistedNames")]
    public IList<string>? WhitelistedNames { get; set; }
}

/// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOrderedCacheBehaviorForwardedValues
{
    /// <summary>The forwarded values cookies that specifies how CloudFront handles cookies (maximum one).</summary>
    [JsonPropertyName("cookies")]
    public V1beta2DistributionStatusAtProviderOrderedCacheBehaviorForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Headers, if any, that you want CloudFront to vary upon for this cache behavior. Specify * to include all headers.</summary>
    [JsonPropertyName("headers")]
    public IList<string>? Headers { get; set; }

    /// <summary>Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>When specified, along with a value of true for query_string, all query strings are forwarded, however only the query string keys listed in this argument are cached. When omitted with a value of true for query_string, all query string keys are cached.</summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public IList<string>? QueryStringCacheKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOrderedCacheBehaviorFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>ARN of the CloudFront function.</summary>
    [JsonPropertyName("functionArn")]
    public string? FunctionArn { get; set; }
}

/// <summary>A config block that sets the grpc config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOrderedCacheBehaviorGrpcConfig
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOrderedCacheBehaviorLambdaFunctionAssociation
{
    /// <summary>Specific event to trigger this function. Valid values: viewer-request, origin-request, viewer-response, origin-response.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>When set to true it exposes the request body to the lambda function. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    /// <summary>ARN of the Lambda function.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOrderedCacheBehavior
{
    /// <summary>Controls which HTTP methods CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Unique identifier of the cache policy that is attached to the cache behavior. If configuring the default_cache_behavior either cache_policy_id or forwarded_values must be set.</summary>
    [JsonPropertyName("cachePolicyId")]
    public string? CachePolicyId { get; set; }

    /// <summary>Controls whether CloudFront caches the response to requests using the specified HTTP methods.</summary>
    [JsonPropertyName("cachedMethods")]
    public IList<string>? CachedMethods { get; set; }

    /// <summary>Whether you want CloudFront to automatically compress content for web requests that include Accept-Encoding: gzip in the request header (default: false).</summary>
    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    /// <summary>Default amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request in the absence of an Cache-Control max-age or Expires header. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Field level encryption configuration ID.</summary>
    [JsonPropertyName("fieldLevelEncryptionId")]
    public string? FieldLevelEncryptionId { get; set; }

    /// <summary>The forwarded values configuration that specifies how CloudFront handles query strings, cookies and headers (maximum one).</summary>
    [JsonPropertyName("forwardedValues")]
    public V1beta2DistributionStatusAtProviderOrderedCacheBehaviorForwardedValues? ForwardedValues { get; set; }

    /// <summary>A config block that triggers a cloudfront function with specific actions (maximum 2).</summary>
    [JsonPropertyName("functionAssociation")]
    public IList<V1beta2DistributionStatusAtProviderOrderedCacheBehaviorFunctionAssociation>? FunctionAssociation { get; set; }

    /// <summary>A config block that sets the grpc config.</summary>
    [JsonPropertyName("grpcConfig")]
    public V1beta2DistributionStatusAtProviderOrderedCacheBehaviorGrpcConfig? GrpcConfig { get; set; }

    /// <summary>A config block that triggers a lambda function with specific actions (maximum 4).</summary>
    [JsonPropertyName("lambdaFunctionAssociation")]
    public IList<V1beta2DistributionStatusAtProviderOrderedCacheBehaviorLambdaFunctionAssociation>? LambdaFunctionAssociation { get; set; }

    /// <summary>Maximum amount of time (in seconds) that an object is in a CloudFront cache before CloudFront forwards another request to your origin to determine whether the object has been updated. Only effective in the presence of Cache-Control max-age, Cache-Control s-maxage, and Expires headers. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the object has been updated. Defaults to 0 seconds. The TTL defined in Cache Policy overrides this configuration.</summary>
    [JsonPropertyName("minTtl")]
    public double? MinTtl { get; set; }

    /// <summary>Unique identifier of the origin request policy that is attached to the behavior.</summary>
    [JsonPropertyName("originRequestPolicyId")]
    public string? OriginRequestPolicyId { get; set; }

    /// <summary>Pattern (for example, images/*.jpg) that specifies which requests you want this cache behavior to apply to.</summary>
    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    /// <summary>ARN of the real-time log configuration that is attached to this cache behavior.</summary>
    [JsonPropertyName("realtimeLogConfigArn")]
    public string? RealtimeLogConfigArn { get; set; }

    /// <summary>Identifier for a response headers policy.</summary>
    [JsonPropertyName("responseHeadersPolicyId")]
    public string? ResponseHeadersPolicyId { get; set; }

    /// <summary>Indicates whether you want to distribute media files in Microsoft Smooth Streaming format using the origin that is associated with this cache behavior.</summary>
    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    /// <summary>Value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache behavior or for the default cache behavior.</summary>
    [JsonPropertyName("targetOriginId")]
    public string? TargetOriginId { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<string>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<string>? TrustedSigners { get; set; }

    /// <summary>Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request matches the path pattern in PathPattern. One of allow-all, https-only, or redirect-to-https.</summary>
    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginCustomHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginCustomOriginConfig
{
    /// <summary>HTTP port the custom origin listens on.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>HTTPS port the custom origin listens on.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>IP protocol CloudFront uses when connecting to your origin. Valid values: ipv4, ipv6, dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>Origin protocol policy to apply to your origin. One of http-only, https-only, or match-viewer.</summary>
    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>List of SSL/TLS protocols that CloudFront can use when connecting to your origin over HTTPS. Valid values: SSLv3, TLSv1, TLSv1.1, TLSv1.2. For more information, see Minimum Origin SSL Protocol in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originSslProtocols")]
    public IList<string>? OriginSslProtocols { get; set; }
}

/// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginOriginShield
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>AWS Region for Origin Shield. To specify a region, use the region code, not the region name. For example, specify the US East (Ohio) region as us-east-2.</summary>
    [JsonPropertyName("originShieldRegion")]
    public string? OriginShieldRegion { get; set; }
}

/// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginS3OriginConfig
{
    /// <summary>The CloudFront origin access identity to associate with the origin.</summary>
    [JsonPropertyName("originAccessIdentity")]
    public string? OriginAccessIdentity { get; set; }
}

/// <summary>The VPC origin configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginVpcOriginConfig
{
    /// <summary>The Custom KeepAlive timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 5.</summary>
    [JsonPropertyName("originKeepaliveTimeout")]
    public double? OriginKeepaliveTimeout { get; set; }

    /// <summary>The Custom Read timeout, in seconds. By default, AWS enforces an upper limit of 60. But you can request an increase. Defaults to 30.</summary>
    [JsonPropertyName("originReadTimeout")]
    public double? OriginReadTimeout { get; set; }

    /// <summary>The AWS account ID that owns the VPC origin. Required when referencing a VPC origin from a different AWS account for cross-account VPC origin access.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>The VPC origin ID.</summary>
    [JsonPropertyName("vpcOriginId")]
    public string? VpcOriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOrigin
{
    /// <summary>Number of times that CloudFront attempts to connect to the origin. Must be between 1-3. Defaults to 3.</summary>
    [JsonPropertyName("connectionAttempts")]
    public double? ConnectionAttempts { get; set; }

    /// <summary>Number of seconds that CloudFront waits when trying to establish a connection to the origin. Must be between 1-10. Defaults to 10.</summary>
    [JsonPropertyName("connectionTimeout")]
    public double? ConnectionTimeout { get; set; }

    /// <summary>One or more sub-resources with name and value parameters that specify header data that will be sent to the origin (multiples allowed).</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta2DistributionStatusAtProviderOriginCustomHeader>? CustomHeader { get; set; }

    /// <summary>The CloudFront custom origin configuration information. If an S3 origin is required, use origin_access_control_id or s3_origin_config instead.</summary>
    [JsonPropertyName("customOriginConfig")]
    public V1beta2DistributionStatusAtProviderOriginCustomOriginConfig? CustomOriginConfig { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Unique identifier of a CloudFront origin access control for this origin.</summary>
    [JsonPropertyName("originAccessControlId")]
    public string? OriginAccessControlId { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }

    /// <summary>Optional element that causes CloudFront to request your content from a directory in your Amazon S3 bucket or your custom origin.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>CloudFront Origin Shield configuration information. Using Origin Shield can help reduce the load on your origin. For more information, see Using Origin Shield in the Amazon CloudFront Developer Guide.</summary>
    [JsonPropertyName("originShield")]
    public V1beta2DistributionStatusAtProviderOriginOriginShield? OriginShield { get; set; }

    /// <summary>Time (in seconds) that a request from CloudFront to the origin can stay open and wait for a response. Must be integer greater than or equal to the value of origin_read_timeout. If omitted or explicitly set to 0, no maximum value is enforced.</summary>
    [JsonPropertyName("responseCompletionTimeout")]
    public double? ResponseCompletionTimeout { get; set; }

    /// <summary>CloudFront S3 origin configuration information. If a custom origin is required, use custom_origin_config instead.</summary>
    [JsonPropertyName("s3OriginConfig")]
    public V1beta2DistributionStatusAtProviderOriginS3OriginConfig? S3OriginConfig { get; set; }

    /// <summary>The VPC origin configuration.</summary>
    [JsonPropertyName("vpcOriginConfig")]
    public V1beta2DistributionStatusAtProviderOriginVpcOriginConfig? VpcOriginConfig { get; set; }
}

/// <summary>The failover criteria for when to failover to the secondary origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginGroupFailoverCriteria
{
    /// <summary>List of HTTP status codes for the origin group.</summary>
    [JsonPropertyName("statusCodes")]
    public IList<double>? StatusCodes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginGroupMember
{
    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderOriginGroup
{
    /// <summary>The failover criteria for when to failover to the secondary origin.</summary>
    [JsonPropertyName("failoverCriteria")]
    public V1beta2DistributionStatusAtProviderOriginGroupFailoverCriteria? FailoverCriteria { get; set; }

    /// <summary>Ordered member configuration blocks assigned to the origin group, where the first member is the primary origin. You must specify two members.</summary>
    [JsonPropertyName("member")]
    public IList<V1beta2DistributionStatusAtProviderOriginGroupMember>? Member { get; set; }

    /// <summary>Unique identifier for the origin.</summary>
    [JsonPropertyName("originId")]
    public string? OriginId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderRestrictionsGeoRestriction
{
    /// <summary>ISO 3166-1-alpha-2 codes for which you want CloudFront either to distribute your content (whitelist) or not distribute your content (blacklist). If the type is specified as none an empty array can be used.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Method that you want to use to restrict distribution of your content by country: none, whitelist, or blacklist.</summary>
    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary>The restriction configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderRestrictions
{
    [JsonPropertyName("geoRestriction")]
    public V1beta2DistributionStatusAtProviderRestrictionsGeoRestriction? GeoRestriction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderTrustedKeyGroupsItems
{
    /// <summary>ID of the key group that contains the public keys.</summary>
    [JsonPropertyName("keyGroupId")]
    public string? KeyGroupId { get; set; }

    /// <summary>Set of CloudFront key pair IDs.</summary>
    [JsonPropertyName("keyPairIds")]
    public IList<string>? KeyPairIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderTrustedKeyGroups
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>List of nested attributes for each key group.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta2DistributionStatusAtProviderTrustedKeyGroupsItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderTrustedSignersItems
{
    /// <summary>AWS account ID or self</summary>
    [JsonPropertyName("awsAccountNumber")]
    public string? AwsAccountNumber { get; set; }

    /// <summary>Set of CloudFront key pair IDs.</summary>
    [JsonPropertyName("keyPairIds")]
    public IList<string>? KeyPairIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderTrustedSigners
{
    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>List of nested attributes for each key group.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta2DistributionStatusAtProviderTrustedSignersItems>? Items { get; set; }
}

/// <summary>The SSL configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderViewerCertificate
{
    /// <summary>ARN of the AWS Certificate Manager certificate that you wish to use with this distribution. Specify this, cloudfront_default_certificate, or iam_certificate_id.  The ACM certificate must be in  US-EAST-1.</summary>
    [JsonPropertyName("acmCertificateArn")]
    public string? AcmCertificateArn { get; set; }

    /// <summary>true if you want viewers to use HTTPS to request your objects and you&apos;re using the CloudFront domain name for your distribution. Specify this, acm_certificate_arn, or iam_certificate_id.</summary>
    [JsonPropertyName("cloudfrontDefaultCertificate")]
    public bool? CloudfrontDefaultCertificate { get; set; }

    /// <summary>IAM certificate identifier of the custom viewer certificate for this distribution if you are using a custom domain. Specify this, acm_certificate_arn, or cloudfront_default_certificate.</summary>
    [JsonPropertyName("iamCertificateId")]
    public string? IamCertificateId { get; set; }

    /// <summary>Minimum version of the SSL protocol that you want CloudFront to use for HTTPS connections. Can only be set if cloudfront_default_certificate = false. See all possible values in this table under &quot;Security policy.&quot; Some examples include: TLSv1.2_2019 and TLSv1.2_2021. Default: TLSv1. NOTE: If you are using a custom certificate (specified with acm_certificate_arn or iam_certificate_id), and have specified sni-only in ssl_support_method, TLSv1 or later must be specified. If you have specified vip in ssl_support_method, only SSLv3 or TLSv1 can be specified. If you have specified cloudfront_default_certificate, TLSv1 must be specified.</summary>
    [JsonPropertyName("minimumProtocolVersion")]
    public string? MinimumProtocolVersion { get; set; }

    /// <summary>How you want CloudFront to serve HTTPS requests. One of vip, sni-only, or static-ip. Required if you specify acm_certificate_arn or iam_certificate_id. NOTE: vip causes CloudFront to use a dedicated IP address and may incur extra charges.</summary>
    [JsonPropertyName("sslSupportMethod")]
    public string? SslSupportMethod { get; set; }
}

/// <summary>The trust store configuration for viewer mTLS (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderViewerMtlsConfigTrustStoreConfig
{
    /// <summary>Whether to advertise the trust store CA names to clients. Defaults to false.</summary>
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public bool? AdvertiseTrustStoreCaNames { get; set; }

    /// <summary>Whether to ignore certificate expiry for viewer mTLS. Defaults to false.</summary>
    [JsonPropertyName("ignoreCertificateExpiry")]
    public bool? IgnoreCertificateExpiry { get; set; }

    /// <summary>Identifier of the trust store to use for viewer mTLS.</summary>
    [JsonPropertyName("trustStoreId")]
    public string? TrustStoreId { get; set; }
}

/// <summary>The viewer mTLS configuration for this distribution (maximum one).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProviderViewerMtlsConfig
{
    /// <summary>The mode for viewer mTLS. Valid values: required, optional.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The trust store configuration for viewer mTLS (maximum one).</summary>
    [JsonPropertyName("trustStoreConfig")]
    public V1beta2DistributionStatusAtProviderViewerMtlsConfigTrustStoreConfig? TrustStoreConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusAtProvider
{
    /// <summary>Extra CNAMEs (alternate domain names), if any, for this distribution.</summary>
    [JsonPropertyName("aliases")]
    public IList<string>? Aliases { get; set; }

    /// <summary>ID of the Anycast static IP list that is associated with the distribution.</summary>
    [JsonPropertyName("anycastIpListId")]
    public string? AnycastIpListId { get; set; }

    /// <summary>ARN for the distribution. For example: arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5, where 123456789012 is your AWS account ID.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Internal value used by CloudFront to allow future updates to the distribution configuration.</summary>
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>Any comments you want to include about the distribution.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A connection function association configuration block (maximum one).</summary>
    [JsonPropertyName("connectionFunctionAssociation")]
    public V1beta2DistributionStatusAtProviderConnectionFunctionAssociation? ConnectionFunctionAssociation { get; set; }

    /// <summary>Identifier of a continuous deployment policy. This argument should only be set on a production distribution. See the aws_cloudfront_continuous_deployment_policy resource for additional details.</summary>
    [JsonPropertyName("continuousDeploymentPolicyId")]
    public string? ContinuousDeploymentPolicyId { get; set; }

    /// <summary>One or more custom error response elements (multiples allowed).</summary>
    [JsonPropertyName("customErrorResponse")]
    public IList<V1beta2DistributionStatusAtProviderCustomErrorResponse>? CustomErrorResponse { get; set; }

    /// <summary>Default cache behavior for this distribution (maximum one). Requires either cache_policy_id (preferred) or forwarded_values (deprecated) be set.</summary>
    [JsonPropertyName("defaultCacheBehavior")]
    public V1beta2DistributionStatusAtProviderDefaultCacheBehavior? DefaultCacheBehavior { get; set; }

    /// <summary>Object that you want CloudFront to return (for example, index.html) when an end user requests the root URL.</summary>
    [JsonPropertyName("defaultRootObject")]
    public string? DefaultRootObject { get; set; }

    /// <summary>DNS domain name of either the S3 bucket, or web site of your custom origin.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Whether the distribution is enabled to accept end user requests for content.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Current version of the distribution&apos;s information. For example: E2QWRUHAPOMQZL.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>CloudFront Route 53 zone ID that can be used to route an Alias Resource Record Set to. This attribute is simply an alias for the zone ID Z2FDTNDATAQYW2.</summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>Maximum HTTP version to support on the distribution. Allowed values are http1.1, http2, http2and3 and http3. The default is http2.</summary>
    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }

    /// <summary>Identifier of the connection function to associate with the distribution.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Number of invalidation batches currently in progress.</summary>
    [JsonPropertyName("inProgressValidationBatches")]
    public double? InProgressValidationBatches { get; set; }

    /// <summary>Whether the IPv6 is enabled for the distribution.</summary>
    [JsonPropertyName("isIpv6Enabled")]
    public bool? IsIpv6Enabled { get; set; }

    /// <summary>Date and time the distribution was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>The logging configuration that controls how logs are written to your distribution (maximum one). AWS provides two versions of access logs for CloudFront: Legacy and v2. This argument configures legacy version standard logs.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2DistributionStatusAtProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Whether V1 logging is enabled for the distribution.</summary>
    [JsonPropertyName("loggingV1Enabled")]
    public bool? LoggingV1Enabled { get; set; }

    /// <summary>Ordered list of cache behaviors resource for this distribution. List from top to bottom in order of precedence. The topmost cache behavior will have precedence 0.</summary>
    [JsonPropertyName("orderedCacheBehavior")]
    public IList<V1beta2DistributionStatusAtProviderOrderedCacheBehavior>? OrderedCacheBehavior { get; set; }

    /// <summary>One or more origins for this distribution (multiples allowed).</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta2DistributionStatusAtProviderOrigin>? Origin { get; set; }

    /// <summary>One or more origin_group for this distribution (multiples allowed).</summary>
    [JsonPropertyName("originGroup")]
    public IList<V1beta2DistributionStatusAtProviderOriginGroup>? OriginGroup { get; set; }

    /// <summary>Price class for this distribution. One of PriceClass_All, PriceClass_200, PriceClass_100.</summary>
    [JsonPropertyName("priceClass")]
    public string? PriceClass { get; set; }

    /// <summary>The restriction configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("restrictions")]
    public V1beta2DistributionStatusAtProviderRestrictions? Restrictions { get; set; }

    /// <summary>If this is set, the distribution needs to be deleted manually afterwards. Default: false.</summary>
    [JsonPropertyName("retainOnDelete")]
    public bool? RetainOnDelete { get; set; }

    /// <summary>A Boolean that indicates whether this is a staging distribution. Defaults to false.</summary>
    [JsonPropertyName("staging")]
    public bool? Staging { get; set; }

    /// <summary>Current status of the distribution. Deployed if the distribution&apos;s information is fully propagated throughout the Amazon CloudFront system.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>List of key group IDs that CloudFront can use to validate signed URLs or signed cookies. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedKeyGroups")]
    public IList<V1beta2DistributionStatusAtProviderTrustedKeyGroups>? TrustedKeyGroups { get; set; }

    /// <summary>List of AWS account IDs (or self) that you want to allow to create signed URLs for private content. See the CloudFront User Guide for more information about this feature.</summary>
    [JsonPropertyName("trustedSigners")]
    public IList<V1beta2DistributionStatusAtProviderTrustedSigners>? TrustedSigners { get; set; }

    /// <summary>The SSL configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerCertificate")]
    public V1beta2DistributionStatusAtProviderViewerCertificate? ViewerCertificate { get; set; }

    /// <summary>The viewer mTLS configuration for this distribution (maximum one).</summary>
    [JsonPropertyName("viewerMtlsConfig")]
    public V1beta2DistributionStatusAtProviderViewerMtlsConfig? ViewerMtlsConfig { get; set; }

    /// <summary>If enabled, the resource will wait for the distribution status to change from InProgress to Deployed. Setting this tofalse will skip the process. Default: true.</summary>
    [JsonPropertyName("waitForDeployment")]
    public bool? WaitForDeployment { get; set; }

    /// <summary>Unique identifier that specifies the AWS WAF web ACL, if any, to associate with this distribution. To specify a web ACL created using the latest version of AWS WAF (WAFv2), use the ACL ARN, for example aws_wafv2_web_acl.example.arn. To specify a web ACL created using AWS WAF Classic, use the ACL ID, for example aws_waf_web_acl.example.id. The WAF Web ACL must exist in the WAF Global (CloudFront) region and the credentials configuring this argument must have waf:GetWebACL permissions assigned.</summary>
    [JsonPropertyName("webAclId")]
    public string? WebAclId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatusConditions
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

/// <summary>DistributionStatus defines the observed state of Distribution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DistributionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DistributionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DistributionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Distribution is the Schema for the Distributions API. Provides a CloudFront web distribution resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Distribution : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DistributionSpec>, IStatus<V1beta2DistributionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Distribution";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "distributions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Distribution";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DistributionSpec defines the desired state of Distribution</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DistributionSpec Spec { get; set; }

    /// <summary>DistributionStatus defines the observed state of Distribution.</summary>
    [JsonPropertyName("status")]
    public V1beta2DistributionStatus? Status { get; set; }
}