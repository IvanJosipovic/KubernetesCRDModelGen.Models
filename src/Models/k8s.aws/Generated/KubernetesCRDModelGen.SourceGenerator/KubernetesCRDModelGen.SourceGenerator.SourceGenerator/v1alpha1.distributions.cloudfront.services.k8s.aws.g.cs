#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.services.k8s.aws;
/// <summary>Distribution is the Schema for the Distributions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DistributionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Distribution>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DistributionList";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "distributions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DistributionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Distribution objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Distribution> Items { get; set; }
}

/// <summary>
/// A complex type that contains information about CNAMEs (alternate domain names),
/// if any, for this distribution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigAliases
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A complex type that controls whether CloudFront caches the response to requests
/// using the specified HTTP methods. There are two choices:
/// 
///    * CloudFront caches responses to GET and HEAD requests.
/// 
///    * CloudFront caches responses to GET, HEAD, and OPTIONS requests.
/// 
/// If you pick the second choice for your Amazon S3 Origin, you may need to
/// forward Access-Control-Request-Method, Access-Control-Request-Headers, and
/// Origin headers for the responses to be cached correctly.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsAllowedMethodsCachedMethods
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A complex type that controls which HTTP methods CloudFront processes and
/// forwards to your Amazon S3 bucket or your custom origin. There are three
/// choices:
/// 
///    * CloudFront forwards only GET and HEAD requests.
/// 
///    * CloudFront forwards only GET, HEAD, and OPTIONS requests.
/// 
///    * CloudFront forwards GET, HEAD, OPTIONS, PUT, PATCH, POST, and DELETE
///    requests.
/// 
/// If you pick the third choice, you may need to restrict access to your Amazon
/// S3 bucket or to your custom origin so users can&apos;t perform operations that
/// you don&apos;t want them to. For example, you might not want users to have permissions
/// to delete objects from your origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsAllowedMethods
{
    /// <summary>
    /// A complex type that controls whether CloudFront caches the response to requests
    /// using the specified HTTP methods. There are two choices:
    /// 
    ///    * CloudFront caches responses to GET and HEAD requests.
    /// 
    ///    * CloudFront caches responses to GET, HEAD, and OPTIONS requests.
    /// 
    /// If you pick the second choice for your Amazon S3 Origin, you may need to
    /// forward Access-Control-Request-Method, Access-Control-Request-Headers, and
    /// Origin headers for the responses to be cached correctly.
    /// </summary>
    [JsonPropertyName("cachedMethods")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsAllowedMethodsCachedMethods? CachedMethods { get; set; }

    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Contains a list of cookie names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesCookiesWhitelistedNames
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// This field is deprecated. We recommend that you use a cache policy or an
/// origin request policy instead of this field.
/// 
/// If you want to include cookies in the cache key, use CookiesConfig in a cache
/// policy. See CachePolicy.
/// 
/// If you want to send cookies to the origin but not include them in the cache
/// key, use CookiesConfig in an origin request policy. See OriginRequestPolicy.
/// 
/// A complex type that specifies whether you want CloudFront to forward cookies
/// to the origin and, if so, which ones. For more information about forwarding
/// cookies to the origin, see Caching Content Based on Cookies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Cookies.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesCookies
{
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>Contains a list of cookie names.</summary>
    [JsonPropertyName("whitelistedNames")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesCookiesWhitelistedNames? WhitelistedNames { get; set; }
}

/// <summary>Contains a list of HTTP header names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// This field is deprecated. We recommend that you use a cache policy or an
/// origin request policy instead of this field.
/// 
/// If you want to include query strings in the cache key, use QueryStringsConfig
/// in a cache policy. See CachePolicy.
/// 
/// If you want to send query strings to the origin but not include them in the
/// cache key, use QueryStringsConfig in an origin request policy. See OriginRequestPolicy.
/// 
/// A complex type that contains information about the query string parameters
/// that you want CloudFront to use for caching for a cache behavior.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesQueryStringCacheKeys
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// This field only supports standard distributions. You can&apos;t specify this field
/// for multi-tenant distributions. For more information, see Unsupported features
/// for SaaS Manager for Amazon CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas)
/// in the Amazon CloudFront Developer Guide.
/// 
/// This field is deprecated. We recommend that you use a cache policy or an
/// origin request policy instead of this field.
/// 
/// If you want to include values in the cache key, use a cache policy. For more
/// information, see Creating cache policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy)
/// in the Amazon CloudFront Developer Guide.
/// 
/// If you want to send values to the origin but not include them in the cache
/// key, use an origin request policy. For more information, see Creating origin
/// request policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy)
/// in the Amazon CloudFront Developer Guide.
/// 
/// A complex type that specifies how CloudFront handles query strings, cookies,
/// and HTTP headers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValues
{
    /// <summary>
    /// This field is deprecated. We recommend that you use a cache policy or an
    /// origin request policy instead of this field.
    /// 
    /// If you want to include cookies in the cache key, use CookiesConfig in a cache
    /// policy. See CachePolicy.
    /// 
    /// If you want to send cookies to the origin but not include them in the cache
    /// key, use CookiesConfig in an origin request policy. See OriginRequestPolicy.
    /// 
    /// A complex type that specifies whether you want CloudFront to forward cookies
    /// to the origin and, if so, which ones. For more information about forwarding
    /// cookies to the origin, see Caching Content Based on Cookies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Cookies.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Contains a list of HTTP header names.</summary>
    [JsonPropertyName("headers")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesHeaders? Headers { get; set; }

    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>
    /// This field is deprecated. We recommend that you use a cache policy or an
    /// origin request policy instead of this field.
    /// 
    /// If you want to include query strings in the cache key, use QueryStringsConfig
    /// in a cache policy. See CachePolicy.
    /// 
    /// If you want to send query strings to the origin but not include them in the
    /// cache key, use QueryStringsConfig in an origin request policy. See OriginRequestPolicy.
    /// 
    /// A complex type that contains information about the query string parameters
    /// that you want CloudFront to use for caching for a cache behavior.
    /// </summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValuesQueryStringCacheKeys? QueryStringCacheKeys { get; set; }
}

/// <summary>
/// A CloudFront function that is associated with a cache behavior in a CloudFront
/// distribution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsFunctionAssociationsItems
{
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    [JsonPropertyName("functionARN")]
    public string? FunctionARN { get; set; }
}

/// <summary>
/// A list of CloudFront functions that are associated with a cache behavior
/// in a CloudFront distribution. Your functions must be published to the LIVE
/// stage to associate them with a cache behavior.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsFunctionAssociations
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsFunctionAssociationsItems>? Items { get; set; }
}

/// <summary>A complex type that contains a Lambda@Edge function association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsLambdaFunctionAssociationsItems
{
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    [JsonPropertyName("lambdaFunctionARN")]
    public string? LambdaFunctionARN { get; set; }
}

/// <summary>
/// A complex type that specifies a list of Lambda@Edge functions associations
/// for a cache behavior.
/// 
/// If you want to invoke one or more Lambda@Edge functions triggered by requests
/// that match the PathPattern of the cache behavior, specify the applicable
/// values for Quantity and Items. Note that there can be up to 4 LambdaFunctionAssociation
/// items in this list (one for each possible value of EventType) and each EventType
/// can be associated with only one function.
/// 
/// If you don&apos;t want to invoke any Lambda@Edge functions for the requests that
/// match PathPattern, specify 0 for Quantity and omit Items.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsLambdaFunctionAssociations
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsLambdaFunctionAssociationsItems>? Items { get; set; }
}

/// <summary>
/// A list of key groups whose public keys CloudFront can use to verify the signatures
/// of signed URLs and signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsTrustedKeyGroups
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A list of Amazon Web Services accounts whose public keys CloudFront can use
/// to verify the signatures of signed URLs and signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsTrustedSigners
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A complex type that describes how CloudFront processes requests.
/// 
/// You must create at least as many cache behaviors (including the default cache
/// behavior) as you have origins if you want CloudFront to serve objects from
/// all of the origins. Each cache behavior specifies the one origin from which
/// you want CloudFront to get objects. If you have two origins and only the
/// default cache behavior, the default cache behavior will cause CloudFront
/// to get objects from one of the origins, but the other origin is never used.
/// 
/// For the current quota (formerly known as limit) on the number of cache behaviors
/// that you can add to a distribution, see Quotas (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html)
/// in the Amazon CloudFront Developer Guide.
/// 
/// If you don&apos;t want to specify any cache behaviors, include only an empty CacheBehaviors
/// element. Don&apos;t specify an empty individual CacheBehavior element, because
/// this is invalid. For more information, see CacheBehaviors (https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CacheBehaviors.html).
/// 
/// To delete all cache behaviors in an existing distribution, update the distribution
/// configuration and include only an empty CacheBehaviors element.
/// 
/// To add, change, or remove one or more cache behaviors, update the distribution
/// configuration and specify all of the cache behaviors that you want to include
/// in the updated distribution.
/// 
/// If your minimum TTL is greater than 0, CloudFront will cache content for
/// at least the duration specified in the cache policy&apos;s minimum TTL, even if
/// the Cache-Control: no-cache, no-store, or private directives are present
/// in the origin headers.
/// 
/// For more information about cache behaviors, see Cache Behavior Settings (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesCacheBehavior)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItems
{
    /// <summary>
    /// A complex type that controls which HTTP methods CloudFront processes and
    /// forwards to your Amazon S3 bucket or your custom origin. There are three
    /// choices:
    /// 
    ///    * CloudFront forwards only GET and HEAD requests.
    /// 
    ///    * CloudFront forwards only GET, HEAD, and OPTIONS requests.
    /// 
    ///    * CloudFront forwards GET, HEAD, OPTIONS, PUT, PATCH, POST, and DELETE
    ///    requests.
    /// 
    /// If you pick the third choice, you may need to restrict access to your Amazon
    /// S3 bucket or to your custom origin so users can&apos;t perform operations that
    /// you don&apos;t want them to. For example, you might not want users to have permissions
    /// to delete objects from your origin.
    /// </summary>
    [JsonPropertyName("allowedMethods")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsAllowedMethods? AllowedMethods { get; set; }

    [JsonPropertyName("cachePolicyID")]
    public string? CachePolicyID { get; set; }

    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    [JsonPropertyName("defaultTTL")]
    public long? DefaultTTL { get; set; }

    [JsonPropertyName("fieldLevelEncryptionID")]
    public string? FieldLevelEncryptionID { get; set; }

    /// <summary>
    /// This field only supports standard distributions. You can&apos;t specify this field
    /// for multi-tenant distributions. For more information, see Unsupported features
    /// for SaaS Manager for Amazon CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas)
    /// in the Amazon CloudFront Developer Guide.
    /// 
    /// This field is deprecated. We recommend that you use a cache policy or an
    /// origin request policy instead of this field.
    /// 
    /// If you want to include values in the cache key, use a cache policy. For more
    /// information, see Creating cache policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy)
    /// in the Amazon CloudFront Developer Guide.
    /// 
    /// If you want to send values to the origin but not include them in the cache
    /// key, use an origin request policy. For more information, see Creating origin
    /// request policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy)
    /// in the Amazon CloudFront Developer Guide.
    /// 
    /// A complex type that specifies how CloudFront handles query strings, cookies,
    /// and HTTP headers.
    /// </summary>
    [JsonPropertyName("forwardedValues")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsForwardedValues? ForwardedValues { get; set; }

    /// <summary>
    /// A list of CloudFront functions that are associated with a cache behavior
    /// in a CloudFront distribution. Your functions must be published to the LIVE
    /// stage to associate them with a cache behavior.
    /// </summary>
    [JsonPropertyName("functionAssociations")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsFunctionAssociations? FunctionAssociations { get; set; }

    /// <summary>
    /// A complex type that specifies a list of Lambda@Edge functions associations
    /// for a cache behavior.
    /// 
    /// If you want to invoke one or more Lambda@Edge functions triggered by requests
    /// that match the PathPattern of the cache behavior, specify the applicable
    /// values for Quantity and Items. Note that there can be up to 4 LambdaFunctionAssociation
    /// items in this list (one for each possible value of EventType) and each EventType
    /// can be associated with only one function.
    /// 
    /// If you don&apos;t want to invoke any Lambda@Edge functions for the requests that
    /// match PathPattern, specify 0 for Quantity and omit Items.
    /// </summary>
    [JsonPropertyName("lambdaFunctionAssociations")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsLambdaFunctionAssociations? LambdaFunctionAssociations { get; set; }

    [JsonPropertyName("maxTTL")]
    public long? MaxTTL { get; set; }

    [JsonPropertyName("minTTL")]
    public long? MinTTL { get; set; }

    [JsonPropertyName("originRequestPolicyID")]
    public string? OriginRequestPolicyID { get; set; }

    [JsonPropertyName("pathPattern")]
    public string? PathPattern { get; set; }

    [JsonPropertyName("realtimeLogConfigARN")]
    public string? RealtimeLogConfigARN { get; set; }

    [JsonPropertyName("responseHeadersPolicyID")]
    public string? ResponseHeadersPolicyID { get; set; }

    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    [JsonPropertyName("targetOriginID")]
    public string? TargetOriginID { get; set; }

    /// <summary>
    /// A list of key groups whose public keys CloudFront can use to verify the signatures
    /// of signed URLs and signed cookies.
    /// </summary>
    [JsonPropertyName("trustedKeyGroups")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsTrustedKeyGroups? TrustedKeyGroups { get; set; }

    /// <summary>
    /// A list of Amazon Web Services accounts whose public keys CloudFront can use
    /// to verify the signatures of signed URLs and signed cookies.
    /// </summary>
    [JsonPropertyName("trustedSigners")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItemsTrustedSigners? TrustedSigners { get; set; }

    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary>A complex type that contains zero or more CacheBehavior elements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheBehaviors
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigCacheBehaviorsItems>? Items { get; set; }
}

/// <summary>
/// A complex type that specifies the HTTP header name from which CloudFront
/// extracts cache tags from origin responses. When you add CacheTagConfig to
/// a distribution, CloudFront reads the specified header from origin responses,
/// parses the comma-separated tag values, and stores them with the cached object.
/// You can then invalidate cached objects by tag using the CreateInvalidation
/// API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCacheTagConfig
{
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>A connection function association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigConnectionFunctionAssociation
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// A complex type that controls:
/// 
///   - Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range
///     with custom error messages before returning the response to the viewer.
/// 
///   - How long CloudFront caches HTTP status codes in the 4xx and 5xx range.
/// 
/// For more information about custom error pages, see Customizing Error Responses
/// (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCustomErrorResponsesItems
{
    [JsonPropertyName("errorCachingMinTTL")]
    public long? ErrorCachingMinTTL { get; set; }

    [JsonPropertyName("errorCode")]
    public long? ErrorCode { get; set; }

    [JsonPropertyName("responseCode")]
    public string? ResponseCode { get; set; }

    [JsonPropertyName("responsePagePath")]
    public string? ResponsePagePath { get; set; }
}

/// <summary>
/// A complex type that controls:
/// 
///    * Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range
///    with custom error messages before returning the response to the viewer.
/// 
///    * How long CloudFront caches HTTP status codes in the 4xx and 5xx range.
/// 
/// For more information about custom error pages, see Customizing Error Responses
/// (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigCustomErrorResponses
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigCustomErrorResponsesItems>? Items { get; set; }
}

/// <summary>
/// A complex type that controls whether CloudFront caches the response to requests
/// using the specified HTTP methods. There are two choices:
/// 
///    * CloudFront caches responses to GET and HEAD requests.
/// 
///    * CloudFront caches responses to GET, HEAD, and OPTIONS requests.
/// 
/// If you pick the second choice for your Amazon S3 Origin, you may need to
/// forward Access-Control-Request-Method, Access-Control-Request-Headers, and
/// Origin headers for the responses to be cached correctly.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethods
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A complex type that controls which HTTP methods CloudFront processes and
/// forwards to your Amazon S3 bucket or your custom origin. There are three
/// choices:
/// 
///    * CloudFront forwards only GET and HEAD requests.
/// 
///    * CloudFront forwards only GET, HEAD, and OPTIONS requests.
/// 
///    * CloudFront forwards GET, HEAD, OPTIONS, PUT, PATCH, POST, and DELETE
///    requests.
/// 
/// If you pick the third choice, you may need to restrict access to your Amazon
/// S3 bucket or to your custom origin so users can&apos;t perform operations that
/// you don&apos;t want them to. For example, you might not want users to have permissions
/// to delete objects from your origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorAllowedMethods
{
    /// <summary>
    /// A complex type that controls whether CloudFront caches the response to requests
    /// using the specified HTTP methods. There are two choices:
    /// 
    ///    * CloudFront caches responses to GET and HEAD requests.
    /// 
    ///    * CloudFront caches responses to GET, HEAD, and OPTIONS requests.
    /// 
    /// If you pick the second choice for your Amazon S3 Origin, you may need to
    /// forward Access-Control-Request-Method, Access-Control-Request-Headers, and
    /// Origin headers for the responses to be cached correctly.
    /// </summary>
    [JsonPropertyName("cachedMethods")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorAllowedMethodsCachedMethods? CachedMethods { get; set; }

    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Contains a list of cookie names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNames
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// This field is deprecated. We recommend that you use a cache policy or an
/// origin request policy instead of this field.
/// 
/// If you want to include cookies in the cache key, use CookiesConfig in a cache
/// policy. See CachePolicy.
/// 
/// If you want to send cookies to the origin but not include them in the cache
/// key, use CookiesConfig in an origin request policy. See OriginRequestPolicy.
/// 
/// A complex type that specifies whether you want CloudFront to forward cookies
/// to the origin and, if so, which ones. For more information about forwarding
/// cookies to the origin, see Caching Content Based on Cookies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Cookies.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesCookies
{
    [JsonPropertyName("forward")]
    public string? Forward { get; set; }

    /// <summary>Contains a list of cookie names.</summary>
    [JsonPropertyName("whitelistedNames")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNames? WhitelistedNames { get; set; }
}

/// <summary>Contains a list of HTTP header names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// This field is deprecated. We recommend that you use a cache policy or an
/// origin request policy instead of this field.
/// 
/// If you want to include query strings in the cache key, use QueryStringsConfig
/// in a cache policy. See CachePolicy.
/// 
/// If you want to send query strings to the origin but not include them in the
/// cache key, use QueryStringsConfig in an origin request policy. See OriginRequestPolicy.
/// 
/// A complex type that contains information about the query string parameters
/// that you want CloudFront to use for caching for a cache behavior.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeys
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// This field only supports standard distributions. You can&apos;t specify this field
/// for multi-tenant distributions. For more information, see Unsupported features
/// for SaaS Manager for Amazon CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas)
/// in the Amazon CloudFront Developer Guide.
/// 
/// This field is deprecated. We recommend that you use a cache policy or an
/// origin request policy instead of this field.
/// 
/// If you want to include values in the cache key, use a cache policy. For more
/// information, see Creating cache policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy)
/// in the Amazon CloudFront Developer Guide.
/// 
/// If you want to send values to the origin but not include them in the cache
/// key, use an origin request policy. For more information, see Creating origin
/// request policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy)
/// in the Amazon CloudFront Developer Guide.
/// 
/// A complex type that specifies how CloudFront handles query strings, cookies,
/// and HTTP headers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValues
{
    /// <summary>
    /// This field is deprecated. We recommend that you use a cache policy or an
    /// origin request policy instead of this field.
    /// 
    /// If you want to include cookies in the cache key, use CookiesConfig in a cache
    /// policy. See CachePolicy.
    /// 
    /// If you want to send cookies to the origin but not include them in the cache
    /// key, use CookiesConfig in an origin request policy. See OriginRequestPolicy.
    /// 
    /// A complex type that specifies whether you want CloudFront to forward cookies
    /// to the origin and, if so, which ones. For more information about forwarding
    /// cookies to the origin, see Caching Content Based on Cookies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Cookies.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesCookies? Cookies { get; set; }

    /// <summary>Contains a list of HTTP header names.</summary>
    [JsonPropertyName("headers")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesHeaders? Headers { get; set; }

    [JsonPropertyName("queryString")]
    public bool? QueryString { get; set; }

    /// <summary>
    /// This field is deprecated. We recommend that you use a cache policy or an
    /// origin request policy instead of this field.
    /// 
    /// If you want to include query strings in the cache key, use QueryStringsConfig
    /// in a cache policy. See CachePolicy.
    /// 
    /// If you want to send query strings to the origin but not include them in the
    /// cache key, use QueryStringsConfig in an origin request policy. See OriginRequestPolicy.
    /// 
    /// A complex type that contains information about the query string parameters
    /// that you want CloudFront to use for caching for a cache behavior.
    /// </summary>
    [JsonPropertyName("queryStringCacheKeys")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValuesQueryStringCacheKeys? QueryStringCacheKeys { get; set; }
}

/// <summary>
/// A CloudFront function that is associated with a cache behavior in a CloudFront
/// distribution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems
{
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    [JsonPropertyName("functionARN")]
    public string? FunctionARN { get; set; }
}

/// <summary>
/// A list of CloudFront functions that are associated with a cache behavior
/// in a CloudFront distribution. Your functions must be published to the LIVE
/// stage to associate them with a cache behavior.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorFunctionAssociations
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorFunctionAssociationsItems>? Items { get; set; }
}

/// <summary>A complex type that contains a Lambda@Edge function association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems
{
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    [JsonPropertyName("includeBody")]
    public bool? IncludeBody { get; set; }

    [JsonPropertyName("lambdaFunctionARN")]
    public string? LambdaFunctionARN { get; set; }
}

/// <summary>
/// A complex type that specifies a list of Lambda@Edge functions associations
/// for a cache behavior.
/// 
/// If you want to invoke one or more Lambda@Edge functions triggered by requests
/// that match the PathPattern of the cache behavior, specify the applicable
/// values for Quantity and Items. Note that there can be up to 4 LambdaFunctionAssociation
/// items in this list (one for each possible value of EventType) and each EventType
/// can be associated with only one function.
/// 
/// If you don&apos;t want to invoke any Lambda@Edge functions for the requests that
/// match PathPattern, specify 0 for Quantity and omit Items.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociations
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociationsItems>? Items { get; set; }
}

/// <summary>
/// A list of key groups whose public keys CloudFront can use to verify the signatures
/// of signed URLs and signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorTrustedKeyGroups
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A list of Amazon Web Services accounts whose public keys CloudFront can use
/// to verify the signatures of signed URLs and signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorTrustedSigners
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A complex type that describes the default cache behavior if you don&apos;t specify
/// a CacheBehavior element or if request URLs don&apos;t match any of the values
/// of PathPattern in CacheBehavior elements. You must create exactly one default
/// cache behavior.
/// 
/// If your minimum TTL is greater than 0, CloudFront will cache content for
/// at least the duration specified in the cache policy&apos;s minimum TTL, even if
/// the Cache-Control: no-cache, no-store, or private directives are present
/// in the origin headers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigDefaultCacheBehavior
{
    /// <summary>
    /// A complex type that controls which HTTP methods CloudFront processes and
    /// forwards to your Amazon S3 bucket or your custom origin. There are three
    /// choices:
    /// 
    ///    * CloudFront forwards only GET and HEAD requests.
    /// 
    ///    * CloudFront forwards only GET, HEAD, and OPTIONS requests.
    /// 
    ///    * CloudFront forwards GET, HEAD, OPTIONS, PUT, PATCH, POST, and DELETE
    ///    requests.
    /// 
    /// If you pick the third choice, you may need to restrict access to your Amazon
    /// S3 bucket or to your custom origin so users can&apos;t perform operations that
    /// you don&apos;t want them to. For example, you might not want users to have permissions
    /// to delete objects from your origin.
    /// </summary>
    [JsonPropertyName("allowedMethods")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorAllowedMethods? AllowedMethods { get; set; }

    [JsonPropertyName("cachePolicyID")]
    public string? CachePolicyID { get; set; }

    [JsonPropertyName("compress")]
    public bool? Compress { get; set; }

    [JsonPropertyName("defaultTTL")]
    public long? DefaultTTL { get; set; }

    [JsonPropertyName("fieldLevelEncryptionID")]
    public string? FieldLevelEncryptionID { get; set; }

    /// <summary>
    /// This field only supports standard distributions. You can&apos;t specify this field
    /// for multi-tenant distributions. For more information, see Unsupported features
    /// for SaaS Manager for Amazon CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas)
    /// in the Amazon CloudFront Developer Guide.
    /// 
    /// This field is deprecated. We recommend that you use a cache policy or an
    /// origin request policy instead of this field.
    /// 
    /// If you want to include values in the cache key, use a cache policy. For more
    /// information, see Creating cache policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy)
    /// in the Amazon CloudFront Developer Guide.
    /// 
    /// If you want to send values to the origin but not include them in the cache
    /// key, use an origin request policy. For more information, see Creating origin
    /// request policies (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy)
    /// in the Amazon CloudFront Developer Guide.
    /// 
    /// A complex type that specifies how CloudFront handles query strings, cookies,
    /// and HTTP headers.
    /// </summary>
    [JsonPropertyName("forwardedValues")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorForwardedValues? ForwardedValues { get; set; }

    /// <summary>
    /// A list of CloudFront functions that are associated with a cache behavior
    /// in a CloudFront distribution. Your functions must be published to the LIVE
    /// stage to associate them with a cache behavior.
    /// </summary>
    [JsonPropertyName("functionAssociations")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorFunctionAssociations? FunctionAssociations { get; set; }

    /// <summary>
    /// A complex type that specifies a list of Lambda@Edge functions associations
    /// for a cache behavior.
    /// 
    /// If you want to invoke one or more Lambda@Edge functions triggered by requests
    /// that match the PathPattern of the cache behavior, specify the applicable
    /// values for Quantity and Items. Note that there can be up to 4 LambdaFunctionAssociation
    /// items in this list (one for each possible value of EventType) and each EventType
    /// can be associated with only one function.
    /// 
    /// If you don&apos;t want to invoke any Lambda@Edge functions for the requests that
    /// match PathPattern, specify 0 for Quantity and omit Items.
    /// </summary>
    [JsonPropertyName("lambdaFunctionAssociations")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorLambdaFunctionAssociations? LambdaFunctionAssociations { get; set; }

    [JsonPropertyName("maxTTL")]
    public long? MaxTTL { get; set; }

    [JsonPropertyName("minTTL")]
    public long? MinTTL { get; set; }

    [JsonPropertyName("originRequestPolicyID")]
    public string? OriginRequestPolicyID { get; set; }

    [JsonPropertyName("realtimeLogConfigARN")]
    public string? RealtimeLogConfigARN { get; set; }

    [JsonPropertyName("responseHeadersPolicyID")]
    public string? ResponseHeadersPolicyID { get; set; }

    [JsonPropertyName("smoothStreaming")]
    public bool? SmoothStreaming { get; set; }

    [JsonPropertyName("targetOriginID")]
    public string? TargetOriginID { get; set; }

    /// <summary>
    /// A list of key groups whose public keys CloudFront can use to verify the signatures
    /// of signed URLs and signed cookies.
    /// </summary>
    [JsonPropertyName("trustedKeyGroups")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorTrustedKeyGroups? TrustedKeyGroups { get; set; }

    /// <summary>
    /// A list of Amazon Web Services accounts whose public keys CloudFront can use
    /// to verify the signatures of signed URLs and signed cookies.
    /// </summary>
    [JsonPropertyName("trustedSigners")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehaviorTrustedSigners? TrustedSigners { get; set; }

    [JsonPropertyName("viewerProtocolPolicy")]
    public string? ViewerProtocolPolicy { get; set; }
}

/// <summary>
/// A complex type that specifies whether access logs are written for the distribution.
/// 
/// If you already enabled standard logging (legacy) and you want to enable standard
/// logging (v2) to send your access logs to Amazon S3, we recommend that you
/// specify a different Amazon S3 bucket or use a separate path in the same bucket
/// (for example, use a log prefix or partitioning). This helps you keep track
/// of which log files are associated with which logging subscription and prevents
/// log files from overwriting each other. For more information, see Standard
/// logging (access logs) (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/AccessLogs.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigLogging
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("includeCookies")]
    public bool? IncludeCookies { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>
/// A complex data type for the status codes that you specify that, when returned
/// by a primary origin, trigger CloudFront to failover to a second origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsFailoverCriteriaStatusCodes
{
    /// <summary>List of status codes for origin failover.</summary>
    [JsonPropertyName("items")]
    public IList<long>? Items { get; set; }
}

/// <summary>
/// A complex data type that includes information about the failover criteria
/// for an origin group, including the status codes for which CloudFront will
/// failover from the primary origin to the second origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsFailoverCriteria
{
    /// <summary>
    /// A complex data type for the status codes that you specify that, when returned
    /// by a primary origin, trigger CloudFront to failover to a second origin.
    /// </summary>
    [JsonPropertyName("statusCodes")]
    public V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsFailoverCriteriaStatusCodes? StatusCodes { get; set; }
}

/// <summary>An origin in an origin group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsMembersItems
{
    [JsonPropertyName("originID")]
    public string? OriginID { get; set; }
}

/// <summary>A complex data type for the origins included in an origin group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsMembers
{
    /// <summary>List of origins in an origin group.</summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsMembersItems>? Items { get; set; }
}

/// <summary>
/// An origin group includes two origins (a primary origin and a secondary origin
/// to failover to) and a failover criteria that you specify. You create an origin
/// group to support origin failover in CloudFront. When you create or update
/// a distribution, you can specify the origin group instead of a single origin,
/// and CloudFront will failover from the primary origin to the secondary origin
/// under the failover conditions that you&apos;ve chosen.
/// 
/// Optionally, you can choose selection criteria for your origin group to specify
/// how your origins are selected when your distribution routes viewer requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginGroupsItems
{
    /// <summary>
    /// A complex data type that includes information about the failover criteria
    /// for an origin group, including the status codes for which CloudFront will
    /// failover from the primary origin to the second origin.
    /// </summary>
    [JsonPropertyName("failoverCriteria")]
    public V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsFailoverCriteria? FailoverCriteria { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A complex data type for the origins included in an origin group.</summary>
    [JsonPropertyName("members")]
    public V1alpha1DistributionSpecDistributionConfigOriginGroupsItemsMembers? Members { get; set; }
}

/// <summary>A complex data type for the origin groups specified for a distribution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginGroups
{
    /// <summary>List of origin groups for a distribution.</summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigOriginGroupsItems>? Items { get; set; }
}

/// <summary>
/// A complex type that contains HeaderName and HeaderValue elements, if any,
/// for this distribution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomHeadersItems
{
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>A complex type that contains the list of Custom Headers for each origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomHeaders
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomHeadersItems>? Items { get; set; }
}

/// <summary>Configures mutual TLS authentication between CloudFront and your origin server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomOriginConfigOriginMtlsConfig
{
    [JsonPropertyName("clientCertificateARN")]
    public string? ClientCertificateARN { get; set; }
}

/// <summary>
/// A complex type that contains information about the SSL/TLS protocols that
/// CloudFront can use when establishing an HTTPS connection with your origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomOriginConfigOriginSSLProtocols
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A custom origin. A custom origin is any origin that is not an Amazon S3 bucket,
/// with one exception. An Amazon S3 bucket that is configured with static website
/// hosting (https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html)
/// is a custom origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomOriginConfig
{
    [JsonPropertyName("httpPort")]
    public long? HttpPort { get; set; }

    [JsonPropertyName("httpSPort")]
    public long? HttpSPort { get; set; }

    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    [JsonPropertyName("originKeepaliveTimeout")]
    public long? OriginKeepaliveTimeout { get; set; }

    /// <summary>Configures mutual TLS authentication between CloudFront and your origin server.</summary>
    [JsonPropertyName("originMtlsConfig")]
    public V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomOriginConfigOriginMtlsConfig? OriginMtlsConfig { get; set; }

    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    [JsonPropertyName("originReadTimeout")]
    public long? OriginReadTimeout { get; set; }

    /// <summary>
    /// A complex type that contains information about the SSL/TLS protocols that
    /// CloudFront can use when establishing an HTTPS connection with your origin.
    /// </summary>
    [JsonPropertyName("originSSLProtocols")]
    public V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomOriginConfigOriginSSLProtocols? OriginSSLProtocols { get; set; }
}

/// <summary>
/// CloudFront Origin Shield.
/// 
/// Using Origin Shield can help reduce the load on your origin. For more information,
/// see Using Origin Shield (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/origin-shield.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsOriginShield
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("originShieldRegion")]
    public string? OriginShieldRegion { get; set; }
}

/// <summary>
/// A complex type that contains information about the Amazon S3 origin. If the
/// origin is a custom origin or an S3 bucket that is configured as a website
/// endpoint, use the CustomOriginConfig element instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsS3OriginConfig
{
    [JsonPropertyName("originAccessIdentity")]
    public string? OriginAccessIdentity { get; set; }

    [JsonPropertyName("originReadTimeout")]
    public long? OriginReadTimeout { get; set; }
}

/// <summary>An Amazon CloudFront VPC origin configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItemsVpcOriginConfig
{
    [JsonPropertyName("originKeepaliveTimeout")]
    public long? OriginKeepaliveTimeout { get; set; }

    [JsonPropertyName("originReadTimeout")]
    public long? OriginReadTimeout { get; set; }

    [JsonPropertyName("ownerAccountID")]
    public string? OwnerAccountID { get; set; }

    [JsonPropertyName("vpcOriginID")]
    public string? VpcOriginID { get; set; }
}

/// <summary>
/// An origin.
/// 
/// An origin is the location where content is stored, and from which CloudFront
/// gets content to serve to viewers. To specify an origin:
/// 
///   - Use S3OriginConfig to specify an Amazon S3 bucket that is not configured
///     with static website hosting.
/// 
///   - Use VpcOriginConfig to specify a VPC origin.
/// 
///   - Use CustomOriginConfig to specify all other kinds of origins, including:
///     An Amazon S3 bucket that is configured with static website hosting An
///     Elastic Load Balancing load balancer An Elemental MediaPackage endpoint
///     An Elemental MediaStore container Any other HTTP server, running on an
///     Amazon EC2 instance or any other kind of host
/// 
/// For the current maximum number of origins that you can specify per distribution,
/// see General Quotas on Web Distributions (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/cloudfront-limits.html#limits-web-distributions)
/// in the Amazon CloudFront Developer Guide (quotas were formerly referred to
/// as limits).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOriginsItems
{
    [JsonPropertyName("connectionAttempts")]
    public long? ConnectionAttempts { get; set; }

    [JsonPropertyName("connectionTimeout")]
    public long? ConnectionTimeout { get; set; }

    /// <summary>A complex type that contains the list of Custom Headers for each origin.</summary>
    [JsonPropertyName("customHeaders")]
    public V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomHeaders? CustomHeaders { get; set; }

    /// <summary>
    /// A custom origin. A custom origin is any origin that is not an Amazon S3 bucket,
    /// with one exception. An Amazon S3 bucket that is configured with static website
    /// hosting (https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html)
    /// is a custom origin.
    /// </summary>
    [JsonPropertyName("customOriginConfig")]
    public V1alpha1DistributionSpecDistributionConfigOriginsItemsCustomOriginConfig? CustomOriginConfig { get; set; }

    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("originAccessControlID")]
    public string? OriginAccessControlID { get; set; }

    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>
    /// CloudFront Origin Shield.
    /// 
    /// Using Origin Shield can help reduce the load on your origin. For more information,
    /// see Using Origin Shield (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/origin-shield.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("originShield")]
    public V1alpha1DistributionSpecDistributionConfigOriginsItemsOriginShield? OriginShield { get; set; }

    [JsonPropertyName("responseCompletionTimeout")]
    public long? ResponseCompletionTimeout { get; set; }

    /// <summary>
    /// A complex type that contains information about the Amazon S3 origin. If the
    /// origin is a custom origin or an S3 bucket that is configured as a website
    /// endpoint, use the CustomOriginConfig element instead.
    /// </summary>
    [JsonPropertyName("s3OriginConfig")]
    public V1alpha1DistributionSpecDistributionConfigOriginsItemsS3OriginConfig? S3OriginConfig { get; set; }

    /// <summary>An Amazon CloudFront VPC origin configuration.</summary>
    [JsonPropertyName("vpcOriginConfig")]
    public V1alpha1DistributionSpecDistributionConfigOriginsItemsVpcOriginConfig? VpcOriginConfig { get; set; }
}

/// <summary>Contains information about the origins for this distribution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigOrigins
{
    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionSpecDistributionConfigOriginsItems>? Items { get; set; }
}

/// <summary>
/// A complex type that controls the countries in which your content is distributed.
/// CloudFront determines the location of your users using MaxMind GeoIP databases.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigRestrictionsGeoRestriction
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }

    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary>
/// A complex type that identifies ways in which you want to restrict distribution
/// of your content.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigRestrictions
{
    /// <summary>
    /// A complex type that controls the countries in which your content is distributed.
    /// CloudFront determines the location of your users using MaxMind GeoIP databases.
    /// </summary>
    [JsonPropertyName("geoRestriction")]
    public V1alpha1DistributionSpecDistributionConfigRestrictionsGeoRestriction? GeoRestriction { get; set; }
}

/// <summary>The configuration for a string schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigTenantConfigParameterDefinitionsDefinitionStringSchema
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("required")]
    public bool? Required { get; set; }
}

/// <summary>An object that contains information about the parameter definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigTenantConfigParameterDefinitionsDefinition
{
    /// <summary>The configuration for a string schema.</summary>
    [JsonPropertyName("stringSchema")]
    public V1alpha1DistributionSpecDistributionConfigTenantConfigParameterDefinitionsDefinitionStringSchema? StringSchema { get; set; }
}

/// <summary>
/// A list of parameter values to add to the resource. A parameter is specified
/// as a key-value pair. A valid parameter value must exist for any parameter
/// that is marked as required in the multi-tenant distribution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigTenantConfigParameterDefinitions
{
    /// <summary>An object that contains information about the parameter definition.</summary>
    [JsonPropertyName("definition")]
    public V1alpha1DistributionSpecDistributionConfigTenantConfigParameterDefinitionsDefinition? Definition { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// This field only supports multi-tenant distributions. You can&apos;t specify this
/// field for standard distributions. For more information, see Unsupported features
/// for SaaS Manager for Amazon CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas)
/// in the Amazon CloudFront Developer Guide.
/// 
/// The configuration for a distribution tenant.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigTenantConfig
{
    [JsonPropertyName("parameterDefinitions")]
    public IList<V1alpha1DistributionSpecDistributionConfigTenantConfigParameterDefinitions>? ParameterDefinitions { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigViewerCertificateAcmCertificateRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for ACMCertificateARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigViewerCertificateAcmCertificateRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DistributionSpecDistributionConfigViewerCertificateAcmCertificateRefFrom? From { get; set; }
}

/// <summary>
/// A complex type that determines the distribution&apos;s SSL/TLS configuration for
/// communicating with viewers.
/// 
/// If the distribution doesn&apos;t use Aliases (also known as alternate domain names
/// or CNAMEs)—that is, if the distribution uses the CloudFront domain name
/// such as d111111abcdef8.cloudfront.net—set CloudFrontDefaultCertificate
/// to true and leave all other fields empty.
/// 
/// If the distribution uses Aliases (alternate domain names or CNAMEs), use
/// the fields in this type to specify the following settings:
/// 
///    * Which viewers the distribution accepts HTTPS connections from: only
///    viewers that support server name indication (SNI) (https://en.wikipedia.org/wiki/Server_Name_Indication)
///    (recommended), or all viewers including those that don&apos;t support SNI.
///    To accept HTTPS connections from only viewers that support SNI, set SSLSupportMethod
///    to sni-only. This is recommended. Most browsers and clients support SNI.
///    To accept HTTPS connections from all viewers, including those that don&apos;t
///    support SNI, set SSLSupportMethod to vip. This is not recommended, and
///    results in additional monthly charges from CloudFront.
/// 
///    * The minimum SSL/TLS protocol version that the distribution can use to
///    communicate with viewers. To specify a minimum version, choose a value
///    for MinimumProtocolVersion. For more information, see Security Policy
///    (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValues-security-policy)
///    in the Amazon CloudFront Developer Guide.
/// 
///    * The location of the SSL/TLS certificate, Certificate Manager (ACM) (https://docs.aws.amazon.com/acm/latest/userguide/acm-overview.html)
///    (recommended) or Identity and Access Management (IAM) (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html).
///    You specify the location by setting a value in one of the following fields
///    (not both): ACMCertificateArn IAMCertificateId
/// 
/// All distributions support HTTPS connections from viewers. To require viewers
/// to use HTTPS only, or to redirect them from HTTP to HTTPS, use ViewerProtocolPolicy
/// in the CacheBehavior or DefaultCacheBehavior. To specify how CloudFront should
/// use SSL/TLS to communicate with your custom origin, use CustomOriginConfig.
/// 
/// For more information, see Using HTTPS with CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-https.html)
/// and Using Alternate Domain Names and HTTPS (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-https-alternate-domain-names.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigViewerCertificate
{
    [JsonPropertyName("acmCertificateARN")]
    public string? AcmCertificateARN { get; set; }

    /// <summary>Reference field for ACMCertificateARN</summary>
    [JsonPropertyName("acmCertificateRef")]
    public V1alpha1DistributionSpecDistributionConfigViewerCertificateAcmCertificateRef? AcmCertificateRef { get; set; }

    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    [JsonPropertyName("cloudFrontDefaultCertificate")]
    public bool? CloudFrontDefaultCertificate { get; set; }

    [JsonPropertyName("iamCertificateID")]
    public string? IamCertificateID { get; set; }

    [JsonPropertyName("minimumProtocolVersion")]
    public string? MinimumProtocolVersion { get; set; }

    [JsonPropertyName("sslSupportMethod")]
    public string? SslSupportMethod { get; set; }
}

/// <summary>A trust store configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigViewerMtlsConfigTrustStoreConfig
{
    [JsonPropertyName("advertiseTrustStoreCaNames")]
    public bool? AdvertiseTrustStoreCaNames { get; set; }

    [JsonPropertyName("ignoreCertificateExpiry")]
    public bool? IgnoreCertificateExpiry { get; set; }

    [JsonPropertyName("trustStoreID")]
    public string? TrustStoreID { get; set; }
}

/// <summary>A viewer mTLS configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfigViewerMtlsConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>A trust store configuration.</summary>
    [JsonPropertyName("trustStoreConfig")]
    public V1alpha1DistributionSpecDistributionConfigViewerMtlsConfigTrustStoreConfig? TrustStoreConfig { get; set; }
}

/// <summary>The distribution&apos;s configuration information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecDistributionConfig
{
    /// <summary>
    /// A complex type that contains information about CNAMEs (alternate domain names),
    /// if any, for this distribution.
    /// </summary>
    [JsonPropertyName("aliases")]
    public V1alpha1DistributionSpecDistributionConfigAliases? Aliases { get; set; }

    /// <summary>A complex type that contains zero or more CacheBehavior elements.</summary>
    [JsonPropertyName("cacheBehaviors")]
    public V1alpha1DistributionSpecDistributionConfigCacheBehaviors? CacheBehaviors { get; set; }

    /// <summary>
    /// A complex type that specifies the HTTP header name from which CloudFront
    /// extracts cache tags from origin responses. When you add CacheTagConfig to
    /// a distribution, CloudFront reads the specified header from origin responses,
    /// parses the comma-separated tag values, and stores them with the cached object.
    /// You can then invalidate cached objects by tag using the CreateInvalidation
    /// API.
    /// </summary>
    [JsonPropertyName("cacheTagConfig")]
    public V1alpha1DistributionSpecDistributionConfigCacheTagConfig? CacheTagConfig { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A connection function association.</summary>
    [JsonPropertyName("connectionFunctionAssociation")]
    public V1alpha1DistributionSpecDistributionConfigConnectionFunctionAssociation? ConnectionFunctionAssociation { get; set; }

    [JsonPropertyName("connectionMode")]
    public string? ConnectionMode { get; set; }

    [JsonPropertyName("continuousDeploymentPolicyID")]
    public string? ContinuousDeploymentPolicyID { get; set; }

    /// <summary>
    /// A complex type that controls:
    /// 
    ///    * Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range
    ///    with custom error messages before returning the response to the viewer.
    /// 
    ///    * How long CloudFront caches HTTP status codes in the 4xx and 5xx range.
    /// 
    /// For more information about custom error pages, see Customizing Error Responses
    /// (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("customErrorResponses")]
    public V1alpha1DistributionSpecDistributionConfigCustomErrorResponses? CustomErrorResponses { get; set; }

    /// <summary>
    /// A complex type that describes the default cache behavior if you don&apos;t specify
    /// a CacheBehavior element or if request URLs don&apos;t match any of the values
    /// of PathPattern in CacheBehavior elements. You must create exactly one default
    /// cache behavior.
    /// 
    /// If your minimum TTL is greater than 0, CloudFront will cache content for
    /// at least the duration specified in the cache policy&apos;s minimum TTL, even if
    /// the Cache-Control: no-cache, no-store, or private directives are present
    /// in the origin headers.
    /// </summary>
    [JsonPropertyName("defaultCacheBehavior")]
    public V1alpha1DistributionSpecDistributionConfigDefaultCacheBehavior? DefaultCacheBehavior { get; set; }

    [JsonPropertyName("defaultRootObject")]
    public string? DefaultRootObject { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("httpVersion")]
    public string? HttpVersion { get; set; }

    [JsonPropertyName("isIPV6Enabled")]
    public bool? IsIPV6Enabled { get; set; }

    /// <summary>
    /// A complex type that specifies whether access logs are written for the distribution.
    /// 
    /// If you already enabled standard logging (legacy) and you want to enable standard
    /// logging (v2) to send your access logs to Amazon S3, we recommend that you
    /// specify a different Amazon S3 bucket or use a separate path in the same bucket
    /// (for example, use a log prefix or partitioning). This helps you keep track
    /// of which log files are associated with which logging subscription and prevents
    /// log files from overwriting each other. For more information, see Standard
    /// logging (access logs) (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/AccessLogs.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("logging")]
    public V1alpha1DistributionSpecDistributionConfigLogging? Logging { get; set; }

    /// <summary>A complex data type for the origin groups specified for a distribution.</summary>
    [JsonPropertyName("originGroups")]
    public V1alpha1DistributionSpecDistributionConfigOriginGroups? OriginGroups { get; set; }

    /// <summary>Contains information about the origins for this distribution.</summary>
    [JsonPropertyName("origins")]
    public V1alpha1DistributionSpecDistributionConfigOrigins? Origins { get; set; }

    [JsonPropertyName("priceClass")]
    public string? PriceClass { get; set; }

    /// <summary>
    /// A complex type that identifies ways in which you want to restrict distribution
    /// of your content.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public V1alpha1DistributionSpecDistributionConfigRestrictions? Restrictions { get; set; }

    [JsonPropertyName("staging")]
    public bool? Staging { get; set; }

    /// <summary>
    /// This field only supports multi-tenant distributions. You can&apos;t specify this
    /// field for standard distributions. For more information, see Unsupported features
    /// for SaaS Manager for Amazon CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas)
    /// in the Amazon CloudFront Developer Guide.
    /// 
    /// The configuration for a distribution tenant.
    /// </summary>
    [JsonPropertyName("tenantConfig")]
    public V1alpha1DistributionSpecDistributionConfigTenantConfig? TenantConfig { get; set; }

    /// <summary>
    /// A complex type that determines the distribution&apos;s SSL/TLS configuration for
    /// communicating with viewers.
    /// 
    /// If the distribution doesn&apos;t use Aliases (also known as alternate domain names
    /// or CNAMEs)—that is, if the distribution uses the CloudFront domain name
    /// such as d111111abcdef8.cloudfront.net—set CloudFrontDefaultCertificate
    /// to true and leave all other fields empty.
    /// 
    /// If the distribution uses Aliases (alternate domain names or CNAMEs), use
    /// the fields in this type to specify the following settings:
    /// 
    ///    * Which viewers the distribution accepts HTTPS connections from: only
    ///    viewers that support server name indication (SNI) (https://en.wikipedia.org/wiki/Server_Name_Indication)
    ///    (recommended), or all viewers including those that don&apos;t support SNI.
    ///    To accept HTTPS connections from only viewers that support SNI, set SSLSupportMethod
    ///    to sni-only. This is recommended. Most browsers and clients support SNI.
    ///    To accept HTTPS connections from all viewers, including those that don&apos;t
    ///    support SNI, set SSLSupportMethod to vip. This is not recommended, and
    ///    results in additional monthly charges from CloudFront.
    /// 
    ///    * The minimum SSL/TLS protocol version that the distribution can use to
    ///    communicate with viewers. To specify a minimum version, choose a value
    ///    for MinimumProtocolVersion. For more information, see Security Policy
    ///    (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValues-security-policy)
    ///    in the Amazon CloudFront Developer Guide.
    /// 
    ///    * The location of the SSL/TLS certificate, Certificate Manager (ACM) (https://docs.aws.amazon.com/acm/latest/userguide/acm-overview.html)
    ///    (recommended) or Identity and Access Management (IAM) (https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html).
    ///    You specify the location by setting a value in one of the following fields
    ///    (not both): ACMCertificateArn IAMCertificateId
    /// 
    /// All distributions support HTTPS connections from viewers. To require viewers
    /// to use HTTPS only, or to redirect them from HTTP to HTTPS, use ViewerProtocolPolicy
    /// in the CacheBehavior or DefaultCacheBehavior. To specify how CloudFront should
    /// use SSL/TLS to communicate with your custom origin, use CustomOriginConfig.
    /// 
    /// For more information, see Using HTTPS with CloudFront (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-https.html)
    /// and Using Alternate Domain Names and HTTPS (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-https-alternate-domain-names.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("viewerCertificate")]
    public V1alpha1DistributionSpecDistributionConfigViewerCertificate? ViewerCertificate { get; set; }

    /// <summary>A viewer mTLS configuration.</summary>
    [JsonPropertyName("viewerMtlsConfig")]
    public V1alpha1DistributionSpecDistributionConfigViewerMtlsConfig? ViewerMtlsConfig { get; set; }

    [JsonPropertyName("webACLID")]
    public string? WebACLID { get; set; }
}

/// <summary>A complex type that contains Tag key and Tag value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpecTags
{
    /// <summary>
    /// A string that contains Tag key.
    /// 
    /// The string length should be between 1 and 128 characters. Valid characters
    /// include a-z, A-Z, 0-9, space, and the special characters _ - . : / = + @.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DistributionSpec defines the desired state of Distribution.
/// 
/// A distribution tells CloudFront where you want content to be delivered from,
/// and the details about how to track and manage content delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionSpec
{
    /// <summary>The distribution&apos;s configuration information.</summary>
    [JsonPropertyName("distributionConfig")]
    public required V1alpha1DistributionSpecDistributionConfig DistributionConfig { get; set; }

    /// <summary>A complex type that contains Tag elements.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DistributionSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>A list of CloudFront key pair identifiers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusActiveTrustedKeyGroupsItemsKeyPairIDs
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }

    [JsonPropertyName("quantity")]
    public long? Quantity { get; set; }
}

/// <summary>
/// A list of identifiers for the public keys that CloudFront can use to verify
/// the signatures of signed URLs and signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusActiveTrustedKeyGroupsItems
{
    [JsonPropertyName("keyGroupID")]
    public string? KeyGroupID { get; set; }

    /// <summary>A list of CloudFront key pair identifiers.</summary>
    [JsonPropertyName("keyPairIDs")]
    public V1alpha1DistributionStatusActiveTrustedKeyGroupsItemsKeyPairIDs? KeyPairIDs { get; set; }
}

/// <summary>
/// This field contains a list of key groups and the public keys in each key
/// group that CloudFront can use to verify the signatures of signed URLs or
/// signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusActiveTrustedKeyGroups
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionStatusActiveTrustedKeyGroupsItems>? Items { get; set; }
}

/// <summary>A list of CloudFront key pair identifiers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusActiveTrustedSignersItemsKeyPairIDs
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }

    [JsonPropertyName("quantity")]
    public long? Quantity { get; set; }
}

/// <summary>
/// A list of Amazon Web Services accounts and the active CloudFront key pairs
/// in each account that CloudFront can use to verify the signatures of signed
/// URLs and signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusActiveTrustedSignersItems
{
    [JsonPropertyName("awsAccountNumber")]
    public string? AwsAccountNumber { get; set; }

    /// <summary>A list of CloudFront key pair identifiers.</summary>
    [JsonPropertyName("keyPairIDs")]
    public V1alpha1DistributionStatusActiveTrustedSignersItemsKeyPairIDs? KeyPairIDs { get; set; }
}

/// <summary>
/// We recommend using TrustedKeyGroups instead of TrustedSigners.
/// 
/// This field contains a list of Amazon Web Services account IDs and the active
/// CloudFront key pairs in each account that CloudFront can use to verify the
/// signatures of signed URLs or signed cookies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusActiveTrustedSigners
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("items")]
    public IList<V1alpha1DistributionStatusActiveTrustedSignersItems>? Items { get; set; }
}

/// <summary>
/// Amazon Web Services services in China customers must file for an Internet
/// Content Provider (ICP) recordal if they want to serve content publicly on
/// an alternate domain name, also known as a CNAME, that they&apos;ve added to CloudFront.
/// AliasICPRecordal provides the ICP recordal status for CNAMEs associated with
/// distributions. The status is returned in the CloudFront response; you can&apos;t
/// configure it yourself.
/// 
/// For more information about ICP recordals, see Signup, Accounts, and Credentials
/// (https://docs.amazonaws.cn/en_us/aws/latest/userguide/accounts-and-credentials.html)
/// in Getting Started with Amazon Web Services services in China.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusAliasICPRecordals
{
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    [JsonPropertyName("iCPRecordalStatus")]
    public string? ICPRecordalStatus { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>DistributionStatus defines the observed state of Distribution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DistributionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// This field contains a list of key groups and the public keys in each key
    /// group that CloudFront can use to verify the signatures of signed URLs or
    /// signed cookies.
    /// </summary>
    [JsonPropertyName("activeTrustedKeyGroups")]
    public V1alpha1DistributionStatusActiveTrustedKeyGroups? ActiveTrustedKeyGroups { get; set; }

    /// <summary>
    /// We recommend using TrustedKeyGroups instead of TrustedSigners.
    /// 
    /// This field contains a list of Amazon Web Services account IDs and the active
    /// CloudFront key pairs in each account that CloudFront can use to verify the
    /// signatures of signed URLs or signed cookies.
    /// </summary>
    [JsonPropertyName("activeTrustedSigners")]
    public V1alpha1DistributionStatusActiveTrustedSigners? ActiveTrustedSigners { get; set; }

    /// <summary>
    /// Amazon Web Services services in China customers must file for an Internet
    /// Content Provider (ICP) recordal if they want to serve content publicly on
    /// an alternate domain name, also known as a CNAME, that they&apos;ve added to CloudFront.
    /// AliasICPRecordal provides the ICP recordal status for CNAMEs associated with
    /// distributions.
    /// 
    /// For more information about ICP recordals, see Signup, Accounts, and Credentials
    /// (https://docs.amazonaws.cn/en_us/aws/latest/userguide/accounts-and-credentials.html)
    /// in Getting Started with Amazon Web Services services in China.
    /// </summary>
    [JsonPropertyName("aliasICPRecordals")]
    public IList<V1alpha1DistributionStatusAliasICPRecordals>? AliasICPRecordals { get; set; }

    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DistributionStatusConditions>? Conditions { get; set; }

    /// <summary>The distribution&apos;s CloudFront domain name. For example: d111111abcdef8.cloudfront.net.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The current version of the distribution created.</summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>The distribution&apos;s identifier. For example: E1U5RQF7T870K0.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The number of invalidation batches currently in progress.</summary>
    [JsonPropertyName("inProgressInvalidationBatches")]
    public long? InProgressInvalidationBatches { get; set; }

    /// <summary>The date and time when the distribution was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// The distribution&apos;s status. When the status is Deployed, the distribution&apos;s
    /// information is fully propagated to all CloudFront edge locations.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Distribution is the Schema for the Distributions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Distribution : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DistributionSpec?>, IStatus<V1alpha1DistributionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Distribution";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "distributions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Distribution";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DistributionSpec defines the desired state of Distribution.
    /// 
    /// A distribution tells CloudFront where you want content to be delivered from,
    /// and the details about how to track and manage content delivery.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DistributionSpec? Spec { get; set; }

    /// <summary>DistributionStatus defines the observed state of Distribution</summary>
    [JsonPropertyName("status")]
    public V1alpha1DistributionStatus? Status { get; set; }
}