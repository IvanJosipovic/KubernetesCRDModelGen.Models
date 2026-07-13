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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901ManagedClustersAgentPoolList : IKubernetesObject<V1ListMeta>, IItems<V1api20240901ManagedClustersAgentPool>
{
    public const string KubeApiVersion = "v1api20240901";
    public const string KubeKind = "ManagedClustersAgentPoolList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20240901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClustersAgentPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240901ManagedClustersAgentPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240901ManagedClustersAgentPool> Items { get; set; }
}

/// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecCapacityReservationGroupReference
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
public partial class V1api20240901ManagedClustersAgentPoolSpecCreationDataSourceResourceReference
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
public partial class V1api20240901ManagedClustersAgentPoolSpecCreationData
{
    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20240901ManagedClustersAgentPoolSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecGpuInstanceProfileEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecGpuInstanceProfileEnum
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
public partial class V1api20240901ManagedClustersAgentPoolSpecHostGroupReference
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
public partial class V1api20240901ManagedClustersAgentPoolSpecKubeletConfig
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecKubeletDiskTypeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecKubeletDiskTypeEnum
{
    [EnumMember(Value = "OS"), JsonStringEnumMemberName("OS")]
    OS,
    [EnumMember(Value = "Temporary"), JsonStringEnumMemberName("Temporary")]
    Temporary
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecLinuxOSConfigSysctls
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
public partial class V1api20240901ManagedClustersAgentPoolSpecLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901ManagedClustersAgentPoolSpecLinuxOSConfigSysctls? Sysctls { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecModeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecModeEnum
{
    [EnumMember(Value = "System"), JsonStringEnumMemberName("System")]
    System,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>Protocol: The network protocol of the port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecNetworkProfileAllowedHostPortsProtocolEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecNetworkProfileAllowedHostPortsProtocolEnum
{
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts
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
    public V1api20240901ManagedClustersAgentPoolSpecNetworkProfileAllowedHostPortsProtocolEnum? Protocol { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences
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
public partial class V1api20240901ManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags
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
public partial class V1api20240901ManagedClustersAgentPoolSpecNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901ManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>
    /// ApplicationSecurityGroupsReferences: The IDs of the application security groups which agent pool will associate when
    /// created.
    /// </summary>
    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V1api20240901ManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901ManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// NodePublicIPPrefixReference: This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecNodePublicIPPrefixReference
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecOperatorSpecSecretExpressions
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
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240901ManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240901ManagedClustersAgentPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// OsDiskType: The default is &apos;Ephemeral&apos; if the VM supports it and has a cache disk larger than the requested
/// OSDiskSizeGB. Otherwise,  defaults to &apos;Managed&apos;. May not be changed after creation. For more information see [Ephemeral
/// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecOsDiskTypeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecOsDiskTypeEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecOsSKUEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecOsSKUEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecOsTypeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a containerservice.azure.com/ManagedCluster resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details).
/// This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecPodSubnetReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecPowerStateCodeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecPowerStateCodeEnum
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
public partial class V1api20240901ManagedClustersAgentPoolSpecPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public V1api20240901ManagedClustersAgentPoolSpecPowerStateCodeEnum? Code { get; set; }
}

/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecProximityPlacementGroupReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecScaleDownModeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecScaleDownModeEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecScaleSetEvictionPolicyEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecScaleSetEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecScaleSetPriorityEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecScaleSetPriorityEnum
{
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecSecurityProfile
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecTypeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecTypeEnum
{
    [EnumMember(Value = "AvailabilitySet"), JsonStringEnumMemberName("AvailabilitySet")]
    AvailabilitySet,
    [EnumMember(Value = "VirtualMachineScaleSets"), JsonStringEnumMemberName("VirtualMachineScaleSets")]
    VirtualMachineScaleSets
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpecUpgradeSettings
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
public partial class V1api20240901ManagedClustersAgentPoolSpecVnetSubnetReference
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
public partial class V1api20240901ManagedClustersAgentPoolSpecWindowsProfile
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240901ManagedClustersAgentPoolSpecWorkloadRuntimeEnum>))]
public enum V1api20240901ManagedClustersAgentPoolSpecWorkloadRuntimeEnum
{
    [EnumMember(Value = "OCIContainer"), JsonStringEnumMemberName("OCIContainer")]
    OCIContainer,
    [EnumMember(Value = "WasmWasi"), JsonStringEnumMemberName("WasmWasi")]
    WasmWasi
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolSpec
{
    /// <summary>
    /// AvailabilityZones: The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType
    /// property is &apos;VirtualMachineScaleSets&apos;.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
    [JsonPropertyName("capacityReservationGroupReference")]
    public V1api20240901ManagedClustersAgentPoolSpecCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolSpecCreationData? CreationData { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolSpecGpuInstanceProfileEnum? GpuInstanceProfile { get; set; }

    /// <summary>
    /// HostGroupReference: This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupReference")]
    public V1api20240901ManagedClustersAgentPoolSpecHostGroupReference? HostGroupReference { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901ManagedClustersAgentPoolSpecKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public V1api20240901ManagedClustersAgentPoolSpecKubeletDiskTypeEnum? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901ManagedClustersAgentPoolSpecLinuxOSConfig? LinuxOSConfig { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolSpecModeEnum? Mode { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901ManagedClustersAgentPoolSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeLabels: The node labels to be persisted across all nodes in agent pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixReference: This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V1api20240901ManagedClustersAgentPoolSpecNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

    /// <summary>NodeTaints: The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule.</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240901ManagedClustersAgentPoolSpecOperatorSpec? OperatorSpec { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolSpecOsDiskTypeEnum? OsDiskType { get; set; }

    /// <summary>
    /// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
    /// when  Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    [JsonPropertyName("osSKU")]
    public V1api20240901ManagedClustersAgentPoolSpecOsSKUEnum? OsSKU { get; set; }

    /// <summary>OsType: The operating system type. The default is Linux.</summary>
    [JsonPropertyName("osType")]
    public V1api20240901ManagedClustersAgentPoolSpecOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/ManagedCluster resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240901ManagedClustersAgentPoolSpecOwner Owner { get; set; }

    /// <summary>
    /// PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details).
    /// This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetReference")]
    public V1api20240901ManagedClustersAgentPoolSpecPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>
    /// PowerState: When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this
    /// field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only
    /// be stopped if it is Running and provisioning state is Succeeded
    /// </summary>
    [JsonPropertyName("powerState")]
    public V1api20240901ManagedClustersAgentPoolSpecPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V1api20240901ManagedClustersAgentPoolSpecProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

    /// <summary>ScaleDownMode: This also effects the cluster autoscaler behavior. If not specified, it defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public V1api20240901ManagedClustersAgentPoolSpecScaleDownModeEnum? ScaleDownMode { get; set; }

    /// <summary>
    /// ScaleSetEvictionPolicy: This cannot be specified unless the scaleSetPriority is &apos;Spot&apos;. If not specified, the default is
    /// &apos;Delete&apos;.
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public V1api20240901ManagedClustersAgentPoolSpecScaleSetEvictionPolicyEnum? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public V1api20240901ManagedClustersAgentPoolSpecScaleSetPriorityEnum? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901ManagedClustersAgentPoolSpecSecurityProfile? SecurityProfile { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolSpecTypeEnum? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901ManagedClustersAgentPoolSpecUpgradeSettings? UpgradeSettings { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolSpecVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901ManagedClustersAgentPoolSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public V1api20240901ManagedClustersAgentPoolSpecWorkloadRuntimeEnum? WorkloadRuntime { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolStatusConditions
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

/// <summary>
/// CreationData: CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using
/// a snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolStatusCreationData
{
    /// <summary>SourceResourceId: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolStatusKubeletConfig
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
public partial class V1api20240901ManagedClustersAgentPoolStatusLinuxOSConfigSysctls
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
public partial class V1api20240901ManagedClustersAgentPoolStatusLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901ManagedClustersAgentPoolStatusLinuxOSConfigSysctls? Sysctls { get; set; }

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
public partial class V1api20240901ManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts
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
public partial class V1api20240901ManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags
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
public partial class V1api20240901ManagedClustersAgentPoolStatusNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901ManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>ApplicationSecurityGroups: The IDs of the application security groups which agent pool will associate when created.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901ManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// PowerState: When an Agent Pool is first created it is initially Running. The Agent Pool can be stopped by setting this
/// field to Stopped. A stopped Agent Pool stops all of its VMs and does not accrue billing charges. An Agent Pool can only
/// be stopped if it is Running and provisioning state is Succeeded
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolStatusPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolStatusSecurityProfile
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
public partial class V1api20240901ManagedClustersAgentPoolStatusUpgradeSettings
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
public partial class V1api20240901ManagedClustersAgentPoolStatusWindowsProfile
{
    /// <summary>
    /// DisableOutboundNat: The default value is false. Outbound NAT can only be disabled if the cluster outboundType is NAT
    /// Gateway and the Windows agent pool does not have node public IP enabled.
    /// </summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901ManagedClustersAgentPoolStatus
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

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240901ManagedClustersAgentPoolStatusConditions>? Conditions { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolStatusCreationData? CreationData { get; set; }

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

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901ManagedClustersAgentPoolStatusKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901ManagedClustersAgentPoolStatusLinuxOSConfig? LinuxOSConfig { get; set; }

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

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901ManagedClustersAgentPoolStatusNetworkProfile? NetworkProfile { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolStatusPowerState? PowerState { get; set; }

    /// <summary>PropertiesType: The type of Agent Pool.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolStatusSecurityProfile? SecurityProfile { get; set; }

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

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901ManagedClustersAgentPoolStatusUpgradeSettings? UpgradeSettings { get; set; }

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
    public V1api20240901ManagedClustersAgentPoolStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2024-09-01/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901ManagedClustersAgentPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240901ManagedClustersAgentPoolSpec?>, IStatus<V1api20240901ManagedClustersAgentPoolStatus?>
{
    public const string KubeApiVersion = "v1api20240901";
    public const string KubeKind = "ManagedClustersAgentPool";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20240901";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClustersAgentPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240901ManagedClustersAgentPoolSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240901ManagedClustersAgentPoolStatus? Status { get; set; }
}