#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.container.gcp.upbound.io;
/// <summary>NodePool is the Schema for the NodePools API. Manages a GKE NodePool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2NodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta2NodePool>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "NodePoolList";
    public const string KubeGroup = "container.gcp.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodePoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2NodePool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2NodePool> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecDeletionPolicyEnum>))]
public enum V1beta2NodePoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Configuration required by cluster autoscaler to adjust
/// the size of the node pool to the current cluster usage. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderAutoscaling
{
    /// <summary>
    /// Location policy specifies the algorithm used when
    /// scaling-up the node pool. Location policy is supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary>
    /// Maximum number of nodes per zone in the NodePool.
    /// Must be &gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes per zone in the NodePool.
    /// Must be &gt;=0 and &lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>
    /// Total maximum number of nodes in the NodePool.
    /// Must be &gt;= total_min_node_count. Cannot be used with per zone limits.
    /// Total size limits are supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public double? TotalMaxNodeCount { get; set; }

    /// <summary>
    /// Total minimum number of nodes in the NodePool.
    /// Must be &gt;=0 and &lt;= total_max_node_count. Cannot be used with per zone limits.
    /// Total size limits are supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("totalMinNodeCount")]
    public double? TotalMinNodeCount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderClusterRefPolicyResolutionEnum>))]
public enum V1beta2NodePoolSpecForProviderClusterRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderClusterRefPolicyResolveEnum>))]
public enum V1beta2NodePoolSpecForProviderClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderClusterRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2NodePoolSpecForProviderClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2NodePoolSpecForProviderClusterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2NodePoolSpecForProviderClusterRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum>))]
public enum V1beta2NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderClusterSelectorPolicyResolveEnum>))]
public enum V1beta2NodePoolSpecForProviderClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderClusterSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2NodePoolSpecForProviderClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderClusterSelector
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
    public V1beta2NodePoolSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Node management configuration, wherein auto-repair and
/// auto-upgrade is configured. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>Name of the VPC where the additional interface belongs.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNetworkConfigAdditionalPodNetworkConfigs
{
    /// <summary>
    /// The maximum number of pods per node in this node pool.
    /// Note that this does not work on node pools which are &quot;route-based&quot; - that is, node
    /// pools belonging to clusters that do not have IP Aliasing enabled.
    /// See the official documentation
    /// for more information.
    /// </summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>The name of the secondary range on the subnet which provides IP address for this pod range.</summary>
    [JsonPropertyName("secondaryPodRange")]
    public string? SecondaryPodRange { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig
{
    /// <summary>Whether pod cidr overprovision is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

/// <summary>
/// The network configuration of the pool. Such as
/// configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is
/// documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNetworkConfig
{
    /// <summary>
    /// We specify the additional node networks for this node pool using this list. Each node network corresponds to an additional interface.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta2NodePoolSpecForProviderNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary>
    /// We specify the additional pod networks for this node pool using this list. Each pod network corresponds to an additional alias IP range for the node.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta2NodePoolSpecForProviderNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta2NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta2NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures
{
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta2NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigKubeletConfig
{
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    [JsonPropertyName("containerLogMaxFiles")]
    public double? ContainerLogMaxFiles { get; set; }

    [JsonPropertyName("containerLogMaxSize")]
    public string? ContainerLogMaxSize { get; set; }

    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    [JsonPropertyName("imageGcHighThresholdPercent")]
    public double? ImageGcHighThresholdPercent { get; set; }

    [JsonPropertyName("imageGcLowThresholdPercent")]
    public double? ImageGcLowThresholdPercent { get; set; }

    [JsonPropertyName("imageMaximumGcAge")]
    public string? ImageMaximumGcAge { get; set; }

    [JsonPropertyName("imageMinimumGcAge")]
    public string? ImageMinimumGcAge { get; set; }

    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    [JsonPropertyName("memoryManager")]
    public V1beta2NodePoolSpecForProviderNodeConfigKubeletConfigMemoryManager? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    [JsonPropertyName("topologyManager")]
    public V1beta2NodePoolSpecForProviderNodeConfigKubeletConfigTopologyManager? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigReservationAffinity
{
    /// <summary>
    /// The type of reservation consumption
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name&quot;</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigSecondaryBootDisks
{
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelector
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
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>name&quot;</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta2NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigWindowsNodeConfig
{
    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("osversion")]
    public string? Osversion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta2NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    [JsonPropertyName("confidentialNodes")]
    public V1beta2NodePoolSpecForProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public V1beta2NodePoolSpecForProviderNodeConfigFastSocket? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta2NodePoolSpecForProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public V1beta2NodePoolSpecForProviderNodeConfigGvnic? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta2NodePoolSpecForProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    [JsonPropertyName("kubeletConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>
    /// Possible Local SSD encryption modes:
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("localSsdEncryptionMode")]
    public string? LocalSsdEncryptionMode { get; set; }

    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    [JsonPropertyName("reservationAffinity")]
    public V1beta2NodePoolSpecForProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta2NodePoolSpecForProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2NodePoolSpecForProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta2NodePoolSpecForProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

/// <summary>
/// Specifies a custom placement policy for the
/// nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderPlacementPolicy
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user.
    /// The resource policy must be in the same project and region as the node pool.
    /// If not found, InvalidArgument error is returned.
    /// </summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU topology like &quot;2x4&quot; or &quot;2x2x2&quot;.</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies node pool-level settings of queued provisioning.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>Percentage of the blue pool nodes to drain in a batch.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>(Optionial) Soak time after each batch gets drained.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary>
/// The settings to adjust blue green upgrades.
/// Structure is documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>
    /// Time needed after draining the entire blue pool.
    /// After this period, the blue pool will be cleaned up.
    /// </summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta2NodePoolSpecForProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}

/// <summary>
/// Specify node upgrade settings to change how GKE upgrades nodes.
/// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta2NodePoolSpecForProviderUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>
    /// The number of additional nodes that can be added to the node pool during
    /// an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously.
    /// Can be set to 0 or greater.
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during
    /// an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in
    /// parallel. Can be set to 0 or greater.
    /// </summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>(Default SURGE) The upgrade strategy to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecForProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2NodePoolSpecForProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>The cluster to create the node pool for. Cluster must be present in location provided for clusters. May be specified in the format projects/{{project}}/locations/{{location}}/clusters/{{cluster}} or as just the name of the cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta2NodePoolSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta2NodePoolSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>
    /// The initial number of nodes for the pool. In
    /// regional or multi-zonal clusters, this is the number of nodes per zone. Changing
    /// this will force recreation of the resource.  If you don&apos;t
    /// need this value, don&apos;t set it.  If you do need it, you can use a lifecycle block to
    /// ignore subsequent changes to this field.
    /// </summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>The location (region or zone) of the cluster.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Node management configuration, wherein auto-repair and
    /// auto-upgrade is configured. Structure is documented below.
    /// </summary>
    [JsonPropertyName("management")]
    public V1beta2NodePoolSpecForProviderManagement? Management { get; set; }

    /// <summary>
    /// The maximum number of pods per node in this node pool.
    /// Note that this does not work on node pools which are &quot;route-based&quot; - that is, node
    /// pools belonging to clusters that do not have IP Aliasing enabled.
    /// See the official documentation
    /// for more information.
    /// </summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>
    /// The network configuration of the pool. Such as
    /// configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is
    /// documented below
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2NodePoolSpecForProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2NodePoolSpecForProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to
    /// update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The list of zones in which the node pool&apos;s nodes should be located. Nodes must
    /// be in the region of their regional cluster or in the same region as their
    /// cluster&apos;s zone for zonal clusters. If unspecified, the cluster-level
    /// node_locations will be used.
    /// </summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>
    /// Specifies a custom placement policy for the
    /// nodes.
    /// </summary>
    [JsonPropertyName("placementPolicy")]
    public V1beta2NodePoolSpecForProviderPlacementPolicy? PlacementPolicy { get; set; }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank,
    /// the provider-configured project will be used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Specifies node pool-level settings of queued provisioning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queuedProvisioning")]
    public V1beta2NodePoolSpecForProviderQueuedProvisioning? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta2NodePoolSpecForProviderUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Configuration required by cluster autoscaler to adjust
/// the size of the node pool to the current cluster usage. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderAutoscaling
{
    /// <summary>
    /// Location policy specifies the algorithm used when
    /// scaling-up the node pool. Location policy is supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary>
    /// Maximum number of nodes per zone in the NodePool.
    /// Must be &gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes per zone in the NodePool.
    /// Must be &gt;=0 and &lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>
    /// Total maximum number of nodes in the NodePool.
    /// Must be &gt;= total_min_node_count. Cannot be used with per zone limits.
    /// Total size limits are supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public double? TotalMaxNodeCount { get; set; }

    /// <summary>
    /// Total minimum number of nodes in the NodePool.
    /// Must be &gt;=0 and &lt;= total_max_node_count. Cannot be used with per zone limits.
    /// Total size limits are supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("totalMinNodeCount")]
    public double? TotalMinNodeCount { get; set; }
}

/// <summary>
/// Node management configuration, wherein auto-repair and
/// auto-upgrade is configured. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>Name of the VPC where the additional interface belongs.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNetworkConfigAdditionalPodNetworkConfigs
{
    /// <summary>
    /// The maximum number of pods per node in this node pool.
    /// Note that this does not work on node pools which are &quot;route-based&quot; - that is, node
    /// pools belonging to clusters that do not have IP Aliasing enabled.
    /// See the official documentation
    /// for more information.
    /// </summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>The name of the secondary range on the subnet which provides IP address for this pod range.</summary>
    [JsonPropertyName("secondaryPodRange")]
    public string? SecondaryPodRange { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig
{
    /// <summary>Whether pod cidr overprovision is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

/// <summary>
/// The network configuration of the pool. Such as
/// configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is
/// documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNetworkConfig
{
    /// <summary>
    /// We specify the additional node networks for this node pool using this list. Each node network corresponds to an additional interface.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta2NodePoolSpecInitProviderNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary>
    /// We specify the additional pod networks for this node pool using this list. Each pod network corresponds to an additional alias IP range for the node.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta2NodePoolSpecInitProviderNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta2NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta2NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures
{
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigKubeletConfig
{
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    [JsonPropertyName("containerLogMaxFiles")]
    public double? ContainerLogMaxFiles { get; set; }

    [JsonPropertyName("containerLogMaxSize")]
    public string? ContainerLogMaxSize { get; set; }

    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    [JsonPropertyName("imageGcHighThresholdPercent")]
    public double? ImageGcHighThresholdPercent { get; set; }

    [JsonPropertyName("imageGcLowThresholdPercent")]
    public double? ImageGcLowThresholdPercent { get; set; }

    [JsonPropertyName("imageMaximumGcAge")]
    public string? ImageMaximumGcAge { get; set; }

    [JsonPropertyName("imageMinimumGcAge")]
    public string? ImageMinimumGcAge { get; set; }

    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    [JsonPropertyName("memoryManager")]
    public V1beta2NodePoolSpecInitProviderNodeConfigKubeletConfigMemoryManager? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    [JsonPropertyName("topologyManager")]
    public V1beta2NodePoolSpecInitProviderNodeConfigKubeletConfigTopologyManager? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigReservationAffinity
{
    /// <summary>
    /// The type of reservation consumption
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name&quot;</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigSecondaryBootDisks
{
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelector
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
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>name&quot;</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta2NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigWindowsNodeConfig
{
    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("osversion")]
    public string? Osversion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta2NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    [JsonPropertyName("confidentialNodes")]
    public V1beta2NodePoolSpecInitProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public V1beta2NodePoolSpecInitProviderNodeConfigFastSocket? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta2NodePoolSpecInitProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public V1beta2NodePoolSpecInitProviderNodeConfigGvnic? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta2NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    [JsonPropertyName("kubeletConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>
    /// Possible Local SSD encryption modes:
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("localSsdEncryptionMode")]
    public string? LocalSsdEncryptionMode { get; set; }

    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    [JsonPropertyName("reservationAffinity")]
    public V1beta2NodePoolSpecInitProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta2NodePoolSpecInitProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2NodePoolSpecInitProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta2NodePoolSpecInitProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

/// <summary>
/// Specifies a custom placement policy for the
/// nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderPlacementPolicy
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user.
    /// The resource policy must be in the same project and region as the node pool.
    /// If not found, InvalidArgument error is returned.
    /// </summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU topology like &quot;2x4&quot; or &quot;2x2x2&quot;.</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies node pool-level settings of queued provisioning.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>Percentage of the blue pool nodes to drain in a batch.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>(Optionial) Soak time after each batch gets drained.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary>
/// The settings to adjust blue green upgrades.
/// Structure is documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>
    /// Time needed after draining the entire blue pool.
    /// After this period, the blue pool will be cleaned up.
    /// </summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta2NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}

/// <summary>
/// Specify node upgrade settings to change how GKE upgrades nodes.
/// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecInitProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta2NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>
    /// The number of additional nodes that can be added to the node pool during
    /// an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously.
    /// Can be set to 0 or greater.
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during
    /// an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in
    /// parallel. Can be set to 0 or greater.
    /// </summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>(Default SURGE) The upgrade strategy to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
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
public partial class V1beta2NodePoolSpecInitProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2NodePoolSpecInitProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>
    /// The initial number of nodes for the pool. In
    /// regional or multi-zonal clusters, this is the number of nodes per zone. Changing
    /// this will force recreation of the resource.  If you don&apos;t
    /// need this value, don&apos;t set it.  If you do need it, you can use a lifecycle block to
    /// ignore subsequent changes to this field.
    /// </summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>
    /// Node management configuration, wherein auto-repair and
    /// auto-upgrade is configured. Structure is documented below.
    /// </summary>
    [JsonPropertyName("management")]
    public V1beta2NodePoolSpecInitProviderManagement? Management { get; set; }

    /// <summary>
    /// The maximum number of pods per node in this node pool.
    /// Note that this does not work on node pools which are &quot;route-based&quot; - that is, node
    /// pools belonging to clusters that do not have IP Aliasing enabled.
    /// See the official documentation
    /// for more information.
    /// </summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>
    /// The network configuration of the pool. Such as
    /// configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is
    /// documented below
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2NodePoolSpecInitProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2NodePoolSpecInitProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to
    /// update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The list of zones in which the node pool&apos;s nodes should be located. Nodes must
    /// be in the region of their regional cluster or in the same region as their
    /// cluster&apos;s zone for zonal clusters. If unspecified, the cluster-level
    /// node_locations will be used.
    /// </summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>
    /// Specifies a custom placement policy for the
    /// nodes.
    /// </summary>
    [JsonPropertyName("placementPolicy")]
    public V1beta2NodePoolSpecInitProviderPlacementPolicy? PlacementPolicy { get; set; }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank,
    /// the provider-configured project will be used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Specifies node pool-level settings of queued provisioning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queuedProvisioning")]
    public V1beta2NodePoolSpecInitProviderQueuedProvisioning? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta2NodePoolSpecInitProviderUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecManagementPoliciesEnum>))]
public enum V1beta2NodePoolSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2NodePoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodePoolSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2NodePoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2NodePoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2NodePoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2NodePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>NodePoolSpec defines the desired state of NodePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolSpec
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
    public V1beta2NodePoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2NodePoolSpecForProvider ForProvider { get; set; }

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
    public V1beta2NodePoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2NodePoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2NodePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2NodePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration required by cluster autoscaler to adjust
/// the size of the node pool to the current cluster usage. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderAutoscaling
{
    /// <summary>
    /// Location policy specifies the algorithm used when
    /// scaling-up the node pool. Location policy is supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary>
    /// Maximum number of nodes per zone in the NodePool.
    /// Must be &gt;= min_node_count. Cannot be used with total limits.
    /// </summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>
    /// Minimum number of nodes per zone in the NodePool.
    /// Must be &gt;=0 and &lt;= max_node_count. Cannot be used with total limits.
    /// </summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>
    /// Total maximum number of nodes in the NodePool.
    /// Must be &gt;= total_min_node_count. Cannot be used with per zone limits.
    /// Total size limits are supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public double? TotalMaxNodeCount { get; set; }

    /// <summary>
    /// Total minimum number of nodes in the NodePool.
    /// Must be &gt;=0 and &lt;= total_max_node_count. Cannot be used with per zone limits.
    /// Total size limits are supported only in 1.24.1+ clusters.
    /// </summary>
    [JsonPropertyName("totalMinNodeCount")]
    public double? TotalMinNodeCount { get; set; }
}

/// <summary>
/// Node management configuration, wherein auto-repair and
/// auto-upgrade is configured. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>Name of the VPC where the additional interface belongs.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNetworkConfigAdditionalPodNetworkConfigs
{
    /// <summary>
    /// The maximum number of pods per node in this node pool.
    /// Note that this does not work on node pools which are &quot;route-based&quot; - that is, node
    /// pools belonging to clusters that do not have IP Aliasing enabled.
    /// See the official documentation
    /// for more information.
    /// </summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>The name of the secondary range on the subnet which provides IP address for this pod range.</summary>
    [JsonPropertyName("secondaryPodRange")]
    public string? SecondaryPodRange { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig
{
    /// <summary>Whether pod cidr overprovision is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

/// <summary>
/// The network configuration of the pool. Such as
/// configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is
/// documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNetworkConfig
{
    /// <summary>
    /// We specify the additional node networks for this node pool using this list. Each node network corresponds to an additional interface.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta2NodePoolStatusAtProviderNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary>
    /// We specify the additional pod networks for this node pool using this list. Each pod network corresponds to an additional alias IP range for the node.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta2NodePoolStatusAtProviderNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta2NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta2NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures
{
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigEffectiveTaints
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigKubeletConfig
{
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    [JsonPropertyName("containerLogMaxFiles")]
    public double? ContainerLogMaxFiles { get; set; }

    [JsonPropertyName("containerLogMaxSize")]
    public string? ContainerLogMaxSize { get; set; }

    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    [JsonPropertyName("imageGcHighThresholdPercent")]
    public double? ImageGcHighThresholdPercent { get; set; }

    [JsonPropertyName("imageGcLowThresholdPercent")]
    public double? ImageGcLowThresholdPercent { get; set; }

    [JsonPropertyName("imageMaximumGcAge")]
    public string? ImageMaximumGcAge { get; set; }

    [JsonPropertyName("imageMinimumGcAge")]
    public string? ImageMinimumGcAge { get; set; }

    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    [JsonPropertyName("memoryManager")]
    public V1beta2NodePoolStatusAtProviderNodeConfigKubeletConfigMemoryManager? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    [JsonPropertyName("topologyManager")]
    public V1beta2NodePoolStatusAtProviderNodeConfigKubeletConfigTopologyManager? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigReservationAffinity
{
    /// <summary>
    /// The type of reservation consumption
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name&quot;</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigSecondaryBootDisks
{
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>name&quot;</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta2NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigWindowsNodeConfig
{
    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("osversion")]
    public string? Osversion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Parameters used in creating the node pool. See
/// google_container_cluster for schema.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta2NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    [JsonPropertyName("confidentialNodes")]
    public V1beta2NodePoolStatusAtProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("effectiveTaints")]
    public IList<V1beta2NodePoolStatusAtProviderNodeConfigEffectiveTaints>? EffectiveTaints { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public V1beta2NodePoolStatusAtProviderNodeConfigFastSocket? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta2NodePoolStatusAtProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public V1beta2NodePoolStatusAtProviderNodeConfigGvnic? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta2NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    [JsonPropertyName("kubeletConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>
    /// Possible Local SSD encryption modes:
    /// Accepted values are:
    /// </summary>
    [JsonPropertyName("localSsdEncryptionMode")]
    public string? LocalSsdEncryptionMode { get; set; }

    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    [JsonPropertyName("reservationAffinity")]
    public V1beta2NodePoolStatusAtProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta2NodePoolStatusAtProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta2NodePoolStatusAtProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

/// <summary>
/// Specifies a custom placement policy for the
/// nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderPlacementPolicy
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user.
    /// The resource policy must be in the same project and region as the node pool.
    /// If not found, InvalidArgument error is returned.
    /// </summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU topology like &quot;2x4&quot; or &quot;2x2x2&quot;.</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies node pool-level settings of queued provisioning.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>Percentage of the blue pool nodes to drain in a batch.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>(Optionial) Soak time after each batch gets drained.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary>
/// The settings to adjust blue green upgrades.
/// Structure is documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>
    /// Time needed after draining the entire blue pool.
    /// After this period, the blue pool will be cleaned up.
    /// </summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta2NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}

/// <summary>
/// Specify node upgrade settings to change how GKE upgrades nodes.
/// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta2NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>
    /// The number of additional nodes that can be added to the node pool during
    /// an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously.
    /// Can be set to 0 or greater.
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>
    /// The number of nodes that can be simultaneously unavailable during
    /// an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in
    /// parallel. Can be set to 0 or greater.
    /// </summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>(Default SURGE) The upgrade strategy to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusAtProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta2NodePoolStatusAtProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>The cluster to create the node pool for. Cluster must be present in location provided for clusters. May be specified in the format projects/{{project}}/locations/{{location}}/clusters/{{cluster}} or as just the name of the cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{location}}/{{cluster}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The initial number of nodes for the pool. In
    /// regional or multi-zonal clusters, this is the number of nodes per zone. Changing
    /// this will force recreation of the resource.  If you don&apos;t
    /// need this value, don&apos;t set it.  If you do need it, you can use a lifecycle block to
    /// ignore subsequent changes to this field.
    /// </summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>The resource URLs of the managed instance groups associated with this node pool.</summary>
    [JsonPropertyName("instanceGroupUrls")]
    public IList<string>? InstanceGroupUrls { get; set; }

    /// <summary>The location (region or zone) of the cluster.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>List of instance group URLs which have been assigned to this node pool.</summary>
    [JsonPropertyName("managedInstanceGroupUrls")]
    public IList<string>? ManagedInstanceGroupUrls { get; set; }

    /// <summary>
    /// Node management configuration, wherein auto-repair and
    /// auto-upgrade is configured. Structure is documented below.
    /// </summary>
    [JsonPropertyName("management")]
    public V1beta2NodePoolStatusAtProviderManagement? Management { get; set; }

    /// <summary>
    /// The maximum number of pods per node in this node pool.
    /// Note that this does not work on node pools which are &quot;route-based&quot; - that is, node
    /// pools belonging to clusters that do not have IP Aliasing enabled.
    /// See the official documentation
    /// for more information.
    /// </summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>
    /// The network configuration of the pool. Such as
    /// configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is
    /// documented below
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2NodePoolStatusAtProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2NodePoolStatusAtProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to
    /// update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The list of zones in which the node pool&apos;s nodes should be located. Nodes must
    /// be in the region of their regional cluster or in the same region as their
    /// cluster&apos;s zone for zonal clusters. If unspecified, the cluster-level
    /// node_locations will be used.
    /// </summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>
    /// Specifies a custom placement policy for the
    /// nodes.
    /// </summary>
    [JsonPropertyName("placementPolicy")]
    public V1beta2NodePoolStatusAtProviderPlacementPolicy? PlacementPolicy { get; set; }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank,
    /// the provider-configured project will be used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Specifies node pool-level settings of queued provisioning.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queuedProvisioning")]
    public V1beta2NodePoolStatusAtProviderQueuedProvisioning? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta2NodePoolStatusAtProviderUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatusConditions
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

/// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodePoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2NodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2NodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NodePool is the Schema for the NodePools API. Manages a GKE NodePool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2NodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2NodePoolSpec>, IStatus<V1beta2NodePoolStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "NodePool";
    public const string KubeGroup = "container.gcp.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodePool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodePoolSpec defines the desired state of NodePool</summary>
    [JsonPropertyName("spec")]
    public required V1beta2NodePoolSpec Spec { get; set; }

    /// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
    [JsonPropertyName("status")]
    public V1beta2NodePoolStatus? Status { get; set; }
}