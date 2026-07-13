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
/// <summary>Cluster is the Schema for the Clusters API. Manages a Cloud Dataproc cluster resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Cluster>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Cluster> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecDeletionPolicyEnum>))]
public enum V1beta2ClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The autoscaling policy config associated with the cluster.
/// Note that once set, if autoscaling_config is the only field set in cluster_config, it can
/// only be removed by setting policy_uri = &quot; &quot;, rather than removing the whole block.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster.</summary>
    [JsonPropertyName("policyUri")]
    public string? PolicyUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The node group instance group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance.
    /// The instance may be scheduled on the specified or a newer CPU platform.
    /// Specify the friendly names of CPU platforms, such as &quot;Intel Haswell&quot; or &quot;Intel Sandy Bridge&quot;.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Specifies the number of master nodes to create.
    /// Please set a number greater than 0. Node Group must have at least 1 instance.
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroup
{
    /// <summary>The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig? NodeGroupConfig { get; set; }

    /// <summary>
    /// The roles associated with the GKE node pool.
    /// One of &quot;DEFAULT&quot;, &quot;CONTROLLER&quot;, &quot;SPARK_DRIVER&quot; or &quot;SPARK_EXECUTOR&quot;.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroups
{
    /// <summary>Node group configuration.</summary>
    [JsonPropertyName("nodeGroup")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroupsNodeGroup>? NodeGroup { get; set; }

    [JsonPropertyName("nodeGroupId")]
    public string? NodeGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigDataprocMetricConfigMetrics
{
    /// <summary>One or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect for the metric course.</summary>
    [JsonPropertyName("metricOverrides")]
    public IList<string>? MetricOverrides { get; set; }

    /// <summary>A source for the collection of Dataproc OSS metrics (see available OSS metrics).</summary>
    [JsonPropertyName("metricSource")]
    public string? MetricSource { get; set; }
}

/// <summary>
/// The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigDataprocMetricConfig
{
    /// <summary>Metrics sources to enable.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigDataprocMetricConfigMetrics>? Metrics { get; set; }
}

/// <summary>
/// The Customer managed encryption keys settings for the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigEncryptionConfig
{
    /// <summary>
    /// The Cloud KMS key name to use for PD disk encryption for
    /// all instances in the cluster.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// The config settings for port access on the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigEndpointConfig
{
    /// <summary>
    /// The flag to enable http access to specific ports
    /// on the cluster from external sources (aka Component Gateway). Defaults to false.
    /// </summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}

/// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigConfidentialInstanceConfig
{
    /// <summary>Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Node Group Affinity for sole-tenant clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>The URI of a sole-tenant node group resource that the cluster will be created on.</summary>
    [JsonPropertyName("nodeGroupUri")]
    public string? NodeGroupUri { get; set; }
}

/// <summary>Reservation Affinity for consuming zonal reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelector
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
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>
/// Common config settings for resources of Google Compute Engine cluster
/// instances, applicable to all instances in the cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigGceClusterConfig
{
    /// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>
    /// By default, clusters are not restricted to internal IP addresses,
    /// and will have ephemeral external IP addresses assigned to each instance. If set to true, all
    /// instances in the cluster will only have internal IP addresses. Note: Private Google Access
    /// (also known as privateIpGoogleAccess) must be enabled on the subnetwork that the cluster
    /// will be launched in.
    /// </summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>
    /// A map of the Compute Engine metadata entries to add to all instances
    /// (see Project and instance metadata).
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine
    /// network to the cluster will be part of. Conflicts with subnetwork.
    /// If neither is specified, this defaults to the &quot;default&quot; network.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigNodeGroupAffinity? NodeGroupAffinity { get; set; }

    /// <summary>Reservation Affinity for consuming zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>
    /// The service account to be used by the Node VMs.
    /// If not specified, the &quot;default&quot; service account is used.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>
    /// The set of Google API scopes
    /// to be made available on all of the node VMs under the service_account
    /// specified. Both OAuth2 URLs and gcloud
    /// short names are supported. To allow full access to all Cloud APIs, use the
    /// cloud-platform scope. See a complete list of scopes here.
    /// </summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine
    /// subnetwork the cluster will be part of. Conflicts with network.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>
    /// The list of instance tags applied to instances in the cluster.
    /// Tags are used to identify valid sources or targets for network firewalls.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// The GCP zone where your data is stored and used (i.e. where
    /// the master and the worker nodes will be created in). If region is set to &apos;global&apos; (default)
    /// then zone is mandatory, otherwise GCP is able to make use of Auto Zone Placement
    /// to determine this automatically for you.
    /// Note: This setting additionally determines and restricts
    /// which computing resources are available for use with other configs such as
    /// cluster_config.master_config.machine_type and cluster_config.worker_config.machine_type.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigInitializationAction
{
    /// <summary>
    /// The script to be executed during initialization of the cluster.
    /// The script must be a GCS file with a gs:// prefix.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>
    /// The maximum duration (in seconds) which script is
    /// allowed to take to execute its action. GCP will default to a predetermined
    /// computed value if not set (currently 300).
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}

/// <summary>
/// The settings for auto deletion cluster schedule.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigLifecycleConfig
{
    /// <summary>
    /// The time when cluster will be auto-deleted.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds.
    /// Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>
    /// The duration to keep the cluster alive while idling
    /// (no jobs running). After this TTL, the cluster will be deleted. Valid range: [10m, 14d].
    /// </summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigMasterConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the master instances
/// in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigMasterConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>
    /// The URI for the image to use for this worker.  See the guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type
    /// to create for the master. If not specified, GCP will default to a predetermined
    /// computed value (currently n1-standard-4).
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The name of a minimum generation of CPU family
    /// for the master. If not specified, GCP will default to a predetermined computed value
    /// for each zone. See the guide
    /// for details about which CPU families are available (and defaulted) for each zone.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Specifies the number of master nodes to create.
    /// If not specified, GCP will default to a predetermined computed value (currently 1).
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

/// <summary>
/// The config setting for metastore service with the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList
{
    /// <summary>Full machine-type names, e.g. &quot;n1-standard-16&quot;.</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>Preference of this instance selection. A lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}

/// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix
{
    /// <summary>The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need. Dataproc will create only standard VMs until it reaches standardCapacityBase, then it will start using standardCapacityPercentAboveBase to mix Spot with Standard VMs. eg. If 15 instances are requested and standardCapacityBase is 5, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances.</summary>
    [JsonPropertyName("standardCapacityBase")]
    public double? StandardCapacityBase { get; set; }

    /// <summary>The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs. The percentage applies only to the capacity above standardCapacityBase. eg. If 15 instances are requested and standardCapacityBase is 5 and standardCapacityPercentAboveBase is 30, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances. The mix will be 30% standard and 70% spot.</summary>
    [JsonPropertyName("standardCapacityPercentAboveBase")]
    public double? StandardCapacityPercentAboveBase { get; set; }
}

/// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy
{
    /// <summary>List of instance selection options that the group will use when creating new VMs.</summary>
    [JsonPropertyName("instanceSelectionList")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList>? InstanceSelectionList { get; set; }

    /// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
    [JsonPropertyName("provisioningModelMix")]
    public V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix? ProvisioningModelMix { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the additional
/// instances in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfig
{
    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary>
    /// Specifies the number of preemptible nodes to create.
    /// Defaults to 0.
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>
    /// Specifies the preemptibility of the secondary workers. The default value is PREEMPTIBLE
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>
/// Identity Configuration. At least one of identity_config
/// or kerberos_config is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigSecurityConfigIdentityConfig
{
    /// <summary>
    /// The end user to service account mappings
    /// in a service account based multi-tenant cluster
    /// </summary>
    [JsonPropertyName("userServiceAccountMapping")]
    public IDictionary<string, string>? UserServiceAccountMapping { get; set; }
}

/// <summary>
/// Kerberos Configuration. At least one of identity_config
/// or kerberos_config is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>
    /// The admin server (IP or hostname) for the
    /// remote trusted realm in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>
    /// The KDC (IP or hostname) for the
    /// remote trusted realm in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>
    /// The remote realm the Dataproc on-cluster KDC will
    /// trust, should the user enable cross realm trust.
    /// </summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS
    /// encrypted file containing the shared password between the on-cluster Kerberos realm
    /// and the remote trusted realm, in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustSharedPasswordUri")]
    public string? CrossRealmTrustSharedPasswordUri { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the master key of the KDC database.
    /// </summary>
    [JsonPropertyName("kdcDbKeyUri")]
    public string? KdcDbKeyUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the password to the user provided key. For the self-signed certificate, this password
    /// is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("keyPasswordUri")]
    public string? KeyPasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the password to the user provided keystore. For the self-signed certificated, the password
    /// is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("keystorePasswordUri")]
    public string? KeystorePasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of the keystore file used for SSL encryption.
    /// If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    [JsonPropertyName("keystoreUri")]
    public string? KeystoreUri { get; set; }

    /// <summary>The URI of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKeyUri")]
    public string? KmsKeyUri { get; set; }

    /// <summary>
    /// The name of the on-cluster Kerberos realm. If not specified, the
    /// uppercased domain of hostnames will be the realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file
    /// containing the root principal password.
    /// </summary>
    [JsonPropertyName("rootPrincipalPasswordUri")]
    public string? RootPrincipalPasswordUri { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file
    /// containing the password to the user provided truststore. For the self-signed
    /// certificate, this password is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("truststorePasswordUri")]
    public string? TruststorePasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of the truststore file used for
    /// SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }
}

/// <summary>Security related configuration. Structure defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigSecurityConfig
{
    /// <summary>
    /// Identity Configuration. At least one of identity_config
    /// or kerberos_config is required.
    /// </summary>
    [JsonPropertyName("identityConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigSecurityConfigIdentityConfig? IdentityConfig { get; set; }

    /// <summary>
    /// Kerberos Configuration. At least one of identity_config
    /// or kerberos_config is required.
    /// </summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigSecurityConfigKerberosConfig? KerberosConfig { get; set; }
}

/// <summary>
/// The config settings for software inside the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigSoftwareConfig
{
    /// <summary>
    /// The Cloud Dataproc image version to use
    /// for the cluster - this controls the sets of software versions
    /// installed onto the nodes when you create clusters. If not specified, defaults to the
    /// latest version. For a list of valid versions see
    /// Cloud Dataproc versions
    /// </summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of optional components to activate on the cluster. See Available Optional Components.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>
    /// A list of override and additional properties (key/value pairs)
    /// used to modify various aspects of the common configuration files used when creating
    /// a cluster. For a list of valid properties please see
    /// Cluster properties
    /// </summary>
    [JsonPropertyName("overrideProperties")]
    public IDictionary<string, string>? OverrideProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigWorkerConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the worker instances
/// in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>
    /// The URI for the image to use for this worker.  See the guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type
    /// to create for the worker nodes. If not specified, GCP will default to a predetermined
    /// computed value (currently n1-standard-4).
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The name of a minimum generation of CPU family
    /// for the master. If not specified, GCP will default to a predetermined computed value
    /// for each zone. See the guide
    /// for details about which CPU families are available (and defaulted) for each zone.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The minimum number of primary worker instances to create.  If min_num_instances is set, cluster creation will succeed if the number of primary workers created is at least equal to the min_num_instances number.</summary>
    [JsonPropertyName("minNumInstances")]
    public double? MinNumInstances { get; set; }

    /// <summary>
    /// Specifies the number of worker nodes to create.
    /// If not specified, GCP will default to a predetermined computed value (currently 2).
    /// There is currently a beta feature which allows you to run a
    /// Single Node Cluster.
    /// In order to take advantage of this you need to set
    /// &quot;dataproc:dataproc.allow.zero.workers&quot; = &quot;true&quot; in
    /// cluster_config.software_config.properties
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

/// <summary>
/// Allows you to configure various aspects of the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderClusterConfig
{
    /// <summary>
    /// The autoscaling policy config associated with the cluster.
    /// Note that once set, if autoscaling_config is the only field set in cluster_config, it can
    /// only be removed by setting policy_uri = &quot; &quot;, rather than removing the whole block.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// A Dataproc NodeGroup resource is a group of Dataproc cluster nodes that execute an assigned role.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("auxiliaryNodeGroups")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigAuxiliaryNodeGroups>? AuxiliaryNodeGroups { get; set; }

    /// <summary>The tier of the cluster.</summary>
    [JsonPropertyName("clusterTier")]
    public string? ClusterTier { get; set; }

    /// <summary>
    /// The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("dataprocMetricConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigDataprocMetricConfig? DataprocMetricConfig { get; set; }

    /// <summary>
    /// The Customer managed encryption keys settings for the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// The config settings for port access on the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary>
    /// Common config settings for resources of Google Compute Engine cluster
    /// instances, applicable to all instances in the cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("gceClusterConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigGceClusterConfig? GceClusterConfig { get; set; }

    /// <summary>
    /// Commands to execute on each node after config is completed.
    /// You can specify multiple versions of these. Structure defined below.
    /// </summary>
    [JsonPropertyName("initializationAction")]
    public IList<V1beta2ClusterSpecForProviderClusterConfigInitializationAction>? InitializationAction { get; set; }

    /// <summary>
    /// The settings for auto deletion cluster schedule.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the master instances
    /// in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("masterConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigMasterConfig? MasterConfig { get; set; }

    /// <summary>
    /// The config setting for metastore service with the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the additional
    /// instances in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("preemptibleWorkerConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigPreemptibleWorkerConfig? PreemptibleWorkerConfig { get; set; }

    /// <summary>Security related configuration. Structure defined below.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>
    /// The config settings for software inside the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files,
    /// such as Hadoop jars, between client machines and the cluster.
    /// Note: If you don&apos;t explicitly specify a staging_bucket
    /// then GCP will auto create / assign one for you. However, you are not guaranteed
    /// an auto generated bucket which is solely dedicated to your cluster; it may be shared
    /// with other clusters in the same region/zone also choosing to use the auto generation
    /// option.
    /// </summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>
    /// The Cloud Storage temp bucket used to store ephemeral cluster
    /// and jobs data, such as Spark and MapReduce history files.
    /// Note: If you don&apos;t explicitly specify a temp_bucket then GCP will auto create / assign one for you.
    /// </summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the worker instances
    /// in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2ClusterSpecForProviderClusterConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>
/// The config setting for metastore service with the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}

/// <summary>The Spark History Server configuration for the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}

/// <summary>
/// Configuration of auxiliary services used by this cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfig
{
    /// <summary>
    /// The config setting for metastore service with the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

/// <summary>
/// The autoscaler configuration for this node pool.
/// The autoscaler is enabled only when a valid configuration is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling
{
    /// <summary>The maximum number of nodes in the node pool. Must be &gt;= minNodeCount, and must be &gt; 0.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes in the node pool. Must be &gt;= 0 and &lt;= maxNodeCount.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>The node pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig
{
    /// <summary>
    /// The number of local SSD disks to attach to the node,
    /// which is limited by the maximum number of disks allowable per zone.
    /// </summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance.
    /// The instance may be scheduled on the specified or a newer CPU platform.
    /// Specify the friendly names of CPU platforms, such as &quot;Intel Haswell&quot; or &quot;Intel Sandy Bridge&quot;.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// Preemptible nodes cannot be used in a node pool with the CONTROLLER role or in the DEFAULT node pool if the
    /// CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).
    /// </summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Spot flag for enabling Spot VM, which is a rebrand of the existing preemptible flag.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}

/// <summary>
/// (Input only) The configuration for the GKE node pool.
/// If specified, Dataproc attempts to create a node pool with the specified shape.
/// If one with the same name already exists, it is verified against all specified fields.
/// If a field differs, the virtual cluster creation will fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig
{
    /// <summary>
    /// The autoscaler configuration for this node pool.
    /// The autoscaler is enabled only when a valid configuration is present.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling? Autoscaling { get; set; }

    /// <summary>The node pool configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig? Config { get; set; }

    /// <summary>
    /// The list of Compute Engine zones where node pool nodes associated
    /// with a Dataproc on GKE virtual cluster will be located.
    /// </summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget
{
    /// <summary>The target GKE node pool.</summary>
    [JsonPropertyName("nodePool")]
    public string? NodePool { get; set; }

    /// <summary>
    /// (Input only) The configuration for the GKE node pool.
    /// If specified, Dataproc attempts to create a node pool with the specified shape.
    /// If one with the same name already exists, it is verified against all specified fields.
    /// If a field differs, the virtual cluster creation will fail.
    /// </summary>
    [JsonPropertyName("nodePoolConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig? NodePoolConfig { get; set; }

    /// <summary>
    /// The roles associated with the GKE node pool.
    /// One of &quot;DEFAULT&quot;, &quot;CONTROLLER&quot;, &quot;SPARK_DRIVER&quot; or &quot;SPARK_EXECUTOR&quot;.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

/// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig
{
    /// <summary>
    /// A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster
    /// (the GKE cluster can be zonal or regional)
    /// </summary>
    [JsonPropertyName("gkeClusterTarget")]
    public string? GkeClusterTarget { get; set; }

    /// <summary>
    /// GKE node pools where workloads will be scheduled. At least one node pool must be assigned the DEFAULT
    /// GkeNodePoolTarget.Role. If a GkeNodePoolTarget is not specified, Dataproc constructs a DEFAULT GkeNodePoolTarget.
    /// Each role can be given to only one GkeNodePoolTarget. All node pools must have the same location settings.
    /// </summary>
    [JsonPropertyName("nodePoolTarget")]
    public IList<V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget>? NodePoolTarget { get; set; }
}

/// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig
{
    /// <summary>
    /// The components that should be installed in this Dataproc cluster. The key must be a string from the
    /// KubernetesComponent enumeration. The value is the version of the software to be installed. At least one entry must be specified.
    /// </summary>
    [JsonPropertyName("componentVersion")]
    public IDictionary<string, string>? ComponentVersion { get; set; }

    /// <summary>
    /// The properties to set on daemon config files. Property keys are specified in prefix:property format,
    /// for example spark:spark.kubernetes.container.image.
    /// </summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>
/// The configuration for running the Dataproc cluster on Kubernetes.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfig
{
    /// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
    [JsonPropertyName("gkeClusterConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig? GkeClusterConfig { get; set; }

    /// <summary>
    /// A namespace within the Kubernetes cluster to deploy into.
    /// If this namespace does not exist, it is created.
    /// If it  exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it.
    /// If not specified, the name of the Dataproc Cluster is used.
    /// </summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
    [JsonPropertyName("kubernetesSoftwareConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig? KubernetesSoftwareConfig { get; set; }
}

/// <summary>
/// Allows you to configure a virtual Dataproc on GKE cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProviderVirtualClusterConfig
{
    /// <summary>
    /// Configuration of auxiliary services used by this cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("auxiliaryServicesConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigAuxiliaryServicesConfig? AuxiliaryServicesConfig { get; set; }

    /// <summary>
    /// The configuration for running the Dataproc cluster on Kubernetes.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("kubernetesClusterConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfigKubernetesClusterConfig? KubernetesClusterConfig { get; set; }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files,
    /// such as Hadoop jars, between client machines and the cluster.
    /// Note: If you don&apos;t explicitly specify a staging_bucket
    /// then GCP will auto create / assign one for you. However, you are not guaranteed
    /// an auto generated bucket which is solely dedicated to your cluster; it may be shared
    /// with other clusters in the same region/zone also choosing to use the auto generation
    /// option.
    /// </summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecForProvider
{
    /// <summary>
    /// Allows you to configure various aspects of the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2ClusterSpecForProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>
    /// Does not affect auto scaling decomissioning from an autoscaling policy.
    /// Graceful decommissioning allows removing nodes from the cluster without interrupting jobs in progress.
    /// Timeout specifies how long to wait for jobs in progress to finish before forcefully removing nodes (and potentially interrupting jobs).
    /// Default timeout is 0 (for forceful decommission), and the maximum allowed timeout is 1 day. (see JSON representation of
    /// Duration).
    /// Only supported on Dataproc image versions 1.2 and higher.
    /// For more context see the docs
    /// </summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary>Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and
    /// zone.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the cluster will exist. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The region in which the cluster and associated nodes will be created in.
    /// Defaults to global.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Allows you to configure a virtual Dataproc on GKE cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("virtualClusterConfig")]
    public V1beta2ClusterSpecForProviderVirtualClusterConfig? VirtualClusterConfig { get; set; }
}

/// <summary>
/// The autoscaling policy config associated with the cluster.
/// Note that once set, if autoscaling_config is the only field set in cluster_config, it can
/// only be removed by setting policy_uri = &quot; &quot;, rather than removing the whole block.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster.</summary>
    [JsonPropertyName("policyUri")]
    public string? PolicyUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The node group instance group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance.
    /// The instance may be scheduled on the specified or a newer CPU platform.
    /// Specify the friendly names of CPU platforms, such as &quot;Intel Haswell&quot; or &quot;Intel Sandy Bridge&quot;.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Specifies the number of master nodes to create.
    /// Please set a number greater than 0. Node Group must have at least 1 instance.
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroup
{
    /// <summary>The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig? NodeGroupConfig { get; set; }

    /// <summary>
    /// The roles associated with the GKE node pool.
    /// One of &quot;DEFAULT&quot;, &quot;CONTROLLER&quot;, &quot;SPARK_DRIVER&quot; or &quot;SPARK_EXECUTOR&quot;.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroups
{
    /// <summary>Node group configuration.</summary>
    [JsonPropertyName("nodeGroup")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroupsNodeGroup>? NodeGroup { get; set; }

    [JsonPropertyName("nodeGroupId")]
    public string? NodeGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigDataprocMetricConfigMetrics
{
    /// <summary>One or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect for the metric course.</summary>
    [JsonPropertyName("metricOverrides")]
    public IList<string>? MetricOverrides { get; set; }

    /// <summary>A source for the collection of Dataproc OSS metrics (see available OSS metrics).</summary>
    [JsonPropertyName("metricSource")]
    public string? MetricSource { get; set; }
}

/// <summary>
/// The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigDataprocMetricConfig
{
    /// <summary>Metrics sources to enable.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigDataprocMetricConfigMetrics>? Metrics { get; set; }
}

/// <summary>
/// The Customer managed encryption keys settings for the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigEncryptionConfig
{
    /// <summary>
    /// The Cloud KMS key name to use for PD disk encryption for
    /// all instances in the cluster.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// The config settings for port access on the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigEndpointConfig
{
    /// <summary>
    /// The flag to enable http access to specific ports
    /// on the cluster from external sources (aka Component Gateway). Defaults to false.
    /// </summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}

/// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigConfidentialInstanceConfig
{
    /// <summary>Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Node Group Affinity for sole-tenant clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>The URI of a sole-tenant node group resource that the cluster will be created on.</summary>
    [JsonPropertyName("nodeGroupUri")]
    public string? NodeGroupUri { get; set; }
}

/// <summary>Reservation Affinity for consuming zonal reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelector
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
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>
/// Common config settings for resources of Google Compute Engine cluster
/// instances, applicable to all instances in the cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfig
{
    /// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>
    /// By default, clusters are not restricted to internal IP addresses,
    /// and will have ephemeral external IP addresses assigned to each instance. If set to true, all
    /// instances in the cluster will only have internal IP addresses. Note: Private Google Access
    /// (also known as privateIpGoogleAccess) must be enabled on the subnetwork that the cluster
    /// will be launched in.
    /// </summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>
    /// A map of the Compute Engine metadata entries to add to all instances
    /// (see Project and instance metadata).
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine
    /// network to the cluster will be part of. Conflicts with subnetwork.
    /// If neither is specified, this defaults to the &quot;default&quot; network.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigNodeGroupAffinity? NodeGroupAffinity { get; set; }

    /// <summary>Reservation Affinity for consuming zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>
    /// The service account to be used by the Node VMs.
    /// If not specified, the &quot;default&quot; service account is used.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>
    /// The set of Google API scopes
    /// to be made available on all of the node VMs under the service_account
    /// specified. Both OAuth2 URLs and gcloud
    /// short names are supported. To allow full access to all Cloud APIs, use the
    /// cloud-platform scope. See a complete list of scopes here.
    /// </summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine
    /// subnetwork the cluster will be part of. Conflicts with network.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>
    /// The list of instance tags applied to instances in the cluster.
    /// Tags are used to identify valid sources or targets for network firewalls.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// The GCP zone where your data is stored and used (i.e. where
    /// the master and the worker nodes will be created in). If region is set to &apos;global&apos; (default)
    /// then zone is mandatory, otherwise GCP is able to make use of Auto Zone Placement
    /// to determine this automatically for you.
    /// Note: This setting additionally determines and restricts
    /// which computing resources are available for use with other configs such as
    /// cluster_config.master_config.machine_type and cluster_config.worker_config.machine_type.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigInitializationAction
{
    /// <summary>
    /// The script to be executed during initialization of the cluster.
    /// The script must be a GCS file with a gs:// prefix.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>
    /// The maximum duration (in seconds) which script is
    /// allowed to take to execute its action. GCP will default to a predetermined
    /// computed value if not set (currently 300).
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}

/// <summary>
/// The settings for auto deletion cluster schedule.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigLifecycleConfig
{
    /// <summary>
    /// The time when cluster will be auto-deleted.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds.
    /// Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>
    /// The duration to keep the cluster alive while idling
    /// (no jobs running). After this TTL, the cluster will be deleted. Valid range: [10m, 14d].
    /// </summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigMasterConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the master instances
/// in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigMasterConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>
    /// The URI for the image to use for this worker.  See the guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type
    /// to create for the master. If not specified, GCP will default to a predetermined
    /// computed value (currently n1-standard-4).
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The name of a minimum generation of CPU family
    /// for the master. If not specified, GCP will default to a predetermined computed value
    /// for each zone. See the guide
    /// for details about which CPU families are available (and defaulted) for each zone.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Specifies the number of master nodes to create.
    /// If not specified, GCP will default to a predetermined computed value (currently 1).
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

/// <summary>
/// The config setting for metastore service with the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList
{
    /// <summary>Full machine-type names, e.g. &quot;n1-standard-16&quot;.</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>Preference of this instance selection. A lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}

/// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix
{
    /// <summary>The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need. Dataproc will create only standard VMs until it reaches standardCapacityBase, then it will start using standardCapacityPercentAboveBase to mix Spot with Standard VMs. eg. If 15 instances are requested and standardCapacityBase is 5, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances.</summary>
    [JsonPropertyName("standardCapacityBase")]
    public double? StandardCapacityBase { get; set; }

    /// <summary>The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs. The percentage applies only to the capacity above standardCapacityBase. eg. If 15 instances are requested and standardCapacityBase is 5 and standardCapacityPercentAboveBase is 30, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances. The mix will be 30% standard and 70% spot.</summary>
    [JsonPropertyName("standardCapacityPercentAboveBase")]
    public double? StandardCapacityPercentAboveBase { get; set; }
}

/// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy
{
    /// <summary>List of instance selection options that the group will use when creating new VMs.</summary>
    [JsonPropertyName("instanceSelectionList")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList>? InstanceSelectionList { get; set; }

    /// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
    [JsonPropertyName("provisioningModelMix")]
    public V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix? ProvisioningModelMix { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the additional
/// instances in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfig
{
    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary>
    /// Specifies the number of preemptible nodes to create.
    /// Defaults to 0.
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>
    /// Specifies the preemptibility of the secondary workers. The default value is PREEMPTIBLE
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>
/// Identity Configuration. At least one of identity_config
/// or kerberos_config is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigSecurityConfigIdentityConfig
{
    /// <summary>
    /// The end user to service account mappings
    /// in a service account based multi-tenant cluster
    /// </summary>
    [JsonPropertyName("userServiceAccountMapping")]
    public IDictionary<string, string>? UserServiceAccountMapping { get; set; }
}

/// <summary>
/// Kerberos Configuration. At least one of identity_config
/// or kerberos_config is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>
    /// The admin server (IP or hostname) for the
    /// remote trusted realm in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>
    /// The KDC (IP or hostname) for the
    /// remote trusted realm in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>
    /// The remote realm the Dataproc on-cluster KDC will
    /// trust, should the user enable cross realm trust.
    /// </summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS
    /// encrypted file containing the shared password between the on-cluster Kerberos realm
    /// and the remote trusted realm, in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustSharedPasswordUri")]
    public string? CrossRealmTrustSharedPasswordUri { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the master key of the KDC database.
    /// </summary>
    [JsonPropertyName("kdcDbKeyUri")]
    public string? KdcDbKeyUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the password to the user provided key. For the self-signed certificate, this password
    /// is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("keyPasswordUri")]
    public string? KeyPasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the password to the user provided keystore. For the self-signed certificated, the password
    /// is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("keystorePasswordUri")]
    public string? KeystorePasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of the keystore file used for SSL encryption.
    /// If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    [JsonPropertyName("keystoreUri")]
    public string? KeystoreUri { get; set; }

    /// <summary>The URI of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKeyUri")]
    public string? KmsKeyUri { get; set; }

    /// <summary>
    /// The name of the on-cluster Kerberos realm. If not specified, the
    /// uppercased domain of hostnames will be the realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file
    /// containing the root principal password.
    /// </summary>
    [JsonPropertyName("rootPrincipalPasswordUri")]
    public string? RootPrincipalPasswordUri { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file
    /// containing the password to the user provided truststore. For the self-signed
    /// certificate, this password is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("truststorePasswordUri")]
    public string? TruststorePasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of the truststore file used for
    /// SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }
}

/// <summary>Security related configuration. Structure defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigSecurityConfig
{
    /// <summary>
    /// Identity Configuration. At least one of identity_config
    /// or kerberos_config is required.
    /// </summary>
    [JsonPropertyName("identityConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigSecurityConfigIdentityConfig? IdentityConfig { get; set; }

    /// <summary>
    /// Kerberos Configuration. At least one of identity_config
    /// or kerberos_config is required.
    /// </summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigSecurityConfigKerberosConfig? KerberosConfig { get; set; }
}

/// <summary>
/// The config settings for software inside the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigSoftwareConfig
{
    /// <summary>
    /// The Cloud Dataproc image version to use
    /// for the cluster - this controls the sets of software versions
    /// installed onto the nodes when you create clusters. If not specified, defaults to the
    /// latest version. For a list of valid versions see
    /// Cloud Dataproc versions
    /// </summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of optional components to activate on the cluster. See Available Optional Components.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>
    /// A list of override and additional properties (key/value pairs)
    /// used to modify various aspects of the common configuration files used when creating
    /// a cluster. For a list of valid properties please see
    /// Cluster properties
    /// </summary>
    [JsonPropertyName("overrideProperties")]
    public IDictionary<string, string>? OverrideProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigWorkerConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the worker instances
/// in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>
    /// The URI for the image to use for this worker.  See the guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type
    /// to create for the worker nodes. If not specified, GCP will default to a predetermined
    /// computed value (currently n1-standard-4).
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The name of a minimum generation of CPU family
    /// for the master. If not specified, GCP will default to a predetermined computed value
    /// for each zone. See the guide
    /// for details about which CPU families are available (and defaulted) for each zone.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The minimum number of primary worker instances to create.  If min_num_instances is set, cluster creation will succeed if the number of primary workers created is at least equal to the min_num_instances number.</summary>
    [JsonPropertyName("minNumInstances")]
    public double? MinNumInstances { get; set; }

    /// <summary>
    /// Specifies the number of worker nodes to create.
    /// If not specified, GCP will default to a predetermined computed value (currently 2).
    /// There is currently a beta feature which allows you to run a
    /// Single Node Cluster.
    /// In order to take advantage of this you need to set
    /// &quot;dataproc:dataproc.allow.zero.workers&quot; = &quot;true&quot; in
    /// cluster_config.software_config.properties
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

/// <summary>
/// Allows you to configure various aspects of the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderClusterConfig
{
    /// <summary>
    /// The autoscaling policy config associated with the cluster.
    /// Note that once set, if autoscaling_config is the only field set in cluster_config, it can
    /// only be removed by setting policy_uri = &quot; &quot;, rather than removing the whole block.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// A Dataproc NodeGroup resource is a group of Dataproc cluster nodes that execute an assigned role.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("auxiliaryNodeGroups")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigAuxiliaryNodeGroups>? AuxiliaryNodeGroups { get; set; }

    /// <summary>The tier of the cluster.</summary>
    [JsonPropertyName("clusterTier")]
    public string? ClusterTier { get; set; }

    /// <summary>
    /// The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("dataprocMetricConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigDataprocMetricConfig? DataprocMetricConfig { get; set; }

    /// <summary>
    /// The Customer managed encryption keys settings for the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// The config settings for port access on the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary>
    /// Common config settings for resources of Google Compute Engine cluster
    /// instances, applicable to all instances in the cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("gceClusterConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigGceClusterConfig? GceClusterConfig { get; set; }

    /// <summary>
    /// Commands to execute on each node after config is completed.
    /// You can specify multiple versions of these. Structure defined below.
    /// </summary>
    [JsonPropertyName("initializationAction")]
    public IList<V1beta2ClusterSpecInitProviderClusterConfigInitializationAction>? InitializationAction { get; set; }

    /// <summary>
    /// The settings for auto deletion cluster schedule.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the master instances
    /// in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("masterConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigMasterConfig? MasterConfig { get; set; }

    /// <summary>
    /// The config setting for metastore service with the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the additional
    /// instances in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("preemptibleWorkerConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigPreemptibleWorkerConfig? PreemptibleWorkerConfig { get; set; }

    /// <summary>Security related configuration. Structure defined below.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>
    /// The config settings for software inside the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files,
    /// such as Hadoop jars, between client machines and the cluster.
    /// Note: If you don&apos;t explicitly specify a staging_bucket
    /// then GCP will auto create / assign one for you. However, you are not guaranteed
    /// an auto generated bucket which is solely dedicated to your cluster; it may be shared
    /// with other clusters in the same region/zone also choosing to use the auto generation
    /// option.
    /// </summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>
    /// The Cloud Storage temp bucket used to store ephemeral cluster
    /// and jobs data, such as Spark and MapReduce history files.
    /// Note: If you don&apos;t explicitly specify a temp_bucket then GCP will auto create / assign one for you.
    /// </summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the worker instances
    /// in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>
/// The config setting for metastore service with the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}

/// <summary>The Spark History Server configuration for the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}

/// <summary>
/// Configuration of auxiliary services used by this cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfig
{
    /// <summary>
    /// The config setting for metastore service with the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

/// <summary>
/// The autoscaler configuration for this node pool.
/// The autoscaler is enabled only when a valid configuration is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling
{
    /// <summary>The maximum number of nodes in the node pool. Must be &gt;= minNodeCount, and must be &gt; 0.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes in the node pool. Must be &gt;= 0 and &lt;= maxNodeCount.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>The node pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig
{
    /// <summary>
    /// The number of local SSD disks to attach to the node,
    /// which is limited by the maximum number of disks allowable per zone.
    /// </summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance.
    /// The instance may be scheduled on the specified or a newer CPU platform.
    /// Specify the friendly names of CPU platforms, such as &quot;Intel Haswell&quot; or &quot;Intel Sandy Bridge&quot;.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// Preemptible nodes cannot be used in a node pool with the CONTROLLER role or in the DEFAULT node pool if the
    /// CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).
    /// </summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Spot flag for enabling Spot VM, which is a rebrand of the existing preemptible flag.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}

/// <summary>
/// (Input only) The configuration for the GKE node pool.
/// If specified, Dataproc attempts to create a node pool with the specified shape.
/// If one with the same name already exists, it is verified against all specified fields.
/// If a field differs, the virtual cluster creation will fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig
{
    /// <summary>
    /// The autoscaler configuration for this node pool.
    /// The autoscaler is enabled only when a valid configuration is present.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling? Autoscaling { get; set; }

    /// <summary>The node pool configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig? Config { get; set; }

    /// <summary>
    /// The list of Compute Engine zones where node pool nodes associated
    /// with a Dataproc on GKE virtual cluster will be located.
    /// </summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget
{
    /// <summary>The target GKE node pool.</summary>
    [JsonPropertyName("nodePool")]
    public string? NodePool { get; set; }

    /// <summary>
    /// (Input only) The configuration for the GKE node pool.
    /// If specified, Dataproc attempts to create a node pool with the specified shape.
    /// If one with the same name already exists, it is verified against all specified fields.
    /// If a field differs, the virtual cluster creation will fail.
    /// </summary>
    [JsonPropertyName("nodePoolConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig? NodePoolConfig { get; set; }

    /// <summary>
    /// The roles associated with the GKE node pool.
    /// One of &quot;DEFAULT&quot;, &quot;CONTROLLER&quot;, &quot;SPARK_DRIVER&quot; or &quot;SPARK_EXECUTOR&quot;.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

/// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig
{
    /// <summary>
    /// A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster
    /// (the GKE cluster can be zonal or regional)
    /// </summary>
    [JsonPropertyName("gkeClusterTarget")]
    public string? GkeClusterTarget { get; set; }

    /// <summary>
    /// GKE node pools where workloads will be scheduled. At least one node pool must be assigned the DEFAULT
    /// GkeNodePoolTarget.Role. If a GkeNodePoolTarget is not specified, Dataproc constructs a DEFAULT GkeNodePoolTarget.
    /// Each role can be given to only one GkeNodePoolTarget. All node pools must have the same location settings.
    /// </summary>
    [JsonPropertyName("nodePoolTarget")]
    public IList<V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget>? NodePoolTarget { get; set; }
}

/// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig
{
    /// <summary>
    /// The components that should be installed in this Dataproc cluster. The key must be a string from the
    /// KubernetesComponent enumeration. The value is the version of the software to be installed. At least one entry must be specified.
    /// </summary>
    [JsonPropertyName("componentVersion")]
    public IDictionary<string, string>? ComponentVersion { get; set; }

    /// <summary>
    /// The properties to set on daemon config files. Property keys are specified in prefix:property format,
    /// for example spark:spark.kubernetes.container.image.
    /// </summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>
/// The configuration for running the Dataproc cluster on Kubernetes.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfig
{
    /// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
    [JsonPropertyName("gkeClusterConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig? GkeClusterConfig { get; set; }

    /// <summary>
    /// A namespace within the Kubernetes cluster to deploy into.
    /// If this namespace does not exist, it is created.
    /// If it  exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it.
    /// If not specified, the name of the Dataproc Cluster is used.
    /// </summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
    [JsonPropertyName("kubernetesSoftwareConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig? KubernetesSoftwareConfig { get; set; }
}

/// <summary>
/// Allows you to configure a virtual Dataproc on GKE cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecInitProviderVirtualClusterConfig
{
    /// <summary>
    /// Configuration of auxiliary services used by this cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("auxiliaryServicesConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigAuxiliaryServicesConfig? AuxiliaryServicesConfig { get; set; }

    /// <summary>
    /// The configuration for running the Dataproc cluster on Kubernetes.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("kubernetesClusterConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfigKubernetesClusterConfig? KubernetesClusterConfig { get; set; }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files,
    /// such as Hadoop jars, between client machines and the cluster.
    /// Note: If you don&apos;t explicitly specify a staging_bucket
    /// then GCP will auto create / assign one for you. However, you are not guaranteed
    /// an auto generated bucket which is solely dedicated to your cluster; it may be shared
    /// with other clusters in the same region/zone also choosing to use the auto generation
    /// option.
    /// </summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }
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
public partial class V1beta2ClusterSpecInitProvider
{
    /// <summary>
    /// Allows you to configure various aspects of the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2ClusterSpecInitProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>
    /// Does not affect auto scaling decomissioning from an autoscaling policy.
    /// Graceful decommissioning allows removing nodes from the cluster without interrupting jobs in progress.
    /// Timeout specifies how long to wait for jobs in progress to finish before forcefully removing nodes (and potentially interrupting jobs).
    /// Default timeout is 0 (for forceful decommission), and the maximum allowed timeout is 1 day. (see JSON representation of
    /// Duration).
    /// Only supported on Dataproc image versions 1.2 and higher.
    /// For more context see the docs
    /// </summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    /// <summary>Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and
    /// zone.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the cluster will exist. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The region in which the cluster and associated nodes will be created in.
    /// Defaults to global.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Allows you to configure a virtual Dataproc on GKE cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("virtualClusterConfig")]
    public V1beta2ClusterSpecInitProviderVirtualClusterConfig? VirtualClusterConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecManagementPoliciesEnum>))]
public enum V1beta2ClusterSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterSpec
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
    public V1beta2ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta2ClusterSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The autoscaling policy config associated with the cluster.
/// Note that once set, if autoscaling_config is the only field set in cluster_config, it can
/// only be removed by setting policy_uri = &quot; &quot;, rather than removing the whole block.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster.</summary>
    [JsonPropertyName("policyUri")]
    public string? PolicyUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The node group instance group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>
    /// List of worker instance names which have been assigned
    /// to the cluster.
    /// </summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance.
    /// The instance may be scheduled on the specified or a newer CPU platform.
    /// Specify the friendly names of CPU platforms, such as &quot;Intel Haswell&quot; or &quot;Intel Sandy Bridge&quot;.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Specifies the number of master nodes to create.
    /// Please set a number greater than 0. Node Group must have at least 1 instance.
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroup
{
    /// <summary>
    /// The name of the cluster, unique within the project and
    /// zone.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The node group instance group configuration.</summary>
    [JsonPropertyName("nodeGroupConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroupNodeGroupConfig? NodeGroupConfig { get; set; }

    /// <summary>
    /// The roles associated with the GKE node pool.
    /// One of &quot;DEFAULT&quot;, &quot;CONTROLLER&quot;, &quot;SPARK_DRIVER&quot; or &quot;SPARK_EXECUTOR&quot;.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroups
{
    /// <summary>Node group configuration.</summary>
    [JsonPropertyName("nodeGroup")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroupsNodeGroup>? NodeGroup { get; set; }

    [JsonPropertyName("nodeGroupId")]
    public string? NodeGroupId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigDataprocMetricConfigMetrics
{
    /// <summary>One or more [available OSS metrics] (https://cloud.google.com/dataproc/docs/guides/monitoring#available_oss_metrics) to collect for the metric course.</summary>
    [JsonPropertyName("metricOverrides")]
    public IList<string>? MetricOverrides { get; set; }

    /// <summary>A source for the collection of Dataproc OSS metrics (see available OSS metrics).</summary>
    [JsonPropertyName("metricSource")]
    public string? MetricSource { get; set; }
}

/// <summary>
/// The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigDataprocMetricConfig
{
    /// <summary>Metrics sources to enable.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigDataprocMetricConfigMetrics>? Metrics { get; set; }
}

/// <summary>
/// The Customer managed encryption keys settings for the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigEncryptionConfig
{
    /// <summary>
    /// The Cloud KMS key name to use for PD disk encryption for
    /// all instances in the cluster.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>
/// The config settings for port access on the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigEndpointConfig
{
    /// <summary>
    /// The flag to enable http access to specific ports
    /// on the cluster from external sources (aka Component Gateway). Defaults to false.
    /// </summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }

    /// <summary>
    /// The map of port descriptions to URLs. Will only be populated if
    /// enable_http_port_access is true.
    /// </summary>
    [JsonPropertyName("httpPorts")]
    public IDictionary<string, string>? HttpPorts { get; set; }
}

/// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigConfidentialInstanceConfig
{
    /// <summary>Defines whether the instance should have confidential compute enabled.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Node Group Affinity for sole-tenant clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>The URI of a sole-tenant node group resource that the cluster will be created on.</summary>
    [JsonPropertyName("nodeGroupUri")]
    public string? NodeGroupUri { get; set; }
}

/// <summary>Reservation Affinity for consuming zonal reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>
/// Common config settings for resources of Google Compute Engine cluster
/// instances, applicable to all instances in the cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfig
{
    /// <summary>Confidential Instance Config for clusters using Confidential VMs</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>
    /// By default, clusters are not restricted to internal IP addresses,
    /// and will have ephemeral external IP addresses assigned to each instance. If set to true, all
    /// instances in the cluster will only have internal IP addresses. Note: Private Google Access
    /// (also known as privateIpGoogleAccess) must be enabled on the subnetwork that the cluster
    /// will be launched in.
    /// </summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>
    /// A map of the Compute Engine metadata entries to add to all instances
    /// (see Project and instance metadata).
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine
    /// network to the cluster will be part of. Conflicts with subnetwork.
    /// If neither is specified, this defaults to the &quot;default&quot; network.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigNodeGroupAffinity? NodeGroupAffinity { get; set; }

    /// <summary>Reservation Affinity for consuming zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>
    /// The service account to be used by the Node VMs.
    /// If not specified, the &quot;default&quot; service account is used.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>
    /// The set of Google API scopes
    /// to be made available on all of the node VMs under the service_account
    /// specified. Both OAuth2 URLs and gcloud
    /// short names are supported. To allow full access to all Cloud APIs, use the
    /// cloud-platform scope. See a complete list of scopes here.
    /// </summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// The name or self_link of the Google Compute Engine
    /// subnetwork the cluster will be part of. Conflicts with network.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>
    /// The list of instance tags applied to instances in the cluster.
    /// Tags are used to identify valid sources or targets for network firewalls.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// The GCP zone where your data is stored and used (i.e. where
    /// the master and the worker nodes will be created in). If region is set to &apos;global&apos; (default)
    /// then zone is mandatory, otherwise GCP is able to make use of Auto Zone Placement
    /// to determine this automatically for you.
    /// Note: This setting additionally determines and restricts
    /// which computing resources are available for use with other configs such as
    /// cluster_config.master_config.machine_type and cluster_config.worker_config.machine_type.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigInitializationAction
{
    /// <summary>
    /// The script to be executed during initialization of the cluster.
    /// The script must be a GCS file with a gs:// prefix.
    /// </summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>
    /// The maximum duration (in seconds) which script is
    /// allowed to take to execute its action. GCP will default to a predetermined
    /// computed value if not set (currently 300).
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }
}

/// <summary>
/// The settings for auto deletion cluster schedule.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigLifecycleConfig
{
    /// <summary>
    /// The time when cluster will be auto-deleted.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, accurate to nanoseconds.
    /// Example: &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>
    /// The duration to keep the cluster alive while idling
    /// (no jobs running). After this TTL, the cluster will be deleted. Valid range: [10m, 14d].
    /// </summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }

    /// <summary>
    /// Time when the cluster became idle
    /// (most recent job finished) and became eligible for deletion due to idleness.
    /// </summary>
    [JsonPropertyName("idleStartTime")]
    public string? IdleStartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigMasterConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the master instances
/// in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigMasterConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>
    /// The URI for the image to use for this worker.  See the guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>
    /// List of worker instance names which have been assigned
    /// to the cluster.
    /// </summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type
    /// to create for the master. If not specified, GCP will default to a predetermined
    /// computed value (currently n1-standard-4).
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The name of a minimum generation of CPU family
    /// for the master. If not specified, GCP will default to a predetermined computed value
    /// for each zone. See the guide
    /// for details about which CPU families are available (and defaulted) for each zone.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Specifies the number of master nodes to create.
    /// If not specified, GCP will default to a predetermined computed value (currently 1).
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

/// <summary>
/// The config setting for metastore service with the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList
{
    /// <summary>Full machine-type names, e.g. &quot;n1-standard-16&quot;.</summary>
    [JsonPropertyName("machineTypes")]
    public IList<string>? MachineTypes { get; set; }

    /// <summary>Preference of this instance selection. A lower number means higher preference. Dataproc will first try to create a VM based on the machine-type with priority rank and fallback to next rank based on availability. Machine types and instance selections with the same priority have the same preference.</summary>
    [JsonPropertyName("rank")]
    public double? Rank { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionResults
{
    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}

/// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix
{
    /// <summary>The base capacity that will always use Standard VMs to avoid risk of more preemption than the minimum capacity you need. Dataproc will create only standard VMs until it reaches standardCapacityBase, then it will start using standardCapacityPercentAboveBase to mix Spot with Standard VMs. eg. If 15 instances are requested and standardCapacityBase is 5, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances.</summary>
    [JsonPropertyName("standardCapacityBase")]
    public double? StandardCapacityBase { get; set; }

    /// <summary>The percentage of target capacity that should use Standard VM. The remaining percentage will use Spot VMs. The percentage applies only to the capacity above standardCapacityBase. eg. If 15 instances are requested and standardCapacityBase is 5 and standardCapacityPercentAboveBase is 30, Dataproc will create 5 standard VMs and then start mixing spot and standard VMs for remaining 10 instances. The mix will be 30% standard and 70% spot.</summary>
    [JsonPropertyName("standardCapacityPercentAboveBase")]
    public double? StandardCapacityPercentAboveBase { get; set; }
}

/// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy
{
    /// <summary>List of instance selection options that the group will use when creating new VMs.</summary>
    [JsonPropertyName("instanceSelectionList")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionList>? InstanceSelectionList { get; set; }

    [JsonPropertyName("instanceSelectionResults")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyInstanceSelectionResults>? InstanceSelectionResults { get; set; }

    /// <summary>Defines how the Group selects the provisioning model to ensure required reliability.</summary>
    [JsonPropertyName("provisioningModelMix")]
    public V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicyProvisioningModelMix? ProvisioningModelMix { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the additional
/// instances in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfig
{
    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>Instance flexibility Policy allowing a mixture of VM shapes and provisioning models.</summary>
    [JsonPropertyName("instanceFlexibilityPolicy")]
    public V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfigInstanceFlexibilityPolicy? InstanceFlexibilityPolicy { get; set; }

    /// <summary>
    /// List of worker instance names which have been assigned
    /// to the cluster.
    /// </summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>
    /// Specifies the number of preemptible nodes to create.
    /// Defaults to 0.
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>
    /// Specifies the preemptibility of the secondary workers. The default value is PREEMPTIBLE
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>
/// Identity Configuration. At least one of identity_config
/// or kerberos_config is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigSecurityConfigIdentityConfig
{
    /// <summary>
    /// The end user to service account mappings
    /// in a service account based multi-tenant cluster
    /// </summary>
    [JsonPropertyName("userServiceAccountMapping")]
    public IDictionary<string, string>? UserServiceAccountMapping { get; set; }
}

/// <summary>
/// Kerberos Configuration. At least one of identity_config
/// or kerberos_config is required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>
    /// The admin server (IP or hostname) for the
    /// remote trusted realm in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>
    /// The KDC (IP or hostname) for the
    /// remote trusted realm in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>
    /// The remote realm the Dataproc on-cluster KDC will
    /// trust, should the user enable cross realm trust.
    /// </summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS
    /// encrypted file containing the shared password between the on-cluster Kerberos realm
    /// and the remote trusted realm, in a cross realm trust relationship.
    /// </summary>
    [JsonPropertyName("crossRealmTrustSharedPasswordUri")]
    public string? CrossRealmTrustSharedPasswordUri { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the master key of the KDC database.
    /// </summary>
    [JsonPropertyName("kdcDbKeyUri")]
    public string? KdcDbKeyUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the password to the user provided key. For the self-signed certificate, this password
    /// is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("keyPasswordUri")]
    public string? KeyPasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file containing
    /// the password to the user provided keystore. For the self-signed certificated, the password
    /// is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("keystorePasswordUri")]
    public string? KeystorePasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of the keystore file used for SSL encryption.
    /// If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    [JsonPropertyName("keystoreUri")]
    public string? KeystoreUri { get; set; }

    /// <summary>The URI of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKeyUri")]
    public string? KmsKeyUri { get; set; }

    /// <summary>
    /// The name of the on-cluster Kerberos realm. If not specified, the
    /// uppercased domain of hostnames will be the realm.
    /// </summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file
    /// containing the root principal password.
    /// </summary>
    [JsonPropertyName("rootPrincipalPasswordUri")]
    public string? RootPrincipalPasswordUri { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>
    /// The Cloud Storage URI of a KMS encrypted file
    /// containing the password to the user provided truststore. For the self-signed
    /// certificate, this password is generated by Dataproc.
    /// </summary>
    [JsonPropertyName("truststorePasswordUri")]
    public string? TruststorePasswordUri { get; set; }

    /// <summary>
    /// The Cloud Storage URI of the truststore file used for
    /// SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }
}

/// <summary>Security related configuration. Structure defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigSecurityConfig
{
    /// <summary>
    /// Identity Configuration. At least one of identity_config
    /// or kerberos_config is required.
    /// </summary>
    [JsonPropertyName("identityConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigSecurityConfigIdentityConfig? IdentityConfig { get; set; }

    /// <summary>
    /// Kerberos Configuration. At least one of identity_config
    /// or kerberos_config is required.
    /// </summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigSecurityConfigKerberosConfig? KerberosConfig { get; set; }
}

/// <summary>
/// The config settings for software inside the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigSoftwareConfig
{
    /// <summary>
    /// The Cloud Dataproc image version to use
    /// for the cluster - this controls the sets of software versions
    /// installed onto the nodes when you create clusters. If not specified, defaults to the
    /// latest version. For a list of valid versions see
    /// Cloud Dataproc versions
    /// </summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of optional components to activate on the cluster. See Available Optional Components.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>
    /// A list of override and additional properties (key/value pairs)
    /// used to modify various aspects of the common configuration files used when creating
    /// a cluster. For a list of valid properties please see
    /// Cluster properties
    /// </summary>
    [JsonPropertyName("overrideProperties")]
    public IDictionary<string, string>? OverrideProperties { get; set; }

    /// <summary>
    /// The properties to set on daemon config files. Property keys are specified in prefix:property format,
    /// for example spark:spark.kubernetes.container.image.
    /// </summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance. Often restricted to one of 1, 2, 4, or 8.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>The short name of the accelerator type to expose to this instance. For example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk Config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigWorkerConfigDiskConfig
{
    /// <summary>
    /// Size of the primary disk attached to each node, specified
    /// in GB. The primary disk contains the boot volume and system libraries, and the
    /// smallest allowed disk size is 10GB. GCP will default to a predetermined
    /// computed value if not set (currently 500GB). Note: If SSDs are not
    /// attached, it also contains the HDFS data blocks and Hadoop working directories.
    /// </summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>
    /// The disk type of the primary disk attached to each node.
    /// One of &quot;pd-ssd&quot; or &quot;pd-standard&quot;. Defaults to &quot;pd-standard&quot;.
    /// </summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>
    /// Optional. Interface type of local SSDs (default is &quot;scsi&quot;).
    /// Valid values: &quot;scsi&quot; (Small Computer System Interface), &quot;nvme&quot; (Non-Volatile
    /// Memory Express). See
    /// local SSD performance.
    /// </summary>
    [JsonPropertyName("localSsdInterface")]
    public string? LocalSsdInterface { get; set; }

    /// <summary>
    /// The amount of local SSD disks that will be
    /// attached to each master cluster node. Defaults to 0.
    /// </summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>
/// The Google Compute Engine config settings for the worker instances
/// in a cluster. Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances. Can be specified multiple times.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk Config</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>
    /// The URI for the image to use for this worker.  See the guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }

    /// <summary>
    /// List of worker instance names which have been assigned
    /// to the cluster.
    /// </summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>
    /// The name of a Google Compute Engine machine type
    /// to create for the worker nodes. If not specified, GCP will default to a predetermined
    /// computed value (currently n1-standard-4).
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The name of a minimum generation of CPU family
    /// for the master. If not specified, GCP will default to a predetermined computed value
    /// for each zone. See the guide
    /// for details about which CPU families are available (and defaulted) for each zone.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The minimum number of primary worker instances to create.  If min_num_instances is set, cluster creation will succeed if the number of primary workers created is at least equal to the min_num_instances number.</summary>
    [JsonPropertyName("minNumInstances")]
    public double? MinNumInstances { get; set; }

    /// <summary>
    /// Specifies the number of worker nodes to create.
    /// If not specified, GCP will default to a predetermined computed value (currently 2).
    /// There is currently a beta feature which allows you to run a
    /// Single Node Cluster.
    /// In order to take advantage of this you need to set
    /// &quot;dataproc:dataproc.allow.zero.workers&quot; = &quot;true&quot; in
    /// cluster_config.software_config.properties
    /// </summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }
}

/// <summary>
/// Allows you to configure various aspects of the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderClusterConfig
{
    /// <summary>
    /// The autoscaling policy config associated with the cluster.
    /// Note that once set, if autoscaling_config is the only field set in cluster_config, it can
    /// only be removed by setting policy_uri = &quot; &quot;, rather than removing the whole block.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// A Dataproc NodeGroup resource is a group of Dataproc cluster nodes that execute an assigned role.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("auxiliaryNodeGroups")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigAuxiliaryNodeGroups>? AuxiliaryNodeGroups { get; set; }

    /// <summary>
    /// The name of the cloud storage bucket ultimately used to house the staging data
    /// for the cluster. If staging_bucket is specified, it will contain this value, otherwise
    /// it will be the auto generated name.
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The tier of the cluster.</summary>
    [JsonPropertyName("clusterTier")]
    public string? ClusterTier { get; set; }

    /// <summary>
    /// The Compute Engine accelerator (GPU) configuration for these instances. Can be specified multiple times.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("dataprocMetricConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigDataprocMetricConfig? DataprocMetricConfig { get; set; }

    /// <summary>
    /// The Customer managed encryption keys settings for the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// The config settings for port access on the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary>
    /// Common config settings for resources of Google Compute Engine cluster
    /// instances, applicable to all instances in the cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("gceClusterConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigGceClusterConfig? GceClusterConfig { get; set; }

    /// <summary>
    /// Commands to execute on each node after config is completed.
    /// You can specify multiple versions of these. Structure defined below.
    /// </summary>
    [JsonPropertyName("initializationAction")]
    public IList<V1beta2ClusterStatusAtProviderClusterConfigInitializationAction>? InitializationAction { get; set; }

    /// <summary>
    /// The settings for auto deletion cluster schedule.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the master instances
    /// in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("masterConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigMasterConfig? MasterConfig { get; set; }

    /// <summary>
    /// The config setting for metastore service with the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the additional
    /// instances in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("preemptibleWorkerConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigPreemptibleWorkerConfig? PreemptibleWorkerConfig { get; set; }

    /// <summary>Security related configuration. Structure defined below.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>
    /// The config settings for software inside the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files,
    /// such as Hadoop jars, between client machines and the cluster.
    /// Note: If you don&apos;t explicitly specify a staging_bucket
    /// then GCP will auto create / assign one for you. However, you are not guaranteed
    /// an auto generated bucket which is solely dedicated to your cluster; it may be shared
    /// with other clusters in the same region/zone also choosing to use the auto generation
    /// option.
    /// </summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>
    /// The Cloud Storage temp bucket used to store ephemeral cluster
    /// and jobs data, such as Spark and MapReduce history files.
    /// Note: If you don&apos;t explicitly specify a temp_bucket then GCP will auto create / assign one for you.
    /// </summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>
    /// The Google Compute Engine config settings for the worker instances
    /// in a cluster. Structure defined below.
    /// </summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>
/// The config setting for metastore service with the cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig
{
    /// <summary>Resource name of an existing Dataproc Metastore service.</summary>
    [JsonPropertyName("dataprocMetastoreService")]
    public string? DataprocMetastoreService { get; set; }
}

/// <summary>The Spark History Server configuration for the workload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig
{
    /// <summary>Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.</summary>
    [JsonPropertyName("dataprocCluster")]
    public string? DataprocCluster { get; set; }
}

/// <summary>
/// Configuration of auxiliary services used by this cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfig
{
    /// <summary>
    /// The config setting for metastore service with the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("metastoreConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigMetastoreConfig? MetastoreConfig { get; set; }

    /// <summary>The Spark History Server configuration for the workload.</summary>
    [JsonPropertyName("sparkHistoryServerConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfigSparkHistoryServerConfig? SparkHistoryServerConfig { get; set; }
}

/// <summary>
/// The autoscaler configuration for this node pool.
/// The autoscaler is enabled only when a valid configuration is present.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling
{
    /// <summary>The maximum number of nodes in the node pool. Must be &gt;= minNodeCount, and must be &gt; 0.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes in the node pool. Must be &gt;= 0 and &lt;= maxNodeCount.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>The node pool configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig
{
    /// <summary>
    /// The number of local SSD disks to attach to the node,
    /// which is limited by the maximum number of disks allowable per zone.
    /// </summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>The name of a Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Minimum CPU platform to be used by this instance.
    /// The instance may be scheduled on the specified or a newer CPU platform.
    /// Specify the friendly names of CPU platforms, such as &quot;Intel Haswell&quot; or &quot;Intel Sandy Bridge&quot;.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>
    /// Whether the nodes are created as preemptible VM instances.
    /// Preemptible nodes cannot be used in a node pool with the CONTROLLER role or in the DEFAULT node pool if the
    /// CONTROLLER role is not assigned (the DEFAULT node pool will assume the CONTROLLER role).
    /// </summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Spot flag for enabling Spot VM, which is a rebrand of the existing preemptible flag.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }
}

/// <summary>
/// (Input only) The configuration for the GKE node pool.
/// If specified, Dataproc attempts to create a node pool with the specified shape.
/// If one with the same name already exists, it is verified against all specified fields.
/// If a field differs, the virtual cluster creation will fail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig
{
    /// <summary>
    /// The autoscaler configuration for this node pool.
    /// The autoscaler is enabled only when a valid configuration is present.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigAutoscaling? Autoscaling { get; set; }

    /// <summary>The node pool configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfigConfig? Config { get; set; }

    /// <summary>
    /// The list of Compute Engine zones where node pool nodes associated
    /// with a Dataproc on GKE virtual cluster will be located.
    /// </summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget
{
    /// <summary>The target GKE node pool.</summary>
    [JsonPropertyName("nodePool")]
    public string? NodePool { get; set; }

    /// <summary>
    /// (Input only) The configuration for the GKE node pool.
    /// If specified, Dataproc attempts to create a node pool with the specified shape.
    /// If one with the same name already exists, it is verified against all specified fields.
    /// If a field differs, the virtual cluster creation will fail.
    /// </summary>
    [JsonPropertyName("nodePoolConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTargetNodePoolConfig? NodePoolConfig { get; set; }

    /// <summary>
    /// The roles associated with the GKE node pool.
    /// One of &quot;DEFAULT&quot;, &quot;CONTROLLER&quot;, &quot;SPARK_DRIVER&quot; or &quot;SPARK_EXECUTOR&quot;.
    /// </summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}

/// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig
{
    /// <summary>
    /// A target GKE cluster to deploy to. It must be in the same project and region as the Dataproc cluster
    /// (the GKE cluster can be zonal or regional)
    /// </summary>
    [JsonPropertyName("gkeClusterTarget")]
    public string? GkeClusterTarget { get; set; }

    /// <summary>
    /// GKE node pools where workloads will be scheduled. At least one node pool must be assigned the DEFAULT
    /// GkeNodePoolTarget.Role. If a GkeNodePoolTarget is not specified, Dataproc constructs a DEFAULT GkeNodePoolTarget.
    /// Each role can be given to only one GkeNodePoolTarget. All node pools must have the same location settings.
    /// </summary>
    [JsonPropertyName("nodePoolTarget")]
    public IList<V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfigNodePoolTarget>? NodePoolTarget { get; set; }
}

/// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig
{
    /// <summary>
    /// The components that should be installed in this Dataproc cluster. The key must be a string from the
    /// KubernetesComponent enumeration. The value is the version of the software to be installed. At least one entry must be specified.
    /// </summary>
    [JsonPropertyName("componentVersion")]
    public IDictionary<string, string>? ComponentVersion { get; set; }

    /// <summary>
    /// The properties to set on daemon config files. Property keys are specified in prefix:property format,
    /// for example spark:spark.kubernetes.container.image.
    /// </summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>
/// The configuration for running the Dataproc cluster on Kubernetes.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfig
{
    /// <summary>The configuration for running the Dataproc cluster on GKE.</summary>
    [JsonPropertyName("gkeClusterConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigGkeClusterConfig? GkeClusterConfig { get; set; }

    /// <summary>
    /// A namespace within the Kubernetes cluster to deploy into.
    /// If this namespace does not exist, it is created.
    /// If it  exists, Dataproc verifies that another Dataproc VirtualCluster is not installed into it.
    /// If not specified, the name of the Dataproc Cluster is used.
    /// </summary>
    [JsonPropertyName("kubernetesNamespace")]
    public string? KubernetesNamespace { get; set; }

    /// <summary>The software configuration for this Dataproc cluster running on Kubernetes.</summary>
    [JsonPropertyName("kubernetesSoftwareConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfigKubernetesSoftwareConfig? KubernetesSoftwareConfig { get; set; }
}

/// <summary>
/// Allows you to configure a virtual Dataproc on GKE cluster.
/// Structure defined below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProviderVirtualClusterConfig
{
    /// <summary>
    /// Configuration of auxiliary services used by this cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("auxiliaryServicesConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigAuxiliaryServicesConfig? AuxiliaryServicesConfig { get; set; }

    /// <summary>
    /// The configuration for running the Dataproc cluster on Kubernetes.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("kubernetesClusterConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfigKubernetesClusterConfig? KubernetesClusterConfig { get; set; }

    /// <summary>
    /// The Cloud Storage staging bucket used to stage files,
    /// such as Hadoop jars, between client machines and the cluster.
    /// Note: If you don&apos;t explicitly specify a staging_bucket
    /// then GCP will auto create / assign one for you. However, you are not guaranteed
    /// an auto generated bucket which is solely dedicated to your cluster; it may be shared
    /// with other clusters in the same region/zone also choosing to use the auto generation
    /// option.
    /// </summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusAtProvider
{
    /// <summary>
    /// Allows you to configure various aspects of the cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2ClusterStatusAtProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>
    /// (Computed) The list of labels (key/value pairs) to be applied to
    /// instances in the cluster. GCP generates some itself including goog-dataproc-cluster-name
    /// which is the name of the cluster.
    /// </summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Does not affect auto scaling decomissioning from an autoscaling policy.
    /// Graceful decommissioning allows removing nodes from the cluster without interrupting jobs in progress.
    /// Timeout specifies how long to wait for jobs in progress to finish before forcefully removing nodes (and potentially interrupting jobs).
    /// Default timeout is 0 (for forceful decommission), and the maximum allowed timeout is 1 day. (see JSON representation of
    /// Duration).
    /// Only supported on Dataproc image versions 1.2 and higher.
    /// For more context see the docs
    /// </summary>
    [JsonPropertyName("gracefulDecommissionTimeout")]
    public string? GracefulDecommissionTimeout { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The name of the cluster, unique within the project and
    /// zone.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the cluster will exist. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The region in which the cluster and associated nodes will be created in.
    /// Defaults to global.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// Allows you to configure a virtual Dataproc on GKE cluster.
    /// Structure defined below.
    /// </summary>
    [JsonPropertyName("virtualClusterConfig")]
    public V1beta2ClusterStatusAtProviderVirtualClusterConfig? VirtualClusterConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API. Manages a Cloud Dataproc cluster resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ClusterSpec>, IStatus<V1beta2ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta2ClusterStatus? Status { get; set; }
}