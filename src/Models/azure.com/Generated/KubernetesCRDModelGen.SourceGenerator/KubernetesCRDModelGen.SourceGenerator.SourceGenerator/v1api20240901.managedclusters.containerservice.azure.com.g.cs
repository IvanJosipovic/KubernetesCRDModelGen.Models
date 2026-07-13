#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2024-09-01/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901ManagedClusterList : IKubernetesObject<V1ListMeta>, IItems<V1api20240901ManagedCluster>
{
    public const string KubeApiVersion = "v1api20240901";
    public const string KubeKind = "ManagedClusterList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20240901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240901ManagedCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240901ManagedCluster> Items { get; set; }
}

/// <summary>AadProfile: The Azure Active Directory configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAadProfile
{
    /// <summary>AdminGroupObjectIDs: The list of AAD group object IDs that will have admin role of the cluster.</summary>
    [JsonPropertyName("adminGroupObjectIDs")]
    public IList<string>? AdminGroupObjectIDs { get; set; }

    /// <summary>ClientAppID: (DEPRECATED) The client AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.</summary>
    [JsonPropertyName("clientAppID")]
    public string? ClientAppID { get; set; }

    /// <summary>EnableAzureRBAC: Whether to enable Azure RBAC for Kubernetes authorization.</summary>
    [JsonPropertyName("enableAzureRBAC")]
    public bool? EnableAzureRBAC { get; set; }

    /// <summary>Managed: Whether to enable managed AAD.</summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    /// <summary>ServerAppID: (DEPRECATED) The server AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.</summary>
    [JsonPropertyName("serverAppID")]
    public string? ServerAppID { get; set; }

    /// <summary>ServerAppSecret: (DEPRECATED) The server AAD application secret. Learn more at https://aka.ms/aks/aad-legacy.</summary>
    [JsonPropertyName("serverAppSecret")]
    public string? ServerAppSecret { get; set; }

    /// <summary>
    /// TenantID: The AAD tenant ID to use for authentication. If not specified, will use the tenant of the deployment
    /// subscription.
    /// </summary>
    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>A Kubernetes add-on profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAddonProfiles
{
    /// <summary>Config: Key-value pairs for configuring an add-on.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary>Enabled: Whether the add-on is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// CreationData: CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using
/// a snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesCreationData
{
    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum
{
    [EnumMember(Value = "MIG1g"), JsonStringEnumMemberName("MIG1g")]
    MIG1g,
    [EnumMember(Value = "MIG2g"), JsonStringEnumMemberName("MIG2g")]
    MIG2g,
    [EnumMember(Value = "MIG3g"), JsonStringEnumMemberName("MIG3g")]
    MIG3g,
    [EnumMember(Value = "MIG4g"), JsonStringEnumMemberName("MIG4g")]
    MIG4g,
    [EnumMember(Value = "MIG7g"), JsonStringEnumMemberName("MIG7g")]
    MIG7g
}

/// <summary>
/// HostGroupReference: This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
/// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesHostGroupReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesKubeletConfig
{
    /// <summary>AllowedUnsafeSysctls: Allowed list of unsafe sysctls or unsafe sysctl patterns (ending in `*`).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>
    /// ContainerLogMaxFiles: The maximum number of container log files that can be present for a container. The number must be
    /// ≥ 2.
    /// </summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public int? ContainerLogMaxFiles { get; set; }

    /// <summary>ContainerLogMaxSizeMB: The maximum size (e.g. 10Mi) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMB")]
    public int? ContainerLogMaxSizeMB { get; set; }

    /// <summary>CpuCfsQuota: The default is true.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>
    /// CpuCfsQuotaPeriod: The default is &apos;100ms.&apos; Valid values are a sequence of decimal numbers with an optional fraction and
    /// a unit suffix. For example: &apos;300ms&apos;, &apos;2h45m&apos;. Supported units are &apos;ns&apos;, &apos;us&apos;, &apos;ms&apos;, &apos;s&apos;, &apos;m&apos;, and &apos;h&apos;.
    /// </summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// CpuManagerPolicy: The default is &apos;none&apos;. See [Kubernetes CPU management
    /// policies](https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/#cpu-management-policies) for more
    /// information. Allowed values are &apos;none&apos; and &apos;static&apos;.
    /// </summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>FailSwapOn: If set to true it will make the Kubelet fail to start if swap is enabled on the node.</summary>
    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    /// <summary>ImageGcHighThreshold: To disable image garbage collection, set to 100. The default is 85%</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    /// <summary>ImageGcLowThreshold: This cannot be set higher than imageGcHighThreshold. The default is 80%</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    /// <summary>PodMaxPids: The maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    /// <summary>
    /// TopologyManagerPolicy: For more information see [Kubernetes Topology
    /// Manager](https://kubernetes.io/docs/tasks/administer-cluster/topology-manager). The default is &apos;none&apos;. Allowed values
    /// are &apos;none&apos;, &apos;best-effort&apos;, &apos;restricted&apos;, and &apos;single-numa-node&apos;.
    /// </summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>
/// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
/// storage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum
{
    [EnumMember(Value = "OS"), JsonStringEnumMemberName("OS")]
    OS,
    [EnumMember(Value = "Temporary"), JsonStringEnumMemberName("Temporary")]
    Temporary
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls
{
    /// <summary>FsAioMaxNr: Sysctl setting fs.aio-max-nr.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public int? FsAioMaxNr { get; set; }

    /// <summary>FsFileMax: Sysctl setting fs.file-max.</summary>
    [JsonPropertyName("fsFileMax")]
    public int? FsFileMax { get; set; }

    /// <summary>FsInotifyMaxUserWatches: Sysctl setting fs.inotify.max_user_watches.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public int? FsInotifyMaxUserWatches { get; set; }

    /// <summary>FsNrOpen: Sysctl setting fs.nr_open.</summary>
    [JsonPropertyName("fsNrOpen")]
    public int? FsNrOpen { get; set; }

    /// <summary>KernelThreadsMax: Sysctl setting kernel.threads-max.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public int? KernelThreadsMax { get; set; }

    /// <summary>NetCoreNetdevMaxBacklog: Sysctl setting net.core.netdev_max_backlog.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public int? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>NetCoreOptmemMax: Sysctl setting net.core.optmem_max.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public int? NetCoreOptmemMax { get; set; }

    /// <summary>NetCoreRmemDefault: Sysctl setting net.core.rmem_default.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public int? NetCoreRmemDefault { get; set; }

    /// <summary>NetCoreRmemMax: Sysctl setting net.core.rmem_max.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public int? NetCoreRmemMax { get; set; }

    /// <summary>NetCoreSomaxconn: Sysctl setting net.core.somaxconn.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public int? NetCoreSomaxconn { get; set; }

    /// <summary>NetCoreWmemDefault: Sysctl setting net.core.wmem_default.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public int? NetCoreWmemDefault { get; set; }

    /// <summary>NetCoreWmemMax: Sysctl setting net.core.wmem_max.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public int? NetCoreWmemMax { get; set; }

    /// <summary>NetIpv4IpLocalPortRange: Sysctl setting net.ipv4.ip_local_port_range.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRange")]
    public string? NetIpv4IpLocalPortRange { get; set; }

    /// <summary>NetIpv4NeighDefaultGcThresh1: Sysctl setting net.ipv4.neigh.default.gc_thresh1.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public int? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>NetIpv4NeighDefaultGcThresh2: Sysctl setting net.ipv4.neigh.default.gc_thresh2.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public int? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>NetIpv4NeighDefaultGcThresh3: Sysctl setting net.ipv4.neigh.default.gc_thresh3.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public int? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>NetIpv4TcpFinTimeout: Sysctl setting net.ipv4.tcp_fin_timeout.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public int? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>NetIpv4TcpKeepaliveProbes: Sysctl setting net.ipv4.tcp_keepalive_probes.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public int? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>NetIpv4TcpKeepaliveTime: Sysctl setting net.ipv4.tcp_keepalive_time.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public int? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>NetIpv4TcpMaxSynBacklog: Sysctl setting net.ipv4.tcp_max_syn_backlog.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public int? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>NetIpv4TcpMaxTwBuckets: Sysctl setting net.ipv4.tcp_max_tw_buckets.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public int? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>NetIpv4TcpTwReuse: Sysctl setting net.ipv4.tcp_tw_reuse.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>NetIpv4TcpkeepaliveIntvl: Sysctl setting net.ipv4.tcp_keepalive_intvl.</summary>
    [JsonPropertyName("netIpv4TcpkeepaliveIntvl")]
    public int? NetIpv4TcpkeepaliveIntvl { get; set; }

    /// <summary>NetNetfilterNfConntrackBuckets: Sysctl setting net.netfilter.nf_conntrack_buckets.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public int? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>NetNetfilterNfConntrackMax: Sysctl setting net.netfilter.nf_conntrack_max.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public int? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>VmMaxMapCount: Sysctl setting vm.max_map_count.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public int? VmMaxMapCount { get; set; }

    /// <summary>VmSwappiness: Sysctl setting vm.swappiness.</summary>
    [JsonPropertyName("vmSwappiness")]
    public int? VmSwappiness { get; set; }

    /// <summary>VmVfsCachePressure: Sysctl setting vm.vfs_cache_pressure.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public int? VmVfsCachePressure { get; set; }
}

/// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary>
    /// TransparentHugePageDefrag: Valid values are &apos;always&apos;, &apos;defer&apos;, &apos;defer+madvise&apos;, &apos;madvise&apos; and &apos;never&apos;. The default is
    /// &apos;madvise&apos;. For more information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>
    /// TransparentHugePageEnabled: Valid values are &apos;always&apos;, &apos;madvise&apos;, and &apos;never&apos;. The default is &apos;always&apos;. For more
    /// information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>
/// Mode: A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional information on agent pool
/// restrictions  and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesModeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesModeEnum
{
    [EnumMember(Value = "System"), JsonStringEnumMemberName("System")]
    System,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>Protocol: The network protocol of the port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum
{
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts
{
    /// <summary>
    /// PortEnd: The maximum port that is included in the range. It should be ranged from 1 to 65535, and be greater than or
    /// equal to portStart.
    /// </summary>
    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    /// <summary>
    /// PortStart: The minimum port that is included in the range. It should be ranged from 1 to 65535, and be less than or
    /// equal to portEnd.
    /// </summary>
    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    /// <summary>Protocol: The network protocol of the port.</summary>
    [JsonPropertyName("protocol")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum? Protocol { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Contains the IPTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags
{
    /// <summary>IpTagType: The IP tag type. Example: RoutingPreference.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: The value of the IP tag associated with the public IP. Example: Internet.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>
    /// ApplicationSecurityGroupsReferences: The IDs of the application security groups which agent pool will associate when
    /// created.
    /// </summary>
    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// NodePublicIPPrefixReference: This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// OsDiskType: The default is &apos;Ephemeral&apos; if the VM supports it and has a cache disk larger than the requested
/// OSDiskSizeGB. Otherwise,  defaults to &apos;Managed&apos;. May not be changed after creation. For more information see [Ephemeral
/// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum
{
    [EnumMember(Value = "Ephemeral"), JsonStringEnumMemberName("Ephemeral")]
    Ephemeral,
    [EnumMember(Value = "Managed"), JsonStringEnumMemberName("Managed")]
    Managed
}

/// <summary>
/// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
/// when  Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesOsSKUEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesOsSKUEnum
{
    [EnumMember(Value = "AzureLinux"), JsonStringEnumMemberName("AzureLinux")]
    AzureLinux,
    [EnumMember(Value = "CBLMariner"), JsonStringEnumMemberName("CBLMariner")]
    CBLMariner,
    [EnumMember(Value = "Ubuntu"), JsonStringEnumMemberName("Ubuntu")]
    Ubuntu,
    [EnumMember(Value = "Windows2019"), JsonStringEnumMemberName("Windows2019")]
    Windows2019,
    [EnumMember(Value = "Windows2022"), JsonStringEnumMemberName("Windows2022")]
    Windows2022
}

/// <summary>OsType: The operating system type. The default is Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesOsTypeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details).
/// This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesPodSubnetReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum
{
    [EnumMember(Value = "Running"), JsonStringEnumMemberName("Running")]
    Running,
    [EnumMember(Value = "Stopped"), JsonStringEnumMemberName("Stopped")]
    Stopped
}

/// <summary>
/// PowerState: When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this
/// field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only
/// be stopped if it is Running and provisioning state is Succeeded
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum? Code { get; set; }
}

/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ScaleDownMode: This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesScaleDownModeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesScaleDownModeEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// ScaleSetEvictionPolicy: This cannot be specified unless the scaleSetPriority is &apos;Spot&apos;. If not specified, the default is
/// &apos;Delete&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum
{
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesSecurityProfile
{
    /// <summary>
    /// EnableSecureBoot: Secure Boot is a feature of Trusted Launch which ensures that only signed operating systems and
    /// drivers can boot. For more details, see aka.ms/aks/trustedlaunch.  If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>
    /// EnableVTPM: vTPM is a Trusted Launch feature for configuring a dedicated secure vault for keys and measurements held
    /// locally on the node. For more details, see aka.ms/aks/trustedlaunch. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }
}

/// <summary>Type: The type of Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesTypeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesTypeEnum
{
    [EnumMember(Value = "AvailabilitySet"), JsonStringEnumMemberName("AvailabilitySet")]
    AvailabilitySet,
    [EnumMember(Value = "VirtualMachineScaleSets"), JsonStringEnumMemberName("VirtualMachineScaleSets")]
    VirtualMachineScaleSets
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesUpgradeSettings
{
    /// <summary>
    /// DrainTimeoutInMinutes: The amount of time (in minutes) to wait on eviction of pods and graceful termination per node.
    /// This eviction wait time honors waiting on pod disruption budgets. If this time is exceeded, the upgrade fails. If not
    /// specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// MaxSurge: This can either be set to an integer (e.g. &apos;5&apos;) or a percentage (e.g. &apos;50%&apos;). If a percentage is specified, it
    /// is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded
    /// up. If not specified, the default is 1. For more information, including best practices, see:
    /// https://docs.microsoft.com/azure/aks/upgrade-cluster#customize-node-surge-upgrade
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>
    /// NodeSoakDurationInMinutes: The amount of time (in minutes) to wait after draining a node and before reimaging it and
    /// moving on to next node. If not specified, the default is 0 minutes.
    /// </summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }
}

/// <summary>
/// VnetSubnetReference: If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is
/// specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesVnetSubnetReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfilesWindowsProfile
{
    /// <summary>
    /// DisableOutboundNat: The default value is false. Outbound NAT can only be disabled if the cluster outboundType is NAT
    /// Gateway and the Windows agent pool does not have node public IP enabled.
    /// </summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum>))]
public enum V1api20240901ManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum
{
    [EnumMember(Value = "OCIContainer"), JsonStringEnumMemberName("OCIContainer")]
    OCIContainer,
    [EnumMember(Value = "WasmWasi"), JsonStringEnumMemberName("WasmWasi")]
    WasmWasi
}

/// <summary>Profile for the container service agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAgentPoolProfiles
{
    /// <summary>
    /// AvailabilityZones: The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType
    /// property is &apos;VirtualMachineScaleSets&apos;.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
    [JsonPropertyName("capacityReservationGroupReference")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

    /// <summary>
    /// Count: Number of agents (VMs) to host docker containers. Allowed values must be in the range of 0 to 1000 (inclusive)
    /// for user pools and in the range of 1 to 1000 (inclusive) for system pools. The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// CreationData: CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using
    /// a snapshot.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesCreationData? CreationData { get; set; }

    /// <summary>EnableAutoScaling: Whether to enable auto-scaler</summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary>
    /// EnableEncryptionAtHost: This is only supported on certain VM sizes and in certain Azure regions. For more information,
    /// see: https://docs.microsoft.com/azure/aks/enable-host-encryption
    /// </summary>
    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    /// <summary>
    /// EnableFIPS: See [Add a FIPS-enabled node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview) for more
    /// details.
    /// </summary>
    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    /// <summary>
    /// EnableNodePublicIP: Some scenarios may require nodes in a node pool to receive their own dedicated public IP addresses.
    /// A common scenario is for gaming workloads, where a console needs to make a direct connection to a cloud virtual machine
    /// to minimize hops. For more information see [assigning a public IP per
    /// node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools). The
    /// default is false.
    /// </summary>
    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    /// <summary>EnableUltraSSD: Whether to enable UltraSSD</summary>
    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum? GpuInstanceProfile { get; set; }

    /// <summary>
    /// HostGroupReference: This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupReference")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesHostGroupReference? HostGroupReference { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>MaxCount: The maximum number of nodes for auto-scaling</summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary>MaxPods: The maximum number of pods that can run on a node.</summary>
    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    /// <summary>MinCount: The minimum number of nodes for auto-scaling</summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary>
    /// Mode: A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional information on agent pool
    /// restrictions  and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
    /// </summary>
    [JsonPropertyName("mode")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesModeEnum? Mode { get; set; }

    /// <summary>Name: Windows agent pool names must be 6 characters or less.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeLabels: The node labels to be persisted across all nodes in agent pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixReference: This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

    /// <summary>NodeTaints: The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule.</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>
    /// OrchestratorVersion: Both patch version &lt;major.minor.patch&gt; (e.g. 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported.
    /// When &lt;major.minor&gt; is specified, the latest supported GA patch version is chosen automatically. Updating the cluster
    /// with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x -&gt; 1.14) will not trigger an upgrade, even if a newer
    /// patch version is available. As a best practice, you should upgrade all node pools in an AKS cluster to the same
    /// Kubernetes version. The node pool version must have the same major version as the control plane. The node pool minor
    /// version must be within two minor versions of the control plane version. The node pool version cannot be greater than the
    /// control plane version. For more information see [upgrading a node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool).
    /// </summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary>
    /// OsDiskType: The default is &apos;Ephemeral&apos; if the VM supports it and has a cache disk larger than the requested
    /// OSDiskSizeGB. Otherwise,  defaults to &apos;Managed&apos;. May not be changed after creation. For more information see [Ephemeral
    /// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
    /// </summary>
    [JsonPropertyName("osDiskType")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum? OsDiskType { get; set; }

    /// <summary>
    /// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
    /// when  Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    [JsonPropertyName("osSKU")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesOsSKUEnum? OsSKU { get; set; }

    /// <summary>OsType: The operating system type. The default is Linux.</summary>
    [JsonPropertyName("osType")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details).
    /// This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetReference")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>
    /// PowerState: When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this
    /// field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only
    /// be stopped if it is Running and provisioning state is Succeeded
    /// </summary>
    [JsonPropertyName("powerState")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

    /// <summary>ScaleDownMode: This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesScaleDownModeEnum? ScaleDownMode { get; set; }

    /// <summary>
    /// ScaleSetEvictionPolicy: This cannot be specified unless the scaleSetPriority is &apos;Spot&apos;. If not specified, the default is
    /// &apos;Delete&apos;.
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// SpotMaxPrice: Possible values are any decimal value greater than zero or -1 which indicates the willingness to pay any
    /// on-demand price. For more details on spot pricing, see [spot VMs
    /// pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing)
    /// </summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>Tags: The tags to be persisted on the agent pool virtual machine scale set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Agent Pool.</summary>
    [JsonPropertyName("type")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesTypeEnum? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// VmSize: VM size availability varies by region. If a node contains insufficient compute resources (memory, cpu, etc) pods
    /// might fail to run correctly. For more details on restricted VM sizes, see:
    /// https://docs.microsoft.com/azure/aks/quotas-skus-regions
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VnetSubnetReference: If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is
    /// specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("vnetSubnetReference")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public V1api20240901ManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum? WorkloadRuntime { get; set; }
}

/// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecApiServerAccessProfile
{
    /// <summary>
    /// AuthorizedIPRanges: IP ranges are specified in CIDR format, e.g. 137.117.106.88/29. This feature is not compatible with
    /// clusters that use Public IP Per Node, or clusters that are using a Basic Load Balancer. For more information see [API
    /// server authorized IP ranges](https://docs.microsoft.com/azure/aks/api-server-authorized-ip-ranges).
    /// </summary>
    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    /// <summary>DisableRunCommand: Whether to disable run command for the cluster or not.</summary>
    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    /// <summary>
    /// EnablePrivateCluster: For more details, see [Creating a private AKS
    /// cluster](https://docs.microsoft.com/azure/aks/private-clusters).
    /// </summary>
    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    /// <summary>EnablePrivateClusterPublicFQDN: Whether to create additional public FQDN for private cluster or not.</summary>
    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    /// <summary>
    /// PrivateDNSZone: The default is System. For more details see [configure private DNS
    /// zone](https://docs.microsoft.com/azure/aks/private-clusters#configure-private-dns-zone). Allowed values are &apos;system&apos; and
    /// &apos;none&apos;.
    /// </summary>
    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }
}

/// <summary>
/// Expander: If not specified, the default is &apos;random&apos;. See
/// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more
/// information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAutoScalerProfileExpanderEnum>))]
public enum V1api20240901ManagedClusterSpecAutoScalerProfileExpanderEnum
{
    [EnumMember(Value = "least-waste"), JsonStringEnumMemberName("least-waste")]
    LeastWaste,
    [EnumMember(Value = "most-pods"), JsonStringEnumMemberName("most-pods")]
    MostPods,
    [EnumMember(Value = "priority"), JsonStringEnumMemberName("priority")]
    Priority,
    [EnumMember(Value = "random"), JsonStringEnumMemberName("random")]
    Random
}

/// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAutoScalerProfile
{
    /// <summary>BalanceSimilarNodeGroups: Valid values are &apos;true&apos; and &apos;false&apos;</summary>
    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    /// <summary>
    /// DaemonsetEvictionForEmptyNodes: If set to true, all daemonset pods on empty nodes will be evicted before deletion of the
    /// node. If the daemonset pod cannot be evicted another node will be chosen for scaling. If set to false, the node will be
    /// deleted without ensuring that daemonset pods are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    /// <summary>
    /// DaemonsetEvictionForOccupiedNodes: If set to true, all daemonset pods on occupied nodes will be evicted before deletion
    /// of the node. If the daemonset pod cannot be evicted another node will be chosen for scaling. If set to false, the node
    /// will be deleted without ensuring that daemonset pods are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    /// <summary>
    /// Expander: If not specified, the default is &apos;random&apos;. See
    /// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more
    /// information.
    /// </summary>
    [JsonPropertyName("expander")]
    public V1api20240901ManagedClusterSpecAutoScalerProfileExpanderEnum? Expander { get; set; }

    /// <summary>
    /// IgnoreDaemonsetsUtilization: If set to true, the resources used by daemonset will be taken into account when making
    /// scaling down decisions.
    /// </summary>
    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    /// <summary>MaxEmptyBulkDelete: The default is 10.</summary>
    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    /// <summary>MaxGracefulTerminationSec: The default is 600.</summary>
    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary>
    /// MaxNodeProvisionTime: The default is &apos;15m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    /// <summary>MaxTotalUnreadyPercentage: The default is 45. The maximum is 100 and the minimum is 0.</summary>
    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    /// <summary>
    /// NewPodScaleUpDelay: For scenarios like burst/batch scale where you don&apos;t want CA to act before the kubernetes scheduler
    /// could schedule all the pods, you can tell CA to ignore unscheduled pods before they&apos;re a certain age. The default is
    /// &apos;0s&apos;. Values must be an integer followed by a unit (&apos;s&apos; for seconds, &apos;m&apos; for minutes, &apos;h&apos; for hours, etc).
    /// </summary>
    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary>OkTotalUnreadyCount: This must be an integer. The default is 3.</summary>
    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterAdd: The default is &apos;10m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterDelete: The default is the scan-interval. Values must be an integer followed by an &apos;m&apos;. No unit of
    /// time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterFailure: The default is &apos;3m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other
    /// than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary>
    /// ScaleDownUnneededTime: The default is &apos;10m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    /// <summary>
    /// ScaleDownUnreadyTime: The default is &apos;20m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    /// <summary>ScaleDownUtilizationThreshold: The default is &apos;0.5&apos;.</summary>
    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary>ScanInterval: The default is &apos;10&apos;. Values must be an integer number of seconds.</summary>
    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    /// <summary>SkipNodesWithLocalStorage: The default is true.</summary>
    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    /// <summary>SkipNodesWithSystemPods: The default is true.</summary>
    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>NodeOSUpgradeChannel: Manner in which the OS on your nodes is updated. The default is NodeImage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum>))]
public enum V1api20240901ManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum
{
    [EnumMember(Value = "NodeImage"), JsonStringEnumMemberName("NodeImage")]
    NodeImage,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SecurityPatch"), JsonStringEnumMemberName("SecurityPatch")]
    SecurityPatch,
    [EnumMember(Value = "Unmanaged"), JsonStringEnumMemberName("Unmanaged")]
    Unmanaged
}

/// <summary>
/// UpgradeChannel: For more information see [setting the AKS cluster auto-upgrade
/// channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum>))]
public enum V1api20240901ManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum
{
    [EnumMember(Value = "node-image"), JsonStringEnumMemberName("node-image")]
    NodeImage,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "patch"), JsonStringEnumMemberName("patch")]
    Patch,
    [EnumMember(Value = "rapid"), JsonStringEnumMemberName("rapid")]
    Rapid,
    [EnumMember(Value = "stable"), JsonStringEnumMemberName("stable")]
    Stable
}

/// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAutoUpgradeProfile
{
    /// <summary>NodeOSUpgradeChannel: Manner in which the OS on your nodes is updated. The default is NodeImage.</summary>
    [JsonPropertyName("nodeOSUpgradeChannel")]
    public V1api20240901ManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum? NodeOSUpgradeChannel { get; set; }

    /// <summary>
    /// UpgradeChannel: For more information see [setting the AKS cluster auto-upgrade
    /// channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
    /// </summary>
    [JsonPropertyName("upgradeChannel")]
    public V1api20240901ManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum? UpgradeChannel { get; set; }
}

/// <summary>
/// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
///  kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics
{
    /// <summary>
    /// MetricAnnotationsAllowList: Comma-separated list of Kubernetes annotation keys that will be used in the resource&apos;s
    /// labels metric (Example: &apos;namespaces=[kubernetes.io/team,...],pods=[kubernetes.io/team],...&apos;). By default the metric
    /// contains only resource name and namespace labels.
    /// </summary>
    [JsonPropertyName("metricAnnotationsAllowList")]
    public string? MetricAnnotationsAllowList { get; set; }

    /// <summary>
    /// MetricLabelsAllowlist: Comma-separated list of additional Kubernetes label keys that will be used in the resource&apos;s
    /// labels metric (Example: &apos;namespaces=[k8s-label-1,k8s-label-n,...],pods=[app],...&apos;). By default the metric contains only
    /// resource name and namespace labels.
    /// </summary>
    [JsonPropertyName("metricLabelsAllowlist")]
    public string? MetricLabelsAllowlist { get; set; }
}

/// <summary>
/// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
/// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
/// aka.ms/AzureManagedPrometheus for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAzureMonitorProfileMetrics
{
    /// <summary>
    /// Enabled: Whether to enable or disable the Azure Managed Prometheus addon for Prometheus monitoring. See
    /// aka.ms/AzureManagedPrometheus-aks-enable for details on enabling and disabling.
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>
    /// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
    ///  kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
    /// details.
    /// </summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V1api20240901ManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecAzureMonitorProfile
{
    /// <summary>
    /// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V1api20240901ManagedClusterSpecAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>
/// DiskEncryptionSetReference: This is of the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecDiskEncryptionSetReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecExtendedLocationTypeEnum>))]
public enum V1api20240901ManagedClusterSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20240901ManagedClusterSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecHttpProxyConfig
{
    /// <summary>HttpProxy: The HTTP proxy server endpoint to use.</summary>
    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    /// <summary>HttpsProxy: The HTTPS proxy server endpoint to use.</summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary>NoProxy: The endpoints that should not go through proxy.</summary>
    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    /// <summary>TrustedCa: Alternative CA cert to use for connecting to proxy servers.</summary>
    [JsonPropertyName("trustedCa")]
    public string? TrustedCa { get; set; }
}

/// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityDelegatedResourcesResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Delegated resource properties - internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityDelegatedResources
{
    /// <summary>Location: The source resource location - internal use only.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ReferralResource: The delegation id of the referral delegation (optional) - internal use only.</summary>
    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240901ManagedClusterSpecIdentityDelegatedResourcesResourceReference? ResourceReference { get; set; }

    /// <summary>TenantId: The tenant id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Type: For more information see [use managed identities in
/// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecIdentityTypeEnum>))]
public enum V1api20240901ManagedClusterSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240901ManagedClusterSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the managed cluster, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentity
{
    /// <summary>
    /// DelegatedResources: The delegated identity resources assigned to this managed cluster. This can only be set by another
    /// Azure Resource Provider, and managed cluster only accept one delegated identity resource. Internal use only.
    /// </summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V1api20240901ManagedClusterSpecIdentityDelegatedResources>? DelegatedResources { get; set; }

    /// <summary>
    /// Type: For more information see [use managed identities in
    /// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20240901ManagedClusterSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The keys must be ARM resource IDs in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240901ManagedClusterSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityProfileClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityProfileObjectIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityProfileResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIdentityProfile
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240901ManagedClusterSpecIdentityProfileClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20240901ManagedClusterSpecIdentityProfileObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240901ManagedClusterSpecIdentityProfileResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
/// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIngressProfileWebAppRouting
{
    /// <summary>
    /// DnsZoneResourceReferences: Resource IDs of the DNS zones to be associated with the Application Routing add-on. Used only
    /// when Application Routing add-on is enabled. Public and private DNS zones can be in different resource groups, but all
    /// public DNS zones must be in the same resource group and all private DNS zones must be in the same resource group.
    /// </summary>
    [JsonPropertyName("dnsZoneResourceReferences")]
    public IList<V1api20240901ManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences>? DnsZoneResourceReferences { get; set; }

    /// <summary>Enabled: Whether to enable the Application Routing add-on.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecIngressProfile
{
    /// <summary>
    /// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
    /// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V1api20240901ManagedClusterSpecIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecLinuxProfileSshPublicKeys
{
    /// <summary>
    /// KeyData: Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or
    /// without headers.
    /// </summary>
    [JsonPropertyName("keyData")]
    public required string KeyData { get; set; }
}

/// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecLinuxProfileSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified.</summary>
    [JsonPropertyName("publicKeys")]
    public required IList<V1api20240901ManagedClusterSpecLinuxProfileSshPublicKeys> PublicKeys { get; set; }
}

/// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecLinuxProfile
{
    /// <summary>AdminUsername: The administrator username to use for Linux VMs.</summary>
    [JsonPropertyName("adminUsername")]
    public required string AdminUsername { get; set; }

    /// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public required V1api20240901ManagedClusterSpecLinuxProfileSsh Ssh { get; set; }
}

/// <summary>CostAnalysis: The cost analysis configuration for the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecMetricsProfileCostAnalysis
{
    /// <summary>
    /// Enabled: The Managed Cluster sku.tier must be set to &apos;Standard&apos; or &apos;Premium&apos; to enable this feature. Enabling this will
    /// add Kubernetes Namespace and Deployment details to the Cost Analysis views in the Azure portal. If not specified, the
    /// default is false. For more information see aka.ms/aks/docs/cost-analysis.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecMetricsProfile
{
    /// <summary>CostAnalysis: The cost analysis configuration for the cluster</summary>
    [JsonPropertyName("costAnalysis")]
    public V1api20240901ManagedClusterSpecMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>Enabled: Indicates the enablement of Advanced Networking observability functionalities on clusters.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>
    /// Enabled: This feature allows user to configure network policy based on DNS (FQDN) names. It can be enabled only on
    /// cilium based clusters. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
/// more information see  aka.ms/aksadvancednetworking.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileAdvancedNetworking
{
    /// <summary>
    /// Enabled: Indicates the enablement of Advanced Networking functionalities of observability and security on AKS clusters.
    /// When this is set to true, all observability and security features will be set to enabled unless explicitly disabled. If
    /// not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
    [JsonPropertyName("observability")]
    public V1api20240901ManagedClusterSpecNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V1api20240901ManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileIpFamiliesEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>BackendPoolType: The type of the managed inbound Load Balancer BackendPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum
{
    [EnumMember(Value = "NodeIP"), JsonStringEnumMemberName("NodeIP")]
    NodeIP,
    [EnumMember(Value = "NodeIPConfiguration"), JsonStringEnumMemberName("NodeIPConfiguration")]
    NodeIPConfiguration
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPs
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPsReference? Reference { get; set; }
}

/// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs
{
    /// <summary>
    /// Count: The desired number of IPv4 outbound IPs created/managed by Azure for the cluster load balancer. Allowed values
    /// must be in the range of 1 to 100 (inclusive). The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// CountIPv6: The desired number of IPv6 outbound IPs created/managed by Azure for the cluster load balancer. Allowed
    /// values must be in the range of 1 to 100 (inclusive). The default value is 0 for single-stack and 1 for dual-stack.
    /// </summary>
    [JsonPropertyName("countIPv6")]
    public int? CountIPv6 { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference? Reference { get; set; }
}

/// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PublicIPPrefixes: A list of public IP prefix resources.</summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference? Reference { get; set; }
}

/// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PublicIPs: A list of public IP resources.</summary>
    [JsonPropertyName("publicIPs")]
    public IList<V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfile
{
    /// <summary>
    /// AllocatedOutboundPorts: The desired number of allocated SNAT ports per VM. Allowed values are in the range of 0 to 64000
    /// (inclusive). The default value is 0 which results in Azure dynamically allocating ports.
    /// </summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>BackendPoolType: The type of the managed inbound Load Balancer BackendPool.</summary>
    [JsonPropertyName("backendPoolType")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum? BackendPoolType { get; set; }

    /// <summary>EffectiveOutboundIPs: The effective outbound IP resources of the cluster load balancer.</summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary>EnableMultipleStandardLoadBalancers: Enable multiple standard load balancers per AKS cluster or not.</summary>
    [JsonPropertyName("enableMultipleStandardLoadBalancers")]
    public bool? EnableMultipleStandardLoadBalancers { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 30 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
    [JsonPropertyName("managedOutboundIPs")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPs")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>
/// LoadBalancerSku: The default is &apos;standard&apos;. See [Azure Load Balancer
/// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
/// balancer SKUs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerSkuEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerSkuEnum
{
    [EnumMember(Value = "basic"), JsonStringEnumMemberName("basic")]
    Basic,
    [EnumMember(Value = "standard"), JsonStringEnumMemberName("standard")]
    Standard
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPs
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPsReference? Reference { get; set; }
}

/// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>
    /// Count: The desired number of outbound IPs created/managed by Azure. Allowed values must be in the range of 1 to 16
    /// (inclusive). The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfile
{
    /// <summary>EffectiveOutboundIPs: The effective outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 4 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileNetworkDataplaneEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileNetworkDataplaneEnum
{
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "cilium"), JsonStringEnumMemberName("cilium")]
    Cilium
}

/// <summary>NetworkMode: This cannot be specified if networkPlugin is anything other than &apos;azure&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileNetworkModeEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileNetworkModeEnum
{
    [EnumMember(Value = "bridge"), JsonStringEnumMemberName("bridge")]
    Bridge,
    [EnumMember(Value = "transparent"), JsonStringEnumMemberName("transparent")]
    Transparent
}

/// <summary>NetworkPlugin: Network plugin used for building the Kubernetes network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileNetworkPluginEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileNetworkPluginEnum
{
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "kubenet"), JsonStringEnumMemberName("kubenet")]
    Kubenet,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>NetworkPluginMode: The mode the network plugin should use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileNetworkPluginModeEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileNetworkPluginModeEnum
{
    [EnumMember(Value = "overlay"), JsonStringEnumMemberName("overlay")]
    Overlay
}

/// <summary>NetworkPolicy: Network policy used for building the Kubernetes network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileNetworkPolicyEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileNetworkPolicyEnum
{
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "calico"), JsonStringEnumMemberName("calico")]
    Calico,
    [EnumMember(Value = "cilium"), JsonStringEnumMemberName("cilium")]
    Cilium,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>
/// OutboundType: This can only be set at cluster creation time and cannot be changed later. For more information see
/// [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNetworkProfileOutboundTypeEnum>))]
public enum V1api20240901ManagedClusterSpecNetworkProfileOutboundTypeEnum
{
    [EnumMember(Value = "loadBalancer"), JsonStringEnumMemberName("loadBalancer")]
    LoadBalancer,
    [EnumMember(Value = "managedNATGateway"), JsonStringEnumMemberName("managedNATGateway")]
    ManagedNATGateway,
    [EnumMember(Value = "userAssignedNATGateway"), JsonStringEnumMemberName("userAssignedNATGateway")]
    UserAssignedNATGateway,
    [EnumMember(Value = "userDefinedRouting"), JsonStringEnumMemberName("userDefinedRouting")]
    UserDefinedRouting
}

/// <summary>NetworkProfile: The network configuration profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNetworkProfile
{
    /// <summary>
    /// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
    /// more information see  aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V1api20240901ManagedClusterSpecNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    /// <summary>
    /// DnsServiceIP: An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address
    /// range specified in serviceCidr.
    /// </summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary>
    /// IpFamilies: IP families are used to determine single-stack or dual-stack clusters. For single-stack, the expected value
    /// is IPv4. For dual-stack, the expected values are IPv4 and IPv6.
    /// </summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1api20240901ManagedClusterSpecNetworkProfileIpFamiliesEnum>? IpFamilies { get; set; }

    /// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>
    /// LoadBalancerSku: The default is &apos;standard&apos;. See [Azure Load Balancer
    /// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
    /// balancer SKUs.
    /// </summary>
    [JsonPropertyName("loadBalancerSku")]
    public V1api20240901ManagedClusterSpecNetworkProfileLoadBalancerSkuEnum? LoadBalancerSku { get; set; }

    /// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V1api20240901ManagedClusterSpecNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    /// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
    [JsonPropertyName("networkDataplane")]
    public V1api20240901ManagedClusterSpecNetworkProfileNetworkDataplaneEnum? NetworkDataplane { get; set; }

    /// <summary>NetworkMode: This cannot be specified if networkPlugin is anything other than &apos;azure&apos;.</summary>
    [JsonPropertyName("networkMode")]
    public V1api20240901ManagedClusterSpecNetworkProfileNetworkModeEnum? NetworkMode { get; set; }

    /// <summary>NetworkPlugin: Network plugin used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPlugin")]
    public V1api20240901ManagedClusterSpecNetworkProfileNetworkPluginEnum? NetworkPlugin { get; set; }

    /// <summary>NetworkPluginMode: The mode the network plugin should use.</summary>
    [JsonPropertyName("networkPluginMode")]
    public V1api20240901ManagedClusterSpecNetworkProfileNetworkPluginModeEnum? NetworkPluginMode { get; set; }

    /// <summary>NetworkPolicy: Network policy used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPolicy")]
    public V1api20240901ManagedClusterSpecNetworkProfileNetworkPolicyEnum? NetworkPolicy { get; set; }

    /// <summary>
    /// OutboundType: This can only be set at cluster creation time and cannot be changed later. For more information see
    /// [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
    /// </summary>
    [JsonPropertyName("outboundType")]
    public V1api20240901ManagedClusterSpecNetworkProfileOutboundTypeEnum? OutboundType { get; set; }

    /// <summary>PodCidr: A CIDR notation IP range from which to assign pod IPs when kubenet is used.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>
    /// PodCidrs: One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is
    /// expected for dual-stack networking.
    /// </summary>
    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    /// <summary>
    /// ServiceCidr: A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP
    /// ranges.
    /// </summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>
    /// ServiceCidrs: One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is
    /// expected for dual-stack networking. They must not overlap with any Subnet IP ranges.
    /// </summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }
}

/// <summary>
/// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
/// &apos;Unrestricted&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum>))]
public enum V1api20240901ManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum
{
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "Unrestricted"), JsonStringEnumMemberName("Unrestricted")]
    Unrestricted
}

/// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecNodeResourceGroupProfile
{
    /// <summary>
    /// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
    /// &apos;Unrestricted&apos;
    /// </summary>
    [JsonPropertyName("restrictionLevel")]
    public V1api20240901ManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum? RestrictionLevel { get; set; }
}

/// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOidcIssuerProfile
{
    /// <summary>Enabled: Whether the OIDC issuer is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OIDCIssuerProfile: indicates where the OIDCIssuerProfile config map should be placed. If omitted, no config map will be
/// created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PrincipalId: indicates where the PrincipalId config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecConfigMapsPrincipalId
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// OIDCIssuerProfile: indicates where the OIDCIssuerProfile config map should be placed. If omitted, no config map will be
    /// created.
    /// </summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20240901ManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>PrincipalId: indicates where the PrincipalId config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("principalId")]
    public V1api20240901ManagedClusterSpecOperatorSpecConfigMapsPrincipalId? PrincipalId { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// AdminCredentials: indicates where the AdminCredentials secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecSecretsAdminCredentials
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// UserCredentials: indicates where the UserCredentials secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecSecretsUserCredentials
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpecSecrets
{
    /// <summary>
    /// AdminCredentials: indicates where the AdminCredentials secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("adminCredentials")]
    public V1api20240901ManagedClusterSpecOperatorSpecSecretsAdminCredentials? AdminCredentials { get; set; }

    /// <summary>
    /// UserCredentials: indicates where the UserCredentials secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("userCredentials")]
    public V1api20240901ManagedClusterSpecOperatorSpecSecretsUserCredentials? UserCredentials { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240901ManagedClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20240901ManagedClusterSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240901ManagedClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20240901ManagedClusterSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Identity: The user assigned identity details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference? ResourceReference { get; set; }
}

/// <summary>Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentities
{
    /// <summary>BindingSelector: The binding selector to use for the AzureIdentityBinding resource.</summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Identity: The user assigned identity details.</summary>
    [JsonPropertyName("identity")]
    public required V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity Identity { get; set; }

    /// <summary>Name: The name of the pod identity.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace: The namespace of the pod identity.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// See [disable AAD Pod Identity for a specific
/// Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions
{
    /// <summary>Name: The name of the pod identity exception.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace: The namespace of the pod identity exception.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>PodLabels: The pod labels to match.</summary>
    [JsonPropertyName("podLabels")]
    public required IDictionary<string, string> PodLabels { get; set; }
}

/// <summary>
/// PodIdentityProfile: See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more
/// details on AAD pod identity integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPodIdentityProfile
{
    /// <summary>
    /// AllowNetworkPluginKubenet: Running in Kubenet is disabled by default due to the security related nature of AAD Pod
    /// Identity and the risks of IP spoofing. See [using Kubenet network plugin with AAD Pod
    /// Identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity#using-kubenet-network-plugin-with-azure-active-directory-pod-managed-identities)
    /// for more information.
    /// </summary>
    [JsonPropertyName("allowNetworkPluginKubenet")]
    public bool? AllowNetworkPluginKubenet { get; set; }

    /// <summary>Enabled: Whether the pod identity addon is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>UserAssignedIdentities: The pod identities to use in the cluster.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary>UserAssignedIdentityExceptions: The pod identity exceptions to allow.</summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V1api20240901ManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>Reference: The ID of the private link resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPrivateLinkResourcesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A private link resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecPrivateLinkResources
{
    /// <summary>GroupId: The group ID of the resource.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name: The name of the private link resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: The ID of the private link resource.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901ManagedClusterSpecPrivateLinkResourcesReference? Reference { get; set; }

    /// <summary>RequiredMembers: The RequiredMembers of the resource</summary>
    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublicNetworkAccess: Allow or deny public network access for AKS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecPublicNetworkAccessEnum>))]
public enum V1api20240901ManagedClusterSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// KeyVaultNetworkAccess: Network access of key vault. The possible values are `Public` and `Private`. `Public` means the
/// key vault allows public access from all networks. `Private` means the key vault disables public access and enables
/// private link. The default value is `Public`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum>))]
public enum V1api20240901ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum
{
    [EnumMember(Value = "Private"), JsonStringEnumMemberName("Private")]
    Private,
    [EnumMember(Value = "Public"), JsonStringEnumMemberName("Public")]
    Public
}

/// <summary>
/// KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and
/// must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// AzureKeyVaultKms: Azure Key Vault [key management
/// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfileAzureKeyVaultKms
{
    /// <summary>Enabled: Whether to enable Azure Key Vault key management service. The default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyId: Identifier of Azure Key Vault key. See [key identifier
    /// format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name)
    /// for more details. When Azure Key Vault key management service is enabled, this field is required and must be a valid key
    /// identifier. When Azure Key Vault key management service is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// KeyVaultNetworkAccess: Network access of key vault. The possible values are `Public` and `Private`. `Public` means the
    /// key vault allows public access from all networks. `Private` means the key vault disables public access and enables
    /// private link. The default value is `Public`.
    /// </summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public V1api20240901ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum? KeyVaultNetworkAccess { get; set; }

    /// <summary>
    /// KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and
    /// must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
    /// </summary>
    [JsonPropertyName("keyVaultResourceReference")]
    public V1api20240901ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference? KeyVaultResourceReference { get; set; }
}

/// <summary>
/// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
/// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
/// Microsoft Defender is disabled, leave the field empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>Enabled: Whether to enable Defender threat detection</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfileDefender
{
    /// <summary>
    /// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
    /// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
    /// Microsoft Defender is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceReference")]
    public V1api20240901ManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference? LogAnalyticsWorkspaceResourceReference { get; set; }

    /// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
    [JsonPropertyName("securityMonitoring")]
    public V1api20240901ManagedClusterSpecSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfileImageCleaner
{
    /// <summary>Enabled: Whether to enable Image Cleaner on AKS cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IntervalHours: Image Cleaner scanning interval in hours.</summary>
    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>
/// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
/// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfileWorkloadIdentity
{
    /// <summary>Enabled: Whether to enable workload identity.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSecurityProfile
{
    /// <summary>
    /// AzureKeyVaultKms: Azure Key Vault [key management
    /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V1api20240901ManagedClusterSpecSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V1api20240901ManagedClusterSpecSecurityProfileDefender? Defender { get; set; }

    /// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V1api20240901ManagedClusterSpecSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
    /// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V1api20240901ManagedClusterSpecSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin
{
    /// <summary>CertChainObjectName: Certificate chain object name in Azure Key Vault.</summary>
    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    /// <summary>CertObjectName: Intermediate certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    /// <summary>KeyObjectName: Intermediate certificate private key object name in Azure Key Vault.</summary>
    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20240901ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>RootCertObjectName: Root certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>
/// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
/// certificates as described  here https://aka.ms/asm-plugin-ca
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V1api20240901ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>Enabled: Whether to enable the egress gateway.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Mode: Mode of an ingress gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum>))]
public enum V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum
{
    [EnumMember(Value = "External"), JsonStringEnumMemberName("External")]
    External,
    [EnumMember(Value = "Internal"), JsonStringEnumMemberName("Internal")]
    Internal
}

/// <summary>
/// Istio ingress gateway configuration. For now, we support up to one external ingress gateway named
/// `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>Enabled: Whether to enable the ingress gateway.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>Mode: Mode of an ingress gateway.</summary>
    [JsonPropertyName("mode")]
    public required V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum Mode { get; set; }
}

/// <summary>Components: Istio components configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponents
{
    /// <summary>EgressGateways: Istio egress gateways.</summary>
    [JsonPropertyName("egressGateways")]
    public IList<V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary>IngressGateways: Istio ingress gateways.</summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }
}

/// <summary>Istio: Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfileIstio
{
    /// <summary>
    /// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
    /// certificates as described  here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20240901ManagedClusterSpecServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Components: Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V1api20240901ManagedClusterSpecServiceMeshProfileIstioComponents? Components { get; set; }

    /// <summary>
    /// Revisions: The list of revisions of the Istio control plane. When an upgrade is not in progress, this holds one value.
    /// When canary upgrade is in progress, this can only hold two consecutive values. For more information, see:
    /// https://learn.microsoft.com/en-us/azure/aks/istio-upgrade
    /// </summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>Mode: Mode of the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecServiceMeshProfileModeEnum>))]
public enum V1api20240901ManagedClusterSpecServiceMeshProfileModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Istio"), JsonStringEnumMemberName("Istio")]
    Istio
}

/// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServiceMeshProfile
{
    /// <summary>Istio: Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V1api20240901ManagedClusterSpecServiceMeshProfileIstio? Istio { get; set; }

    /// <summary>Mode: Mode of the service mesh.</summary>
    [JsonPropertyName("mode")]
    public required V1api20240901ManagedClusterSpecServiceMeshProfileModeEnum Mode { get; set; }
}

/// <summary>Secret: The secret password associated with the service principal in plain text.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServicePrincipalProfileSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
/// APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecServicePrincipalProfile
{
    /// <summary>ClientId: The ID for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    /// <summary>Secret: The secret password associated with the service principal in plain text.</summary>
    [JsonPropertyName("secret")]
    public V1api20240901ManagedClusterSpecServicePrincipalProfileSecret? Secret { get; set; }
}

/// <summary>Name: The name of a managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecSkuNameEnum>))]
public enum V1api20240901ManagedClusterSpecSkuNameEnum
{
    [EnumMember(Value = "Base"), JsonStringEnumMemberName("Base")]
    Base
}

/// <summary>
/// Tier: If not specified, the default is &apos;Free&apos;. See [AKS Pricing
/// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecSkuTierEnum>))]
public enum V1api20240901ManagedClusterSpecSkuTierEnum
{
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecSku
{
    /// <summary>Name: The name of a managed cluster SKU.</summary>
    [JsonPropertyName("name")]
    public V1api20240901ManagedClusterSpecSkuNameEnum? Name { get; set; }

    /// <summary>
    /// Tier: If not specified, the default is &apos;Free&apos;. See [AKS Pricing
    /// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers) for more details.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20240901ManagedClusterSpecSkuTierEnum? Tier { get; set; }
}

/// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecStorageProfileBlobCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureBlob CSI Driver. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecStorageProfileDiskCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureDisk CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecStorageProfileFileCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureFile CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecStorageProfileSnapshotController
{
    /// <summary>Enabled: Whether to enable Snapshot Controller. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecStorageProfile
{
    /// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V1api20240901ManagedClusterSpecStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V1api20240901ManagedClusterSpecStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V1api20240901ManagedClusterSpecStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V1api20240901ManagedClusterSpecStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecSupportPlanEnum>))]
public enum V1api20240901ManagedClusterSpecSupportPlanEnum
{
    [EnumMember(Value = "AKSLongTermSupport"), JsonStringEnumMemberName("AKSLongTermSupport")]
    AKSLongTermSupport,
    [EnumMember(Value = "KubernetesOfficial"), JsonStringEnumMemberName("KubernetesOfficial")]
    KubernetesOfficial
}

/// <summary>OverrideSettings: Settings for overrides.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecUpgradeSettingsOverrideSettings
{
    /// <summary>
    /// ForceUpgrade: Whether to force upgrade the cluster. Note that this option instructs upgrade operation to bypass upgrade
    /// protections such as checking for deprecated API usage. Enable this option only with caution.
    /// </summary>
    [JsonPropertyName("forceUpgrade")]
    public bool? ForceUpgrade { get; set; }

    /// <summary>
    /// Until: Until when the overrides are effective. Note that this only matches the start time of an upgrade, and the
    /// effectiveness won&apos;t change once an upgrade starts even if the `until` expires as upgrade proceeds. This field is not set
    /// by default. It must be set for the overrides to take effect.
    /// </summary>
    [JsonPropertyName("until")]
    public string? Until { get; set; }
}

/// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecUpgradeSettings
{
    /// <summary>OverrideSettings: Settings for overrides.</summary>
    [JsonPropertyName("overrideSettings")]
    public V1api20240901ManagedClusterSpecUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>
/// AdminPassword: Specifies the password of the administrator account.
/// Minimum-length: 8 characters
/// Max-length: 123 characters
/// Complexity requirements: 3 out of 4 conditions below need to be fulfilled
/// Has lower characters
/// Has upper characters
/// Has a digit
/// Has a special character (Regex match [\W_])
/// Disallowed values: &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;,
/// &quot;Password22&quot;, &quot;iloveyou!&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecWindowsProfileAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecWindowsProfileGmsaProfile
{
    /// <summary>
    /// DnsServer: Specifies the DNS server for Windows gMSA.
    /// Set it to empty if you have configured the DNS server in the vnet which is used to create the managed cluster.
    /// </summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary>Enabled: Specifies whether to enable Windows gMSA in the managed cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RootDomainName: Specifies the root domain name for Windows gMSA.
    /// Set it to empty if you have configured the DNS server in the vnet which is used to create the managed cluster.
    /// </summary>
    [JsonPropertyName("rootDomainName")]
    public string? RootDomainName { get; set; }
}

/// <summary>
/// LicenseType: The license type to use for Windows VMs. See [Azure Hybrid User
/// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClusterSpecWindowsProfileLicenseTypeEnum>))]
public enum V1api20240901ManagedClusterSpecWindowsProfileLicenseTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Windows_Server"), JsonStringEnumMemberName("Windows_Server")]
    WindowsServer
}

/// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecWindowsProfile
{
    /// <summary>
    /// AdminPassword: Specifies the password of the administrator account.
    /// Minimum-length: 8 characters
    /// Max-length: 123 characters
    /// Complexity requirements: 3 out of 4 conditions below need to be fulfilled
    /// Has lower characters
    /// Has upper characters
    /// Has a digit
    /// Has a special character (Regex match [\W_])
    /// Disallowed values: &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;,
    /// &quot;Password22&quot;, &quot;iloveyou!&quot;
    /// </summary>
    [JsonPropertyName("adminPassword")]
    public V1api20240901ManagedClusterSpecWindowsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// Restriction: Cannot end in &quot;.&quot;
    /// Disallowed values: &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;,
    /// &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;,
    /// &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;.
    /// Minimum-length: 1 character
    /// Max-length: 20 characters
    /// </summary>
    [JsonPropertyName("adminUsername")]
    public required string AdminUsername { get; set; }

    /// <summary>
    /// EnableCSIProxy: For more details on CSI proxy, see the [CSI proxy GitHub
    /// repo](https://github.com/kubernetes-csi/csi-proxy).
    /// </summary>
    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
    [JsonPropertyName("gmsaProfile")]
    public V1api20240901ManagedClusterSpecWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    /// <summary>
    /// LicenseType: The license type to use for Windows VMs. See [Azure Hybrid User
    /// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public V1api20240901ManagedClusterSpecWindowsProfileLicenseTypeEnum? LicenseType { get; set; }
}

/// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecWorkloadAutoScalerProfileKeda
{
    /// <summary>Enabled: Whether to enable KEDA.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>Enabled: Whether to enable VPA. Default value is false.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpecWorkloadAutoScalerProfile
{
    /// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V1api20240901ManagedClusterSpecWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V1api20240901ManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterSpec
{
    /// <summary>AadProfile: The Azure Active Directory configuration.</summary>
    [JsonPropertyName("aadProfile")]
    public V1api20240901ManagedClusterSpecAadProfile? AadProfile { get; set; }

    /// <summary>AddonProfiles: The profile of managed cluster add-on.</summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V1api20240901ManagedClusterSpecAddonProfiles>? AddonProfiles { get; set; }

    /// <summary>AgentPoolProfiles: The agent pool properties.</summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V1api20240901ManagedClusterSpecAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V1api20240901ManagedClusterSpecApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V1api20240901ManagedClusterSpecAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V1api20240901ManagedClusterSpecAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V1api20240901ManagedClusterSpecAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// DisableLocalAccounts: If set to true, getting static credentials will be disabled for this cluster. This must only be
    /// used on Managed Clusters that are AAD enabled. For more details see [disable local
    /// accounts](https://docs.microsoft.com/azure/aks/managed-aad#disable-local-accounts-preview).
    /// </summary>
    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    /// <summary>
    /// DiskEncryptionSetReference: This is of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
    /// </summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20240901ManagedClusterSpecDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>DnsPrefix: This cannot be updated once the Managed Cluster has been created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>
    /// EnablePodSecurityPolicy: (DEPRECATED) Whether to enable Kubernetes pod security policy (preview). PodSecurityPolicy was
    /// deprecated in Kubernetes v1.21, and removed from Kubernetes in v1.25. Learn more at https://aka.ms/k8s/psp and
    /// https://aka.ms/aks/psp.
    /// </summary>
    [JsonPropertyName("enablePodSecurityPolicy")]
    public bool? EnablePodSecurityPolicy { get; set; }

    /// <summary>EnableRBAC: Whether to enable Kubernetes Role-Based Access Control.</summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240901ManagedClusterSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FqdnSubdomain: This cannot be updated once the Managed Cluster has been created.</summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V1api20240901ManagedClusterSpecHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>Identity: The identity of the managed cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901ManagedClusterSpecIdentity? Identity { get; set; }

    /// <summary>
    /// IdentityProfile: The user identity associated with the managed cluster. This identity will be used by the kubelet. Only
    /// one user assigned identity is allowed. The only accepted key is &quot;kubeletidentity&quot;, with value of &quot;resourceId&quot;:
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&quot;.
    /// </summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V1api20240901ManagedClusterSpecIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V1api20240901ManagedClusterSpecIngressProfile? IngressProfile { get; set; }

    /// <summary>
    /// KubernetesVersion: Both patch version &lt;major.minor.patch&gt; (e.g. 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported.
    /// When &lt;major.minor&gt; is specified, the latest supported GA patch version is chosen automatically. Updating the cluster
    /// with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x -&gt; 1.14) will not trigger an upgrade, even if a newer
    /// patch version is available. When you upgrade a supported AKS cluster, Kubernetes minor versions cannot be skipped. All
    /// upgrades must be performed sequentially by major version number. For example, upgrades between 1.14.x -&gt; 1.15.x or
    /// 1.15.x -&gt; 1.16.x are allowed, however 1.14.x -&gt; 1.16.x is not allowed. See [upgrading an AKS
    /// cluster](https://docs.microsoft.com/azure/aks/upgrade-cluster) for more details.
    /// </summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
    [JsonPropertyName("linuxProfile")]
    public V1api20240901ManagedClusterSpecLinuxProfile? LinuxProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
    [JsonPropertyName("metricsProfile")]
    public V1api20240901ManagedClusterSpecMetricsProfile? MetricsProfile { get; set; }

    /// <summary>NetworkProfile: The network configuration profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901ManagedClusterSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeResourceGroup: The name of the resource group containing agent pool nodes.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V1api20240901ManagedClusterSpecNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20240901ManagedClusterSpecOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240901ManagedClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240901ManagedClusterSpecOwner Owner { get; set; }

    /// <summary>
    /// PodIdentityProfile: See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more
    /// details on AAD pod identity integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V1api20240901ManagedClusterSpecPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>PrivateLinkResources: Private link resources associated with the cluster.</summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V1api20240901ManagedClusterSpecPrivateLinkResources>? PrivateLinkResources { get; set; }

    /// <summary>PublicNetworkAccess: Allow or deny public network access for AKS</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20240901ManagedClusterSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901ManagedClusterSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V1api20240901ManagedClusterSpecServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
    /// APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20240901ManagedClusterSpecServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Sku: The managed cluster SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20240901ManagedClusterSpecSku? Sku { get; set; }

    /// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20240901ManagedClusterSpecStorageProfile? StorageProfile { get; set; }

    /// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
    [JsonPropertyName("supportPlan")]
    public V1api20240901ManagedClusterSpecSupportPlanEnum? SupportPlan { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901ManagedClusterSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901ManagedClusterSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V1api20240901ManagedClusterSpecWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>AadProfile: The Azure Active Directory configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAadProfile
{
    /// <summary>AdminGroupObjectIDs: The list of AAD group object IDs that will have admin role of the cluster.</summary>
    [JsonPropertyName("adminGroupObjectIDs")]
    public IList<string>? AdminGroupObjectIDs { get; set; }

    /// <summary>ClientAppID: (DEPRECATED) The client AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.</summary>
    [JsonPropertyName("clientAppID")]
    public string? ClientAppID { get; set; }

    /// <summary>EnableAzureRBAC: Whether to enable Azure RBAC for Kubernetes authorization.</summary>
    [JsonPropertyName("enableAzureRBAC")]
    public bool? EnableAzureRBAC { get; set; }

    /// <summary>Managed: Whether to enable managed AAD.</summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    /// <summary>ServerAppID: (DEPRECATED) The server AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.</summary>
    [JsonPropertyName("serverAppID")]
    public string? ServerAppID { get; set; }

    /// <summary>ServerAppSecret: (DEPRECATED) The server AAD application secret. Learn more at https://aka.ms/aks/aad-legacy.</summary>
    [JsonPropertyName("serverAppSecret")]
    public string? ServerAppSecret { get; set; }

    /// <summary>
    /// TenantID: The AAD tenant ID to use for authentication. If not specified, will use the tenant of the deployment
    /// subscription.
    /// </summary>
    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>Identity: Information of user assigned identity used by this add-on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAddonProfilesIdentity
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ResourceId: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>A Kubernetes add-on profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAddonProfiles
{
    /// <summary>Config: Key-value pairs for configuring an add-on.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary>Enabled: Whether the add-on is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identity: Information of user assigned identity used by this add-on.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901ManagedClusterStatusAddonProfilesIdentity? Identity { get; set; }
}

/// <summary>
/// CreationData: CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using
/// a snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesCreationData
{
    /// <summary>SourceResourceId: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesKubeletConfig
{
    /// <summary>AllowedUnsafeSysctls: Allowed list of unsafe sysctls or unsafe sysctl patterns (ending in `*`).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>
    /// ContainerLogMaxFiles: The maximum number of container log files that can be present for a container. The number must be
    /// ≥ 2.
    /// </summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public int? ContainerLogMaxFiles { get; set; }

    /// <summary>ContainerLogMaxSizeMB: The maximum size (e.g. 10Mi) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMB")]
    public int? ContainerLogMaxSizeMB { get; set; }

    /// <summary>CpuCfsQuota: The default is true.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>
    /// CpuCfsQuotaPeriod: The default is &apos;100ms.&apos; Valid values are a sequence of decimal numbers with an optional fraction and
    /// a unit suffix. For example: &apos;300ms&apos;, &apos;2h45m&apos;. Supported units are &apos;ns&apos;, &apos;us&apos;, &apos;ms&apos;, &apos;s&apos;, &apos;m&apos;, and &apos;h&apos;.
    /// </summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// CpuManagerPolicy: The default is &apos;none&apos;. See [Kubernetes CPU management
    /// policies](https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/#cpu-management-policies) for more
    /// information. Allowed values are &apos;none&apos; and &apos;static&apos;.
    /// </summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>FailSwapOn: If set to true it will make the Kubelet fail to start if swap is enabled on the node.</summary>
    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    /// <summary>ImageGcHighThreshold: To disable image garbage collection, set to 100. The default is 85%</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    /// <summary>ImageGcLowThreshold: This cannot be set higher than imageGcHighThreshold. The default is 80%</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    /// <summary>PodMaxPids: The maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    /// <summary>
    /// TopologyManagerPolicy: For more information see [Kubernetes Topology
    /// Manager](https://kubernetes.io/docs/tasks/administer-cluster/topology-manager). The default is &apos;none&apos;. Allowed values
    /// are &apos;none&apos;, &apos;best-effort&apos;, &apos;restricted&apos;, and &apos;single-numa-node&apos;.
    /// </summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls
{
    /// <summary>FsAioMaxNr: Sysctl setting fs.aio-max-nr.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public int? FsAioMaxNr { get; set; }

    /// <summary>FsFileMax: Sysctl setting fs.file-max.</summary>
    [JsonPropertyName("fsFileMax")]
    public int? FsFileMax { get; set; }

    /// <summary>FsInotifyMaxUserWatches: Sysctl setting fs.inotify.max_user_watches.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public int? FsInotifyMaxUserWatches { get; set; }

    /// <summary>FsNrOpen: Sysctl setting fs.nr_open.</summary>
    [JsonPropertyName("fsNrOpen")]
    public int? FsNrOpen { get; set; }

    /// <summary>KernelThreadsMax: Sysctl setting kernel.threads-max.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public int? KernelThreadsMax { get; set; }

    /// <summary>NetCoreNetdevMaxBacklog: Sysctl setting net.core.netdev_max_backlog.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public int? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>NetCoreOptmemMax: Sysctl setting net.core.optmem_max.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public int? NetCoreOptmemMax { get; set; }

    /// <summary>NetCoreRmemDefault: Sysctl setting net.core.rmem_default.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public int? NetCoreRmemDefault { get; set; }

    /// <summary>NetCoreRmemMax: Sysctl setting net.core.rmem_max.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public int? NetCoreRmemMax { get; set; }

    /// <summary>NetCoreSomaxconn: Sysctl setting net.core.somaxconn.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public int? NetCoreSomaxconn { get; set; }

    /// <summary>NetCoreWmemDefault: Sysctl setting net.core.wmem_default.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public int? NetCoreWmemDefault { get; set; }

    /// <summary>NetCoreWmemMax: Sysctl setting net.core.wmem_max.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public int? NetCoreWmemMax { get; set; }

    /// <summary>NetIpv4IpLocalPortRange: Sysctl setting net.ipv4.ip_local_port_range.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRange")]
    public string? NetIpv4IpLocalPortRange { get; set; }

    /// <summary>NetIpv4NeighDefaultGcThresh1: Sysctl setting net.ipv4.neigh.default.gc_thresh1.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public int? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>NetIpv4NeighDefaultGcThresh2: Sysctl setting net.ipv4.neigh.default.gc_thresh2.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public int? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>NetIpv4NeighDefaultGcThresh3: Sysctl setting net.ipv4.neigh.default.gc_thresh3.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public int? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>NetIpv4TcpFinTimeout: Sysctl setting net.ipv4.tcp_fin_timeout.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public int? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>NetIpv4TcpKeepaliveProbes: Sysctl setting net.ipv4.tcp_keepalive_probes.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public int? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>NetIpv4TcpKeepaliveTime: Sysctl setting net.ipv4.tcp_keepalive_time.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public int? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>NetIpv4TcpMaxSynBacklog: Sysctl setting net.ipv4.tcp_max_syn_backlog.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public int? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>NetIpv4TcpMaxTwBuckets: Sysctl setting net.ipv4.tcp_max_tw_buckets.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public int? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>NetIpv4TcpTwReuse: Sysctl setting net.ipv4.tcp_tw_reuse.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>NetIpv4TcpkeepaliveIntvl: Sysctl setting net.ipv4.tcp_keepalive_intvl.</summary>
    [JsonPropertyName("netIpv4TcpkeepaliveIntvl")]
    public int? NetIpv4TcpkeepaliveIntvl { get; set; }

    /// <summary>NetNetfilterNfConntrackBuckets: Sysctl setting net.netfilter.nf_conntrack_buckets.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public int? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>NetNetfilterNfConntrackMax: Sysctl setting net.netfilter.nf_conntrack_max.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public int? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>VmMaxMapCount: Sysctl setting vm.max_map_count.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public int? VmMaxMapCount { get; set; }

    /// <summary>VmSwappiness: Sysctl setting vm.swappiness.</summary>
    [JsonPropertyName("vmSwappiness")]
    public int? VmSwappiness { get; set; }

    /// <summary>VmVfsCachePressure: Sysctl setting vm.vfs_cache_pressure.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public int? VmVfsCachePressure { get; set; }
}

/// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary>
    /// TransparentHugePageDefrag: Valid values are &apos;always&apos;, &apos;defer&apos;, &apos;defer+madvise&apos;, &apos;madvise&apos; and &apos;never&apos;. The default is
    /// &apos;madvise&apos;. For more information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>
    /// TransparentHugePageEnabled: Valid values are &apos;always&apos;, &apos;madvise&apos;, and &apos;never&apos;. The default is &apos;always&apos;. For more
    /// information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts
{
    /// <summary>
    /// PortEnd: The maximum port that is included in the range. It should be ranged from 1 to 65535, and be greater than or
    /// equal to portStart.
    /// </summary>
    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    /// <summary>
    /// PortStart: The minimum port that is included in the range. It should be ranged from 1 to 65535, and be less than or
    /// equal to portEnd.
    /// </summary>
    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    /// <summary>Protocol: The network protocol of the port.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Contains the IPTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags
{
    /// <summary>IpTagType: The IP tag type. Example: RoutingPreference.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: The value of the IP tag associated with the public IP. Example: Internet.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901ManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>ApplicationSecurityGroups: The IDs of the application security groups which agent pool will associate when created.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901ManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// PowerState: When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this
/// field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only
/// be stopped if it is Running and provisioning state is Succeeded
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesSecurityProfile
{
    /// <summary>
    /// EnableSecureBoot: Secure Boot is a feature of Trusted Launch which ensures that only signed operating systems and
    /// drivers can boot. For more details, see aka.ms/aks/trustedlaunch.  If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>
    /// EnableVTPM: vTPM is a Trusted Launch feature for configuring a dedicated secure vault for keys and measurements held
    /// locally on the node. For more details, see aka.ms/aks/trustedlaunch. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesUpgradeSettings
{
    /// <summary>
    /// DrainTimeoutInMinutes: The amount of time (in minutes) to wait on eviction of pods and graceful termination per node.
    /// This eviction wait time honors waiting on pod disruption budgets. If this time is exceeded, the upgrade fails. If not
    /// specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// MaxSurge: This can either be set to an integer (e.g. &apos;5&apos;) or a percentage (e.g. &apos;50%&apos;). If a percentage is specified, it
    /// is the percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded
    /// up. If not specified, the default is 1. For more information, including best practices, see:
    /// https://docs.microsoft.com/azure/aks/upgrade-cluster#customize-node-surge-upgrade
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>
    /// NodeSoakDurationInMinutes: The amount of time (in minutes) to wait after draining a node and before reimaging it and
    /// moving on to next node. If not specified, the default is 0 minutes.
    /// </summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }
}

/// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfilesWindowsProfile
{
    /// <summary>
    /// DisableOutboundNat: The default value is false. Outbound NAT can only be disabled if the cluster outboundType is NAT
    /// Gateway and the Windows agent pool does not have node public IP enabled.
    /// </summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>Profile for the container service agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAgentPoolProfiles
{
    /// <summary>
    /// AvailabilityZones: The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType
    /// property is &apos;VirtualMachineScaleSets&apos;.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>CapacityReservationGroupID: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
    [JsonPropertyName("capacityReservationGroupID")]
    public string? CapacityReservationGroupID { get; set; }

    /// <summary>
    /// Count: Number of agents (VMs) to host docker containers. Allowed values must be in the range of 0 to 1000 (inclusive)
    /// for user pools and in the range of 1 to 1000 (inclusive) for system pools. The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// CreationData: CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using
    /// a snapshot.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesCreationData? CreationData { get; set; }

    /// <summary>
    /// CurrentOrchestratorVersion: If orchestratorVersion is a fully specified version &lt;major.minor.patch&gt;, this field will be
    /// exactly equal to it. If orchestratorVersion is &lt;major.minor&gt;, this field will contain the full &lt;major.minor.patch&gt;
    /// version being used.
    /// </summary>
    [JsonPropertyName("currentOrchestratorVersion")]
    public string? CurrentOrchestratorVersion { get; set; }

    /// <summary>
    /// ETag: Unique read-only string used to implement optimistic concurrency. The eTag value will change when the resource is
    /// updated. Specify an if-match or if-none-match header with the eTag value for a subsequent request to enable optimistic
    /// concurrency per the normal etag convention.
    /// </summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>EnableAutoScaling: Whether to enable auto-scaler</summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary>
    /// EnableEncryptionAtHost: This is only supported on certain VM sizes and in certain Azure regions. For more information,
    /// see: https://docs.microsoft.com/azure/aks/enable-host-encryption
    /// </summary>
    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    /// <summary>
    /// EnableFIPS: See [Add a FIPS-enabled node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview) for more
    /// details.
    /// </summary>
    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    /// <summary>
    /// EnableNodePublicIP: Some scenarios may require nodes in a node pool to receive their own dedicated public IP addresses.
    /// A common scenario is for gaming workloads, where a console needs to make a direct connection to a cloud virtual machine
    /// to minimize hops. For more information see [assigning a public IP per
    /// node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools). The
    /// default is false.
    /// </summary>
    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    /// <summary>EnableUltraSSD: Whether to enable UltraSSD</summary>
    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>
    /// HostGroupID: This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupID")]
    public string? HostGroupID { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>MaxCount: The maximum number of nodes for auto-scaling</summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary>MaxPods: The maximum number of pods that can run on a node.</summary>
    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    /// <summary>MinCount: The minimum number of nodes for auto-scaling</summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary>
    /// Mode: A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional information on agent pool
    /// restrictions  and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Name: Windows agent pool names must be 6 characters or less.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeImageVersion: The version of node image</summary>
    [JsonPropertyName("nodeImageVersion")]
    public string? NodeImageVersion { get; set; }

    /// <summary>NodeLabels: The node labels to be persisted across all nodes in agent pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixID: This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixID")]
    public string? NodePublicIPPrefixID { get; set; }

    /// <summary>NodeTaints: The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule.</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>
    /// OrchestratorVersion: Both patch version &lt;major.minor.patch&gt; (e.g. 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported.
    /// When &lt;major.minor&gt; is specified, the latest supported GA patch version is chosen automatically. Updating the cluster
    /// with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x -&gt; 1.14) will not trigger an upgrade, even if a newer
    /// patch version is available. As a best practice, you should upgrade all node pools in an AKS cluster to the same
    /// Kubernetes version. The node pool version must have the same major version as the control plane. The node pool minor
    /// version must be within two minor versions of the control plane version. The node pool version cannot be greater than the
    /// control plane version. For more information see [upgrading a node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool).
    /// </summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary>
    /// OsDiskType: The default is &apos;Ephemeral&apos; if the VM supports it and has a cache disk larger than the requested
    /// OSDiskSizeGB. Otherwise,  defaults to &apos;Managed&apos;. May not be changed after creation. For more information see [Ephemeral
    /// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
    /// </summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>
    /// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
    /// when  Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    [JsonPropertyName("osSKU")]
    public string? OsSKU { get; set; }

    /// <summary>OsType: The operating system type. The default is Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>
    /// PodSubnetID: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is
    /// of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetID")]
    public string? PodSubnetID { get; set; }

    /// <summary>
    /// PowerState: When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this
    /// field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only
    /// be stopped if it is Running and provisioning state is Succeeded
    /// </summary>
    [JsonPropertyName("powerState")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesPowerState? PowerState { get; set; }

    /// <summary>ProvisioningState: The current deployment or provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ProximityPlacementGroupID: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupID")]
    public string? ProximityPlacementGroupID { get; set; }

    /// <summary>ScaleDownMode: This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>
    /// ScaleSetEvictionPolicy: This cannot be specified unless the scaleSetPriority is &apos;Spot&apos;. If not specified, the default is
    /// &apos;Delete&apos;.
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public string? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public string? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// SpotMaxPrice: Possible values are any decimal value greater than zero or -1 which indicates the willingness to pay any
    /// on-demand price. For more details on spot pricing, see [spot VMs
    /// pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing)
    /// </summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>Tags: The tags to be persisted on the agent pool virtual machine scale set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Agent Pool.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// VmSize: VM size availability varies by region. If a node contains insufficient compute resources (memory, cpu, etc) pods
    /// might fail to run correctly. For more details on restricted VM sizes, see:
    /// https://docs.microsoft.com/azure/aks/quotas-skus-regions
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VnetSubnetID: If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified,
    /// this applies to nodes and pods, otherwise it applies to just nodes. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("vnetSubnetID")]
    public string? VnetSubnetID { get; set; }

    /// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901ManagedClusterStatusAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusApiServerAccessProfile
{
    /// <summary>
    /// AuthorizedIPRanges: IP ranges are specified in CIDR format, e.g. 137.117.106.88/29. This feature is not compatible with
    /// clusters that use Public IP Per Node, or clusters that are using a Basic Load Balancer. For more information see [API
    /// server authorized IP ranges](https://docs.microsoft.com/azure/aks/api-server-authorized-ip-ranges).
    /// </summary>
    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    /// <summary>DisableRunCommand: Whether to disable run command for the cluster or not.</summary>
    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    /// <summary>
    /// EnablePrivateCluster: For more details, see [Creating a private AKS
    /// cluster](https://docs.microsoft.com/azure/aks/private-clusters).
    /// </summary>
    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    /// <summary>EnablePrivateClusterPublicFQDN: Whether to create additional public FQDN for private cluster or not.</summary>
    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    /// <summary>
    /// PrivateDNSZone: The default is System. For more details see [configure private DNS
    /// zone](https://docs.microsoft.com/azure/aks/private-clusters#configure-private-dns-zone). Allowed values are &apos;system&apos; and
    /// &apos;none&apos;.
    /// </summary>
    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }
}

/// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAutoScalerProfile
{
    /// <summary>BalanceSimilarNodeGroups: Valid values are &apos;true&apos; and &apos;false&apos;</summary>
    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    /// <summary>
    /// DaemonsetEvictionForEmptyNodes: If set to true, all daemonset pods on empty nodes will be evicted before deletion of the
    /// node. If the daemonset pod cannot be evicted another node will be chosen for scaling. If set to false, the node will be
    /// deleted without ensuring that daemonset pods are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    /// <summary>
    /// DaemonsetEvictionForOccupiedNodes: If set to true, all daemonset pods on occupied nodes will be evicted before deletion
    /// of the node. If the daemonset pod cannot be evicted another node will be chosen for scaling. If set to false, the node
    /// will be deleted without ensuring that daemonset pods are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    /// <summary>
    /// Expander: If not specified, the default is &apos;random&apos;. See
    /// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more
    /// information.
    /// </summary>
    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    /// <summary>
    /// IgnoreDaemonsetsUtilization: If set to true, the resources used by daemonset will be taken into account when making
    /// scaling down decisions.
    /// </summary>
    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    /// <summary>MaxEmptyBulkDelete: The default is 10.</summary>
    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    /// <summary>MaxGracefulTerminationSec: The default is 600.</summary>
    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary>
    /// MaxNodeProvisionTime: The default is &apos;15m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    /// <summary>MaxTotalUnreadyPercentage: The default is 45. The maximum is 100 and the minimum is 0.</summary>
    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    /// <summary>
    /// NewPodScaleUpDelay: For scenarios like burst/batch scale where you don&apos;t want CA to act before the kubernetes scheduler
    /// could schedule all the pods, you can tell CA to ignore unscheduled pods before they&apos;re a certain age. The default is
    /// &apos;0s&apos;. Values must be an integer followed by a unit (&apos;s&apos; for seconds, &apos;m&apos; for minutes, &apos;h&apos; for hours, etc).
    /// </summary>
    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary>OkTotalUnreadyCount: This must be an integer. The default is 3.</summary>
    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterAdd: The default is &apos;10m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterDelete: The default is the scan-interval. Values must be an integer followed by an &apos;m&apos;. No unit of
    /// time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterFailure: The default is &apos;3m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other
    /// than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary>
    /// ScaleDownUnneededTime: The default is &apos;10m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    /// <summary>
    /// ScaleDownUnreadyTime: The default is &apos;20m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than
    /// minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    /// <summary>ScaleDownUtilizationThreshold: The default is &apos;0.5&apos;.</summary>
    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary>ScanInterval: The default is &apos;10&apos;. Values must be an integer number of seconds.</summary>
    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    /// <summary>SkipNodesWithLocalStorage: The default is true.</summary>
    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    /// <summary>SkipNodesWithSystemPods: The default is true.</summary>
    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAutoUpgradeProfile
{
    /// <summary>NodeOSUpgradeChannel: Manner in which the OS on your nodes is updated. The default is NodeImage.</summary>
    [JsonPropertyName("nodeOSUpgradeChannel")]
    public string? NodeOSUpgradeChannel { get; set; }

    /// <summary>
    /// UpgradeChannel: For more information see [setting the AKS cluster auto-upgrade
    /// channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
    /// </summary>
    [JsonPropertyName("upgradeChannel")]
    public string? UpgradeChannel { get; set; }
}

/// <summary>
/// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
///  kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics
{
    /// <summary>
    /// MetricAnnotationsAllowList: Comma-separated list of Kubernetes annotation keys that will be used in the resource&apos;s
    /// labels metric (Example: &apos;namespaces=[kubernetes.io/team,...],pods=[kubernetes.io/team],...&apos;). By default the metric
    /// contains only resource name and namespace labels.
    /// </summary>
    [JsonPropertyName("metricAnnotationsAllowList")]
    public string? MetricAnnotationsAllowList { get; set; }

    /// <summary>
    /// MetricLabelsAllowlist: Comma-separated list of additional Kubernetes label keys that will be used in the resource&apos;s
    /// labels metric (Example: &apos;namespaces=[k8s-label-1,k8s-label-n,...],pods=[app],...&apos;). By default the metric contains only
    /// resource name and namespace labels.
    /// </summary>
    [JsonPropertyName("metricLabelsAllowlist")]
    public string? MetricLabelsAllowlist { get; set; }
}

/// <summary>
/// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
/// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
/// aka.ms/AzureManagedPrometheus for an overview.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAzureMonitorProfileMetrics
{
    /// <summary>
    /// Enabled: Whether to enable or disable the Azure Managed Prometheus addon for Prometheus monitoring. See
    /// aka.ms/AzureManagedPrometheus-aks-enable for details on enabling and disabling.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
    ///  kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
    /// details.
    /// </summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V1api20240901ManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusAzureMonitorProfile
{
    /// <summary>
    /// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V1api20240901ManagedClusterStatusAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusHttpProxyConfig
{
    /// <summary>HttpProxy: The HTTP proxy server endpoint to use.</summary>
    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    /// <summary>HttpsProxy: The HTTPS proxy server endpoint to use.</summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary>NoProxy: The endpoints that should not go through proxy.</summary>
    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    /// <summary>TrustedCa: Alternative CA cert to use for connecting to proxy servers.</summary>
    [JsonPropertyName("trustedCa")]
    public string? TrustedCa { get; set; }
}

/// <summary>Delegated resource properties - internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusIdentityDelegatedResources
{
    /// <summary>Location: The source resource location - internal use only.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ReferralResource: The delegation id of the referral delegation (optional) - internal use only.</summary>
    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    /// <summary>ResourceId: The ARM resource id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>TenantId: The tenant id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the managed cluster, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusIdentity
{
    /// <summary>
    /// DelegatedResources: The delegated identity resources assigned to this managed cluster. This can only be set by another
    /// Azure Resource Provider, and managed cluster only accept one delegated identity resource. Internal use only.
    /// </summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V1api20240901ManagedClusterStatusIdentityDelegatedResources>? DelegatedResources { get; set; }

    /// <summary>PrincipalId: The principal id of the system assigned identity which is used by master components.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant id of the system assigned identity which is used by master components.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: For more information see [use managed identities in
    /// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The keys must be ARM resource IDs in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240901ManagedClusterStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusIdentityProfile
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ResourceId: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// Identity: Managed identity of the Application Routing add-on. This is the identity that should be granted permissions,
/// for example, to manage the associated Azure DNS resource and get certificates from Azure Key Vault. See [this overview
/// of the add-on](https://learn.microsoft.com/en-us/azure/aks/web-app-routing?tabs=with-osm) for more instructions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusIngressProfileWebAppRoutingIdentity
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ResourceId: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
/// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusIngressProfileWebAppRouting
{
    /// <summary>
    /// DnsZoneResourceIds: Resource IDs of the DNS zones to be associated with the Application Routing add-on. Used only when
    /// Application Routing add-on is enabled. Public and private DNS zones can be in different resource groups, but all public
    /// DNS zones must be in the same resource group and all private DNS zones must be in the same resource group.
    /// </summary>
    [JsonPropertyName("dnsZoneResourceIds")]
    public IList<string>? DnsZoneResourceIds { get; set; }

    /// <summary>Enabled: Whether to enable the Application Routing add-on.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Identity: Managed identity of the Application Routing add-on. This is the identity that should be granted permissions,
    /// for example, to manage the associated Azure DNS resource and get certificates from Azure Key Vault. See [this overview
    /// of the add-on](https://learn.microsoft.com/en-us/azure/aks/web-app-routing?tabs=with-osm) for more instructions.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20240901ManagedClusterStatusIngressProfileWebAppRoutingIdentity? Identity { get; set; }
}

/// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusIngressProfile
{
    /// <summary>
    /// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
    /// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V1api20240901ManagedClusterStatusIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusLinuxProfileSshPublicKeys
{
    /// <summary>
    /// KeyData: Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or
    /// without headers.
    /// </summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusLinuxProfileSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20240901ManagedClusterStatusLinuxProfileSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusLinuxProfile
{
    /// <summary>AdminUsername: The administrator username to use for Linux VMs.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public V1api20240901ManagedClusterStatusLinuxProfileSsh? Ssh { get; set; }
}

/// <summary>CostAnalysis: The cost analysis configuration for the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusMetricsProfileCostAnalysis
{
    /// <summary>
    /// Enabled: The Managed Cluster sku.tier must be set to &apos;Standard&apos; or &apos;Premium&apos; to enable this feature. Enabling this will
    /// add Kubernetes Namespace and Deployment details to the Cost Analysis views in the Azure portal. If not specified, the
    /// default is false. For more information see aka.ms/aks/docs/cost-analysis.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusMetricsProfile
{
    /// <summary>CostAnalysis: The cost analysis configuration for the cluster</summary>
    [JsonPropertyName("costAnalysis")]
    public V1api20240901ManagedClusterStatusMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>Enabled: Indicates the enablement of Advanced Networking observability functionalities on clusters.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>
    /// Enabled: This feature allows user to configure network policy based on DNS (FQDN) names. It can be enabled only on
    /// cilium based clusters. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
/// more information see  aka.ms/aksadvancednetworking.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileAdvancedNetworking
{
    /// <summary>
    /// Enabled: Indicates the enablement of Advanced Networking functionalities of observability and security on AKS clusters.
    /// When this is set to true, all observability and security features will be set to enabled unless explicitly disabled. If
    /// not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
    [JsonPropertyName("observability")]
    public V1api20240901ManagedClusterStatusNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V1api20240901ManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs
{
    /// <summary>
    /// Count: The desired number of IPv4 outbound IPs created/managed by Azure for the cluster load balancer. Allowed values
    /// must be in the range of 1 to 100 (inclusive). The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// CountIPv6: The desired number of IPv6 outbound IPs created/managed by Azure for the cluster load balancer. Allowed
    /// values must be in the range of 1 to 100 (inclusive). The default value is 0 for single-stack and 1 for dual-stack.
    /// </summary>
    [JsonPropertyName("countIPv6")]
    public int? CountIPv6 { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PublicIPPrefixes: A list of public IP prefix resources.</summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PublicIPs: A list of public IP resources.</summary>
    [JsonPropertyName("publicIPs")]
    public IList<V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfile
{
    /// <summary>
    /// AllocatedOutboundPorts: The desired number of allocated SNAT ports per VM. Allowed values are in the range of 0 to 64000
    /// (inclusive). The default value is 0 which results in Azure dynamically allocating ports.
    /// </summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>BackendPoolType: The type of the managed inbound Load Balancer BackendPool.</summary>
    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    /// <summary>EffectiveOutboundIPs: The effective outbound IP resources of the cluster load balancer.</summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary>EnableMultipleStandardLoadBalancers: Enable multiple standard load balancers per AKS cluster or not.</summary>
    [JsonPropertyName("enableMultipleStandardLoadBalancers")]
    public bool? EnableMultipleStandardLoadBalancers { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 30 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
    [JsonPropertyName("managedOutboundIPs")]
    public V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPs")]
    public V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>
    /// Count: The desired number of outbound IPs created/managed by Azure. Allowed values must be in the range of 1 to 16
    /// (inclusive). The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfileNatGatewayProfile
{
    /// <summary>EffectiveOutboundIPs: The effective outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901ManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 4 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V1api20240901ManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>NetworkProfile: The network configuration profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNetworkProfile
{
    /// <summary>
    /// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
    /// more information see  aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V1api20240901ManagedClusterStatusNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    /// <summary>
    /// DnsServiceIP: An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address
    /// range specified in serviceCidr.
    /// </summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary>
    /// IpFamilies: IP families are used to determine single-stack or dual-stack clusters. For single-stack, the expected value
    /// is IPv4. For dual-stack, the expected values are IPv4 and IPv6.
    /// </summary>
    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20240901ManagedClusterStatusNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>
    /// LoadBalancerSku: The default is &apos;standard&apos;. See [Azure Load Balancer
    /// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
    /// balancer SKUs.
    /// </summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V1api20240901ManagedClusterStatusNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    /// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
    [JsonPropertyName("networkDataplane")]
    public string? NetworkDataplane { get; set; }

    /// <summary>NetworkMode: This cannot be specified if networkPlugin is anything other than &apos;azure&apos;.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>NetworkPlugin: Network plugin used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    /// <summary>NetworkPluginMode: The mode the network plugin should use.</summary>
    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    /// <summary>NetworkPolicy: Network policy used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    /// <summary>
    /// OutboundType: This can only be set at cluster creation time and cannot be changed later. For more information see
    /// [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
    /// </summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>PodCidr: A CIDR notation IP range from which to assign pod IPs when kubenet is used.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>
    /// PodCidrs: One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is
    /// expected for dual-stack networking.
    /// </summary>
    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    /// <summary>
    /// ServiceCidr: A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP
    /// ranges.
    /// </summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>
    /// ServiceCidrs: One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is
    /// expected for dual-stack networking. They must not overlap with any Subnet IP ranges.
    /// </summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }
}

/// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusNodeResourceGroupProfile
{
    /// <summary>
    /// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
    /// &apos;Unrestricted&apos;
    /// </summary>
    [JsonPropertyName("restrictionLevel")]
    public string? RestrictionLevel { get; set; }
}

/// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusOidcIssuerProfile
{
    /// <summary>Enabled: Whether the OIDC issuer is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IssuerURL: The OIDC issuer url of the Managed Cluster.</summary>
    [JsonPropertyName("issuerURL")]
    public string? IssuerURL { get; set; }
}

/// <summary>Identity: The user assigned identity details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ResourceId: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails
{
    /// <summary>Code: An identifier for the error. Codes are invariant and are intended to be consumed programmatically.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: A message describing the error, intended to be suitable for display in a user interface.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error. For example, the name of the property in error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: Details about the error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError
{
    /// <summary>Code: An identifier for the error. Codes are invariant and are intended to be consumed programmatically.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: A list of additional details about the error.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails>? Details { get; set; }

    /// <summary>Message: A message describing the error, intended to be suitable for display in a user interface.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error. For example, the name of the property in error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: Pod identity assignment error (if any).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError
{
    /// <summary>Error: Details about the error.</summary>
    [JsonPropertyName("error")]
    public V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError? Error { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo
{
    /// <summary>Error: Pod identity assignment error (if any).</summary>
    [JsonPropertyName("error")]
    public V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError? Error { get; set; }
}

/// <summary>Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentities
{
    /// <summary>BindingSelector: The binding selector to use for the AzureIdentityBinding resource.</summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Identity: The user assigned identity details.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity? Identity { get; set; }

    /// <summary>Name: The name of the pod identity.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: The namespace of the pod identity.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("provisioningInfo")]
    public V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo? ProvisioningInfo { get; set; }

    /// <summary>ProvisioningState: The current provisioning state of the pod identity.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>
/// See [disable AAD Pod Identity for a specific
/// Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions
{
    /// <summary>Name: The name of the pod identity exception.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: The namespace of the pod identity exception.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>PodLabels: The pod labels to match.</summary>
    [JsonPropertyName("podLabels")]
    public IDictionary<string, string>? PodLabels { get; set; }
}

/// <summary>
/// PodIdentityProfile: See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more
/// details on AAD pod identity integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPodIdentityProfile
{
    /// <summary>
    /// AllowNetworkPluginKubenet: Running in Kubenet is disabled by default due to the security related nature of AAD Pod
    /// Identity and the risks of IP spoofing. See [using Kubenet network plugin with AAD Pod
    /// Identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity#using-kubenet-network-plugin-with-azure-active-directory-pod-managed-identities)
    /// for more information.
    /// </summary>
    [JsonPropertyName("allowNetworkPluginKubenet")]
    public bool? AllowNetworkPluginKubenet { get; set; }

    /// <summary>Enabled: Whether the pod identity addon is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>UserAssignedIdentities: The pod identities to use in the cluster.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary>UserAssignedIdentityExceptions: The pod identity exceptions to allow.</summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V1api20240901ManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>PowerState: The Power State of the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>A private link resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusPrivateLinkResources
{
    /// <summary>GroupId: The group ID of the resource.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Id: The ID of the private link resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the private link resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkServiceID: The private link service ID of the resource, this field is exposed only to NRP internally.</summary>
    [JsonPropertyName("privateLinkServiceID")]
    public string? PrivateLinkServiceID { get; set; }

    /// <summary>RequiredMembers: The RequiredMembers of the resource</summary>
    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// AzureKeyVaultKms: Azure Key Vault [key management
/// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSecurityProfileAzureKeyVaultKms
{
    /// <summary>Enabled: Whether to enable Azure Key Vault key management service. The default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyId: Identifier of Azure Key Vault key. See [key identifier
    /// format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name)
    /// for more details. When Azure Key Vault key management service is enabled, this field is required and must be a valid key
    /// identifier. When Azure Key Vault key management service is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// KeyVaultNetworkAccess: Network access of key vault. The possible values are `Public` and `Private`. `Public` means the
    /// key vault allows public access from all networks. `Private` means the key vault disables public access and enables
    /// private link. The default value is `Public`.
    /// </summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }

    /// <summary>
    /// KeyVaultResourceId: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and must
    /// be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
    /// </summary>
    [JsonPropertyName("keyVaultResourceId")]
    public string? KeyVaultResourceId { get; set; }
}

/// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>Enabled: Whether to enable Defender threat detection</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSecurityProfileDefender
{
    /// <summary>
    /// LogAnalyticsWorkspaceResourceId: Resource ID of the Log Analytics workspace to be associated with Microsoft Defender.
    /// When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When Microsoft
    /// Defender is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceId")]
    public string? LogAnalyticsWorkspaceResourceId { get; set; }

    /// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
    [JsonPropertyName("securityMonitoring")]
    public V1api20240901ManagedClusterStatusSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSecurityProfileImageCleaner
{
    /// <summary>Enabled: Whether to enable Image Cleaner on AKS cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IntervalHours: Image Cleaner scanning interval in hours.</summary>
    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>
/// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
/// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSecurityProfileWorkloadIdentity
{
    /// <summary>Enabled: Whether to enable workload identity.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSecurityProfile
{
    /// <summary>
    /// AzureKeyVaultKms: Azure Key Vault [key management
    /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V1api20240901ManagedClusterStatusSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V1api20240901ManagedClusterStatusSecurityProfileDefender? Defender { get; set; }

    /// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V1api20240901ManagedClusterStatusSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
    /// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V1api20240901ManagedClusterStatusSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin
{
    /// <summary>CertChainObjectName: Certificate chain object name in Azure Key Vault.</summary>
    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    /// <summary>CertObjectName: Intermediate certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    /// <summary>KeyObjectName: Intermediate certificate private key object name in Azure Key Vault.</summary>
    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary>KeyVaultId: The resource ID of the Key Vault.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>RootCertObjectName: Root certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>
/// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
/// certificates as described  here https://aka.ms/asm-plugin-ca
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V1api20240901ManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>Enabled: Whether to enable the egress gateway.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Istio ingress gateway configuration. For now, we support up to one external ingress gateway named
/// `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>Enabled: Whether to enable the ingress gateway.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Mode: Mode of an ingress gateway.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Components: Istio components configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServiceMeshProfileIstioComponents
{
    /// <summary>EgressGateways: Istio egress gateways.</summary>
    [JsonPropertyName("egressGateways")]
    public IList<V1api20240901ManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary>IngressGateways: Istio ingress gateways.</summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V1api20240901ManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }
}

/// <summary>Istio: Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServiceMeshProfileIstio
{
    /// <summary>
    /// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
    /// certificates as described  here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20240901ManagedClusterStatusServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Components: Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V1api20240901ManagedClusterStatusServiceMeshProfileIstioComponents? Components { get; set; }

    /// <summary>
    /// Revisions: The list of revisions of the Istio control plane. When an upgrade is not in progress, this holds one value.
    /// When canary upgrade is in progress, this can only hold two consecutive values. For more information, see:
    /// https://learn.microsoft.com/en-us/azure/aks/istio-upgrade
    /// </summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServiceMeshProfile
{
    /// <summary>Istio: Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V1api20240901ManagedClusterStatusServiceMeshProfileIstio? Istio { get; set; }

    /// <summary>Mode: Mode of the service mesh.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
/// APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusServicePrincipalProfile
{
    /// <summary>ClientId: The ID for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>Sku: The managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSku
{
    /// <summary>Name: The name of a managed cluster SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Tier: If not specified, the default is &apos;Free&apos;. See [AKS Pricing
    /// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers) for more details.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusStorageProfileBlobCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureBlob CSI Driver. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusStorageProfileDiskCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureDisk CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusStorageProfileFileCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureFile CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusStorageProfileSnapshotController
{
    /// <summary>Enabled: Whether to enable Snapshot Controller. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusStorageProfile
{
    /// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V1api20240901ManagedClusterStatusStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V1api20240901ManagedClusterStatusStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V1api20240901ManagedClusterStatusStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V1api20240901ManagedClusterStatusStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>OverrideSettings: Settings for overrides.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusUpgradeSettingsOverrideSettings
{
    /// <summary>
    /// ForceUpgrade: Whether to force upgrade the cluster. Note that this option instructs upgrade operation to bypass upgrade
    /// protections such as checking for deprecated API usage. Enable this option only with caution.
    /// </summary>
    [JsonPropertyName("forceUpgrade")]
    public bool? ForceUpgrade { get; set; }

    /// <summary>
    /// Until: Until when the overrides are effective. Note that this only matches the start time of an upgrade, and the
    /// effectiveness won&apos;t change once an upgrade starts even if the `until` expires as upgrade proceeds. This field is not set
    /// by default. It must be set for the overrides to take effect.
    /// </summary>
    [JsonPropertyName("until")]
    public string? Until { get; set; }
}

/// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusUpgradeSettings
{
    /// <summary>OverrideSettings: Settings for overrides.</summary>
    [JsonPropertyName("overrideSettings")]
    public V1api20240901ManagedClusterStatusUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusWindowsProfileGmsaProfile
{
    /// <summary>
    /// DnsServer: Specifies the DNS server for Windows gMSA.
    /// Set it to empty if you have configured the DNS server in the vnet which is used to create the managed cluster.
    /// </summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary>Enabled: Specifies whether to enable Windows gMSA in the managed cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// RootDomainName: Specifies the root domain name for Windows gMSA.
    /// Set it to empty if you have configured the DNS server in the vnet which is used to create the managed cluster.
    /// </summary>
    [JsonPropertyName("rootDomainName")]
    public string? RootDomainName { get; set; }
}

/// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusWindowsProfile
{
    /// <summary>
    /// AdminUsername: Specifies the name of the administrator account.
    /// Restriction: Cannot end in &quot;.&quot;
    /// Disallowed values: &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;,
    /// &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;,
    /// &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;.
    /// Minimum-length: 1 character
    /// Max-length: 20 characters
    /// </summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>
    /// EnableCSIProxy: For more details on CSI proxy, see the [CSI proxy GitHub
    /// repo](https://github.com/kubernetes-csi/csi-proxy).
    /// </summary>
    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
    [JsonPropertyName("gmsaProfile")]
    public V1api20240901ManagedClusterStatusWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    /// <summary>
    /// LicenseType: The license type to use for Windows VMs. See [Azure Hybrid User
    /// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }
}

/// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusWorkloadAutoScalerProfileKeda
{
    /// <summary>Enabled: Whether to enable KEDA.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>Enabled: Whether to enable VPA. Default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatusWorkloadAutoScalerProfile
{
    /// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V1api20240901ManagedClusterStatusWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V1api20240901ManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

/// <summary>Managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClusterStatus
{
    /// <summary>AadProfile: The Azure Active Directory configuration.</summary>
    [JsonPropertyName("aadProfile")]
    public V1api20240901ManagedClusterStatusAadProfile? AadProfile { get; set; }

    /// <summary>AddonProfiles: The profile of managed cluster add-on.</summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V1api20240901ManagedClusterStatusAddonProfiles>? AddonProfiles { get; set; }

    /// <summary>AgentPoolProfiles: The agent pool properties.</summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V1api20240901ManagedClusterStatusAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V1api20240901ManagedClusterStatusApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V1api20240901ManagedClusterStatusAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V1api20240901ManagedClusterStatusAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V1api20240901ManagedClusterStatusAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary>
    /// AzurePortalFQDN: The Azure Portal requires certain Cross-Origin Resource Sharing (CORS) headers to be sent in some
    /// responses, which Kubernetes APIServer doesn&apos;t handle by default. This special FQDN supports CORS, allowing the Azure
    /// Portal to function properly.
    /// </summary>
    [JsonPropertyName("azurePortalFQDN")]
    public string? AzurePortalFQDN { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240901ManagedClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CurrentKubernetesVersion: If kubernetesVersion was a fully specified version &lt;major.minor.patch&gt;, this field will be
    /// exactly equal to it. If kubernetesVersion was &lt;major.minor&gt;, this field will contain the full &lt;major.minor.patch&gt;
    /// version being used.
    /// </summary>
    [JsonPropertyName("currentKubernetesVersion")]
    public string? CurrentKubernetesVersion { get; set; }

    /// <summary>
    /// DisableLocalAccounts: If set to true, getting static credentials will be disabled for this cluster. This must only be
    /// used on Managed Clusters that are AAD enabled. For more details see [disable local
    /// accounts](https://docs.microsoft.com/azure/aks/managed-aad#disable-local-accounts-preview).
    /// </summary>
    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    /// <summary>
    /// DiskEncryptionSetID: This is of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
    /// </summary>
    [JsonPropertyName("diskEncryptionSetID")]
    public string? DiskEncryptionSetID { get; set; }

    /// <summary>DnsPrefix: This cannot be updated once the Managed Cluster has been created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>
    /// ETag: Unique read-only string used to implement optimistic concurrency. The eTag value will change when the resource is
    /// updated. Specify an if-match or if-none-match header with the eTag value for a subsequent request to enable optimistic
    /// concurrency per the normal etag convention.
    /// </summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>
    /// EnablePodSecurityPolicy: (DEPRECATED) Whether to enable Kubernetes pod security policy (preview). PodSecurityPolicy was
    /// deprecated in Kubernetes v1.21, and removed from Kubernetes in v1.25. Learn more at https://aka.ms/k8s/psp and
    /// https://aka.ms/aks/psp.
    /// </summary>
    [JsonPropertyName("enablePodSecurityPolicy")]
    public bool? EnablePodSecurityPolicy { get; set; }

    /// <summary>EnableRBAC: Whether to enable Kubernetes Role-Based Access Control.</summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240901ManagedClusterStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Fqdn: The FQDN of the master pool.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>FqdnSubdomain: This cannot be updated once the Managed Cluster has been created.</summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V1api20240901ManagedClusterStatusHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the managed cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901ManagedClusterStatusIdentity? Identity { get; set; }

    /// <summary>
    /// IdentityProfile: The user identity associated with the managed cluster. This identity will be used by the kubelet. Only
    /// one user assigned identity is allowed. The only accepted key is &quot;kubeletidentity&quot;, with value of &quot;resourceId&quot;:
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&quot;.
    /// </summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V1api20240901ManagedClusterStatusIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V1api20240901ManagedClusterStatusIngressProfile? IngressProfile { get; set; }

    /// <summary>
    /// KubernetesVersion: Both patch version &lt;major.minor.patch&gt; (e.g. 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported.
    /// When &lt;major.minor&gt; is specified, the latest supported GA patch version is chosen automatically. Updating the cluster
    /// with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x -&gt; 1.14) will not trigger an upgrade, even if a newer
    /// patch version is available. When you upgrade a supported AKS cluster, Kubernetes minor versions cannot be skipped. All
    /// upgrades must be performed sequentially by major version number. For example, upgrades between 1.14.x -&gt; 1.15.x or
    /// 1.15.x -&gt; 1.16.x are allowed, however 1.14.x -&gt; 1.16.x is not allowed. See [upgrading an AKS
    /// cluster](https://docs.microsoft.com/azure/aks/upgrade-cluster) for more details.
    /// </summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
    [JsonPropertyName("linuxProfile")]
    public V1api20240901ManagedClusterStatusLinuxProfile? LinuxProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaxAgentPools: The max number of agent pools for the managed cluster.</summary>
    [JsonPropertyName("maxAgentPools")]
    public int? MaxAgentPools { get; set; }

    /// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
    [JsonPropertyName("metricsProfile")]
    public V1api20240901ManagedClusterStatusMetricsProfile? MetricsProfile { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: The network configuration profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901ManagedClusterStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeResourceGroup: The name of the resource group containing agent pool nodes.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V1api20240901ManagedClusterStatusNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20240901ManagedClusterStatusOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// PodIdentityProfile: See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more
    /// details on AAD pod identity integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V1api20240901ManagedClusterStatusPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>PowerState: The Power State of the cluster.</summary>
    [JsonPropertyName("powerState")]
    public V1api20240901ManagedClusterStatusPowerState? PowerState { get; set; }

    /// <summary>PrivateFQDN: The FQDN of private cluster.</summary>
    [JsonPropertyName("privateFQDN")]
    public string? PrivateFQDN { get; set; }

    /// <summary>PrivateLinkResources: Private link resources associated with the cluster.</summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V1api20240901ManagedClusterStatusPrivateLinkResources>? PrivateLinkResources { get; set; }

    /// <summary>ProvisioningState: The current provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Allow or deny public network access for AKS</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// ResourceUID: The resourceUID uniquely identifies ManagedClusters that reuse ARM ResourceIds (i.e: create, delete, create
    /// sequence)
    /// </summary>
    [JsonPropertyName("resourceUID")]
    public string? ResourceUID { get; set; }

    /// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901ManagedClusterStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V1api20240901ManagedClusterStatusServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
    /// APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20240901ManagedClusterStatusServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Sku: The managed cluster SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20240901ManagedClusterStatusSku? Sku { get; set; }

    /// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20240901ManagedClusterStatusStorageProfile? StorageProfile { get; set; }

    /// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240901ManagedClusterStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901ManagedClusterStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901ManagedClusterStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V1api20240901ManagedClusterStatusWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2024-09-01/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901ManagedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240901ManagedClusterSpec?>, IStatus<V1api20240901ManagedClusterStatus?>
{
    public const string KubeApiVersion = "v1api20240901";
    public const string KubeKind = "ManagedCluster";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20240901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240901ManagedClusterSpec? Spec { get; set; }

    /// <summary>Managed cluster.</summary>
    [JsonPropertyName("status")]
    public V1api20240901ManagedClusterStatus? Status { get; set; }
}