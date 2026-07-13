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
/// <summary>FrontdoorRoute is the Schema for the FrontdoorRoutes API. Manages a Front Door (standard/premium) Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorRouteList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FrontdoorRoute>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorRouteList";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorroutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorRouteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FrontdoorRoute objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FrontdoorRoute> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecDeletionPolicyEnum>))]
public enum V1beta2FrontdoorRouteSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A cache block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCache
{
    /// <summary>Is content compression enabled? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>A list of one or more Content types (formerly known as MIME types) to compress. Possible values include application/eot, application/font, application/font-sfnt, application/javascript, application/json, application/opentype, application/otf, application/pkcs7-mime, application/truetype, application/ttf, application/vnd.ms-fontobject, application/xhtml+xml, application/xml, application/xml+rss, application/x-font-opentype, application/x-font-truetype, application/x-font-ttf, application/x-httpd-cgi, application/x-mpegurl, application/x-opentype, application/x-otf, application/x-perl, application/x-ttf, application/x-javascript, font/eot, font/ttf, font/otf, font/opentype, image/svg+xml, text/css, text/csv, text/html, text/javascript, text/js, text/plain, text/richtext, text/tab-separated-values, text/xml, text/x-script, text/x-component or text/x-java-source.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Defines how the Front Door Route will cache requests that include query strings. Possible values include IgnoreQueryString, IgnoreSpecifiedQueryStrings, IncludeSpecifiedQueryStrings or UseQueryString. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>Query strings to include or ignore.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<string>? QueryStrings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelector
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
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelector
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
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelector
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
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelector
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
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelector
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
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecForProvider
{
    /// <summary>A cache block as defined below.</summary>
    [JsonPropertyName("cache")]
    public V1beta2FrontdoorRouteSpecForProviderCache? Cache { get; set; }

    /// <summary>The IDs of the Front Door Custom Domains which are associated with this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIds")]
    public IList<string>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>References to FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsRefs")]
    public IList<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsRefs>? CdnFrontdoorCustomDomainIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsSelector")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorCustomDomainIdsSelector? CdnFrontdoorCustomDomainIdsSelector { get; set; }

    /// <summary>The resource ID of the Front Door Endpoint where this Front Door Route should exist. Changing this forces a new Front Door Route to be created.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointId")]
    public string? CdnFrontdoorEndpointId { get; set; }

    /// <summary>Reference to a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointIdRef")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdRef? CdnFrontdoorEndpointIdRef { get; set; }

    /// <summary>Selector for a FrontdoorEndpoint in cdn to populate cdnFrontdoorEndpointId.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointIdSelector")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorEndpointIdSelector? CdnFrontdoorEndpointIdSelector { get; set; }

    /// <summary>The resource ID of the Front Door Origin Group where this Front Door Route should be created.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>One or more Front Door Origin resource IDs that this Front Door Route will link to.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIds")]
    public IList<string>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>References to FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsRefs")]
    public IList<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsRefs>? CdnFrontdoorOriginIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsSelector")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorOriginIdsSelector? CdnFrontdoorOriginIdsSelector { get; set; }

    /// <summary>A directory path on the Front Door Origin that can be used to retrieve content (e.g. contoso.cloudapp.net/originpath).</summary>
    [JsonPropertyName("cdnFrontdoorOriginPath")]
    public string? CdnFrontdoorOriginPath { get; set; }

    /// <summary>A list of the Front Door Rule Set IDs which should be assigned to this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIds")]
    public IList<string>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>References to FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsRefs")]
    public IList<V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsRefs>? CdnFrontdoorRuleSetIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsSelector")]
    public V1beta2FrontdoorRouteSpecForProviderCdnFrontdoorRuleSetIdsSelector? CdnFrontdoorRuleSetIdsSelector { get; set; }

    /// <summary>Is this Front Door Route enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Protocol that will be use when forwarding traffic to backends. Possible values are HttpOnly, HttpsOnly or MatchRequest. Defaults to MatchRequest.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Automatically redirect HTTP traffic to HTTPS traffic? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("httpsRedirectEnabled")]
    public bool? HttpsRedirectEnabled { get; set; }

    /// <summary>Should this Front Door Route be linked to the default endpoint? Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public bool? LinkToDefaultDomain { get; set; }

    /// <summary>The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>One or more Protocols supported by this Front Door Route. Possible values are Http or Https.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }
}

/// <summary>A cache block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCache
{
    /// <summary>Is content compression enabled? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>A list of one or more Content types (formerly known as MIME types) to compress. Possible values include application/eot, application/font, application/font-sfnt, application/javascript, application/json, application/opentype, application/otf, application/pkcs7-mime, application/truetype, application/ttf, application/vnd.ms-fontobject, application/xhtml+xml, application/xml, application/xml+rss, application/x-font-opentype, application/x-font-truetype, application/x-font-ttf, application/x-httpd-cgi, application/x-mpegurl, application/x-opentype, application/x-otf, application/x-perl, application/x-ttf, application/x-javascript, font/eot, font/ttf, font/otf, font/opentype, image/svg+xml, text/css, text/csv, text/html, text/javascript, text/js, text/plain, text/richtext, text/tab-separated-values, text/xml, text/x-script, text/x-component or text/x-java-source.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Defines how the Front Door Route will cache requests that include query strings. Possible values include IgnoreQueryString, IgnoreSpecifiedQueryStrings, IncludeSpecifiedQueryStrings or UseQueryString. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>Query strings to include or ignore.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<string>? QueryStrings { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelector
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
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelector
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
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelector
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
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelector
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
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2FrontdoorRouteSpecInitProvider
{
    /// <summary>A cache block as defined below.</summary>
    [JsonPropertyName("cache")]
    public V1beta2FrontdoorRouteSpecInitProviderCache? Cache { get; set; }

    /// <summary>The IDs of the Front Door Custom Domains which are associated with this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIds")]
    public IList<string>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>References to FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsRefs")]
    public IList<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsRefs>? CdnFrontdoorCustomDomainIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorCustomDomain in cdn to populate cdnFrontdoorCustomDomainIds.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIdsSelector")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorCustomDomainIdsSelector? CdnFrontdoorCustomDomainIdsSelector { get; set; }

    /// <summary>The resource ID of the Front Door Origin Group where this Front Door Route should be created.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>Reference to a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdRef")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdRef? CdnFrontdoorOriginGroupIdRef { get; set; }

    /// <summary>Selector for a FrontdoorOriginGroup in cdn to populate cdnFrontdoorOriginGroupId.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupIdSelector")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginGroupIdSelector? CdnFrontdoorOriginGroupIdSelector { get; set; }

    /// <summary>One or more Front Door Origin resource IDs that this Front Door Route will link to.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIds")]
    public IList<string>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>References to FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsRefs")]
    public IList<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsRefs>? CdnFrontdoorOriginIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorOrigin in cdn to populate cdnFrontdoorOriginIds.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIdsSelector")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorOriginIdsSelector? CdnFrontdoorOriginIdsSelector { get; set; }

    /// <summary>A directory path on the Front Door Origin that can be used to retrieve content (e.g. contoso.cloudapp.net/originpath).</summary>
    [JsonPropertyName("cdnFrontdoorOriginPath")]
    public string? CdnFrontdoorOriginPath { get; set; }

    /// <summary>A list of the Front Door Rule Set IDs which should be assigned to this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIds")]
    public IList<string>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>References to FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsRefs")]
    public IList<V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsRefs>? CdnFrontdoorRuleSetIdsRefs { get; set; }

    /// <summary>Selector for a list of FrontdoorRuleSet in cdn to populate cdnFrontdoorRuleSetIds.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIdsSelector")]
    public V1beta2FrontdoorRouteSpecInitProviderCdnFrontdoorRuleSetIdsSelector? CdnFrontdoorRuleSetIdsSelector { get; set; }

    /// <summary>Is this Front Door Route enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Protocol that will be use when forwarding traffic to backends. Possible values are HttpOnly, HttpsOnly or MatchRequest. Defaults to MatchRequest.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Automatically redirect HTTP traffic to HTTPS traffic? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("httpsRedirectEnabled")]
    public bool? HttpsRedirectEnabled { get; set; }

    /// <summary>Should this Front Door Route be linked to the default endpoint? Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public bool? LinkToDefaultDomain { get; set; }

    /// <summary>The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>One or more Protocols supported by this Front Door Route. Possible values are Http or Https.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecManagementPoliciesEnum>))]
public enum V1beta2FrontdoorRouteSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRouteSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRouteSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRouteSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRouteSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRouteSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRouteSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FrontdoorRouteSpec defines the desired state of FrontdoorRoute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteSpec
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
    public V1beta2FrontdoorRouteSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FrontdoorRouteSpecForProvider ForProvider { get; set; }

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
    public V1beta2FrontdoorRouteSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FrontdoorRouteSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FrontdoorRouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FrontdoorRouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A cache block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteStatusAtProviderCache
{
    /// <summary>Is content compression enabled? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("compressionEnabled")]
    public bool? CompressionEnabled { get; set; }

    /// <summary>A list of one or more Content types (formerly known as MIME types) to compress. Possible values include application/eot, application/font, application/font-sfnt, application/javascript, application/json, application/opentype, application/otf, application/pkcs7-mime, application/truetype, application/ttf, application/vnd.ms-fontobject, application/xhtml+xml, application/xml, application/xml+rss, application/x-font-opentype, application/x-font-truetype, application/x-font-ttf, application/x-httpd-cgi, application/x-mpegurl, application/x-opentype, application/x-otf, application/x-perl, application/x-ttf, application/x-javascript, font/eot, font/ttf, font/otf, font/opentype, image/svg+xml, text/css, text/csv, text/html, text/javascript, text/js, text/plain, text/richtext, text/tab-separated-values, text/xml, text/x-script, text/x-component or text/x-java-source.</summary>
    [JsonPropertyName("contentTypesToCompress")]
    public IList<string>? ContentTypesToCompress { get; set; }

    /// <summary>Defines how the Front Door Route will cache requests that include query strings. Possible values include IgnoreQueryString, IgnoreSpecifiedQueryStrings, IncludeSpecifiedQueryStrings or UseQueryString. Defaults to IgnoreQueryString.</summary>
    [JsonPropertyName("queryStringCachingBehavior")]
    public string? QueryStringCachingBehavior { get; set; }

    /// <summary>Query strings to include or ignore.</summary>
    [JsonPropertyName("queryStrings")]
    public IList<string>? QueryStrings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteStatusAtProvider
{
    /// <summary>A cache block as defined below.</summary>
    [JsonPropertyName("cache")]
    public V1beta2FrontdoorRouteStatusAtProviderCache? Cache { get; set; }

    /// <summary>The IDs of the Front Door Custom Domains which are associated with this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorCustomDomainIds")]
    public IList<string>? CdnFrontdoorCustomDomainIds { get; set; }

    /// <summary>The resource ID of the Front Door Endpoint where this Front Door Route should exist. Changing this forces a new Front Door Route to be created.</summary>
    [JsonPropertyName("cdnFrontdoorEndpointId")]
    public string? CdnFrontdoorEndpointId { get; set; }

    /// <summary>The resource ID of the Front Door Origin Group where this Front Door Route should be created.</summary>
    [JsonPropertyName("cdnFrontdoorOriginGroupId")]
    public string? CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>One or more Front Door Origin resource IDs that this Front Door Route will link to.</summary>
    [JsonPropertyName("cdnFrontdoorOriginIds")]
    public IList<string>? CdnFrontdoorOriginIds { get; set; }

    /// <summary>A directory path on the Front Door Origin that can be used to retrieve content (e.g. contoso.cloudapp.net/originpath).</summary>
    [JsonPropertyName("cdnFrontdoorOriginPath")]
    public string? CdnFrontdoorOriginPath { get; set; }

    /// <summary>A list of the Front Door Rule Set IDs which should be assigned to this Front Door Route.</summary>
    [JsonPropertyName("cdnFrontdoorRuleSetIds")]
    public IList<string>? CdnFrontdoorRuleSetIds { get; set; }

    /// <summary>Is this Front Door Route enabled? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Protocol that will be use when forwarding traffic to backends. Possible values are HttpOnly, HttpsOnly or MatchRequest. Defaults to MatchRequest.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }

    /// <summary>Automatically redirect HTTP traffic to HTTPS traffic? Possible values are true or false. Defaults to true.</summary>
    [JsonPropertyName("httpsRedirectEnabled")]
    public bool? HttpsRedirectEnabled { get; set; }

    /// <summary>The ID of the Front Door Route.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Should this Front Door Route be linked to the default endpoint? Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("linkToDefaultDomain")]
    public bool? LinkToDefaultDomain { get; set; }

    /// <summary>The route patterns of the rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>One or more Protocols supported by this Front Door Route. Possible values are Http or Https.</summary>
    [JsonPropertyName("supportedProtocols")]
    public IList<string>? SupportedProtocols { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteStatusConditions
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

/// <summary>FrontdoorRouteStatus defines the observed state of FrontdoorRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRouteStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FrontdoorRouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FrontdoorRouteStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorRoute is the Schema for the FrontdoorRoutes API. Manages a Front Door (standard/premium) Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FrontdoorRouteSpec>, IStatus<V1beta2FrontdoorRouteStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorRoute";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorroutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorRoute";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorRouteSpec defines the desired state of FrontdoorRoute</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FrontdoorRouteSpec Spec { get; set; }

    /// <summary>FrontdoorRouteStatus defines the observed state of FrontdoorRoute.</summary>
    [JsonPropertyName("status")]
    public V1beta2FrontdoorRouteStatus? Status { get; set; }
}