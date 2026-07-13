#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>TrafficMirrorFilterRule is the Schema for the TrafficMirrorFilterRules API. Provides an Traffic mirror filter rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TrafficMirrorFilterRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TrafficMirrorFilterRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TrafficMirrorFilterRuleList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "trafficmirrorfilterrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficMirrorFilterRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1TrafficMirrorFilterRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1TrafficMirrorFilterRule> Items { get; set; }
}

/// <summary>Destination port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecForProviderDestinationPortRange
{
    /// <summary>Starting port of the range</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Ending port of the range</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Source port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecForProviderSourcePortRange
{
    /// <summary>Starting port of the range</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Ending port of the range</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicyResolutionEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicyResolveEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicyResolutionEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicyResolveEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelector
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
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecForProvider
{
    /// <summary>Description of the traffic mirror filter rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Destination CIDR block to assign to the Traffic Mirror rule.</summary>
    [JsonPropertyName("destinationCidrBlock")]
    public string? DestinationCidrBlock { get; set; }

    /// <summary>Destination port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>Protocol number, for example 17 (UDP), to assign to the Traffic Mirror rule. For information about the protocol value, see Protocol Numbers on the Internet Assigned Numbers Authority (IANA) website.</summary>
    [JsonPropertyName("protocol")]
    public double? Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Action to take (accept | reject) on the filtered traffic. Valid values are accept and reject</summary>
    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    /// <summary>Number of the Traffic Mirror rule. This number must be unique for each Traffic Mirror rule in a given direction. The rules are processed in ascending order by rule number.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }

    /// <summary>Source CIDR block to assign to the Traffic Mirror rule.</summary>
    [JsonPropertyName("sourceCidrBlock")]
    public string? SourceCidrBlock { get; set; }

    /// <summary>Source port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderSourcePortRange? SourcePortRange { get; set; }

    /// <summary>Direction of traffic to be captured. Valid values are ingress and egress</summary>
    [JsonPropertyName("trafficDirection")]
    public string? TrafficDirection { get; set; }

    /// <summary>ID of the traffic mirror filter to which this rule should be added</summary>
    [JsonPropertyName("trafficMirrorFilterId")]
    public string? TrafficMirrorFilterId { get; set; }

    /// <summary>Reference to a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
    [JsonPropertyName("trafficMirrorFilterIdRef")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdRef? TrafficMirrorFilterIdRef { get; set; }

    /// <summary>Selector for a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
    [JsonPropertyName("trafficMirrorFilterIdSelector")]
    public V1beta1TrafficMirrorFilterRuleSpecForProviderTrafficMirrorFilterIdSelector? TrafficMirrorFilterIdSelector { get; set; }
}

/// <summary>Destination port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecInitProviderDestinationPortRange
{
    /// <summary>Starting port of the range</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Ending port of the range</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Source port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecInitProviderSourcePortRange
{
    /// <summary>Starting port of the range</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Ending port of the range</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicyResolutionEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicyResolveEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicyResolutionEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicyResolveEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelector
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
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1TrafficMirrorFilterRuleSpecInitProvider
{
    /// <summary>Description of the traffic mirror filter rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Destination CIDR block to assign to the Traffic Mirror rule.</summary>
    [JsonPropertyName("destinationCidrBlock")]
    public string? DestinationCidrBlock { get; set; }

    /// <summary>Destination port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>Protocol number, for example 17 (UDP), to assign to the Traffic Mirror rule. For information about the protocol value, see Protocol Numbers on the Internet Assigned Numbers Authority (IANA) website.</summary>
    [JsonPropertyName("protocol")]
    public double? Protocol { get; set; }

    /// <summary>Action to take (accept | reject) on the filtered traffic. Valid values are accept and reject</summary>
    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    /// <summary>Number of the Traffic Mirror rule. This number must be unique for each Traffic Mirror rule in a given direction. The rules are processed in ascending order by rule number.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }

    /// <summary>Source CIDR block to assign to the Traffic Mirror rule.</summary>
    [JsonPropertyName("sourceCidrBlock")]
    public string? SourceCidrBlock { get; set; }

    /// <summary>Source port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderSourcePortRange? SourcePortRange { get; set; }

    /// <summary>Direction of traffic to be captured. Valid values are ingress and egress</summary>
    [JsonPropertyName("trafficDirection")]
    public string? TrafficDirection { get; set; }

    /// <summary>ID of the traffic mirror filter to which this rule should be added</summary>
    [JsonPropertyName("trafficMirrorFilterId")]
    public string? TrafficMirrorFilterId { get; set; }

    /// <summary>Reference to a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
    [JsonPropertyName("trafficMirrorFilterIdRef")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdRef? TrafficMirrorFilterIdRef { get; set; }

    /// <summary>Selector for a TrafficMirrorFilter in ec2 to populate trafficMirrorFilterId.</summary>
    [JsonPropertyName("trafficMirrorFilterIdSelector")]
    public V1beta1TrafficMirrorFilterRuleSpecInitProviderTrafficMirrorFilterIdSelector? TrafficMirrorFilterIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficMirrorFilterRuleSpecManagementPoliciesEnum>))]
public enum V1beta1TrafficMirrorFilterRuleSpecManagementPoliciesEnum
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
public partial class V1beta1TrafficMirrorFilterRuleSpecProviderConfigRef
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
public partial class V1beta1TrafficMirrorFilterRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TrafficMirrorFilterRuleSpec defines the desired state of TrafficMirrorFilterRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1TrafficMirrorFilterRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta1TrafficMirrorFilterRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TrafficMirrorFilterRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TrafficMirrorFilterRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TrafficMirrorFilterRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Destination port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleStatusAtProviderDestinationPortRange
{
    /// <summary>Starting port of the range</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Ending port of the range</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Source port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleStatusAtProviderSourcePortRange
{
    /// <summary>Starting port of the range</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>Ending port of the range</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleStatusAtProvider
{
    /// <summary>ARN of the traffic mirror filter rule.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the traffic mirror filter rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Destination CIDR block to assign to the Traffic Mirror rule.</summary>
    [JsonPropertyName("destinationCidrBlock")]
    public string? DestinationCidrBlock { get; set; }

    /// <summary>Destination port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1TrafficMirrorFilterRuleStatusAtProviderDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>Name of the traffic mirror filter rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Protocol number, for example 17 (UDP), to assign to the Traffic Mirror rule. For information about the protocol value, see Protocol Numbers on the Internet Assigned Numbers Authority (IANA) website.</summary>
    [JsonPropertyName("protocol")]
    public double? Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Action to take (accept | reject) on the filtered traffic. Valid values are accept and reject</summary>
    [JsonPropertyName("ruleAction")]
    public string? RuleAction { get; set; }

    /// <summary>Number of the Traffic Mirror rule. This number must be unique for each Traffic Mirror rule in a given direction. The rules are processed in ascending order by rule number.</summary>
    [JsonPropertyName("ruleNumber")]
    public double? RuleNumber { get; set; }

    /// <summary>Source CIDR block to assign to the Traffic Mirror rule.</summary>
    [JsonPropertyName("sourceCidrBlock")]
    public string? SourceCidrBlock { get; set; }

    /// <summary>Source port range. Supported only when the protocol is set to TCP(6) or UDP(17). See Traffic mirror port range documented below</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1TrafficMirrorFilterRuleStatusAtProviderSourcePortRange? SourcePortRange { get; set; }

    /// <summary>Direction of traffic to be captured. Valid values are ingress and egress</summary>
    [JsonPropertyName("trafficDirection")]
    public string? TrafficDirection { get; set; }

    /// <summary>ID of the traffic mirror filter to which this rule should be added</summary>
    [JsonPropertyName("trafficMirrorFilterId")]
    public string? TrafficMirrorFilterId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleStatusConditions
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

/// <summary>TrafficMirrorFilterRuleStatus defines the observed state of TrafficMirrorFilterRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficMirrorFilterRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1TrafficMirrorFilterRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TrafficMirrorFilterRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TrafficMirrorFilterRule is the Schema for the TrafficMirrorFilterRules API. Provides an Traffic mirror filter rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TrafficMirrorFilterRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TrafficMirrorFilterRuleSpec>, IStatus<V1beta1TrafficMirrorFilterRuleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TrafficMirrorFilterRule";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "trafficmirrorfilterrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrafficMirrorFilterRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TrafficMirrorFilterRuleSpec defines the desired state of TrafficMirrorFilterRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TrafficMirrorFilterRuleSpec Spec { get; set; }

    /// <summary>TrafficMirrorFilterRuleStatus defines the observed state of TrafficMirrorFilterRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1TrafficMirrorFilterRuleStatus? Status { get; set; }
}