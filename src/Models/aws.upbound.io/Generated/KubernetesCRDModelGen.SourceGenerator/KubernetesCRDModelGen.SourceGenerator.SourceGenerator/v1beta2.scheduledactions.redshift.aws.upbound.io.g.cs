#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.redshift.aws.upbound.io;
/// <summary>ScheduledAction is the Schema for the ScheduledActions API. Provides a Redshift Scheduled Action resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ScheduledActionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ScheduledAction>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ScheduledActionList";
    public const string KubeGroup = "redshift.aws.upbound.io";
    public const string KubePluralName = "scheduledactions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "redshift.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScheduledActionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ScheduledAction objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ScheduledAction> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecDeletionPolicyEnum>))]
public enum V1beta2ScheduledActionSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecForProviderIamRoleRefPolicyResolutionEnum>))]
public enum V1beta2ScheduledActionSpecForProviderIamRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecForProviderIamRoleRefPolicyResolveEnum>))]
public enum V1beta2ScheduledActionSpecForProviderIamRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderIamRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduledActionSpecForProviderIamRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduledActionSpecForProviderIamRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderIamRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduledActionSpecForProviderIamRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderIamRoleSelector
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
    public V1beta2ScheduledActionSpecForProviderIamRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>An action that runs a PauseCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderTargetActionPauseCluster
{
    /// <summary>The identifier of the cluster to be paused.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }
}

/// <summary>An action that runs a ResizeCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderTargetActionResizeCluster
{
    /// <summary>A boolean value indicating whether the resize operation is using the classic resize process. Default: false.</summary>
    [JsonPropertyName("classic")]
    public bool? Classic { get; set; }

    /// <summary>The unique identifier for the cluster to resize.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>The new cluster type for the specified cluster.</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>The new node type for the nodes you are adding.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The new number of nodes for the cluster.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }
}

/// <summary>An action that runs a ResumeCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderTargetActionResumeCluster
{
    /// <summary>The identifier of the cluster to be resumed.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }
}

/// <summary>Target action. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProviderTargetAction
{
    /// <summary>An action that runs a PauseCluster API operation. Documented below.</summary>
    [JsonPropertyName("pauseCluster")]
    public V1beta2ScheduledActionSpecForProviderTargetActionPauseCluster? PauseCluster { get; set; }

    /// <summary>An action that runs a ResizeCluster API operation. Documented below.</summary>
    [JsonPropertyName("resizeCluster")]
    public V1beta2ScheduledActionSpecForProviderTargetActionResizeCluster? ResizeCluster { get; set; }

    /// <summary>An action that runs a ResumeCluster API operation. Documented below.</summary>
    [JsonPropertyName("resumeCluster")]
    public V1beta2ScheduledActionSpecForProviderTargetActionResumeCluster? ResumeCluster { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecForProvider
{
    /// <summary>The description of the scheduled action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to enable the scheduled action. Default is true .</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>The end time in UTC when the schedule is active, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The IAM role to assume to run the scheduled action.</summary>
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleRef")]
    public V1beta2ScheduledActionSpecForProviderIamRoleRef? IamRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleSelector")]
    public V1beta2ScheduledActionSpecForProviderIamRoleSelector? IamRoleSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The schedule of action. The schedule is defined format of &quot;at expression&quot; or &quot;cron expression&quot;, for example at(2016-03-04T17:27:00) or cron(0 10 ? * MON *). See Scheduled Action for more information.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The start time in UTC when the schedule is active, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Target action. Documented below.</summary>
    [JsonPropertyName("targetAction")]
    public V1beta2ScheduledActionSpecForProviderTargetAction? TargetAction { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicyResolutionEnum>))]
public enum V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicyResolveEnum>))]
public enum V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderIamRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduledActionSpecInitProviderIamRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderIamRoleSelector
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
    public V1beta2ScheduledActionSpecInitProviderIamRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>An action that runs a PauseCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderTargetActionPauseCluster
{
    /// <summary>The identifier of the cluster to be paused.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }
}

/// <summary>An action that runs a ResizeCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderTargetActionResizeCluster
{
    /// <summary>A boolean value indicating whether the resize operation is using the classic resize process. Default: false.</summary>
    [JsonPropertyName("classic")]
    public bool? Classic { get; set; }

    /// <summary>The unique identifier for the cluster to resize.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>The new cluster type for the specified cluster.</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>The new node type for the nodes you are adding.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The new number of nodes for the cluster.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }
}

/// <summary>An action that runs a ResumeCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderTargetActionResumeCluster
{
    /// <summary>The identifier of the cluster to be resumed.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }
}

/// <summary>Target action. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecInitProviderTargetAction
{
    /// <summary>An action that runs a PauseCluster API operation. Documented below.</summary>
    [JsonPropertyName("pauseCluster")]
    public V1beta2ScheduledActionSpecInitProviderTargetActionPauseCluster? PauseCluster { get; set; }

    /// <summary>An action that runs a ResizeCluster API operation. Documented below.</summary>
    [JsonPropertyName("resizeCluster")]
    public V1beta2ScheduledActionSpecInitProviderTargetActionResizeCluster? ResizeCluster { get; set; }

    /// <summary>An action that runs a ResumeCluster API operation. Documented below.</summary>
    [JsonPropertyName("resumeCluster")]
    public V1beta2ScheduledActionSpecInitProviderTargetActionResumeCluster? ResumeCluster { get; set; }
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
public partial class V1beta2ScheduledActionSpecInitProvider
{
    /// <summary>The description of the scheduled action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to enable the scheduled action. Default is true .</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>The end time in UTC when the schedule is active, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The IAM role to assume to run the scheduled action.</summary>
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleRef")]
    public V1beta2ScheduledActionSpecInitProviderIamRoleRef? IamRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleSelector")]
    public V1beta2ScheduledActionSpecInitProviderIamRoleSelector? IamRoleSelector { get; set; }

    /// <summary>The schedule of action. The schedule is defined format of &quot;at expression&quot; or &quot;cron expression&quot;, for example at(2016-03-04T17:27:00) or cron(0 10 ? * MON *). See Scheduled Action for more information.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The start time in UTC when the schedule is active, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Target action. Documented below.</summary>
    [JsonPropertyName("targetAction")]
    public V1beta2ScheduledActionSpecInitProviderTargetAction? TargetAction { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecManagementPoliciesEnum>))]
public enum V1beta2ScheduledActionSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ScheduledActionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduledActionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ScheduledActionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduledActionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduledActionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduledActionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ScheduledActionSpec defines the desired state of ScheduledAction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionSpec
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
    public V1beta2ScheduledActionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ScheduledActionSpecForProvider ForProvider { get; set; }

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
    public V1beta2ScheduledActionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ScheduledActionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ScheduledActionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ScheduledActionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An action that runs a PauseCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionStatusAtProviderTargetActionPauseCluster
{
    /// <summary>The identifier of the cluster to be paused.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }
}

/// <summary>An action that runs a ResizeCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionStatusAtProviderTargetActionResizeCluster
{
    /// <summary>A boolean value indicating whether the resize operation is using the classic resize process. Default: false.</summary>
    [JsonPropertyName("classic")]
    public bool? Classic { get; set; }

    /// <summary>The unique identifier for the cluster to resize.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }

    /// <summary>The new cluster type for the specified cluster.</summary>
    [JsonPropertyName("clusterType")]
    public string? ClusterType { get; set; }

    /// <summary>The new node type for the nodes you are adding.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>The new number of nodes for the cluster.</summary>
    [JsonPropertyName("numberOfNodes")]
    public double? NumberOfNodes { get; set; }
}

/// <summary>An action that runs a ResumeCluster API operation. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionStatusAtProviderTargetActionResumeCluster
{
    /// <summary>The identifier of the cluster to be resumed.</summary>
    [JsonPropertyName("clusterIdentifier")]
    public string? ClusterIdentifier { get; set; }
}

/// <summary>Target action. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionStatusAtProviderTargetAction
{
    /// <summary>An action that runs a PauseCluster API operation. Documented below.</summary>
    [JsonPropertyName("pauseCluster")]
    public V1beta2ScheduledActionStatusAtProviderTargetActionPauseCluster? PauseCluster { get; set; }

    /// <summary>An action that runs a ResizeCluster API operation. Documented below.</summary>
    [JsonPropertyName("resizeCluster")]
    public V1beta2ScheduledActionStatusAtProviderTargetActionResizeCluster? ResizeCluster { get; set; }

    /// <summary>An action that runs a ResumeCluster API operation. Documented below.</summary>
    [JsonPropertyName("resumeCluster")]
    public V1beta2ScheduledActionStatusAtProviderTargetActionResumeCluster? ResumeCluster { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionStatusAtProvider
{
    /// <summary>The description of the scheduled action.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether to enable the scheduled action. Default is true .</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>The end time in UTC when the schedule is active, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The IAM role to assume to run the scheduled action.</summary>
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; set; }

    /// <summary>The Redshift Scheduled Action name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The schedule of action. The schedule is defined format of &quot;at expression&quot; or &quot;cron expression&quot;, for example at(2016-03-04T17:27:00) or cron(0 10 ? * MON *). See Scheduled Action for more information.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The start time in UTC when the schedule is active, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Target action. Documented below.</summary>
    [JsonPropertyName("targetAction")]
    public V1beta2ScheduledActionStatusAtProviderTargetAction? TargetAction { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionStatusConditions
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

/// <summary>ScheduledActionStatus defines the observed state of ScheduledAction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduledActionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ScheduledActionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ScheduledActionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ScheduledAction is the Schema for the ScheduledActions API. Provides a Redshift Scheduled Action resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ScheduledAction : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ScheduledActionSpec>, IStatus<V1beta2ScheduledActionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ScheduledAction";
    public const string KubeGroup = "redshift.aws.upbound.io";
    public const string KubePluralName = "scheduledactions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "redshift.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScheduledAction";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScheduledActionSpec defines the desired state of ScheduledAction</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ScheduledActionSpec Spec { get; set; }

    /// <summary>ScheduledActionStatus defines the observed state of ScheduledAction.</summary>
    [JsonPropertyName("status")]
    public V1beta2ScheduledActionStatus? Status { get; set; }
}