#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eks.aws.m.upbound.io;
/// <summary>NodeGroup is the Schema for the NodeGroups API. Manages an EKS Node Group</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodeGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NodeGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodeGroupList";
    public const string KubeGroup = "eks.aws.m.upbound.io";
    public const string KubePluralName = "nodegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodeGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NodeGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NodeGroup> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderClusterNameRefPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderClusterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderClusterNameRefPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderClusterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderClusterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderClusterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderClusterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in eks to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecForProviderClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in eks to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderClusterNameSelector
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
    public V1beta1NodeGroupSpecForProviderClusterNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with Launch Template settings. See launch_template below for details. Conflicts with remote_access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderLaunchTemplate
{
    /// <summary>Identifier of the EC2 Launch Template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the EC2 Launch Template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>EC2 Launch Template version number.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderNodeRepairConfigNodeRepairConfigOverrides
{
    /// <summary>Minimum time in minutes to wait before attempting to repair a node with the specified node_monitoring_condition and node_unhealthy_reason.</summary>
    [JsonPropertyName("minRepairWaitTimeMins")]
    public double? MinRepairWaitTimeMins { get; set; }

    /// <summary>Unhealthy condition reported by the node monitoring agent that this override applies to.</summary>
    [JsonPropertyName("nodeMonitoringCondition")]
    public string? NodeMonitoringCondition { get; set; }

    /// <summary>Reason reported by the node monitoring agent that this override applies to.</summary>
    [JsonPropertyName("nodeUnhealthyReason")]
    public string? NodeUnhealthyReason { get; set; }

    /// <summary>Repair action to take for nodes when all of the specified conditions are met. Valid values are defined by the EKS API.</summary>
    [JsonPropertyName("repairAction")]
    public string? RepairAction { get; set; }
}

/// <summary>The node auto repair configuration for the node group. See node_repair_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderNodeRepairConfig
{
    /// <summary>Specifies whether to enable node auto repair for the node group. Node auto repair is disabled by default. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Maximum number of nodes that can be repaired concurrently or in parallel, expressed as a count of unhealthy nodes. Conflicts with max_parallel_nodes_repaired_percentage.</summary>
    [JsonPropertyName("maxParallelNodesRepairedCount")]
    public double? MaxParallelNodesRepairedCount { get; set; }

    /// <summary>Maximum number of nodes that can be repaired concurrently or in parallel, expressed as a percentage of unhealthy nodes. Conflicts with max_parallel_nodes_repaired_count.</summary>
    [JsonPropertyName("maxParallelNodesRepairedPercentage")]
    public double? MaxParallelNodesRepairedPercentage { get; set; }

    /// <summary>Count threshold of unhealthy nodes, above which node auto repair actions will stop. Conflicts with max_unhealthy_node_threshold_percentage.</summary>
    [JsonPropertyName("maxUnhealthyNodeThresholdCount")]
    public double? MaxUnhealthyNodeThresholdCount { get; set; }

    /// <summary>Percentage threshold of unhealthy nodes, above which node auto repair actions will stop. Conflicts with max_unhealthy_node_threshold_count.</summary>
    [JsonPropertyName("maxUnhealthyNodeThresholdPercentage")]
    public double? MaxUnhealthyNodeThresholdPercentage { get; set; }

    /// <summary>Granular overrides for specific repair actions. See node_repair_config_overrides below for details.</summary>
    [JsonPropertyName("nodeRepairConfigOverrides")]
    public IList<V1beta1NodeGroupSpecForProviderNodeRepairConfigNodeRepairConfigOverrides>? NodeRepairConfigOverrides { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate nodeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderNodeRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecForProviderNodeRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate nodeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderNodeRoleArnSelector
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
    public V1beta1NodeGroupSpecForProviderNodeRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate sourceSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelector
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
    public V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with remote access settings. See remote_access below for details. Conflicts with launch_template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderRemoteAccess
{
    /// <summary>EC2 Key Pair name that provides access for remote communication with the worker nodes in the EKS Node Group. If you specify this configuration, but do not specify source_security_group_ids when you create an EKS Node Group, either port 3389 for Windows, or port 22 for all other operating systems is opened on the worker nodes to the Internet (0.0.0.0/0). For Windows nodes, this will allow you to use RDP, for all others this allows you to SSH into the worker nodes.</summary>
    [JsonPropertyName("ec2SshKey")]
    public string? Ec2SshKey { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate sourceSecurityGroupIds.</summary>
    [JsonPropertyName("sourceSecurityGroupIdRefs")]
    public IList<V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdRefs>? SourceSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate sourceSecurityGroupIds.</summary>
    [JsonPropertyName("sourceSecurityGroupIdSelector")]
    public V1beta1NodeGroupSpecForProviderRemoteAccessSourceSecurityGroupIdSelector? SourceSecurityGroupIdSelector { get; set; }

    /// <summary>Set of EC2 Security Group IDs to allow SSH access (port 22) from on the worker nodes. If you specify ec2_ssh_key, but do not specify this configuration when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).</summary>
    [JsonPropertyName("sourceSecurityGroupIds")]
    public IList<string>? SourceSecurityGroupIds { get; set; }
}

/// <summary>Configuration block with scaling settings. See scaling_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderScalingConfig
{
    /// <summary>Desired number of worker nodes.</summary>
    [JsonPropertyName("desiredSize")]
    public double? DesiredSize { get; set; }

    /// <summary>Maximum number of worker nodes.</summary>
    [JsonPropertyName("maxSize")]
    public double? MaxSize { get; set; }

    /// <summary>Minimum number of worker nodes.</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderSubnetIdSelector
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
    public V1beta1NodeGroupSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderTaint
{
    /// <summary>The effect of the taint. Valid values: NO_SCHEDULE, NO_EXECUTE, PREFER_NO_SCHEDULE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>The key of the taint. Maximum length of 63.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the taint. Maximum length of 63.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block with update settings. See update_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderUpdateConfig
{
    /// <summary>Desired max number of unavailable worker nodes during node group update.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>Desired max percentage of unavailable worker nodes during node group update.</summary>
    [JsonPropertyName("maxUnavailablePercentage")]
    public double? MaxUnavailablePercentage { get; set; }

    /// <summary>Strategy to use for updating the node group. Valid values: MINIMAL and DEFAULT.</summary>
    [JsonPropertyName("updateStrategy")]
    public string? UpdateStrategy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderVersionRefPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderVersionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderVersionRefPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in eks to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecForProviderVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecForProviderVersionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecForProviderVersionSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecForProviderVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecForProviderVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecForProviderVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in eks to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProviderVersionSelector
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
    public V1beta1NodeGroupSpecForProviderVersionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecForProvider
{
    /// <summary>Type of Amazon Machine Image (AMI) associated with the EKS Node Group. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("amiType")]
    public string? AmiType { get; set; }

    /// <summary>Type of capacity associated with the EKS Node Group. Valid values: ON_DEMAND, SPOT.</summary>
    [JsonPropertyName("capacityType")]
    public string? CapacityType { get; set; }

    /// <summary>Name of the EKS Cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Reference to a Cluster in eks to populate clusterName.</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1beta1NodeGroupSpecForProviderClusterNameRef? ClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in eks to populate clusterName.</summary>
    [JsonPropertyName("clusterNameSelector")]
    public V1beta1NodeGroupSpecForProviderClusterNameSelector? ClusterNameSelector { get; set; }

    /// <summary>Disk size in GiB for worker nodes. Defaults to 50 for Windows, 20 all other node groups.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>Force version update if existing pods are unable to be drained due to a pod disruption budget issue.</summary>
    [JsonPropertyName("forceUpdateVersion")]
    public bool? ForceUpdateVersion { get; set; }

    /// <summary>List of instance types associated with the EKS Node Group. Defaults to [&quot;t3.medium&quot;].</summary>
    [JsonPropertyName("instanceTypes")]
    public IList<string>? InstanceTypes { get; set; }

    /// <summary>Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configuration block with Launch Template settings. See launch_template below for details. Conflicts with remote_access.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1NodeGroupSpecForProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The node auto repair configuration for the node group. See node_repair_config below for details.</summary>
    [JsonPropertyName("nodeRepairConfig")]
    public V1beta1NodeGroupSpecForProviderNodeRepairConfig? NodeRepairConfig { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.</summary>
    [JsonPropertyName("nodeRoleArn")]
    public string? NodeRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate nodeRoleArn.</summary>
    [JsonPropertyName("nodeRoleArnRef")]
    public V1beta1NodeGroupSpecForProviderNodeRoleArnRef? NodeRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate nodeRoleArn.</summary>
    [JsonPropertyName("nodeRoleArnSelector")]
    public V1beta1NodeGroupSpecForProviderNodeRoleArnSelector? NodeRoleArnSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.</summary>
    [JsonPropertyName("releaseVersion")]
    public string? ReleaseVersion { get; set; }

    /// <summary>Configuration block with remote access settings. See remote_access below for details. Conflicts with launch_template.</summary>
    [JsonPropertyName("remoteAccess")]
    public V1beta1NodeGroupSpecForProviderRemoteAccess? RemoteAccess { get; set; }

    /// <summary>Configuration block with scaling settings. See scaling_config below for details.</summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta1NodeGroupSpecForProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1NodeGroupSpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1NodeGroupSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Identifiers of EC2 Subnets to associate with the EKS Node Group. Amazon EKS managed node groups can be launched in both public and private subnets. If you plan to deploy load balancers to a subnet, the private subnet must have tag kubernetes.io/role/internal-elb, the public subnet must have tag kubernetes.io/role/elb.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Kubernetes taints to be applied to the nodes in the node group. Maximum of 50 taints per node group. See taint below for details.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1NodeGroupSpecForProviderTaint>? Taint { get; set; }

    /// <summary>Configuration block with update settings. See update_config below for details.</summary>
    [JsonPropertyName("updateConfig")]
    public V1beta1NodeGroupSpecForProviderUpdateConfig? UpdateConfig { get; set; }

    /// <summary>Kubernetes version. Defaults to EKS Cluster Kubernetes version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a Cluster in eks to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1NodeGroupSpecForProviderVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a Cluster in eks to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta1NodeGroupSpecForProviderVersionSelector? VersionSelector { get; set; }
}

/// <summary>Configuration block with Launch Template settings. See launch_template below for details. Conflicts with remote_access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderLaunchTemplate
{
    /// <summary>Identifier of the EC2 Launch Template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the EC2 Launch Template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>EC2 Launch Template version number.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderNodeRepairConfigNodeRepairConfigOverrides
{
    /// <summary>Minimum time in minutes to wait before attempting to repair a node with the specified node_monitoring_condition and node_unhealthy_reason.</summary>
    [JsonPropertyName("minRepairWaitTimeMins")]
    public double? MinRepairWaitTimeMins { get; set; }

    /// <summary>Unhealthy condition reported by the node monitoring agent that this override applies to.</summary>
    [JsonPropertyName("nodeMonitoringCondition")]
    public string? NodeMonitoringCondition { get; set; }

    /// <summary>Reason reported by the node monitoring agent that this override applies to.</summary>
    [JsonPropertyName("nodeUnhealthyReason")]
    public string? NodeUnhealthyReason { get; set; }

    /// <summary>Repair action to take for nodes when all of the specified conditions are met. Valid values are defined by the EKS API.</summary>
    [JsonPropertyName("repairAction")]
    public string? RepairAction { get; set; }
}

/// <summary>The node auto repair configuration for the node group. See node_repair_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderNodeRepairConfig
{
    /// <summary>Specifies whether to enable node auto repair for the node group. Node auto repair is disabled by default. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Maximum number of nodes that can be repaired concurrently or in parallel, expressed as a count of unhealthy nodes. Conflicts with max_parallel_nodes_repaired_percentage.</summary>
    [JsonPropertyName("maxParallelNodesRepairedCount")]
    public double? MaxParallelNodesRepairedCount { get; set; }

    /// <summary>Maximum number of nodes that can be repaired concurrently or in parallel, expressed as a percentage of unhealthy nodes. Conflicts with max_parallel_nodes_repaired_count.</summary>
    [JsonPropertyName("maxParallelNodesRepairedPercentage")]
    public double? MaxParallelNodesRepairedPercentage { get; set; }

    /// <summary>Count threshold of unhealthy nodes, above which node auto repair actions will stop. Conflicts with max_unhealthy_node_threshold_percentage.</summary>
    [JsonPropertyName("maxUnhealthyNodeThresholdCount")]
    public double? MaxUnhealthyNodeThresholdCount { get; set; }

    /// <summary>Percentage threshold of unhealthy nodes, above which node auto repair actions will stop. Conflicts with max_unhealthy_node_threshold_count.</summary>
    [JsonPropertyName("maxUnhealthyNodeThresholdPercentage")]
    public double? MaxUnhealthyNodeThresholdPercentage { get; set; }

    /// <summary>Granular overrides for specific repair actions. See node_repair_config_overrides below for details.</summary>
    [JsonPropertyName("nodeRepairConfigOverrides")]
    public IList<V1beta1NodeGroupSpecInitProviderNodeRepairConfigNodeRepairConfigOverrides>? NodeRepairConfigOverrides { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate nodeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderNodeRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate nodeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderNodeRoleArnSelector
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
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate sourceSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelector
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
    public V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with remote access settings. See remote_access below for details. Conflicts with launch_template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderRemoteAccess
{
    /// <summary>EC2 Key Pair name that provides access for remote communication with the worker nodes in the EKS Node Group. If you specify this configuration, but do not specify source_security_group_ids when you create an EKS Node Group, either port 3389 for Windows, or port 22 for all other operating systems is opened on the worker nodes to the Internet (0.0.0.0/0). For Windows nodes, this will allow you to use RDP, for all others this allows you to SSH into the worker nodes.</summary>
    [JsonPropertyName("ec2SshKey")]
    public string? Ec2SshKey { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate sourceSecurityGroupIds.</summary>
    [JsonPropertyName("sourceSecurityGroupIdRefs")]
    public IList<V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdRefs>? SourceSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate sourceSecurityGroupIds.</summary>
    [JsonPropertyName("sourceSecurityGroupIdSelector")]
    public V1beta1NodeGroupSpecInitProviderRemoteAccessSourceSecurityGroupIdSelector? SourceSecurityGroupIdSelector { get; set; }

    /// <summary>Set of EC2 Security Group IDs to allow SSH access (port 22) from on the worker nodes. If you specify ec2_ssh_key, but do not specify this configuration when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).</summary>
    [JsonPropertyName("sourceSecurityGroupIds")]
    public IList<string>? SourceSecurityGroupIds { get; set; }
}

/// <summary>Configuration block with scaling settings. See scaling_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderScalingConfig
{
    /// <summary>Desired number of worker nodes.</summary>
    [JsonPropertyName("desiredSize")]
    public double? DesiredSize { get; set; }

    /// <summary>Maximum number of worker nodes.</summary>
    [JsonPropertyName("maxSize")]
    public double? MaxSize { get; set; }

    /// <summary>Minimum number of worker nodes.</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderSubnetIdSelector
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
    public V1beta1NodeGroupSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderTaint
{
    /// <summary>The effect of the taint. Valid values: NO_SCHEDULE, NO_EXECUTE, PREFER_NO_SCHEDULE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>The key of the taint. Maximum length of 63.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the taint. Maximum length of 63.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block with update settings. See update_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderUpdateConfig
{
    /// <summary>Desired max number of unavailable worker nodes during node group update.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>Desired max percentage of unavailable worker nodes during node group update.</summary>
    [JsonPropertyName("maxUnavailablePercentage")]
    public double? MaxUnavailablePercentage { get; set; }

    /// <summary>Strategy to use for updating the node group. Valid values: MINIMAL and DEFAULT.</summary>
    [JsonPropertyName("updateStrategy")]
    public string? UpdateStrategy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderVersionRefPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderVersionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderVersionRefPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in eks to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodeGroupSpecInitProviderVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1NodeGroupSpecInitProviderVersionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecInitProviderVersionSelectorPolicyResolveEnum>))]
public enum V1beta1NodeGroupSpecInitProviderVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodeGroupSpecInitProviderVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodeGroupSpecInitProviderVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in eks to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpecInitProviderVersionSelector
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
    public V1beta1NodeGroupSpecInitProviderVersionSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1NodeGroupSpecInitProvider
{
    /// <summary>Type of Amazon Machine Image (AMI) associated with the EKS Node Group. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("amiType")]
    public string? AmiType { get; set; }

    /// <summary>Type of capacity associated with the EKS Node Group. Valid values: ON_DEMAND, SPOT.</summary>
    [JsonPropertyName("capacityType")]
    public string? CapacityType { get; set; }

    /// <summary>Disk size in GiB for worker nodes. Defaults to 50 for Windows, 20 all other node groups.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>Force version update if existing pods are unable to be drained due to a pod disruption budget issue.</summary>
    [JsonPropertyName("forceUpdateVersion")]
    public bool? ForceUpdateVersion { get; set; }

    /// <summary>List of instance types associated with the EKS Node Group. Defaults to [&quot;t3.medium&quot;].</summary>
    [JsonPropertyName("instanceTypes")]
    public IList<string>? InstanceTypes { get; set; }

    /// <summary>Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configuration block with Launch Template settings. See launch_template below for details. Conflicts with remote_access.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1NodeGroupSpecInitProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The node auto repair configuration for the node group. See node_repair_config below for details.</summary>
    [JsonPropertyName("nodeRepairConfig")]
    public V1beta1NodeGroupSpecInitProviderNodeRepairConfig? NodeRepairConfig { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.</summary>
    [JsonPropertyName("nodeRoleArn")]
    public string? NodeRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate nodeRoleArn.</summary>
    [JsonPropertyName("nodeRoleArnRef")]
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnRef? NodeRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate nodeRoleArn.</summary>
    [JsonPropertyName("nodeRoleArnSelector")]
    public V1beta1NodeGroupSpecInitProviderNodeRoleArnSelector? NodeRoleArnSelector { get; set; }

    /// <summary>AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.</summary>
    [JsonPropertyName("releaseVersion")]
    public string? ReleaseVersion { get; set; }

    /// <summary>Configuration block with remote access settings. See remote_access below for details. Conflicts with launch_template.</summary>
    [JsonPropertyName("remoteAccess")]
    public V1beta1NodeGroupSpecInitProviderRemoteAccess? RemoteAccess { get; set; }

    /// <summary>Configuration block with scaling settings. See scaling_config below for details.</summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta1NodeGroupSpecInitProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1NodeGroupSpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1NodeGroupSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Identifiers of EC2 Subnets to associate with the EKS Node Group. Amazon EKS managed node groups can be launched in both public and private subnets. If you plan to deploy load balancers to a subnet, the private subnet must have tag kubernetes.io/role/internal-elb, the public subnet must have tag kubernetes.io/role/elb.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The Kubernetes taints to be applied to the nodes in the node group. Maximum of 50 taints per node group. See taint below for details.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1NodeGroupSpecInitProviderTaint>? Taint { get; set; }

    /// <summary>Configuration block with update settings. See update_config below for details.</summary>
    [JsonPropertyName("updateConfig")]
    public V1beta1NodeGroupSpecInitProviderUpdateConfig? UpdateConfig { get; set; }

    /// <summary>Kubernetes version. Defaults to EKS Cluster Kubernetes version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a Cluster in eks to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1NodeGroupSpecInitProviderVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a Cluster in eks to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta1NodeGroupSpecInitProviderVersionSelector? VersionSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodeGroupSpecManagementPoliciesEnum>))]
public enum V1beta1NodeGroupSpecManagementPoliciesEnum
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
public partial class V1beta1NodeGroupSpecProviderConfigRef
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
public partial class V1beta1NodeGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>NodeGroupSpec defines the desired state of NodeGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1NodeGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1NodeGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NodeGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodeGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodeGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block with Launch Template settings. See launch_template below for details. Conflicts with remote_access.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderLaunchTemplate
{
    /// <summary>Identifier of the EC2 Launch Template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the EC2 Launch Template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>EC2 Launch Template version number.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderNodeRepairConfigNodeRepairConfigOverrides
{
    /// <summary>Minimum time in minutes to wait before attempting to repair a node with the specified node_monitoring_condition and node_unhealthy_reason.</summary>
    [JsonPropertyName("minRepairWaitTimeMins")]
    public double? MinRepairWaitTimeMins { get; set; }

    /// <summary>Unhealthy condition reported by the node monitoring agent that this override applies to.</summary>
    [JsonPropertyName("nodeMonitoringCondition")]
    public string? NodeMonitoringCondition { get; set; }

    /// <summary>Reason reported by the node monitoring agent that this override applies to.</summary>
    [JsonPropertyName("nodeUnhealthyReason")]
    public string? NodeUnhealthyReason { get; set; }

    /// <summary>Repair action to take for nodes when all of the specified conditions are met. Valid values are defined by the EKS API.</summary>
    [JsonPropertyName("repairAction")]
    public string? RepairAction { get; set; }
}

/// <summary>The node auto repair configuration for the node group. See node_repair_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderNodeRepairConfig
{
    /// <summary>Specifies whether to enable node auto repair for the node group. Node auto repair is disabled by default. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Maximum number of nodes that can be repaired concurrently or in parallel, expressed as a count of unhealthy nodes. Conflicts with max_parallel_nodes_repaired_percentage.</summary>
    [JsonPropertyName("maxParallelNodesRepairedCount")]
    public double? MaxParallelNodesRepairedCount { get; set; }

    /// <summary>Maximum number of nodes that can be repaired concurrently or in parallel, expressed as a percentage of unhealthy nodes. Conflicts with max_parallel_nodes_repaired_count.</summary>
    [JsonPropertyName("maxParallelNodesRepairedPercentage")]
    public double? MaxParallelNodesRepairedPercentage { get; set; }

    /// <summary>Count threshold of unhealthy nodes, above which node auto repair actions will stop. Conflicts with max_unhealthy_node_threshold_percentage.</summary>
    [JsonPropertyName("maxUnhealthyNodeThresholdCount")]
    public double? MaxUnhealthyNodeThresholdCount { get; set; }

    /// <summary>Percentage threshold of unhealthy nodes, above which node auto repair actions will stop. Conflicts with max_unhealthy_node_threshold_count.</summary>
    [JsonPropertyName("maxUnhealthyNodeThresholdPercentage")]
    public double? MaxUnhealthyNodeThresholdPercentage { get; set; }

    /// <summary>Granular overrides for specific repair actions. See node_repair_config_overrides below for details.</summary>
    [JsonPropertyName("nodeRepairConfigOverrides")]
    public IList<V1beta1NodeGroupStatusAtProviderNodeRepairConfigNodeRepairConfigOverrides>? NodeRepairConfigOverrides { get; set; }
}

/// <summary>Configuration block with remote access settings. See remote_access below for details. Conflicts with launch_template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderRemoteAccess
{
    /// <summary>EC2 Key Pair name that provides access for remote communication with the worker nodes in the EKS Node Group. If you specify this configuration, but do not specify source_security_group_ids when you create an EKS Node Group, either port 3389 for Windows, or port 22 for all other operating systems is opened on the worker nodes to the Internet (0.0.0.0/0). For Windows nodes, this will allow you to use RDP, for all others this allows you to SSH into the worker nodes.</summary>
    [JsonPropertyName("ec2SshKey")]
    public string? Ec2SshKey { get; set; }

    /// <summary>Set of EC2 Security Group IDs to allow SSH access (port 22) from on the worker nodes. If you specify ec2_ssh_key, but do not specify this configuration when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).</summary>
    [JsonPropertyName("sourceSecurityGroupIds")]
    public IList<string>? SourceSecurityGroupIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderResourcesAutoscalingGroups
{
    /// <summary>Name of the AutoScaling Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderResources
{
    /// <summary>List of objects containing information about AutoScaling Groups.</summary>
    [JsonPropertyName("autoscalingGroups")]
    public IList<V1beta1NodeGroupStatusAtProviderResourcesAutoscalingGroups>? AutoscalingGroups { get; set; }

    /// <summary>Identifier of the remote access EC2 Security Group.</summary>
    [JsonPropertyName("remoteAccessSecurityGroupId")]
    public string? RemoteAccessSecurityGroupId { get; set; }
}

/// <summary>Configuration block with scaling settings. See scaling_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderScalingConfig
{
    /// <summary>Desired number of worker nodes.</summary>
    [JsonPropertyName("desiredSize")]
    public double? DesiredSize { get; set; }

    /// <summary>Maximum number of worker nodes.</summary>
    [JsonPropertyName("maxSize")]
    public double? MaxSize { get; set; }

    /// <summary>Minimum number of worker nodes.</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderTaint
{
    /// <summary>The effect of the taint. Valid values: NO_SCHEDULE, NO_EXECUTE, PREFER_NO_SCHEDULE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>The key of the taint. Maximum length of 63.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the taint. Maximum length of 63.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configuration block with update settings. See update_config below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProviderUpdateConfig
{
    /// <summary>Desired max number of unavailable worker nodes during node group update.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>Desired max percentage of unavailable worker nodes during node group update.</summary>
    [JsonPropertyName("maxUnavailablePercentage")]
    public double? MaxUnavailablePercentage { get; set; }

    /// <summary>Strategy to use for updating the node group. Valid values: MINIMAL and DEFAULT.</summary>
    [JsonPropertyName("updateStrategy")]
    public string? UpdateStrategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusAtProvider
{
    /// <summary>Type of Amazon Machine Image (AMI) associated with the EKS Node Group. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("amiType")]
    public string? AmiType { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the EKS Node Group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Type of capacity associated with the EKS Node Group. Valid values: ON_DEMAND, SPOT.</summary>
    [JsonPropertyName("capacityType")]
    public string? CapacityType { get; set; }

    /// <summary>Name of the EKS Cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Disk size in GiB for worker nodes. Defaults to 50 for Windows, 20 all other node groups.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>Force version update if existing pods are unable to be drained due to a pod disruption budget issue.</summary>
    [JsonPropertyName("forceUpdateVersion")]
    public bool? ForceUpdateVersion { get; set; }

    /// <summary>EKS Cluster name and EKS Node Group name separated by a colon (:).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>List of instance types associated with the EKS Node Group. Defaults to [&quot;t3.medium&quot;].</summary>
    [JsonPropertyName("instanceTypes")]
    public IList<string>? InstanceTypes { get; set; }

    /// <summary>Key-value map of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Configuration block with Launch Template settings. See launch_template below for details. Conflicts with remote_access.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1NodeGroupStatusAtProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The node auto repair configuration for the node group. See node_repair_config below for details.</summary>
    [JsonPropertyName("nodeRepairConfig")]
    public V1beta1NodeGroupStatusAtProviderNodeRepairConfig? NodeRepairConfig { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.</summary>
    [JsonPropertyName("nodeRoleArn")]
    public string? NodeRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.</summary>
    [JsonPropertyName("releaseVersion")]
    public string? ReleaseVersion { get; set; }

    /// <summary>Configuration block with remote access settings. See remote_access below for details. Conflicts with launch_template.</summary>
    [JsonPropertyName("remoteAccess")]
    public V1beta1NodeGroupStatusAtProviderRemoteAccess? RemoteAccess { get; set; }

    /// <summary>List of objects containing information about underlying resources.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1NodeGroupStatusAtProviderResources>? Resources { get; set; }

    /// <summary>Configuration block with scaling settings. See scaling_config below for details.</summary>
    [JsonPropertyName("scalingConfig")]
    public V1beta1NodeGroupStatusAtProviderScalingConfig? ScalingConfig { get; set; }

    /// <summary>Status of the EKS Node Group.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Identifiers of EC2 Subnets to associate with the EKS Node Group. Amazon EKS managed node groups can be launched in both public and private subnets. If you plan to deploy load balancers to a subnet, the private subnet must have tag kubernetes.io/role/internal-elb, the public subnet must have tag kubernetes.io/role/elb.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The Kubernetes taints to be applied to the nodes in the node group. Maximum of 50 taints per node group. See taint below for details.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1NodeGroupStatusAtProviderTaint>? Taint { get; set; }

    /// <summary>Configuration block with update settings. See update_config below for details.</summary>
    [JsonPropertyName("updateConfig")]
    public V1beta1NodeGroupStatusAtProviderUpdateConfig? UpdateConfig { get; set; }

    /// <summary>Kubernetes version. Defaults to EKS Cluster Kubernetes version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatusConditions
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

/// <summary>NodeGroupStatus defines the observed state of NodeGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodeGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1NodeGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodeGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NodeGroup is the Schema for the NodeGroups API. Manages an EKS Node Group</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodeGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodeGroupSpec>, IStatus<V1beta1NodeGroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodeGroup";
    public const string KubeGroup = "eks.aws.m.upbound.io";
    public const string KubePluralName = "nodegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eks.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodeGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodeGroupSpec defines the desired state of NodeGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NodeGroupSpec Spec { get; set; }

    /// <summary>NodeGroupStatus defines the observed state of NodeGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1NodeGroupStatus? Status { get; set; }
}