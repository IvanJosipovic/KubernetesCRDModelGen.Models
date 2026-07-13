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
/// <summary>ResponseHeadersPolicy is the Schema for the ResponseHeadersPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResponseHeadersPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ResponseHeadersPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResponseHeadersPolicyList";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "responseheaderspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResponseHeadersPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ResponseHeadersPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ResponseHeadersPolicy> Items { get; set; }
}

/// <summary>
/// A list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers
/// HTTP response header.
/// 
/// For more information about the Access-Control-Allow-Headers HTTP response
/// header, see Access-Control-Allow-Headers (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Headers)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods
/// HTTP response header.
/// 
/// For more information about the Access-Control-Allow-Methods HTTP response
/// header, see Access-Control-Allow-Methods (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Methods)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethods
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A list of origins (domain names) that CloudFront can use as the value for
/// the Access-Control-Allow-Origin HTTP response header.
/// 
/// For more information about the Access-Control-Allow-Origin HTTP response
/// header, see Access-Control-Allow-Origin (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Origin)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlAllowOrigins
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers
/// HTTP response header.
/// 
/// For more information about the Access-Control-Expose-Headers HTTP response
/// header, see Access-Control-Expose-Headers (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Expose-Headers)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// A configuration for a set of HTTP response headers that are used for cross-origin
/// resource sharing (CORS). CloudFront adds these headers to HTTP responses
/// that it sends for CORS requests that match a cache behavior associated with
/// this response headers policy.
/// 
/// For more information about CORS, see Cross-Origin Resource Sharing (CORS)
/// (https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS) in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfig
{
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>
    /// A list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers
    /// HTTP response header.
    /// 
    /// For more information about the Access-Control-Allow-Headers HTTP response
    /// header, see Access-Control-Allow-Headers (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Headers)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlAllowHeaders? AccessControlAllowHeaders { get; set; }

    /// <summary>
    /// A list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods
    /// HTTP response header.
    /// 
    /// For more information about the Access-Control-Allow-Methods HTTP response
    /// header, see Access-Control-Allow-Methods (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Methods)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlAllowMethods? AccessControlAllowMethods { get; set; }

    /// <summary>
    /// A list of origins (domain names) that CloudFront can use as the value for
    /// the Access-Control-Allow-Origin HTTP response header.
    /// 
    /// For more information about the Access-Control-Allow-Origin HTTP response
    /// header, see Access-Control-Allow-Origin (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Allow-Origin)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("accessControlAllowOrigins")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlAllowOrigins? AccessControlAllowOrigins { get; set; }

    /// <summary>
    /// A list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers
    /// HTTP response header.
    /// 
    /// For more information about the Access-Control-Expose-Headers HTTP response
    /// header, see Access-Control-Expose-Headers (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Access-Control-Expose-Headers)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders { get; set; }

    [JsonPropertyName("accessControlMaxAgeSec")]
    public long? AccessControlMaxAgeSec { get; set; }

    [JsonPropertyName("originOverride")]
    public bool? OriginOverride { get; set; }
}

/// <summary>
/// An HTTP response header name and its value. CloudFront includes this header
/// in HTTP responses that it sends for requests that match a cache behavior
/// that&apos;s associated with this response headers policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCustomHeadersConfigItems
{
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A list of HTTP response header names and their values. CloudFront includes
/// these headers in HTTP responses that it sends for requests that match a cache
/// behavior that&apos;s associated with this response headers policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCustomHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCustomHeadersConfigItems>? Items { get; set; }
}

/// <summary>
/// The name of an HTTP header that CloudFront removes from HTTP responses to
/// requests that match the cache behavior that this response headers policy
/// is attached to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigRemoveHeadersConfigItems
{
    [JsonPropertyName("header")]
    public string? Header { get; set; }
}

/// <summary>
/// A list of HTTP header names that CloudFront removes from HTTP responses to
/// requests that match the cache behavior that this response headers policy
/// is attached to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigRemoveHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigRemoveHeadersConfigItems>? Items { get; set; }
}

/// <summary>
/// The policy directives and their values that CloudFront includes as values
/// for the Content-Security-Policy HTTP response header.
/// 
/// For more information about the Content-Security-Policy HTTP response header,
/// see Content-Security-Policy (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigContentSecurityPolicy
{
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>
/// Determines whether CloudFront includes the X-Content-Type-Options HTTP response
/// header with its value set to nosniff.
/// 
/// For more information about the X-Content-Type-Options HTTP response header,
/// see X-Content-Type-Options (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Content-Type-Options)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigContentTypeOptions
{
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>
/// Determines whether CloudFront includes the X-Frame-Options HTTP response
/// header and the header&apos;s value.
/// 
/// For more information about the X-Frame-Options HTTP response header, see
/// X-Frame-Options (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigFrameOptions
{
    [JsonPropertyName("frameOption")]
    public string? FrameOption { get; set; }

    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>
/// Determines whether CloudFront includes the Referrer-Policy HTTP response
/// header and the header&apos;s value.
/// 
/// For more information about the Referrer-Policy HTTP response header, see
/// Referrer-Policy (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Referrer-Policy)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigReferrerPolicy
{
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }
}

/// <summary>
/// Determines whether CloudFront includes the Strict-Transport-Security HTTP
/// response header and the header&apos;s value.
/// 
/// For more information about the Strict-Transport-Security HTTP response header,
/// see Strict-Transport-Security (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Strict-Transport-Security)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigStrictTransportSecurity
{
    [JsonPropertyName("accessControlMaxAgeSec")]
    public long? AccessControlMaxAgeSec { get; set; }

    [JsonPropertyName("includeSubdomains")]
    public bool? IncludeSubdomains { get; set; }

    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }
}

/// <summary>
/// Determines whether CloudFront includes the X-XSS-Protection HTTP response
/// header and the header&apos;s value.
/// 
/// For more information about the X-XSS-Protection HTTP response header, see
/// X-XSS-Protection (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection)
/// in the MDN Web Docs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigXssProtection
{
    [JsonPropertyName("modeBlock")]
    public bool? ModeBlock { get; set; }

    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    [JsonPropertyName("protection")]
    public bool? Protection { get; set; }

    [JsonPropertyName("reportURI")]
    public string? ReportURI { get; set; }
}

/// <summary>
/// A configuration for a set of security-related HTTP response headers. CloudFront
/// adds these headers to HTTP responses that it sends for requests that match
/// a cache behavior associated with this response headers policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfig
{
    /// <summary>
    /// The policy directives and their values that CloudFront includes as values
    /// for the Content-Security-Policy HTTP response header.
    /// 
    /// For more information about the Content-Security-Policy HTTP response header,
    /// see Content-Security-Policy (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Security-Policy)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy { get; set; }

    /// <summary>
    /// Determines whether CloudFront includes the X-Content-Type-Options HTTP response
    /// header with its value set to nosniff.
    /// 
    /// For more information about the X-Content-Type-Options HTTP response header,
    /// see X-Content-Type-Options (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Content-Type-Options)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("contentTypeOptions")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigContentTypeOptions? ContentTypeOptions { get; set; }

    /// <summary>
    /// Determines whether CloudFront includes the X-Frame-Options HTTP response
    /// header and the header&apos;s value.
    /// 
    /// For more information about the X-Frame-Options HTTP response header, see
    /// X-Frame-Options (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("frameOptions")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigFrameOptions? FrameOptions { get; set; }

    /// <summary>
    /// Determines whether CloudFront includes the Referrer-Policy HTTP response
    /// header and the header&apos;s value.
    /// 
    /// For more information about the Referrer-Policy HTTP response header, see
    /// Referrer-Policy (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Referrer-Policy)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("referrerPolicy")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigReferrerPolicy? ReferrerPolicy { get; set; }

    /// <summary>
    /// Determines whether CloudFront includes the Strict-Transport-Security HTTP
    /// response header and the header&apos;s value.
    /// 
    /// For more information about the Strict-Transport-Security HTTP response header,
    /// see Strict-Transport-Security (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Strict-Transport-Security)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("strictTransportSecurity")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity { get; set; }

    /// <summary>
    /// Determines whether CloudFront includes the X-XSS-Protection HTTP response
    /// header and the header&apos;s value.
    /// 
    /// For more information about the X-XSS-Protection HTTP response header, see
    /// X-XSS-Protection (https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-XSS-Protection)
    /// in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("xssProtection")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfigXssProtection? XssProtection { get; set; }
}

/// <summary>
/// A configuration for enabling the Server-Timing header in HTTP responses sent
/// from CloudFront. CloudFront adds this header to HTTP responses that it sends
/// in response to requests that match a cache behavior that&apos;s associated with
/// this response headers policy.
/// 
/// You can use the Server-Timing header to view metrics that can help you gain
/// insights about the behavior and performance of CloudFront. For example, you
/// can see which cache layer served a cache hit, or the first byte latency from
/// the origin when there was a cache miss. You can use the metrics in the Server-Timing
/// header to troubleshoot issues or test the efficiency of your CloudFront configuration.
/// For more information, see Server-Timing header (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/understanding-response-headers-policies.html#server-timing-header)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigServerTimingHeadersConfig
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

/// <summary>
/// Contains metadata about the response headers policy, and a set of configurations
/// that specify the HTTP headers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfig
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// A configuration for a set of HTTP response headers that are used for cross-origin
    /// resource sharing (CORS). CloudFront adds these headers to HTTP responses
    /// that it sends for CORS requests that match a cache behavior associated with
    /// this response headers policy.
    /// 
    /// For more information about CORS, see Cross-Origin Resource Sharing (CORS)
    /// (https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS) in the MDN Web Docs.
    /// </summary>
    [JsonPropertyName("corsConfig")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCorsConfig? CorsConfig { get; set; }

    /// <summary>
    /// A list of HTTP response header names and their values. CloudFront includes
    /// these headers in HTTP responses that it sends for requests that match a cache
    /// behavior that&apos;s associated with this response headers policy.
    /// </summary>
    [JsonPropertyName("customHeadersConfig")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigCustomHeadersConfig? CustomHeadersConfig { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// A list of HTTP header names that CloudFront removes from HTTP responses to
    /// requests that match the cache behavior that this response headers policy
    /// is attached to.
    /// </summary>
    [JsonPropertyName("removeHeadersConfig")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigRemoveHeadersConfig? RemoveHeadersConfig { get; set; }

    /// <summary>
    /// A configuration for a set of security-related HTTP response headers. CloudFront
    /// adds these headers to HTTP responses that it sends for requests that match
    /// a cache behavior associated with this response headers policy.
    /// </summary>
    [JsonPropertyName("securityHeadersConfig")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigSecurityHeadersConfig? SecurityHeadersConfig { get; set; }

    /// <summary>
    /// A configuration for enabling the Server-Timing header in HTTP responses sent
    /// from CloudFront. CloudFront adds this header to HTTP responses that it sends
    /// in response to requests that match a cache behavior that&apos;s associated with
    /// this response headers policy.
    /// 
    /// You can use the Server-Timing header to view metrics that can help you gain
    /// insights about the behavior and performance of CloudFront. For example, you
    /// can see which cache layer served a cache hit, or the first byte latency from
    /// the origin when there was a cache miss. You can use the metrics in the Server-Timing
    /// header to troubleshoot issues or test the efficiency of your CloudFront configuration.
    /// For more information, see Server-Timing header (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/understanding-response-headers-policies.html#server-timing-header)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("serverTimingHeadersConfig")]
    public V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfigServerTimingHeadersConfig? ServerTimingHeadersConfig { get; set; }
}

/// <summary>
/// ResponseHeadersPolicySpec defines the desired state of ResponseHeadersPolicy.
/// 
/// A response headers policy.
/// 
/// A response headers policy contains information about a set of HTTP response
/// headers.
/// 
/// After you create a response headers policy, you can use its ID to attach
/// it to one or more cache behaviors in a CloudFront distribution. When it&apos;s
/// attached to a cache behavior, the response headers policy affects the HTTP
/// headers that CloudFront includes in HTTP responses to requests that match
/// the cache behavior. CloudFront adds or removes response headers according
/// to the configuration of the response headers policy.
/// 
/// For more information, see Adding or removing HTTP headers in CloudFront responses
/// (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/modifying-response-headers.html)
/// in the Amazon CloudFront Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicySpec
{
    /// <summary>
    /// Contains metadata about the response headers policy, and a set of configurations
    /// that specify the HTTP headers.
    /// </summary>
    [JsonPropertyName("responseHeadersPolicyConfig")]
    public required V1alpha1ResponseHeadersPolicySpecResponseHeadersPolicyConfig ResponseHeadersPolicyConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicyStatusAckResourceMetadata
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

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicyStatusConditions
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

/// <summary>ResponseHeadersPolicyStatus defines the observed state of ResponseHeadersPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResponseHeadersPolicyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ResponseHeadersPolicyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ResponseHeadersPolicyStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>The identifier for the response headers policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date and time when the response headers policy was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }
}

/// <summary>ResponseHeadersPolicy is the Schema for the ResponseHeadersPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResponseHeadersPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ResponseHeadersPolicySpec?>, IStatus<V1alpha1ResponseHeadersPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResponseHeadersPolicy";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "responseheaderspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResponseHeadersPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ResponseHeadersPolicySpec defines the desired state of ResponseHeadersPolicy.
    /// 
    /// A response headers policy.
    /// 
    /// A response headers policy contains information about a set of HTTP response
    /// headers.
    /// 
    /// After you create a response headers policy, you can use its ID to attach
    /// it to one or more cache behaviors in a CloudFront distribution. When it&apos;s
    /// attached to a cache behavior, the response headers policy affects the HTTP
    /// headers that CloudFront includes in HTTP responses to requests that match
    /// the cache behavior. CloudFront adds or removes response headers according
    /// to the configuration of the response headers policy.
    /// 
    /// For more information, see Adding or removing HTTP headers in CloudFront responses
    /// (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/modifying-response-headers.html)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ResponseHeadersPolicySpec? Spec { get; set; }

    /// <summary>ResponseHeadersPolicyStatus defines the observed state of ResponseHeadersPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1ResponseHeadersPolicyStatus? Status { get; set; }
}