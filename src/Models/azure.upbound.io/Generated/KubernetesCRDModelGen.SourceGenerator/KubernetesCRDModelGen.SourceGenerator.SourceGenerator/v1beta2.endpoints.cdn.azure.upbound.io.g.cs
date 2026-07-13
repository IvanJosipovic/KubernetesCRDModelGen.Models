#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
/// <summary>Endpoint is the Schema for the Endpoints API. Manages a CDN (classic) Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Endpoint>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EndpointList";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Endpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Endpoint> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecDeletionPolicyEnum>))]
public enum V1beta2EndpointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A cache_expiration_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A cache_key_query_string_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleCookiesCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A device_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleDeviceCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleHttpVersionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRulePostArgCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleQueryStringCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleRemoteAddressCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleRequestBodyCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleRequestHeaderCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A request_method_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleRequestMethodCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>A request_scheme_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleRequestSchemeCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleRequestUriCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleUrlFileExtensionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleUrlFileNameCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleUrlPathCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A url_redirect_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public V1beta2EndpointSpecForProviderDeliveryRuleCacheExpirationAction? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public V1beta2EndpointSpecForProviderDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction { get; set; }

    /// <summary>A cookies_condition block as defined above.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A device_condition block as defined below.</summary>
    [JsonPropertyName("deviceCondition")]
    public V1beta2EndpointSpecForProviderDeliveryRuleDeviceCondition? DeviceCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>The Name which should be used for this Delivery Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order used for this rule. The order values should be sequential and begin at 1.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>A post_arg_condition block as defined below.</summary>
    [JsonPropertyName("postArgCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRulePostArgCondition>? PostArgCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public V1beta2EndpointSpecForProviderDeliveryRuleRequestMethodCondition? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public V1beta2EndpointSpecForProviderDeliveryRuleRequestSchemeCondition? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_file_name_condition block as defined below.</summary>
    [JsonPropertyName("urlFileNameCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleUrlFileNameCondition>? UrlFileNameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRuleUrlPathCondition>? UrlPathCondition { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2EndpointSpecForProviderDeliveryRuleUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2EndpointSpecForProviderDeliveryRuleUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGeoFilter
{
    /// <summary>The Action of the Geo Filter. Possible values include Allow and Block.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A List of two letter country codes (e.g. US, GB) to be associated with this Geo Filter.</summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>The relative path applicable to geo filter.</summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

/// <summary>A cache_expiration_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGlobalDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A cache_key_query_string_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGlobalDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGlobalDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGlobalDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A url_redirect_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGlobalDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGlobalDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderGlobalDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public V1beta2EndpointSpecForProviderGlobalDeliveryRuleCacheExpirationAction? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public V1beta2EndpointSpecForProviderGlobalDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta2EndpointSpecForProviderGlobalDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta2EndpointSpecForProviderGlobalDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2EndpointSpecForProviderGlobalDeliveryRuleUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2EndpointSpecForProviderGlobalDeliveryRuleUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderOrigin
{
    /// <summary>A string that determines the hostname/IP address of the origin server. This string can be a domain name, Storage Account endpoint, Web App endpoint, IPv4 address or IPv6 address. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The HTTP port of the origin. Defaults to 80. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS port of the origin. Defaults to 443. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderProfileNameRefPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecForProviderProfileNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderProfileNameRefPolicyResolveEnum>))]
public enum V1beta2EndpointSpecForProviderProfileNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderProfileNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecForProviderProfileNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecForProviderProfileNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Profile in cdn to populate profileName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderProfileNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointSpecForProviderProfileNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderProfileNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecForProviderProfileNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderProfileNameSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointSpecForProviderProfileNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderProfileNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecForProviderProfileNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecForProviderProfileNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Profile in cdn to populate profileName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderProfileNameSelector
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
    public V1beta2EndpointSpecForProviderProfileNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2EndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProviderResourceGroupNameSelector
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
    public V1beta2EndpointSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecForProvider
{
    /// <summary>An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Rules for the rules engine. An endpoint can contain up until 4 of those rules that consist of conditions and actions. A delivery_rule blocks as defined below.</summary>
    [JsonPropertyName("deliveryRule")]
    public IList<V1beta2EndpointSpecForProviderDeliveryRule>? DeliveryRule { get; set; }

    /// <summary>A set of Geo Filters for this CDN Endpoint. Each geo_filter block supports fields documented below.</summary>
    [JsonPropertyName("geoFilter")]
    public IList<V1beta2EndpointSpecForProviderGeoFilter>? GeoFilter { get; set; }

    /// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
    [JsonPropertyName("globalDeliveryRule")]
    public V1beta2EndpointSpecForProviderGlobalDeliveryRule? GlobalDeliveryRule { get; set; }

    /// <summary>Indicates whether compression is to be enabled.</summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>Specifies if http allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>Specifies if https allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>What types of optimization should this CDN Endpoint optimize for? Possible values include DynamicSiteAcceleration, GeneralMediaStreaming, GeneralWebDelivery, LargeFileDownload and VideoOnDemandMediaStreaming.</summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each origin block supports fields documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta2EndpointSpecForProviderOrigin>? Origin { get; set; }

    /// <summary>The host header CDN provider will send along with content requests to origins.</summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>The path used at for origin requests.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin_path.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>The CDN Profile to which to attach the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary>Reference to a Profile in cdn to populate profileName.</summary>
    [JsonPropertyName("profileNameRef")]
    public V1beta2EndpointSpecForProviderProfileNameRef? ProfileNameRef { get; set; }

    /// <summary>Selector for a Profile in cdn to populate profileName.</summary>
    [JsonPropertyName("profileNameSelector")]
    public V1beta2EndpointSpecForProviderProfileNameSelector? ProfileNameSelector { get; set; }

    /// <summary>Sets query string caching behavior. Allowed values are IgnoreQueryString, BypassCaching and UseQueryString. NotSet value can be used for Premium Verizon CDN profile. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("querystringCachingBehaviour")]
    public string? QuerystringCachingBehaviour { get; set; }

    /// <summary>The name of the resource group in which to create the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2EndpointSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2EndpointSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A cache_expiration_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A cache_key_query_string_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleCookiesCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A device_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleDeviceCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleHttpVersionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRulePostArgCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleQueryStringCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleRemoteAddressCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleRequestBodyCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleRequestHeaderCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A request_method_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleRequestMethodCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>A request_scheme_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleRequestSchemeCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleRequestUriCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleUrlFileExtensionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleUrlFileNameCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleUrlPathCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A url_redirect_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public V1beta2EndpointSpecInitProviderDeliveryRuleCacheExpirationAction? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public V1beta2EndpointSpecInitProviderDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction { get; set; }

    /// <summary>A cookies_condition block as defined above.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A device_condition block as defined below.</summary>
    [JsonPropertyName("deviceCondition")]
    public V1beta2EndpointSpecInitProviderDeliveryRuleDeviceCondition? DeviceCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>The Name which should be used for this Delivery Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order used for this rule. The order values should be sequential and begin at 1.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>A post_arg_condition block as defined below.</summary>
    [JsonPropertyName("postArgCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRulePostArgCondition>? PostArgCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public V1beta2EndpointSpecInitProviderDeliveryRuleRequestMethodCondition? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public V1beta2EndpointSpecInitProviderDeliveryRuleRequestSchemeCondition? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_file_name_condition block as defined below.</summary>
    [JsonPropertyName("urlFileNameCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleUrlFileNameCondition>? UrlFileNameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRuleUrlPathCondition>? UrlPathCondition { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2EndpointSpecInitProviderDeliveryRuleUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2EndpointSpecInitProviderDeliveryRuleUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGeoFilter
{
    /// <summary>The Action of the Geo Filter. Possible values include Allow and Block.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A List of two letter country codes (e.g. US, GB) to be associated with this Geo Filter.</summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>The relative path applicable to geo filter.</summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

/// <summary>A cache_expiration_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGlobalDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A cache_key_query_string_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGlobalDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGlobalDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGlobalDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A url_redirect_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGlobalDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGlobalDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderGlobalDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public V1beta2EndpointSpecInitProviderGlobalDeliveryRuleCacheExpirationAction? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public V1beta2EndpointSpecInitProviderGlobalDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta2EndpointSpecInitProviderGlobalDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta2EndpointSpecInitProviderGlobalDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2EndpointSpecInitProviderGlobalDeliveryRuleUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2EndpointSpecInitProviderGlobalDeliveryRuleUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProviderOrigin
{
    /// <summary>A string that determines the hostname/IP address of the origin server. This string can be a domain name, Storage Account endpoint, Web App endpoint, IPv4 address or IPv6 address. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The HTTP port of the origin. Defaults to 80. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS port of the origin. Defaults to 443. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecInitProvider
{
    /// <summary>An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Rules for the rules engine. An endpoint can contain up until 4 of those rules that consist of conditions and actions. A delivery_rule blocks as defined below.</summary>
    [JsonPropertyName("deliveryRule")]
    public IList<V1beta2EndpointSpecInitProviderDeliveryRule>? DeliveryRule { get; set; }

    /// <summary>A set of Geo Filters for this CDN Endpoint. Each geo_filter block supports fields documented below.</summary>
    [JsonPropertyName("geoFilter")]
    public IList<V1beta2EndpointSpecInitProviderGeoFilter>? GeoFilter { get; set; }

    /// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
    [JsonPropertyName("globalDeliveryRule")]
    public V1beta2EndpointSpecInitProviderGlobalDeliveryRule? GlobalDeliveryRule { get; set; }

    /// <summary>Indicates whether compression is to be enabled.</summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>Specifies if http allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>Specifies if https allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>What types of optimization should this CDN Endpoint optimize for? Possible values include DynamicSiteAcceleration, GeneralMediaStreaming, GeneralWebDelivery, LargeFileDownload and VideoOnDemandMediaStreaming.</summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each origin block supports fields documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta2EndpointSpecInitProviderOrigin>? Origin { get; set; }

    /// <summary>The host header CDN provider will send along with content requests to origins.</summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>The path used at for origin requests.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin_path.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>Sets query string caching behavior. Allowed values are IgnoreQueryString, BypassCaching and UseQueryString. NotSet value can be used for Premium Verizon CDN profile. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("querystringCachingBehaviour")]
    public string? QuerystringCachingBehaviour { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecManagementPoliciesEnum>))]
public enum V1beta2EndpointSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2EndpointSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2EndpointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>EndpointSpec defines the desired state of Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointSpec
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
    public V1beta2EndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2EndpointSpecForProvider ForProvider { get; set; }

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
    public V1beta2EndpointSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2EndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2EndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2EndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A cache_expiration_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A cache_key_query_string_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleCookiesCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A device_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleDeviceCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleHttpVersionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRulePostArgCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleQueryStringCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleRemoteAddressCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleRequestBodyCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleRequestHeaderCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Header name.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A request_method_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleRequestMethodCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>A request_scheme_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleRequestSchemeCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleRequestUriCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleUrlFileExtensionCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleUrlFileNameCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleUrlPathCondition
{
    /// <summary>List of string values. This is required if operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Valid values are Any, BeginsWith, Contains, EndsWith, Equal, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual, RegEx and Wildcard.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transforms. Valid values are Lowercase and Uppercase.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A url_redirect_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public V1beta2EndpointStatusAtProviderDeliveryRuleCacheExpirationAction? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public V1beta2EndpointStatusAtProviderDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction { get; set; }

    /// <summary>A cookies_condition block as defined above.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A device_condition block as defined below.</summary>
    [JsonPropertyName("deviceCondition")]
    public V1beta2EndpointStatusAtProviderDeliveryRuleDeviceCondition? DeviceCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>The Name which should be used for this Delivery Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The order used for this rule. The order values should be sequential and begin at 1.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>A post_arg_condition block as defined below.</summary>
    [JsonPropertyName("postArgCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRulePostArgCondition>? PostArgCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public V1beta2EndpointStatusAtProviderDeliveryRuleRequestMethodCondition? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public V1beta2EndpointStatusAtProviderDeliveryRuleRequestSchemeCondition? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_file_name_condition block as defined below.</summary>
    [JsonPropertyName("urlFileNameCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleUrlFileNameCondition>? UrlFileNameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRuleUrlPathCondition>? UrlPathCondition { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2EndpointStatusAtProviderDeliveryRuleUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2EndpointStatusAtProviderDeliveryRuleUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGeoFilter
{
    /// <summary>The Action of the Geo Filter. Possible values include Allow and Block.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A List of two letter country codes (e.g. US, GB) to be associated with this Geo Filter.</summary>
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>The relative path applicable to geo filter.</summary>
    [JsonPropertyName("relativePath")]
    public string? RelativePath { get; set; }
}

/// <summary>A cache_expiration_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGlobalDeliveryRuleCacheExpirationAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Duration of the cache. Only allowed when behavior is set to Override or SetIfMissing. Format: [d.]hh:mm:ss</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary>A cache_key_query_string_action block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGlobalDeliveryRuleCacheKeyQueryStringAction
{
    /// <summary>The behavior of the cache key for query strings. Valid values are Exclude, ExcludeAll, Include and IncludeAll.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary>Comma separated list of parameter values.</summary>
    [JsonPropertyName("parameters")]
    public string? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGlobalDeliveryRuleModifyRequestHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGlobalDeliveryRuleModifyResponseHeaderAction
{
    /// <summary>Action to be executed on a header value. Valid values are Append, Delete and Overwrite.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the header. Only needed when action is set to Append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A url_redirect_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGlobalDeliveryRuleUrlRedirectAction
{
    /// <summary>Specifies the fragment part of the URL. This value must not start with a #.</summary>
    [JsonPropertyName("fragment")]
    public string? Fragment { get; set; }

    /// <summary>Specifies the hostname part of the URL.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>Specifies the path part of the URL. This value must begin with a /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol part of the URL. Valid values are MatchRequest, Http and Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the query string part of the URL. This value must not start with a ? or &amp; and must be in &lt;key&gt;=&lt;value&gt; format separated by &amp;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Type of the redirect. Valid values are Found, Moved, PermanentRedirect and TemporaryRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGlobalDeliveryRuleUrlRewriteAction
{
    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Whether preserve an unmatched path. Defaults to true.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>This value must start with a / and can&apos;t be longer than 260 characters.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderGlobalDeliveryRule
{
    /// <summary>A cache_expiration_action block as defined above.</summary>
    [JsonPropertyName("cacheExpirationAction")]
    public V1beta2EndpointStatusAtProviderGlobalDeliveryRuleCacheExpirationAction? CacheExpirationAction { get; set; }

    /// <summary>A cache_key_query_string_action block as defined above.</summary>
    [JsonPropertyName("cacheKeyQueryStringAction")]
    public V1beta2EndpointStatusAtProviderGlobalDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringAction { get; set; }

    /// <summary>A modify_request_header_action block as defined below.</summary>
    [JsonPropertyName("modifyRequestHeaderAction")]
    public IList<V1beta2EndpointStatusAtProviderGlobalDeliveryRuleModifyRequestHeaderAction>? ModifyRequestHeaderAction { get; set; }

    /// <summary>A modify_response_header_action block as defined below.</summary>
    [JsonPropertyName("modifyResponseHeaderAction")]
    public IList<V1beta2EndpointStatusAtProviderGlobalDeliveryRuleModifyResponseHeaderAction>? ModifyResponseHeaderAction { get; set; }

    /// <summary>A url_redirect_action block as defined below.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2EndpointStatusAtProviderGlobalDeliveryRuleUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2EndpointStatusAtProviderGlobalDeliveryRuleUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProviderOrigin
{
    /// <summary>A string that determines the hostname/IP address of the origin server. This string can be a domain name, Storage Account endpoint, Web App endpoint, IPv4 address or IPv6 address. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The HTTP port of the origin. Defaults to 80. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS port of the origin. Defaults to 443. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>The name of the origin. This is an arbitrary value. However, this value needs to be unique under the endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusAtProvider
{
    /// <summary>An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Rules for the rules engine. An endpoint can contain up until 4 of those rules that consist of conditions and actions. A delivery_rule blocks as defined below.</summary>
    [JsonPropertyName("deliveryRule")]
    public IList<V1beta2EndpointStatusAtProviderDeliveryRule>? DeliveryRule { get; set; }

    /// <summary>The Fully Qualified Domain Name of the CDN Endpoint.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>A set of Geo Filters for this CDN Endpoint. Each geo_filter block supports fields documented below.</summary>
    [JsonPropertyName("geoFilter")]
    public IList<V1beta2EndpointStatusAtProviderGeoFilter>? GeoFilter { get; set; }

    /// <summary>Actions that are valid for all resources regardless of any conditions. A global_delivery_rule block as defined below.</summary>
    [JsonPropertyName("globalDeliveryRule")]
    public V1beta2EndpointStatusAtProviderGlobalDeliveryRule? GlobalDeliveryRule { get; set; }

    /// <summary>The ID of the CDN Endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indicates whether compression is to be enabled.</summary>
    [JsonPropertyName("isCompressionEnabled")]
    public bool? IsCompressionEnabled { get; set; }

    /// <summary>Specifies if http allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpAllowed")]
    public bool? IsHttpAllowed { get; set; }

    /// <summary>Specifies if https allowed. Defaults to true.</summary>
    [JsonPropertyName("isHttpsAllowed")]
    public bool? IsHttpsAllowed { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>What types of optimization should this CDN Endpoint optimize for? Possible values include DynamicSiteAcceleration, GeneralMediaStreaming, GeneralWebDelivery, LargeFileDownload and VideoOnDemandMediaStreaming.</summary>
    [JsonPropertyName("optimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each origin block supports fields documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("origin")]
    public IList<V1beta2EndpointStatusAtProviderOrigin>? Origin { get; set; }

    /// <summary>The host header CDN provider will send along with content requests to origins.</summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>The path used at for origin requests.</summary>
    [JsonPropertyName("originPath")]
    public string? OriginPath { get; set; }

    /// <summary>the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin_path.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>The CDN Profile to which to attach the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary>Sets query string caching behavior. Allowed values are IgnoreQueryString, BypassCaching and UseQueryString. NotSet value can be used for Premium Verizon CDN profile. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("querystringCachingBehaviour")]
    public string? QuerystringCachingBehaviour { get; set; }

    /// <summary>The name of the resource group in which to create the CDN Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatusConditions
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

/// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2EndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API. Manages a CDN (classic) Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EndpointSpec>, IStatus<V1beta2EndpointStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Endpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointSpec defines the desired state of Endpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta2EndpointSpec Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta2EndpointStatus? Status { get; set; }
}