#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagentcore.aws.upbound.io;
/// <summary>GatewayRule is the Schema for the GatewayRules API. Manages an AWS Bedrock AgentCore Gateway Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GatewayRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayRuleList";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "gatewayrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1GatewayRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1GatewayRule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecDeletionPolicyEnum>))]
public enum V1beta1GatewayRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Statically override the configuration bundle used for the matched request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionConfigurationBundleStaticOverride
{
    /// <summary>ARN of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleArn")]
    public string? BundleArn { get; set; }

    /// <summary>Version (UUID) of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleVersion")]
    public string? BundleVersion { get; set; }
}

/// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionConfigurationBundleWeightedOverrideTrafficSplitConfigurationBundle
{
    /// <summary>ARN of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleArn")]
    public string? BundleArn { get; set; }

    /// <summary>Version (UUID) of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleVersion")]
    public string? BundleVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionConfigurationBundleWeightedOverrideTrafficSplit
{
    /// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
    [JsonPropertyName("configurationBundle")]
    public V1beta1GatewayRuleSpecForProviderActionConfigurationBundleWeightedOverrideTrafficSplitConfigurationBundle? ConfigurationBundle { get; set; }

    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Up to 25 key/value metadata pairs describing this variant.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name of this variant. Between 1 and 64 characters; alphanumeric with internal hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Percentage of traffic sent to this variant, between 1 and 99. Weights across the two entries must sum to 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Distribute the request across two configuration bundle versions by weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionConfigurationBundleWeightedOverride
{
    /// <summary>Exactly two traffic_split blocks describing the two variants.</summary>
    [JsonPropertyName("trafficSplit")]
    public IList<V1beta1GatewayRuleSpecForProviderActionConfigurationBundleWeightedOverrideTrafficSplit>? TrafficSplit { get; set; }
}

/// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionConfigurationBundle
{
    /// <summary>Statically override the configuration bundle used for the matched request.</summary>
    [JsonPropertyName("staticOverride")]
    public V1beta1GatewayRuleSpecForProviderActionConfigurationBundleStaticOverride? StaticOverride { get; set; }

    /// <summary>Distribute the request across two configuration bundle versions by weight.</summary>
    [JsonPropertyName("weightedOverride")]
    public V1beta1GatewayRuleSpecForProviderActionConfigurationBundleWeightedOverride? WeightedOverride { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelector
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
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Route all matching requests to a single named gateway target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRoute
{
    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameRef")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameRef? TargetNameRef { get; set; }

    /// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameSelector")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRouteTargetNameSelector? TargetNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelector
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
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplit
{
    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Up to 25 key/value metadata pairs describing this variant.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name of this variant. Between 1 and 64 characters; alphanumeric with internal hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameRef")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRef? TargetNameRef { get; set; }

    /// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameSelector")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelector? TargetNameSelector { get; set; }

    /// <summary>Percentage of traffic sent to this variant, between 1 and 99. Weights across the two entries must sum to 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Distribute requests across two named targets by weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRoute
{
    /// <summary>Exactly two traffic_split blocks describing the two variants.</summary>
    [JsonPropertyName("trafficSplit")]
    public IList<V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRouteTrafficSplit>? TrafficSplit { get; set; }
}

/// <summary>Route requests to a gateway target when the rule&apos;s conditions match. See route_to_target below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderActionRouteToTarget
{
    /// <summary>Route all matching requests to a single named gateway target.</summary>
    [JsonPropertyName("staticRoute")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetStaticRoute? StaticRoute { get; set; }

    /// <summary>Distribute requests across two named targets by weight.</summary>
    [JsonPropertyName("weightedRoute")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTargetWeightedRoute? WeightedRoute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderAction
{
    /// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
    [JsonPropertyName("configurationBundle")]
    public V1beta1GatewayRuleSpecForProviderActionConfigurationBundle? ConfigurationBundle { get; set; }

    /// <summary>Route requests to a gateway target when the rule&apos;s conditions match. See route_to_target below.</summary>
    [JsonPropertyName("routeToTarget")]
    public V1beta1GatewayRuleSpecForProviderActionRouteToTarget? RouteToTarget { get; set; }
}

/// <summary>Match when the request path matches any of the supplied glob patterns (e.g. /api/*).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderConditionMatchPaths
{
    /// <summary>Between 1 and 10 path patterns. A pattern must be of the form /&lt;segment&gt;/* and at most 512 characters.</summary>
    [JsonPropertyName("anyOf")]
    public IList<string>? AnyOf { get; set; }
}

/// <summary>Match an IAM user, role, or assumed-role ARN. Exactly one iam_principal block is required per entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderConditionMatchPrincipalsAnyOfIamPrincipal
{
    /// <summary>IAM principal ARN. Wildcards are allowed with the StringLike operator.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Match operator, one of StringEquals or StringLike. Defaults to StringEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderConditionMatchPrincipalsAnyOf
{
    /// <summary>Match an IAM user, role, or assumed-role ARN. Exactly one iam_principal block is required per entry.</summary>
    [JsonPropertyName("iamPrincipal")]
    public V1beta1GatewayRuleSpecForProviderConditionMatchPrincipalsAnyOfIamPrincipal? IamPrincipal { get; set; }
}

/// <summary>Match when the caller&apos;s IAM identity matches any of the supplied principal entries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderConditionMatchPrincipals
{
    /// <summary>Between 1 and 100 principal entry blocks.</summary>
    [JsonPropertyName("anyOf")]
    public IList<V1beta1GatewayRuleSpecForProviderConditionMatchPrincipalsAnyOf>? AnyOf { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderCondition
{
    /// <summary>Match when the request path matches any of the supplied glob patterns (e.g. /api/*).</summary>
    [JsonPropertyName("matchPaths")]
    public V1beta1GatewayRuleSpecForProviderConditionMatchPaths? MatchPaths { get; set; }

    /// <summary>Match when the caller&apos;s IAM identity matches any of the supplied principal entries.</summary>
    [JsonPropertyName("matchPrincipals")]
    public V1beta1GatewayRuleSpecForProviderConditionMatchPrincipals? MatchPrincipals { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderGatewayIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelector
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
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecForProvider
{
    /// <summary>One or two action blocks defining what happens when the rule&apos;s conditions match. See Action below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1GatewayRuleSpecForProviderAction>? Action { get; set; }

    /// <summary>Up to two condition blocks that must all be satisfied for the rule&apos;s actions to apply. See Condition below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1GatewayRuleSpecForProviderCondition>? Condition { get; set; }

    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Identifier of the gateway to attach the rule to.</summary>
    [JsonPropertyName("gatewayIdentifier")]
    public string? GatewayIdentifier { get; set; }

    /// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierRef")]
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierRef? GatewayIdentifierRef { get; set; }

    /// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierSelector")]
    public V1beta1GatewayRuleSpecForProviderGatewayIdentifierSelector? GatewayIdentifierSelector { get; set; }

    /// <summary>Priority of the rule, between 1 and 1000000. Rules are evaluated in ascending order of priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>Statically override the configuration bundle used for the matched request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleStaticOverride
{
    /// <summary>ARN of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleArn")]
    public string? BundleArn { get; set; }

    /// <summary>Version (UUID) of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleVersion")]
    public string? BundleVersion { get; set; }
}

/// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleWeightedOverrideTrafficSplitConfigurationBundle
{
    /// <summary>ARN of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleArn")]
    public string? BundleArn { get; set; }

    /// <summary>Version (UUID) of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleVersion")]
    public string? BundleVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleWeightedOverrideTrafficSplit
{
    /// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
    [JsonPropertyName("configurationBundle")]
    public V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleWeightedOverrideTrafficSplitConfigurationBundle? ConfigurationBundle { get; set; }

    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Up to 25 key/value metadata pairs describing this variant.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name of this variant. Between 1 and 64 characters; alphanumeric with internal hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Percentage of traffic sent to this variant, between 1 and 99. Weights across the two entries must sum to 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Distribute the request across two configuration bundle versions by weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleWeightedOverride
{
    /// <summary>Exactly two traffic_split blocks describing the two variants.</summary>
    [JsonPropertyName("trafficSplit")]
    public IList<V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleWeightedOverrideTrafficSplit>? TrafficSplit { get; set; }
}

/// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionConfigurationBundle
{
    /// <summary>Statically override the configuration bundle used for the matched request.</summary>
    [JsonPropertyName("staticOverride")]
    public V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleStaticOverride? StaticOverride { get; set; }

    /// <summary>Distribute the request across two configuration bundle versions by weight.</summary>
    [JsonPropertyName("weightedOverride")]
    public V1beta1GatewayRuleSpecInitProviderActionConfigurationBundleWeightedOverride? WeightedOverride { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelector
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
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Route all matching requests to a single named gateway target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRoute
{
    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameRef")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameRef? TargetNameRef { get; set; }

    /// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameSelector")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRouteTargetNameSelector? TargetNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelector
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
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplit
{
    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Up to 25 key/value metadata pairs describing this variant.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name of this variant. Between 1 and 64 characters; alphanumeric with internal hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>Reference to a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameRef")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameRef? TargetNameRef { get; set; }

    /// <summary>Selector for a GatewayTarget in bedrockagentcore to populate targetName.</summary>
    [JsonPropertyName("targetNameSelector")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplitTargetNameSelector? TargetNameSelector { get; set; }

    /// <summary>Percentage of traffic sent to this variant, between 1 and 99. Weights across the two entries must sum to 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Distribute requests across two named targets by weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRoute
{
    /// <summary>Exactly two traffic_split blocks describing the two variants.</summary>
    [JsonPropertyName("trafficSplit")]
    public IList<V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRouteTrafficSplit>? TrafficSplit { get; set; }
}

/// <summary>Route requests to a gateway target when the rule&apos;s conditions match. See route_to_target below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderActionRouteToTarget
{
    /// <summary>Route all matching requests to a single named gateway target.</summary>
    [JsonPropertyName("staticRoute")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetStaticRoute? StaticRoute { get; set; }

    /// <summary>Distribute requests across two named targets by weight.</summary>
    [JsonPropertyName("weightedRoute")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTargetWeightedRoute? WeightedRoute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderAction
{
    /// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
    [JsonPropertyName("configurationBundle")]
    public V1beta1GatewayRuleSpecInitProviderActionConfigurationBundle? ConfigurationBundle { get; set; }

    /// <summary>Route requests to a gateway target when the rule&apos;s conditions match. See route_to_target below.</summary>
    [JsonPropertyName("routeToTarget")]
    public V1beta1GatewayRuleSpecInitProviderActionRouteToTarget? RouteToTarget { get; set; }
}

/// <summary>Match when the request path matches any of the supplied glob patterns (e.g. /api/*).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderConditionMatchPaths
{
    /// <summary>Between 1 and 10 path patterns. A pattern must be of the form /&lt;segment&gt;/* and at most 512 characters.</summary>
    [JsonPropertyName("anyOf")]
    public IList<string>? AnyOf { get; set; }
}

/// <summary>Match an IAM user, role, or assumed-role ARN. Exactly one iam_principal block is required per entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderConditionMatchPrincipalsAnyOfIamPrincipal
{
    /// <summary>IAM principal ARN. Wildcards are allowed with the StringLike operator.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Match operator, one of StringEquals or StringLike. Defaults to StringEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderConditionMatchPrincipalsAnyOf
{
    /// <summary>Match an IAM user, role, or assumed-role ARN. Exactly one iam_principal block is required per entry.</summary>
    [JsonPropertyName("iamPrincipal")]
    public V1beta1GatewayRuleSpecInitProviderConditionMatchPrincipalsAnyOfIamPrincipal? IamPrincipal { get; set; }
}

/// <summary>Match when the caller&apos;s IAM identity matches any of the supplied principal entries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderConditionMatchPrincipals
{
    /// <summary>Between 1 and 100 principal entry blocks.</summary>
    [JsonPropertyName("anyOf")]
    public IList<V1beta1GatewayRuleSpecInitProviderConditionMatchPrincipalsAnyOf>? AnyOf { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderCondition
{
    /// <summary>Match when the request path matches any of the supplied glob patterns (e.g. /api/*).</summary>
    [JsonPropertyName("matchPaths")]
    public V1beta1GatewayRuleSpecInitProviderConditionMatchPaths? MatchPaths { get; set; }

    /// <summary>Match when the caller&apos;s IAM identity matches any of the supplied principal entries.</summary>
    [JsonPropertyName("matchPrincipals")]
    public V1beta1GatewayRuleSpecInitProviderConditionMatchPrincipals? MatchPrincipals { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelector
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
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1GatewayRuleSpecInitProvider
{
    /// <summary>One or two action blocks defining what happens when the rule&apos;s conditions match. See Action below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1GatewayRuleSpecInitProviderAction>? Action { get; set; }

    /// <summary>Up to two condition blocks that must all be satisfied for the rule&apos;s actions to apply. See Condition below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1GatewayRuleSpecInitProviderCondition>? Condition { get; set; }

    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Identifier of the gateway to attach the rule to.</summary>
    [JsonPropertyName("gatewayIdentifier")]
    public string? GatewayIdentifier { get; set; }

    /// <summary>Reference to a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierRef")]
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierRef? GatewayIdentifierRef { get; set; }

    /// <summary>Selector for a Gateway in bedrockagentcore to populate gatewayIdentifier.</summary>
    [JsonPropertyName("gatewayIdentifierSelector")]
    public V1beta1GatewayRuleSpecInitProviderGatewayIdentifierSelector? GatewayIdentifierSelector { get; set; }

    /// <summary>Priority of the rule, between 1 and 1000000. Rules are evaluated in ascending order of priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecManagementPoliciesEnum>))]
public enum V1beta1GatewayRuleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1GatewayRuleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1GatewayRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GatewayRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GatewayRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>GatewayRuleSpec defines the desired state of GatewayRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleSpec
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
    public V1beta1GatewayRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1GatewayRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta1GatewayRuleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1GatewayRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GatewayRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GatewayRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Statically override the configuration bundle used for the matched request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleStaticOverride
{
    /// <summary>ARN of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleArn")]
    public string? BundleArn { get; set; }

    /// <summary>Version (UUID) of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleVersion")]
    public string? BundleVersion { get; set; }
}

/// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleWeightedOverrideTrafficSplitConfigurationBundle
{
    /// <summary>ARN of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleArn")]
    public string? BundleArn { get; set; }

    /// <summary>Version (UUID) of the configuration bundle to apply.</summary>
    [JsonPropertyName("bundleVersion")]
    public string? BundleVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleWeightedOverrideTrafficSplit
{
    /// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
    [JsonPropertyName("configurationBundle")]
    public V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleWeightedOverrideTrafficSplitConfigurationBundle? ConfigurationBundle { get; set; }

    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Up to 25 key/value metadata pairs describing this variant.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name of this variant. Between 1 and 64 characters; alphanumeric with internal hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Percentage of traffic sent to this variant, between 1 and 99. Weights across the two entries must sum to 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Distribute the request across two configuration bundle versions by weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleWeightedOverride
{
    /// <summary>Exactly two traffic_split blocks describing the two variants.</summary>
    [JsonPropertyName("trafficSplit")]
    public IList<V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleWeightedOverrideTrafficSplit>? TrafficSplit { get; set; }
}

/// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionConfigurationBundle
{
    /// <summary>Statically override the configuration bundle used for the matched request.</summary>
    [JsonPropertyName("staticOverride")]
    public V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleStaticOverride? StaticOverride { get; set; }

    /// <summary>Distribute the request across two configuration bundle versions by weight.</summary>
    [JsonPropertyName("weightedOverride")]
    public V1beta1GatewayRuleStatusAtProviderActionConfigurationBundleWeightedOverride? WeightedOverride { get; set; }
}

/// <summary>Route all matching requests to a single named gateway target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionRouteToTargetStaticRoute
{
    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionRouteToTargetWeightedRouteTrafficSplit
{
    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Up to 25 key/value metadata pairs describing this variant.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Name of this variant. Between 1 and 64 characters; alphanumeric with internal hyphens.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Name of the gateway target.</summary>
    [JsonPropertyName("targetName")]
    public string? TargetName { get; set; }

    /// <summary>Percentage of traffic sent to this variant, between 1 and 99. Weights across the two entries must sum to 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Distribute requests across two named targets by weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionRouteToTargetWeightedRoute
{
    /// <summary>Exactly two traffic_split blocks describing the two variants.</summary>
    [JsonPropertyName("trafficSplit")]
    public IList<V1beta1GatewayRuleStatusAtProviderActionRouteToTargetWeightedRouteTrafficSplit>? TrafficSplit { get; set; }
}

/// <summary>Route requests to a gateway target when the rule&apos;s conditions match. See route_to_target below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderActionRouteToTarget
{
    /// <summary>Route all matching requests to a single named gateway target.</summary>
    [JsonPropertyName("staticRoute")]
    public V1beta1GatewayRuleStatusAtProviderActionRouteToTargetStaticRoute? StaticRoute { get; set; }

    /// <summary>Distribute requests across two named targets by weight.</summary>
    [JsonPropertyName("weightedRoute")]
    public V1beta1GatewayRuleStatusAtProviderActionRouteToTargetWeightedRoute? WeightedRoute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderAction
{
    /// <summary>Apply a configuration bundle when the rule&apos;s conditions match. See configuration_bundle below.</summary>
    [JsonPropertyName("configurationBundle")]
    public V1beta1GatewayRuleStatusAtProviderActionConfigurationBundle? ConfigurationBundle { get; set; }

    /// <summary>Route requests to a gateway target when the rule&apos;s conditions match. See route_to_target below.</summary>
    [JsonPropertyName("routeToTarget")]
    public V1beta1GatewayRuleStatusAtProviderActionRouteToTarget? RouteToTarget { get; set; }
}

/// <summary>Match when the request path matches any of the supplied glob patterns (e.g. /api/*).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderConditionMatchPaths
{
    /// <summary>Between 1 and 10 path patterns. A pattern must be of the form /&lt;segment&gt;/* and at most 512 characters.</summary>
    [JsonPropertyName("anyOf")]
    public IList<string>? AnyOf { get; set; }
}

/// <summary>Match an IAM user, role, or assumed-role ARN. Exactly one iam_principal block is required per entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderConditionMatchPrincipalsAnyOfIamPrincipal
{
    /// <summary>IAM principal ARN. Wildcards are allowed with the StringLike operator.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Match operator, one of StringEquals or StringLike. Defaults to StringEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderConditionMatchPrincipalsAnyOf
{
    /// <summary>Match an IAM user, role, or assumed-role ARN. Exactly one iam_principal block is required per entry.</summary>
    [JsonPropertyName("iamPrincipal")]
    public V1beta1GatewayRuleStatusAtProviderConditionMatchPrincipalsAnyOfIamPrincipal? IamPrincipal { get; set; }
}

/// <summary>Match when the caller&apos;s IAM identity matches any of the supplied principal entries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderConditionMatchPrincipals
{
    /// <summary>Between 1 and 100 principal entry blocks.</summary>
    [JsonPropertyName("anyOf")]
    public IList<V1beta1GatewayRuleStatusAtProviderConditionMatchPrincipalsAnyOf>? AnyOf { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderCondition
{
    /// <summary>Match when the request path matches any of the supplied glob patterns (e.g. /api/*).</summary>
    [JsonPropertyName("matchPaths")]
    public V1beta1GatewayRuleStatusAtProviderConditionMatchPaths? MatchPaths { get; set; }

    /// <summary>Match when the caller&apos;s IAM identity matches any of the supplied principal entries.</summary>
    [JsonPropertyName("matchPrincipals")]
    public V1beta1GatewayRuleStatusAtProviderConditionMatchPrincipals? MatchPrincipals { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProviderSystem
{
    /// <summary>Name of the system that manages the rule.</summary>
    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusAtProvider
{
    /// <summary>One or two action blocks defining what happens when the rule&apos;s conditions match. See Action below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1GatewayRuleStatusAtProviderAction>? Action { get; set; }

    /// <summary>Up to two condition blocks that must all be satisfied for the rule&apos;s actions to apply. See Condition below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1GatewayRuleStatusAtProviderCondition>? Condition { get; set; }

    /// <summary>Description of the rule. Between 1 and 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>ARN of the gateway that owns the rule.</summary>
    [JsonPropertyName("gatewayArn")]
    public string? GatewayArn { get; set; }

    /// <summary>Identifier of the gateway to attach the rule to.</summary>
    [JsonPropertyName("gatewayIdentifier")]
    public string? GatewayIdentifier { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Priority of the rule, between 1 and 1000000. Rules are evaluated in ascending order of priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Identifier of the rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Present when the rule is system-managed. See system Block below.</summary>
    [JsonPropertyName("system")]
    public IList<V1beta1GatewayRuleStatusAtProviderSystem>? System { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatusConditions
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

/// <summary>GatewayRuleStatus defines the observed state of GatewayRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1GatewayRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GatewayRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GatewayRule is the Schema for the GatewayRules API. Manages an AWS Bedrock AgentCore Gateway Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GatewayRuleSpec>, IStatus<V1beta1GatewayRuleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayRule";
    public const string KubeGroup = "bedrockagentcore.aws.upbound.io";
    public const string KubePluralName = "gatewayrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GatewayRuleSpec defines the desired state of GatewayRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta1GatewayRuleSpec Spec { get; set; }

    /// <summary>GatewayRuleStatus defines the observed state of GatewayRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1GatewayRuleStatus? Status { get; set; }
}