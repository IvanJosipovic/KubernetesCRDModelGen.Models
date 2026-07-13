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
/// <summary>FrontdoorRule is the Schema for the FrontdoorRules API. Manages a Front Door (standard/premium) Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FrontdoorRule>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorRuleList";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FrontdoorRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FrontdoorRule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecDeletionPolicyEnum>))]
public enum V1beta2FrontdoorRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsRequestHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsResponseHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector
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
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A route_configuration_override_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideAction
{
    /// <summary>HonorOrigin the Front Door will always honor origin response header directive. If the origin directive is missing, Front Door will cache contents anywhere from 1 to 3 days. OverrideAlways the TTL value returned from your Front Door Origin is overwritten with the value specified in the action. This behavior will only be applied if the response is cacheable. OverrideIfOriginMissing if no TTL value gets returned from your Front Door Origin, the rule sets the TTL to the value specified in the action. This behavior will only be applied if the response is cacheable. Disabled the Front Door will not cache the response contents, irrespective of Front Door Origin response directives. Possible values include HonorOrigin, OverrideAlways, OverrideIfOriginMissing or Disabled.</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>When Cache behavior is set to Override or SetIfMissing, this field specifies the cache duration to use. The maximum duration is 366 days specified in the d.HH:MM:SS format(e.g. 365.23:59:59). If the desired maximum cache duration is less than 1 day then the maximum cache duration should be specified in the HH:MM:SS format(e.g. 23:59:59).</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>The Front Door Origin Group resource ID that the request should be routed to. This overrides the configuration specified in the Front Door Endpoint route.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>Should the Front Door dynamically compress the content? Possible values include true or false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The forwarding protocol the request will be redirected as. This overrides the configuration specified in the route to be associated with. Possible values include MatchRequest, HttpOnly or HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>IncludeSpecifiedQueryStrings query strings specified in the query_string_parameters field get included when the cache key gets generated. UseQueryString cache every unique URL, each unique URL will have its own cache key. IgnoreSpecifiedQueryStrings query strings specified in the query_string_parameters field get excluded when the cache key gets generated. IgnoreQueryString query strings aren&apos;t considered when the cache key gets generated. Possible values include IgnoreQueryString, UseQueryString, IgnoreSpecifiedQueryStrings or IncludeSpecifiedQueryStrings.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>A list of query string parameter names.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IList<string>? QueryStringParameters { get; set; }
}

/// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsUrlRedirectAction
{
    /// <summary>The fragment to use in the redirect. The value must be a string between 0 and 1024 characters in length, leave blank to preserve the incoming fragment. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("destinationFragment")]
    public string? DestinationFragment { get; set; }

    /// <summary>The host name you want the request to be redirected to. The value must be a string between 0 and 2048 characters in length, leave blank to preserve the incoming host.</summary>
    [JsonPropertyName("destinationHostname")]
    public string? DestinationHostname { get; set; }

    /// <summary>The path to use in the redirect. The value must be a string and include the leading /, leave blank to preserve the incoming path. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>The query string used in the redirect URL. The value must be in the &lt;key&gt;=&lt;value&gt; or &lt;key&gt;={action_server_variable} format and must not include the leading ?, leave blank to preserve the incoming query string. Maximum allowed length for this field is 2048 characters. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>The protocol the request will be redirected as. Possible values include MatchRequest, Http or Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>The response type to return to the requestor. Possible values include Moved, Found , TemporaryRedirect or PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActionsUrlRewriteAction
{
    /// <summary>The destination path to use in the rewrite. The destination path overwrites the source pattern.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Append the remaining path after the source pattern to the new destination path? Possible values true or false. Defaults to false.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>The source pattern in the URL path to replace. This uses prefix-based matching. For example, to match all URL paths use a forward slash &quot;/&quot; as the source pattern value.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary>An actions block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderActions
{
    /// <summary>A request_header_action block as defined below.</summary>
    [JsonPropertyName("requestHeaderAction")]
    public IList<V1beta2FrontdoorRuleSpecForProviderActionsRequestHeaderAction>? RequestHeaderAction { get; set; }

    /// <summary>A response_header_action block as defined below.</summary>
    [JsonPropertyName("responseHeaderAction")]
    public IList<V1beta2FrontdoorRuleSpecForProviderActionsResponseHeaderAction>? ResponseHeaderAction { get; set; }

    /// <summary>A route_configuration_override_action block as defined below.</summary>
    [JsonPropertyName("routeConfigurationOverrideAction")]
    public V1beta2FrontdoorRuleSpecForProviderActionsRouteConfigurationOverrideAction? RouteConfigurationOverrideAction { get; set; }

    /// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2FrontdoorRuleSpecForProviderActionsUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2FrontdoorRuleSpecForProviderActionsUrlRewriteAction? UrlRewriteAction { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelector
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
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsClientPortCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsCookiesCondition
{
    /// <summary>A string value representing the name of the cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsHostNameCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsHttpVersionCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsIsDeviceCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsPostArgsCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A string value representing the name of the POST argument.</summary>
    [JsonPropertyName("postArgsName")]
    public string? PostArgsName { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsQueryStringCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsRemoteAddressCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsRequestBodyCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsRequestHeaderCondition
{
    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsRequestMethodCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsRequestSchemeCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsRequestUriCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsServerPortCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsSocketAddressCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsSslProtocolCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsUrlFileExtensionCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsUrlFilenameCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditionsUrlPathCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A conditions block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProviderConditions
{
    /// <summary>A client_port_condition block as defined below.</summary>
    [JsonPropertyName("clientPortCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsClientPortCondition>? ClientPortCondition { get; set; }

    /// <summary>A cookies_condition block as defined below.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A host_name_condition block as defined below.</summary>
    [JsonPropertyName("hostNameCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsHostNameCondition>? HostNameCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A is_device_condition block as defined below.</summary>
    [JsonPropertyName("isDeviceCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsIsDeviceCondition>? IsDeviceCondition { get; set; }

    /// <summary>A post_args_condition block as defined below.</summary>
    [JsonPropertyName("postArgsCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsPostArgsCondition>? PostArgsCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A server_port_condition block as defined below.</summary>
    [JsonPropertyName("serverPortCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsServerPortCondition>? ServerPortCondition { get; set; }

    /// <summary>A socket_address_condition block as defined below.</summary>
    [JsonPropertyName("socketAddressCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsSocketAddressCondition>? SocketAddressCondition { get; set; }

    /// <summary>A ssl_protocol_condition block as defined below.</summary>
    [JsonPropertyName("sslProtocolCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsSslProtocolCondition>? SslProtocolCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_filename_condition block as defined below.</summary>
    [JsonPropertyName("urlFilenameCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsUrlFilenameCondition>? UrlFilenameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta2FrontdoorRuleSpecForProviderConditionsUrlPathCondition>? UrlPathCondition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecForProvider
{
    /// <summary>An actions block as defined below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2FrontdoorRuleSpecForProviderActions? Actions { get; set; }

    /// <summary>If this rule is a match should the rules engine continue processing the remaining rules or stop? Possible values are Continue and Stop. Defaults to Continue.</summary>
    [JsonPropertyName("behaviorOnMatch")]
    public string? BehaviorOnMatch { get; set; }

    /// <summary>The resource ID of the Front Door Rule Set for this Front Door Rule. Changing this forces a new Front Door Rule to be created.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetId")]
    public string? CdnFrontdoorRuleSetId { get; set; }

    /// <summary>Reference to a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdRef")]
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdRef? CdnFrontdoorRuleSetIdRef { get; set; }

    /// <summary>Selector for a FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetId.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdSelector")]
    public V1beta2FrontdoorRuleSpecForProviderCdnFrontdoorRuleSetIdSelector? CdnFrontdoorRuleSetIdSelector { get; set; }

    /// <summary>A conditions block as defined below.</summary>
    [JsonPropertyName("conditions")]
    public V1beta2FrontdoorRuleSpecForProviderConditions? Conditions { get; set; }

    /// <summary>The order in which the rules will be applied for the Front Door Endpoint. The order value should be sequential and begin at 1(e.g. 1, 2, 3...). A Front Door Rule with a lesser order value will be applied before a rule with a greater order value.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsRequestHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsResponseHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector
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
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A route_configuration_override_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideAction
{
    /// <summary>HonorOrigin the Front Door will always honor origin response header directive. If the origin directive is missing, Front Door will cache contents anywhere from 1 to 3 days. OverrideAlways the TTL value returned from your Front Door Origin is overwritten with the value specified in the action. This behavior will only be applied if the response is cacheable. OverrideIfOriginMissing if no TTL value gets returned from your Front Door Origin, the rule sets the TTL to the value specified in the action. This behavior will only be applied if the response is cacheable. Disabled the Front Door will not cache the response contents, irrespective of Front Door Origin response directives. Possible values include HonorOrigin, OverrideAlways, OverrideIfOriginMissing or Disabled.</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>When Cache behavior is set to Override or SetIfMissing, this field specifies the cache duration to use. The maximum duration is 366 days specified in the d.HH:MM:SS format(e.g. 365.23:59:59). If the desired maximum cache duration is less than 1 day then the maximum cache duration should be specified in the HH:MM:SS format(e.g. 23:59:59).</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>The Front Door Origin Group resource ID that the request should be routed to. This overrides the configuration specified in the Front Door Endpoint route.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideActionCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>Should the Front Door dynamically compress the content? Possible values include true or false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The forwarding protocol the request will be redirected as. This overrides the configuration specified in the route to be associated with. Possible values include MatchRequest, HttpOnly or HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>IncludeSpecifiedQueryStrings query strings specified in the query_string_parameters field get included when the cache key gets generated. UseQueryString cache every unique URL, each unique URL will have its own cache key. IgnoreSpecifiedQueryStrings query strings specified in the query_string_parameters field get excluded when the cache key gets generated. IgnoreQueryString query strings aren&apos;t considered when the cache key gets generated. Possible values include IgnoreQueryString, UseQueryString, IgnoreSpecifiedQueryStrings or IncludeSpecifiedQueryStrings.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>A list of query string parameter names.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IList<string>? QueryStringParameters { get; set; }
}

/// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsUrlRedirectAction
{
    /// <summary>The fragment to use in the redirect. The value must be a string between 0 and 1024 characters in length, leave blank to preserve the incoming fragment. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("destinationFragment")]
    public string? DestinationFragment { get; set; }

    /// <summary>The host name you want the request to be redirected to. The value must be a string between 0 and 2048 characters in length, leave blank to preserve the incoming host.</summary>
    [JsonPropertyName("destinationHostname")]
    public string? DestinationHostname { get; set; }

    /// <summary>The path to use in the redirect. The value must be a string and include the leading /, leave blank to preserve the incoming path. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>The query string used in the redirect URL. The value must be in the &lt;key&gt;=&lt;value&gt; or &lt;key&gt;={action_server_variable} format and must not include the leading ?, leave blank to preserve the incoming query string. Maximum allowed length for this field is 2048 characters. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>The protocol the request will be redirected as. Possible values include MatchRequest, Http or Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>The response type to return to the requestor. Possible values include Moved, Found , TemporaryRedirect or PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActionsUrlRewriteAction
{
    /// <summary>The destination path to use in the rewrite. The destination path overwrites the source pattern.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Append the remaining path after the source pattern to the new destination path? Possible values true or false. Defaults to false.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>The source pattern in the URL path to replace. This uses prefix-based matching. For example, to match all URL paths use a forward slash &quot;/&quot; as the source pattern value.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary>An actions block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderActions
{
    /// <summary>A request_header_action block as defined below.</summary>
    [JsonPropertyName("requestHeaderAction")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderActionsRequestHeaderAction>? RequestHeaderAction { get; set; }

    /// <summary>A response_header_action block as defined below.</summary>
    [JsonPropertyName("responseHeaderAction")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderActionsResponseHeaderAction>? ResponseHeaderAction { get; set; }

    /// <summary>A route_configuration_override_action block as defined below.</summary>
    [JsonPropertyName("routeConfigurationOverrideAction")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsRouteConfigurationOverrideAction? RouteConfigurationOverrideAction { get; set; }

    /// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2FrontdoorRuleSpecInitProviderActionsUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsClientPortCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsCookiesCondition
{
    /// <summary>A string value representing the name of the cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsHostNameCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsHttpVersionCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsIsDeviceCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsPostArgsCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A string value representing the name of the POST argument.</summary>
    [JsonPropertyName("postArgsName")]
    public string? PostArgsName { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsQueryStringCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsRemoteAddressCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsRequestBodyCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsRequestHeaderCondition
{
    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsRequestMethodCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsRequestSchemeCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsRequestUriCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsServerPortCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsSocketAddressCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsSslProtocolCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsUrlFileExtensionCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsUrlFilenameCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditionsUrlPathCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A conditions block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecInitProviderConditions
{
    /// <summary>A client_port_condition block as defined below.</summary>
    [JsonPropertyName("clientPortCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsClientPortCondition>? ClientPortCondition { get; set; }

    /// <summary>A cookies_condition block as defined below.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A host_name_condition block as defined below.</summary>
    [JsonPropertyName("hostNameCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsHostNameCondition>? HostNameCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A is_device_condition block as defined below.</summary>
    [JsonPropertyName("isDeviceCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsIsDeviceCondition>? IsDeviceCondition { get; set; }

    /// <summary>A post_args_condition block as defined below.</summary>
    [JsonPropertyName("postArgsCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsPostArgsCondition>? PostArgsCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A server_port_condition block as defined below.</summary>
    [JsonPropertyName("serverPortCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsServerPortCondition>? ServerPortCondition { get; set; }

    /// <summary>A socket_address_condition block as defined below.</summary>
    [JsonPropertyName("socketAddressCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsSocketAddressCondition>? SocketAddressCondition { get; set; }

    /// <summary>A ssl_protocol_condition block as defined below.</summary>
    [JsonPropertyName("sslProtocolCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsSslProtocolCondition>? SslProtocolCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_filename_condition block as defined below.</summary>
    [JsonPropertyName("urlFilenameCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsUrlFilenameCondition>? UrlFilenameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta2FrontdoorRuleSpecInitProviderConditionsUrlPathCondition>? UrlPathCondition { get; set; }
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
public partial class V1beta2FrontdoorRuleSpecInitProvider
{
    /// <summary>An actions block as defined below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2FrontdoorRuleSpecInitProviderActions? Actions { get; set; }

    /// <summary>If this rule is a match should the rules engine continue processing the remaining rules or stop? Possible values are Continue and Stop. Defaults to Continue.</summary>
    [JsonPropertyName("behaviorOnMatch")]
    public string? BehaviorOnMatch { get; set; }

    /// <summary>A conditions block as defined below.</summary>
    [JsonPropertyName("conditions")]
    public V1beta2FrontdoorRuleSpecInitProviderConditions? Conditions { get; set; }

    /// <summary>The order in which the rules will be applied for the Front Door Endpoint. The order value should be sequential and begin at 1(e.g. 1, 2, 3...). A Front Door Rule with a lesser order value will be applied before a rule with a greater order value.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecManagementPoliciesEnum>))]
public enum V1beta2FrontdoorRuleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRuleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FrontdoorRuleSpec defines the desired state of FrontdoorRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleSpec
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
    public V1beta2FrontdoorRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FrontdoorRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta2FrontdoorRuleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FrontdoorRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FrontdoorRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FrontdoorRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderActionsRequestHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderActionsResponseHeaderAction
{
    /// <summary>The action to be taken on the specified header_name. Possible values include Append, Overwrite or Delete.</summary>
    [JsonPropertyName("headerAction")]
    public string? HeaderAction { get; set; }

    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to append or overwrite.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A route_configuration_override_action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderActionsRouteConfigurationOverrideAction
{
    /// <summary>HonorOrigin the Front Door will always honor origin response header directive. If the origin directive is missing, Front Door will cache contents anywhere from 1 to 3 days. OverrideAlways the TTL value returned from your Front Door Origin is overwritten with the value specified in the action. This behavior will only be applied if the response is cacheable. OverrideIfOriginMissing if no TTL value gets returned from your Front Door Origin, the rule sets the TTL to the value specified in the action. This behavior will only be applied if the response is cacheable. Disabled the Front Door will not cache the response contents, irrespective of Front Door Origin response directives. Possible values include HonorOrigin, OverrideAlways, OverrideIfOriginMissing or Disabled.</summary>
    [JsonPropertyName("cacheBehavior")]
    public string? CacheBehavior { get; set; }

    /// <summary>When Cache behavior is set to Override or SetIfMissing, this field specifies the cache duration to use. The maximum duration is 366 days specified in the d.HH:MM:SS format(e.g. 365.23:59:59). If the desired maximum cache duration is less than 1 day then the maximum cache duration should be specified in the HH:MM:SS format(e.g. 23:59:59).</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>The Front Door Origin Group resource ID that the request should be routed to. This overrides the configuration specified in the Front Door Endpoint route.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Should the Front Door dynamically compress the content? Possible values include true or false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>The forwarding protocol the request will be redirected as. This overrides the configuration specified in the route to be associated with. Possible values include MatchRequest, HttpOnly or HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>IncludeSpecifiedQueryStrings query strings specified in the query_string_parameters field get included when the cache key gets generated. UseQueryString cache every unique URL, each unique URL will have its own cache key. IgnoreSpecifiedQueryStrings query strings specified in the query_string_parameters field get excluded when the cache key gets generated. IgnoreQueryString query strings aren&apos;t considered when the cache key gets generated. Possible values include IgnoreQueryString, UseQueryString, IgnoreSpecifiedQueryStrings or IncludeSpecifiedQueryStrings.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>A list of query string parameter names.</summary>
    [JsonPropertyName("queryStringParameters")]
    public IList<string>? QueryStringParameters { get; set; }
}

/// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderActionsUrlRedirectAction
{
    /// <summary>The fragment to use in the redirect. The value must be a string between 0 and 1024 characters in length, leave blank to preserve the incoming fragment. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("destinationFragment")]
    public string? DestinationFragment { get; set; }

    /// <summary>The host name you want the request to be redirected to. The value must be a string between 0 and 2048 characters in length, leave blank to preserve the incoming host.</summary>
    [JsonPropertyName("destinationHostname")]
    public string? DestinationHostname { get; set; }

    /// <summary>The path to use in the redirect. The value must be a string and include the leading /, leave blank to preserve the incoming path. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>The query string used in the redirect URL. The value must be in the &lt;key&gt;=&lt;value&gt; or &lt;key&gt;={action_server_variable} format and must not include the leading ?, leave blank to preserve the incoming query string. Maximum allowed length for this field is 2048 characters. Defaults to &quot; &quot;.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>The protocol the request will be redirected as. Possible values include MatchRequest, Http or Https. Defaults to MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>The response type to return to the requestor. Possible values include Moved, Found , TemporaryRedirect or PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderActionsUrlRewriteAction
{
    /// <summary>The destination path to use in the rewrite. The destination path overwrites the source pattern.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Append the remaining path after the source pattern to the new destination path? Possible values true or false. Defaults to false.</summary>
    [JsonPropertyName("preserveUnmatchedPath")]
    public bool? PreserveUnmatchedPath { get; set; }

    /// <summary>The source pattern in the URL path to replace. This uses prefix-based matching. For example, to match all URL paths use a forward slash &quot;/&quot; as the source pattern value.</summary>
    [JsonPropertyName("sourcePattern")]
    public string? SourcePattern { get; set; }
}

/// <summary>An actions block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderActions
{
    /// <summary>A request_header_action block as defined below.</summary>
    [JsonPropertyName("requestHeaderAction")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderActionsRequestHeaderAction>? RequestHeaderAction { get; set; }

    /// <summary>A response_header_action block as defined below.</summary>
    [JsonPropertyName("responseHeaderAction")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderActionsResponseHeaderAction>? ResponseHeaderAction { get; set; }

    /// <summary>A route_configuration_override_action block as defined below.</summary>
    [JsonPropertyName("routeConfigurationOverrideAction")]
    public V1beta2FrontdoorRuleStatusAtProviderActionsRouteConfigurationOverrideAction? RouteConfigurationOverrideAction { get; set; }

    /// <summary>A url_redirect_action block as defined below. You may not have a url_redirect_action and a url_rewrite_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRedirectAction")]
    public V1beta2FrontdoorRuleStatusAtProviderActionsUrlRedirectAction? UrlRedirectAction { get; set; }

    /// <summary>A url_rewrite_action block as defined below. You may not have a url_rewrite_action and a url_redirect_action defined in the same actions block.</summary>
    [JsonPropertyName("urlRewriteAction")]
    public V1beta2FrontdoorRuleStatusAtProviderActionsUrlRewriteAction? UrlRewriteAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsClientPortCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsCookiesCondition
{
    /// <summary>A string value representing the name of the cookie.</summary>
    [JsonPropertyName("cookieName")]
    public string? CookieName { get; set; }

    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsHostNameCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsHttpVersionCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsIsDeviceCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsPostArgsCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A string value representing the name of the POST argument.</summary>
    [JsonPropertyName("postArgsName")]
    public string? PostArgsName { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsQueryStringCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsRemoteAddressCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsRequestBodyCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsRequestHeaderCondition
{
    /// <summary>The name of the header to modify.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsRequestMethodCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsRequestSchemeCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsRequestUriCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsServerPortCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsSocketAddressCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsSslProtocolCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsUrlFileExtensionCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsUrlFilenameCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditionsUrlPathCondition
{
    /// <summary>One or more string or integer values(e.g. &quot;1&quot;) representing the value of the request path to match. Don&apos;t include the leading slash (/). If multiple values are specified, they&apos;re evaluated using OR logic.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>If true operator becomes the opposite of its value. Possible values true or false. Defaults to false. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>A Conditional operator. Possible values include Any, Equal, Contains, BeginsWith, EndsWith, LessThan, LessThanOrEqual, GreaterThan, GreaterThanOrEqual, RegEx or Wildcard. Details can be found in the Condition Operator List below.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A Conditional operator. Possible values include Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode or UrlEncode. Details can be found in the Condition Transform List below.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>A conditions block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProviderConditions
{
    /// <summary>A client_port_condition block as defined below.</summary>
    [JsonPropertyName("clientPortCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsClientPortCondition>? ClientPortCondition { get; set; }

    /// <summary>A cookies_condition block as defined below.</summary>
    [JsonPropertyName("cookiesCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsCookiesCondition>? CookiesCondition { get; set; }

    /// <summary>A host_name_condition block as defined below.</summary>
    [JsonPropertyName("hostNameCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsHostNameCondition>? HostNameCondition { get; set; }

    /// <summary>A http_version_condition block as defined below.</summary>
    [JsonPropertyName("httpVersionCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsHttpVersionCondition>? HttpVersionCondition { get; set; }

    /// <summary>A is_device_condition block as defined below.</summary>
    [JsonPropertyName("isDeviceCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsIsDeviceCondition>? IsDeviceCondition { get; set; }

    /// <summary>A post_args_condition block as defined below.</summary>
    [JsonPropertyName("postArgsCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsPostArgsCondition>? PostArgsCondition { get; set; }

    /// <summary>A query_string_condition block as defined below.</summary>
    [JsonPropertyName("queryStringCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsQueryStringCondition>? QueryStringCondition { get; set; }

    /// <summary>A remote_address_condition block as defined below.</summary>
    [JsonPropertyName("remoteAddressCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsRemoteAddressCondition>? RemoteAddressCondition { get; set; }

    /// <summary>A request_body_condition block as defined below.</summary>
    [JsonPropertyName("requestBodyCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsRequestBodyCondition>? RequestBodyCondition { get; set; }

    /// <summary>A request_header_condition block as defined below.</summary>
    [JsonPropertyName("requestHeaderCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsRequestHeaderCondition>? RequestHeaderCondition { get; set; }

    /// <summary>A request_method_condition block as defined below.</summary>
    [JsonPropertyName("requestMethodCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsRequestMethodCondition>? RequestMethodCondition { get; set; }

    /// <summary>A request_scheme_condition block as defined below.</summary>
    [JsonPropertyName("requestSchemeCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsRequestSchemeCondition>? RequestSchemeCondition { get; set; }

    /// <summary>A request_uri_condition block as defined below.</summary>
    [JsonPropertyName("requestUriCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsRequestUriCondition>? RequestUriCondition { get; set; }

    /// <summary>A server_port_condition block as defined below.</summary>
    [JsonPropertyName("serverPortCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsServerPortCondition>? ServerPortCondition { get; set; }

    /// <summary>A socket_address_condition block as defined below.</summary>
    [JsonPropertyName("socketAddressCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsSocketAddressCondition>? SocketAddressCondition { get; set; }

    /// <summary>A ssl_protocol_condition block as defined below.</summary>
    [JsonPropertyName("sslProtocolCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsSslProtocolCondition>? SslProtocolCondition { get; set; }

    /// <summary>A url_file_extension_condition block as defined below.</summary>
    [JsonPropertyName("urlFileExtensionCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsUrlFileExtensionCondition>? UrlFileExtensionCondition { get; set; }

    /// <summary>A url_filename_condition block as defined below.</summary>
    [JsonPropertyName("urlFilenameCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsUrlFilenameCondition>? UrlFilenameCondition { get; set; }

    /// <summary>A url_path_condition block as defined below.</summary>
    [JsonPropertyName("urlPathCondition")]
    public IList<V1beta2FrontdoorRuleStatusAtProviderConditionsUrlPathCondition>? UrlPathCondition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusAtProvider
{
    /// <summary>An actions block as defined below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2FrontdoorRuleStatusAtProviderActions? Actions { get; set; }

    /// <summary>If this rule is a match should the rules engine continue processing the remaining rules or stop? Possible values are Continue and Stop. Defaults to Continue.</summary>
    [JsonPropertyName("behaviorOnMatch")]
    public string? BehaviorOnMatch { get; set; }

    /// <summary>The resource ID of the Front Door Rule Set for this Front Door Rule. Changing this forces a new Front Door Rule to be created.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetId")]
    public string? CdnFrontdoorRuleSetId { get; set; }

    /// <summary>The name of the Front Door Rule Set containing this Front Door Rule.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetName")]
    public string? CdnFrontdoorRuleSetName { get; set; }

    /// <summary>A conditions block as defined below.</summary>
    [JsonPropertyName("conditions")]
    public V1beta2FrontdoorRuleStatusAtProviderConditions? Conditions { get; set; }

    /// <summary>The ID of the Front Door Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The order in which the rules will be applied for the Front Door Endpoint. The order value should be sequential and begin at 1(e.g. 1, 2, 3...). A Front Door Rule with a lesser order value will be applied before a rule with a greater order value.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatusConditions
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

/// <summary>FrontdoorRuleStatus defines the observed state of FrontdoorRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FrontdoorRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FrontdoorRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorRule is the Schema for the FrontdoorRules API. Manages a Front Door (standard/premium) Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FrontdoorRuleSpec>, IStatus<V1beta2FrontdoorRuleStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorRule";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorRuleSpec defines the desired state of FrontdoorRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FrontdoorRuleSpec Spec { get; set; }

    /// <summary>FrontdoorRuleStatus defines the observed state of FrontdoorRule.</summary>
    [JsonPropertyName("status")]
    public V1beta2FrontdoorRuleStatus? Status { get; set; }
}