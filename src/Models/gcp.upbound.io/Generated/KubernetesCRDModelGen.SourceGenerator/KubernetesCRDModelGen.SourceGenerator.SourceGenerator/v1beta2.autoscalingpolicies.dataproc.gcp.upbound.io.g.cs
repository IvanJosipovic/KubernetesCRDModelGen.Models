#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.gcp.upbound.io;
/// <summary>AutoscalingPolicy is the Schema for the AutoscalingPolicys API. Describes an autoscaling policy for Dataproc cluster autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AutoscalingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2AutoscalingPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AutoscalingPolicyList";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "autoscalingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoscalingPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2AutoscalingPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2AutoscalingPolicy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AutoscalingPolicySpecDeletionPolicyEnum>))]
public enum V1beta2AutoscalingPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// YARN autoscaling configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecForProviderBasicAlgorithmYarnConfig
{
    /// <summary>
    /// Timeout for YARN graceful decommissioning of Node Managers. Specifies the
    /// duration to wait for jobs to complete before forcefully removing workers
    /// (and potentially interrupting jobs). Only applicable to downscaling operations.
    /// Bounds: [0s, 1d].
    /// </summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// remove workers. A scale-down factor of 1 will result in scaling down so that there
    /// is no available memory remaining after the update (more aggressive scaling).
    /// A scale-down factor of 0 disables removing workers, which can be beneficial for
    /// autoscaling a single job.
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleDownFactor")]
    public double? ScaleDownFactor { get; set; }

    /// <summary>
    /// Minimum scale-down threshold as a fraction of total cluster size before scaling occurs.
    /// For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler must
    /// recommend at least a 2 worker scale-down for the cluster to scale. A threshold of 0
    /// means the autoscaler will scale down on any recommended change.
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleDownMinWorkerFraction")]
    public double? ScaleDownMinWorkerFraction { get; set; }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// add workers. A scale-up factor of 1.0 will result in scaling up so that there
    /// is no pending memory remaining after the update (more aggressive scaling).
    /// A scale-up factor closer to 0 will result in a smaller magnitude of scaling up
    /// (less aggressive scaling).
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleUpFactor")]
    public double? ScaleUpFactor { get; set; }

    /// <summary>
    /// Minimum scale-up threshold as a fraction of total cluster size before scaling
    /// occurs. For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler
    /// must recommend at least a 2-worker scale-up for the cluster to scale. A threshold of
    /// 0 means the autoscaler will scale up on any recommended change.
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleUpMinWorkerFraction")]
    public double? ScaleUpMinWorkerFraction { get; set; }
}

/// <summary>
/// Basic algorithm for autoscaling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecForProviderBasicAlgorithm
{
    /// <summary>
    /// Duration between scaling events. A scaling period starts after the
    /// update operation from the previous event has completed.
    /// Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    [JsonPropertyName("cooldownPeriod")]
    public string? CooldownPeriod { get; set; }

    /// <summary>
    /// YARN autoscaling configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yarnConfig")]
    public V1beta2AutoscalingPolicySpecForProviderBasicAlgorithmYarnConfig? YarnConfig { get; set; }
}

/// <summary>
/// Describes how the autoscaler will operate for secondary workers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecForProviderSecondaryWorkerConfig
{
    /// <summary>
    /// Maximum number of instances for this group. Note that by default, clusters will not use
    /// secondary workers. Required for secondary workers if the minimum secondary instances is set.
    /// Bounds: [minInstances, ). Defaults to 0.
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Describes how the autoscaler will operate for primary workers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecForProviderWorkerConfig
{
    /// <summary>Maximum number of instances for this group.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecForProvider
{
    /// <summary>
    /// Basic algorithm for autoscaling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicAlgorithm")]
    public V1beta2AutoscalingPolicySpecForProviderBasicAlgorithm? BasicAlgorithm { get; set; }

    /// <summary>
    /// The  location where the autoscaling policy should reside.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Describes how the autoscaler will operate for secondary workers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta2AutoscalingPolicySpecForProviderSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>
    /// Describes how the autoscaler will operate for primary workers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2AutoscalingPolicySpecForProviderWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>
/// YARN autoscaling configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecInitProviderBasicAlgorithmYarnConfig
{
    /// <summary>
    /// Timeout for YARN graceful decommissioning of Node Managers. Specifies the
    /// duration to wait for jobs to complete before forcefully removing workers
    /// (and potentially interrupting jobs). Only applicable to downscaling operations.
    /// Bounds: [0s, 1d].
    /// </summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// remove workers. A scale-down factor of 1 will result in scaling down so that there
    /// is no available memory remaining after the update (more aggressive scaling).
    /// A scale-down factor of 0 disables removing workers, which can be beneficial for
    /// autoscaling a single job.
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleDownFactor")]
    public double? ScaleDownFactor { get; set; }

    /// <summary>
    /// Minimum scale-down threshold as a fraction of total cluster size before scaling occurs.
    /// For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler must
    /// recommend at least a 2 worker scale-down for the cluster to scale. A threshold of 0
    /// means the autoscaler will scale down on any recommended change.
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleDownMinWorkerFraction")]
    public double? ScaleDownMinWorkerFraction { get; set; }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// add workers. A scale-up factor of 1.0 will result in scaling up so that there
    /// is no pending memory remaining after the update (more aggressive scaling).
    /// A scale-up factor closer to 0 will result in a smaller magnitude of scaling up
    /// (less aggressive scaling).
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleUpFactor")]
    public double? ScaleUpFactor { get; set; }

    /// <summary>
    /// Minimum scale-up threshold as a fraction of total cluster size before scaling
    /// occurs. For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler
    /// must recommend at least a 2-worker scale-up for the cluster to scale. A threshold of
    /// 0 means the autoscaler will scale up on any recommended change.
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleUpMinWorkerFraction")]
    public double? ScaleUpMinWorkerFraction { get; set; }
}

/// <summary>
/// Basic algorithm for autoscaling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecInitProviderBasicAlgorithm
{
    /// <summary>
    /// Duration between scaling events. A scaling period starts after the
    /// update operation from the previous event has completed.
    /// Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    [JsonPropertyName("cooldownPeriod")]
    public string? CooldownPeriod { get; set; }

    /// <summary>
    /// YARN autoscaling configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yarnConfig")]
    public V1beta2AutoscalingPolicySpecInitProviderBasicAlgorithmYarnConfig? YarnConfig { get; set; }
}

/// <summary>
/// Describes how the autoscaler will operate for secondary workers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecInitProviderSecondaryWorkerConfig
{
    /// <summary>
    /// Maximum number of instances for this group. Note that by default, clusters will not use
    /// secondary workers. Required for secondary workers if the minimum secondary instances is set.
    /// Bounds: [minInstances, ). Defaults to 0.
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Describes how the autoscaler will operate for primary workers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecInitProviderWorkerConfig
{
    /// <summary>Maximum number of instances for this group.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
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
public partial class V1beta2AutoscalingPolicySpecInitProvider
{
    /// <summary>
    /// Basic algorithm for autoscaling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicAlgorithm")]
    public V1beta2AutoscalingPolicySpecInitProviderBasicAlgorithm? BasicAlgorithm { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Describes how the autoscaler will operate for secondary workers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta2AutoscalingPolicySpecInitProviderSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>
    /// Describes how the autoscaler will operate for primary workers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2AutoscalingPolicySpecInitProviderWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AutoscalingPolicySpecManagementPoliciesEnum>))]
public enum V1beta2AutoscalingPolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AutoscalingPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AutoscalingPolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AutoscalingPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AutoscalingPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AutoscalingPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AutoscalingPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AutoscalingPolicySpec defines the desired state of AutoscalingPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicySpec
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
    public V1beta2AutoscalingPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AutoscalingPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2AutoscalingPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AutoscalingPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AutoscalingPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AutoscalingPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// YARN autoscaling configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicyStatusAtProviderBasicAlgorithmYarnConfig
{
    /// <summary>
    /// Timeout for YARN graceful decommissioning of Node Managers. Specifies the
    /// duration to wait for jobs to complete before forcefully removing workers
    /// (and potentially interrupting jobs). Only applicable to downscaling operations.
    /// Bounds: [0s, 1d].
    /// </summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// remove workers. A scale-down factor of 1 will result in scaling down so that there
    /// is no available memory remaining after the update (more aggressive scaling).
    /// A scale-down factor of 0 disables removing workers, which can be beneficial for
    /// autoscaling a single job.
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleDownFactor")]
    public double? ScaleDownFactor { get; set; }

    /// <summary>
    /// Minimum scale-down threshold as a fraction of total cluster size before scaling occurs.
    /// For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler must
    /// recommend at least a 2 worker scale-down for the cluster to scale. A threshold of 0
    /// means the autoscaler will scale down on any recommended change.
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleDownMinWorkerFraction")]
    public double? ScaleDownMinWorkerFraction { get; set; }

    /// <summary>
    /// Fraction of average pending memory in the last cooldown period for which to
    /// add workers. A scale-up factor of 1.0 will result in scaling up so that there
    /// is no pending memory remaining after the update (more aggressive scaling).
    /// A scale-up factor closer to 0 will result in a smaller magnitude of scaling up
    /// (less aggressive scaling).
    /// Bounds: [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("scaleUpFactor")]
    public double? ScaleUpFactor { get; set; }

    /// <summary>
    /// Minimum scale-up threshold as a fraction of total cluster size before scaling
    /// occurs. For example, in a 20-worker cluster, a threshold of 0.1 means the autoscaler
    /// must recommend at least a 2-worker scale-up for the cluster to scale. A threshold of
    /// 0 means the autoscaler will scale up on any recommended change.
    /// Bounds: [0.0, 1.0]. Default: 0.0.
    /// </summary>
    [JsonPropertyName("scaleUpMinWorkerFraction")]
    public double? ScaleUpMinWorkerFraction { get; set; }
}

/// <summary>
/// Basic algorithm for autoscaling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicyStatusAtProviderBasicAlgorithm
{
    /// <summary>
    /// Duration between scaling events. A scaling period starts after the
    /// update operation from the previous event has completed.
    /// Bounds: [2m, 1d]. Default: 2m.
    /// </summary>
    [JsonPropertyName("cooldownPeriod")]
    public string? CooldownPeriod { get; set; }

    /// <summary>
    /// YARN autoscaling configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yarnConfig")]
    public V1beta2AutoscalingPolicyStatusAtProviderBasicAlgorithmYarnConfig? YarnConfig { get; set; }
}

/// <summary>
/// Describes how the autoscaler will operate for secondary workers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicyStatusAtProviderSecondaryWorkerConfig
{
    /// <summary>
    /// Maximum number of instances for this group. Note that by default, clusters will not use
    /// secondary workers. Required for secondary workers if the minimum secondary instances is set.
    /// Bounds: [minInstances, ). Defaults to 0.
    /// </summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances for this group. Bounds: [0, maxInstances]. Defaults to 0.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Describes how the autoscaler will operate for primary workers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicyStatusAtProviderWorkerConfig
{
    /// <summary>Maximum number of instances for this group.</summary>
    [JsonPropertyName("maxInstances")]
    public double? MaxInstances { get; set; }

    /// <summary>Minimum number of instances for this group. Bounds: [2, maxInstances]. Defaults to 2.</summary>
    [JsonPropertyName("minInstances")]
    public double? MinInstances { get; set; }

    /// <summary>
    /// Weight for the instance group, which is used to determine the fraction of total workers
    /// in the cluster from this instance group. For example, if primary workers have weight 2,
    /// and secondary workers have weight 1, the cluster will have approximately 2 primary workers
    /// for each secondary worker.
    /// The cluster may not reach the specified balance if constrained by min/max bounds or other
    /// autoscaling settings. For example, if maxInstances for secondary workers is 0, then only
    /// primary workers will be added. The cluster can also be out of balance when created.
    /// If weight is not set on any instance group, the cluster will default to equal weight for
    /// all groups: the cluster will attempt to maintain an equal number of workers in each group
    /// within the configured size bounds for each group. If weight is set for one group only,
    /// the cluster will default to zero weight on the unset group. For example if weight is set
    /// only on primary workers, the cluster will use primary workers only and no secondary workers.
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicyStatusAtProvider
{
    /// <summary>
    /// Basic algorithm for autoscaling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("basicAlgorithm")]
    public V1beta2AutoscalingPolicyStatusAtProviderBasicAlgorithm? BasicAlgorithm { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/autoscalingPolicies/{{policy_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The  location where the autoscaling policy should reside.
    /// The default value is global.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The &quot;resource name&quot; of the autoscaling policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Describes how the autoscaler will operate for secondary workers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta2AutoscalingPolicyStatusAtProviderSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>
    /// Describes how the autoscaler will operate for primary workers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2AutoscalingPolicyStatusAtProviderWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicyStatusConditions
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

/// <summary>AutoscalingPolicyStatus defines the observed state of AutoscalingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AutoscalingPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AutoscalingPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AutoscalingPolicy is the Schema for the AutoscalingPolicys API. Describes an autoscaling policy for Dataproc cluster autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AutoscalingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AutoscalingPolicySpec>, IStatus<V1beta2AutoscalingPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AutoscalingPolicy";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "autoscalingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutoscalingPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AutoscalingPolicySpec defines the desired state of AutoscalingPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AutoscalingPolicySpec Spec { get; set; }

    /// <summary>AutoscalingPolicyStatus defines the observed state of AutoscalingPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2AutoscalingPolicyStatus? Status { get; set; }
}