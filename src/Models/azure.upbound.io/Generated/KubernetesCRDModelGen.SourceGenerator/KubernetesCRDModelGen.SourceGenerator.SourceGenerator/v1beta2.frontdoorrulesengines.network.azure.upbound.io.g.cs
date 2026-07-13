#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>FrontdoorRulesEngine is the Schema for the FrontdoorRulesEngines API. Manages an Azure Front Door (classic) Rules Engine configuration and rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorRulesEngineList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FrontdoorRulesEngine>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorRulesEngineList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "frontdoorrulesengines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorRulesEngineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FrontdoorRulesEngine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FrontdoorRulesEngine> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecDeletionPolicyEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontDoor in network to populate frontdoorName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontDoor in network to populate frontdoorName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelector
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
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelector
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
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderRuleActionRequestHeader
{
    /// <summary>can be set to Overwrite, Append or Delete.</summary>
    [JsonPropertyName("headerActionType")]
    public string? HeaderActionType { get; set; }

    /// <summary>header name (string).</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderRuleActionResponseHeader
{
    /// <summary>can be set to Overwrite, Append or Delete.</summary>
    [JsonPropertyName("headerActionType")]
    public string? HeaderActionType { get; set; }

    /// <summary>header name (string).</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderRuleAction
{
    /// <summary>A request_header block as defined below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta2FrontdoorRulesEngineSpecForProviderRuleActionRequestHeader>? RequestHeader { get; set; }

    /// <summary>A response_header block as defined below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta2FrontdoorRulesEngineSpecForProviderRuleActionResponseHeader>? ResponseHeader { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderRuleMatchCondition
{
    /// <summary>can be set to true or false to negate the given condition. Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>can be set to Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith or EndsWith</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>match against a specific key when variable is set to PostArgs or RequestHeader. It cannot be used with QueryString and RequestMethod.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>can be set to one or more values out of Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode</summary>
    [JsonPropertyName("transform")]
    public IList<string>? Transform { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }

    /// <summary>can be set to IsMobile, RemoteAddr, RequestMethod, QueryString, PostArgs, RequestURI, RequestPath, RequestFilename, RequestFilenameExtension,RequestHeader,RequestBody or RequestScheme.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProviderRule
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta2FrontdoorRulesEngineSpecForProviderRuleAction? Action { get; set; }

    /// <summary>One or more match_condition block as defined below.</summary>
    [JsonPropertyName("matchCondition")]
    public IList<V1beta2FrontdoorRulesEngineSpecForProviderRuleMatchCondition>? MatchCondition { get; set; }

    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority of the rule, must be unique per rules engine definition.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecForProvider
{
    /// <summary>Whether this Rules engine configuration is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Front Door instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontdoorName")]
    public string? FrontdoorName { get; set; }

    /// <summary>Reference to a FrontDoor in network to populate frontdoorName.</summary>
    [JsonPropertyName("frontdoorNameRef")]
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameRef? FrontdoorNameRef { get; set; }

    /// <summary>Selector for a FrontDoor in network to populate frontdoorName.</summary>
    [JsonPropertyName("frontdoorNameSelector")]
    public V1beta2FrontdoorRulesEngineSpecForProviderFrontdoorNameSelector? FrontdoorNameSelector { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2FrontdoorRulesEngineSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2FrontdoorRulesEngineSpecForProviderRule>? Rule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecInitProviderRuleActionRequestHeader
{
    /// <summary>can be set to Overwrite, Append or Delete.</summary>
    [JsonPropertyName("headerActionType")]
    public string? HeaderActionType { get; set; }

    /// <summary>header name (string).</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecInitProviderRuleActionResponseHeader
{
    /// <summary>can be set to Overwrite, Append or Delete.</summary>
    [JsonPropertyName("headerActionType")]
    public string? HeaderActionType { get; set; }

    /// <summary>header name (string).</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecInitProviderRuleAction
{
    /// <summary>A request_header block as defined below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta2FrontdoorRulesEngineSpecInitProviderRuleActionRequestHeader>? RequestHeader { get; set; }

    /// <summary>A response_header block as defined below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta2FrontdoorRulesEngineSpecInitProviderRuleActionResponseHeader>? ResponseHeader { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecInitProviderRuleMatchCondition
{
    /// <summary>can be set to true or false to negate the given condition. Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>can be set to Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith or EndsWith</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>match against a specific key when variable is set to PostArgs or RequestHeader. It cannot be used with QueryString and RequestMethod.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>can be set to one or more values out of Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode</summary>
    [JsonPropertyName("transform")]
    public IList<string>? Transform { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }

    /// <summary>can be set to IsMobile, RemoteAddr, RequestMethod, QueryString, PostArgs, RequestURI, RequestPath, RequestFilename, RequestFilenameExtension,RequestHeader,RequestBody or RequestScheme.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecInitProviderRule
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta2FrontdoorRulesEngineSpecInitProviderRuleAction? Action { get; set; }

    /// <summary>One or more match_condition block as defined below.</summary>
    [JsonPropertyName("matchCondition")]
    public IList<V1beta2FrontdoorRulesEngineSpecInitProviderRuleMatchCondition>? MatchCondition { get; set; }

    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority of the rule, must be unique per rules engine definition.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
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
public partial class V1beta2FrontdoorRulesEngineSpecInitProvider
{
    /// <summary>Whether this Rules engine configuration is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2FrontdoorRulesEngineSpecInitProviderRule>? Rule { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecManagementPoliciesEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorRulesEngineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FrontdoorRulesEngineSpec defines the desired state of FrontdoorRulesEngine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineSpec
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
    public V1beta2FrontdoorRulesEngineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FrontdoorRulesEngineSpecForProvider ForProvider { get; set; }

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
    public V1beta2FrontdoorRulesEngineSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FrontdoorRulesEngineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FrontdoorRulesEngineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FrontdoorRulesEngineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatusAtProviderRuleActionRequestHeader
{
    /// <summary>can be set to Overwrite, Append or Delete.</summary>
    [JsonPropertyName("headerActionType")]
    public string? HeaderActionType { get; set; }

    /// <summary>header name (string).</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatusAtProviderRuleActionResponseHeader
{
    /// <summary>can be set to Overwrite, Append or Delete.</summary>
    [JsonPropertyName("headerActionType")]
    public string? HeaderActionType { get; set; }

    /// <summary>header name (string).</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatusAtProviderRuleAction
{
    /// <summary>A request_header block as defined below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta2FrontdoorRulesEngineStatusAtProviderRuleActionRequestHeader>? RequestHeader { get; set; }

    /// <summary>A response_header block as defined below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta2FrontdoorRulesEngineStatusAtProviderRuleActionResponseHeader>? ResponseHeader { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatusAtProviderRuleMatchCondition
{
    /// <summary>can be set to true or false to negate the given condition. Defaults to false.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>can be set to Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith or EndsWith</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>match against a specific key when variable is set to PostArgs or RequestHeader. It cannot be used with QueryString and RequestMethod.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>can be set to one or more values out of Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode</summary>
    [JsonPropertyName("transform")]
    public IList<string>? Transform { get; set; }

    /// <summary>value name (string).</summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }

    /// <summary>can be set to IsMobile, RemoteAddr, RequestMethod, QueryString, PostArgs, RequestURI, RequestPath, RequestFilename, RequestFilenameExtension,RequestHeader,RequestBody or RequestScheme.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatusAtProviderRule
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta2FrontdoorRulesEngineStatusAtProviderRuleAction? Action { get; set; }

    /// <summary>One or more match_condition block as defined below.</summary>
    [JsonPropertyName("matchCondition")]
    public IList<V1beta2FrontdoorRulesEngineStatusAtProviderRuleMatchCondition>? MatchCondition { get; set; }

    /// <summary>The name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority of the rule, must be unique per rules engine definition.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatusAtProvider
{
    /// <summary>Whether this Rules engine configuration is enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Front Door instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontdoorName")]
    public string? FrontdoorName { get; set; }

    /// <summary>The ID of the Front Door Rules Engine.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location in which the Front Door Rules Engine exists.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A rule block as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2FrontdoorRulesEngineStatusAtProviderRule>? Rule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatusConditions
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

/// <summary>FrontdoorRulesEngineStatus defines the observed state of FrontdoorRulesEngine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorRulesEngineStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FrontdoorRulesEngineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FrontdoorRulesEngineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorRulesEngine is the Schema for the FrontdoorRulesEngines API. Manages an Azure Front Door (classic) Rules Engine configuration and rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorRulesEngine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FrontdoorRulesEngineSpec>, IStatus<V1beta2FrontdoorRulesEngineStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorRulesEngine";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "frontdoorrulesengines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorRulesEngine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorRulesEngineSpec defines the desired state of FrontdoorRulesEngine</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FrontdoorRulesEngineSpec Spec { get; set; }

    /// <summary>FrontdoorRulesEngineStatus defines the observed state of FrontdoorRulesEngine.</summary>
    [JsonPropertyName("status")]
    public V1beta2FrontdoorRulesEngineStatus? Status { get; set; }
}