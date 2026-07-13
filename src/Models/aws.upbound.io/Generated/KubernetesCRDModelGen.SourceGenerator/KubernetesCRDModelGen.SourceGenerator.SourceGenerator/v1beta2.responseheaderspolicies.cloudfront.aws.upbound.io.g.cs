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
/// <summary>ResponseHeadersPolicy is the Schema for the ResponseHeadersPolicys API. Provides a CloudFront response headers policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResponseHeadersPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ResponseHeadersPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResponseHeadersPolicyList";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "responseheaderspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResponseHeadersPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ResponseHeadersPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ResponseHeadersPolicy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResponseHeadersPolicySpecDeletionPolicyEnum>))]
public enum V1beta2ResponseHeadersPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowMethods
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowOrigins
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlExposeHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderCorsConfig
{
    /// <summary>A Boolean value that CloudFront uses as the value for the Access-Control-Allow-Credentials HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowHeaders? AccessControlAllowHeaders { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowMethods? AccessControlAllowMethods { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowOrigins")]
    public V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlAllowOrigins? AccessControlAllowOrigins { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public V1beta2ResponseHeadersPolicySpecForProviderCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders { get; set; }

    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>A Boolean value that determines how CloudFront behaves for the HTTP response header.</summary>
    [JsonPropertyName("originOverride")]
    public bool? OriginOverride { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderCustomHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>The value for the HTTP response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderCustomHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1beta2ResponseHeadersPolicySpecForProviderCustomHeadersConfigItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderRemoveHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }
}

/// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderRemoveHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1beta2ResponseHeadersPolicySpecForProviderRemoveHeadersConfigItems>? Items { get; set; }
}

/// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentSecurityPolicy
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentTypeOptions
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigFrameOptions
{
    /// <summary>The value of the X-Frame-Options HTTP response header. Valid values: DENY | SAMEORIGIN</summary>
    [JsonPropertyName("frameOption")]
    public string? FrameOption { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigReferrerPolicy
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }
}

/// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigStrictTransportSecurity
{
    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>Whether CloudFront includes the includeSubDomains directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("includeSubdomains")]
    public bool? IncludeSubdomains { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Whether CloudFront includes the preload directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }
}

/// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigXssProtection
{
    /// <summary>Whether CloudFront includes the mode=block directive in the X-XSS-Protection header.</summary>
    [JsonPropertyName("modeBlock")]
    public bool? ModeBlock { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>A Boolean value that determines the value of the X-XSS-Protection HTTP response header. When this setting is true, the value of the X-XSS-Protection header is 1. When this setting is false, the value of the X-XSS-Protection header is 0.</summary>
    [JsonPropertyName("protection")]
    public bool? Protection { get; set; }

    /// <summary>A reporting URI, which CloudFront uses as the value of the report directive in the X-XSS-Protection header. You cannot specify a report_uri when mode_block is true.</summary>
    [JsonPropertyName("reportUri")]
    public string? ReportUri { get; set; }
}

/// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfig
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
    [JsonPropertyName("contentTypeOptions")]
    public V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigContentTypeOptions? ContentTypeOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
    [JsonPropertyName("frameOptions")]
    public V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigFrameOptions? FrameOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigReferrerPolicy? ReferrerPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
    [JsonPropertyName("strictTransportSecurity")]
    public V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity { get; set; }

    /// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
    [JsonPropertyName("xssProtection")]
    public V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfigXssProtection? XssProtection { get; set; }
}

/// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProviderServerTimingHeadersConfig
{
    /// <summary>A Whether CloudFront adds the Server-Timing header to HTTP responses that it sends in response to requests that match a cache behavior that&apos;s associated with this response headers policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A number 0–100 (inclusive) that specifies the percentage of responses that you want CloudFront to add the Server-Timing header to. Valid range: Minimum value of 0.0. Maximum value of 100.0.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecForProvider
{
    /// <summary>A comment to describe the response headers policy. The comment cannot be longer than 128 characters.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
    [JsonPropertyName("corsConfig")]
    public V1beta2ResponseHeadersPolicySpecForProviderCorsConfig? CorsConfig { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
    [JsonPropertyName("customHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecForProviderCustomHeadersConfig? CustomHeadersConfig { get; set; }

    /// <summary>A unique name to identify the response headers policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
    [JsonPropertyName("removeHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecForProviderRemoveHeadersConfig? RemoveHeadersConfig { get; set; }

    /// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
    [JsonPropertyName("securityHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecForProviderSecurityHeadersConfig? SecurityHeadersConfig { get; set; }

    /// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
    [JsonPropertyName("serverTimingHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecForProviderServerTimingHeadersConfig? ServerTimingHeadersConfig { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowMethods
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowOrigins
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlExposeHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderCorsConfig
{
    /// <summary>A Boolean value that CloudFront uses as the value for the Access-Control-Allow-Credentials HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowHeaders? AccessControlAllowHeaders { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowMethods? AccessControlAllowMethods { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowOrigins")]
    public V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlAllowOrigins? AccessControlAllowOrigins { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public V1beta2ResponseHeadersPolicySpecInitProviderCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders { get; set; }

    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>A Boolean value that determines how CloudFront behaves for the HTTP response header.</summary>
    [JsonPropertyName("originOverride")]
    public bool? OriginOverride { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderCustomHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>The value for the HTTP response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderCustomHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1beta2ResponseHeadersPolicySpecInitProviderCustomHeadersConfigItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderRemoveHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }
}

/// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderRemoveHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1beta2ResponseHeadersPolicySpecInitProviderRemoveHeadersConfigItems>? Items { get; set; }
}

/// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentSecurityPolicy
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentTypeOptions
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigFrameOptions
{
    /// <summary>The value of the X-Frame-Options HTTP response header. Valid values: DENY | SAMEORIGIN</summary>
    [JsonPropertyName("frameOption")]
    public string? FrameOption { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigReferrerPolicy
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }
}

/// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigStrictTransportSecurity
{
    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>Whether CloudFront includes the includeSubDomains directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("includeSubdomains")]
    public bool? IncludeSubdomains { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Whether CloudFront includes the preload directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }
}

/// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigXssProtection
{
    /// <summary>Whether CloudFront includes the mode=block directive in the X-XSS-Protection header.</summary>
    [JsonPropertyName("modeBlock")]
    public bool? ModeBlock { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>A Boolean value that determines the value of the X-XSS-Protection HTTP response header. When this setting is true, the value of the X-XSS-Protection header is 1. When this setting is false, the value of the X-XSS-Protection header is 0.</summary>
    [JsonPropertyName("protection")]
    public bool? Protection { get; set; }

    /// <summary>A reporting URI, which CloudFront uses as the value of the report directive in the X-XSS-Protection header. You cannot specify a report_uri when mode_block is true.</summary>
    [JsonPropertyName("reportUri")]
    public string? ReportUri { get; set; }
}

/// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfig
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
    [JsonPropertyName("contentTypeOptions")]
    public V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigContentTypeOptions? ContentTypeOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
    [JsonPropertyName("frameOptions")]
    public V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigFrameOptions? FrameOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigReferrerPolicy? ReferrerPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
    [JsonPropertyName("strictTransportSecurity")]
    public V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity { get; set; }

    /// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
    [JsonPropertyName("xssProtection")]
    public V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfigXssProtection? XssProtection { get; set; }
}

/// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecInitProviderServerTimingHeadersConfig
{
    /// <summary>A Whether CloudFront adds the Server-Timing header to HTTP responses that it sends in response to requests that match a cache behavior that&apos;s associated with this response headers policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A number 0–100 (inclusive) that specifies the percentage of responses that you want CloudFront to add the Server-Timing header to. Valid range: Minimum value of 0.0. Maximum value of 100.0.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
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
public partial class V1beta2ResponseHeadersPolicySpecInitProvider
{
    /// <summary>A comment to describe the response headers policy. The comment cannot be longer than 128 characters.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
    [JsonPropertyName("corsConfig")]
    public V1beta2ResponseHeadersPolicySpecInitProviderCorsConfig? CorsConfig { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
    [JsonPropertyName("customHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecInitProviderCustomHeadersConfig? CustomHeadersConfig { get; set; }

    /// <summary>A unique name to identify the response headers policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
    [JsonPropertyName("removeHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecInitProviderRemoveHeadersConfig? RemoveHeadersConfig { get; set; }

    /// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
    [JsonPropertyName("securityHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecInitProviderSecurityHeadersConfig? SecurityHeadersConfig { get; set; }

    /// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
    [JsonPropertyName("serverTimingHeadersConfig")]
    public V1beta2ResponseHeadersPolicySpecInitProviderServerTimingHeadersConfig? ServerTimingHeadersConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResponseHeadersPolicySpecManagementPoliciesEnum>))]
public enum V1beta2ResponseHeadersPolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ResponseHeadersPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ResponseHeadersPolicySpec defines the desired state of ResponseHeadersPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicySpec
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
    public V1beta2ResponseHeadersPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ResponseHeadersPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2ResponseHeadersPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ResponseHeadersPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ResponseHeadersPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ResponseHeadersPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowMethods
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowOrigins
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlExposeHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfig
{
    /// <summary>A Boolean value that CloudFront uses as the value for the Access-Control-Allow-Credentials HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowCredentials")]
    public bool? AccessControlAllowCredentials { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP header names that CloudFront includes as values for the Access-Control-Allow-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowHeaders")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowHeaders? AccessControlAllowHeaders { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP methods that CloudFront includes as values for the Access-Control-Allow-Methods HTTP response header. Valid values: GET | POST | OPTIONS | PUT | DELETE | HEAD | ALL</summary>
    [JsonPropertyName("accessControlAllowMethods")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowMethods? AccessControlAllowMethods { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of origins that CloudFront can use as the value for the Access-Control-Allow-Origin HTTP response header.</summary>
    [JsonPropertyName("accessControlAllowOrigins")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlAllowOrigins? AccessControlAllowOrigins { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of HTTP headers that CloudFront includes as values for the Access-Control-Expose-Headers HTTP response header.</summary>
    [JsonPropertyName("accessControlExposeHeaders")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders { get; set; }

    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>A Boolean value that determines how CloudFront behaves for the HTTP response header.</summary>
    [JsonPropertyName("originOverride")]
    public bool? OriginOverride { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderCustomHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>The value for the HTTP response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderCustomHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1beta2ResponseHeadersPolicyStatusAtProviderCustomHeadersConfigItems>? Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfigItems
{
    /// <summary>The HTTP response header name.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }
}

/// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfig
{
    [JsonPropertyName("items")]
    public IList<V1beta2ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfigItems>? Items { get; set; }
}

/// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentSecurityPolicy
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public string? ContentSecurityPolicy { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentTypeOptions
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigFrameOptions
{
    /// <summary>The value of the X-Frame-Options HTTP response header. Valid values: DENY | SAMEORIGIN</summary>
    [JsonPropertyName("frameOption")]
    public string? FrameOption { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }
}

/// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigReferrerPolicy
{
    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public string? ReferrerPolicy { get; set; }
}

/// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigStrictTransportSecurity
{
    /// <summary>A number that CloudFront uses as the value for the Access-Control-Max-Age HTTP response header.</summary>
    [JsonPropertyName("accessControlMaxAgeSec")]
    public double? AccessControlMaxAgeSec { get; set; }

    /// <summary>Whether CloudFront includes the includeSubDomains directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("includeSubdomains")]
    public bool? IncludeSubdomains { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>Whether CloudFront includes the preload directive in the Strict-Transport-Security HTTP response header.</summary>
    [JsonPropertyName("preload")]
    public bool? Preload { get; set; }
}

/// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigXssProtection
{
    /// <summary>Whether CloudFront includes the mode=block directive in the X-XSS-Protection header.</summary>
    [JsonPropertyName("modeBlock")]
    public bool? ModeBlock { get; set; }

    /// <summary>Whether CloudFront overrides a response header with the same name received from the origin with the header specifies here.</summary>
    [JsonPropertyName("override")]
    public bool? Override { get; set; }

    /// <summary>A Boolean value that determines the value of the X-XSS-Protection HTTP response header. When this setting is true, the value of the X-XSS-Protection header is 1. When this setting is false, the value of the X-XSS-Protection header is 0.</summary>
    [JsonPropertyName("protection")]
    public bool? Protection { get; set; }

    /// <summary>A reporting URI, which CloudFront uses as the value of the report directive in the X-XSS-Protection header. You cannot specify a report_uri when mode_block is true.</summary>
    [JsonPropertyName("reportUri")]
    public string? ReportUri { get; set; }
}

/// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfig
{
    /// <summary>The policy directives and their values that CloudFront includes as values for the Content-Security-Policy HTTP response header. See Content Security Policy for more information.</summary>
    [JsonPropertyName("contentSecurityPolicy")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Content-Type-Options HTTP response header with its value set to nosniff. See Content Type Options for more information.</summary>
    [JsonPropertyName("contentTypeOptions")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigContentTypeOptions? ContentTypeOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the X-Frame-Options HTTP response header and the header’s value. See Frame Options for more information.</summary>
    [JsonPropertyName("frameOptions")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigFrameOptions? FrameOptions { get; set; }

    /// <summary>Determines whether CloudFront includes the Referrer-Policy HTTP response header and the header’s value. See Referrer Policy for more information.</summary>
    [JsonPropertyName("referrerPolicy")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigReferrerPolicy? ReferrerPolicy { get; set; }

    /// <summary>Determines whether CloudFront includes the Strict-Transport-Security HTTP response header and the header’s value. See Strict Transport Security for more information.</summary>
    [JsonPropertyName("strictTransportSecurity")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity { get; set; }

    /// <summary>Determine whether CloudFront includes the X-XSS-Protection HTTP response header and the header’s value. See XSS Protection for more information.</summary>
    [JsonPropertyName("xssProtection")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfigXssProtection? XssProtection { get; set; }
}

/// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProviderServerTimingHeadersConfig
{
    /// <summary>A Whether CloudFront adds the Server-Timing header to HTTP responses that it sends in response to requests that match a cache behavior that&apos;s associated with this response headers policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A number 0–100 (inclusive) that specifies the percentage of responses that you want CloudFront to add the Server-Timing header to. Valid range: Minimum value of 0.0. Maximum value of 100.0.</summary>
    [JsonPropertyName("samplingRate")]
    public double? SamplingRate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusAtProvider
{
    /// <summary>The response headers policy ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A comment to describe the response headers policy. The comment cannot be longer than 128 characters.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>A configuration for a set of HTTP response headers that are used for Cross-Origin Resource Sharing (CORS). See Cors Config for more information.</summary>
    [JsonPropertyName("corsConfig")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderCorsConfig? CorsConfig { get; set; }

    /// <summary>Object that contains an attribute items that contains a list of custom headers. See Custom Header for more information.</summary>
    [JsonPropertyName("customHeadersConfig")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderCustomHeadersConfig? CustomHeadersConfig { get; set; }

    /// <summary>The current version of the response headers policy.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The identifier for the response headers policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A unique name to identify the response headers policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration for a set of HTTP headers to remove from the HTTP response. Object that contains an attribute items that contains a list of headers. See Remove Header for more information.</summary>
    [JsonPropertyName("removeHeadersConfig")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderRemoveHeadersConfig? RemoveHeadersConfig { get; set; }

    /// <summary>A configuration for a set of security-related HTTP response headers. See Security Headers Config for more information.</summary>
    [JsonPropertyName("securityHeadersConfig")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderSecurityHeadersConfig? SecurityHeadersConfig { get; set; }

    /// <summary>A configuration for enabling the Server-Timing header in HTTP responses sent from CloudFront. See Server Timing Headers Config for more information.</summary>
    [JsonPropertyName("serverTimingHeadersConfig")]
    public V1beta2ResponseHeadersPolicyStatusAtProviderServerTimingHeadersConfig? ServerTimingHeadersConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatusConditions
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

/// <summary>ResponseHeadersPolicyStatus defines the observed state of ResponseHeadersPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ResponseHeadersPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ResponseHeadersPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ResponseHeadersPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResponseHeadersPolicy is the Schema for the ResponseHeadersPolicys API. Provides a CloudFront response headers policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ResponseHeadersPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ResponseHeadersPolicySpec>, IStatus<V1beta2ResponseHeadersPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ResponseHeadersPolicy";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "responseheaderspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResponseHeadersPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResponseHeadersPolicySpec defines the desired state of ResponseHeadersPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ResponseHeadersPolicySpec Spec { get; set; }

    /// <summary>ResponseHeadersPolicyStatus defines the observed state of ResponseHeadersPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2ResponseHeadersPolicyStatus? Status { get; set; }
}