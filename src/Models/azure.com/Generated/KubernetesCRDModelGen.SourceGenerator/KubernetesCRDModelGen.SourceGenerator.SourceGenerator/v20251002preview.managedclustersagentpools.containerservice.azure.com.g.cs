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
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewManagedClustersAgentPoolList : IKubernetesObject<V1ListMeta>, IItems<V20251002previewManagedClustersAgentPool>
{
    public const string KubeApiVersion = "v20251002preview";
    public const string KubeKind = "ManagedClustersAgentPoolList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClustersAgentPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20251002previewManagedClustersAgentPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20251002previewManagedClustersAgentPool> Items { get; set; }
}

/// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecArtifactStreamingProfile
{
    /// <summary>
    /// Enabled: Artifact streaming speeds up the cold-start of containers on a node through on-demand image loading. To use
    /// this feature, container images must also enable artifact streaming on ACR. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// CapacityReservationGroupReference: The fully qualified resource ID of the Capacity Reservation Group to provide virtual
/// machines from a reserved group of Virtual Machines. This is of the form:
/// &apos;/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Compute/capacityreservationgroups/{capacityReservationGroupName}&apos;
/// Customers use it to create an agentpool with a specified CRG. For more information see [Capacity
/// Reservation](https://learn.microsoft.com/en-us/azure/virtual-machines/capacity-reservation-overview)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecCapacityReservationGroupReference
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
public partial class V20251002previewManagedClustersAgentPoolSpecCreationDataSourceResourceReference
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
public partial class V20251002previewManagedClustersAgentPoolSpecCreationData
{
    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20251002previewManagedClustersAgentPoolSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>
/// GatewayProfile: Profile specific to a managed agent pool in Gateway mode. This field cannot be set if agent pool mode is
/// not Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecGatewayProfile
{
    /// <summary>
    /// PublicIPPrefixSize: The Gateway agent pool associates one public IPPrefix for each static egress gateway to provide
    /// public egress. The size of Public IPPrefix should be selected by the user. Each node in the agent pool is assigned with
    /// one IP from the IPPrefix. The IPPrefix size thus serves as a cap on the size of the Gateway agent pool. Due to Azure
    /// public IPPrefix size limitation, the valid value range is [28, 31] (/31 = 2 nodes/IPs, /30 = 4 nodes/IPs, /29 = 8
    /// nodes/IPs, /28 = 16 nodes/IPs). The default value is 31.
    /// </summary>
    [JsonPropertyName("publicIPPrefixSize")]
    public int? PublicIPPrefixSize { get; set; }
}

/// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecGpuInstanceProfileEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecGpuInstanceProfileEnum
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

/// <summary>Driver: Whether to install GPU drivers. When it&apos;s not specified, default is Install.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecGpuProfileDriverEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecGpuProfileDriverEnum
{
    [EnumMember(Value = "Install"), JsonStringEnumMemberName("Install")]
    Install,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// DriverType: Specify the type of GPU driver to install when creating Windows agent pools. If not provided, AKS selects
/// the driver based on system compatibility. This cannot be changed once the AgentPool has been created. This cannot be set
/// on Linux AgentPools. For Linux AgentPools, the driver is selected based on system compatibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecGpuProfileDriverTypeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecGpuProfileDriverTypeEnum
{
    [EnumMember(Value = "CUDA"), JsonStringEnumMemberName("CUDA")]
    CUDA,
    [EnumMember(Value = "GRID"), JsonStringEnumMemberName("GRID")]
    GRID
}

/// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecGpuProfile
{
    /// <summary>Driver: Whether to install GPU drivers. When it&apos;s not specified, default is Install.</summary>
    [JsonPropertyName("driver")]
    public V20251002previewManagedClustersAgentPoolSpecGpuProfileDriverEnum? Driver { get; set; }

    /// <summary>
    /// DriverType: Specify the type of GPU driver to install when creating Windows agent pools. If not provided, AKS selects
    /// the driver based on system compatibility. This cannot be changed once the AgentPool has been created. This cannot be set
    /// on Linux AgentPools. For Linux AgentPools, the driver is selected based on system compatibility.
    /// </summary>
    [JsonPropertyName("driverType")]
    public V20251002previewManagedClustersAgentPoolSpecGpuProfileDriverTypeEnum? DriverType { get; set; }
}

/// <summary>
/// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
/// only in creation scenario and not allowed to changed once set. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
/// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecHostGroupReference
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
/// SeccompDefault: Specifies the default seccomp profile applied to all workloads. If not specified, &apos;Unconfined&apos; will be
/// used by default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecKubeletConfigSeccompDefaultEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecKubeletConfigSeccompDefaultEnum
{
    [EnumMember(Value = "RuntimeDefault"), JsonStringEnumMemberName("RuntimeDefault")]
    RuntimeDefault,
    [EnumMember(Value = "Unconfined"), JsonStringEnumMemberName("Unconfined")]
    Unconfined
}

/// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecKubeletConfig
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

    /// <summary>CpuCfsQuota: If CPU CFS quota enforcement is enabled for containers that specify CPU limits. The default is true.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>
    /// CpuCfsQuotaPeriod: The CPU CFS quota period value. The default is &apos;100ms.&apos; Valid values are a sequence of decimal
    /// numbers with an optional fraction and a unit suffix. For example: &apos;300ms&apos;, &apos;2h45m&apos;. Supported units are &apos;ns&apos;, &apos;us&apos;,
    /// &apos;ms&apos;, &apos;s&apos;, &apos;m&apos;, and &apos;h&apos;.
    /// </summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// CpuManagerPolicy: The CPU Manager policy to use. The default is &apos;none&apos;. See [Kubernetes CPU management
    /// policies](https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/#cpu-management-policies) for more
    /// information. Allowed values are &apos;none&apos; and &apos;static&apos;.
    /// </summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>FailSwapOn: If set to true it will make the Kubelet fail to start if swap is enabled on the node.</summary>
    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    /// <summary>
    /// ImageGcHighThreshold: The percent of disk usage after which image garbage collection is always run. To disable image
    /// garbage collection, set to 100. The default is 85%
    /// </summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    /// <summary>
    /// ImageGcLowThreshold: The percent of disk usage before which image garbage collection is never run. This cannot be set
    /// higher than imageGcHighThreshold. The default is 80%
    /// </summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    /// <summary>PodMaxPids: The maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    /// <summary>
    /// SeccompDefault: Specifies the default seccomp profile applied to all workloads. If not specified, &apos;Unconfined&apos; will be
    /// used by default.
    /// </summary>
    [JsonPropertyName("seccompDefault")]
    public V20251002previewManagedClustersAgentPoolSpecKubeletConfigSeccompDefaultEnum? SeccompDefault { get; set; }

    /// <summary>
    /// TopologyManagerPolicy: The Topology Manager policy to use. For more information see [Kubernetes Topology
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecKubeletDiskTypeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecKubeletDiskTypeEnum
{
    [EnumMember(Value = "OS"), JsonStringEnumMemberName("OS")]
    OS,
    [EnumMember(Value = "Temporary"), JsonStringEnumMemberName("Temporary")]
    Temporary
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecLinuxOSConfigSysctls
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
public partial class V20251002previewManagedClustersAgentPoolSpecLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V20251002previewManagedClustersAgentPoolSpecLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary>
    /// TransparentHugePageDefrag: Whether the kernel should make aggressive use of memory compaction to make more hugepages
    /// available. Valid values are &apos;always&apos;, &apos;defer&apos;, &apos;defer+madvise&apos;, &apos;madvise&apos; and &apos;never&apos;. The default is &apos;madvise&apos;. For
    /// more information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>
    /// TransparentHugePageEnabled: Whether transparent hugepages are enabled. Valid values are &apos;always&apos;, &apos;madvise&apos;, and
    /// &apos;never&apos;. The default is &apos;always&apos;. For more information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesForwardDestinationEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesForwardDestinationEnum
{
    [EnumMember(Value = "ClusterCoreDNS"), JsonStringEnumMemberName("ClusterCoreDNS")]
    ClusterCoreDNS,
    [EnumMember(Value = "VnetDNS"), JsonStringEnumMemberName("VnetDNS")]
    VnetDNS
}

/// <summary>
/// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
/// plugin](https://coredns.io/plugins/forward) for more information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesForwardPolicyEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesForwardPolicyEnum
{
    [EnumMember(Value = "Random"), JsonStringEnumMemberName("Random")]
    Random,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin,
    [EnumMember(Value = "Sequential"), JsonStringEnumMemberName("Sequential")]
    Sequential
}

/// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesProtocolEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesProtocolEnum
{
    [EnumMember(Value = "ForceTCP"), JsonStringEnumMemberName("ForceTCP")]
    ForceTCP,
    [EnumMember(Value = "PreferUDP"), JsonStringEnumMemberName("PreferUDP")]
    PreferUDP
}

/// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesQueryLoggingEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesQueryLoggingEnum
{
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesServeStaleEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesServeStaleEnum
{
    [EnumMember(Value = "Disable"), JsonStringEnumMemberName("Disable")]
    Disable,
    [EnumMember(Value = "Immediate"), JsonStringEnumMemberName("Immediate")]
    Immediate,
    [EnumMember(Value = "Verify"), JsonStringEnumMemberName("Verify")]
    Verify
}

/// <summary>Overrides for localDNS profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverrides
{
    /// <summary>
    /// CacheDurationInSeconds: Cache max TTL in seconds. See [cache plugin](https://coredns.io/plugins/cache) for more
    /// information.
    /// </summary>
    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    /// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
    [JsonPropertyName("forwardDestination")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesForwardDestinationEnum? ForwardDestination { get; set; }

    /// <summary>
    /// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
    /// plugin](https://coredns.io/plugins/forward) for more information.
    /// </summary>
    [JsonPropertyName("forwardPolicy")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesForwardPolicyEnum? ForwardPolicy { get; set; }

    /// <summary>
    /// MaxConcurrent: Maximum number of concurrent queries. See [forward plugin](https://coredns.io/plugins/forward) for more
    /// information.
    /// </summary>
    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    /// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
    [JsonPropertyName("protocol")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesProtocolEnum? Protocol { get; set; }

    /// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
    [JsonPropertyName("queryLogging")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesQueryLoggingEnum? QueryLogging { get; set; }

    /// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
    [JsonPropertyName("serveStale")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverridesServeStaleEnum? ServeStale { get; set; }

    /// <summary>
    /// ServeStaleDurationInSeconds: Serve stale duration in seconds. See [cache plugin](https://coredns.io/plugins/cache) for
    /// more information.
    /// </summary>
    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>Mode: Mode of enablement for localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileModeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Preferred"), JsonStringEnumMemberName("Preferred")]
    Preferred,
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required
}

/// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesForwardDestinationEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesForwardDestinationEnum
{
    [EnumMember(Value = "ClusterCoreDNS"), JsonStringEnumMemberName("ClusterCoreDNS")]
    ClusterCoreDNS,
    [EnumMember(Value = "VnetDNS"), JsonStringEnumMemberName("VnetDNS")]
    VnetDNS
}

/// <summary>
/// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
/// plugin](https://coredns.io/plugins/forward) for more information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesForwardPolicyEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesForwardPolicyEnum
{
    [EnumMember(Value = "Random"), JsonStringEnumMemberName("Random")]
    Random,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin,
    [EnumMember(Value = "Sequential"), JsonStringEnumMemberName("Sequential")]
    Sequential
}

/// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesProtocolEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesProtocolEnum
{
    [EnumMember(Value = "ForceTCP"), JsonStringEnumMemberName("ForceTCP")]
    ForceTCP,
    [EnumMember(Value = "PreferUDP"), JsonStringEnumMemberName("PreferUDP")]
    PreferUDP
}

/// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesQueryLoggingEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesQueryLoggingEnum
{
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesServeStaleEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesServeStaleEnum
{
    [EnumMember(Value = "Disable"), JsonStringEnumMemberName("Disable")]
    Disable,
    [EnumMember(Value = "Immediate"), JsonStringEnumMemberName("Immediate")]
    Immediate,
    [EnumMember(Value = "Verify"), JsonStringEnumMemberName("Verify")]
    Verify
}

/// <summary>Overrides for localDNS profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverrides
{
    /// <summary>
    /// CacheDurationInSeconds: Cache max TTL in seconds. See [cache plugin](https://coredns.io/plugins/cache) for more
    /// information.
    /// </summary>
    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    /// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
    [JsonPropertyName("forwardDestination")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesForwardDestinationEnum? ForwardDestination { get; set; }

    /// <summary>
    /// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
    /// plugin](https://coredns.io/plugins/forward) for more information.
    /// </summary>
    [JsonPropertyName("forwardPolicy")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesForwardPolicyEnum? ForwardPolicy { get; set; }

    /// <summary>
    /// MaxConcurrent: Maximum number of concurrent queries. See [forward plugin](https://coredns.io/plugins/forward) for more
    /// information.
    /// </summary>
    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    /// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
    [JsonPropertyName("protocol")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesProtocolEnum? Protocol { get; set; }

    /// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
    [JsonPropertyName("queryLogging")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesQueryLoggingEnum? QueryLogging { get; set; }

    /// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
    [JsonPropertyName("serveStale")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverridesServeStaleEnum? ServeStale { get; set; }

    /// <summary>
    /// ServeStaleDurationInSeconds: Serve stale duration in seconds. See [cache plugin](https://coredns.io/plugins/cache) for
    /// more information.
    /// </summary>
    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>
/// LocalDNSProfile: Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve
/// performance and reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecLocalDNSProfile
{
    /// <summary>
    /// KubeDNSOverrides: KubeDNS overrides apply to DNS traffic from pods with dnsPolicy:ClusterFirst (referred to as KubeDNS
    /// traffic).
    /// </summary>
    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

    /// <summary>Mode: Mode of enablement for localDNS.</summary>
    [JsonPropertyName("mode")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileModeEnum? Mode { get; set; }

    /// <summary>
    /// VnetDNSOverrides: VnetDNS overrides apply to DNS traffic from pods with dnsPolicy:default or kubelet (referred to as
    /// VnetDNS traffic).
    /// </summary>
    [JsonPropertyName("vnetDNSOverrides")]
    public IDictionary<string, V20251002previewManagedClustersAgentPoolSpecLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>
/// Mode: The mode of an agent pool. A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional
/// information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecModeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecModeEnum
{
    [EnumMember(Value = "Gateway"), JsonStringEnumMemberName("Gateway")]
    Gateway,
    [EnumMember(Value = "Machines"), JsonStringEnumMemberName("Machines")]
    Machines,
    [EnumMember(Value = "ManagedSystem"), JsonStringEnumMemberName("ManagedSystem")]
    ManagedSystem,
    [EnumMember(Value = "System"), JsonStringEnumMemberName("System")]
    System,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>Protocol: The network protocol of the port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecNetworkProfileAllowedHostPortsProtocolEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecNetworkProfileAllowedHostPortsProtocolEnum
{
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts
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
    public V20251002previewManagedClustersAgentPoolSpecNetworkProfileAllowedHostPortsProtocolEnum? Protocol { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences
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
public partial class V20251002previewManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags
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
public partial class V20251002previewManagedClustersAgentPoolSpecNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>
    /// ApplicationSecurityGroupsReferences: The IDs of the application security groups which agent pool will associate when
    /// created.
    /// </summary>
    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V20251002previewManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// NodeCustomizationReference: The resource ID of the node customization resource to use. This can be a version. Omitting
/// the version will use the latest version of the node customization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecNodeCustomizationProfileNodeCustomizationReference
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

/// <summary>NodeCustomizationProfile: Settings to determine the node customization used to provision nodes in a pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecNodeCustomizationProfile
{
    /// <summary>
    /// NodeCustomizationReference: The resource ID of the node customization resource to use. This can be a version. Omitting
    /// the version will use the latest version of the node customization.
    /// </summary>
    [JsonPropertyName("nodeCustomizationReference")]
    public V20251002previewManagedClustersAgentPoolSpecNodeCustomizationProfileNodeCustomizationReference? NodeCustomizationReference { get; set; }
}

/// <summary>
/// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecNodePublicIPPrefixReference
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
public partial class V20251002previewManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions
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
public partial class V20251002previewManagedClustersAgentPoolSpecOperatorSpecSecretExpressions
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
public partial class V20251002previewManagedClustersAgentPoolSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20251002previewManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20251002previewManagedClustersAgentPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// OsDiskType: The OS disk type to be used for machines in the agent pool. The default is &apos;Ephemeral&apos; if the VM supports it
/// and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to &apos;Managed&apos;. May not be changed after
/// creation. For more information see [Ephemeral
/// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecOsDiskTypeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecOsDiskTypeEnum
{
    [EnumMember(Value = "Ephemeral"), JsonStringEnumMemberName("Ephemeral")]
    Ephemeral,
    [EnumMember(Value = "Managed"), JsonStringEnumMemberName("Managed")]
    Managed
}

/// <summary>
/// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
/// when Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecOsSKUEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecOsSKUEnum
{
    [EnumMember(Value = "AzureLinux"), JsonStringEnumMemberName("AzureLinux")]
    AzureLinux,
    [EnumMember(Value = "AzureLinux3"), JsonStringEnumMemberName("AzureLinux3")]
    AzureLinux3,
    [EnumMember(Value = "CBLMariner"), JsonStringEnumMemberName("CBLMariner")]
    CBLMariner,
    [EnumMember(Value = "Flatcar"), JsonStringEnumMemberName("Flatcar")]
    Flatcar,
    [EnumMember(Value = "Mariner"), JsonStringEnumMemberName("Mariner")]
    Mariner,
    [EnumMember(Value = "Ubuntu"), JsonStringEnumMemberName("Ubuntu")]
    Ubuntu,
    [EnumMember(Value = "Ubuntu2204"), JsonStringEnumMemberName("Ubuntu2204")]
    Ubuntu2204,
    [EnumMember(Value = "Ubuntu2404"), JsonStringEnumMemberName("Ubuntu2404")]
    Ubuntu2404,
    [EnumMember(Value = "Windows2019"), JsonStringEnumMemberName("Windows2019")]
    Windows2019,
    [EnumMember(Value = "Windows2022"), JsonStringEnumMemberName("Windows2022")]
    Windows2022,
    [EnumMember(Value = "Windows2025"), JsonStringEnumMemberName("Windows2025")]
    Windows2025,
    [EnumMember(Value = "WindowsAnnual"), JsonStringEnumMemberName("WindowsAnnual")]
    WindowsAnnual
}

/// <summary>OsType: The operating system type. The default is Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecOsTypeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecOsTypeEnum
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
public partial class V20251002previewManagedClustersAgentPoolSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
/// podSubnetId. The default is &apos;DynamicIndividual&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecPodIPAllocationModeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecPodIPAllocationModeEnum
{
    [EnumMember(Value = "DynamicIndividual"), JsonStringEnumMemberName("DynamicIndividual")]
    DynamicIndividual,
    [EnumMember(Value = "StaticBlock"), JsonStringEnumMemberName("StaticBlock")]
    StaticBlock
}

/// <summary>
/// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
/// on the node subnet (see vnetSubnetID for more details). This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecPodSubnetReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecPowerStateCodeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecPowerStateCodeEnum
{
    [EnumMember(Value = "Running"), JsonStringEnumMemberName("Running")]
    Running,
    [EnumMember(Value = "Stopped"), JsonStringEnumMemberName("Stopped")]
    Stopped
}

/// <summary>
/// PowerState: Whether the Agent Pool is running or stopped. When an Agent Pool is first created it is initially Running.
/// The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not
/// accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public V20251002previewManagedClustersAgentPoolSpecPowerStateCodeEnum? Code { get; set; }
}

/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecProximityPlacementGroupReference
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
/// ScaleDownMode: The scale down mode to use when scaling the Agent Pool. This also effects the cluster autoscaler
/// behavior. If not specified, it defaults to Delete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecScaleDownModeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecScaleDownModeEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// ScaleSetEvictionPolicy: The Virtual Machine Scale Set eviction policy. The eviction policy specifies what to do with the
/// VM when it is evicted. The default is Delete. For more information about eviction see [spot
/// VMs](https://docs.microsoft.com/azure/virtual-machines/spot-vms)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecScaleSetEvictionPolicyEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecScaleSetEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecScaleSetPriorityEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecScaleSetPriorityEnum
{
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>SshAccess: SSH access method of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecSecurityProfileSshAccessEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecSecurityProfileSshAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "EntraId"), JsonStringEnumMemberName("EntraId")]
    EntraId,
    [EnumMember(Value = "LocalUser"), JsonStringEnumMemberName("LocalUser")]
    LocalUser
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecSecurityProfile
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

    /// <summary>SshAccess: SSH access method of an agent pool.</summary>
    [JsonPropertyName("sshAccess")]
    public V20251002previewManagedClustersAgentPoolSpecSecurityProfileSshAccessEnum? SshAccess { get; set; }
}

/// <summary>Type: The type of Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecTypeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecTypeEnum
{
    [EnumMember(Value = "AvailabilitySet"), JsonStringEnumMemberName("AvailabilitySet")]
    AvailabilitySet,
    [EnumMember(Value = "VirtualMachineScaleSets"), JsonStringEnumMemberName("VirtualMachineScaleSets")]
    VirtualMachineScaleSets,
    [EnumMember(Value = "VirtualMachines"), JsonStringEnumMemberName("VirtualMachines")]
    VirtualMachines
}

/// <summary>
/// UndrainableNodeBehavior: Defines the behavior for undrainable nodes during upgrade. The most common cause of undrainable
/// nodes is Pod Disruption Budgets (PDBs), but other issues, such as pod termination grace period is exceeding the
/// remaining per-node drain timeout or pod is still being in a running state, can also cause undrainable nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecUpgradeSettingsUndrainableNodeBehaviorEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecUpgradeSettingsUndrainableNodeBehaviorEnum
{
    [EnumMember(Value = "Cordon"), JsonStringEnumMemberName("Cordon")]
    Cordon,
    [EnumMember(Value = "Schedule"), JsonStringEnumMemberName("Schedule")]
    Schedule
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecUpgradeSettings
{
    /// <summary>
    /// DrainTimeoutInMinutes: The drain timeout for a node. The amount of time (in minutes) to wait on eviction of pods and
    /// graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is
    /// exceeded, the upgrade fails. If not specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// MaxBlockedNodes: The maximum number or percentage of extra nodes that are allowed to be blocked in the agent pool during
    /// an upgrade when undrainable node behavior is Cordon. This can either be set to an integer (e.g. &apos;5&apos;) or a percentage
    /// (e.g. &apos;50%&apos;). If a percentage is specified, it is the percentage of the total agent pool size at the time of the
    /// upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is maxSurge. This must always
    /// be greater than or equal to maxSurge. For more information, including best practices, see:
    /// https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("maxBlockedNodes")]
    public string? MaxBlockedNodes { get; set; }

    /// <summary>
    /// MaxSurge: The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer
    /// (e.g. &apos;5&apos;) or a percentage (e.g. &apos;50%&apos;). If a percentage is specified, it is the percentage of the total agent pool size
    /// at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 10%. For
    /// more information, including best practices, see: https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>
    /// MaxUnavailable: The maximum number or percentage of nodes that can be simultaneously unavailable during upgrade. This
    /// can either be set to an integer (e.g. &apos;1&apos;) or a percentage (e.g. &apos;5%&apos;). If a percentage is specified, it is the
    /// percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If
    /// not specified, the default is 0. For more information, including best practices, see:
    /// https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("maxUnavailable")]
    public string? MaxUnavailable { get; set; }

    /// <summary>
    /// NodeSoakDurationInMinutes: The soak duration for a node. The amount of time (in minutes) to wait after draining a node
    /// and before reimaging it and moving on to next node. If not specified, the default is 0 minutes.
    /// </summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }

    /// <summary>
    /// UndrainableNodeBehavior: Defines the behavior for undrainable nodes during upgrade. The most common cause of undrainable
    /// nodes is Pod Disruption Budgets (PDBs), but other issues, such as pod termination grace period is exceeding the
    /// remaining per-node drain timeout or pod is still being in a running state, can also cause undrainable nodes.
    /// </summary>
    [JsonPropertyName("undrainableNodeBehavior")]
    public V20251002previewManagedClustersAgentPoolSpecUpgradeSettingsUndrainableNodeBehaviorEnum? UndrainableNodeBehavior { get; set; }
}

/// <summary>
/// UpgradeSettingsBlueGreen: Settings for Blue-Green upgrade on the agentpool. Applies when upgrade strategy is set to
/// BlueGreen.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecUpgradeSettingsBlueGreen
{
    /// <summary>
    /// BatchSoakDurationInMinutes: The soak duration after draining a batch of nodes, i.e., the amount of time (in minutes) to
    /// wait after draining a batch of nodes before moving on the next batch. If not specified, the default is 15 minutes.
    /// </summary>
    [JsonPropertyName("batchSoakDurationInMinutes")]
    public int? BatchSoakDurationInMinutes { get; set; }

    /// <summary>
    /// DrainBatchSize: The number or percentage of nodes to drain in batch during blue-green upgrade. Must be a non-zero
    /// number. This can either be set to an integer (e.g. &apos;5&apos;) or a percentage (e.g. &apos;50%&apos;). If a percentage is specified, it
    /// is the percentage of the total number of blue nodes of the initial upgrade operation. For percentages, fractional nodes
    /// are rounded up. If not specified, the default is 10%. For more information, including best practices, see:
    /// https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("drainBatchSize")]
    public string? DrainBatchSize { get; set; }

    /// <summary>
    /// DrainTimeoutInMinutes: The drain timeout for a node, i.e., the amount of time (in minutes) to wait on eviction of pods
    /// and graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is
    /// exceeded, the upgrade fails. If not specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// FinalSoakDurationInMinutes: The soak duration for a node pool, i.e., the amount of time (in minutes) to wait after all
    /// old nodes are drained before we remove the old nodes. If not specified, the default is 60 minutes. Only applicable for
    /// blue-green upgrade strategy.
    /// </summary>
    [JsonPropertyName("finalSoakDurationInMinutes")]
    public int? FinalSoakDurationInMinutes { get; set; }
}

/// <summary>UpgradeStrategy: Defines the upgrade strategy for the agent pool. The default is Rolling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecUpgradeStrategyEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecUpgradeStrategyEnum
{
    [EnumMember(Value = "BlueGreen"), JsonStringEnumMemberName("BlueGreen")]
    BlueGreen,
    [EnumMember(Value = "Rolling"), JsonStringEnumMemberName("Rolling")]
    Rolling
}

/// <summary>Current status on a group of nodes of the same vm size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecVirtualMachineNodesStatus
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Size: The VM size of the agents used to host this group of nodes.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfileScaleAutoscale
{
    /// <summary>MaxCount: The maximum number of nodes of the specified sizes.</summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary>MinCount: The minimum number of nodes of the specified sizes.</summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary>
    /// Size: VM size that AKS will use when creating and scaling e.g. &apos;Standard_E4s_v3&apos;, &apos;Standard_E16s_v3&apos; or
    /// &apos;Standard_D16s_v5&apos;.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Specifications on number of machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfileScaleManual
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Size: VM size that AKS will use when creating and scaling e.g. &apos;Standard_E4s_v3&apos;, &apos;Standard_E16s_v3&apos; or
    /// &apos;Standard_D16s_v5&apos;.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfileScale
{
    /// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
    [JsonPropertyName("autoscale")]
    public V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    /// <summary>Manual: Specifications on how to scale the VirtualMachines agent pool to a fixed size.</summary>
    [JsonPropertyName("manual")]
    public IList<V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfile
{
    /// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
    [JsonPropertyName("scale")]
    public V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>
/// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
/// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
/// pods, otherwise it applies to just nodes. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpecVnetSubnetReference
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
public partial class V20251002previewManagedClustersAgentPoolSpecWindowsProfile
{
    /// <summary>
    /// DisableOutboundNat: Whether to disable OutboundNAT in windows nodes. The default value is false. Outbound NAT can only
    /// be disabled if the cluster outboundType is NAT Gateway and the Windows agent pool does not have node public IP enabled.
    /// </summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewManagedClustersAgentPoolSpecWorkloadRuntimeEnum>))]
public enum V20251002previewManagedClustersAgentPoolSpecWorkloadRuntimeEnum
{
    [EnumMember(Value = "KataMshvVmIsolation"), JsonStringEnumMemberName("KataMshvVmIsolation")]
    KataMshvVmIsolation,
    [EnumMember(Value = "KataVmIsolation"), JsonStringEnumMemberName("KataVmIsolation")]
    KataVmIsolation,
    [EnumMember(Value = "OCIContainer"), JsonStringEnumMemberName("OCIContainer")]
    OCIContainer,
    [EnumMember(Value = "WasmWasi"), JsonStringEnumMemberName("WasmWasi")]
    WasmWasi
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolSpec
{
    /// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewManagedClustersAgentPoolSpecArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

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

    /// <summary>
    /// CapacityReservationGroupReference: The fully qualified resource ID of the Capacity Reservation Group to provide virtual
    /// machines from a reserved group of Virtual Machines. This is of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Compute/capacityreservationgroups/{capacityReservationGroupName}&apos;
    /// Customers use it to create an agentpool with a specified CRG. For more information see [Capacity
    /// Reservation](https://learn.microsoft.com/en-us/azure/virtual-machines/capacity-reservation-overview)
    /// </summary>
    [JsonPropertyName("capacityReservationGroupReference")]
    public V20251002previewManagedClustersAgentPoolSpecCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

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
    public V20251002previewManagedClustersAgentPoolSpecCreationData? CreationData { get; set; }

    /// <summary>EnableAutoScaling: Whether to enable auto-scaler</summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary>
    /// EnableEncryptionAtHost: Whether to enable host based OS and data drive encryption. This is only supported on certain VM
    /// sizes and in certain Azure regions. For more information, see:
    /// https://docs.microsoft.com/azure/aks/enable-host-encryption
    /// </summary>
    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    /// <summary>
    /// EnableFIPS: Whether to use a FIPS-enabled OS. See [Add a FIPS-enabled node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview) for more
    /// details.
    /// </summary>
    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    /// <summary>
    /// EnableNodePublicIP: Whether each node is allocated its own public IP. Some scenarios may require nodes in a node pool to
    /// receive their own dedicated public IP addresses. A common scenario is for gaming workloads, where a console needs to
    /// make a direct connection to a cloud virtual machine to minimize hops. For more information see [assigning a public IP
    /// per node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools).
    /// The default is false.
    /// </summary>
    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    /// <summary>EnableUltraSSD: Whether to enable UltraSSD</summary>
    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary>
    /// GatewayProfile: Profile specific to a managed agent pool in Gateway mode. This field cannot be set if agent pool mode is
    /// not Gateway.
    /// </summary>
    [JsonPropertyName("gatewayProfile")]
    public V20251002previewManagedClustersAgentPoolSpecGatewayProfile? GatewayProfile { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public V20251002previewManagedClustersAgentPoolSpecGpuInstanceProfileEnum? GpuInstanceProfile { get; set; }

    /// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewManagedClustersAgentPoolSpecGpuProfile? GpuProfile { get; set; }

    /// <summary>
    /// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
    /// only in creation scenario and not allowed to changed once set. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupReference")]
    public V20251002previewManagedClustersAgentPoolSpecHostGroupReference? HostGroupReference { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V20251002previewManagedClustersAgentPoolSpecKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public V20251002previewManagedClustersAgentPoolSpecKubeletDiskTypeEnum? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewManagedClustersAgentPoolSpecLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// LocalDNSProfile: Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve
    /// performance and reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewManagedClustersAgentPoolSpecLocalDNSProfile? LocalDNSProfile { get; set; }

    /// <summary>MaxCount: The maximum number of nodes for auto-scaling</summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary>MaxPods: The maximum number of pods that can run on a node.</summary>
    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    /// <summary>
    /// MessageOfTheDay: Message of the day for Linux nodes, base64-encoded. A base64-encoded string which will be written to
    /// /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It must not be specified
    /// for Windows nodes. It must be a static string (i.e., will be printed raw and not be executed as a script).
    /// </summary>
    [JsonPropertyName("messageOfTheDay")]
    public string? MessageOfTheDay { get; set; }

    /// <summary>MinCount: The minimum number of nodes for auto-scaling</summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary>
    /// Mode: The mode of an agent pool. A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional
    /// information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
    /// </summary>
    [JsonPropertyName("mode")]
    public V20251002previewManagedClustersAgentPoolSpecModeEnum? Mode { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewManagedClustersAgentPoolSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeCustomizationProfile: Settings to determine the node customization used to provision nodes in a pool.</summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewManagedClustersAgentPoolSpecNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

    /// <summary>
    /// NodeInitializationTaints: Taints added on the nodes during creation that will not be reconciled by AKS. These taints
    /// will not be reconciled by AKS and can be removed with a kubectl call. This field can be modified after node pool is
    /// created, but nodes will not be recreated with new taints until another operation that requires recreation (e.g. node
    /// image upgrade) happens. These taints allow for required configuration to run before the node is ready to accept
    /// workloads, for example &apos;key1=value1:NoSchedule&apos; that then can be removed with `kubectl taint nodes node1
    /// key1=value1:NoSchedule-`
    /// </summary>
    [JsonPropertyName("nodeInitializationTaints")]
    public IList<string>? NodeInitializationTaints { get; set; }

    /// <summary>NodeLabels: The node labels to be persisted across all nodes in agent pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V20251002previewManagedClustersAgentPoolSpecNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

    /// <summary>NodeTaints: The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule.</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20251002previewManagedClustersAgentPoolSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// OrchestratorVersion: The version of Kubernetes specified by the user. Both patch version &lt;major.minor.patch&gt; (e.g.
    /// 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported. When &lt;major.minor&gt; is specified, the latest supported GA patch
    /// version is chosen automatically. Updating the cluster with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x
    /// -&gt; 1.14) will not trigger an upgrade, even if a newer patch version is available. As a best practice, you should upgrade
    /// all node pools in an AKS cluster to the same Kubernetes version. The node pool version must have the same major version
    /// as the control plane. The node pool minor version must be within two minor versions of the control plane version. The
    /// node pool version cannot be greater than the control plane version. For more information see [upgrading a node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool).
    /// </summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>
    /// OsDiskSizeGB: OS Disk Size in GB to be used to specify the disk size for every machine in the master/agent pool. If you
    /// specify 0, it will apply the default osDisk size according to the vmSize specified.
    /// </summary>
    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary>
    /// OsDiskType: The OS disk type to be used for machines in the agent pool. The default is &apos;Ephemeral&apos; if the VM supports it
    /// and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to &apos;Managed&apos;. May not be changed after
    /// creation. For more information see [Ephemeral
    /// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
    /// </summary>
    [JsonPropertyName("osDiskType")]
    public V20251002previewManagedClustersAgentPoolSpecOsDiskTypeEnum? OsDiskType { get; set; }

    /// <summary>
    /// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
    /// when Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    [JsonPropertyName("osSKU")]
    public V20251002previewManagedClustersAgentPoolSpecOsSKUEnum? OsSKU { get; set; }

    /// <summary>OsType: The operating system type. The default is Linux.</summary>
    [JsonPropertyName("osType")]
    public V20251002previewManagedClustersAgentPoolSpecOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/ManagedCluster resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20251002previewManagedClustersAgentPoolSpecOwner Owner { get; set; }

    /// <summary>
    /// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
    /// podSubnetId. The default is &apos;DynamicIndividual&apos;.
    /// </summary>
    [JsonPropertyName("podIPAllocationMode")]
    public V20251002previewManagedClustersAgentPoolSpecPodIPAllocationModeEnum? PodIPAllocationMode { get; set; }

    /// <summary>
    /// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
    /// on the node subnet (see vnetSubnetID for more details). This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetReference")]
    public V20251002previewManagedClustersAgentPoolSpecPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>
    /// PowerState: Whether the Agent Pool is running or stopped. When an Agent Pool is first created it is initially Running.
    /// The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not
    /// accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded
    /// </summary>
    [JsonPropertyName("powerState")]
    public V20251002previewManagedClustersAgentPoolSpecPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V20251002previewManagedClustersAgentPoolSpecProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

    /// <summary>
    /// ScaleDownMode: The scale down mode to use when scaling the Agent Pool. This also effects the cluster autoscaler
    /// behavior. If not specified, it defaults to Delete.
    /// </summary>
    [JsonPropertyName("scaleDownMode")]
    public V20251002previewManagedClustersAgentPoolSpecScaleDownModeEnum? ScaleDownMode { get; set; }

    /// <summary>
    /// ScaleSetEvictionPolicy: The Virtual Machine Scale Set eviction policy. The eviction policy specifies what to do with the
    /// VM when it is evicted. The default is Delete. For more information about eviction see [spot
    /// VMs](https://docs.microsoft.com/azure/virtual-machines/spot-vms)
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public V20251002previewManagedClustersAgentPoolSpecScaleSetEvictionPolicyEnum? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public V20251002previewManagedClustersAgentPoolSpecScaleSetPriorityEnum? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewManagedClustersAgentPoolSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// SpotMaxPrice: The max price (in US Dollars) you are willing to pay for spot instances. Possible values are any decimal
    /// value greater than zero or -1 which indicates default price to be up-to on-demand. Possible values are any decimal value
    /// greater than zero or -1 which indicates the willingness to pay any on-demand price. For more details on spot pricing,
    /// see [spot VMs pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing)
    /// </summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>Tags: The tags to be persisted on the agent pool virtual machine scale set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Agent Pool.</summary>
    [JsonPropertyName("type")]
    public V20251002previewManagedClustersAgentPoolSpecTypeEnum? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewManagedClustersAgentPoolSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// UpgradeSettingsBlueGreen: Settings for Blue-Green upgrade on the agentpool. Applies when upgrade strategy is set to
    /// BlueGreen.
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewManagedClustersAgentPoolSpecUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    /// <summary>UpgradeStrategy: Defines the upgrade strategy for the agent pool. The default is Rolling.</summary>
    [JsonPropertyName("upgradeStrategy")]
    public V20251002previewManagedClustersAgentPoolSpecUpgradeStrategyEnum? UpgradeStrategy { get; set; }

    /// <summary>VirtualMachineNodesStatus: The status of nodes in a VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewManagedClustersAgentPoolSpecVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewManagedClustersAgentPoolSpecVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

    /// <summary>
    /// VmSize: The size of the agent pool VMs. VM size availability varies by region. If a node contains insufficient compute
    /// resources (memory, cpu, etc) pods might fail to run correctly. For more details on restricted VM sizes, see:
    /// https://docs.microsoft.com/azure/aks/quotas-skus-regions
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
    /// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
    /// pods, otherwise it applies to just nodes. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("vnetSubnetReference")]
    public V20251002previewManagedClustersAgentPoolSpecVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewManagedClustersAgentPoolSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public V20251002previewManagedClustersAgentPoolSpecWorkloadRuntimeEnum? WorkloadRuntime { get; set; }
}

/// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusArtifactStreamingProfile
{
    /// <summary>
    /// Enabled: Artifact streaming speeds up the cold-start of containers on a node through on-demand image loading. To use
    /// this feature, container images must also enable artifact streaming on ACR. If not specified, the default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusConditions
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
public partial class V20251002previewManagedClustersAgentPoolStatusCreationData
{
    /// <summary>SourceResourceId: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>
/// GatewayProfile: Profile specific to a managed agent pool in Gateway mode. This field cannot be set if agent pool mode is
/// not Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusGatewayProfile
{
    /// <summary>
    /// PublicIPPrefixSize: The Gateway agent pool associates one public IPPrefix for each static egress gateway to provide
    /// public egress. The size of Public IPPrefix should be selected by the user. Each node in the agent pool is assigned with
    /// one IP from the IPPrefix. The IPPrefix size thus serves as a cap on the size of the Gateway agent pool. Due to Azure
    /// public IPPrefix size limitation, the valid value range is [28, 31] (/31 = 2 nodes/IPs, /30 = 4 nodes/IPs, /29 = 8
    /// nodes/IPs, /28 = 16 nodes/IPs). The default value is 31.
    /// </summary>
    [JsonPropertyName("publicIPPrefixSize")]
    public int? PublicIPPrefixSize { get; set; }
}

/// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusGpuProfile
{
    /// <summary>Driver: Whether to install GPU drivers. When it&apos;s not specified, default is Install.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    /// <summary>
    /// DriverType: Specify the type of GPU driver to install when creating Windows agent pools. If not provided, AKS selects
    /// the driver based on system compatibility. This cannot be changed once the AgentPool has been created. This cannot be set
    /// on Linux AgentPools. For Linux AgentPools, the driver is selected based on system compatibility.
    /// </summary>
    [JsonPropertyName("driverType")]
    public string? DriverType { get; set; }
}

/// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusKubeletConfig
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

    /// <summary>CpuCfsQuota: If CPU CFS quota enforcement is enabled for containers that specify CPU limits. The default is true.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>
    /// CpuCfsQuotaPeriod: The CPU CFS quota period value. The default is &apos;100ms.&apos; Valid values are a sequence of decimal
    /// numbers with an optional fraction and a unit suffix. For example: &apos;300ms&apos;, &apos;2h45m&apos;. Supported units are &apos;ns&apos;, &apos;us&apos;,
    /// &apos;ms&apos;, &apos;s&apos;, &apos;m&apos;, and &apos;h&apos;.
    /// </summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>
    /// CpuManagerPolicy: The CPU Manager policy to use. The default is &apos;none&apos;. See [Kubernetes CPU management
    /// policies](https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/#cpu-management-policies) for more
    /// information. Allowed values are &apos;none&apos; and &apos;static&apos;.
    /// </summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>FailSwapOn: If set to true it will make the Kubelet fail to start if swap is enabled on the node.</summary>
    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    /// <summary>
    /// ImageGcHighThreshold: The percent of disk usage after which image garbage collection is always run. To disable image
    /// garbage collection, set to 100. The default is 85%
    /// </summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    /// <summary>
    /// ImageGcLowThreshold: The percent of disk usage before which image garbage collection is never run. This cannot be set
    /// higher than imageGcHighThreshold. The default is 80%
    /// </summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    /// <summary>PodMaxPids: The maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    /// <summary>
    /// SeccompDefault: Specifies the default seccomp profile applied to all workloads. If not specified, &apos;Unconfined&apos; will be
    /// used by default.
    /// </summary>
    [JsonPropertyName("seccompDefault")]
    public string? SeccompDefault { get; set; }

    /// <summary>
    /// TopologyManagerPolicy: The Topology Manager policy to use. For more information see [Kubernetes Topology
    /// Manager](https://kubernetes.io/docs/tasks/administer-cluster/topology-manager). The default is &apos;none&apos;. Allowed values
    /// are &apos;none&apos;, &apos;best-effort&apos;, &apos;restricted&apos;, and &apos;single-numa-node&apos;.
    /// </summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusLinuxOSConfigSysctls
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
public partial class V20251002previewManagedClustersAgentPoolStatusLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V20251002previewManagedClustersAgentPoolStatusLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary>
    /// TransparentHugePageDefrag: Whether the kernel should make aggressive use of memory compaction to make more hugepages
    /// available. Valid values are &apos;always&apos;, &apos;defer&apos;, &apos;defer+madvise&apos;, &apos;madvise&apos; and &apos;never&apos;. The default is &apos;madvise&apos;. For
    /// more information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>
    /// TransparentHugePageEnabled: Whether transparent hugepages are enabled. Valid values are &apos;always&apos;, &apos;madvise&apos;, and
    /// &apos;never&apos;. The default is &apos;always&apos;. For more information see [Transparent
    /// Hugepages](https://www.kernel.org/doc/html/latest/admin-guide/mm/transhuge.html#admin-guide-transhuge).
    /// </summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>Overrides for localDNS profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusLocalDNSProfileKubeDNSOverrides
{
    /// <summary>
    /// CacheDurationInSeconds: Cache max TTL in seconds. See [cache plugin](https://coredns.io/plugins/cache) for more
    /// information.
    /// </summary>
    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    /// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
    [JsonPropertyName("forwardDestination")]
    public string? ForwardDestination { get; set; }

    /// <summary>
    /// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
    /// plugin](https://coredns.io/plugins/forward) for more information.
    /// </summary>
    [JsonPropertyName("forwardPolicy")]
    public string? ForwardPolicy { get; set; }

    /// <summary>
    /// MaxConcurrent: Maximum number of concurrent queries. See [forward plugin](https://coredns.io/plugins/forward) for more
    /// information.
    /// </summary>
    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    /// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
    [JsonPropertyName("queryLogging")]
    public string? QueryLogging { get; set; }

    /// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
    [JsonPropertyName("serveStale")]
    public string? ServeStale { get; set; }

    /// <summary>
    /// ServeStaleDurationInSeconds: Serve stale duration in seconds. See [cache plugin](https://coredns.io/plugins/cache) for
    /// more information.
    /// </summary>
    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>Overrides for localDNS profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusLocalDNSProfileVnetDNSOverrides
{
    /// <summary>
    /// CacheDurationInSeconds: Cache max TTL in seconds. See [cache plugin](https://coredns.io/plugins/cache) for more
    /// information.
    /// </summary>
    [JsonPropertyName("cacheDurationInSeconds")]
    public int? CacheDurationInSeconds { get; set; }

    /// <summary>ForwardDestination: Destination server for DNS queries to be forwarded from localDNS.</summary>
    [JsonPropertyName("forwardDestination")]
    public string? ForwardDestination { get; set; }

    /// <summary>
    /// ForwardPolicy: Forward policy for selecting upstream DNS server. See [forward
    /// plugin](https://coredns.io/plugins/forward) for more information.
    /// </summary>
    [JsonPropertyName("forwardPolicy")]
    public string? ForwardPolicy { get; set; }

    /// <summary>
    /// MaxConcurrent: Maximum number of concurrent queries. See [forward plugin](https://coredns.io/plugins/forward) for more
    /// information.
    /// </summary>
    [JsonPropertyName("maxConcurrent")]
    public int? MaxConcurrent { get; set; }

    /// <summary>Protocol: Enforce TCP or prefer UDP protocol for connections from localDNS to upstream DNS server.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>QueryLogging: Log level for DNS queries in localDNS.</summary>
    [JsonPropertyName("queryLogging")]
    public string? QueryLogging { get; set; }

    /// <summary>ServeStale: Policy for serving stale data. See [cache plugin](https://coredns.io/plugins/cache) for more information.</summary>
    [JsonPropertyName("serveStale")]
    public string? ServeStale { get; set; }

    /// <summary>
    /// ServeStaleDurationInSeconds: Serve stale duration in seconds. See [cache plugin](https://coredns.io/plugins/cache) for
    /// more information.
    /// </summary>
    [JsonPropertyName("serveStaleDurationInSeconds")]
    public int? ServeStaleDurationInSeconds { get; set; }
}

/// <summary>
/// LocalDNSProfile: Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve
/// performance and reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusLocalDNSProfile
{
    /// <summary>
    /// KubeDNSOverrides: KubeDNS overrides apply to DNS traffic from pods with dnsPolicy:ClusterFirst (referred to as KubeDNS
    /// traffic).
    /// </summary>
    [JsonPropertyName("kubeDNSOverrides")]
    public IDictionary<string, V20251002previewManagedClustersAgentPoolStatusLocalDNSProfileKubeDNSOverrides>? KubeDNSOverrides { get; set; }

    /// <summary>Mode: Mode of enablement for localDNS.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>State: System-generated state of localDNS.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// VnetDNSOverrides: VnetDNS overrides apply to DNS traffic from pods with dnsPolicy:default or kubelet (referred to as
    /// VnetDNS traffic).
    /// </summary>
    [JsonPropertyName("vnetDNSOverrides")]
    public IDictionary<string, V20251002previewManagedClustersAgentPoolStatusLocalDNSProfileVnetDNSOverrides>? VnetDNSOverrides { get; set; }
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts
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
public partial class V20251002previewManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags
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
public partial class V20251002previewManagedClustersAgentPoolStatusNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V20251002previewManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>ApplicationSecurityGroups: The IDs of the application security groups which agent pool will associate when created.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V20251002previewManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>NodeCustomizationProfile: Settings to determine the node customization used to provision nodes in a pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusNodeCustomizationProfile
{
    /// <summary>
    /// NodeCustomizationId: The resource ID of the node customization resource to use. This can be a version. Omitting the
    /// version will use the latest version of the node customization.
    /// </summary>
    [JsonPropertyName("nodeCustomizationId")]
    public string? NodeCustomizationId { get; set; }
}

/// <summary>
/// PowerState: Whether the Agent Pool is running or stopped. When an Agent Pool is first created it is initially Running.
/// The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not
/// accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusSecurityProfile
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

    /// <summary>SshAccess: SSH access method of an agent pool.</summary>
    [JsonPropertyName("sshAccess")]
    public string? SshAccess { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusStatusProvisioningErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusStatusProvisioningErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusStatusProvisioningErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewManagedClustersAgentPoolStatusStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// ProvisioningError: The error detail information of the agent pool. Preserves the detailed info of failure. If there was
/// no error, this field is omitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusStatusProvisioningError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V20251002previewManagedClustersAgentPoolStatusStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V20251002previewManagedClustersAgentPoolStatusStatusProvisioningErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: Contains read-only information about the Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusStatus
{
    /// <summary>
    /// ProvisioningError: The error detail information of the agent pool. Preserves the detailed info of failure. If there was
    /// no error, this field is omitted.
    /// </summary>
    [JsonPropertyName("provisioningError")]
    public V20251002previewManagedClustersAgentPoolStatusStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusSystemData
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

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusUpgradeSettings
{
    /// <summary>
    /// DrainTimeoutInMinutes: The drain timeout for a node. The amount of time (in minutes) to wait on eviction of pods and
    /// graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is
    /// exceeded, the upgrade fails. If not specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// MaxBlockedNodes: The maximum number or percentage of extra nodes that are allowed to be blocked in the agent pool during
    /// an upgrade when undrainable node behavior is Cordon. This can either be set to an integer (e.g. &apos;5&apos;) or a percentage
    /// (e.g. &apos;50%&apos;). If a percentage is specified, it is the percentage of the total agent pool size at the time of the
    /// upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is maxSurge. This must always
    /// be greater than or equal to maxSurge. For more information, including best practices, see:
    /// https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("maxBlockedNodes")]
    public string? MaxBlockedNodes { get; set; }

    /// <summary>
    /// MaxSurge: The maximum number or percentage of nodes that are surged during upgrade. This can either be set to an integer
    /// (e.g. &apos;5&apos;) or a percentage (e.g. &apos;50%&apos;). If a percentage is specified, it is the percentage of the total agent pool size
    /// at the time of the upgrade. For percentages, fractional nodes are rounded up. If not specified, the default is 10%. For
    /// more information, including best practices, see: https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>
    /// MaxUnavailable: The maximum number or percentage of nodes that can be simultaneously unavailable during upgrade. This
    /// can either be set to an integer (e.g. &apos;1&apos;) or a percentage (e.g. &apos;5%&apos;). If a percentage is specified, it is the
    /// percentage of the total agent pool size at the time of the upgrade. For percentages, fractional nodes are rounded up. If
    /// not specified, the default is 0. For more information, including best practices, see:
    /// https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("maxUnavailable")]
    public string? MaxUnavailable { get; set; }

    /// <summary>
    /// NodeSoakDurationInMinutes: The soak duration for a node. The amount of time (in minutes) to wait after draining a node
    /// and before reimaging it and moving on to next node. If not specified, the default is 0 minutes.
    /// </summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }

    /// <summary>
    /// UndrainableNodeBehavior: Defines the behavior for undrainable nodes during upgrade. The most common cause of undrainable
    /// nodes is Pod Disruption Budgets (PDBs), but other issues, such as pod termination grace period is exceeding the
    /// remaining per-node drain timeout or pod is still being in a running state, can also cause undrainable nodes.
    /// </summary>
    [JsonPropertyName("undrainableNodeBehavior")]
    public string? UndrainableNodeBehavior { get; set; }
}

/// <summary>
/// UpgradeSettingsBlueGreen: Settings for Blue-Green upgrade on the agentpool. Applies when upgrade strategy is set to
/// BlueGreen.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusUpgradeSettingsBlueGreen
{
    /// <summary>
    /// BatchSoakDurationInMinutes: The soak duration after draining a batch of nodes, i.e., the amount of time (in minutes) to
    /// wait after draining a batch of nodes before moving on the next batch. If not specified, the default is 15 minutes.
    /// </summary>
    [JsonPropertyName("batchSoakDurationInMinutes")]
    public int? BatchSoakDurationInMinutes { get; set; }

    /// <summary>
    /// DrainBatchSize: The number or percentage of nodes to drain in batch during blue-green upgrade. Must be a non-zero
    /// number. This can either be set to an integer (e.g. &apos;5&apos;) or a percentage (e.g. &apos;50%&apos;). If a percentage is specified, it
    /// is the percentage of the total number of blue nodes of the initial upgrade operation. For percentages, fractional nodes
    /// are rounded up. If not specified, the default is 10%. For more information, including best practices, see:
    /// https://learn.microsoft.com/en-us/azure/aks/upgrade-cluster
    /// </summary>
    [JsonPropertyName("drainBatchSize")]
    public string? DrainBatchSize { get; set; }

    /// <summary>
    /// DrainTimeoutInMinutes: The drain timeout for a node, i.e., the amount of time (in minutes) to wait on eviction of pods
    /// and graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is
    /// exceeded, the upgrade fails. If not specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary>
    /// FinalSoakDurationInMinutes: The soak duration for a node pool, i.e., the amount of time (in minutes) to wait after all
    /// old nodes are drained before we remove the old nodes. If not specified, the default is 60 minutes. Only applicable for
    /// blue-green upgrade strategy.
    /// </summary>
    [JsonPropertyName("finalSoakDurationInMinutes")]
    public int? FinalSoakDurationInMinutes { get; set; }
}

/// <summary>Current status on a group of nodes of the same vm size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusVirtualMachineNodesStatus
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Size: The VM size of the agents used to host this group of nodes.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfileScaleAutoscale
{
    /// <summary>MaxCount: The maximum number of nodes of the specified sizes.</summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary>MinCount: The minimum number of nodes of the specified sizes.</summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary>
    /// Size: VM size that AKS will use when creating and scaling e.g. &apos;Standard_E4s_v3&apos;, &apos;Standard_E16s_v3&apos; or
    /// &apos;Standard_D16s_v5&apos;.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Specifications on number of machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfileScaleManual
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// Size: VM size that AKS will use when creating and scaling e.g. &apos;Standard_E4s_v3&apos;, &apos;Standard_E16s_v3&apos; or
    /// &apos;Standard_D16s_v5&apos;.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfileScale
{
    /// <summary>Autoscale: Specifications on how to auto-scale the VirtualMachines agent pool within a predefined size range.</summary>
    [JsonPropertyName("autoscale")]
    public V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfileScaleAutoscale? Autoscale { get; set; }

    /// <summary>Manual: Specifications on how to scale the VirtualMachines agent pool to a fixed size.</summary>
    [JsonPropertyName("manual")]
    public IList<V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfile
{
    /// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
    [JsonPropertyName("scale")]
    public V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatusWindowsProfile
{
    /// <summary>
    /// DisableOutboundNat: Whether to disable OutboundNAT in windows nodes. The default value is false. Outbound NAT can only
    /// be disabled if the cluster outboundType is NAT Gateway and the Windows agent pool does not have node public IP enabled.
    /// </summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewManagedClustersAgentPoolStatus
{
    /// <summary>ArtifactStreamingProfile: Configuration for using artifact streaming on AKS.</summary>
    [JsonPropertyName("artifactStreamingProfile")]
    public V20251002previewManagedClustersAgentPoolStatusArtifactStreamingProfile? ArtifactStreamingProfile { get; set; }

    /// <summary>
    /// AvailabilityZones: The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType
    /// property is &apos;VirtualMachineScaleSets&apos;.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>
    /// CapacityReservationGroupID: The fully qualified resource ID of the Capacity Reservation Group to provide virtual
    /// machines from a reserved group of Virtual Machines. This is of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Compute/capacityreservationgroups/{capacityReservationGroupName}&apos;
    /// Customers use it to create an agentpool with a specified CRG. For more information see [Capacity
    /// Reservation](https://learn.microsoft.com/en-us/azure/virtual-machines/capacity-reservation-overview)
    /// </summary>
    [JsonPropertyName("capacityReservationGroupID")]
    public string? CapacityReservationGroupID { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20251002previewManagedClustersAgentPoolStatusConditions>? Conditions { get; set; }

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
    public V20251002previewManagedClustersAgentPoolStatusCreationData? CreationData { get; set; }

    /// <summary>
    /// CurrentOrchestratorVersion: The version of Kubernetes the Agent Pool is running. If orchestratorVersion is a fully
    /// specified version &lt;major.minor.patch&gt;, this field will be exactly equal to it. If orchestratorVersion is &lt;major.minor&gt;,
    /// this field will contain the full &lt;major.minor.patch&gt; version being used.
    /// </summary>
    [JsonPropertyName("currentOrchestratorVersion")]
    public string? CurrentOrchestratorVersion { get; set; }

    /// <summary>
    /// ETag: Unique read-only string used to implement optimistic concurrency. The eTag value will change when the resource is
    /// updated. Specify an if-match or if-none-match header with the eTag value for a subsequent request to enable optimistic
    /// concurrency per the normal eTag convention.
    /// </summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>EnableAutoScaling: Whether to enable auto-scaler</summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary>
    /// EnableEncryptionAtHost: Whether to enable host based OS and data drive encryption. This is only supported on certain VM
    /// sizes and in certain Azure regions. For more information, see:
    /// https://docs.microsoft.com/azure/aks/enable-host-encryption
    /// </summary>
    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    /// <summary>
    /// EnableFIPS: Whether to use a FIPS-enabled OS. See [Add a FIPS-enabled node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview) for more
    /// details.
    /// </summary>
    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    /// <summary>
    /// EnableNodePublicIP: Whether each node is allocated its own public IP. Some scenarios may require nodes in a node pool to
    /// receive their own dedicated public IP addresses. A common scenario is for gaming workloads, where a console needs to
    /// make a direct connection to a cloud virtual machine to minimize hops. For more information see [assigning a public IP
    /// per node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools).
    /// The default is false.
    /// </summary>
    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    /// <summary>EnableUltraSSD: Whether to enable UltraSSD</summary>
    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary>
    /// GatewayProfile: Profile specific to a managed agent pool in Gateway mode. This field cannot be set if agent pool mode is
    /// not Gateway.
    /// </summary>
    [JsonPropertyName("gatewayProfile")]
    public V20251002previewManagedClustersAgentPoolStatusGatewayProfile? GatewayProfile { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
    [JsonPropertyName("gpuProfile")]
    public V20251002previewManagedClustersAgentPoolStatusGpuProfile? GpuProfile { get; set; }

    /// <summary>
    /// HostGroupID: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used only
    /// in creation scenario and not allowed to changed once set. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupID")]
    public string? HostGroupID { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V20251002previewManagedClustersAgentPoolStatusKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V20251002previewManagedClustersAgentPoolStatusLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary>
    /// LocalDNSProfile: Configures the per-node local DNS, with VnetDNS and KubeDNS overrides. LocalDNS helps improve
    /// performance and reliability of DNS resolution in an AKS cluster. For more details see aka.ms/aks/localdns.
    /// </summary>
    [JsonPropertyName("localDNSProfile")]
    public V20251002previewManagedClustersAgentPoolStatusLocalDNSProfile? LocalDNSProfile { get; set; }

    /// <summary>MaxCount: The maximum number of nodes for auto-scaling</summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary>MaxPods: The maximum number of pods that can run on a node.</summary>
    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    /// <summary>
    /// MessageOfTheDay: Message of the day for Linux nodes, base64-encoded. A base64-encoded string which will be written to
    /// /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It must not be specified
    /// for Windows nodes. It must be a static string (i.e., will be printed raw and not be executed as a script).
    /// </summary>
    [JsonPropertyName("messageOfTheDay")]
    public string? MessageOfTheDay { get; set; }

    /// <summary>MinCount: The minimum number of nodes for auto-scaling</summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary>
    /// Mode: The mode of an agent pool. A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional
    /// information on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V20251002previewManagedClustersAgentPoolStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeCustomizationProfile: Settings to determine the node customization used to provision nodes in a pool.</summary>
    [JsonPropertyName("nodeCustomizationProfile")]
    public V20251002previewManagedClustersAgentPoolStatusNodeCustomizationProfile? NodeCustomizationProfile { get; set; }

    /// <summary>NodeImageVersion: The version of node image</summary>
    [JsonPropertyName("nodeImageVersion")]
    public string? NodeImageVersion { get; set; }

    /// <summary>
    /// NodeInitializationTaints: Taints added on the nodes during creation that will not be reconciled by AKS. These taints
    /// will not be reconciled by AKS and can be removed with a kubectl call. This field can be modified after node pool is
    /// created, but nodes will not be recreated with new taints until another operation that requires recreation (e.g. node
    /// image upgrade) happens. These taints allow for required configuration to run before the node is ready to accept
    /// workloads, for example &apos;key1=value1:NoSchedule&apos; that then can be removed with `kubectl taint nodes node1
    /// key1=value1:NoSchedule-`
    /// </summary>
    [JsonPropertyName("nodeInitializationTaints")]
    public IList<string>? NodeInitializationTaints { get; set; }

    /// <summary>NodeLabels: The node labels to be persisted across all nodes in agent pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixID: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixID")]
    public string? NodePublicIPPrefixID { get; set; }

    /// <summary>NodeTaints: The taints added to new nodes during node pool create and scale. For example, key=value:NoSchedule.</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>
    /// OrchestratorVersion: The version of Kubernetes specified by the user. Both patch version &lt;major.minor.patch&gt; (e.g.
    /// 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported. When &lt;major.minor&gt; is specified, the latest supported GA patch
    /// version is chosen automatically. Updating the cluster with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x
    /// -&gt; 1.14) will not trigger an upgrade, even if a newer patch version is available. As a best practice, you should upgrade
    /// all node pools in an AKS cluster to the same Kubernetes version. The node pool version must have the same major version
    /// as the control plane. The node pool minor version must be within two minor versions of the control plane version. The
    /// node pool version cannot be greater than the control plane version. For more information see [upgrading a node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool).
    /// </summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>
    /// OsDiskSizeGB: OS Disk Size in GB to be used to specify the disk size for every machine in the master/agent pool. If you
    /// specify 0, it will apply the default osDisk size according to the vmSize specified.
    /// </summary>
    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary>
    /// OsDiskType: The OS disk type to be used for machines in the agent pool. The default is &apos;Ephemeral&apos; if the VM supports it
    /// and has a cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to &apos;Managed&apos;. May not be changed after
    /// creation. For more information see [Ephemeral
    /// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
    /// </summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>
    /// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
    /// when Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    [JsonPropertyName("osSKU")]
    public string? OsSKU { get; set; }

    /// <summary>OsType: The operating system type. The default is Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>
    /// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
    /// podSubnetId. The default is &apos;DynamicIndividual&apos;.
    /// </summary>
    [JsonPropertyName("podIPAllocationMode")]
    public string? PodIPAllocationMode { get; set; }

    /// <summary>
    /// PodSubnetID: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned on the
    /// node subnet (see vnetSubnetID for more details). This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetID")]
    public string? PodSubnetID { get; set; }

    /// <summary>
    /// PowerState: Whether the Agent Pool is running or stopped. When an Agent Pool is first created it is initially Running.
    /// The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not
    /// accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded
    /// </summary>
    [JsonPropertyName("powerState")]
    public V20251002previewManagedClustersAgentPoolStatusPowerState? PowerState { get; set; }

    /// <summary>PropertiesType: The type of Agent Pool.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>ProvisioningState: The current deployment or provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ProximityPlacementGroupID: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupID")]
    public string? ProximityPlacementGroupID { get; set; }

    /// <summary>
    /// ScaleDownMode: The scale down mode to use when scaling the Agent Pool. This also effects the cluster autoscaler
    /// behavior. If not specified, it defaults to Delete.
    /// </summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>
    /// ScaleSetEvictionPolicy: The Virtual Machine Scale Set eviction policy. The eviction policy specifies what to do with the
    /// VM when it is evicted. The default is Delete. For more information about eviction see [spot
    /// VMs](https://docs.microsoft.com/azure/virtual-machines/spot-vms)
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public string? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public string? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V20251002previewManagedClustersAgentPoolStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// SpotMaxPrice: The max price (in US Dollars) you are willing to pay for spot instances. Possible values are any decimal
    /// value greater than zero or -1 which indicates default price to be up-to on-demand. Possible values are any decimal value
    /// greater than zero or -1 which indicates the willingness to pay any on-demand price. For more details on spot pricing,
    /// see [spot VMs pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing)
    /// </summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>Status: Contains read-only information about the Agent Pool.</summary>
    [JsonPropertyName("status")]
    public V20251002previewManagedClustersAgentPoolStatusStatus? Status { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20251002previewManagedClustersAgentPoolStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: The tags to be persisted on the agent pool virtual machine scale set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V20251002previewManagedClustersAgentPoolStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>
    /// UpgradeSettingsBlueGreen: Settings for Blue-Green upgrade on the agentpool. Applies when upgrade strategy is set to
    /// BlueGreen.
    /// </summary>
    [JsonPropertyName("upgradeSettingsBlueGreen")]
    public V20251002previewManagedClustersAgentPoolStatusUpgradeSettingsBlueGreen? UpgradeSettingsBlueGreen { get; set; }

    /// <summary>UpgradeStrategy: Defines the upgrade strategy for the agent pool. The default is Rolling.</summary>
    [JsonPropertyName("upgradeStrategy")]
    public string? UpgradeStrategy { get; set; }

    /// <summary>VirtualMachineNodesStatus: The status of nodes in a VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V20251002previewManagedClustersAgentPoolStatusVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V20251002previewManagedClustersAgentPoolStatusVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

    /// <summary>
    /// VmSize: The size of the agent pool VMs. VM size availability varies by region. If a node contains insufficient compute
    /// resources (memory, cpu, etc) pods might fail to run correctly. For more details on restricted VM sizes, see:
    /// https://docs.microsoft.com/azure/aks/quotas-skus-regions
    /// </summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>
    /// VnetSubnetID: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is not
    /// specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods,
    /// otherwise it applies to just nodes. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("vnetSubnetID")]
    public string? VnetSubnetID { get; set; }

    /// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V20251002previewManagedClustersAgentPoolStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewManagedClustersAgentPool : IKubernetesObject<V1ObjectMeta>, ISpec<V20251002previewManagedClustersAgentPoolSpec?>, IStatus<V20251002previewManagedClustersAgentPoolStatus?>
{
    public const string KubeApiVersion = "v20251002preview";
    public const string KubeKind = "ManagedClustersAgentPool";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClustersAgentPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20251002previewManagedClustersAgentPoolSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20251002previewManagedClustersAgentPoolStatus? Status { get; set; }
}