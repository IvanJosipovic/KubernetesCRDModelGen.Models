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
/// <summary>OriginRequestPolicy is the Schema for the OriginRequestPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OriginRequestPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1OriginRequestPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OriginRequestPolicyList";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "originrequestpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OriginRequestPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1OriginRequestPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1OriginRequestPolicy> Items { get; set; }
}

/// <summary>Contains a list of cookie names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigCookiesConfigCookies
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// An object that determines whether any cookies in viewer requests (and if
/// so, which cookies) are included in requests that CloudFront sends to the
/// origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigCookiesConfig
{
    [JsonPropertyName("cookieBehavior")]
    public string? CookieBehavior { get; set; }

    /// <summary>Contains a list of cookie names.</summary>
    [JsonPropertyName("cookies")]
    public V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigCookiesConfigCookies? Cookies { get; set; }
}

/// <summary>Contains a list of HTTP header names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigHeadersConfigHeaders
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// An object that determines whether any HTTP headers (and if so, which headers)
/// are included in requests that CloudFront sends to the origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigHeadersConfig
{
    [JsonPropertyName("headerBehavior")]
    public string? HeaderBehavior { get; set; }

    /// <summary>Contains a list of HTTP header names.</summary>
    [JsonPropertyName("headers")]
    public V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigHeadersConfigHeaders? Headers { get; set; }
}

/// <summary>Contains a list of query string names.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigQueryStringsConfigQueryStrings
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>
/// An object that determines whether any URL query strings in viewer requests
/// (and if so, which query strings) are included in requests that CloudFront
/// sends to the origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigQueryStringsConfig
{
    [JsonPropertyName("queryStringBehavior")]
    public string? QueryStringBehavior { get; set; }

    /// <summary>Contains a list of query string names.</summary>
    [JsonPropertyName("queryStrings")]
    public V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigQueryStringsConfigQueryStrings? QueryStrings { get; set; }
}

/// <summary>An origin request policy configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfig
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// An object that determines whether any cookies in viewer requests (and if
    /// so, which cookies) are included in requests that CloudFront sends to the
    /// origin.
    /// </summary>
    [JsonPropertyName("cookiesConfig")]
    public V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigCookiesConfig? CookiesConfig { get; set; }

    /// <summary>
    /// An object that determines whether any HTTP headers (and if so, which headers)
    /// are included in requests that CloudFront sends to the origin.
    /// </summary>
    [JsonPropertyName("headersConfig")]
    public V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigHeadersConfig? HeadersConfig { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// An object that determines whether any URL query strings in viewer requests
    /// (and if so, which query strings) are included in requests that CloudFront
    /// sends to the origin.
    /// </summary>
    [JsonPropertyName("queryStringsConfig")]
    public V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfigQueryStringsConfig? QueryStringsConfig { get; set; }
}

/// <summary>
/// OriginRequestPolicySpec defines the desired state of OriginRequestPolicy.
/// 
/// An origin request policy.
/// 
/// When it&apos;s attached to a cache behavior, the origin request policy determines
/// the values that CloudFront includes in requests that it sends to the origin.
/// Each request that CloudFront sends to the origin includes the following:
/// 
///   - The request body and the URL path (without the domain name) from the
///     viewer request.
/// 
///   - The headers that CloudFront automatically includes in every origin request,
///     including Host, User-Agent, and X-Amz-Cf-Id.
/// 
///   - All HTTP headers, cookies, and URL query strings that are specified
///     in the cache policy or the origin request policy. These can include items
///     from the viewer request and, in the case of headers, additional ones that
///     are added by CloudFront.
/// 
/// CloudFront sends a request when it can&apos;t find an object in its cache that
/// matches the request. If you want to send values to the origin and also include
/// them in the cache key, use CachePolicy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicySpec
{
    /// <summary>An origin request policy configuration.</summary>
    [JsonPropertyName("originRequestPolicyConfig")]
    public required V1alpha1OriginRequestPolicySpecOriginRequestPolicyConfig OriginRequestPolicyConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicyStatusAckResourceMetadata
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
public partial class V1alpha1OriginRequestPolicyStatusConditions
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

/// <summary>OriginRequestPolicyStatus defines the observed state of OriginRequestPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OriginRequestPolicyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1OriginRequestPolicyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OriginRequestPolicyStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>The unique identifier for the origin request policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date and time when the origin request policy was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>OriginRequestPolicy is the Schema for the OriginRequestPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OriginRequestPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OriginRequestPolicySpec?>, IStatus<V1alpha1OriginRequestPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OriginRequestPolicy";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "originrequestpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OriginRequestPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// OriginRequestPolicySpec defines the desired state of OriginRequestPolicy.
    /// 
    /// An origin request policy.
    /// 
    /// When it&apos;s attached to a cache behavior, the origin request policy determines
    /// the values that CloudFront includes in requests that it sends to the origin.
    /// Each request that CloudFront sends to the origin includes the following:
    /// 
    ///   - The request body and the URL path (without the domain name) from the
    ///     viewer request.
    /// 
    ///   - The headers that CloudFront automatically includes in every origin request,
    ///     including Host, User-Agent, and X-Amz-Cf-Id.
    /// 
    ///   - All HTTP headers, cookies, and URL query strings that are specified
    ///     in the cache policy or the origin request policy. These can include items
    ///     from the viewer request and, in the case of headers, additional ones that
    ///     are added by CloudFront.
    /// 
    /// CloudFront sends a request when it can&apos;t find an object in its cache that
    /// matches the request. If you want to send values to the origin and also include
    /// them in the cache key, use CachePolicy.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1OriginRequestPolicySpec? Spec { get; set; }

    /// <summary>OriginRequestPolicyStatus defines the observed state of OriginRequestPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1OriginRequestPolicyStatus? Status { get; set; }
}