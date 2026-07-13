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
/// <summary>
/// NodePool is the Schema for the NodePools API. Manages a GKE NodePool resource.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NodePool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePoolList";
    public const string KubeGroup = "container.gcp.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodePoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NodePool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NodePool> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderAutoscaling
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderClusterRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderClusterSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderClusterSelector
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
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderManagement
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigAdditionalNodeNetworkConfigs
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigAdditionalPodNetworkConfigs
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig
{
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNetworkConfig
{
    /// <summary>
    /// We specify the additional node networks for this node pool using this list. Each node network corresponds to an additional interface.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta1NodePoolSpecForProviderNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary>
    /// We specify the additional pod networks for this node pool using this list. Each pod network corresponds to an additional alias IP range for the node.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta1NodePoolSpecForProviderNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    [JsonPropertyName("networkPerformanceConfig")]
    public IList<V1beta1NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig>? NetworkPerformanceConfig { get; set; }

    [JsonPropertyName("podCidrOverprovisionConfig")]
    public IList<V1beta1NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig>? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig>? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig>? PrivateRegistryAccessConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig>? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig>? GpuSharingConfig { get; set; }

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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfig
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
    public IList<V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigMemoryManager>? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    [JsonPropertyName("topologyManager")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigTopologyManager>? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig>? HugepagesConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigReservationAffinity
{
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSecondaryBootDisks
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelector
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
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigWindowsNodeConfig
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigConfidentialNodes>? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfig>? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig>? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigFastSocket>? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGcfsConfig>? GcfsConfig { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGvnic>? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigHostMaintenancePolicy>? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigKubeletConfig>? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("linuxNodeConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfig>? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig>? LocalNvmeSsdBlockConfig { get; set; }

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
    public IList<V1beta1NodePoolSpecForProviderNodeConfigReservationAffinity>? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfig>? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("windowsNodeConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigWindowsNodeConfig>? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig>? WorkloadMetadataConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderPlacementPolicy
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user.
    /// The resource policy must be in the same project and region as the node pool.
    /// If not found, InvalidArgument error is returned.
    /// </summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU placement topology for pod slice node pool.</summary>
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>
    /// Time needed after draining the entire blue pool.
    /// After this period, the blue pool will be cleaned up.
    /// </summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public IList<V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy>? StandardRolloutPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public IList<V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettings>? BlueGreenSettings { get; set; }

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

    /// <summary>(Default SURGE) The upgrade stragey to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecForProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolSpecForProviderAutoscaling>? Autoscaling { get; set; }

    /// <summary>The cluster to create the node pool for. Cluster must be present in location provided for clusters. May be specified in the format projects/{{project}}/locations/{{location}}/clusters/{{cluster}} or as just the name of the cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1NodePoolSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1NodePoolSpecForProviderClusterSelector? ClusterSelector { get; set; }

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
    public IList<V1beta1NodePoolSpecForProviderManagement>? Management { get; set; }

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
    public IList<V1beta1NodePoolSpecForProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfig>? NodeConfig { get; set; }

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
    public IList<V1beta1NodePoolSpecForProviderPlacementPolicy>? PlacementPolicy { get; set; }

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
    public IList<V1beta1NodePoolSpecForProviderQueuedProvisioning>? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1NodePoolSpecForProviderUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderAutoscaling
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderManagement
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigAdditionalNodeNetworkConfigs
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigAdditionalPodNetworkConfigs
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig
{
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfig
{
    /// <summary>
    /// We specify the additional node networks for this node pool using this list. Each node network corresponds to an additional interface.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary>
    /// We specify the additional pod networks for this node pool using this list. Each pod network corresponds to an additional alias IP range for the node.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    [JsonPropertyName("networkPerformanceConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig>? NetworkPerformanceConfig { get; set; }

    [JsonPropertyName("podCidrOverprovisionConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig>? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig>? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig>? PrivateRegistryAccessConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig>? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig>? GpuSharingConfig { get; set; }

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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfig
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
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigMemoryManager>? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    [JsonPropertyName("topologyManager")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigTopologyManager>? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig>? HugepagesConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigReservationAffinity
{
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSecondaryBootDisks
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelector
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
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigWindowsNodeConfig
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigConfidentialNodes>? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfig>? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig>? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigFastSocket>? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGcfsConfig>? GcfsConfig { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGvnic>? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy>? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfig>? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("linuxNodeConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfig>? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig>? LocalNvmeSsdBlockConfig { get; set; }

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
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigReservationAffinity>? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfig>? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("windowsNodeConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigWindowsNodeConfig>? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig>? WorkloadMetadataConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderPlacementPolicy
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user.
    /// The resource policy must be in the same project and region as the node pool.
    /// If not found, InvalidArgument error is returned.
    /// </summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU placement topology for pod slice node pool.</summary>
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>
    /// Time needed after draining the entire blue pool.
    /// After this period, the blue pool will be cleaned up.
    /// </summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public IList<V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy>? StandardRolloutPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public IList<V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettings>? BlueGreenSettings { get; set; }

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

    /// <summary>(Default SURGE) The upgrade stragey to be used for upgrading the nodes.</summary>
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecInitProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolSpecInitProviderAutoscaling>? Autoscaling { get; set; }

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
    public IList<V1beta1NodePoolSpecInitProviderManagement>? Management { get; set; }

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
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfig>? NodeConfig { get; set; }

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
    public IList<V1beta1NodePoolSpecInitProviderPlacementPolicy>? PlacementPolicy { get; set; }

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
    public IList<V1beta1NodePoolSpecInitProviderQueuedProvisioning>? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1NodePoolSpecInitProviderUpgradeSettings>? UpgradeSettings { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpecWriteConnectionSecretToRef
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolSpec
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
    public V1beta1NodePoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1NodePoolSpecForProvider ForProvider { get; set; }

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
    public V1beta1NodePoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1NodePoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderAutoscaling
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderManagement
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigAdditionalNodeNetworkConfigs
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigAdditionalPodNetworkConfigs
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig
{
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfig
{
    /// <summary>
    /// We specify the additional node networks for this node pool using this list. Each node network corresponds to an additional interface.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary>
    /// We specify the additional pod networks for this node pool using this list. Each pod network corresponds to an additional alias IP range for the node.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    [JsonPropertyName("networkPerformanceConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig>? NetworkPerformanceConfig { get; set; }

    [JsonPropertyName("podCidrOverprovisionConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig>? PodCidrOverprovisionConfig { get; set; }

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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig>? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig>? PrivateRegistryAccessConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigEffectiveTaints
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig>? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig>? GpuSharingConfig { get; set; }

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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfig
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
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigMemoryManager>? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    [JsonPropertyName("topologyManager")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigTopologyManager>? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig>? HugepagesConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigReservationAffinity
{
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSecondaryBootDisks
{
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigWindowsNodeConfig
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigConfidentialNodes>? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfig>? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("effectiveTaints")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigEffectiveTaints>? EffectiveTaints { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig>? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigFastSocket>? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGcfsConfig>? GcfsConfig { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGvnic>? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy>? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfig>? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("linuxNodeConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfig>? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig>? LocalNvmeSsdBlockConfig { get; set; }

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
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigReservationAffinity>? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfig>? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("windowsNodeConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigWindowsNodeConfig>? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig>? WorkloadMetadataConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderPlacementPolicy
{
    /// <summary>
    /// If set, refers to the name of a custom resource policy supplied by the user.
    /// The resource policy must be in the same project and region as the node pool.
    /// If not found, InvalidArgument error is returned.
    /// </summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU placement topology for pod slice node pool.</summary>
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>
    /// Time needed after draining the entire blue pool.
    /// After this period, the blue pool will be cleaned up.
    /// </summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public IList<V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy>? StandardRolloutPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public IList<V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettings>? BlueGreenSettings { get; set; }

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

    /// <summary>(Default SURGE) The upgrade stragey to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusAtProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolStatusAtProviderAutoscaling>? Autoscaling { get; set; }

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
    public IList<V1beta1NodePoolStatusAtProviderManagement>? Management { get; set; }

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
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>
    /// Parameters used in creating the node pool. See
    /// google_container_cluster for schema.
    /// </summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfig>? NodeConfig { get; set; }

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
    public IList<V1beta1NodePoolStatusAtProviderPlacementPolicy>? PlacementPolicy { get; set; }

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
    public IList<V1beta1NodePoolStatusAtProviderQueuedProvisioning>? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1NodePoolStatusAtProviderUpgradeSettings>? UpgradeSettings { get; set; }

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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatusConditions
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
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1NodePoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1NodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// NodePool is the Schema for the NodePools API. Manages a GKE NodePool resource.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodePoolSpec>, IStatus<V1beta1NodePoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePool";
    public const string KubeGroup = "container.gcp.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodePool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodePoolSpec defines the desired state of NodePool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NodePoolSpec Spec { get; set; }

    /// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
    [JsonPropertyName("status")]
    public V1beta1NodePoolStatus? Status { get; set; }
}