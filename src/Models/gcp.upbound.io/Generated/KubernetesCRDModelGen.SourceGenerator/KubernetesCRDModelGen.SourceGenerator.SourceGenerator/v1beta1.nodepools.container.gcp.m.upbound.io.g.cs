#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.container.gcp.m.upbound.io;
/// <summary>NodePool is the Schema for the NodePools API. Manages a GKE NodePool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NodePool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePoolList";
    public const string KubeGroup = "container.gcp.m.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.gcp.m.upbound.io/v1beta1";

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
/// Configuration required by cluster autoscaler to adjust
/// the size of the node pool to the current cluster usage. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum>))]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum>))]
public enum V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum>))]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum>))]
public enum V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Node management configuration, wherein auto-repair and
/// auto-upgrade is configured. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>Name of the VPC where the additional interface belongs.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNetworkConfig
{
    /// <summary>Specifies the accelerator network profile for nodes in this node pool. Setting to &quot;auto&quot; enables GKE to automatically configure high-performance networking settings for nodes with accelerators (like GPUs). GKE manages the underlying resources (like VPCs and subnets) for this configuration.</summary>
    [JsonPropertyName("acceleratorNetworkProfile")]
    public string? AcceleratorNetworkProfile { get; set; }

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

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures
{
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigBootDisk
{
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsCa
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsClientCert
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

/// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsClientKey
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsClient
{
    [JsonPropertyName("cert")]
    public V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsClientCert? Cert { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsClientKey? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsHeader
{
    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHosts
{
    [JsonPropertyName("ca")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsCa>? Ca { get; set; }

    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    [JsonPropertyName("client")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsClient>? Client { get; set; }

    [JsonPropertyName("dialTimeout")]
    public string? DialTimeout { get; set; }

    [JsonPropertyName("header")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHostsHeader>? Header { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("overridePath")]
    public bool? OverridePath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHosts
{
    [JsonPropertyName("hosts")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHostsHosts>? Hosts { get; set; }

    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigWritableCgroups
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }

    [JsonPropertyName("registryHosts")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigRegistryHosts>? RegistryHosts { get; set; }

    [JsonPropertyName("writableCgroups")]
    public V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigWritableCgroups? WritableCgroups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigCrashLoopBackOff
{
    [JsonPropertyName("maxContainerRestartPeriod")]
    public string? MaxContainerRestartPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigEvictionMinimumReclaim
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigEvictionSoft
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigEvictionSoftGracePeriod
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Node kubelet configs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    [JsonPropertyName("crashLoopBackOff")]
    public V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigCrashLoopBackOff? CrashLoopBackOff { get; set; }

    [JsonPropertyName("evictionMaxPodGracePeriodSeconds")]
    public double? EvictionMaxPodGracePeriodSeconds { get; set; }

    [JsonPropertyName("evictionMinimumReclaim")]
    public V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigEvictionMinimumReclaim? EvictionMinimumReclaim { get; set; }

    [JsonPropertyName("evictionSoft")]
    public V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigEvictionSoft? EvictionSoft { get; set; }

    [JsonPropertyName("evictionSoftGracePeriod")]
    public V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigEvictionSoftGracePeriod? EvictionSoftGracePeriod { get; set; }

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

    [JsonPropertyName("maxParallelImagePulls")]
    public double? MaxParallelImagePulls { get; set; }

    [JsonPropertyName("memoryManager")]
    public V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigMemoryManager? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    /// <summary>The grace period (in seconds) to use during a graceful node shutdown for critical pods. This value must be less than or equal to shutdown_grace_period_seconds. This field can only be configured if the node pool uses Spot VMs or Preemptible VMs.</summary>
    [JsonPropertyName("shutdownGracePeriodCriticalPodsSeconds")]
    public double? ShutdownGracePeriodCriticalPodsSeconds { get; set; }

    /// <summary>The grace period (in seconds) to use during a graceful node shutdown. This is the time allocated for all pods (critical and non-critical) to terminate. The value must be between 10 and 10000. This field can only be configured if the node pool uses Spot VMs or Preemptible VMs.</summary>
    [JsonPropertyName("shutdownGracePeriodSeconds")]
    public double? ShutdownGracePeriodSeconds { get; set; }

    [JsonPropertyName("singleProcessOomKill")]
    public bool? SingleProcessOomKill { get; set; }

    [JsonPropertyName("topologyManager")]
    public V1beta1NodePoolSpecForProviderNodeConfigKubeletConfigTopologyManager? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigAccurateTimeConfig
{
    [JsonPropertyName("enablePtpKvmTimeSync")]
    public bool? EnablePtpKvmTimeSync { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigNodeKernelModuleLoading
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigBootDiskProfile
{
    [JsonPropertyName("swapSizeGib")]
    public double? SwapSizeGib { get; set; }

    [JsonPropertyName("swapSizePercent")]
    public double? SwapSizePercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigDedicatedLocalSsdProfile
{
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigEncryptionConfig
{
    /// <summary>Whether pod cidr overprovision is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigEphemeralLocalSsdProfile
{
    [JsonPropertyName("swapSizeGib")]
    public double? SwapSizeGib { get; set; }

    [JsonPropertyName("swapSizePercent")]
    public double? SwapSizePercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfig
{
    [JsonPropertyName("bootDiskProfile")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigBootDiskProfile? BootDiskProfile { get; set; }

    [JsonPropertyName("dedicatedLocalSsdProfile")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigDedicatedLocalSsdProfile? DedicatedLocalSsdProfile { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("encryptionConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigEncryptionConfig? EncryptionConfig { get; set; }

    [JsonPropertyName("ephemeralLocalSsdProfile")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfigEphemeralLocalSsdProfile? EphemeralLocalSsdProfile { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("accurateTimeConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigAccurateTimeConfig? AccurateTimeConfig { get; set; }

    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    [JsonPropertyName("nodeKernelModuleLoading")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigNodeKernelModuleLoading? NodeKernelModuleLoading { get; set; }

    [JsonPropertyName("swapConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfigSwapConfig? SwapConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }

    [JsonPropertyName("transparentHugepageDefrag")]
    public string? TransparentHugepageDefrag { get; set; }

    [JsonPropertyName("transparentHugepageEnabled")]
    public string? TransparentHugepageEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigNodeImageConfig
{
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank,
    /// the provider-configured project will be used.
    /// </summary>
    [JsonPropertyName("imageProject")]
    public string? ImageProject { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigReservationAffinity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSandboxConfig
{
    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Taint configuration for the node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigTaintConfig
{
    /// <summary>Specifies the behavior for applying architecture taints to node pool nodes. Valid values are ARCHITECTURE_TAINT_BEHAVIOR_UNSPECIFIED, NONE, or ARM.</summary>
    [JsonPropertyName("architectureTaintBehavior")]
    public string? ArchitectureTaintBehavior { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDisk")]
    public V1beta1NodePoolSpecForProviderNodeConfigBootDisk? BootDisk { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    [JsonPropertyName("confidentialNodes")]
    public V1beta1NodePoolSpecForProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public V1beta1NodePoolSpecForProviderNodeConfigFastSocket? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    [JsonPropertyName("gpudirectStrategy")]
    public string? GpudirectStrategy { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public V1beta1NodePoolSpecForProviderNodeConfigGvnic? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1NodePoolSpecForProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Node kubelet configs. Structure is documented below.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

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

    [JsonPropertyName("nodeImageConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigNodeImageConfig>? NodeImageConfig { get; set; }

    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    [JsonPropertyName("reservationAffinity")]
    public V1beta1NodePoolSpecForProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("sandboxConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigSandboxConfig? SandboxConfig { get; set; }

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
    public V1beta1NodePoolSpecForProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>Taint configuration for the node pool. Structure is documented below.</summary>
    [JsonPropertyName("taintConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigTaintConfig? TaintConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeDrainConfig
{
    /// <summary>The duration of the grace termination period for node drain.</summary>
    [JsonPropertyName("graceTerminationDuration")]
    public string? GraceTerminationDuration { get; set; }

    /// <summary>The duration of the PDB timeout period for node drain.</summary>
    [JsonPropertyName("pdbTimeoutDuration")]
    public string? PdbTimeoutDuration { get; set; }

    /// <summary>Whether to respect PodDisruptionBudget policy during node pool deletion.</summary>
    [JsonPropertyName("respectPdbDuringNodePoolDeletion")]
    public bool? RespectPdbDuringNodePoolDeletion { get; set; }
}

/// <summary>
/// Specifies a custom placement policy for the
/// nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderPlacementPolicy
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>
/// The settings to adjust blue green upgrades.
/// Structure is documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}

/// <summary>
/// Specify node upgrade settings to change how GKE upgrades nodes.
/// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1NodePoolSpecForProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>The cluster to create the node pool for. Cluster must be present in location provided for clusters. May be specified in the format projects/{{project}}/locations/{{location}}/clusters/{{cluster}} or as just the name of the cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1NodePoolSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1NodePoolSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>Whether to ignore external changes (drift) to the node count (e.g. from GKE autoscaling). Setting this to true skips querying Compute Engine Instance Group Managers (IGMs) to determine the current node count on read, which can save API quota and speed up plans on large clusters.</summary>
    [JsonPropertyName("ignoreNodeCountChanges")]
    public bool? IgnoreNodeCountChanges { get; set; }

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
    public V1beta1NodePoolSpecForProviderManagement? Management { get; set; }

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
    public V1beta1NodePoolSpecForProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1NodePoolSpecForProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to
    /// update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The node drain configuration of the pool. Structure is documented below.</summary>
    [JsonPropertyName("nodeDrainConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeDrainConfig>? NodeDrainConfig { get; set; }

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
    public V1beta1NodePoolSpecForProviderPlacementPolicy? PlacementPolicy { get; set; }

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
    public V1beta1NodePoolSpecForProviderQueuedProvisioning? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1NodePoolSpecForProviderUpgradeSettings? UpgradeSettings { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>
/// Node management configuration, wherein auto-repair and
/// auto-upgrade is configured. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>Name of the VPC where the additional interface belongs.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfig
{
    /// <summary>Specifies the accelerator network profile for nodes in this node pool. Setting to &quot;auto&quot; enables GKE to automatically configure high-performance networking settings for nodes with accelerators (like GPUs). GKE manages the underlying resources (like VPCs and subnets) for this configuration.</summary>
    [JsonPropertyName("acceleratorNetworkProfile")]
    public string? AcceleratorNetworkProfile { get; set; }

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

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures
{
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigBootDisk
{
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsCa
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsClientCert
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

/// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsClientKey
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsClient
{
    [JsonPropertyName("cert")]
    public V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsClientCert? Cert { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsClientKey? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsHeader
{
    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHosts
{
    [JsonPropertyName("ca")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsCa>? Ca { get; set; }

    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    [JsonPropertyName("client")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsClient>? Client { get; set; }

    [JsonPropertyName("dialTimeout")]
    public string? DialTimeout { get; set; }

    [JsonPropertyName("header")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHostsHeader>? Header { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("overridePath")]
    public bool? OverridePath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHosts
{
    [JsonPropertyName("hosts")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHostsHosts>? Hosts { get; set; }

    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigWritableCgroups
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }

    [JsonPropertyName("registryHosts")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigRegistryHosts>? RegistryHosts { get; set; }

    [JsonPropertyName("writableCgroups")]
    public V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigWritableCgroups? WritableCgroups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigCrashLoopBackOff
{
    [JsonPropertyName("maxContainerRestartPeriod")]
    public string? MaxContainerRestartPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigEvictionMinimumReclaim
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigEvictionSoft
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigEvictionSoftGracePeriod
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Node kubelet configs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    [JsonPropertyName("crashLoopBackOff")]
    public V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigCrashLoopBackOff? CrashLoopBackOff { get; set; }

    [JsonPropertyName("evictionMaxPodGracePeriodSeconds")]
    public double? EvictionMaxPodGracePeriodSeconds { get; set; }

    [JsonPropertyName("evictionMinimumReclaim")]
    public V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigEvictionMinimumReclaim? EvictionMinimumReclaim { get; set; }

    [JsonPropertyName("evictionSoft")]
    public V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigEvictionSoft? EvictionSoft { get; set; }

    [JsonPropertyName("evictionSoftGracePeriod")]
    public V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigEvictionSoftGracePeriod? EvictionSoftGracePeriod { get; set; }

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

    [JsonPropertyName("maxParallelImagePulls")]
    public double? MaxParallelImagePulls { get; set; }

    [JsonPropertyName("memoryManager")]
    public V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigMemoryManager? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    /// <summary>The grace period (in seconds) to use during a graceful node shutdown for critical pods. This value must be less than or equal to shutdown_grace_period_seconds. This field can only be configured if the node pool uses Spot VMs or Preemptible VMs.</summary>
    [JsonPropertyName("shutdownGracePeriodCriticalPodsSeconds")]
    public double? ShutdownGracePeriodCriticalPodsSeconds { get; set; }

    /// <summary>The grace period (in seconds) to use during a graceful node shutdown. This is the time allocated for all pods (critical and non-critical) to terminate. The value must be between 10 and 10000. This field can only be configured if the node pool uses Spot VMs or Preemptible VMs.</summary>
    [JsonPropertyName("shutdownGracePeriodSeconds")]
    public double? ShutdownGracePeriodSeconds { get; set; }

    [JsonPropertyName("singleProcessOomKill")]
    public bool? SingleProcessOomKill { get; set; }

    [JsonPropertyName("topologyManager")]
    public V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfigTopologyManager? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigAccurateTimeConfig
{
    [JsonPropertyName("enablePtpKvmTimeSync")]
    public bool? EnablePtpKvmTimeSync { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigNodeKernelModuleLoading
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigBootDiskProfile
{
    [JsonPropertyName("swapSizeGib")]
    public double? SwapSizeGib { get; set; }

    [JsonPropertyName("swapSizePercent")]
    public double? SwapSizePercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigDedicatedLocalSsdProfile
{
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigEncryptionConfig
{
    /// <summary>Whether pod cidr overprovision is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigEphemeralLocalSsdProfile
{
    [JsonPropertyName("swapSizeGib")]
    public double? SwapSizeGib { get; set; }

    [JsonPropertyName("swapSizePercent")]
    public double? SwapSizePercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfig
{
    [JsonPropertyName("bootDiskProfile")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigBootDiskProfile? BootDiskProfile { get; set; }

    [JsonPropertyName("dedicatedLocalSsdProfile")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigDedicatedLocalSsdProfile? DedicatedLocalSsdProfile { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("encryptionConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigEncryptionConfig? EncryptionConfig { get; set; }

    [JsonPropertyName("ephemeralLocalSsdProfile")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfigEphemeralLocalSsdProfile? EphemeralLocalSsdProfile { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("accurateTimeConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigAccurateTimeConfig? AccurateTimeConfig { get; set; }

    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    [JsonPropertyName("nodeKernelModuleLoading")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigNodeKernelModuleLoading? NodeKernelModuleLoading { get; set; }

    [JsonPropertyName("swapConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfigSwapConfig? SwapConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }

    [JsonPropertyName("transparentHugepageDefrag")]
    public string? TransparentHugepageDefrag { get; set; }

    [JsonPropertyName("transparentHugepageEnabled")]
    public string? TransparentHugepageEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigNodeImageConfig
{
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank,
    /// the provider-configured project will be used.
    /// </summary>
    [JsonPropertyName("imageProject")]
    public string? ImageProject { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigReservationAffinity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSandboxConfig
{
    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Taint configuration for the node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigTaintConfig
{
    /// <summary>Specifies the behavior for applying architecture taints to node pool nodes. Valid values are ARCHITECTURE_TAINT_BEHAVIOR_UNSPECIFIED, NONE, or ARM.</summary>
    [JsonPropertyName("architectureTaintBehavior")]
    public string? ArchitectureTaintBehavior { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDisk")]
    public V1beta1NodePoolSpecInitProviderNodeConfigBootDisk? BootDisk { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    [JsonPropertyName("confidentialNodes")]
    public V1beta1NodePoolSpecInitProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public V1beta1NodePoolSpecInitProviderNodeConfigFastSocket? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    [JsonPropertyName("gpudirectStrategy")]
    public string? GpudirectStrategy { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public V1beta1NodePoolSpecInitProviderNodeConfigGvnic? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Node kubelet configs. Structure is documented below.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

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

    [JsonPropertyName("nodeImageConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigNodeImageConfig>? NodeImageConfig { get; set; }

    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    [JsonPropertyName("reservationAffinity")]
    public V1beta1NodePoolSpecInitProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("sandboxConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigSandboxConfig? SandboxConfig { get; set; }

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
    public V1beta1NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>Taint configuration for the node pool. Structure is documented below.</summary>
    [JsonPropertyName("taintConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigTaintConfig? TaintConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeDrainConfig
{
    /// <summary>The duration of the grace termination period for node drain.</summary>
    [JsonPropertyName("graceTerminationDuration")]
    public string? GraceTerminationDuration { get; set; }

    /// <summary>The duration of the PDB timeout period for node drain.</summary>
    [JsonPropertyName("pdbTimeoutDuration")]
    public string? PdbTimeoutDuration { get; set; }

    /// <summary>Whether to respect PodDisruptionBudget policy during node pool deletion.</summary>
    [JsonPropertyName("respectPdbDuringNodePoolDeletion")]
    public bool? RespectPdbDuringNodePoolDeletion { get; set; }
}

/// <summary>
/// Specifies a custom placement policy for the
/// nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderPlacementPolicy
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>
/// The settings to adjust blue green upgrades.
/// Structure is documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}

/// <summary>
/// Specify node upgrade settings to change how GKE upgrades nodes.
/// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1NodePoolSpecInitProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>Whether to ignore external changes (drift) to the node count (e.g. from GKE autoscaling). Setting this to true skips querying Compute Engine Instance Group Managers (IGMs) to determine the current node count on read, which can save API quota and speed up plans on large clusters.</summary>
    [JsonPropertyName("ignoreNodeCountChanges")]
    public bool? IgnoreNodeCountChanges { get; set; }

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
    public V1beta1NodePoolSpecInitProviderManagement? Management { get; set; }

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
    public V1beta1NodePoolSpecInitProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1NodePoolSpecInitProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to
    /// update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The node drain configuration of the pool. Structure is documented below.</summary>
    [JsonPropertyName("nodeDrainConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeDrainConfig>? NodeDrainConfig { get; set; }

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
    public V1beta1NodePoolSpecInitProviderPlacementPolicy? PlacementPolicy { get; set; }

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
    public V1beta1NodePoolSpecInitProviderQueuedProvisioning? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1NodePoolSpecInitProviderUpgradeSettings? UpgradeSettings { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecManagementPoliciesEnum>))]
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>NodePoolSpec defines the desired state of NodePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpec
{
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

/// <summary>
/// Configuration required by cluster autoscaler to adjust
/// the size of the node pool to the current cluster usage. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>
/// Node management configuration, wherein auto-repair and
/// auto-upgrade is configured. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>Name of the VPC where the additional interface belongs.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The subnetwork path for the node pool. Format: projects/{project}/regions/{region}/subnetworks/{subnetwork}. If the cluster is associated with multiple subnetworks, the subnetwork for the node pool is picked based on the IP utilization during node pool creation and is immutable</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for the NodePool. Valid values include: &quot;TIER_1&quot; and &quot;TIER_UNSPECIFIED&quot;.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfig
{
    /// <summary>Specifies the accelerator network profile for nodes in this node pool. Setting to &quot;auto&quot; enables GKE to automatically configure high-performance networking settings for nodes with accelerators (like GPUs). GKE manages the underlying resources (like VPCs and subnets) for this configuration.</summary>
    [JsonPropertyName("acceleratorNetworkProfile")]
    public string? AcceleratorNetworkProfile { get; set; }

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

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration for node-pool level pod cidr overprovision. If not set, the cluster level setting will be inherited. Structure is documented below.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures
{
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigBootDisk
{
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigConfidentialNodes
{
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsCa
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsClientCert
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

/// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsClientKey
{
    [JsonPropertyName("gcpSecretManagerSecretUri")]
    public string? GcpSecretManagerSecretUri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsClient
{
    [JsonPropertyName("cert")]
    public V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsClientCert? Cert { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsClientKey? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsHeader
{
    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHosts
{
    [JsonPropertyName("ca")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsCa>? Ca { get; set; }

    [JsonPropertyName("capabilities")]
    public IList<string>? Capabilities { get; set; }

    [JsonPropertyName("client")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsClient>? Client { get; set; }

    [JsonPropertyName("dialTimeout")]
    public string? DialTimeout { get; set; }

    [JsonPropertyName("header")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHostsHeader>? Header { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("overridePath")]
    public bool? OverridePath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHosts
{
    [JsonPropertyName("hosts")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHostsHosts>? Hosts { get; set; }

    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigWritableCgroups
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfig
{
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }

    [JsonPropertyName("registryHosts")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigRegistryHosts>? RegistryHosts { get; set; }

    [JsonPropertyName("writableCgroups")]
    public V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigWritableCgroups? WritableCgroups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigEffectiveTaints
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAccelerator
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy
{
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigCrashLoopBackOff
{
    [JsonPropertyName("maxContainerRestartPeriod")]
    public string? MaxContainerRestartPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigEvictionMinimumReclaim
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigEvictionSoft
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigEvictionSoftGracePeriod
{
    [JsonPropertyName("imagefsAvailable")]
    public string? ImagefsAvailable { get; set; }

    [JsonPropertyName("imagefsInodesFree")]
    public string? ImagefsInodesFree { get; set; }

    [JsonPropertyName("memoryAvailable")]
    public string? MemoryAvailable { get; set; }

    [JsonPropertyName("nodefsAvailable")]
    public string? NodefsAvailable { get; set; }

    [JsonPropertyName("nodefsInodesFree")]
    public string? NodefsInodesFree { get; set; }

    [JsonPropertyName("pidAvailable")]
    public string? PidAvailable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigMemoryManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigTopologyManager
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>Node kubelet configs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

    [JsonPropertyName("crashLoopBackOff")]
    public V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigCrashLoopBackOff? CrashLoopBackOff { get; set; }

    [JsonPropertyName("evictionMaxPodGracePeriodSeconds")]
    public double? EvictionMaxPodGracePeriodSeconds { get; set; }

    [JsonPropertyName("evictionMinimumReclaim")]
    public V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigEvictionMinimumReclaim? EvictionMinimumReclaim { get; set; }

    [JsonPropertyName("evictionSoft")]
    public V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigEvictionSoft? EvictionSoft { get; set; }

    [JsonPropertyName("evictionSoftGracePeriod")]
    public V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigEvictionSoftGracePeriod? EvictionSoftGracePeriod { get; set; }

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

    [JsonPropertyName("maxParallelImagePulls")]
    public double? MaxParallelImagePulls { get; set; }

    [JsonPropertyName("memoryManager")]
    public V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigMemoryManager? MemoryManager { get; set; }

    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }

    /// <summary>The grace period (in seconds) to use during a graceful node shutdown for critical pods. This value must be less than or equal to shutdown_grace_period_seconds. This field can only be configured if the node pool uses Spot VMs or Preemptible VMs.</summary>
    [JsonPropertyName("shutdownGracePeriodCriticalPodsSeconds")]
    public double? ShutdownGracePeriodCriticalPodsSeconds { get; set; }

    /// <summary>The grace period (in seconds) to use during a graceful node shutdown. This is the time allocated for all pods (critical and non-critical) to terminate. The value must be between 10 and 10000. This field can only be configured if the node pool uses Spot VMs or Preemptible VMs.</summary>
    [JsonPropertyName("shutdownGracePeriodSeconds")]
    public double? ShutdownGracePeriodSeconds { get; set; }

    [JsonPropertyName("singleProcessOomKill")]
    public bool? SingleProcessOomKill { get; set; }

    [JsonPropertyName("topologyManager")]
    public V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfigTopologyManager? TopologyManager { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigAccurateTimeConfig
{
    [JsonPropertyName("enablePtpKvmTimeSync")]
    public bool? EnablePtpKvmTimeSync { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigNodeKernelModuleLoading
{
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigBootDiskProfile
{
    [JsonPropertyName("swapSizeGib")]
    public double? SwapSizeGib { get; set; }

    [JsonPropertyName("swapSizePercent")]
    public double? SwapSizePercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigDedicatedLocalSsdProfile
{
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigEncryptionConfig
{
    /// <summary>Whether pod cidr overprovision is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigEphemeralLocalSsdProfile
{
    [JsonPropertyName("swapSizeGib")]
    public double? SwapSizeGib { get; set; }

    [JsonPropertyName("swapSizePercent")]
    public double? SwapSizePercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfig
{
    [JsonPropertyName("bootDiskProfile")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigBootDiskProfile? BootDiskProfile { get; set; }

    [JsonPropertyName("dedicatedLocalSsdProfile")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigDedicatedLocalSsdProfile? DedicatedLocalSsdProfile { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("encryptionConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigEncryptionConfig? EncryptionConfig { get; set; }

    [JsonPropertyName("ephemeralLocalSsdProfile")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfigEphemeralLocalSsdProfile? EphemeralLocalSsdProfile { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfig
{
    [JsonPropertyName("accurateTimeConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigAccurateTimeConfig? AccurateTimeConfig { get; set; }

    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    [JsonPropertyName("hugepagesConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    [JsonPropertyName("nodeKernelModuleLoading")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigNodeKernelModuleLoading? NodeKernelModuleLoading { get; set; }

    [JsonPropertyName("swapConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfigSwapConfig? SwapConfig { get; set; }

    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }

    [JsonPropertyName("transparentHugepageDefrag")]
    public string? TransparentHugepageDefrag { get; set; }

    [JsonPropertyName("transparentHugepageEnabled")]
    public string? TransparentHugepageEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig
{
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigNodeImageConfig
{
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The ID of the project in which to create the node pool. If blank,
    /// the provider-configured project will be used.
    /// </summary>
    [JsonPropertyName("imageProject")]
    public string? ImageProject { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigReservationAffinity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSandboxConfig
{
    /// <summary>
    /// The type of the policy. Supports a single value: COMPACT.
    /// Specifying COMPACT placement policy type places node pool&apos;s nodes in a closer
    /// physical proximity in order to reduce network latency between nodes.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSecondaryBootDisks
{
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig
{
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfig
{
    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigTaint
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>name&quot; as the key and specify the name of your reservation as its value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Taint configuration for the node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigTaintConfig
{
    /// <summary>Specifies the behavior for applying architecture taints to node pool nodes. Valid values are ARCHITECTURE_TAINT_BEHAVIOR_UNSPECIFIED, NONE, or ARM.</summary>
    [JsonPropertyName("architectureTaintBehavior")]
    public string? ArchitectureTaintBehavior { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfig
{
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    [JsonPropertyName("bootDisk")]
    public V1beta1NodePoolStatusAtProviderNodeConfigBootDisk? BootDisk { get; set; }

    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    [JsonPropertyName("confidentialNodes")]
    public V1beta1NodePoolStatusAtProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    [JsonPropertyName("containerdConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("effectiveTaints")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigEffectiveTaints>? EffectiveTaints { get; set; }

    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    [JsonPropertyName("fastSocket")]
    public V1beta1NodePoolStatusAtProviderNodeConfigFastSocket? FastSocket { get; set; }

    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    [JsonPropertyName("gcfsConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    [JsonPropertyName("gpudirectStrategy")]
    public string? GpudirectStrategy { get; set; }

    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    [JsonPropertyName("gvnic")]
    public V1beta1NodePoolStatusAtProviderNodeConfigGvnic? Gvnic { get; set; }

    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Node kubelet configs. Structure is documented below.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

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

    [JsonPropertyName("nodeImageConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigNodeImageConfig>? NodeImageConfig { get; set; }

    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    [JsonPropertyName("reservationAffinity")]
    public V1beta1NodePoolStatusAtProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    [JsonPropertyName("sandboxConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigSandboxConfig? SandboxConfig { get; set; }

    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    [JsonPropertyName("soleTenantConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>Taint configuration for the node pool. Structure is documented below.</summary>
    [JsonPropertyName("taintConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigTaintConfig? TaintConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeDrainConfig
{
    /// <summary>The duration of the grace termination period for node drain.</summary>
    [JsonPropertyName("graceTerminationDuration")]
    public string? GraceTerminationDuration { get; set; }

    /// <summary>The duration of the PDB timeout period for node drain.</summary>
    [JsonPropertyName("pdbTimeoutDuration")]
    public string? PdbTimeoutDuration { get; set; }

    /// <summary>Whether to respect PodDisruptionBudget policy during node pool deletion.</summary>
    [JsonPropertyName("respectPdbDuringNodePoolDeletion")]
    public bool? RespectPdbDuringNodePoolDeletion { get; set; }
}

/// <summary>
/// Specifies a custom placement policy for the
/// nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderPlacementPolicy
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>
/// The settings to adjust blue green upgrades.
/// Structure is documented below
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
    public V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}

/// <summary>
/// Specify node upgrade settings to change how GKE upgrades nodes.
/// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderUpgradeSettings
{
    /// <summary>
    /// The settings to adjust blue green upgrades.
    /// Structure is documented below
    /// </summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProvider
{
    /// <summary>
    /// Configuration required by cluster autoscaler to adjust
    /// the size of the node pool to the current cluster usage. Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1NodePoolStatusAtProviderAutoscaling? Autoscaling { get; set; }

    /// <summary>The cluster to create the node pool for. Cluster must be present in location provided for clusters. May be specified in the format projects/{{project}}/locations/{{location}}/clusters/{{cluster}} or as just the name of the cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>
    /// Defaults to &quot;DELETE&quot;.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{location}}/{{cluster}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether to ignore external changes (drift) to the node count (e.g. from GKE autoscaling). Setting this to true skips querying Compute Engine Instance Group Managers (IGMs) to determine the current node count on read, which can save API quota and speed up plans on large clusters.</summary>
    [JsonPropertyName("ignoreNodeCountChanges")]
    public bool? IgnoreNodeCountChanges { get; set; }

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
    public V1beta1NodePoolStatusAtProviderManagement? Management { get; set; }

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
    public V1beta1NodePoolStatusAtProviderNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. Structure is documented below. See google_container_cluster for exact schema.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1NodePoolStatusAtProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>
    /// The number of nodes per instance group. This field can be used to
    /// update the number of nodes per instance group but should not be used alongside autoscaling.
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The node drain configuration of the pool. Structure is documented below.</summary>
    [JsonPropertyName("nodeDrainConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeDrainConfig>? NodeDrainConfig { get; set; }

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
    public V1beta1NodePoolStatusAtProviderPlacementPolicy? PlacementPolicy { get; set; }

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
    public V1beta1NodePoolStatusAtProviderQueuedProvisioning? QueuedProvisioning { get; set; }

    /// <summary>
    /// Specify node upgrade settings to change how GKE upgrades nodes.
    /// The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.
    /// </summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1NodePoolStatusAtProviderUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// The Kubernetes version for the nodes in this pool. Note that if this field
    /// and auto_upgrade are both specified, they will fight each other for what the node version should
    /// be, so setting both is highly discouraged.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1NodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodePoolStatusConditions>? Conditions { get; set; }

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

/// <summary>NodePool is the Schema for the NodePools API. Manages a GKE NodePool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodePoolSpec>, IStatus<V1beta1NodePoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePool";
    public const string KubeGroup = "container.gcp.m.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "container.gcp.m.upbound.io/v1beta1";

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