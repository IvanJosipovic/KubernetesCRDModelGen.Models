#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary>ApplicationInsightsStandardWebTest is the Schema for the ApplicationInsightsStandardWebTests API. Manages a Application Insights Standard WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ApplicationInsightsStandardWebTestList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ApplicationInsightsStandardWebTest>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ApplicationInsightsStandardWebTestList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "applicationinsightsstandardwebtests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationInsightsStandardWebTestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ApplicationInsightsStandardWebTest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ApplicationInsightsStandardWebTest> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecDeletionPolicyEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelector
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
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderRequestHeader
{
    /// <summary>The name which should be used for this Application Insights Standard WebTest. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value which should be used for a header in the request.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderRequest
{
    /// <summary>The WebTest request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Should the following of redirects be enabled? Defaults to true.</summary>
    [JsonPropertyName("followRedirectsEnabled")]
    public bool? FollowRedirectsEnabled { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ApplicationInsightsStandardWebTestSpecForProviderRequestHeader>? Header { get; set; }

    /// <summary>Which HTTP verb to use for the call. Options are &apos;GET&apos;, &apos;POST&apos;, &apos;PUT&apos;, &apos;PATCH&apos;, &apos;DELETE&apos;, &apos;HEAD&apos;, and &apos;OPTIONS&apos;. Defaults to GET.</summary>
    [JsonPropertyName("httpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>Should the parsing of dependend requests be enabled? Defaults to true.</summary>
    [JsonPropertyName("parseDependentRequestsEnabled")]
    public bool? ParseDependentRequestsEnabled { get; set; }

    /// <summary>The WebTest request URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelector
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
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A content block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderValidationRulesContent
{
    /// <summary>A string value containing the content to match on.</summary>
    [JsonPropertyName("contentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>Ignore the casing in the content_match value.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>If the content of content_match is found, pass the test. If set to false, the WebTest is failing if the content of content_match is found.</summary>
    [JsonPropertyName("passIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary>A validation_rules block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProviderValidationRules
{
    /// <summary>A content block as defined above.</summary>
    [JsonPropertyName("content")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderValidationRulesContent? Content { get; set; }

    /// <summary>The expected status code of the response. Default is &apos;200&apos;, &apos;0&apos; means &apos;response code &lt; 400&apos;</summary>
    [JsonPropertyName("expectedStatusCode")]
    public double? ExpectedStatusCode { get; set; }

    /// <summary>The number of days of SSL certificate validity remaining for the checked endpoint. If the certificate has a shorter remaining lifetime left, the test will fail. This number should be between 1 and 365.</summary>
    [JsonPropertyName("sslCertRemainingLifetime")]
    public double? SslCertRemainingLifetime { get; set; }

    /// <summary>Should the SSL check be enabled?</summary>
    [JsonPropertyName("sslCheckEnabled")]
    public bool? SslCheckEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecForProvider
{
    /// <summary>The ID of the Application Insights instance on which the WebTest operates. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("applicationInsightsId")]
    public string? ApplicationInsightsId { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdRef")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdRef? ApplicationInsightsIdRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdSelector")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderApplicationInsightsIdSelector? ApplicationInsightsIdSelector { get; set; }

    /// <summary>Purpose/user defined descriptive test for this WebTest.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the WebTest be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Interval in seconds between test runs for this WebTest. Valid options are 300, 600 and 900. Defaults to 300.</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies a list of where to physically run the tests from to give global coverage for accessibility of your application.</summary>
    [JsonPropertyName("geoLocations")]
    public IList<string>? GeoLocations { get; set; }

    /// <summary>The Azure Region where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created. It needs to correlate with location of the parent resource (azurerm_application_insights)</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderRequest? Request { get; set; }

    /// <summary>The name of the Resource Group where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Should the retry on WebTest failure be enabled?</summary>
    [JsonPropertyName("retryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Seconds until this WebTest will timeout and fail. Default is 30.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>A validation_rules block as defined below.</summary>
    [JsonPropertyName("validationRules")]
    public V1beta2ApplicationInsightsStandardWebTestSpecForProviderValidationRules? ValidationRules { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelector
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
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderRequestHeader
{
    /// <summary>The name which should be used for this Application Insights Standard WebTest. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value which should be used for a header in the request.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderRequest
{
    /// <summary>The WebTest request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Should the following of redirects be enabled? Defaults to true.</summary>
    [JsonPropertyName("followRedirectsEnabled")]
    public bool? FollowRedirectsEnabled { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ApplicationInsightsStandardWebTestSpecInitProviderRequestHeader>? Header { get; set; }

    /// <summary>Which HTTP verb to use for the call. Options are &apos;GET&apos;, &apos;POST&apos;, &apos;PUT&apos;, &apos;PATCH&apos;, &apos;DELETE&apos;, &apos;HEAD&apos;, and &apos;OPTIONS&apos;. Defaults to GET.</summary>
    [JsonPropertyName("httpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>Should the parsing of dependend requests be enabled? Defaults to true.</summary>
    [JsonPropertyName("parseDependentRequestsEnabled")]
    public bool? ParseDependentRequestsEnabled { get; set; }

    /// <summary>The WebTest request URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A content block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderValidationRulesContent
{
    /// <summary>A string value containing the content to match on.</summary>
    [JsonPropertyName("contentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>Ignore the casing in the content_match value.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>If the content of content_match is found, pass the test. If set to false, the WebTest is failing if the content of content_match is found.</summary>
    [JsonPropertyName("passIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary>A validation_rules block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProviderValidationRules
{
    /// <summary>A content block as defined above.</summary>
    [JsonPropertyName("content")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderValidationRulesContent? Content { get; set; }

    /// <summary>The expected status code of the response. Default is &apos;200&apos;, &apos;0&apos; means &apos;response code &lt; 400&apos;</summary>
    [JsonPropertyName("expectedStatusCode")]
    public double? ExpectedStatusCode { get; set; }

    /// <summary>The number of days of SSL certificate validity remaining for the checked endpoint. If the certificate has a shorter remaining lifetime left, the test will fail. This number should be between 1 and 365.</summary>
    [JsonPropertyName("sslCertRemainingLifetime")]
    public double? SslCertRemainingLifetime { get; set; }

    /// <summary>Should the SSL check be enabled?</summary>
    [JsonPropertyName("sslCheckEnabled")]
    public bool? SslCheckEnabled { get; set; }
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
public partial class V1beta2ApplicationInsightsStandardWebTestSpecInitProvider
{
    /// <summary>The ID of the Application Insights instance on which the WebTest operates. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("applicationInsightsId")]
    public string? ApplicationInsightsId { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdRef")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdRef? ApplicationInsightsIdRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate applicationInsightsId.</summary>
    [JsonPropertyName("applicationInsightsIdSelector")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderApplicationInsightsIdSelector? ApplicationInsightsIdSelector { get; set; }

    /// <summary>Purpose/user defined descriptive test for this WebTest.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the WebTest be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Interval in seconds between test runs for this WebTest. Valid options are 300, 600 and 900. Defaults to 300.</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies a list of where to physically run the tests from to give global coverage for accessibility of your application.</summary>
    [JsonPropertyName("geoLocations")]
    public IList<string>? GeoLocations { get; set; }

    /// <summary>The Azure Region where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created. It needs to correlate with location of the parent resource (azurerm_application_insights)</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderRequest? Request { get; set; }

    /// <summary>Should the retry on WebTest failure be enabled?</summary>
    [JsonPropertyName("retryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Seconds until this WebTest will timeout and fail. Default is 30.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>A validation_rules block as defined below.</summary>
    [JsonPropertyName("validationRules")]
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProviderValidationRules? ValidationRules { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecManagementPoliciesEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ApplicationInsightsStandardWebTestSpec defines the desired state of ApplicationInsightsStandardWebTest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestSpec
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
    public V1beta2ApplicationInsightsStandardWebTestSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ApplicationInsightsStandardWebTestSpecForProvider ForProvider { get; set; }

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
    public V1beta2ApplicationInsightsStandardWebTestSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ApplicationInsightsStandardWebTestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ApplicationInsightsStandardWebTestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ApplicationInsightsStandardWebTestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestStatusAtProviderRequestHeader
{
    /// <summary>The name which should be used for this Application Insights Standard WebTest. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value which should be used for a header in the request.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A request block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestStatusAtProviderRequest
{
    /// <summary>The WebTest request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Should the following of redirects be enabled? Defaults to true.</summary>
    [JsonPropertyName("followRedirectsEnabled")]
    public bool? FollowRedirectsEnabled { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ApplicationInsightsStandardWebTestStatusAtProviderRequestHeader>? Header { get; set; }

    /// <summary>Which HTTP verb to use for the call. Options are &apos;GET&apos;, &apos;POST&apos;, &apos;PUT&apos;, &apos;PATCH&apos;, &apos;DELETE&apos;, &apos;HEAD&apos;, and &apos;OPTIONS&apos;. Defaults to GET.</summary>
    [JsonPropertyName("httpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>Should the parsing of dependend requests be enabled? Defaults to true.</summary>
    [JsonPropertyName("parseDependentRequestsEnabled")]
    public bool? ParseDependentRequestsEnabled { get; set; }

    /// <summary>The WebTest request URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A content block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestStatusAtProviderValidationRulesContent
{
    /// <summary>A string value containing the content to match on.</summary>
    [JsonPropertyName("contentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>Ignore the casing in the content_match value.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>If the content of content_match is found, pass the test. If set to false, the WebTest is failing if the content of content_match is found.</summary>
    [JsonPropertyName("passIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary>A validation_rules block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestStatusAtProviderValidationRules
{
    /// <summary>A content block as defined above.</summary>
    [JsonPropertyName("content")]
    public V1beta2ApplicationInsightsStandardWebTestStatusAtProviderValidationRulesContent? Content { get; set; }

    /// <summary>The expected status code of the response. Default is &apos;200&apos;, &apos;0&apos; means &apos;response code &lt; 400&apos;</summary>
    [JsonPropertyName("expectedStatusCode")]
    public double? ExpectedStatusCode { get; set; }

    /// <summary>The number of days of SSL certificate validity remaining for the checked endpoint. If the certificate has a shorter remaining lifetime left, the test will fail. This number should be between 1 and 365.</summary>
    [JsonPropertyName("sslCertRemainingLifetime")]
    public double? SslCertRemainingLifetime { get; set; }

    /// <summary>Should the SSL check be enabled?</summary>
    [JsonPropertyName("sslCheckEnabled")]
    public bool? SslCheckEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestStatusAtProvider
{
    /// <summary>The ID of the Application Insights instance on which the WebTest operates. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("applicationInsightsId")]
    public string? ApplicationInsightsId { get; set; }

    /// <summary>Purpose/user defined descriptive test for this WebTest.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the WebTest be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Interval in seconds between test runs for this WebTest. Valid options are 300, 600 and 900. Defaults to 300.</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies a list of where to physically run the tests from to give global coverage for accessibility of your application.</summary>
    [JsonPropertyName("geoLocations")]
    public IList<string>? GeoLocations { get; set; }

    /// <summary>The ID of the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created. It needs to correlate with location of the parent resource (azurerm_application_insights)</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public V1beta2ApplicationInsightsStandardWebTestStatusAtProviderRequest? Request { get; set; }

    /// <summary>The name of the Resource Group where the Application Insights Standard WebTest should exist. Changing this forces a new Application Insights Standard WebTest to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Should the retry on WebTest failure be enabled?</summary>
    [JsonPropertyName("retryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>Unique ID of this WebTest. This is typically the same value as the Name field.</summary>
    [JsonPropertyName("syntheticMonitorId")]
    public string? SyntheticMonitorId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Application Insights Standard WebTest.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Seconds until this WebTest will timeout and fail. Default is 30.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>A validation_rules block as defined below.</summary>
    [JsonPropertyName("validationRules")]
    public V1beta2ApplicationInsightsStandardWebTestStatusAtProviderValidationRules? ValidationRules { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestStatusConditions
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

/// <summary>ApplicationInsightsStandardWebTestStatus defines the observed state of ApplicationInsightsStandardWebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationInsightsStandardWebTestStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ApplicationInsightsStandardWebTestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ApplicationInsightsStandardWebTestStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ApplicationInsightsStandardWebTest is the Schema for the ApplicationInsightsStandardWebTests API. Manages a Application Insights Standard WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ApplicationInsightsStandardWebTest : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ApplicationInsightsStandardWebTestSpec>, IStatus<V1beta2ApplicationInsightsStandardWebTestStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ApplicationInsightsStandardWebTest";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "applicationinsightsstandardwebtests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationInsightsStandardWebTest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationInsightsStandardWebTestSpec defines the desired state of ApplicationInsightsStandardWebTest</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ApplicationInsightsStandardWebTestSpec Spec { get; set; }

    /// <summary>ApplicationInsightsStandardWebTestStatus defines the observed state of ApplicationInsightsStandardWebTest.</summary>
    [JsonPropertyName("status")]
    public V1beta2ApplicationInsightsStandardWebTestStatus? Status { get; set; }
}