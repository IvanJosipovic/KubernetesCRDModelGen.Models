#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vpclattice.aws.m.upbound.io;
/// <summary>ListenerRule is the Schema for the ListenerRules API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ListenerRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ListenerRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ListenerRuleList";
    public const string KubeGroup = "vpclattice.aws.m.upbound.io";
    public const string KubePluralName = "listenerrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vpclattice.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ListenerRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ListenerRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ListenerRule> Items { get; set; }
}

/// <summary>
/// Describes the rule action that returns a custom HTTP response.
/// See fixed_response Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderActionFixedResponse
{
    /// <summary>The HTTP response code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderActionForwardTargetGroups
{
    [JsonPropertyName("targetGroupIdentifier")]
    public string? TargetGroupIdentifier { get; set; }

    /// <summary>Reference to a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
    [JsonPropertyName("targetGroupIdentifierRef")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierRef? TargetGroupIdentifierRef { get; set; }

    /// <summary>Selector for a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
    [JsonPropertyName("targetGroupIdentifierSelector")]
    public V1beta1ListenerRuleSpecForProviderActionForwardTargetGroupsTargetGroupIdentifierSelector? TargetGroupIdentifierSelector { get; set; }

    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// The forward action. Traffic that matches the rule is forwarded to the specified target groups.
/// See forward Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderActionForward
{
    /// <summary>The target groups. Traffic matching the rule is forwarded to the specified target groups. With forward actions, you can assign a weight that controls the prioritization and selection of each target group. This means that requests are distributed to individual target groups based on their weights. For example, if two target groups have the same weight, each target group receives half of the traffic.</summary>
    [JsonPropertyName("targetGroups")]
    public IList<V1beta1ListenerRuleSpecForProviderActionForwardTargetGroups>? TargetGroups { get; set; }
}

/// <summary>
/// The action for the listener rule.
/// See action Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderAction
{
    /// <summary>
    /// Describes the rule action that returns a custom HTTP response.
    /// See fixed_response Block for details.
    /// </summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta1ListenerRuleSpecForProviderActionFixedResponse? FixedResponse { get; set; }

    /// <summary>
    /// The forward action. Traffic that matches the rule is forwarded to the specified target groups.
    /// See forward Block for details.
    /// </summary>
    [JsonPropertyName("forward")]
    public V1beta1ListenerRuleSpecForProviderActionForward? Forward { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Listener in vpclattice to populate listenerIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderListenerIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Listener in vpclattice to populate listenerIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderListenerIdentifierSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The header match type.
/// See Header Match  for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderMatchHttpMatchHeaderMatchesMatch
{
    /// <summary>Specifies a contains type match.</summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>Specifies an exact type match.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>
    /// Specifies a prefix type match.
    /// Matches the value with the prefix.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderMatchHttpMatchHeaderMatches
{
    /// <summary>
    /// Indicates whether the match is case sensitive.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>
    /// The header match type.
    /// See Header Match  for details.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleSpecForProviderMatchHttpMatchHeaderMatchesMatch? Match { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The header match type.
/// See Path Match  for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderMatchHttpMatchPathMatchMatch
{
    /// <summary>Specifies an exact type match.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>
    /// Specifies a prefix type match.
    /// Matches the value with the prefix.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>
/// The path match.
/// See path_match Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderMatchHttpMatchPathMatch
{
    /// <summary>
    /// Indicates whether the match is case sensitive.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>
    /// The header match type.
    /// See Path Match  for details.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleSpecForProviderMatchHttpMatchPathMatchMatch? Match { get; set; }
}

/// <summary>
/// The HTTP criteria that a rule must match.
/// See http_match Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderMatchHttpMatch
{
    /// <summary>
    /// The header matches.
    /// Matches incoming requests with rule based on request header value before applying rule action.
    /// See header_matches Block for details.
    /// </summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1ListenerRuleSpecForProviderMatchHttpMatchHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>The HTTP method type.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// The path match.
    /// See path_match Block for details.
    /// </summary>
    [JsonPropertyName("pathMatch")]
    public V1beta1ListenerRuleSpecForProviderMatchHttpMatchPathMatch? PathMatch { get; set; }
}

/// <summary>
/// The rule match.
/// See match Block
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderMatch
{
    /// <summary>
    /// The HTTP criteria that a rule must match.
    /// See http_match Block for details.
    /// </summary>
    [JsonPropertyName("httpMatch")]
    public V1beta1ListenerRuleSpecForProviderMatchHttpMatch? HttpMatch { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in vpclattice to populate serviceIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderServiceIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in vpclattice to populate serviceIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProviderServiceIdentifierSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecForProvider
{
    /// <summary>
    /// The action for the listener rule.
    /// See action Block for details.
    /// </summary>
    [JsonPropertyName("action")]
    public V1beta1ListenerRuleSpecForProviderAction? Action { get; set; }

    /// <summary>The ID or Amazon Resource Name (ARN) of the listener.</summary>
    [JsonPropertyName("listenerIdentifier")]
    public string? ListenerIdentifier { get; set; }

    /// <summary>Reference to a Listener in vpclattice to populate listenerIdentifier.</summary>
    [JsonPropertyName("listenerIdentifierRef")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierRef? ListenerIdentifierRef { get; set; }

    /// <summary>Selector for a Listener in vpclattice to populate listenerIdentifier.</summary>
    [JsonPropertyName("listenerIdentifierSelector")]
    public V1beta1ListenerRuleSpecForProviderListenerIdentifierSelector? ListenerIdentifierSelector { get; set; }

    /// <summary>
    /// The rule match.
    /// See match Block
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleSpecForProviderMatch? Match { get; set; }

    /// <summary>The name of the rule. The name must be unique within the listener. The valid characters are a-z, 0-9, and hyphens (-). You can&apos;t use a hyphen as the first or last character, or immediately after another hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority assigned to the rule. Each rule for a specific listener must have a unique priority. The lower the priority number the higher the priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The ID or Amazon Resource Identifier (ARN) of the service.</summary>
    [JsonPropertyName("serviceIdentifier")]
    public string? ServiceIdentifier { get; set; }

    /// <summary>Reference to a Service in vpclattice to populate serviceIdentifier.</summary>
    [JsonPropertyName("serviceIdentifierRef")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierRef? ServiceIdentifierRef { get; set; }

    /// <summary>Selector for a Service in vpclattice to populate serviceIdentifier.</summary>
    [JsonPropertyName("serviceIdentifierSelector")]
    public V1beta1ListenerRuleSpecForProviderServiceIdentifierSelector? ServiceIdentifierSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Describes the rule action that returns a custom HTTP response.
/// See fixed_response Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderActionFixedResponse
{
    /// <summary>The HTTP response code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroups
{
    [JsonPropertyName("targetGroupIdentifier")]
    public string? TargetGroupIdentifier { get; set; }

    /// <summary>Reference to a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
    [JsonPropertyName("targetGroupIdentifierRef")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierRef? TargetGroupIdentifierRef { get; set; }

    /// <summary>Selector for a TargetGroup in vpclattice to populate targetGroupIdentifier.</summary>
    [JsonPropertyName("targetGroupIdentifierSelector")]
    public V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroupsTargetGroupIdentifierSelector? TargetGroupIdentifierSelector { get; set; }

    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// The forward action. Traffic that matches the rule is forwarded to the specified target groups.
/// See forward Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderActionForward
{
    /// <summary>The target groups. Traffic matching the rule is forwarded to the specified target groups. With forward actions, you can assign a weight that controls the prioritization and selection of each target group. This means that requests are distributed to individual target groups based on their weights. For example, if two target groups have the same weight, each target group receives half of the traffic.</summary>
    [JsonPropertyName("targetGroups")]
    public IList<V1beta1ListenerRuleSpecInitProviderActionForwardTargetGroups>? TargetGroups { get; set; }
}

/// <summary>
/// The action for the listener rule.
/// See action Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderAction
{
    /// <summary>
    /// Describes the rule action that returns a custom HTTP response.
    /// See fixed_response Block for details.
    /// </summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta1ListenerRuleSpecInitProviderActionFixedResponse? FixedResponse { get; set; }

    /// <summary>
    /// The forward action. Traffic that matches the rule is forwarded to the specified target groups.
    /// See forward Block for details.
    /// </summary>
    [JsonPropertyName("forward")]
    public V1beta1ListenerRuleSpecInitProviderActionForward? Forward { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Listener in vpclattice to populate listenerIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderListenerIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Listener in vpclattice to populate listenerIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The header match type.
/// See Header Match  for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderMatchHttpMatchHeaderMatchesMatch
{
    /// <summary>Specifies a contains type match.</summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>Specifies an exact type match.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>
    /// Specifies a prefix type match.
    /// Matches the value with the prefix.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderMatchHttpMatchHeaderMatches
{
    /// <summary>
    /// Indicates whether the match is case sensitive.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>
    /// The header match type.
    /// See Header Match  for details.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleSpecInitProviderMatchHttpMatchHeaderMatchesMatch? Match { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The header match type.
/// See Path Match  for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderMatchHttpMatchPathMatchMatch
{
    /// <summary>Specifies an exact type match.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>
    /// Specifies a prefix type match.
    /// Matches the value with the prefix.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>
/// The path match.
/// See path_match Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderMatchHttpMatchPathMatch
{
    /// <summary>
    /// Indicates whether the match is case sensitive.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>
    /// The header match type.
    /// See Path Match  for details.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleSpecInitProviderMatchHttpMatchPathMatchMatch? Match { get; set; }
}

/// <summary>
/// The HTTP criteria that a rule must match.
/// See http_match Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderMatchHttpMatch
{
    /// <summary>
    /// The header matches.
    /// Matches incoming requests with rule based on request header value before applying rule action.
    /// See header_matches Block for details.
    /// </summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1ListenerRuleSpecInitProviderMatchHttpMatchHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>The HTTP method type.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// The path match.
    /// See path_match Block for details.
    /// </summary>
    [JsonPropertyName("pathMatch")]
    public V1beta1ListenerRuleSpecInitProviderMatchHttpMatchPathMatch? PathMatch { get; set; }
}

/// <summary>
/// The rule match.
/// See match Block
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderMatch
{
    /// <summary>
    /// The HTTP criteria that a rule must match.
    /// See http_match Block for details.
    /// </summary>
    [JsonPropertyName("httpMatch")]
    public V1beta1ListenerRuleSpecInitProviderMatchHttpMatch? HttpMatch { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in vpclattice to populate serviceIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderServiceIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in vpclattice to populate serviceIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1ListenerRuleSpecInitProvider
{
    /// <summary>
    /// The action for the listener rule.
    /// See action Block for details.
    /// </summary>
    [JsonPropertyName("action")]
    public V1beta1ListenerRuleSpecInitProviderAction? Action { get; set; }

    /// <summary>The ID or Amazon Resource Name (ARN) of the listener.</summary>
    [JsonPropertyName("listenerIdentifier")]
    public string? ListenerIdentifier { get; set; }

    /// <summary>Reference to a Listener in vpclattice to populate listenerIdentifier.</summary>
    [JsonPropertyName("listenerIdentifierRef")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierRef? ListenerIdentifierRef { get; set; }

    /// <summary>Selector for a Listener in vpclattice to populate listenerIdentifier.</summary>
    [JsonPropertyName("listenerIdentifierSelector")]
    public V1beta1ListenerRuleSpecInitProviderListenerIdentifierSelector? ListenerIdentifierSelector { get; set; }

    /// <summary>
    /// The rule match.
    /// See match Block
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleSpecInitProviderMatch? Match { get; set; }

    /// <summary>The name of the rule. The name must be unique within the listener. The valid characters are a-z, 0-9, and hyphens (-). You can&apos;t use a hyphen as the first or last character, or immediately after another hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority assigned to the rule. Each rule for a specific listener must have a unique priority. The lower the priority number the higher the priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID or Amazon Resource Identifier (ARN) of the service.</summary>
    [JsonPropertyName("serviceIdentifier")]
    public string? ServiceIdentifier { get; set; }

    /// <summary>Reference to a Service in vpclattice to populate serviceIdentifier.</summary>
    [JsonPropertyName("serviceIdentifierRef")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierRef? ServiceIdentifierRef { get; set; }

    /// <summary>Selector for a Service in vpclattice to populate serviceIdentifier.</summary>
    [JsonPropertyName("serviceIdentifierSelector")]
    public V1beta1ListenerRuleSpecInitProviderServiceIdentifierSelector? ServiceIdentifierSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ListenerRuleSpecManagementPoliciesEnum>))]
public enum V1beta1ListenerRuleSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ListenerRuleSpec defines the desired state of ListenerRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ListenerRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta1ListenerRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ListenerRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ListenerRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ListenerRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Describes the rule action that returns a custom HTTP response.
/// See fixed_response Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderActionFixedResponse
{
    /// <summary>The HTTP response code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderActionForwardTargetGroups
{
    [JsonPropertyName("targetGroupIdentifier")]
    public string? TargetGroupIdentifier { get; set; }

    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// The forward action. Traffic that matches the rule is forwarded to the specified target groups.
/// See forward Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderActionForward
{
    /// <summary>The target groups. Traffic matching the rule is forwarded to the specified target groups. With forward actions, you can assign a weight that controls the prioritization and selection of each target group. This means that requests are distributed to individual target groups based on their weights. For example, if two target groups have the same weight, each target group receives half of the traffic.</summary>
    [JsonPropertyName("targetGroups")]
    public IList<V1beta1ListenerRuleStatusAtProviderActionForwardTargetGroups>? TargetGroups { get; set; }
}

/// <summary>
/// The action for the listener rule.
/// See action Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderAction
{
    /// <summary>
    /// Describes the rule action that returns a custom HTTP response.
    /// See fixed_response Block for details.
    /// </summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta1ListenerRuleStatusAtProviderActionFixedResponse? FixedResponse { get; set; }

    /// <summary>
    /// The forward action. Traffic that matches the rule is forwarded to the specified target groups.
    /// See forward Block for details.
    /// </summary>
    [JsonPropertyName("forward")]
    public V1beta1ListenerRuleStatusAtProviderActionForward? Forward { get; set; }
}

/// <summary>
/// The header match type.
/// See Header Match  for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderMatchHttpMatchHeaderMatchesMatch
{
    /// <summary>Specifies a contains type match.</summary>
    [JsonPropertyName("contains")]
    public string? Contains { get; set; }

    /// <summary>Specifies an exact type match.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>
    /// Specifies a prefix type match.
    /// Matches the value with the prefix.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderMatchHttpMatchHeaderMatches
{
    /// <summary>
    /// Indicates whether the match is case sensitive.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>
    /// The header match type.
    /// See Header Match  for details.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleStatusAtProviderMatchHttpMatchHeaderMatchesMatch? Match { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The header match type.
/// See Path Match  for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderMatchHttpMatchPathMatchMatch
{
    /// <summary>Specifies an exact type match.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>
    /// Specifies a prefix type match.
    /// Matches the value with the prefix.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>
/// The path match.
/// See path_match Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderMatchHttpMatchPathMatch
{
    /// <summary>
    /// Indicates whether the match is case sensitive.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>
    /// The header match type.
    /// See Path Match  for details.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleStatusAtProviderMatchHttpMatchPathMatchMatch? Match { get; set; }
}

/// <summary>
/// The HTTP criteria that a rule must match.
/// See http_match Block for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderMatchHttpMatch
{
    /// <summary>
    /// The header matches.
    /// Matches incoming requests with rule based on request header value before applying rule action.
    /// See header_matches Block for details.
    /// </summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta1ListenerRuleStatusAtProviderMatchHttpMatchHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>The HTTP method type.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// The path match.
    /// See path_match Block for details.
    /// </summary>
    [JsonPropertyName("pathMatch")]
    public V1beta1ListenerRuleStatusAtProviderMatchHttpMatchPathMatch? PathMatch { get; set; }
}

/// <summary>
/// The rule match.
/// See match Block
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProviderMatch
{
    /// <summary>
    /// The HTTP criteria that a rule must match.
    /// See http_match Block for details.
    /// </summary>
    [JsonPropertyName("httpMatch")]
    public V1beta1ListenerRuleStatusAtProviderMatchHttpMatch? HttpMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusAtProvider
{
    /// <summary>
    /// The action for the listener rule.
    /// See action Block for details.
    /// </summary>
    [JsonPropertyName("action")]
    public V1beta1ListenerRuleStatusAtProviderAction? Action { get; set; }

    /// <summary>The ARN for the listener rule.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID or Amazon Resource Name (ARN) of the listener.</summary>
    [JsonPropertyName("listenerIdentifier")]
    public string? ListenerIdentifier { get; set; }

    /// <summary>
    /// The rule match.
    /// See match Block
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1ListenerRuleStatusAtProviderMatch? Match { get; set; }

    /// <summary>The name of the rule. The name must be unique within the listener. The valid characters are a-z, 0-9, and hyphens (-). You can&apos;t use a hyphen as the first or last character, or immediately after another hyphen.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority assigned to the rule. Each rule for a specific listener must have a unique priority. The lower the priority number the higher the priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Unique identifier for the listener rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>The ID or Amazon Resource Identifier (ARN) of the service.</summary>
    [JsonPropertyName("serviceIdentifier")]
    public string? ServiceIdentifier { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatusConditions
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

/// <summary>ListenerRuleStatus defines the observed state of ListenerRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ListenerRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ListenerRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ListenerRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ListenerRule is the Schema for the ListenerRules API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ListenerRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ListenerRuleSpec>, IStatus<V1beta1ListenerRuleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ListenerRule";
    public const string KubeGroup = "vpclattice.aws.m.upbound.io";
    public const string KubePluralName = "listenerrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vpclattice.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ListenerRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ListenerRuleSpec defines the desired state of ListenerRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ListenerRuleSpec Spec { get; set; }

    /// <summary>ListenerRuleStatus defines the observed state of ListenerRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1ListenerRuleStatus? Status { get; set; }
}