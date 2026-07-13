#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.cnrm.cloud.google.com;
/// <summary>DataprocAutoscalingPolicy is the Schema for the DataprocAutoscalingPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataprocAutoscalingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataprocAutoscalingPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataprocAutoscalingPolicyList";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocautoscalingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataprocAutoscalingPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DataprocAutoscalingPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DataprocAutoscalingPolicy> Items { get; set; }
}

/// <summary>Required. YARN autoscaling configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicySpecBasicAlgorithmYarnConfig
{
    /// <summary>
    /// Required. Timeout for YARN graceful decommissioning of Node Managers.
    ///  Specifies the duration to wait for jobs to complete before forcefully
    ///  removing workers (and potentially interrupting jobs). Only applicable to
    ///  downscaling operations.
    /// 
    ///  Bounds: [0s, 1d].
    /// </summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public required string GracefulDecommissionTimeout { get; set; }

    /// <summary>
    /// Required. Fraction of average YARN pending memory in the last cooldown
    ///  period for which to remove workers. A scale-down factor of 1 will result in
    ///  scaling down so that there is no available memory remaining after the
    ///  update (more aggressive scaling). A scale-down factor of 0 disables
    ///  removing workers, which can be beneficial for autoscaling a single job.
    ///  See [How autoscaling
    ///  works](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/autoscaling#how_autoscaling_works)
    ///  for more information.
    /// 
    ///  Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleDownFactor")]
    public required double ScaleDownFactor { get; set; }

    /// <summary>
    /// Optional. Minimum scale-down threshold as a fraction of total cluster size
    ///  before scaling occurs. For example, in a 20-worker cluster, a threshold of
    ///  0.1 means the autoscaler must recommend at least a 2 worker scale-down for
    ///  the cluster to scale. A threshold of 0 means the autoscaler will scale down
    ///  on any recommended change.
    /// 
    ///  Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleDownMinWorkerFraction")]
    public double? ScaleDownMinWorkerFraction { get; set; }

    /// <summary>
    /// Required. Fraction of average YARN pending memory in the last cooldown
    ///  period for which to add workers. A scale-up factor of 1.0 will result in
    ///  scaling up so that there is no pending memory remaining after the update
    ///  (more aggressive scaling). A scale-up factor closer to 0 will result in a
    ///  smaller magnitude of scaling up (less aggressive scaling). See [How
    ///  autoscaling
    ///  works](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/autoscaling#how_autoscaling_works)
    ///  for more information.
    /// 
    ///  Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleUpFactor")]
    public required double ScaleUpFactor { get; set; }

    /// <summary>
    /// Optional. Minimum scale-up threshold as a fraction of total cluster size
    ///  before scaling occurs. For example, in a 20-worker cluster, a threshold of
    ///  0.1 means the autoscaler must recommend at least a 2-worker scale-up for
    ///  the cluster to scale. A threshold of 0 means the autoscaler will scale up
    ///  on any recommended change.
    /// 
    ///  Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleUpMinWorkerFraction")]
    public double? ScaleUpMinWorkerFraction { get; set; }
}

/// <summary>Immutable. Required. YARN autoscaling configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicySpecBasicAlgorithm
{
    /// <summary>
    /// Optional. Duration between scaling events. A scaling period starts after
    ///  the update operation from the previous event has completed.
    /// 
    ///  Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    [JsonPropertyName("cooldownPeriod")]
    public string? CooldownPeriod { get; set; }

    /// <summary>Required. YARN autoscaling configuration.</summary>
    [JsonPropertyName("yarnConfig")]
    public required V1beta1DataprocAutoscalingPolicySpecBasicAlgorithmYarnConfig YarnConfig { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. Describes how the autoscaler will operate for secondary workers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicySpecSecondaryWorkerConfig
{
    /// <summary>
    /// Required. Maximum number of instances for this group. Required for primary
    ///  workers. Note that by default, clusters will not use secondary workers.
    ///  Required for secondary workers if the minimum secondary instances is set.
    /// 
    ///  Primary workers - Bounds: [min_instances, ).
    ///  Secondary workers - Bounds: [min_instances, ). Default: 0.
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public long? MaxInstances { get; set; }

    /// <summary>
    /// Optional. Minimum number of instances for this group.
    /// 
    ///  Primary workers - Bounds: [2, max_instances]. Default: 2.
    ///  Secondary workers - Bounds: [0, max_instances]. Default: 0.
    /// </summary>
    [JsonPropertyName("minInstances")]
    public long? MinInstances { get; set; }

    /// <summary>
    /// Optional. Weight for the instance group, which is used to determine the
    ///  fraction of total workers in the cluster from this instance group.
    ///  For example, if primary workers have weight 2, and secondary workers have
    ///  weight 1, the cluster will have approximately 2 primary workers for each
    ///  secondary worker.
    /// 
    ///  The cluster may not reach the specified balance if constrained
    ///  by min/max bounds or other autoscaling settings. For example, if
    ///  `max_instances` for secondary workers is 0, then only primary workers will
    ///  be added. The cluster can also be out of balance when created.
    /// 
    ///  If weight is not set on any instance group, the cluster will default to
    ///  equal weight for all groups: the cluster will attempt to maintain an equal
    ///  number of workers in each group within the configured size bounds for each
    ///  group. If weight is set for one group only, the cluster will default to
    ///  zero weight on the unset group. For example if weight is set only on
    ///  primary workers, the cluster will use primary workers only and no
    ///  secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>Immutable. Required. Describes how the autoscaler will operate for primary workers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicySpecWorkerConfig
{
    /// <summary>
    /// Required. Maximum number of instances for this group. Required for primary
    ///  workers. Note that by default, clusters will not use secondary workers.
    ///  Required for secondary workers if the minimum secondary instances is set.
    /// 
    ///  Primary workers - Bounds: [min_instances, ).
    ///  Secondary workers - Bounds: [min_instances, ). Default: 0.
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public required long MaxInstances { get; set; }

    /// <summary>
    /// Optional. Minimum number of instances for this group.
    /// 
    ///  Primary workers - Bounds: [2, max_instances]. Default: 2.
    ///  Secondary workers - Bounds: [0, max_instances]. Default: 0.
    /// </summary>
    [JsonPropertyName("minInstances")]
    public long? MinInstances { get; set; }

    /// <summary>
    /// Optional. Weight for the instance group, which is used to determine the
    ///  fraction of total workers in the cluster from this instance group.
    ///  For example, if primary workers have weight 2, and secondary workers have
    ///  weight 1, the cluster will have approximately 2 primary workers for each
    ///  secondary worker.
    /// 
    ///  The cluster may not reach the specified balance if constrained
    ///  by min/max bounds or other autoscaling settings. For example, if
    ///  `max_instances` for secondary workers is 0, then only primary workers will
    ///  be added. The cluster can also be out of balance when created.
    /// 
    ///  If weight is not set on any instance group, the cluster will default to
    ///  equal weight for all groups: the cluster will attempt to maintain an equal
    ///  number of workers in each group within the configured size bounds for each
    ///  group. If weight is set for one group only, the cluster will default to
    ///  zero weight on the unset group. For example if weight is set only on
    ///  primary workers, the cluster will use primary workers only and no
    ///  secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>DataprocAutoscalingPolicySpec defines the desired state of DataprocAutoscalingPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicySpec
{
    /// <summary>Immutable. Required. YARN autoscaling configuration.</summary>
    [JsonPropertyName("basicAlgorithm")]
    public required V1beta1DataprocAutoscalingPolicySpecBasicAlgorithm BasicAlgorithm { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1DataprocAutoscalingPolicySpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Optional. Describes how the autoscaler will operate for secondary workers.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta1DataprocAutoscalingPolicySpecSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>Immutable. Required. Describes how the autoscaler will operate for primary workers.</summary>
    [JsonPropertyName("workerConfig")]
    public required V1beta1DataprocAutoscalingPolicySpecWorkerConfig WorkerConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>DataprocAutoscalingPolicyStatus defines the config connector machine state of DataprocAutoscalingPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataprocAutoscalingPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataprocAutoscalingPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataprocAutoscalingPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary>DataprocAutoscalingPolicy is the Schema for the DataprocAutoscalingPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataprocAutoscalingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataprocAutoscalingPolicySpec>, IStatus<V1beta1DataprocAutoscalingPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataprocAutoscalingPolicy";
    public const string KubeGroup = "dataproc.cnrm.cloud.google.com";
    public const string KubePluralName = "dataprocautoscalingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataprocAutoscalingPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataprocAutoscalingPolicySpec defines the desired state of DataprocAutoscalingPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DataprocAutoscalingPolicySpec Spec { get; set; }

    /// <summary>DataprocAutoscalingPolicyStatus defines the config connector machine state of DataprocAutoscalingPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1DataprocAutoscalingPolicyStatus? Status { get; set; }
}