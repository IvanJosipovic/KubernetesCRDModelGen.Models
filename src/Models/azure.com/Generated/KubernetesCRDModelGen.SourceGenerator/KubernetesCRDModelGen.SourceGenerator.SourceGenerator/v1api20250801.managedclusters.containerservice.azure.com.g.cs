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
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2025-08-01/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250801ManagedClusterList : IKubernetesObject<V1ListMeta>, IItems<V1api20250801ManagedCluster>
{
    public const string KubeApiVersion = "v1api20250801";
    public const string KubeKind = "ManagedClusterList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250801ManagedCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250801ManagedCluster> Items { get; set; }
}

/// <summary>AadProfile: The Azure Active Directory configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAadProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAddonProfiles
{
    /// <summary>Config: Key-value pairs for configuring an add-on.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary>Enabled: Whether the add-on is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesCreationData
{
    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>
/// GatewayProfile: Profile specific to a managed agent pool in Gateway mode. This field cannot be set if agent pool mode is
/// not Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesGatewayProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesGpuProfileDriverEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesGpuProfileDriverEnum
{
    [EnumMember(Value = "Install"), JsonStringEnumMemberName("Install")]
    Install,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesGpuProfile
{
    /// <summary>Driver: Whether to install GPU drivers. When it&apos;s not specified, default is Install.</summary>
    [JsonPropertyName("driver")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesGpuProfileDriverEnum? Driver { get; set; }
}

/// <summary>
/// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
/// only in creation scenario and not allowed to changed once set. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
/// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesHostGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesKubeletConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum
{
    [EnumMember(Value = "OS"), JsonStringEnumMemberName("OS")]
    OS,
    [EnumMember(Value = "Temporary"), JsonStringEnumMemberName("Temporary")]
    Temporary
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

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

/// <summary>
/// Mode: The mode of an agent pool. A cluster must have at least one &apos;System&apos; Agent Pool at all times. For additional
/// information  on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesModeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesModeEnum
{
    [EnumMember(Value = "Gateway"), JsonStringEnumMemberName("Gateway")]
    Gateway,
    [EnumMember(Value = "System"), JsonStringEnumMemberName("System")]
    System,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>Protocol: The network protocol of the port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum
{
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts
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
    public V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPortsProtocolEnum? Protocol { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags
{
    /// <summary>IpTagType: The IP tag type. Example: RoutingPreference.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: The value of the IP tag associated with the public IP. Example: Internet.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>
    /// ApplicationSecurityGroupsReferences: The IDs of the application security groups which agent pool will associate when
    /// created.
    /// </summary>
    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference
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
/// OsDiskType: The OS disk type to be used for machines in the agent pool. The default is &apos;Ephemeral&apos; if the VM supports it
/// and has a  cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to &apos;Managed&apos;. May not be changed after
/// creation.  For more information see [Ephemeral
/// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesOsSKUEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesOsSKUEnum
{
    [EnumMember(Value = "AzureLinux"), JsonStringEnumMemberName("AzureLinux")]
    AzureLinux,
    [EnumMember(Value = "AzureLinux3"), JsonStringEnumMemberName("AzureLinux3")]
    AzureLinux3,
    [EnumMember(Value = "CBLMariner"), JsonStringEnumMemberName("CBLMariner")]
    CBLMariner,
    [EnumMember(Value = "Ubuntu"), JsonStringEnumMemberName("Ubuntu")]
    Ubuntu,
    [EnumMember(Value = "Ubuntu2204"), JsonStringEnumMemberName("Ubuntu2204")]
    Ubuntu2204,
    [EnumMember(Value = "Windows2019"), JsonStringEnumMemberName("Windows2019")]
    Windows2019,
    [EnumMember(Value = "Windows2022"), JsonStringEnumMemberName("Windows2022")]
    Windows2022
}

/// <summary>OsType: The operating system type. The default is Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesOsTypeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
/// podSubnetId. The default is  &apos;DynamicIndividual&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesPodIPAllocationModeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesPodIPAllocationModeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesPodSubnetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesPowerStateCodeEnum? Code { get; set; }
}

/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesScaleDownModeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesScaleDownModeEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// ScaleSetEvictionPolicy: The Virtual Machine Scale Set eviction policy to use. This cannot be specified unless the
/// scaleSetPriority is &apos;Spot&apos;. If not specified, the default is &apos;Delete&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum
{
    [EnumMember(Value = "Deallocate"), JsonStringEnumMemberName("Deallocate")]
    Deallocate,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum
{
    [EnumMember(Value = "Regular"), JsonStringEnumMemberName("Regular")]
    Regular,
    [EnumMember(Value = "Spot"), JsonStringEnumMemberName("Spot")]
    Spot
}

/// <summary>SshAccess: SSH access method of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesSecurityProfileSshAccessEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesSecurityProfileSshAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "LocalUser"), JsonStringEnumMemberName("LocalUser")]
    LocalUser
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesSecurityProfile
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
    public V1api20250801ManagedClusterSpecAgentPoolProfilesSecurityProfileSshAccessEnum? SshAccess { get; set; }
}

/// <summary>Type: The type of Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesTypeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesTypeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesUpgradeSettingsUndrainableNodeBehaviorEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesUpgradeSettingsUndrainableNodeBehaviorEnum
{
    [EnumMember(Value = "Cordon"), JsonStringEnumMemberName("Cordon")]
    Cordon,
    [EnumMember(Value = "Schedule"), JsonStringEnumMemberName("Schedule")]
    Schedule
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesUpgradeSettings
{
    /// <summary>
    /// DrainTimeoutInMinutes: The drain timeout for a node. The amount of time (in minutes) to wait on eviction of pods and
    /// graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is
    /// exceeded, the upgrade fails. If not specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

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
    public V1api20250801ManagedClusterSpecAgentPoolProfilesUpgradeSettingsUndrainableNodeBehaviorEnum? UndrainableNodeBehavior { get; set; }
}

/// <summary>Current status on a group of nodes of the same vm size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachineNodesStatus
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Size: The VM size of the agents used to host this group of nodes.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Specifications on number of machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleManual
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScale
{
    /// <summary>Manual: Specifications on how to scale the VirtualMachines agent pool to a fixed size.</summary>
    [JsonPropertyName("manual")]
    public IList<V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachinesProfile
{
    /// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
    [JsonPropertyName("scale")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>
/// VnetSubnetReference: The ID of the subnet which agent pool nodes and optionally pods will join on startup. If this is
/// not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and
/// pods, otherwise it applies to just nodes. This is of the form:
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesVnetSubnetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfilesWindowsProfile
{
    /// <summary>
    /// DisableOutboundNat: Whether to disable OutboundNAT in windows nodes. The default value is false. Outbound NAT can only
    /// be disabled if the cluster outboundType is NAT Gateway and the Windows agent pool does not have node public IP enabled.
    /// </summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum>))]
public enum V1api20250801ManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum
{
    [EnumMember(Value = "OCIContainer"), JsonStringEnumMemberName("OCIContainer")]
    OCIContainer,
    [EnumMember(Value = "WasmWasi"), JsonStringEnumMemberName("WasmWasi")]
    WasmWasi
}

/// <summary>Profile for the container service agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAgentPoolProfiles
{
    /// <summary>
    /// AvailabilityZones: The list of Availability zones to use for nodes. This can only be specified if the AgentPoolType
    /// property is &apos;VirtualMachineScaleSets&apos;.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
    [JsonPropertyName("capacityReservationGroupReference")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

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
    public V1api20250801ManagedClusterSpecAgentPoolProfilesCreationData? CreationData { get; set; }

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
    public V1api20250801ManagedClusterSpecAgentPoolProfilesGatewayProfile? GatewayProfile { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesGpuInstanceProfileEnum? GpuInstanceProfile { get; set; }

    /// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
    [JsonPropertyName("gpuProfile")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesGpuProfile? GpuProfile { get; set; }

    /// <summary>
    /// HostGroupReference: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used
    /// only in creation scenario and not allowed to changed once set. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupReference")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesHostGroupReference? HostGroupReference { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesKubeletDiskTypeEnum? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

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
    /// information  on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
    /// </summary>
    [JsonPropertyName("mode")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesModeEnum? Mode { get; set; }

    /// <summary>
    /// Name: Unique name of the agent pool profile in the context of the subscription and resource group. Windows agent pool
    /// names must be 6 characters or less.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeLabels: The node labels to be persisted across all nodes in agent pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>
    /// NodePublicIPPrefixReference: The public IP prefix ID which VM nodes should use IPs from. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
    /// </summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

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

    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary>
    /// OsDiskType: The OS disk type to be used for machines in the agent pool. The default is &apos;Ephemeral&apos; if the VM supports it
    /// and has a  cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to &apos;Managed&apos;. May not be changed after
    /// creation.  For more information see [Ephemeral
    /// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
    /// </summary>
    [JsonPropertyName("osDiskType")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesOsDiskTypeEnum? OsDiskType { get; set; }

    /// <summary>
    /// OsSKU: Specifies the OS SKU used by the agent pool. The default is Ubuntu if OSType is Linux. The default is Windows2019
    /// when  Kubernetes &lt;= 1.24 or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    [JsonPropertyName("osSKU")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesOsSKUEnum? OsSKU { get; set; }

    /// <summary>OsType: The operating system type. The default is Linux.</summary>
    [JsonPropertyName("osType")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
    /// podSubnetId. The default is  &apos;DynamicIndividual&apos;.
    /// </summary>
    [JsonPropertyName("podIPAllocationMode")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesPodIPAllocationModeEnum? PodIPAllocationMode { get; set; }

    /// <summary>
    /// PodSubnetReference: The ID of the subnet which pods will join when launched. If omitted, pod IPs are statically assigned
    /// on the node subnet (see vnetSubnetID for more details). This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
    /// </summary>
    [JsonPropertyName("podSubnetReference")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>
    /// PowerState: Whether the Agent Pool is running or stopped. When an Agent Pool is first created it is initially Running.
    /// The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not
    /// accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded
    /// </summary>
    [JsonPropertyName("powerState")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

    /// <summary>
    /// ScaleDownMode: The scale down mode to use when scaling the Agent Pool. This also effects the cluster autoscaler
    /// behavior. If not specified, it defaults to Delete.
    /// </summary>
    [JsonPropertyName("scaleDownMode")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesScaleDownModeEnum? ScaleDownMode { get; set; }

    /// <summary>
    /// ScaleSetEvictionPolicy: The Virtual Machine Scale Set eviction policy to use. This cannot be specified unless the
    /// scaleSetPriority is &apos;Spot&apos;. If not specified, the default is &apos;Delete&apos;.
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesScaleSetEvictionPolicyEnum? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesScaleSetPriorityEnum? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

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
    public V1api20250801ManagedClusterSpecAgentPoolProfilesTypeEnum? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

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
    public V1api20250801ManagedClusterSpecAgentPoolProfilesVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public V1api20250801ManagedClusterSpecAgentPoolProfilesWorkloadRuntimeEnum? WorkloadRuntime { get; set; }
}

/// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAiToolchainOperatorProfile
{
    /// <summary>Enabled: Whether to enable AI toolchain operator to the cluster. Indicates if AI toolchain operator  enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// SubnetReference: The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new
/// cluster with BYO Vnet, or when updating an existing cluster to enable apiserver vnet integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecApiServerAccessProfileSubnetReference
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

/// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecApiServerAccessProfile
{
    /// <summary>
    /// AuthorizedIPRanges: The IP ranges authorized to access the Kubernetes API server. IP ranges are specified in CIDR
    /// format, e.g. 137.117.106.88/29. This feature is not compatible with clusters that use Public IP Per Node, or clusters
    /// that are using a Basic Load Balancer. For more information see [API server authorized IP
    /// ranges](https://docs.microsoft.com/azure/aks/api-server-authorized-ip-ranges).
    /// </summary>
    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    /// <summary>DisableRunCommand: Whether to disable run command for the cluster or not.</summary>
    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    /// <summary>
    /// EnablePrivateCluster: Whether to create the cluster as a private cluster or not. For more details, see [Creating a
    /// private AKS cluster](https://docs.microsoft.com/azure/aks/private-clusters).
    /// </summary>
    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    /// <summary>EnablePrivateClusterPublicFQDN: Whether to create additional public FQDN for private cluster or not.</summary>
    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    /// <summary>
    /// EnableVnetIntegration: Whether to enable apiserver vnet integration for the cluster or not. See
    /// aka.ms/AksVnetIntegration for more details.
    /// </summary>
    [JsonPropertyName("enableVnetIntegration")]
    public bool? EnableVnetIntegration { get; set; }

    /// <summary>
    /// PrivateDNSZone: The private DNS zone mode for the cluster. The default is System. For more details see [configure
    /// private DNS zone](https://docs.microsoft.com/azure/aks/private-clusters#configure-private-dns-zone). Allowed values are
    /// &apos;system&apos; and &apos;none&apos;.
    /// </summary>
    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }

    /// <summary>
    /// SubnetReference: The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new
    /// cluster with BYO Vnet, or when updating an existing cluster to enable apiserver vnet integration.
    /// </summary>
    [JsonPropertyName("subnetReference")]
    public V1api20250801ManagedClusterSpecApiServerAccessProfileSubnetReference? SubnetReference { get; set; }
}

/// <summary>
/// Expander: The expander to use when scaling up. If not specified, the default is &apos;random&apos;. See
/// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more
/// information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAutoScalerProfileExpanderEnum>))]
public enum V1api20250801ManagedClusterSpecAutoScalerProfileExpanderEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAutoScalerProfile
{
    /// <summary>
    /// BalanceSimilarNodeGroups: Detects similar node pools and balances the number of nodes between them. Valid values are
    /// &apos;true&apos; and &apos;false&apos;
    /// </summary>
    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    /// <summary>
    /// DaemonsetEvictionForEmptyNodes: DaemonSet pods will be gracefully terminated from empty nodes. If set to true, all
    /// daemonset pods on empty nodes will be evicted before deletion of the node. If the daemonset pod cannot be evicted
    /// another node will be chosen for scaling. If set to false, the node will be deleted without ensuring that daemonset pods
    /// are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    /// <summary>
    /// DaemonsetEvictionForOccupiedNodes: DaemonSet pods will be gracefully terminated from non-empty nodes. If set to true,
    /// all daemonset pods on occupied nodes will be evicted before deletion of the node. If the daemonset pod cannot be evicted
    /// another node will be chosen for scaling. If set to false, the node will be deleted without ensuring that daemonset pods
    /// are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    /// <summary>
    /// Expander: The expander to use when scaling up. If not specified, the default is &apos;random&apos;. See
    /// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more
    /// information.
    /// </summary>
    [JsonPropertyName("expander")]
    public V1api20250801ManagedClusterSpecAutoScalerProfileExpanderEnum? Expander { get; set; }

    /// <summary>
    /// IgnoreDaemonsetsUtilization: Should CA ignore DaemonSet pods when calculating resource utilization for scaling down. If
    /// set to true, the resources used by daemonset will be taken into account when making scaling down decisions.
    /// </summary>
    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    /// <summary>
    /// MaxEmptyBulkDelete: The maximum number of empty nodes that can be deleted at the same time. This must be a positive
    /// integer. The default is 10.
    /// </summary>
    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    /// <summary>
    /// MaxGracefulTerminationSec: The maximum number of seconds the cluster autoscaler waits for pod termination when trying to
    /// scale down a node. The default is 600.
    /// </summary>
    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary>
    /// MaxNodeProvisionTime: The maximum time the autoscaler waits for a node to be provisioned. The default is &apos;15m&apos;. Values
    /// must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    /// <summary>
    /// MaxTotalUnreadyPercentage: The maximum percentage of unready nodes in the cluster. After this percentage is exceeded,
    /// cluster autoscaler halts operations. The default is 45. The maximum is 100 and the minimum is 0.
    /// </summary>
    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    /// <summary>
    /// NewPodScaleUpDelay: Ignore unscheduled pods before they&apos;re a certain age. For scenarios like burst/batch scale where you
    /// don&apos;t want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled
    /// pods before they&apos;re a certain age. The default is &apos;0s&apos;. Values must be an integer followed by a unit (&apos;s&apos; for seconds,
    /// &apos;m&apos; for minutes, &apos;h&apos; for hours, etc).
    /// </summary>
    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary>
    /// OkTotalUnreadyCount: The number of allowed unready nodes, irrespective of max-total-unready-percentage. This must be an
    /// integer. The default is 3.
    /// </summary>
    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterAdd: How long after scale up that scale down evaluation resumes. The default is &apos;10m&apos;. Values must be
    /// an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterDelete: How long after node deletion that scale down evaluation resumes. The default is the
    /// scan-interval. Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterFailure: How long after scale down failure that scale down evaluation resumes. The default is &apos;3m&apos;.
    /// Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary>
    /// ScaleDownUnneededTime: How long a node should be unneeded before it is eligible for scale down. The default is &apos;10m&apos;.
    /// Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    /// <summary>
    /// ScaleDownUnreadyTime: How long an unready node should be unneeded before it is eligible for scale down. The default is
    /// &apos;20m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    /// <summary>
    /// ScaleDownUtilizationThreshold: Node utilization level, defined as sum of requested resources divided by capacity, below
    /// which a node can be considered for scale down. The default is &apos;0.5&apos;.
    /// </summary>
    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary>
    /// ScanInterval: How often cluster is reevaluated for scale up or down. The default is &apos;10&apos;. Values must be an integer
    /// number of seconds.
    /// </summary>
    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    /// <summary>
    /// SkipNodesWithLocalStorage: If cluster autoscaler will skip deleting nodes with pods with local storage, for example,
    /// EmptyDir or HostPath. The default is true.
    /// </summary>
    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    /// <summary>
    /// SkipNodesWithSystemPods: If cluster autoscaler will skip deleting nodes with pods from kube-system (except for DaemonSet
    /// or mirror pods). The default is true.
    /// </summary>
    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>NodeOSUpgradeChannel: Node OS Upgrade Channel. Manner in which the OS on your nodes is updated. The default is NodeImage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum>))]
public enum V1api20250801ManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum
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
/// UpgradeChannel: The upgrade channel for auto upgrade. The default is &apos;none&apos;. For more information see [setting the AKS
/// cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum>))]
public enum V1api20250801ManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAutoUpgradeProfile
{
    /// <summary>NodeOSUpgradeChannel: Node OS Upgrade Channel. Manner in which the OS on your nodes is updated. The default is NodeImage.</summary>
    [JsonPropertyName("nodeOSUpgradeChannel")]
    public V1api20250801ManagedClusterSpecAutoUpgradeProfileNodeOSUpgradeChannelEnum? NodeOSUpgradeChannel { get; set; }

    /// <summary>
    /// UpgradeChannel: The upgrade channel for auto upgrade. The default is &apos;none&apos;. For more information see [setting the AKS
    /// cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
    /// </summary>
    [JsonPropertyName("upgradeChannel")]
    public V1api20250801ManagedClusterSpecAutoUpgradeProfileUpgradeChannelEnum? UpgradeChannel { get; set; }
}

/// <summary>
/// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
///  kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAzureMonitorProfileMetrics
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
    public V1api20250801ManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecAzureMonitorProfile
{
    /// <summary>
    /// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V1api20250801ManagedClusterSpecAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>ArtifactSource: The artifact source. The source where the artifacts are downloaded from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecBootstrapProfileArtifactSourceEnum>))]
public enum V1api20250801ManagedClusterSpecBootstrapProfileArtifactSourceEnum
{
    [EnumMember(Value = "Cache"), JsonStringEnumMemberName("Cache")]
    Cache,
    [EnumMember(Value = "Direct"), JsonStringEnumMemberName("Direct")]
    Direct
}

/// <summary>
/// ContainerRegistryReference: The resource Id of Azure Container Registry. The registry must have private network access,
/// premium SKU and zone redundancy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecBootstrapProfileContainerRegistryReference
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

/// <summary>BootstrapProfile: Profile of the cluster bootstrap configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecBootstrapProfile
{
    /// <summary>ArtifactSource: The artifact source. The source where the artifacts are downloaded from.</summary>
    [JsonPropertyName("artifactSource")]
    public V1api20250801ManagedClusterSpecBootstrapProfileArtifactSourceEnum? ArtifactSource { get; set; }

    /// <summary>
    /// ContainerRegistryReference: The resource Id of Azure Container Registry. The registry must have private network access,
    /// premium SKU and zone redundancy.
    /// </summary>
    [JsonPropertyName("containerRegistryReference")]
    public V1api20250801ManagedClusterSpecBootstrapProfileContainerRegistryReference? ContainerRegistryReference { get; set; }
}

/// <summary>
/// DiskEncryptionSetReference: The Resource ID of the disk encryption set to use for enabling encryption at rest. This is
/// of the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecDiskEncryptionSetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecExtendedLocationTypeEnum>))]
public enum V1api20250801ManagedClusterSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20250801ManagedClusterSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecHttpProxyConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityDelegatedResourcesResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityDelegatedResources
{
    /// <summary>Location: The source resource location - internal use only.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ReferralResource: The delegation id of the referral delegation (optional) - internal use only.</summary>
    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20250801ManagedClusterSpecIdentityDelegatedResourcesResourceReference? ResourceReference { get; set; }

    /// <summary>TenantId: The tenant id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Type: The type of identity used for the managed cluster. For more information see [use managed identities in
/// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecIdentityTypeEnum>))]
public enum V1api20250801ManagedClusterSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20250801ManagedClusterSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the managed cluster, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentity
{
    /// <summary>
    /// DelegatedResources: The delegated identity resources assigned to this managed cluster. This can only be set by another
    /// Azure Resource Provider, and managed cluster only accept one delegated identity resource. Internal use only.
    /// </summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V1api20250801ManagedClusterSpecIdentityDelegatedResources>? DelegatedResources { get; set; }

    /// <summary>
    /// Type: The type of identity used for the managed cluster. For more information see [use managed identities in
    /// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20250801ManagedClusterSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The user identity associated with the managed cluster. This identity will be used in control
    /// plane. Only one user assigned identity is allowed. The keys must be ARM resource IDs in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20250801ManagedClusterSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityProfileClientIdFromConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityProfileObjectIdFromConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityProfileResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIdentityProfile
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20250801ManagedClusterSpecIdentityProfileClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20250801ManagedClusterSpecIdentityProfileObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20250801ManagedClusterSpecIdentityProfileResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences
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

/// <summary>DefaultIngressControllerType: Ingress type for the default NginxIngressController custom resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecIngressProfileWebAppRoutingNginxDefaultIngressControllerTypeEnum>))]
public enum V1api20250801ManagedClusterSpecIngressProfileWebAppRoutingNginxDefaultIngressControllerTypeEnum
{
    [EnumMember(Value = "AnnotationControlled"), JsonStringEnumMemberName("AnnotationControlled")]
    AnnotationControlled,
    [EnumMember(Value = "External"), JsonStringEnumMemberName("External")]
    External,
    [EnumMember(Value = "Internal"), JsonStringEnumMemberName("Internal")]
    Internal,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// Nginx: Configuration for the default NginxIngressController. See more at
/// https://learn.microsoft.com/en-us/azure/aks/app-routing-nginx-configuration#the-default-nginx-ingress-controller.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIngressProfileWebAppRoutingNginx
{
    /// <summary>DefaultIngressControllerType: Ingress type for the default NginxIngressController custom resource</summary>
    [JsonPropertyName("defaultIngressControllerType")]
    public V1api20250801ManagedClusterSpecIngressProfileWebAppRoutingNginxDefaultIngressControllerTypeEnum? DefaultIngressControllerType { get; set; }
}

/// <summary>
/// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
/// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIngressProfileWebAppRouting
{
    /// <summary>
    /// DnsZoneResourceReferences: Resource IDs of the DNS zones to be associated with the Application Routing add-on. Used only
    /// when Application Routing add-on is enabled. Public and private DNS zones can be in different resource groups, but all
    /// public DNS zones must be in the same resource group and all private DNS zones must be in the same resource group.
    /// </summary>
    [JsonPropertyName("dnsZoneResourceReferences")]
    public IList<V1api20250801ManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences>? DnsZoneResourceReferences { get; set; }

    /// <summary>Enabled: Whether to enable the Application Routing add-on.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Nginx: Configuration for the default NginxIngressController. See more at
    /// https://learn.microsoft.com/en-us/azure/aks/app-routing-nginx-configuration#the-default-nginx-ingress-controller.
    /// </summary>
    [JsonPropertyName("nginx")]
    public V1api20250801ManagedClusterSpecIngressProfileWebAppRoutingNginx? Nginx { get; set; }
}

/// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecIngressProfile
{
    /// <summary>
    /// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
    /// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V1api20250801ManagedClusterSpecIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecLinuxProfileSshPublicKeys
{
    /// <summary>
    /// KeyData: Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or
    /// without headers.
    /// </summary>
    [JsonPropertyName("keyData")]
    public required string KeyData { get; set; }
}

/// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecLinuxProfileSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified.</summary>
    [JsonPropertyName("publicKeys")]
    public required IList<V1api20250801ManagedClusterSpecLinuxProfileSshPublicKeys> PublicKeys { get; set; }
}

/// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecLinuxProfile
{
    /// <summary>AdminUsername: The administrator username to use for Linux VMs.</summary>
    [JsonPropertyName("adminUsername")]
    public required string AdminUsername { get; set; }

    /// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public required V1api20250801ManagedClusterSpecLinuxProfileSsh Ssh { get; set; }
}

/// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecMetricsProfileCostAnalysis
{
    /// <summary>
    /// Enabled: Whether to enable cost analysis. The Managed Cluster sku.tier must be set to &apos;Standard&apos; or &apos;Premium&apos; to enable
    /// this feature. Enabling this will add Kubernetes Namespace and Deployment details to the Cost Analysis views in the Azure
    /// portal. If not specified, the default is false. For more information see aka.ms/aks/docs/cost-analysis.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecMetricsProfile
{
    /// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
    [JsonPropertyName("costAnalysis")]
    public V1api20250801ManagedClusterSpecMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>Enabled: Indicates the enablement of Advanced Networking observability functionalities on clusters.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// AdvancedNetworkPolicies: Enable advanced network policies. This allows users to configure Layer 7 network policies
/// (FQDN, HTTP, Kafka). Policies themselves must be configured via the Cilium Network Policy resources, see
/// https://docs.cilium.io/en/latest/security/policy/index.html. This can be enabled only on cilium-based clusters. If not
/// specified, the default value is FQDN if security.enabled is set to true.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityAdvancedNetworkPoliciesEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityAdvancedNetworkPoliciesEnum
{
    [EnumMember(Value = "FQDN"), JsonStringEnumMemberName("FQDN")]
    FQDN,
    [EnumMember(Value = "L7"), JsonStringEnumMemberName("L7")]
    L7,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>
    /// AdvancedNetworkPolicies: Enable advanced network policies. This allows users to configure Layer 7 network policies
    /// (FQDN, HTTP, Kafka). Policies themselves must be configured via the Cilium Network Policy resources, see
    /// https://docs.cilium.io/en/latest/security/policy/index.html. This can be enabled only on cilium-based clusters. If not
    /// specified, the default value is FQDN if security.enabled is set to true.
    /// </summary>
    [JsonPropertyName("advancedNetworkPolicies")]
    public V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworkingSecurityAdvancedNetworkPoliciesEnum? AdvancedNetworkPolicies { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworking
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
    public V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileIpFamiliesEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>BackendPoolType: The type of the managed inbound Load Balancer BackendPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum
{
    [EnumMember(Value = "NodeIP"), JsonStringEnumMemberName("NodeIP")]
    NodeIP,
    [EnumMember(Value = "NodeIPConfiguration"), JsonStringEnumMemberName("NodeIPConfiguration")]
    NodeIPConfiguration
}

/// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference? Reference { get; set; }
}

/// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PublicIPPrefixes: A list of public IP prefix resources.</summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference? Reference { get; set; }
}

/// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PublicIPs: A list of public IP resources.</summary>
    [JsonPropertyName("publicIPs")]
    public IList<V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfile
{
    /// <summary>
    /// AllocatedOutboundPorts: The desired number of allocated SNAT ports per VM. Allowed values are in the range of 0 to 64000
    /// (inclusive). The default value is 0 which results in Azure dynamically allocating ports.
    /// </summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>BackendPoolType: The type of the managed inbound Load Balancer BackendPool.</summary>
    [JsonPropertyName("backendPoolType")]
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileBackendPoolTypeEnum? BackendPoolType { get; set; }

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
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPs")]
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>
/// LoadBalancerSku: The load balancer sku for the managed cluster. The default is &apos;standard&apos;. See [Azure Load Balancer
/// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
/// balancer SKUs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerSkuEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerSkuEnum
{
    [EnumMember(Value = "basic"), JsonStringEnumMemberName("basic")]
    Basic,
    [EnumMember(Value = "standard"), JsonStringEnumMemberName("standard")]
    Standard
}

/// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>
    /// Count: The desired number of outbound IPs created/managed by Azure. Allowed values must be in the range of 1 to 16
    /// (inclusive). The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileNatGatewayProfile
{
    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 4 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V1api20250801ManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileNetworkDataplaneEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileNetworkDataplaneEnum
{
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "cilium"), JsonStringEnumMemberName("cilium")]
    Cilium
}

/// <summary>
/// NetworkMode: The network mode Azure CNI is configured with. This cannot be specified if networkPlugin is anything other
/// than &apos;azure&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileNetworkModeEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileNetworkModeEnum
{
    [EnumMember(Value = "bridge"), JsonStringEnumMemberName("bridge")]
    Bridge,
    [EnumMember(Value = "transparent"), JsonStringEnumMemberName("transparent")]
    Transparent
}

/// <summary>NetworkPlugin: Network plugin used for building the Kubernetes network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileNetworkPluginEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileNetworkPluginEnum
{
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "kubenet"), JsonStringEnumMemberName("kubenet")]
    Kubenet,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>NetworkPluginMode: The mode the network plugin should use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileNetworkPluginModeEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileNetworkPluginModeEnum
{
    [EnumMember(Value = "overlay"), JsonStringEnumMemberName("overlay")]
    Overlay
}

/// <summary>NetworkPolicy: Network policy used for building the Kubernetes network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileNetworkPolicyEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileNetworkPolicyEnum
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
/// OutboundType: The outbound (egress) routing method. This can only be set at cluster creation time and cannot be changed
/// later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNetworkProfileOutboundTypeEnum>))]
public enum V1api20250801ManagedClusterSpecNetworkProfileOutboundTypeEnum
{
    [EnumMember(Value = "loadBalancer"), JsonStringEnumMemberName("loadBalancer")]
    LoadBalancer,
    [EnumMember(Value = "managedNATGateway"), JsonStringEnumMemberName("managedNATGateway")]
    ManagedNATGateway,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "userAssignedNATGateway"), JsonStringEnumMemberName("userAssignedNATGateway")]
    UserAssignedNATGateway,
    [EnumMember(Value = "userDefinedRouting"), JsonStringEnumMemberName("userDefinedRouting")]
    UserDefinedRouting
}

/// <summary>
/// StaticEgressGatewayProfile: The profile for Static Egress Gateway addon. For more details about Static Egress Gateway,
/// see https://aka.ms/aks/static-egress-gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfileStaticEgressGatewayProfile
{
    /// <summary>Enabled: Enable Static Egress Gateway addon. Indicates if Static Egress Gateway addon is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>NetworkProfile: The network configuration profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNetworkProfile
{
    /// <summary>
    /// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
    /// more information see  aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V1api20250801ManagedClusterSpecNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    /// <summary>
    /// DnsServiceIP: An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address
    /// range specified in serviceCidr.
    /// </summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary>
    /// IpFamilies: The IP families used to specify IP versions available to the cluster. IP families are used to determine
    /// single-stack or dual-stack clusters. For single-stack, the expected value is IPv4. For dual-stack, the expected values
    /// are IPv4 and IPv6.
    /// </summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1api20250801ManagedClusterSpecNetworkProfileIpFamiliesEnum>? IpFamilies { get; set; }

    /// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>
    /// LoadBalancerSku: The load balancer sku for the managed cluster. The default is &apos;standard&apos;. See [Azure Load Balancer
    /// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
    /// balancer SKUs.
    /// </summary>
    [JsonPropertyName("loadBalancerSku")]
    public V1api20250801ManagedClusterSpecNetworkProfileLoadBalancerSkuEnum? LoadBalancerSku { get; set; }

    /// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V1api20250801ManagedClusterSpecNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    /// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
    [JsonPropertyName("networkDataplane")]
    public V1api20250801ManagedClusterSpecNetworkProfileNetworkDataplaneEnum? NetworkDataplane { get; set; }

    /// <summary>
    /// NetworkMode: The network mode Azure CNI is configured with. This cannot be specified if networkPlugin is anything other
    /// than &apos;azure&apos;.
    /// </summary>
    [JsonPropertyName("networkMode")]
    public V1api20250801ManagedClusterSpecNetworkProfileNetworkModeEnum? NetworkMode { get; set; }

    /// <summary>NetworkPlugin: Network plugin used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPlugin")]
    public V1api20250801ManagedClusterSpecNetworkProfileNetworkPluginEnum? NetworkPlugin { get; set; }

    /// <summary>NetworkPluginMode: The mode the network plugin should use.</summary>
    [JsonPropertyName("networkPluginMode")]
    public V1api20250801ManagedClusterSpecNetworkProfileNetworkPluginModeEnum? NetworkPluginMode { get; set; }

    /// <summary>NetworkPolicy: Network policy used for building the Kubernetes network.</summary>
    [JsonPropertyName("networkPolicy")]
    public V1api20250801ManagedClusterSpecNetworkProfileNetworkPolicyEnum? NetworkPolicy { get; set; }

    /// <summary>
    /// OutboundType: The outbound (egress) routing method. This can only be set at cluster creation time and cannot be changed
    /// later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
    /// </summary>
    [JsonPropertyName("outboundType")]
    public V1api20250801ManagedClusterSpecNetworkProfileOutboundTypeEnum? OutboundType { get; set; }

    /// <summary>PodCidr: A CIDR notation IP range from which to assign pod IPs when kubenet is used.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>
    /// PodCidrs: The CIDR notation IP ranges from which to assign pod IPs. One IPv4 CIDR is expected for single-stack
    /// networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking.
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
    /// ServiceCidrs: The CIDR notation IP ranges from which to assign service cluster IPs. One IPv4 CIDR is expected for
    /// single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must
    /// not overlap with any Subnet IP ranges.
    /// </summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }

    /// <summary>
    /// StaticEgressGatewayProfile: The profile for Static Egress Gateway addon. For more details about Static Egress Gateway,
    /// see https://aka.ms/aks/static-egress-gateway.
    /// </summary>
    [JsonPropertyName("staticEgressGatewayProfile")]
    public V1api20250801ManagedClusterSpecNetworkProfileStaticEgressGatewayProfile? StaticEgressGatewayProfile { get; set; }
}

/// <summary>
/// DefaultNodePools: The set of default Karpenter NodePools (CRDs) configured for node provisioning. This field has no
/// effect unless mode is &apos;Auto&apos;. Warning: Changing this from Auto to None on an existing cluster will cause the default
/// Karpenter NodePools to be deleted, which will drain and delete the nodes associated with those pools. It is strongly
/// recommended to not do this unless there are idle nodes ready to take the pods evicted by that action. If not specified,
/// the default is Auto. For more information see aka.ms/aks/nap#node-pools.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNodeProvisioningProfileDefaultNodePoolsEnum>))]
public enum V1api20250801ManagedClusterSpecNodeProvisioningProfileDefaultNodePoolsEnum
{
    [EnumMember(Value = "Auto"), JsonStringEnumMemberName("Auto")]
    Auto,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Mode: The node provisioning mode. If not specified, the default is Manual.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNodeProvisioningProfileModeEnum>))]
public enum V1api20250801ManagedClusterSpecNodeProvisioningProfileModeEnum
{
    [EnumMember(Value = "Auto"), JsonStringEnumMemberName("Auto")]
    Auto,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNodeProvisioningProfile
{
    /// <summary>
    /// DefaultNodePools: The set of default Karpenter NodePools (CRDs) configured for node provisioning. This field has no
    /// effect unless mode is &apos;Auto&apos;. Warning: Changing this from Auto to None on an existing cluster will cause the default
    /// Karpenter NodePools to be deleted, which will drain and delete the nodes associated with those pools. It is strongly
    /// recommended to not do this unless there are idle nodes ready to take the pods evicted by that action. If not specified,
    /// the default is Auto. For more information see aka.ms/aks/nap#node-pools.
    /// </summary>
    [JsonPropertyName("defaultNodePools")]
    public V1api20250801ManagedClusterSpecNodeProvisioningProfileDefaultNodePoolsEnum? DefaultNodePools { get; set; }

    /// <summary>Mode: The node provisioning mode. If not specified, the default is Manual.</summary>
    [JsonPropertyName("mode")]
    public V1api20250801ManagedClusterSpecNodeProvisioningProfileModeEnum? Mode { get; set; }
}

/// <summary>
/// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
/// &apos;Unrestricted&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum>))]
public enum V1api20250801ManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum
{
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "Unrestricted"), JsonStringEnumMemberName("Unrestricted")]
    Unrestricted
}

/// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecNodeResourceGroupProfile
{
    /// <summary>
    /// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
    /// &apos;Unrestricted&apos;
    /// </summary>
    [JsonPropertyName("restrictionLevel")]
    public V1api20250801ManagedClusterSpecNodeResourceGroupProfileRestrictionLevelEnum? RestrictionLevel { get; set; }
}

/// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOidcIssuerProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecConfigMapsPrincipalId
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// OIDCIssuerProfile: indicates where the OIDCIssuerProfile config map should be placed. If omitted, no config map will be
    /// created.
    /// </summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20250801ManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>PrincipalId: indicates where the PrincipalId config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("principalId")]
    public V1api20250801ManagedClusterSpecOperatorSpecConfigMapsPrincipalId? PrincipalId { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecSecretsAdminCredentials
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecSecretsUserCredentials
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpecSecrets
{
    /// <summary>
    /// AdminCredentials: indicates where the AdminCredentials secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("adminCredentials")]
    public V1api20250801ManagedClusterSpecOperatorSpecSecretsAdminCredentials? AdminCredentials { get; set; }

    /// <summary>
    /// UserCredentials: indicates where the UserCredentials secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("userCredentials")]
    public V1api20250801ManagedClusterSpecOperatorSpecSecretsUserCredentials? UserCredentials { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250801ManagedClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20250801ManagedClusterSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250801ManagedClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20250801ManagedClusterSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>ClientId: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>ClientIdFromConfig: The client ID of the user assigned identity.</summary>
    [JsonPropertyName("clientIdFromConfig")]
    public V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityClientIdFromConfig? ClientIdFromConfig { get; set; }

    /// <summary>ObjectId: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ObjectIdFromConfig: The object ID of the user assigned identity.</summary>
    [JsonPropertyName("objectIdFromConfig")]
    public V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityObjectIdFromConfig? ObjectIdFromConfig { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference? ResourceReference { get; set; }
}

/// <summary>Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentities
{
    /// <summary>BindingSelector: The binding selector to use for the AzureIdentityBinding resource.</summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Identity: The user assigned identity details.</summary>
    [JsonPropertyName("identity")]
    public required V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity Identity { get; set; }

    /// <summary>Name: The name of the pod identity.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace: The namespace of the pod identity.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// A pod identity exception, which allows pods with certain labels to access the Azure Instance Metadata Service (IMDS)
/// endpoint without being intercepted by the node-managed identity (NMI) server. See [disable AAD Pod Identity for a
/// specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions
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
/// PodIdentityProfile: The pod identity profile of the Managed Cluster. See [use AAD pod
/// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on AAD pod identity
/// integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPodIdentityProfile
{
    /// <summary>
    /// AllowNetworkPluginKubenet: Whether pod identity is allowed to run on clusters with Kubenet networking. Running in
    /// Kubenet is disabled by default due to the security related nature of AAD Pod Identity and the risks of IP spoofing. See
    /// [using Kubenet network plugin with AAD Pod
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
    public IList<V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary>UserAssignedIdentityExceptions: The pod identity exceptions to allow.</summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V1api20250801ManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>Reference: The ID of the private link resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPrivateLinkResourcesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecPrivateLinkResources
{
    /// <summary>GroupId: The group ID of the resource.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name: The name of the private link resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: The ID of the private link resource.</summary>
    [JsonPropertyName("reference")]
    public V1api20250801ManagedClusterSpecPrivateLinkResourcesReference? Reference { get; set; }

    /// <summary>RequiredMembers: The RequiredMembers of the resource</summary>
    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublicNetworkAccess: PublicNetworkAccess of the managedCluster. Allow or deny public network access for AKS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecPublicNetworkAccessEnum>))]
public enum V1api20250801ManagedClusterSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// KeyVaultNetworkAccess: Network access of the key vault. Network access of key vault. The possible values are `Public`
/// and `Private`. `Public` means the key vault allows public access from all networks. `Private` means the key vault
/// disables public access and enables private link. The default value is `Public`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum>))]
public enum V1api20250801ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfileAzureKeyVaultKms
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
    /// KeyVaultNetworkAccess: Network access of the key vault. Network access of key vault. The possible values are `Public`
    /// and `Private`. `Public` means the key vault allows public access from all networks. `Private` means the key vault
    /// disables public access and enables private link. The default value is `Public`.
    /// </summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public V1api20250801ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultNetworkAccessEnum? KeyVaultNetworkAccess { get; set; }

    /// <summary>
    /// KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and
    /// must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
    /// </summary>
    [JsonPropertyName("keyVaultResourceReference")]
    public V1api20250801ManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference? KeyVaultResourceReference { get; set; }
}

/// <summary>
/// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
/// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
/// Microsoft Defender is disabled, leave the field empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>Enabled: Whether to enable Defender threat detection</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfileDefender
{
    /// <summary>
    /// LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft
    /// Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When
    /// Microsoft Defender is disabled, leave the field empty.
    /// </summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceReference")]
    public V1api20250801ManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference? LogAnalyticsWorkspaceResourceReference { get; set; }

    /// <summary>SecurityMonitoring: Microsoft Defender threat detection for Cloud settings for the security profile.</summary>
    [JsonPropertyName("securityMonitoring")]
    public V1api20250801ManagedClusterSpecSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfileImageCleaner
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfileWorkloadIdentity
{
    /// <summary>Enabled: Whether to enable workload identity.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSecurityProfile
{
    /// <summary>
    /// AzureKeyVaultKms: Azure Key Vault [key management
    /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V1api20250801ManagedClusterSpecSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>
    /// CustomCATrustCertificates: A list of up to 10 base64 encoded CAs that will be added to the trust store on all nodes in
    /// the cluster. For more information see [Custom CA Trust
    /// Certificates](https://learn.microsoft.com/en-us/azure/aks/custom-certificate-authority).
    /// </summary>
    [JsonPropertyName("customCATrustCertificates")]
    public IList<string>? CustomCATrustCertificates { get; set; }

    /// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V1api20250801ManagedClusterSpecSecurityProfileDefender? Defender { get; set; }

    /// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V1api20250801ManagedClusterSpecSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
    /// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V1api20250801ManagedClusterSpecSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin
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
    public V1api20250801ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary>RootCertObjectName: Root certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>
/// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
/// certificates as described  here https://aka.ms/asm-plugin-ca
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V1api20250801ManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>Enabled: Whether to enable the egress gateway.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>Mode: Mode of an ingress gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum>))]
public enum V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>Enabled: Whether to enable the ingress gateway.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>Mode: Mode of an ingress gateway.</summary>
    [JsonPropertyName("mode")]
    public required V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGatewaysModeEnum Mode { get; set; }
}

/// <summary>Components: Istio components configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponents
{
    /// <summary>EgressGateways: Istio egress gateways.</summary>
    [JsonPropertyName("egressGateways")]
    public IList<V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary>IngressGateways: Istio ingress gateways.</summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }
}

/// <summary>Istio: Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfileIstio
{
    /// <summary>
    /// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
    /// certificates as described  here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20250801ManagedClusterSpecServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Components: Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V1api20250801ManagedClusterSpecServiceMeshProfileIstioComponents? Components { get; set; }

    /// <summary>
    /// Revisions: The list of revisions of the Istio control plane. When an upgrade is not in progress, this holds one value.
    /// When canary upgrade is in progress, this can only hold two consecutive values. For more information, see:
    /// https://learn.microsoft.com/en-us/azure/aks/istio-upgrade
    /// </summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>Mode: Mode of the service mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecServiceMeshProfileModeEnum>))]
public enum V1api20250801ManagedClusterSpecServiceMeshProfileModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Istio"), JsonStringEnumMemberName("Istio")]
    Istio
}

/// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServiceMeshProfile
{
    /// <summary>Istio: Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V1api20250801ManagedClusterSpecServiceMeshProfileIstio? Istio { get; set; }

    /// <summary>Mode: Mode of the service mesh.</summary>
    [JsonPropertyName("mode")]
    public required V1api20250801ManagedClusterSpecServiceMeshProfileModeEnum Mode { get; set; }
}

/// <summary>Secret: The secret password associated with the service principal in plain text.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServicePrincipalProfileSecret
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecServicePrincipalProfile
{
    /// <summary>ClientId: The ID for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    /// <summary>Secret: The secret password associated with the service principal in plain text.</summary>
    [JsonPropertyName("secret")]
    public V1api20250801ManagedClusterSpecServicePrincipalProfileSecret? Secret { get; set; }
}

/// <summary>Name: The name of a managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecSkuNameEnum>))]
public enum V1api20250801ManagedClusterSpecSkuNameEnum
{
    [EnumMember(Value = "Automatic"), JsonStringEnumMemberName("Automatic")]
    Automatic,
    [EnumMember(Value = "Base"), JsonStringEnumMemberName("Base")]
    Base
}

/// <summary>
/// Tier: The tier of a managed cluster SKU. If not specified, the default is &apos;Free&apos;. See [AKS Pricing
/// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers) for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecSkuTierEnum>))]
public enum V1api20250801ManagedClusterSpecSkuTierEnum
{
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecSku
{
    /// <summary>Name: The name of a managed cluster SKU.</summary>
    [JsonPropertyName("name")]
    public V1api20250801ManagedClusterSpecSkuNameEnum? Name { get; set; }

    /// <summary>
    /// Tier: The tier of a managed cluster SKU. If not specified, the default is &apos;Free&apos;. See [AKS Pricing
    /// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers) for more details.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20250801ManagedClusterSpecSkuTierEnum? Tier { get; set; }
}

/// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecStorageProfileBlobCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureBlob CSI Driver. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecStorageProfileDiskCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureDisk CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecStorageProfileFileCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureFile CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecStorageProfileSnapshotController
{
    /// <summary>Enabled: Whether to enable Snapshot Controller. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecStorageProfile
{
    /// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V1api20250801ManagedClusterSpecStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V1api20250801ManagedClusterSpecStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V1api20250801ManagedClusterSpecStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V1api20250801ManagedClusterSpecStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecSupportPlanEnum>))]
public enum V1api20250801ManagedClusterSpecSupportPlanEnum
{
    [EnumMember(Value = "AKSLongTermSupport"), JsonStringEnumMemberName("AKSLongTermSupport")]
    AKSLongTermSupport,
    [EnumMember(Value = "KubernetesOfficial"), JsonStringEnumMemberName("KubernetesOfficial")]
    KubernetesOfficial
}

/// <summary>OverrideSettings: Settings for overrides.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecUpgradeSettingsOverrideSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecUpgradeSettings
{
    /// <summary>OverrideSettings: Settings for overrides.</summary>
    [JsonPropertyName("overrideSettings")]
    public V1api20250801ManagedClusterSpecUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecWindowsProfileAdminPassword
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecWindowsProfileGmsaProfile
{
    /// <summary>
    /// DnsServer: Specifies the DNS server for Windows gMSA.
    /// Set it to empty if you have configured the DNS server in the vnet which is used to create the managed cluster.
    /// </summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary>Enabled: Whether to enable Windows gMSA. Specifies whether to enable Windows gMSA in the managed cluster.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250801ManagedClusterSpecWindowsProfileLicenseTypeEnum>))]
public enum V1api20250801ManagedClusterSpecWindowsProfileLicenseTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Windows_Server"), JsonStringEnumMemberName("Windows_Server")]
    WindowsServer
}

/// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecWindowsProfile
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
    public V1api20250801ManagedClusterSpecWindowsProfileAdminPassword? AdminPassword { get; set; }

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
    /// EnableCSIProxy: Whether to enable CSI proxy. For more details on CSI proxy, see the [CSI proxy GitHub
    /// repo](https://github.com/kubernetes-csi/csi-proxy).
    /// </summary>
    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
    [JsonPropertyName("gmsaProfile")]
    public V1api20250801ManagedClusterSpecWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    /// <summary>
    /// LicenseType: The license type to use for Windows VMs. See [Azure Hybrid User
    /// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public V1api20250801ManagedClusterSpecWindowsProfileLicenseTypeEnum? LicenseType { get; set; }
}

/// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecWorkloadAutoScalerProfileKeda
{
    /// <summary>Enabled: Whether to enable KEDA.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>Enabled: Whether to enable VPA. Default value is false.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}

/// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpecWorkloadAutoScalerProfile
{
    /// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V1api20250801ManagedClusterSpecWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V1api20250801ManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterSpec
{
    /// <summary>AadProfile: The Azure Active Directory configuration.</summary>
    [JsonPropertyName("aadProfile")]
    public V1api20250801ManagedClusterSpecAadProfile? AadProfile { get; set; }

    /// <summary>AddonProfiles: The profile of managed cluster add-on.</summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V1api20250801ManagedClusterSpecAddonProfiles>? AddonProfiles { get; set; }

    /// <summary>AgentPoolProfiles: The agent pool properties.</summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V1api20250801ManagedClusterSpecAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
    [JsonPropertyName("aiToolchainOperatorProfile")]
    public V1api20250801ManagedClusterSpecAiToolchainOperatorProfile? AiToolchainOperatorProfile { get; set; }

    /// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V1api20250801ManagedClusterSpecApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V1api20250801ManagedClusterSpecAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V1api20250801ManagedClusterSpecAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V1api20250801ManagedClusterSpecAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BootstrapProfile: Profile of the cluster bootstrap configuration.</summary>
    [JsonPropertyName("bootstrapProfile")]
    public V1api20250801ManagedClusterSpecBootstrapProfile? BootstrapProfile { get; set; }

    /// <summary>
    /// DisableLocalAccounts: If local accounts should be disabled on the Managed Cluster. If set to true, getting static
    /// credentials will be disabled for this cluster. This must only be used on Managed Clusters that are AAD enabled. For more
    /// details see [disable local accounts](https://docs.microsoft.com/azure/aks/managed-aad#disable-local-accounts-preview).
    /// </summary>
    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    /// <summary>
    /// DiskEncryptionSetReference: The Resource ID of the disk encryption set to use for enabling encryption at rest. This is
    /// of the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
    /// </summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20250801ManagedClusterSpecDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>DnsPrefix: The DNS prefix of the Managed Cluster. This cannot be updated once the Managed Cluster has been created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>EnableRBAC: Whether to enable Kubernetes Role-Based Access Control.</summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20250801ManagedClusterSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// FqdnSubdomain: The FQDN subdomain of the private cluster with custom private dns zone. This cannot be updated once the
    /// Managed Cluster has been created.
    /// </summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V1api20250801ManagedClusterSpecHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>Identity: The identity of the managed cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20250801ManagedClusterSpecIdentity? Identity { get; set; }

    /// <summary>
    /// IdentityProfile: The user identity associated with the managed cluster. This identity will be used by the kubelet. Only
    /// one user assigned identity is allowed. The only accepted key is &quot;kubeletidentity&quot;, with value of &quot;resourceId&quot;:
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&quot;.
    /// </summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V1api20250801ManagedClusterSpecIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V1api20250801ManagedClusterSpecIngressProfile? IngressProfile { get; set; }

    /// <summary>Kind: This is primarily used to expose different UI experiences in the portal for different kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// KubernetesVersion: The version of Kubernetes specified by the user. Both patch version &lt;major.minor.patch&gt; (e.g.
    /// 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported. When &lt;major.minor&gt; is specified, the latest supported GA patch
    /// version is chosen automatically. Updating the cluster with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x
    /// -&gt; 1.14) will not trigger an upgrade, even if a newer patch version is available. When you upgrade a supported AKS
    /// cluster, Kubernetes minor versions cannot be skipped. All upgrades must be performed sequentially by major version
    /// number. For example, upgrades between 1.14.x -&gt; 1.15.x or 1.15.x -&gt; 1.16.x are allowed, however 1.14.x -&gt; 1.16.x is not
    /// allowed. See [upgrading an AKS cluster](https://docs.microsoft.com/azure/aks/upgrade-cluster) for more details.
    /// </summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
    [JsonPropertyName("linuxProfile")]
    public V1api20250801ManagedClusterSpecLinuxProfile? LinuxProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
    [JsonPropertyName("metricsProfile")]
    public V1api20250801ManagedClusterSpecMetricsProfile? MetricsProfile { get; set; }

    /// <summary>NetworkProfile: The network configuration profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20250801ManagedClusterSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
    [JsonPropertyName("nodeProvisioningProfile")]
    public V1api20250801ManagedClusterSpecNodeProvisioningProfile? NodeProvisioningProfile { get; set; }

    /// <summary>NodeResourceGroup: The name of the resource group containing agent pool nodes.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V1api20250801ManagedClusterSpecNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20250801ManagedClusterSpecOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250801ManagedClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250801ManagedClusterSpecOwner Owner { get; set; }

    /// <summary>
    /// PodIdentityProfile: The pod identity profile of the Managed Cluster. See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on AAD pod identity
    /// integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V1api20250801ManagedClusterSpecPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>PrivateLinkResources: Private link resources associated with the cluster.</summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V1api20250801ManagedClusterSpecPrivateLinkResources>? PrivateLinkResources { get; set; }

    /// <summary>PublicNetworkAccess: PublicNetworkAccess of the managedCluster. Allow or deny public network access for AKS</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20250801ManagedClusterSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20250801ManagedClusterSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V1api20250801ManagedClusterSpecServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
    /// APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20250801ManagedClusterSpecServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Sku: The managed cluster SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20250801ManagedClusterSpecSku? Sku { get; set; }

    /// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20250801ManagedClusterSpecStorageProfile? StorageProfile { get; set; }

    /// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
    [JsonPropertyName("supportPlan")]
    public V1api20250801ManagedClusterSpecSupportPlanEnum? SupportPlan { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20250801ManagedClusterSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20250801ManagedClusterSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V1api20250801ManagedClusterSpecWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>AadProfile: The Azure Active Directory configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAadProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAddonProfilesIdentity
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAddonProfiles
{
    /// <summary>Config: Key-value pairs for configuring an add-on.</summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary>Enabled: Whether the add-on is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identity: Information of user assigned identity used by this add-on.</summary>
    [JsonPropertyName("identity")]
    public V1api20250801ManagedClusterStatusAddonProfilesIdentity? Identity { get; set; }
}

/// <summary>
/// CreationData: CreationData to be used to specify the source Snapshot ID if the node pool will be created/upgraded using
/// a snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesCreationData
{
    /// <summary>SourceResourceId: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>
/// GatewayProfile: Profile specific to a managed agent pool in Gateway mode. This field cannot be set if agent pool mode is
/// not Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesGatewayProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesGpuProfile
{
    /// <summary>Driver: Whether to install GPU drivers. When it&apos;s not specified, default is Install.</summary>
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }
}

/// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesKubeletConfig
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
    /// TopologyManagerPolicy: The Topology Manager policy to use. For more information see [Kubernetes Topology
    /// Manager](https://kubernetes.io/docs/tasks/administer-cluster/topology-manager). The default is &apos;none&apos;. Allowed values
    /// are &apos;none&apos;, &apos;best-effort&apos;, &apos;restricted&apos;, and &apos;single-numa-node&apos;.
    /// </summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesLinuxOSConfig
{
    /// <summary>SwapFileSizeMB: The size in MB of a swap file that will be created on each node.</summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Sysctls: Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

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

/// <summary>The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags
{
    /// <summary>IpTagType: The IP tag type. Example: RoutingPreference.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: The value of the IP tag associated with the public IP. Example: Internet.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesNetworkProfile
{
    /// <summary>AllowedHostPorts: The port ranges that are allowed to access. The specified ranges are allowed to overlap.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>ApplicationSecurityGroups: The IDs of the application security groups which agent pool will associate when created.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    /// <summary>NodePublicIPTags: IPTags of instance-level public IPs.</summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>
/// PowerState: Whether the Agent Pool is running or stopped. When an Agent Pool is first created it is initially Running.
/// The Agent Pool can be stopped by setting this field to Stopped. A stopped Agent Pool stops all of its VMs and does not
/// accrue billing charges. An Agent Pool can only be stopped if it is Running and provisioning state is Succeeded
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>SecurityProfile: The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesSecurityProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: Contains read-only information about the Agent Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesStatus
{
    /// <summary>
    /// ProvisioningError: The error detail information of the agent pool. Preserves the detailed info of failure. If there was
    /// no error, this field is omitted.
    /// </summary>
    [JsonPropertyName("provisioningError")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesUpgradeSettings
{
    /// <summary>
    /// DrainTimeoutInMinutes: The drain timeout for a node. The amount of time (in minutes) to wait on eviction of pods and
    /// graceful termination per node. This eviction wait time honors waiting on pod disruption budgets. If this time is
    /// exceeded, the upgrade fails. If not specified, the default is 30 minutes.
    /// </summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

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

/// <summary>Current status on a group of nodes of the same vm size.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachineNodesStatus
{
    /// <summary>Count: Number of nodes.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Size: The VM size of the agents used to host this group of nodes.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }
}

/// <summary>Specifications on number of machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleManual
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScale
{
    /// <summary>Manual: Specifications on how to scale the VirtualMachines agent pool to a fixed size.</summary>
    [JsonPropertyName("manual")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScaleManual>? Manual { get; set; }
}

/// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachinesProfile
{
    /// <summary>Scale: Specifications on how to scale a VirtualMachines agent pool.</summary>
    [JsonPropertyName("scale")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachinesProfileScale? Scale { get; set; }
}

/// <summary>WindowsProfile: The Windows agent pool&apos;s specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfilesWindowsProfile
{
    /// <summary>
    /// DisableOutboundNat: Whether to disable OutboundNAT in windows nodes. The default value is false. Outbound NAT can only
    /// be disabled if the cluster outboundType is NAT Gateway and the Windows agent pool does not have node public IP enabled.
    /// </summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>Profile for the container service agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAgentPoolProfiles
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
    public V1api20250801ManagedClusterStatusAgentPoolProfilesCreationData? CreationData { get; set; }

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
    /// concurrency per the normal etag convention.
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
    public V1api20250801ManagedClusterStatusAgentPoolProfilesGatewayProfile? GatewayProfile { get; set; }

    /// <summary>GpuInstanceProfile: GPUInstanceProfile to be used to specify GPU MIG instance profile for supported GPU VM SKU.</summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>GpuProfile: GPU settings for the Agent Pool.</summary>
    [JsonPropertyName("gpuProfile")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesGpuProfile? GpuProfile { get; set; }

    /// <summary>
    /// HostGroupID: The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from, used only
    /// in creation scenario and not allowed to changed once set. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    [JsonPropertyName("hostGroupID")]
    public string? HostGroupID { get; set; }

    /// <summary>KubeletConfig: The Kubelet configuration on the agent pool nodes.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary>
    /// KubeletDiskType: Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral
    /// storage.
    /// </summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>LinuxOSConfig: The OS configuration of Linux agent nodes.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

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
    /// information  on agent pool restrictions and best practices, see: https://docs.microsoft.com/azure/aks/use-system-pools
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Name: Unique name of the agent pool profile in the context of the subscription and resource group. Windows agent pool
    /// names must be 6 characters or less.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: Network-related settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeImageVersion: The version of node image</summary>
    [JsonPropertyName("nodeImageVersion")]
    public string? NodeImageVersion { get; set; }

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

    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary>
    /// OsDiskType: The OS disk type to be used for machines in the agent pool. The default is &apos;Ephemeral&apos; if the VM supports it
    /// and has a  cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults to &apos;Managed&apos;. May not be changed after
    /// creation.  For more information see [Ephemeral
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
    /// PodIPAllocationMode: Pod IP Allocation Mode. The IP allocation mode for pods in the agent pool. Must be used with
    /// podSubnetId. The default is  &apos;DynamicIndividual&apos;.
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
    public V1api20250801ManagedClusterStatusAgentPoolProfilesPowerState? PowerState { get; set; }

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
    /// ScaleSetEvictionPolicy: The Virtual Machine Scale Set eviction policy to use. This cannot be specified unless the
    /// scaleSetPriority is &apos;Spot&apos;. If not specified, the default is &apos;Delete&apos;.
    /// </summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public string? ScaleSetEvictionPolicy { get; set; }

    /// <summary>ScaleSetPriority: The Virtual Machine Scale Set priority. If not specified, the default is &apos;Regular&apos;.</summary>
    [JsonPropertyName("scaleSetPriority")]
    public string? ScaleSetPriority { get; set; }

    /// <summary>SecurityProfile: The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

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
    public V1api20250801ManagedClusterStatusAgentPoolProfilesStatus? Status { get; set; }

    /// <summary>Tags: The tags to be persisted on the agent pool virtual machine scale set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Agent Pool.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading the agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    [JsonPropertyName("virtualMachineNodesStatus")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachineNodesStatus>? VirtualMachineNodesStatus { get; set; }

    /// <summary>VirtualMachinesProfile: Specifications on VirtualMachines agent pool.</summary>
    [JsonPropertyName("virtualMachinesProfile")]
    public V1api20250801ManagedClusterStatusAgentPoolProfilesVirtualMachinesProfile? VirtualMachinesProfile { get; set; }

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
    public V1api20250801ManagedClusterStatusAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadRuntime: Determines the type of workload a node can run.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAiToolchainOperatorProfile
{
    /// <summary>Enabled: Whether to enable AI toolchain operator to the cluster. Indicates if AI toolchain operator  enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusApiServerAccessProfile
{
    /// <summary>
    /// AuthorizedIPRanges: The IP ranges authorized to access the Kubernetes API server. IP ranges are specified in CIDR
    /// format, e.g. 137.117.106.88/29. This feature is not compatible with clusters that use Public IP Per Node, or clusters
    /// that are using a Basic Load Balancer. For more information see [API server authorized IP
    /// ranges](https://docs.microsoft.com/azure/aks/api-server-authorized-ip-ranges).
    /// </summary>
    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    /// <summary>DisableRunCommand: Whether to disable run command for the cluster or not.</summary>
    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    /// <summary>
    /// EnablePrivateCluster: Whether to create the cluster as a private cluster or not. For more details, see [Creating a
    /// private AKS cluster](https://docs.microsoft.com/azure/aks/private-clusters).
    /// </summary>
    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    /// <summary>EnablePrivateClusterPublicFQDN: Whether to create additional public FQDN for private cluster or not.</summary>
    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    /// <summary>
    /// EnableVnetIntegration: Whether to enable apiserver vnet integration for the cluster or not. See
    /// aka.ms/AksVnetIntegration for more details.
    /// </summary>
    [JsonPropertyName("enableVnetIntegration")]
    public bool? EnableVnetIntegration { get; set; }

    /// <summary>
    /// PrivateDNSZone: The private DNS zone mode for the cluster. The default is System. For more details see [configure
    /// private DNS zone](https://docs.microsoft.com/azure/aks/private-clusters#configure-private-dns-zone). Allowed values are
    /// &apos;system&apos; and &apos;none&apos;.
    /// </summary>
    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }

    /// <summary>
    /// SubnetId: The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new cluster
    /// with BYO Vnet, or when updating an existing cluster to enable apiserver vnet integration.
    /// </summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAutoScalerProfile
{
    /// <summary>
    /// BalanceSimilarNodeGroups: Detects similar node pools and balances the number of nodes between them. Valid values are
    /// &apos;true&apos; and &apos;false&apos;
    /// </summary>
    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    /// <summary>
    /// DaemonsetEvictionForEmptyNodes: DaemonSet pods will be gracefully terminated from empty nodes. If set to true, all
    /// daemonset pods on empty nodes will be evicted before deletion of the node. If the daemonset pod cannot be evicted
    /// another node will be chosen for scaling. If set to false, the node will be deleted without ensuring that daemonset pods
    /// are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    /// <summary>
    /// DaemonsetEvictionForOccupiedNodes: DaemonSet pods will be gracefully terminated from non-empty nodes. If set to true,
    /// all daemonset pods on occupied nodes will be evicted before deletion of the node. If the daemonset pod cannot be evicted
    /// another node will be chosen for scaling. If set to false, the node will be deleted without ensuring that daemonset pods
    /// are deleted or evicted.
    /// </summary>
    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    /// <summary>
    /// Expander: The expander to use when scaling up. If not specified, the default is &apos;random&apos;. See
    /// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more
    /// information.
    /// </summary>
    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    /// <summary>
    /// IgnoreDaemonsetsUtilization: Should CA ignore DaemonSet pods when calculating resource utilization for scaling down. If
    /// set to true, the resources used by daemonset will be taken into account when making scaling down decisions.
    /// </summary>
    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    /// <summary>
    /// MaxEmptyBulkDelete: The maximum number of empty nodes that can be deleted at the same time. This must be a positive
    /// integer. The default is 10.
    /// </summary>
    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    /// <summary>
    /// MaxGracefulTerminationSec: The maximum number of seconds the cluster autoscaler waits for pod termination when trying to
    /// scale down a node. The default is 600.
    /// </summary>
    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary>
    /// MaxNodeProvisionTime: The maximum time the autoscaler waits for a node to be provisioned. The default is &apos;15m&apos;. Values
    /// must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    /// <summary>
    /// MaxTotalUnreadyPercentage: The maximum percentage of unready nodes in the cluster. After this percentage is exceeded,
    /// cluster autoscaler halts operations. The default is 45. The maximum is 100 and the minimum is 0.
    /// </summary>
    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    /// <summary>
    /// NewPodScaleUpDelay: Ignore unscheduled pods before they&apos;re a certain age. For scenarios like burst/batch scale where you
    /// don&apos;t want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled
    /// pods before they&apos;re a certain age. The default is &apos;0s&apos;. Values must be an integer followed by a unit (&apos;s&apos; for seconds,
    /// &apos;m&apos; for minutes, &apos;h&apos; for hours, etc).
    /// </summary>
    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary>
    /// OkTotalUnreadyCount: The number of allowed unready nodes, irrespective of max-total-unready-percentage. This must be an
    /// integer. The default is 3.
    /// </summary>
    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterAdd: How long after scale up that scale down evaluation resumes. The default is &apos;10m&apos;. Values must be
    /// an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterDelete: How long after node deletion that scale down evaluation resumes. The default is the
    /// scan-interval. Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary>
    /// ScaleDownDelayAfterFailure: How long after scale down failure that scale down evaluation resumes. The default is &apos;3m&apos;.
    /// Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary>
    /// ScaleDownUnneededTime: How long a node should be unneeded before it is eligible for scale down. The default is &apos;10m&apos;.
    /// Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    /// <summary>
    /// ScaleDownUnreadyTime: How long an unready node should be unneeded before it is eligible for scale down. The default is
    /// &apos;20m&apos;. Values must be an integer followed by an &apos;m&apos;. No unit of time other than minutes (m) is supported.
    /// </summary>
    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    /// <summary>
    /// ScaleDownUtilizationThreshold: Node utilization level, defined as sum of requested resources divided by capacity, below
    /// which a node can be considered for scale down. The default is &apos;0.5&apos;.
    /// </summary>
    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary>
    /// ScanInterval: How often cluster is reevaluated for scale up or down. The default is &apos;10&apos;. Values must be an integer
    /// number of seconds.
    /// </summary>
    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    /// <summary>
    /// SkipNodesWithLocalStorage: If cluster autoscaler will skip deleting nodes with pods with local storage, for example,
    /// EmptyDir or HostPath. The default is true.
    /// </summary>
    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    /// <summary>
    /// SkipNodesWithSystemPods: If cluster autoscaler will skip deleting nodes with pods from kube-system (except for DaemonSet
    /// or mirror pods). The default is true.
    /// </summary>
    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAutoUpgradeProfile
{
    /// <summary>NodeOSUpgradeChannel: Node OS Upgrade Channel. Manner in which the OS on your nodes is updated. The default is NodeImage.</summary>
    [JsonPropertyName("nodeOSUpgradeChannel")]
    public string? NodeOSUpgradeChannel { get; set; }

    /// <summary>
    /// UpgradeChannel: The upgrade channel for auto upgrade. The default is &apos;none&apos;. For more information see [setting the AKS
    /// cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
    /// </summary>
    [JsonPropertyName("upgradeChannel")]
    public string? UpgradeChannel { get; set; }
}

/// <summary>
/// KubeStateMetrics: Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the
///  kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAzureMonitorProfileMetrics
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
    public V1api20250801ManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusAzureMonitorProfile
{
    /// <summary>
    /// Metrics: Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes
    /// infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See
    /// aka.ms/AzureManagedPrometheus for an overview.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V1api20250801ManagedClusterStatusAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>BootstrapProfile: Profile of the cluster bootstrap configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusBootstrapProfile
{
    /// <summary>ArtifactSource: The artifact source. The source where the artifacts are downloaded from.</summary>
    [JsonPropertyName("artifactSource")]
    public string? ArtifactSource { get; set; }

    /// <summary>
    /// ContainerRegistryId: The resource Id of Azure Container Registry. The registry must have private network access, premium
    /// SKU and zone redundancy.
    /// </summary>
    [JsonPropertyName("containerRegistryId")]
    public string? ContainerRegistryId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusHttpProxyConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIdentityDelegatedResources
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the managed cluster, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIdentity
{
    /// <summary>
    /// DelegatedResources: The delegated identity resources assigned to this managed cluster. This can only be set by another
    /// Azure Resource Provider, and managed cluster only accept one delegated identity resource. Internal use only.
    /// </summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V1api20250801ManagedClusterStatusIdentityDelegatedResources>? DelegatedResources { get; set; }

    /// <summary>PrincipalId: The principal id of the system assigned identity which is used by master components.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant id of the system assigned identity which is used by master components.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the managed cluster. For more information see [use managed identities in
    /// AKS](https://docs.microsoft.com/azure/aks/use-managed-identity).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The user identity associated with the managed cluster. This identity will be used in control
    /// plane. Only one user assigned identity is allowed. The keys must be ARM resource IDs in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20250801ManagedClusterStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIdentityProfile
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIngressProfileWebAppRoutingIdentity
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
/// Nginx: Configuration for the default NginxIngressController. See more at
/// https://learn.microsoft.com/en-us/azure/aks/app-routing-nginx-configuration#the-default-nginx-ingress-controller.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIngressProfileWebAppRoutingNginx
{
    /// <summary>DefaultIngressControllerType: Ingress type for the default NginxIngressController custom resource</summary>
    [JsonPropertyName("defaultIngressControllerType")]
    public string? DefaultIngressControllerType { get; set; }
}

/// <summary>
/// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
/// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIngressProfileWebAppRouting
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
    public V1api20250801ManagedClusterStatusIngressProfileWebAppRoutingIdentity? Identity { get; set; }

    /// <summary>
    /// Nginx: Configuration for the default NginxIngressController. See more at
    /// https://learn.microsoft.com/en-us/azure/aks/app-routing-nginx-configuration#the-default-nginx-ingress-controller.
    /// </summary>
    [JsonPropertyName("nginx")]
    public V1api20250801ManagedClusterStatusIngressProfileWebAppRoutingNginx? Nginx { get; set; }
}

/// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusIngressProfile
{
    /// <summary>
    /// WebAppRouting: App Routing settings for the ingress profile. You can find an overview and onboarding guide for this
    /// feature at https://learn.microsoft.com/en-us/azure/aks/app-routing?tabs=default%2Cdeploy-app-default.
    /// </summary>
    [JsonPropertyName("webAppRouting")]
    public V1api20250801ManagedClusterStatusIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusLinuxProfileSshPublicKeys
{
    /// <summary>
    /// KeyData: Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or
    /// without headers.
    /// </summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusLinuxProfileSsh
{
    /// <summary>PublicKeys: The list of SSH public keys used to authenticate with Linux-based VMs. A maximum of 1 key may be specified.</summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20250801ManagedClusterStatusLinuxProfileSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusLinuxProfile
{
    /// <summary>AdminUsername: The administrator username to use for Linux VMs.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Ssh: The SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public V1api20250801ManagedClusterStatusLinuxProfileSsh? Ssh { get; set; }
}

/// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusMetricsProfileCostAnalysis
{
    /// <summary>
    /// Enabled: Whether to enable cost analysis. The Managed Cluster sku.tier must be set to &apos;Standard&apos; or &apos;Premium&apos; to enable
    /// this feature. Enabling this will add Kubernetes Namespace and Deployment details to the Cost Analysis views in the Azure
    /// portal. If not specified, the default is false. For more information see aka.ms/aks/docs/cost-analysis.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusMetricsProfile
{
    /// <summary>CostAnalysis: The configuration for detailed per-Kubernetes resource cost analysis.</summary>
    [JsonPropertyName("costAnalysis")]
    public V1api20250801ManagedClusterStatusMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Observability: Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>Enabled: Indicates the enablement of Advanced Networking observability functionalities on clusters.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>
    /// AdvancedNetworkPolicies: Enable advanced network policies. This allows users to configure Layer 7 network policies
    /// (FQDN, HTTP, Kafka). Policies themselves must be configured via the Cilium Network Policy resources, see
    /// https://docs.cilium.io/en/latest/security/policy/index.html. This can be enabled only on cilium-based clusters. If not
    /// specified, the default value is FQDN if security.enabled is set to true.
    /// </summary>
    [JsonPropertyName("advancedNetworkPolicies")]
    public string? AdvancedNetworkPolicies { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileAdvancedNetworking
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
    public V1api20250801ManagedClusterStatusNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Security: Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V1api20250801ManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedOutboundIPs: Desired managed outbound IPs for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PublicIPPrefixes: A list of public IP prefix resources.</summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PublicIPs: A list of public IP resources.</summary>
    [JsonPropertyName("publicIPs")]
    public IList<V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfile
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
    public IList<V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

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
    public V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>OutboundIPPrefixes: Desired outbound IP Prefix resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>OutboundIPs: Desired outbound IP resources for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIPs")]
    public V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs
{
    /// <summary>Id: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>
    /// Count: The desired number of outbound IPs created/managed by Azure. Allowed values must be in the range of 1 to 16
    /// (inclusive). The default value is 1.
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileNatGatewayProfile
{
    /// <summary>EffectiveOutboundIPs: The effective outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20250801ManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: Desired outbound flow idle timeout in minutes. Allowed values are in the range of 4 to 120
    /// (inclusive). The default value is 4 minutes.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>ManagedOutboundIPProfile: Profile of the managed outbound IP resources of the cluster NAT gateway.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V1api20250801ManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>
/// StaticEgressGatewayProfile: The profile for Static Egress Gateway addon. For more details about Static Egress Gateway,
/// see https://aka.ms/aks/static-egress-gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfileStaticEgressGatewayProfile
{
    /// <summary>Enabled: Enable Static Egress Gateway addon. Indicates if Static Egress Gateway addon is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>NetworkProfile: The network configuration profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNetworkProfile
{
    /// <summary>
    /// AdvancedNetworking: Advanced Networking profile for enabling observability and security feature suite on a cluster. For
    /// more information see  aka.ms/aksadvancednetworking.
    /// </summary>
    [JsonPropertyName("advancedNetworking")]
    public V1api20250801ManagedClusterStatusNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    /// <summary>
    /// DnsServiceIP: An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address
    /// range specified in serviceCidr.
    /// </summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary>
    /// IpFamilies: The IP families used to specify IP versions available to the cluster. IP families are used to determine
    /// single-stack or dual-stack clusters. For single-stack, the expected value is IPv4. For dual-stack, the expected values
    /// are IPv4 and IPv6.
    /// </summary>
    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>LoadBalancerProfile: Profile of the cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20250801ManagedClusterStatusNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary>
    /// LoadBalancerSku: The load balancer sku for the managed cluster. The default is &apos;standard&apos;. See [Azure Load Balancer
    /// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load
    /// balancer SKUs.
    /// </summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>NatGatewayProfile: Profile of the cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V1api20250801ManagedClusterStatusNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    /// <summary>NetworkDataplane: Network dataplane used in the Kubernetes cluster.</summary>
    [JsonPropertyName("networkDataplane")]
    public string? NetworkDataplane { get; set; }

    /// <summary>
    /// NetworkMode: The network mode Azure CNI is configured with. This cannot be specified if networkPlugin is anything other
    /// than &apos;azure&apos;.
    /// </summary>
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
    /// OutboundType: The outbound (egress) routing method. This can only be set at cluster creation time and cannot be changed
    /// later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
    /// </summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>PodCidr: A CIDR notation IP range from which to assign pod IPs when kubenet is used.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>
    /// PodCidrs: The CIDR notation IP ranges from which to assign pod IPs. One IPv4 CIDR is expected for single-stack
    /// networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking.
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
    /// ServiceCidrs: The CIDR notation IP ranges from which to assign service cluster IPs. One IPv4 CIDR is expected for
    /// single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must
    /// not overlap with any Subnet IP ranges.
    /// </summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }

    /// <summary>
    /// StaticEgressGatewayProfile: The profile for Static Egress Gateway addon. For more details about Static Egress Gateway,
    /// see https://aka.ms/aks/static-egress-gateway.
    /// </summary>
    [JsonPropertyName("staticEgressGatewayProfile")]
    public V1api20250801ManagedClusterStatusNetworkProfileStaticEgressGatewayProfile? StaticEgressGatewayProfile { get; set; }
}

/// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNodeProvisioningProfile
{
    /// <summary>
    /// DefaultNodePools: The set of default Karpenter NodePools (CRDs) configured for node provisioning. This field has no
    /// effect unless mode is &apos;Auto&apos;. Warning: Changing this from Auto to None on an existing cluster will cause the default
    /// Karpenter NodePools to be deleted, which will drain and delete the nodes associated with those pools. It is strongly
    /// recommended to not do this unless there are idle nodes ready to take the pods evicted by that action. If not specified,
    /// the default is Auto. For more information see aka.ms/aks/nap#node-pools.
    /// </summary>
    [JsonPropertyName("defaultNodePools")]
    public string? DefaultNodePools { get; set; }

    /// <summary>Mode: The node provisioning mode. If not specified, the default is Manual.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusNodeResourceGroupProfile
{
    /// <summary>
    /// RestrictionLevel: The restriction level applied to the cluster&apos;s node resource group. If not specified, the default is
    /// &apos;Unrestricted&apos;
    /// </summary>
    [JsonPropertyName("restrictionLevel")]
    public string? RestrictionLevel { get; set; }
}

/// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusOidcIssuerProfile
{
    /// <summary>Enabled: Whether the OIDC issuer is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>IssuerURL: The OIDC issuer url of the Managed Cluster.</summary>
    [JsonPropertyName("issuerURL")]
    public string? IssuerURL { get; set; }
}

/// <summary>Identity: The user assigned identity details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError
{
    /// <summary>Code: An identifier for the error. Codes are invariant and are intended to be consumed programmatically.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: A list of additional details about the error.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails>? Details { get; set; }

    /// <summary>Message: A message describing the error, intended to be suitable for display in a user interface.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The target of the particular error. For example, the name of the property in error.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: Pod identity assignment error (if any).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError
{
    /// <summary>Error: Details about the error.</summary>
    [JsonPropertyName("error")]
    public V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError? Error { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo
{
    /// <summary>Error: Pod identity assignment error (if any).</summary>
    [JsonPropertyName("error")]
    public V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError? Error { get; set; }
}

/// <summary>Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentities
{
    /// <summary>BindingSelector: The binding selector to use for the AzureIdentityBinding resource.</summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Identity: The user assigned identity details.</summary>
    [JsonPropertyName("identity")]
    public V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity? Identity { get; set; }

    /// <summary>Name: The name of the pod identity.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace: The namespace of the pod identity.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("provisioningInfo")]
    public V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo? ProvisioningInfo { get; set; }

    /// <summary>ProvisioningState: The current provisioning state of the pod identity.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>
/// A pod identity exception, which allows pods with certain labels to access the Azure Instance Metadata Service (IMDS)
/// endpoint without being intercepted by the node-managed identity (NMI) server. See [disable AAD Pod Identity for a
/// specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more
/// details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions
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
/// PodIdentityProfile: The pod identity profile of the Managed Cluster. See [use AAD pod
/// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on AAD pod identity
/// integration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPodIdentityProfile
{
    /// <summary>
    /// AllowNetworkPluginKubenet: Whether pod identity is allowed to run on clusters with Kubenet networking. Running in
    /// Kubenet is disabled by default due to the security related nature of AAD Pod Identity and the risks of IP spoofing. See
    /// [using Kubenet network plugin with AAD Pod
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
    public IList<V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary>UserAssignedIdentityExceptions: The pod identity exceptions to allow.</summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V1api20250801ManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>PowerState: The Power State of the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPowerState
{
    /// <summary>Code: Tells whether the cluster is Running or Stopped</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>A private link resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusPrivateLinkResources
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSecurityProfileAzureKeyVaultKms
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
    /// KeyVaultNetworkAccess: Network access of the key vault. Network access of key vault. The possible values are `Public`
    /// and `Private`. `Public` means the key vault allows public access from all networks. `Private` means the key vault
    /// disables public access and enables private link. The default value is `Public`.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>Enabled: Whether to enable Defender threat detection</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSecurityProfileDefender
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
    public V1api20250801ManagedClusterStatusSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSecurityProfileImageCleaner
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSecurityProfileWorkloadIdentity
{
    /// <summary>Enabled: Whether to enable workload identity.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SecurityProfile: Security profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSecurityProfile
{
    /// <summary>
    /// AzureKeyVaultKms: Azure Key Vault [key management
    /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/) settings for the security profile.
    /// </summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V1api20250801ManagedClusterStatusSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>
    /// CustomCATrustCertificates: A list of up to 10 base64 encoded CAs that will be added to the trust store on all nodes in
    /// the cluster. For more information see [Custom CA Trust
    /// Certificates](https://learn.microsoft.com/en-us/azure/aks/custom-certificate-authority).
    /// </summary>
    [JsonPropertyName("customCATrustCertificates")]
    public IList<string>? CustomCATrustCertificates { get; set; }

    /// <summary>Defender: Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V1api20250801ManagedClusterStatusSecurityProfileDefender? Defender { get; set; }

    /// <summary>ImageCleaner: Image Cleaner settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V1api20250801ManagedClusterStatusSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>
    /// WorkloadIdentity: Workload identity settings for the security profile. Workload identity enables Kubernetes applications
    /// to access Azure cloud resources securely with Azure AD. See https://aka.ms/aks/wi for more details.
    /// </summary>
    [JsonPropertyName("workloadIdentity")]
    public V1api20250801ManagedClusterStatusSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>Plugin: Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V1api20250801ManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>Enabled: Whether to enable the egress gateway.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Istio ingress gateway configuration. For now, we support up to one external ingress gateway named
/// `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>Enabled: Whether to enable the ingress gateway.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Mode: Mode of an ingress gateway.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Components: Istio components configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServiceMeshProfileIstioComponents
{
    /// <summary>EgressGateways: Istio egress gateways.</summary>
    [JsonPropertyName("egressGateways")]
    public IList<V1api20250801ManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary>IngressGateways: Istio ingress gateways.</summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V1api20250801ManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }
}

/// <summary>Istio: Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServiceMeshProfileIstio
{
    /// <summary>
    /// CertificateAuthority: Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin
    /// certificates as described  here https://aka.ms/asm-plugin-ca
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20250801ManagedClusterStatusServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Components: Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V1api20250801ManagedClusterStatusServiceMeshProfileIstioComponents? Components { get; set; }

    /// <summary>
    /// Revisions: The list of revisions of the Istio control plane. When an upgrade is not in progress, this holds one value.
    /// When canary upgrade is in progress, this can only hold two consecutive values. For more information, see:
    /// https://learn.microsoft.com/en-us/azure/aks/istio-upgrade
    /// </summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServiceMeshProfile
{
    /// <summary>Istio: Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V1api20250801ManagedClusterStatusServiceMeshProfileIstio? Istio { get; set; }

    /// <summary>Mode: Mode of the service mesh.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
/// APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusServicePrincipalProfile
{
    /// <summary>ClientId: The ID for the service principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>Sku: The managed cluster SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSku
{
    /// <summary>Name: The name of a managed cluster SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Tier: The tier of a managed cluster SKU. If not specified, the default is &apos;Free&apos;. See [AKS Pricing
    /// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers) for more details.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStatusProvisioningErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStatusProvisioningErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStatusProvisioningErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250801ManagedClusterStatusStatusProvisioningErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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
/// ProvisioningError: The error details information of the managed cluster. Preserves the detailed info of failure. If
/// there was no error, this field is omitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStatusProvisioningError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250801ManagedClusterStatusStatusProvisioningErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250801ManagedClusterStatusStatusProvisioningErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: Contains read-only information about the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStatus
{
    /// <summary>
    /// ProvisioningError: The error details information of the managed cluster. Preserves the detailed info of failure. If
    /// there was no error, this field is omitted.
    /// </summary>
    [JsonPropertyName("provisioningError")]
    public V1api20250801ManagedClusterStatusStatusProvisioningError? ProvisioningError { get; set; }
}

/// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStorageProfileBlobCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureBlob CSI Driver. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStorageProfileDiskCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureDisk CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStorageProfileFileCSIDriver
{
    /// <summary>Enabled: Whether to enable AzureFile CSI Driver. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStorageProfileSnapshotController
{
    /// <summary>Enabled: Whether to enable Snapshot Controller. The default value is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusStorageProfile
{
    /// <summary>BlobCSIDriver: AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V1api20250801ManagedClusterStatusStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>DiskCSIDriver: AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V1api20250801ManagedClusterStatusStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>FileCSIDriver: AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V1api20250801ManagedClusterStatusStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>SnapshotController: Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V1api20250801ManagedClusterStatusStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusSystemData
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusUpgradeSettingsOverrideSettings
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusUpgradeSettings
{
    /// <summary>OverrideSettings: Settings for overrides.</summary>
    [JsonPropertyName("overrideSettings")]
    public V1api20250801ManagedClusterStatusUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusWindowsProfileGmsaProfile
{
    /// <summary>
    /// DnsServer: Specifies the DNS server for Windows gMSA.
    /// Set it to empty if you have configured the DNS server in the vnet which is used to create the managed cluster.
    /// </summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary>Enabled: Whether to enable Windows gMSA. Specifies whether to enable Windows gMSA in the managed cluster.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusWindowsProfile
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
    /// EnableCSIProxy: Whether to enable CSI proxy. For more details on CSI proxy, see the [CSI proxy GitHub
    /// repo](https://github.com/kubernetes-csi/csi-proxy).
    /// </summary>
    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>GmsaProfile: The Windows gMSA Profile in the Managed Cluster.</summary>
    [JsonPropertyName("gmsaProfile")]
    public V1api20250801ManagedClusterStatusWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    /// <summary>
    /// LicenseType: The license type to use for Windows VMs. See [Azure Hybrid User
    /// Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details.
    /// </summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }
}

/// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusWorkloadAutoScalerProfileKeda
{
    /// <summary>Enabled: Whether to enable KEDA.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>Enabled: Whether to enable VPA. Default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatusWorkloadAutoScalerProfile
{
    /// <summary>Keda: KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V1api20250801ManagedClusterStatusWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>VerticalPodAutoscaler: VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V1api20250801ManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

/// <summary>Managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250801ManagedClusterStatus
{
    /// <summary>AadProfile: The Azure Active Directory configuration.</summary>
    [JsonPropertyName("aadProfile")]
    public V1api20250801ManagedClusterStatusAadProfile? AadProfile { get; set; }

    /// <summary>AddonProfiles: The profile of managed cluster add-on.</summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V1api20250801ManagedClusterStatusAddonProfiles>? AddonProfiles { get; set; }

    /// <summary>AgentPoolProfiles: The agent pool properties.</summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V1api20250801ManagedClusterStatusAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>AiToolchainOperatorProfile: AI toolchain operator settings that apply to the whole cluster.</summary>
    [JsonPropertyName("aiToolchainOperatorProfile")]
    public V1api20250801ManagedClusterStatusAiToolchainOperatorProfile? AiToolchainOperatorProfile { get; set; }

    /// <summary>ApiServerAccessProfile: The access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V1api20250801ManagedClusterStatusApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>AutoScalerProfile: Parameters to be applied to the cluster-autoscaler when enabled</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V1api20250801ManagedClusterStatusAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>AutoUpgradeProfile: The auto upgrade configuration.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V1api20250801ManagedClusterStatusAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>AzureMonitorProfile: Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V1api20250801ManagedClusterStatusAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary>
    /// AzurePortalFQDN: The special FQDN used by the Azure Portal to access the Managed Cluster. This FQDN is for use only by
    /// the Azure Portal and should not be used by other clients. The Azure Portal requires certain Cross-Origin Resource
    /// Sharing (CORS) headers to be sent in some responses, which Kubernetes APIServer doesn&apos;t handle by default. This special
    /// FQDN supports CORS, allowing the Azure Portal to function properly.
    /// </summary>
    [JsonPropertyName("azurePortalFQDN")]
    public string? AzurePortalFQDN { get; set; }

    /// <summary>BootstrapProfile: Profile of the cluster bootstrap configuration.</summary>
    [JsonPropertyName("bootstrapProfile")]
    public V1api20250801ManagedClusterStatusBootstrapProfile? BootstrapProfile { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20250801ManagedClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CurrentKubernetesVersion: The version of Kubernetes the Managed Cluster is running. If kubernetesVersion was a fully
    /// specified version &lt;major.minor.patch&gt;, this field will be exactly equal to it. If kubernetesVersion was &lt;major.minor&gt;,
    /// this field will contain the full &lt;major.minor.patch&gt; version being used.
    /// </summary>
    [JsonPropertyName("currentKubernetesVersion")]
    public string? CurrentKubernetesVersion { get; set; }

    /// <summary>
    /// DisableLocalAccounts: If local accounts should be disabled on the Managed Cluster. If set to true, getting static
    /// credentials will be disabled for this cluster. This must only be used on Managed Clusters that are AAD enabled. For more
    /// details see [disable local accounts](https://docs.microsoft.com/azure/aks/managed-aad#disable-local-accounts-preview).
    /// </summary>
    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    /// <summary>
    /// DiskEncryptionSetID: The Resource ID of the disk encryption set to use for enabling encryption at rest. This is of the
    /// form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}&apos;
    /// </summary>
    [JsonPropertyName("diskEncryptionSetID")]
    public string? DiskEncryptionSetID { get; set; }

    /// <summary>DnsPrefix: The DNS prefix of the Managed Cluster. This cannot be updated once the Managed Cluster has been created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>
    /// ETag: Unique read-only string used to implement optimistic concurrency. The eTag value will change when the resource is
    /// updated. Specify an if-match or if-none-match header with the eTag value for a subsequent request to enable optimistic
    /// concurrency per the normal etag convention.
    /// </summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>EnableRBAC: Whether to enable Kubernetes Role-Based Access Control.</summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Virtual Machine.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20250801ManagedClusterStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Fqdn: The FQDN of the master pool.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>
    /// FqdnSubdomain: The FQDN subdomain of the private cluster with custom private dns zone. This cannot be updated once the
    /// Managed Cluster has been created.
    /// </summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>HttpProxyConfig: Configurations for provisioning the cluster with HTTP proxy servers.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V1api20250801ManagedClusterStatusHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the managed cluster, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20250801ManagedClusterStatusIdentity? Identity { get; set; }

    /// <summary>
    /// IdentityProfile: The user identity associated with the managed cluster. This identity will be used by the kubelet. Only
    /// one user assigned identity is allowed. The only accepted key is &quot;kubeletidentity&quot;, with value of &quot;resourceId&quot;:
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&quot;.
    /// </summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V1api20250801ManagedClusterStatusIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>IngressProfile: Ingress profile for the managed cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V1api20250801ManagedClusterStatusIngressProfile? IngressProfile { get; set; }

    /// <summary>Kind: This is primarily used to expose different UI experiences in the portal for different kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// KubernetesVersion: The version of Kubernetes specified by the user. Both patch version &lt;major.minor.patch&gt; (e.g.
    /// 1.20.13) and &lt;major.minor&gt; (e.g. 1.20) are supported. When &lt;major.minor&gt; is specified, the latest supported GA patch
    /// version is chosen automatically. Updating the cluster with the same &lt;major.minor&gt; once it has been created (e.g. 1.14.x
    /// -&gt; 1.14) will not trigger an upgrade, even if a newer patch version is available. When you upgrade a supported AKS
    /// cluster, Kubernetes minor versions cannot be skipped. All upgrades must be performed sequentially by major version
    /// number. For example, upgrades between 1.14.x -&gt; 1.15.x or 1.15.x -&gt; 1.16.x are allowed, however 1.14.x -&gt; 1.16.x is not
    /// allowed. See [upgrading an AKS cluster](https://docs.microsoft.com/azure/aks/upgrade-cluster) for more details.
    /// </summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>LinuxProfile: The profile for Linux VMs in the Managed Cluster.</summary>
    [JsonPropertyName("linuxProfile")]
    public V1api20250801ManagedClusterStatusLinuxProfile? LinuxProfile { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaxAgentPools: The max number of agent pools for the managed cluster.</summary>
    [JsonPropertyName("maxAgentPools")]
    public int? MaxAgentPools { get; set; }

    /// <summary>MetricsProfile: Optional cluster metrics configuration.</summary>
    [JsonPropertyName("metricsProfile")]
    public V1api20250801ManagedClusterStatusMetricsProfile? MetricsProfile { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkProfile: The network configuration profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20250801ManagedClusterStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>NodeProvisioningProfile: Node provisioning settings that apply to the whole cluster.</summary>
    [JsonPropertyName("nodeProvisioningProfile")]
    public V1api20250801ManagedClusterStatusNodeProvisioningProfile? NodeProvisioningProfile { get; set; }

    /// <summary>NodeResourceGroup: The name of the resource group containing agent pool nodes.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>NodeResourceGroupProfile: Profile of the node resource group configuration.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V1api20250801ManagedClusterStatusNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>OidcIssuerProfile: The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20250801ManagedClusterStatusOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>
    /// PodIdentityProfile: The pod identity profile of the Managed Cluster. See [use AAD pod
    /// identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on AAD pod identity
    /// integration.
    /// </summary>
    [JsonPropertyName("podIdentityProfile")]
    public V1api20250801ManagedClusterStatusPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>PowerState: The Power State of the cluster.</summary>
    [JsonPropertyName("powerState")]
    public V1api20250801ManagedClusterStatusPowerState? PowerState { get; set; }

    /// <summary>PrivateFQDN: The FQDN of private cluster.</summary>
    [JsonPropertyName("privateFQDN")]
    public string? PrivateFQDN { get; set; }

    /// <summary>PrivateLinkResources: Private link resources associated with the cluster.</summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V1api20250801ManagedClusterStatusPrivateLinkResources>? PrivateLinkResources { get; set; }

    /// <summary>ProvisioningState: The current provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: PublicNetworkAccess of the managedCluster. Allow or deny public network access for AKS</summary>
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
    public V1api20250801ManagedClusterStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>ServiceMeshProfile: Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V1api20250801ManagedClusterStatusServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>
    /// ServicePrincipalProfile: Information about a service principal identity for the cluster to use for manipulating Azure
    /// APIs.
    /// </summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20250801ManagedClusterStatusServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Sku: The managed cluster SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20250801ManagedClusterStatusSku? Sku { get; set; }

    /// <summary>Status: Contains read-only information about the Managed Cluster.</summary>
    [JsonPropertyName("status")]
    public V1api20250801ManagedClusterStatusStatus? Status { get; set; }

    /// <summary>StorageProfile: Storage profile for the managed cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20250801ManagedClusterStatusStorageProfile? StorageProfile { get; set; }

    /// <summary>SupportPlan: The support plan for the Managed Cluster. If unspecified, the default is &apos;KubernetesOfficial&apos;.</summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20250801ManagedClusterStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpgradeSettings: Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20250801ManagedClusterStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>WindowsProfile: The profile for Windows VMs in the Managed Cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20250801ManagedClusterStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary>WorkloadAutoScalerProfile: Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V1api20250801ManagedClusterStatusWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2025-08-01/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250801ManagedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250801ManagedClusterSpec?>, IStatus<V1api20250801ManagedClusterStatus?>
{
    public const string KubeApiVersion = "v1api20250801";
    public const string KubeKind = "ManagedCluster";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250801";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20250801ManagedClusterSpec? Spec { get; set; }

    /// <summary>Managed cluster.</summary>
    [JsonPropertyName("status")]
    public V1api20250801ManagedClusterStatus? Status { get; set; }
}